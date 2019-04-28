using System;
using System.Windows.Forms;
using Neo;
using Neo.Wallets;
using Settings = plugin_trinity.Properties.trinitySettings;
using Strings = plugin_trinity.Properties.trinityString;
using Neo.SmartContract;
using Trinity.ChannelSet;
using Trinity.TrinityDB.Definitions;
using System.Collections.Generic;

using Trinity.Wallets.TransferHandler.ControlHandler;

namespace plugin_trinity
{
    public partial class Form_start : Form
    {
        private static string accountPublicKey = "";
        private static string accountURI = "";

        public Form_start()
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
                                                      Plugin_trinity.api.CurrentWallet, 
                                                      accountPublicKey,
                                                      magic,
                                                      Settings.Default.gatewayIP,
                                                      Settings.Default.gatewayPort);
                //Todo trigger keepAlive message;
                /*
                 * parameter: null
                 */

                RegisterWallet registerWalletHndl = new RegisterWallet(Settings.Default.localIp, Settings.Default.localPort);
                registerWalletHndl.MakeTransaction();
                
                var formMain = new Form_main();
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
                uint magicNeo = Neo.Network.P2P.Message.Magic;
                uint currentMagic = 0;
                if (magicNeo == Settings.Default.neoMagicMainNet)
                {
                    currentMagic = Settings.Default.trinityMagicMainNet;
                }
                else if (magicNeo == Settings.Default.neoMagicTestNet)
                {
                    currentMagic = Settings.Default.trinityMagicTestNet;
                }
                else
                {
                    Exception ex = new Exception("Magic is invalid");
                    throw ex;
                }
                return currentMagic.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

    }
}
