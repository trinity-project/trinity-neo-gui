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
            this.textBox2.Text = Form_start.getChannelAddress();
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
            string founderAddress = this.textBox2.Text;
            string peerAddress = this.textBox1.Text;
            string deposit = this.通道押金textBox.Text;
            string type = this.资产类型comboBox.SelectedItem.ToString();
            string name = this.通道别名textBox.Text;
            channelInfo = new string[] {name, peerAddress, deposit, type, founderAddress};
        }

    }
}
