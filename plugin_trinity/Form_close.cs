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
    public partial class Form_close : Form
    {
        public Form_close(string channel)
        {
            InitializeComponent();
            string[] destStr = channel.Split(',');
            通道别名textBox.Text = destStr[0];
            对端账户textBox.Text = destStr[1];

            Random ran = new Random();
            int RandKey = ran.Next(100, 999);

            本段余额textBox.Text = RandKey.ToString();
            对端余额textBox.Text = (999 - RandKey).ToString();
        }

        private void 取消button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
