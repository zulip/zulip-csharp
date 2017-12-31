namespace SampleApp.UserControls {
    partial class UCMessages {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.dgvMessages = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGet = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel_Send = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblStreamResponse = new System.Windows.Forms.Label();
            this.txtStreamTopic = new System.Windows.Forms.TextBox();
            this.btnSendToStream = new System.Windows.Forms.Button();
            this.cboStreams = new System.Windows.Forms.ComboBox();
            this.txtStreamMsg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel_PMSend = new System.Windows.Forms.Panel();
            this.lblPMResponse = new System.Windows.Forms.Label();
            this.lnkFillCombos = new System.Windows.Forms.LinkLabel();
            this.btnSendToPrivate = new System.Windows.Forms.Button();
            this.cboUsers = new System.Windows.Forms.ComboBox();
            this.txtPrivateMsg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numAnchor = new System.Windows.Forms.NumericUpDown();
            this.numBefore = new System.Windows.Forms.NumericUpDown();
            this.numAfter = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessages)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_Send.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel_PMSend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAnchor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBefore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAfter)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.splitter1);
            this.groupBox1.Controls.Add(this.dgvMessages);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1004, 326);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Message Retrieval";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(301, 16);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 307);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // dgvMessages
            // 
            this.dgvMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMessages.Location = new System.Drawing.Point(301, 16);
            this.dgvMessages.Name = "dgvMessages";
            this.dgvMessages.Size = new System.Drawing.Size(700, 307);
            this.dgvMessages.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtResponse);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 307);
            this.panel1.TabIndex = 5;
            // 
            // txtResponse
            // 
            this.txtResponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResponse.Location = new System.Drawing.Point(0, 57);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResponse.Size = new System.Drawing.Size(298, 250);
            this.txtResponse.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.numBefore);
            this.panel2.Controls.Add(this.numAfter);
            this.panel2.Controls.Add(this.numAnchor);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnGet);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(298, 57);
            this.panel2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Response";
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(82, 28);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(89, 23);
            this.btnGet.TabIndex = 2;
            this.btnGet.Text = "Get Messages";
            this.btnGet.UseVisualStyleBackColor = true;
            // 
            // panel_Send
            // 
            this.panel_Send.Controls.Add(this.tableLayoutPanel1);
            this.panel_Send.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Send.Location = new System.Drawing.Point(0, 326);
            this.panel_Send.Name = "panel_Send";
            this.panel_Send.Size = new System.Drawing.Size(1004, 178);
            this.panel_Send.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel_PMSend, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1004, 178);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblStreamResponse);
            this.panel3.Controls.Add(this.txtStreamTopic);
            this.panel3.Controls.Add(this.btnSendToStream);
            this.panel3.Controls.Add(this.cboStreams);
            this.panel3.Controls.Add(this.txtStreamMsg);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(505, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(496, 172);
            this.panel3.TabIndex = 1;
            // 
            // lblStreamResponse
            // 
            this.lblStreamResponse.AutoSize = true;
            this.lblStreamResponse.Location = new System.Drawing.Point(98, 152);
            this.lblStreamResponse.Name = "lblStreamResponse";
            this.lblStreamResponse.Size = new System.Drawing.Size(35, 13);
            this.lblStreamResponse.TabIndex = 6;
            this.lblStreamResponse.Text = "label9";
            // 
            // txtStreamTopic
            // 
            this.txtStreamTopic.Location = new System.Drawing.Point(245, 34);
            this.txtStreamTopic.Name = "txtStreamTopic";
            this.txtStreamTopic.Size = new System.Drawing.Size(129, 20);
            this.txtStreamTopic.TabIndex = 5;
            // 
            // btnSendToStream
            // 
            this.btnSendToStream.Location = new System.Drawing.Point(391, 32);
            this.btnSendToStream.Name = "btnSendToStream";
            this.btnSendToStream.Size = new System.Drawing.Size(75, 23);
            this.btnSendToStream.TabIndex = 4;
            this.btnSendToStream.Text = "Send";
            this.btnSendToStream.UseVisualStyleBackColor = true;
            // 
            // cboStreams
            // 
            this.cboStreams.FormattingEnabled = true;
            this.cboStreams.Location = new System.Drawing.Point(101, 34);
            this.cboStreams.Name = "cboStreams";
            this.cboStreams.Size = new System.Drawing.Size(138, 21);
            this.cboStreams.TabIndex = 2;
            // 
            // txtStreamMsg
            // 
            this.txtStreamMsg.Location = new System.Drawing.Point(101, 63);
            this.txtStreamMsg.Multiline = true;
            this.txtStreamMsg.Name = "txtStreamMsg";
            this.txtStreamMsg.Size = new System.Drawing.Size(365, 86);
            this.txtStreamMsg.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Message Text";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(242, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Topic";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "to (Stream)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Stream Message";
            // 
            // panel_PMSend
            // 
            this.panel_PMSend.Controls.Add(this.lblPMResponse);
            this.panel_PMSend.Controls.Add(this.lnkFillCombos);
            this.panel_PMSend.Controls.Add(this.btnSendToPrivate);
            this.panel_PMSend.Controls.Add(this.cboUsers);
            this.panel_PMSend.Controls.Add(this.txtPrivateMsg);
            this.panel_PMSend.Controls.Add(this.label3);
            this.panel_PMSend.Controls.Add(this.label2);
            this.panel_PMSend.Controls.Add(this.label1);
            this.panel_PMSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_PMSend.Location = new System.Drawing.Point(3, 3);
            this.panel_PMSend.Name = "panel_PMSend";
            this.panel_PMSend.Size = new System.Drawing.Size(496, 172);
            this.panel_PMSend.TabIndex = 0;
            // 
            // lblPMResponse
            // 
            this.lblPMResponse.AutoSize = true;
            this.lblPMResponse.Location = new System.Drawing.Point(98, 152);
            this.lblPMResponse.Name = "lblPMResponse";
            this.lblPMResponse.Size = new System.Drawing.Size(35, 13);
            this.lblPMResponse.TabIndex = 6;
            this.lblPMResponse.Text = "label9";
            // 
            // lnkFillCombos
            // 
            this.lnkFillCombos.AutoSize = true;
            this.lnkFillCombos.Location = new System.Drawing.Point(273, 42);
            this.lnkFillCombos.Name = "lnkFillCombos";
            this.lnkFillCombos.Size = new System.Drawing.Size(55, 13);
            this.lnkFillCombos.TabIndex = 5;
            this.lnkFillCombos.TabStop = true;
            this.lnkFillCombos.Text = "Fill Combo";
            // 
            // btnSendToPrivate
            // 
            this.btnSendToPrivate.Location = new System.Drawing.Point(391, 33);
            this.btnSendToPrivate.Name = "btnSendToPrivate";
            this.btnSendToPrivate.Size = new System.Drawing.Size(75, 23);
            this.btnSendToPrivate.TabIndex = 4;
            this.btnSendToPrivate.Text = "Send";
            this.btnSendToPrivate.UseVisualStyleBackColor = true;
            // 
            // cboUsers
            // 
            this.cboUsers.FormattingEnabled = true;
            this.cboUsers.Location = new System.Drawing.Point(101, 34);
            this.cboUsers.Name = "cboUsers";
            this.cboUsers.Size = new System.Drawing.Size(166, 21);
            this.cboUsers.TabIndex = 3;
            // 
            // txtPrivateMsg
            // 
            this.txtPrivateMsg.Location = new System.Drawing.Point(101, 63);
            this.txtPrivateMsg.Multiline = true;
            this.txtPrivateMsg.Name = "txtPrivateMsg";
            this.txtPrivateMsg.Size = new System.Drawing.Size(365, 86);
            this.txtPrivateMsg.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Message Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "to (email)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Private Message";
            // 
            // numAnchor
            // 
            this.numAnchor.Location = new System.Drawing.Point(95, 3);
            this.numAnchor.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numAnchor.Name = "numAnchor";
            this.numAnchor.Size = new System.Drawing.Size(76, 20);
            this.numAnchor.TabIndex = 3;
            this.numAnchor.Value = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            // 
            // numBefore
            // 
            this.numBefore.Location = new System.Drawing.Point(230, 3);
            this.numBefore.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numBefore.Name = "numBefore";
            this.numBefore.Size = new System.Drawing.Size(62, 20);
            this.numBefore.TabIndex = 3;
            this.numBefore.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // numAfter
            // 
            this.numAfter.Location = new System.Drawing.Point(230, 29);
            this.numAfter.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numAfter.Name = "numAfter";
            this.numAfter.Size = new System.Drawing.Size(62, 20);
            this.numAfter.TabIndex = 3;
            this.numAfter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Anchor";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(186, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Before";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(186, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "After";
            // 
            // UCMessages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel_Send);
            this.Name = "UCMessages";
            this.Size = new System.Drawing.Size(1004, 504);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessages)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_Send.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel_PMSend.ResumeLayout(false);
            this.panel_PMSend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAnchor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBefore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAfter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridView dgvMessages;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel_Send;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel_PMSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtStreamMsg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrivateMsg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboStreams;
        private System.Windows.Forms.ComboBox cboUsers;
        private System.Windows.Forms.Button btnSendToStream;
        private System.Windows.Forms.Button btnSendToPrivate;
        private System.Windows.Forms.LinkLabel lnkFillCombos;
        private System.Windows.Forms.TextBox txtStreamTopic;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblStreamResponse;
        private System.Windows.Forms.Label lblPMResponse;
        private System.Windows.Forms.NumericUpDown numAnchor;
        private System.Windows.Forms.NumericUpDown numBefore;
        private System.Windows.Forms.NumericUpDown numAfter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}
