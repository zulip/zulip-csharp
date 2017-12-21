namespace SampleApp {
    partial class UCUsers {
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApiKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtZulipServerURL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnGet = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.dgvStreams = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStreams)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(110, 37);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(174, 20);
            this.txtUsername.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "User name (email)";
            // 
            // txtApiKey
            // 
            this.txtApiKey.Location = new System.Drawing.Point(110, 63);
            this.txtApiKey.Name = "txtApiKey";
            this.txtApiKey.Size = new System.Drawing.Size(174, 20);
            this.txtApiKey.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "API key";
            // 
            // txtZulipServerURL
            // 
            this.txtZulipServerURL.Location = new System.Drawing.Point(110, 2);
            this.txtZulipServerURL.Name = "txtZulipServerURL";
            this.txtZulipServerURL.Size = new System.Drawing.Size(174, 20);
            this.txtZulipServerURL.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Zulip Server";
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(175, 89);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(109, 23);
            this.btnGet.TabIndex = 2;
            this.btnGet.Text = "GetUsers";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.splitter1);
            this.groupBox1.Controls.Add(this.dgvStreams);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(747, 359);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Retrieval";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(301, 16);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 340);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // dgvStreams
            // 
            this.dgvStreams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStreams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStreams.Location = new System.Drawing.Point(301, 16);
            this.dgvStreams.Name = "dgvStreams";
            this.dgvStreams.Size = new System.Drawing.Size(443, 340);
            this.dgvStreams.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtResponse);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 340);
            this.panel1.TabIndex = 5;
            // 
            // txtResponse
            // 
            this.txtResponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResponse.Location = new System.Drawing.Point(0, 117);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResponse.Size = new System.Drawing.Size(298, 223);
            this.txtResponse.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtUsername);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnGet);
            this.panel2.Controls.Add(this.txtApiKey);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtZulipServerURL);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(298, 117);
            this.panel2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Response";
            // 
            // UCUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UCUsers";
            this.Size = new System.Drawing.Size(747, 359);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStreams)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtApiKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtZulipServerURL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvStreams;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Splitter splitter1;
    }
}
