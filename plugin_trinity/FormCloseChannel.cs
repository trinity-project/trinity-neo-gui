﻿using Neo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trinity.TrinityDB.Definitions;
using Trinity.Wallets.TransferHandler.TransactionHandler;
using Trinity.Wallets.Event;
using Trinity.Exceptions;
using Neo.Ledger;
using Strings = plugin_trinity.Properties.trinityString;

namespace plugin_trinity
{
    public partial class FormCloseChannel : Form
    {
        private string channelName;
        private string founderUri;
        private string peerUri;
        private string asset;

        public FormCloseChannel (ChannelTableContent channel)
        {
            InitializeComponent();

            this.通道名称textBox.Text = channel.channel;
            this.对端账户textBox.Text = channel.peer;
            this.本段余额textBox.Text = new Fixed8(channel.balance).ToString();
            this.对端余额textBox.Text = new Fixed8(channel.peerBalance).ToString();

            channelName = channel.channel;
            founderUri = channel.uri;
            peerUri = channel.peer;
            asset = channel.asset;
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
            try
            {
                if ((asset.Equals("NEO")) || (asset.Equals("NeoGas")))
                {
                    if (Plugin_trinity.api.CurrentWallet.WalletHeight < Blockchain.Singleton.HeaderHeight)
                    {
                        MessageBox.Show(Strings.InvalidBlockHeight);
                        return;
                    }
                }
                this.CloseChannel(founderUri, peerUri, channelName, asset);
            }
            catch (TrinityException trinityEx)
            {
                MessageBox.Show(trinityEx.Message);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        
        private void CloseChannel(string uri, string peerUri, string channel, string asset)
        {
            // Send Settle Message to Peer
            SettleHandler settleHndl = new SettleHandler(uri, peerUri, channel, asset, null);
            settleHndl.MakeTransaction();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if ((asset.Equals("NEO")) || (asset.Equals("NeoGas")))
                {
                    if (Plugin_trinity.api.CurrentWallet.WalletHeight < Blockchain.Singleton.HeaderHeight)
                    {
                        MessageBox.Show(Strings.InvalidBlockHeight);
                        return;
                    }
                }
                this.ForcedCloseChannel(founderUri, peerUri, channelName, asset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        private void ForcedCloseChannel(string uri, string peerUri, string channel, string asset)
        {
            //Todo: Forced close channel
            CloseChannelEvent closeChannelEventHndl = new CloseChannelEvent(channel, uri);
            closeChannelEventHndl.ForceClosingChannel();
        }
    }
}
