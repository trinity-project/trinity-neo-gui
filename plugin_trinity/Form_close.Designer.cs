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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.取消button = new System.Windows.Forms.Button();
            this.强拆通道button = new System.Windows.Forms.Button();
            this.快拆通道button = new System.Windows.Forms.Button();
            this.对端余额textBox = new System.Windows.Forms.TextBox();
            this.本段余额textBox = new System.Windows.Forms.TextBox();
            this.对端账户textBox = new System.Windows.Forms.TextBox();
            this.通道别名textBox = new System.Windows.Forms.TextBox();
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
            this.groupBox1.Controls.Add(this.强拆通道button);
            this.groupBox1.Controls.Add(this.快拆通道button);
            this.groupBox1.Controls.Add(this.对端余额textBox);
            this.groupBox1.Controls.Add(this.本段余额textBox);
            this.groupBox1.Controls.Add(this.对端账户textBox);
            this.groupBox1.Controls.Add(this.通道别名textBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(944, 478);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "通道信息";
            // 
            // 取消button
            // 
            this.取消button.Location = new System.Drawing.Point(764, 370);
            this.取消button.Name = "取消button";
            this.取消button.Size = new System.Drawing.Size(146, 60);
            this.取消button.TabIndex = 10;
            this.取消button.Text = "取消";
            this.取消button.UseVisualStyleBackColor = true;
            this.取消button.Click += new System.EventHandler(this.取消button_Click);
            // 
            // 强拆通道button
            // 
            this.强拆通道button.Location = new System.Drawing.Point(320, 370);
            this.强拆通道button.Name = "强拆通道button";
            this.强拆通道button.Size = new System.Drawing.Size(180, 60);
            this.强拆通道button.TabIndex = 9;
            this.强拆通道button.Text = "强制拆除通道";
            this.强拆通道button.UseVisualStyleBackColor = true;
            // 
            // 快拆通道button
            // 
            this.快拆通道button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.快拆通道button.Location = new System.Drawing.Point(84, 370);
            this.快拆通道button.Name = "快拆通道button";
            this.快拆通道button.Size = new System.Drawing.Size(180, 60);
            this.快拆通道button.TabIndex = 8;
            this.快拆通道button.Text = "快速拆除通道";
            this.快拆通道button.UseVisualStyleBackColor = true;
            // 
            // 对端余额textBox
            // 
            this.对端余额textBox.Location = new System.Drawing.Point(166, 275);
            this.对端余额textBox.Name = "对端余额textBox";
            this.对端余额textBox.ReadOnly = true;
            this.对端余额textBox.Size = new System.Drawing.Size(148, 35);
            this.对端余额textBox.TabIndex = 7;
            // 
            // 本段余额textBox
            // 
            this.本段余额textBox.Location = new System.Drawing.Point(166, 205);
            this.本段余额textBox.Name = "本段余额textBox";
            this.本段余额textBox.ReadOnly = true;
            this.本段余额textBox.Size = new System.Drawing.Size(154, 35);
            this.本段余额textBox.TabIndex = 6;
            // 
            // 对端账户textBox
            // 
            this.对端账户textBox.Location = new System.Drawing.Point(166, 135);
            this.对端账户textBox.Name = "对端账户textBox";
            this.对端账户textBox.ReadOnly = true;
            this.对端账户textBox.Size = new System.Drawing.Size(625, 35);
            this.对端账户textBox.TabIndex = 5;
            // 
            // 通道别名textBox
            // 
            this.通道别名textBox.Location = new System.Drawing.Point(166, 59);
            this.通道别名textBox.Name = "通道别名textBox";
            this.通道别名textBox.ReadOnly = true;
            this.通道别名textBox.Size = new System.Drawing.Size(376, 35);
            this.通道别名textBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "对端余额";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "本地余额";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "对端账户";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "通道别名";
            // 
            // Form_close
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 500);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_close";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "关闭通道";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button 强拆通道button;
        private System.Windows.Forms.Button 快拆通道button;
        private System.Windows.Forms.TextBox 对端余额textBox;
        private System.Windows.Forms.TextBox 本段余额textBox;
        private System.Windows.Forms.TextBox 对端账户textBox;
        private System.Windows.Forms.TextBox 通道别名textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button 取消button;
    }
}