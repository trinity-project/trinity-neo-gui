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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_create));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.资产类型comboBox = new System.Windows.Forms.ComboBox();
            this.取消button = new System.Windows.Forms.Button();
            this.创建button = new System.Windows.Forms.Button();
            this.通道密码textBox = new System.Windows.Forms.TextBox();
            this.通道别名textBox = new System.Windows.Forms.TextBox();
            this.通道押金textBox = new System.Windows.Forms.TextBox();
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
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.资产类型comboBox);
            this.groupBox1.Controls.Add(this.取消button);
            this.groupBox1.Controls.Add(this.创建button);
            this.groupBox1.Controls.Add(this.通道密码textBox);
            this.groupBox1.Controls.Add(this.通道别名textBox);
            this.groupBox1.Controls.Add(this.通道押金textBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // 资产类型comboBox
            // 
            this.资产类型comboBox.FormattingEnabled = true;
            this.资产类型comboBox.Items.AddRange(new object[] {
            resources.GetString("资产类型comboBox.Items"),
            resources.GetString("资产类型comboBox.Items1")});
            resources.ApplyResources(this.资产类型comboBox, "资产类型comboBox");
            this.资产类型comboBox.Name = "资产类型comboBox";
            // 
            // 取消button
            // 
            this.取消button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.取消button, "取消button");
            this.取消button.Name = "取消button";
            this.取消button.UseVisualStyleBackColor = true;
            this.取消button.Click += new System.EventHandler(this.取消button_Click);
            // 
            // 创建button
            // 
            this.创建button.DialogResult = System.Windows.Forms.DialogResult.OK;
            resources.ApplyResources(this.创建button, "创建button");
            this.创建button.Name = "创建button";
            this.创建button.UseVisualStyleBackColor = true;
            this.创建button.Click += new System.EventHandler(this.创建button_Click_1);
            // 
            // 通道密码textBox
            // 
            resources.ApplyResources(this.通道密码textBox, "通道密码textBox");
            this.通道密码textBox.Name = "通道密码textBox";
            // 
            // 通道别名textBox
            // 
            resources.ApplyResources(this.通道别名textBox, "通道别名textBox");
            this.通道别名textBox.Name = "通道别名textBox";
            // 
            // 通道押金textBox
            // 
            resources.ApplyResources(this.通道押金textBox, "通道押金textBox");
            this.通道押金textBox.Name = "通道押金textBox";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // Form_create
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_create";
            this.Load += new System.EventHandler(this.Form_create_Load);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox 资产类型comboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}