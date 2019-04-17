using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Neo;
using Neo.Cryptography;
using Neo.Wallets;
using Settings = plugin_trinity.Properties.trinitySettings;
using Strings = plugin_trinity.Properties.trinityString;

namespace plugin_trinity
{
    public partial class Form_start : Form
    {
        private static string accountAddress = "";
        private static string accountPublicKey = "";
        private static UInt160 accountScriptHash = null;
        private static string accountURI = "";

        public static UInt160 toScriptHash(string address)
        {
            byte[] data = address.Base58CheckDecode();
            if (data.Length != 21)
                throw new FormatException();
            if (data[0] != Settings.Default.AddressVersion)
                throw new FormatException();
            return new UInt160(data.Skip(1).ToArray());
        }

        public Form_start()
        {
            InitializeComponent();
        }

        public static string getAccountAddress()
        {
            return accountAddress;
        }

        public static string getChannelUri()
        {
            return accountURI;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                UInt160 scriptHash = toScriptHash(comboBox1.SelectedItem.ToString());                              
                WalletAccount account = Plugin_trinity.api.CurrentWallet.GetAccount(scriptHash);

                KeyPair key = account.GetKey();
                accountAddress = account.Address;
                accountPublicKey = key.PublicKey.EncodePoint(true).ToHexString();
                accountScriptHash = account.ScriptHash;

                string[] uriList = { accountPublicKey, Settings.Default.gatewayIP, Settings.Default.gatewayPort };
                accountURI = string.Join(":", uriList);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (accountAddress == "")
            {
                MessageBox.Show(Strings.choiceChannelAddress);
                return;
            }
            try
            {
                //Todo trigger keepAlive message;
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
                    comboBox1.Items.Add(s.Address.ToString());
                }
                comboBox1.SelectedIndex = 0;
                comboBox1.Refresh();
            }
        }
    }
}
