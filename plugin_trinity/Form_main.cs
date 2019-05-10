using System;
using System.Windows.Forms;
using Strings = plugin_trinity.Properties.trinityString;
using Trinity.ChannelSet;
using Trinity.TrinityDB.Definitions;
using System.Collections.Generic;
using Trinity.ChannelSet.Definitions;

using Neo;

namespace plugin_trinity
{
    public partial class Form_main : Form
    {
        private static EnumChannelState showChannelState = EnumChannelState.INIT;
        private ContextMenuStrip menuStrip;
        public Form_main()
        {
            InitializeComponent();
        }

        private void 创建通道button_Click(object sender, EventArgs e)
        {
            using (Form_create formCreate = new Form_create())
            {
                try
                {
                    if (formCreate.ShowDialog() == DialogResult.OK)
                    {
                        /*
                        string info = formCreate.GetChannel();
                        string[] destStr = info.Split(',');

                        ListViewItem channelItem = new ListViewItem(destStr[0]);
                        channelItem.SubItems.Add(destStr[1]);
                        channelItem.SubItems.Add(destStr[2]);
                        channelItem.SubItems.Add(destStr[3]);
                        this.通道列表listView.Items.Add(channelItem);
                        */
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void 拆除通道button_Click(object sender, EventArgs e)
        {
            if (this.通道列表listView.SelectedItems.Count > 0)
            {
                try
                {
                    ListView.SelectedListViewItemCollection channelInfo = this.通道列表listView.SelectedItems;
                    ChannelTableContent deleteChannel = new ChannelTableContent();
                    foreach (ListViewItem item in channelInfo)
                    {
                        deleteChannel.channel = item.SubItems[0].Text;
                        deleteChannel.uri = Form_start.getChannelUri();
                        deleteChannel.peer = item.SubItems[3].Text;
                        deleteChannel.asset = item.SubItems[4].Text;
                        deleteChannel.balance = new Dictionary<string, long>();
                        deleteChannel.balance.Add(deleteChannel.uri, long.Parse(item.SubItems[1].Text));
                        deleteChannel.balance.Add(deleteChannel.peer, long.Parse(item.SubItems[2].Text));
                    }

                    using (Form_close formClose = new Form_close(deleteChannel))
                    {
                        if (formClose.ShowDialog() == DialogResult.OK)
                        {
                            getChannelList();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(Strings.choiceDeleteChannel);
            }
        }

        private void 转账button_Click(object sender, EventArgs e)
        {
            if (this.通道列表listView.SelectedItems.Count > 0)
            {
                try
                {
                    string founderUri = null;
                    string peerUri = null;
                    string transferAmount = null;
                    string assetType = null;

                    founderUri = founderUritextBox.Text;
                    peerUri = peerUritextBox.Text;
                    assetType = assettextBox.Text;
                    transferAmount = accounttextBox.Text;

                    if (string.IsNullOrEmpty(transferAmount))
                    {
                        MessageBox.Show(Strings.invalidTransferParameters);
                        return;
                    }

                    string message = Strings.TransferMessage + peerUri + " " + transferAmount + " " + assetType;
                    string caption = Strings.TransferPromptTitle;
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;
                    result = MessageBox.Show(this, message, caption, buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        /*Todo  transfer asset to special account*/

                        accounttextBox.Text = "";
                        peerUritextBox.Text = "";
                    }
                    else
                    {

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
            else
            {
                MessageBox.Show(Strings.choiceTransferChannel);
            }
        }

        private void 通道列表listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            拆除通道button.Enabled = true;
        }

        private void 通道列表listView_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                ListView.SelectedListViewItemCollection channelInfo = this.通道列表listView.SelectedItems;
                foreach (ListViewItem item in channelInfo)
                {
                    founderUritextBox.Text = Form_start.getChannelUri();
                    peerUritextBox.Text = item.SubItems[3].Text;
                    assettextBox.Text = item.SubItems[4].Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        private void 查询类型comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            查询条件comboBox.Items.Clear();
            switch (this.查询类型comboBox.SelectedIndex)
            {
                case 0:
                    {
                        查询条件comboBox.Items.AddRange(new object[] {Strings.channelOpened,
                            Strings.channelOpened});
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
                        MessageBox.Show(Strings.invalidQueryCondition);
                        break;
                    }
            }
        }

        private void 查询条件comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form_main_Load(object sender, EventArgs e)
        {
            getChannelList();
            //menuStrip = new ContextMenuStrip();//1
            //menuStrip.Items.Add("item1");//2
            //menuStrip.Items.Add("item2"); //3

            this.All.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            this.Opened.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            this.Opening.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            this.Settled.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            this.Settling.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
        }

        private int getChannelNumber()
        {
            Channel channel = new Channel(null, null, Form_start.getChannelUri(), null);
            List<ChannelTableContent> channelList = channel.GetChannelListOfThisWallet();
            return channelList.Count;
        }

        private void getChannelList()
        {
            Channel channel = new Channel(null, null, Form_start.getChannelUri(), null);
            List<ChannelTableContent> channelList = channel.GetChannelListOfThisWallet();
            this.通道列表listView.Items.Clear();

            if (channelList.Count > 0)
            {
                this.通道列表listView.BeginUpdate();
                foreach (ChannelTableContent item in channelList)
                {
                    if (showChannelState.ToString().Equals(EnumChannelState.INIT.ToString()))
                    {
                        string founderBalane = null;
                        string peerBalane = null;
                        foreach (KeyValuePair<string, long> bl in item.balance)
                        {
                            if (bl.Key.Contains(Form_start.getAccountPublic()))
                            {
                                founderBalane = new Fixed8(bl.Value).ToString();
                            }
                            else
                            {
                                peerBalane = new Fixed8(bl.Value).ToString();
                            }
                        }

                        ListViewItem channelItem = new ListViewItem(item.channel);
                        channelItem.SubItems.Add(founderBalane);
                        channelItem.SubItems.Add(peerBalane);
                        channelItem.SubItems.Add(item.peer);
                        channelItem.SubItems.Add(item.asset);
                        channelItem.SubItems.Add(item.state.ToString());
                        this.通道列表listView.Items.Add(channelItem);
                    }
                    else
                    {
                        if (item.state.Equals(showChannelState.ToString()))
                        {
                            string founderBalane = null;
                            string peerBalane = null;
                            foreach (KeyValuePair<string, long> bl in item.balance)
                            {
                                if (bl.Key.Contains(Form_start.getAccountPublic()))
                                {
                                    founderBalane = new Fixed8(bl.Value).ToString();
                                }
                                else
                                {
                                    peerBalane = new Fixed8(bl.Value).ToString();
                                }
                            }

                            ListViewItem channelItem = new ListViewItem(item.channel);
                            channelItem.SubItems.Add(founderBalane);
                            channelItem.SubItems.Add(peerBalane);
                            channelItem.SubItems.Add(item.peer);
                            channelItem.SubItems.Add(item.asset);
                            channelItem.SubItems.Add(item.state.ToString());
                            this.通道列表listView.Items.Add(channelItem);
                        }
                    }
                }
                this.通道列表listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                this.通道列表listView.EndUpdate();
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            getChannelList();
        }

         private void ToolStripMenuItem_Click(object sender, EventArgs e)
         {
              ToolStripMenuItem tsMenumItem = sender as ToolStripMenuItem;
              if (tsMenumItem.Checked)
              {
                  return;//已经选中则返回
              }
              else
              {
                //清除勾选的右键菜单项
                ClearCheckState(channelStatue);
                //勾选鼠标选中的右键菜单项
                  tsMenumItem.Checked = true;
              }
              //设置ListView列表显示样式
              SetDisplayStyle(tsMenumItem.Text);
         }

          private void ClearCheckState(ContextMenuStrip cms)
          {
              ToolStripMenuItem tsMenumItemTemp;
              for (int i = 0; i<cms.Items.Count; i++)
              {
                  if (!(cms.Items[i] is ToolStripMenuItem))
                  {
                      continue;
                  }
                  tsMenumItemTemp = cms.Items[i] as ToolStripMenuItem;
                  if (tsMenumItemTemp.Checked)
                  {
                      tsMenumItemTemp.Checked = false;
                  }
              }
          }
        private void SetDisplayStyle(string name)
        {
            switch (name)
            {
                case "All":
                    showChannelState = EnumChannelState.INIT;
                    break;
                case "Opening":
                    showChannelState = EnumChannelState.OPENING;
                    break;
                case "Opened":
                    showChannelState = EnumChannelState.OPENED;
                    break;
                case "Settling":
                    showChannelState = EnumChannelState.SETTLING;
                    break;
                case "Settled":
                    showChannelState = EnumChannelState.SETTLED;
                    break;
            }
            getChannelList();
        }
    }
}