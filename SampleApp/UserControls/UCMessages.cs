using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ZulipAPI;
using ZulipAPI.Messages;
using ZulipAPI.Streams;
using ZulipAPI.Users;

namespace SampleApp.UserControls {
    public partial class UCMessages : UserControl {

        private MessageEndPoint msgEndPoint;
        private UserEndPoint userEndPoint;
        private StreamEndPoint streamEndPoint;

        public UCMessages() {
            InitializeComponent();
            InitControls();
            AddHandlers();
            ViewHelpers.DataGridViewHelper.SetDGVProperties(dgvMessages);
            btnGet.Click += btnGet_Click;
        }

        private void AddHandlers() {
            lnkFillCombos.LinkClicked += new LinkLabelLinkClickedEventHandler(lnkFillCombos_LinkClicked);
            btnSendToPrivate.Click += BtnSendToPrivate_Click;
            btnSendToStream.Click += BtnSendToStream_Click;
            dgvMessages.DataError += DgvMessages_DataError;
        }

        private void DgvMessages_DataError(object sender, DataGridViewDataErrorEventArgs e) {
            e.Cancel = true;
        }

        private async void BtnSendToStream_Click(object sender, EventArgs e) {
            if (cboStreams.SelectedValue != null && txtStreamMsg.Text != "" && txtStreamTopic.Text != "") {
                try {
                    await msgEndPoint.SendStreamMessage(cboStreams.SelectedValue.ToString(), txtStreamTopic.Text, txtStreamMsg.Text);
                } catch (Exception ex) {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private async void BtnSendToPrivate_Click(object sender, EventArgs e) {
            if (cboUsers.SelectedValue != null && txtPrivateMsg.Text != "") {
                try {
                    await msgEndPoint.SendPrivateMessage(cboUsers.SelectedValue.ToString(), txtPrivateMsg.Text);
                } catch (Exception ex) {
                    MessageBox.Show(ex.ToString());
                }
            } else { return; }
        }

        private async void btnGet_Click(object sender, System.EventArgs e) {
            await Program.GetZulipClient();
            try {
                var msgs = await msgEndPoint.GetMessages((ulong)numAnchor.Value, (int)numBefore.Value, (int)numAfter.Value);
                dgvMessages.DataSource = msgs;
            } catch (System.Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }

        private void InitControls() {
            msgEndPoint = msgEndPoint ?? Program.client.GetMessageEndPoint();
            userEndPoint = userEndPoint ?? Program.client.GetUserEndPoint();
            streamEndPoint = streamEndPoint ?? Program.client.GetStreamEndPoint();

            txtPrivateMsg.Text = $"new private message sent via .NET client at {DateTime.Now}";
            txtStreamMsg.Text = $"new stream message sent via .NET client at {DateTime.Now}";
            txtStreamTopic.Text = "API Test";
            lblPMResponse.Text = "";
            lblStreamResponse.Text = "";

            toolTip1.SetToolTip(this.numAnchor, "Is the message id from which you want to get x messages before and y messages after.\r\nIf you set Anchor really high (by default) it will automatically use the highest message id available; the most recent one.");
            toolTip1.SetToolTip(this.numBefore, "Number of messages to be retrieve before the anchor message.\r\nIf Anchor is beyond the most recent message, this will retrieve that number of messages.\r\nAfter will have no effect");
            toolTip1.SetToolTip(this.numAfter, "Only useful if you set Anchor to an actcual message id and then get messages after that point,\r\nie. going back to an old topic's first message, then using this to get messages after that.");
        }

        private async void lnkFillCombos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            await Program.GetZulipClient();
            try {

                IList<User> users = await userEndPoint.GetUsers();
                cboUsers.DisplayMember = nameof(User.FullName);
                cboUsers.ValueMember = nameof(User.Email);
                cboUsers.DataSource = users;


                IList<Stream> streams = await streamEndPoint.GetStreams();
                cboStreams.DisplayMember = nameof(Stream.Name);
                cboStreams.ValueMember = nameof(Stream.Name);
                cboStreams.DataSource = streams;

            } catch (System.Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
