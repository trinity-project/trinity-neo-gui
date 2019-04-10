using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Neo.Wallets;

namespace plugin_trinity
{
    public partial class Form_create : Form
    {
        private string[] channelInfo;

        public Form_create()
        {
            InitializeComponent();
        }

        private void Form_create_Load(object sender, EventArgs e)
        {
            if (Plugin_trinity.api.CurrentWallet != null)
            {
                var currWallet = Plugin_trinity.api.CurrentWallet;
                foreach (var s in currWallet.GetAccounts())
                {
                    //var addrOut = s.ScriptHash;
                    //string addrStr = addrOut.ToString();

                    网络接入点comboBox1.Items.Add(s.Address.ToString());
                }
                网络接入点comboBox1.SelectedIndex = 0;
                网络接入点comboBox1.Refresh();

            }
        }

        private void 取消button_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        public string GetChannel()
        {     
            return string.Join(",", channelInfo);           
        }   

        private void 创建button_Click_1(object sender, EventArgs e)
        {
            string account = this.网络接入点comboBox1.SelectedItem.ToString();
            string deposit = this.通道押金textBox.Text;
            string type = this.资产类型comboBox.SelectedItem.ToString();
            string name = this.通道别名textBox.Text;
            channelInfo = new string[] { account, name, deposit, type};
        }

    }
}
