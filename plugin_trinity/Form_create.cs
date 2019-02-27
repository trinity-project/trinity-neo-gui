using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace plugin_trinity
{
    public partial class Form_create : Form
    {
        private string[] channelInfo;

        public Form_create()
        {
            InitializeComponent();
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
            string account = this.网络接入点textBox.Text;
            string deposit = this.通道押金textBox.Text;
            string type = this.资产类型comboBox.SelectedItem.ToString();
            string name = this.通道别名textBox.Text;
            channelInfo = new string[] { account, name, deposit, type};
        }
    }
}
