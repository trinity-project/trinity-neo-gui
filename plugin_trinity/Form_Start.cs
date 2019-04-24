using System;
using System.Windows.Forms;
using Neo;
using Neo.Wallets;
using Settings = plugin_trinity.Properties.trinitySettings;
using Strings = plugin_trinity.Properties.trinityString;

namespace plugin_trinity
{
    public partial class Form_start : Form
    {
        private static WalletAccount walletAccount = null;
        private static string accountPublicKey = "";
        private static UInt160 accountScriptHash = null;
        private static string accountURI = "";

        public Form_start()
        {
            InitializeComponent();
        }

        public static WalletAccount getWalletAccount()
        {
            return walletAccount;
        }

        public static UInt160 getAccountScriptHash()
        {
            return accountScriptHash;
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
                walletAccount = account;
                accountPublicKey = key.PublicKey.EncodePoint(true).ToHexString();
                accountScriptHash = scriptHash;
                
                accountURI = accountPublicKey + "@" + Settings.Default.gatewayIP + ":"+ Settings.Default.gatewayPort;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (walletAccount == null)
            {
                MessageBox.Show(Strings.choiceChannelAddress);
                return;
            }
            try
            {
                //Todo trigger keepAlive message;
                /*
                 * parameter: null
                 */
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
    }
}
