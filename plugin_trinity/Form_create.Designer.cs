namespace plugin_trinity
{
    partial class Form_create
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.资产类型comboBox = new System.Windows.Forms.ComboBox();
            this.取消button = new System.Windows.Forms.Button();
            this.创建button = new System.Windows.Forms.Button();
            this.通道密码textBox = new System.Windows.Forms.TextBox();
            this.通道别名textBox = new System.Windows.Forms.TextBox();
            this.通道押金textBox = new System.Windows.Forms.TextBox();
            this.网络接入点textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.资产类型comboBox);
            this.groupBox1.Controls.Add(this.取消button);
            this.groupBox1.Controls.Add(this.创建button);
            this.groupBox1.Controls.Add(this.通道密码textBox);
            this.groupBox1.Controls.Add(this.通道别名textBox);
            this.groupBox1.Controls.Add(this.通道押金textBox);
            this.groupBox1.Controls.Add(this.网络接入点textBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1026, 502);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "通道信息";
            // 
            // 资产类型comboBox
            // 
            this.资产类型comboBox.FormattingEnabled = true;
            this.资产类型comboBox.Items.AddRange(new object[] {
            "NEO",
            "TNC"});
            this.资产类型comboBox.Location = new System.Drawing.Point(204, 185);
            this.资产类型comboBox.Name = "资产类型comboBox";
            this.资产类型comboBox.Size = new System.Drawing.Size(121, 32);
            this.资产类型comboBox.TabIndex = 12;
            // 
            // 取消button
            // 
            this.取消button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.取消button.Location = new System.Drawing.Point(624, 417);
            this.取消button.Name = "取消button";
            this.取消button.Size = new System.Drawing.Size(128, 44);
            this.取消button.TabIndex = 11;
            this.取消button.Text = "取消";
            this.取消button.UseVisualStyleBackColor = true;
            this.取消button.Click += new System.EventHandler(this.取消button_Click);
            // 
            // 创建button
            // 
            this.创建button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.创建button.Location = new System.Drawing.Point(156, 417);
            this.创建button.Name = "创建button";
            this.创建button.Size = new System.Drawing.Size(115, 44);
            this.创建button.TabIndex = 10;
            this.创建button.Text = "创建";
            this.创建button.UseVisualStyleBackColor = true;
            this.创建button.Click += new System.EventHandler(this.创建button_Click_1);
            // 
            // 通道密码textBox
            // 
            this.通道密码textBox.Location = new System.Drawing.Point(204, 315);
            this.通道密码textBox.Name = "通道密码textBox";
            this.通道密码textBox.Size = new System.Drawing.Size(318, 35);
            this.通道密码textBox.TabIndex = 9;
            // 
            // 通道别名textBox
            // 
            this.通道别名textBox.Location = new System.Drawing.Point(204, 249);
            this.通道别名textBox.Name = "通道别名textBox";
            this.通道别名textBox.Size = new System.Drawing.Size(266, 35);
            this.通道别名textBox.TabIndex = 8;
            // 
            // 通道押金textBox
            // 
            this.通道押金textBox.Location = new System.Drawing.Point(204, 123);
            this.通道押金textBox.Name = "通道押金textBox";
            this.通道押金textBox.Size = new System.Drawing.Size(146, 35);
            this.通道押金textBox.TabIndex = 6;
            // 
            // 网络接入点textBox
            // 
            this.网络接入点textBox.Location = new System.Drawing.Point(204, 63);
            this.网络接入点textBox.Name = "网络接入点textBox";
            this.网络接入点textBox.Size = new System.Drawing.Size(512, 35);
            this.网络接入点textBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "通道密码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "通道别名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "资产类型";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "通道押金";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "网络接入点";
            // 
            // Form_create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 522);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_create";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "创建通道";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button 取消button;
        private System.Windows.Forms.Button 创建button;
        private System.Windows.Forms.TextBox 通道密码textBox;
        private System.Windows.Forms.TextBox 通道别名textBox;
        private System.Windows.Forms.TextBox 通道押金textBox;
        private System.Windows.Forms.TextBox 网络接入点textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox 资产类型comboBox;
    }
}