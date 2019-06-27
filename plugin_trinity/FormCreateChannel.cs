using System;
using System.Windows.Forms;
using Trinity.Wallets.TransferHandler.TransactionHandler;
using Trinity.Exceptions;
using Neo;

namespace plugin_trinity
{
    public partial class FormCreateChannel : Form
    {
        public FormCreateChannel()
        {
            InitializeComponent();
        }

        private void Form_create_Load(object sender, EventArgs e)
        {
            this.textBox2.Text = FormStartTrinity.getChannelUri();
        }

        private void 取消button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void 创建button_Click_1(object sender, EventArgs e)
        {
            try
            {
                string founderAddress = this.textBox2.Text;
                string peerAddress = this.textBox1.Text;
                string deposit = this.通道押金textBox.Text;
                string type = this.资产类型comboBox.SelectedItem.ToString();

                // Trigger to create channel
                this.CreateChannel(founderAddress, peerAddress, type, deposit);
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

    }
}
