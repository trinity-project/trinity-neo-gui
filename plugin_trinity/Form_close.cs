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
        public Form_close(string channelName)
        {
            InitializeComponent();

            /*
             * ToDo: Query Channel Information
             * parameter: channel name
             * return: string
             */

            /*
            通道名称textBox.Text = channelName;
            对端账户textBox.Text = 
            本段余额textBox.Text = 
            对端余额textBox.Text = 
            */
        }

        private void 取消button_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void 快拆通道button_Click(object sender, EventArgs e)
        {
            /*
             * ToDo: Settle Channel Quickly
             * Parameter: Channenl name (通道名称textBox.Text.ToString())
             *            WalletAccount (Form_start.getWalletAccount())
             * return: boolean
             */
        }
    }
}
