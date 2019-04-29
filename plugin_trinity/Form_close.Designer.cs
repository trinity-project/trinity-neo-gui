namespace plugin_trinity
{
    partial class Form_close
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_close));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.取消button = new System.Windows.Forms.Button();
            this.快拆通道button = new System.Windows.Forms.Button();
            this.对端余额textBox = new System.Windows.Forms.TextBox();
            this.本段余额textBox = new System.Windows.Forms.TextBox();
            this.对端账户textBox = new System.Windows.Forms.TextBox();
            this.通道名称textBox = new System.Windows.Forms.TextBox();
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
            this.groupBox1.Controls.Add(this.取消button);
            this.groupBox1.Controls.Add(this.快拆通道button);
            this.groupBox1.Controls.Add(this.对端余额textBox);
            this.groupBox1.Controls.Add(this.本段余额textBox);
            this.groupBox1.Controls.Add(this.对端账户textBox);
            this.groupBox1.Controls.Add(this.通道名称textBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // 取消button
            // 
            resources.ApplyResources(this.取消button, "取消button");
            this.取消button.Name = "取消button";
            this.取消button.UseVisualStyleBackColor = true;
            this.取消button.Click += new System.EventHandler(this.取消button_Click);
            // 
            // 快拆通道button
            // 
            this.快拆通道button.DialogResult = System.Windows.Forms.DialogResult.OK;
            resources.ApplyResources(this.快拆通道button, "快拆通道button");
            this.快拆通道button.Name = "快拆通道button";
            this.快拆通道button.UseVisualStyleBackColor = true;
            this.快拆通道button.Click += new System.EventHandler(this.快拆通道button_Click);
            // 
            // 对端余额textBox
            // 
            resources.ApplyResources(this.对端余额textBox, "对端余额textBox");
            this.对端余额textBox.Name = "对端余额textBox";
            this.对端余额textBox.ReadOnly = true;
            // 
            // 本段余额textBox
            // 
            resources.ApplyResources(this.本段余额textBox, "本段余额textBox");
            this.本段余额textBox.Name = "本段余额textBox";
            this.本段余额textBox.ReadOnly = true;
            // 
            // 对端账户textBox
            // 
            resources.ApplyResources(this.对端账户textBox, "对端账户textBox");
            this.对端账户textBox.Name = "对端账户textBox";
            this.对端账户textBox.ReadOnly = true;
            // 
            // 通道名称textBox
            // 
            resources.ApplyResources(this.通道名称textBox, "通道名称textBox");
            this.通道名称textBox.Name = "通道名称textBox";
            this.通道名称textBox.ReadOnly = true;
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
            // Form_close
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_close";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button 快拆通道button;
        private System.Windows.Forms.TextBox 对端余额textBox;
        private System.Windows.Forms.TextBox 本段余额textBox;
        private System.Windows.Forms.TextBox 对端账户textBox;
        private System.Windows.Forms.TextBox 通道名称textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button 取消button;
    }
}