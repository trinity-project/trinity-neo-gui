using Neo;
using Neo.Core;
using Neo.GUIPlugin;
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
    public partial class Form_main : Form
    {

        public Form_main()
        {
            InitializeComponent();
        }

        private void 创建通道button_Click(object sender, EventArgs e)
        {
            using (Form_create formCreate = new Form_create())
            {
                if (formCreate.ShowDialog() == DialogResult.OK)
                {
                    string info = formCreate.GetChannel();
                    string[] destStr = info.Split(',');
                    
                    ListViewItem channelItem = new ListViewItem(destStr[0]);
                    channelItem.SubItems.Add(destStr[1]);
                    channelItem.SubItems.Add(destStr[2]);
                    channelItem.SubItems.Add(destStr[3]);
                    this.通道列表listView.Items.Add(channelItem);
               }
            }
        }
         
       
        private void 拆除通道button_Click(object sender, EventArgs e)
        {
            var deleteChannel = "";
            int Index = 0;
            if (this.通道列表listView.SelectedItems.Count > 0)
            {
                ListView.SelectedListViewItemCollection channelInfo = this.通道列表listView.SelectedItems;
                foreach (ListViewItem item in channelInfo)
                {
                    deleteChannel = item.SubItems[0].Text + ",";
                    deleteChannel += item.SubItems[1].Text;
                }
                
                using (Form_close formClose = new Form_close(deleteChannel))
                {
                    if (formClose.ShowDialog() == DialogResult.OK)
                    {
                        Index = this.通道列表listView.SelectedItems[0].Index;
                        通道列表listView.Items[Index].Remove();
                    }
                }
            }
        }

        private void 转账button_Click(object sender, EventArgs e)
        {
            try
            {
                string transferNumber = 转账金额textBox.Text;
                string assetTyupe = 资产类型comboBox.SelectedItem.ToString();
                string peerAccount = 对端账户textBox.Text;
                if (string.IsNullOrEmpty(transferNumber) || string.IsNullOrEmpty(peerAccount))
                {
                    MessageBox.Show("请输入完整的信息", "提示");
                    return;
                }

                string message = "发送 " + transferNumber + " " + assetTyupe + " 给 " + peerAccount;
                string caption = "转账交易确认";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(this, message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    转账金额textBox.Text = "";
                    对端账户textBox.Text = "";
                }
                else
                {

                }
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("请选择资产类型", "提示");
                return;
            }
        }

        private void 通道列表listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            拆除通道button.Enabled = true;
        }

        private void 查询类型comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            查询条件comboBox.Items.Clear();
            switch (this.查询类型comboBox.SelectedIndex)
            {               
                case 0:
                    {
                        查询条件comboBox.Items.AddRange(new object[] {"开启",
                            "关闭",
                            "正在开启"});
                        break;
                    }
                case 1:
                    break;
                case 2:
                    {
                        查询条件comboBox.Items.AddRange(new object[] {" <= 100",
                            "> 100"});
                        break;
                    }

                default:
                    {
                        MessageBox.Show("请选择查询条件","查询", MessageBoxButtons.YesNo);
                        break;
                    }
            }
        }

        private void 查询条件comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(this.查询类型comboBox.SelectedItem.ToString() + 查询条件comboBox.SelectedItem.ToString(), "查询条件", MessageBoxButtons.OK);
        }
    }
}