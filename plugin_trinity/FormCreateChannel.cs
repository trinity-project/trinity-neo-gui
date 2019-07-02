using System;
using System.Windows.Forms;
using Trinity.Wallets.TransferHandler.TransactionHandler;
using Trinity.Exceptions;
using Neo;
using System.Collections.Generic;

namespace plugin_trinity
{
    public partial class FormCreateChannel : Form
    {
        private Dictionary<string, string> assetInfos;

        public FormCreateChannel(Dictionary<string, string> assetLists)
        {
            InitializeComponent();
            foreach (var item in assetLists)
            {
                AssetTypeComboBox.Items.Add(item.Key);
            }
            assetInfos = assetLists;
        }

        private void Form_create_Load(object sender, EventArgs e)
        {
            this.textBox2.Text = FormStartTrinity.getChannelUri();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            try
            {
                string founderAddress = this.textBox2.Text;
                string peerAddress = this.textBox1.Text;
                string deposit = this.DepositTextBox.Text;
                string type = this.AssetTypeComboBox.SelectedItem.ToString();

                // Trigger to create channel
                this.CreateChannel(founderAddress, peerAddress, assetInfos[type], deposit);
            }
            catch (TrinityException trinityEx)
            {
                MessageBox.Show(trinityEx.Message);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void CreateChannel(string uri, string peerUri, string asset, string deposit)
        {
            // Send RegisterChannel Messages to peer
            RegisterChannelHandler registerChannelHndl = new RegisterChannelHandler(
                uri, peerUri, null, asset, null, Fixed8.Parse(deposit).GetData());
            registerChannelHndl.MakeTransaction();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
