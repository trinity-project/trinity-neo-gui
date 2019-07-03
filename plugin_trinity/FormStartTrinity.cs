using System;
using System.Windows.Forms;
using Neo;
using Neo.Wallets;
using Trinity.Properties;
using Strings = plugin_trinity.Properties.trinityString;
using Neo.SmartContract;
using Trinity.ChannelSet;
using Trinity.TrinityDB.Definitions;
using System.Collections.Generic;

using Trinity.Wallets.TransferHandler.ControlHandler;

namespace plugin_trinity
{
    public partial class FormStartTrinity : Form
    {
        private static string accountPublicKey = "";
        private static string accountURI = "";

        public FormStartTrinity()
        {
            InitializeComponent();
        }

        public static string getAccountPublic()
        {
            return accountPublicKey;
        }

        public static string getChannelUri()
        {
            return accountURI;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                UInt160 scriptHash = ((string)comboBox1.SelectedItem).ToScriptHash();
                WalletAccount account = Plugin_trinity.api.CurrentWallet.GetAccount(scriptHash);

                KeyPair key = account.GetKey();
                accountPublicKey = key.PublicKey.EncodePoint(true).ToHexString();
                accountURI = accountPublicKey + "@" + Settings.Default.gatewayIP + ":" + Settings.Default.gatewayPort;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (accountPublicKey == null)
            {
                MessageBox.Show(Strings.choiceChannelAddress);
                return;
            }
            try
            {
                string magic = getMagic();
                if (magic == null)
                {
                    return;
                }
                Trinity.startTrinity.trinityConfigure(Plugin_trinity.api.NeoSystem,
                                                      Plugin_trinity.api.NEP5Watched,
                                                      Plugin_trinity.api.CurrentWallet, 
                                                      accountPublicKey,
                                                      magic);

                // Trigger RegisterKeepAlive message to gateway
                this.RegisterToGateway();

                // Trigger SyncWalletData message to gateway
                this.NotifyWalletInfoToGateway(accountPublicKey, magic);
                
                var formMain = new FormMain();
                formMain.ShowDialog();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form_start_Load(object sender, EventArgs e)
        {
            if (Plugin_trinity.api.CurrentWallet != null)
            {
                var currWallet = Plugin_trinity.api.CurrentWallet;
                foreach (var s in currWallet.GetAccounts())
                {
                    if (s.Contract is null)
                    {
                        continue;
                    }
                    if (s.Contract.IsStandard)
                    {
                        comboBox1.Items.Add(s.Address.ToString());
                    }
                }
                comboBox1.SelectedIndex = 0;
                comboBox1.Refresh();
            }
        }
        
        private string getMagic()
        {
            try
            {
                uint neoMagicMainNet = 7630401;
                uint neoMagicTestNet = 1953787457;
                uint trinityMagic = 0;

                uint magicNeo = Neo.Network.P2P.Message.Magic;
                string currentMagic = null;
                if (magicNeo == neoMagicMainNet)
                {
                    trinityMagic = Settings.Default.trinityMagicMainNet;
                    currentMagic = string.Format("{0}{1}",neoMagicMainNet.ToString(),trinityMagic.ToString());
                }
                else if (magicNeo == neoMagicTestNet)
                {
                    trinityMagic = Settings.Default.trinityMagicTestNet;
                    currentMagic = string.Format("{0}{1}", neoMagicTestNet.ToString(), trinityMagic.ToString());
                }
                else
                {
                    Exception ex = new Exception("Magic is invalid");
                    throw ex;
                }
                return currentMagic;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        /// <summary>
        /// this method will inform the gateway the wallet is online
        /// </summary>
        private void RegisterToGateway()
        {
            // Trigger RegisterKeepAlive message to gateway
            RegisterWallet registerWalletHndl = new RegisterWallet();
            registerWalletHndl.MakeTransaction();
        }

        /// <summary>
        /// This method will sync the basic wallet information to the gateway.
        /// </summary>
        private void NotifyWalletInfoToGateway(string pubKey, string magic)
        {
            string sender = pubKey + "@" + Settings.Default.localIp + ":"+ Settings.Default.localPort;
            // Trigger SyncWalletData message to gateway
            SyncWalletHandler syncWalletHndl = new SyncWalletHandler(sender, magic);
            syncWalletHndl.SetPublicKey(pubKey);
            syncWalletHndl.SetAlias("NoAlias");
            syncWalletHndl.SetAutoCreate("0");
            syncWalletHndl.SetNetAddress(Settings.Default.localIp+":"+Settings.Default.localPort);
            syncWalletHndl.SetMaxChannel(10);
            syncWalletHndl.SetChannelInfo();

            syncWalletHndl.MakeTransaction();
        }
    }
}
