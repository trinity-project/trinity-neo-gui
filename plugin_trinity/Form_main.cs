using Neo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Neo.Persistence;
using Neo.Persistence.LevelDB;
using Neo.Network.P2P;
using System.Net;
using Neo.IO.Data.LevelDB;
using System.Threading;
using Neo.IO.Json;
using System.Net.Http;
using System.Net.Http.Headers;

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
            catch (NullReferenceException)
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
                        MessageBox.Show("请选择查询条件", "查询", MessageBoxButtons.YesNo);
                        break;
                    }
            }
        }

        private void 查询条件comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(this.查询类型comboBox.SelectedItem.ToString() + 查询条件comboBox.SelectedItem.ToString(), "查询条件", MessageBoxButtons.OK);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            /*
            LevelDBStore Neostore;
            NeoSystem Neosystem;
            //RpcServer NeoRpcServer;
            Neostore = new LevelDBStore("C:\\Neo");
            Neosystem = new NeoSystem(Neostore);
            Neosystem.StartRpc(10332);
            //NeoRpcServer = new RpcServer(Neosystem);
            //NeoRpcServer.Start(10320);

            //system.StartRpc("127.0.0.1",);
            */

            //DB db = DB.Open("C:\\Neo", new Options { CreateIfMissing = true });
            RpcServer RpcServer = new RpcServer();
            //Thread RpcThread = new Thread(new ThreadStart);
            RpcServer.Start(IPAddress.Parse("0.0.0.0"), 20338);
            //MessageBox.Show(result);
            //Console.WriteLine("按任意键结束:");
            //Console.ReadLine();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            JObject json = new JObject();
            json["jsonrpc"] = "2.0";
            json["method"] = "test";
            json["params"] = new JArray("this is test");
            json["id"] = 1;

            HttpContent httpContent = new StringContent(json.ToString());
            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            httpContent.Headers.ContentType.CharSet = "utf-8";

            HttpClient walletClient = new HttpClient();

            var response = walletClient.PostAsync("http://127.0.0.1:20338", httpContent).Result;

            var responseString = response.Content.ReadAsStringAsync().Result;
            MessageBox.Show(responseString);
        }
    }
}