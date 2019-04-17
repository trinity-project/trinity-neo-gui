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
    public partial class Form_start : Form
    {
        private static string channelAddress = "";

        public Form_start()
        {
            InitializeComponent();
        }

        public static string getChannelAddress()
        {
            return channelAddress;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            channelAddress = comboBox1.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (channelAddress == "")
            {
                MessageBox.Show("Please choise correct channel address");
                return;
            }
            var formMain = new Form_main();
            formMain.ShowDialog();
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
