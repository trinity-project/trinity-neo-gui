using System;
using System.Windows.Forms;
using Strings = plugin_trinity.Properties.trinityString;
using Trinity.ChannelSet;
using Trinity.TrinityDB.Definitions;
using System.Collections.Generic;
using Trinity.ChannelSet.Definitions;
using Trinity.Wallets.TransferHandler.ControlHandler;
using Trinity.Wallets.TransferHandler.TransactionHandler;
using Trinity.Exceptions;

using Neo;
using Neo.Cryptography;
using System.Linq;

namespace plugin_trinity
{
    public partial class FormMain : Form
    {
        private static EnumChannelState showChannelState = EnumChannelState.INIT;
        private Channel channel;
        private string transferChannelName;

        public FormMain()
        {
            InitializeComponent();
        }

        private void 创建通道button_Click(object sender, EventArgs e)
        {
            using (FormCreateChannel formCreate = new FormCreateChannel())
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
                        deleteChannel.uri = FormStartTrinity.getChannelUri();
                        deleteChannel.peer = item.SubItems[3].Text;
                        deleteChannel.asset = item.SubItems[4].Text;

                        deleteChannel.balance = Fixed8.Parse(item.SubItems[1].Text).GetData();
                        deleteChannel.peerBalance = Fixed8.Parse(item.SubItems[2].Text).GetData();
                    }

                    using (FormCloseChannel formClose = new FormCloseChannel(deleteChannel))
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
            //if (this.通道列表listView.SelectedItems.Count > 0)
            if (true)
            {
                try
                {
                    string founderUri = founderUritextBox.Text;
                    string peerUri = peerUritextBox.Text;
                    string assetType = comboBox2.SelectedItem.ToString();
                    string transferAmount = accounttextBox.Text;
                    string channelName = transferChannelName;//this.通道列表listView.SelectedItems[0].SubItems[0].Text;
                    string HashR = null;

                    if (peerUri.Length > 88)
                    {
                        byte[] pamentByte = Base58.Decode(peerUri);
                        string paymentString = System.Text.Encoding.Default.GetString(pamentByte);
                        string[] info = paymentString.Split('&');
                        if (info.Length != 5)
                        {
                            MessageBox.Show(Strings.CheckPaymentCode);
                            return;
                        }
                        peerUri = info[0];
                        HashR = info[1];
                        assetType = info[2];
                        transferAmount = info[3];
                    }
                    else
                    { 
                        if (string.IsNullOrEmpty(transferAmount))
                        {
                            MessageBox.Show(Strings.invalidTransferParameters);
                            return;
                        }
                    }
                    string message = Strings.TransferMessage + peerUri + " " + transferAmount + " " + assetType;
                    string caption = Strings.TransferPromptTitle;
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;
                    result = MessageBox.Show(this, message, caption, buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        try
                        {
                            /*Todo  transfer asset to special account*/
                            TransactionHandler.MakeTransaction(founderUri, peerUri, channelName,
                                assetType, null, 0, Fixed8.Parse(transferAmount).GetData(), HashR);
                            //RsmcHandler rsmcHndl = new RsmcHandler(founderUri, peerUri, channelName,
                            //    assetType, null, 0, Fixed8.Parse(transferAmount).GetData());
                            //rsmcHndl.MakeTransaction();

                            accounttextBox.Text = "";
                            peerUritextBox.Text = "";
                        }
                        catch (TrinityException trinityEx)
                        {
                            MessageBox.Show(trinityEx.Message);
                            return;
                        }
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
                    founderUritextBox.Text = FormStartTrinity.getChannelUri();
                    peerUritextBox.Text = item.SubItems[3].Text;
                    comboBox2.Text = item.SubItems[4].Text;
                    transferChannelName = item.SubItems[0].Text;
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
            channel = new Channel(null, null, FormStartTrinity.getChannelUri(), null);

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
            List<ChannelTableContent> channelList = channel.GetChannelListOfThisWallet();
            return channelList.Count;
        }

        private void getChannelList()
        {
            List<ChannelTableContent> channelList = channel.GetChannelListOfThisWallet();
            this.通道列表listView.Items.Clear();

            if (channelList.Count > 0)
            {
                this.通道列表listView.BeginUpdate();
                foreach (ChannelTableContent item in channelList)
                {
                    if (showChannelState.ToString().Equals(EnumChannelState.INIT.ToString()))
                    {
                        string founderBalane = new Fixed8(item.balance).ToString();
                        string peerBalane = new Fixed8(item.peerBalance).ToString();

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
                            string founderBalane = new Fixed8(item.balance).ToString();
                            string peerBalane = new Fixed8(item.peerBalance).ToString();

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

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            try
            {
                textBox1.Text = Payment.GeneratePaymentCode(FormStartTrinity.getChannelUri(),
                                                            comboBox1.SelectedItem.ToString(),
                                                            textBox2.Text,
                                                            "payment");
            }
            catch (Exception ex)
            {
                textBox1.Text = null;
                MessageBox.Show(ex.Message);
            }
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            uint currentMonitordBlockHeight = 0;

            currentMonitordBlockHeight = channel.TryGetBlockHeight(FormStartTrinity.getChannelUri());
            this.toolStripStatusLabel1.Text = String.Format("{0} : {1}", Strings.monitorBlock, currentMonitordBlockHeight.ToString());
        }
    }
}