namespace plugin_trinity
{
    partial class Form_main
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
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.对端账户textBox = new System.Windows.Forms.TextBox();
            this.转账金额textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.创建通道button = new System.Windows.Forms.Button();
            this.拆除通道button = new System.Windows.Forms.Button();
            this.通道转账groupBox = new System.Windows.Forms.GroupBox();
            this.资产类型comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.转账button = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.可用通道列表groupBox = new System.Windows.Forms.GroupBox();
            this.通道列表listView = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.查询类型comboBox = new System.Windows.Forms.ComboBox();
            this.查询条件comboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.通道转账groupBox.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.可用通道列表groupBox.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // 对端账户textBox
            // 
            this.对端账户textBox.Location = new System.Drawing.Point(190, 72);
            this.对端账户textBox.Name = "对端账户textBox";
            this.对端账户textBox.Size = new System.Drawing.Size(662, 35);
            this.对端账户textBox.TabIndex = 0;
            // 
            // 转账金额textBox
            // 
            this.转账金额textBox.Location = new System.Drawing.Point(190, 153);
            this.转账金额textBox.Name = "转账金额textBox";
            this.转账金额textBox.Size = new System.Drawing.Size(200, 35);
            this.转账金额textBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(32, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "对端账户";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(32, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "转账金额";
            // 
            // 创建通道button
            // 
            this.创建通道button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.创建通道button.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.创建通道button.Location = new System.Drawing.Point(16, 353);
            this.创建通道button.Name = "创建通道button";
            this.创建通道button.Size = new System.Drawing.Size(65, 50);
            this.创建通道button.TabIndex = 8;
            this.创建通道button.Text = "+";
            this.创建通道button.UseVisualStyleBackColor = true;
            this.创建通道button.Click += new System.EventHandler(this.创建通道button_Click);
            // 
            // 拆除通道button
            // 
            this.拆除通道button.Enabled = false;
            this.拆除通道button.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.拆除通道button.Location = new System.Drawing.Point(97, 353);
            this.拆除通道button.Name = "拆除通道button";
            this.拆除通道button.Size = new System.Drawing.Size(68, 50);
            this.拆除通道button.TabIndex = 9;
            this.拆除通道button.Text = "-";
            this.拆除通道button.UseVisualStyleBackColor = true;
            this.拆除通道button.Click += new System.EventHandler(this.拆除通道button_Click);
            // 
            // 通道转账groupBox
            // 
            this.通道转账groupBox.Controls.Add(this.资产类型comboBox);
            this.通道转账groupBox.Controls.Add(this.label3);
            this.通道转账groupBox.Controls.Add(this.转账button);
            this.通道转账groupBox.Controls.Add(this.label1);
            this.通道转账groupBox.Controls.Add(this.label2);
            this.通道转账groupBox.Controls.Add(this.转账金额textBox);
            this.通道转账groupBox.Controls.Add(this.对端账户textBox);
            this.通道转账groupBox.Location = new System.Drawing.Point(22, 21);
            this.通道转账groupBox.Name = "通道转账groupBox";
            this.通道转账groupBox.Size = new System.Drawing.Size(1108, 329);
            this.通道转账groupBox.TabIndex = 10;
            this.通道转账groupBox.TabStop = false;
            this.通道转账groupBox.Text = "通道转账";
            // 
            // 资产类型comboBox
            // 
            this.资产类型comboBox.FormattingEnabled = true;
            this.资产类型comboBox.Items.AddRange(new object[] {
            "NEO",
            "TNC"});
            this.资产类型comboBox.Location = new System.Drawing.Point(190, 225);
            this.资产类型comboBox.Name = "资产类型comboBox";
            this.资产类型comboBox.Size = new System.Drawing.Size(121, 32);
            this.资产类型comboBox.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "资产类型";
            // 
            // 转账button
            // 
            this.转账button.Location = new System.Drawing.Point(896, 222);
            this.转账button.Name = "转账button";
            this.转账button.Size = new System.Drawing.Size(128, 46);
            this.转账button.TabIndex = 12;
            this.转账button.Text = "转账";
            this.转账button.UseVisualStyleBackColor = true;
            this.转账button.Click += new System.EventHandler(this.转账button_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1166, 843);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.可用通道列表groupBox);
            this.tabPage1.Controls.Add(this.通道转账groupBox);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1150, 796);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "转账交易";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // 可用通道列表groupBox
            // 
            this.可用通道列表groupBox.Controls.Add(this.通道列表listView);
            this.可用通道列表groupBox.Controls.Add(this.创建通道button);
            this.可用通道列表groupBox.Controls.Add(this.拆除通道button);
            this.可用通道列表groupBox.Location = new System.Drawing.Point(22, 356);
            this.可用通道列表groupBox.Name = "可用通道列表groupBox";
            this.可用通道列表groupBox.Size = new System.Drawing.Size(1128, 416);
            this.可用通道列表groupBox.TabIndex = 12;
            this.可用通道列表groupBox.TabStop = false;
            this.可用通道列表groupBox.Text = "可用通道列表";
            // 
            // 通道列表listView
            // 
            this.通道列表listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader5,
            this.columnHeader8,
            this.columnHeader7});
            this.通道列表listView.FullRowSelect = true;
            this.通道列表listView.GridLines = true;
            this.通道列表listView.Location = new System.Drawing.Point(20, 40);
            this.通道列表listView.Name = "通道列表listView";
            this.通道列表listView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.通道列表listView.Size = new System.Drawing.Size(1088, 303);
            this.通道列表listView.TabIndex = 10;
            this.通道列表listView.UseCompatibleStateImageBehavior = false;
            this.通道列表listView.View = System.Windows.Forms.View.Details;
            this.通道列表listView.SelectedIndexChanged += new System.EventHandler(this.通道列表listView_SelectedIndexChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "通道别名";
            this.columnHeader6.Width = 124;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "对端地址";
            this.columnHeader5.Width = 134;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "本端通道余额";
            this.columnHeader8.Width = 178;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "通道状态";
            this.columnHeader7.Width = 140;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1150, 796);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "转账记录";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            listViewGroup3.Header = "ListViewGroup";
            listViewGroup3.Name = "listViewGroup1";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup3});
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.ShowGroups = false;
            this.listView1.Size = new System.Drawing.Size(1144, 790);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "交易时间";
            this.columnHeader1.Width = 158;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "通道别名";
            this.columnHeader2.Width = 148;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "交易金额";
            this.columnHeader3.Width = 174;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "资产类型";
            this.columnHeader4.Width = 298;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(8, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1150, 796);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "通道管理";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.查询类型comboBox);
            this.groupBox4.Controls.Add(this.查询条件comboBox);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(17, 17);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1127, 126);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "通道查询";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "查询类型";
            // 
            // 查询类型comboBox
            // 
            this.查询类型comboBox.FormattingEnabled = true;
            this.查询类型comboBox.Items.AddRange(new object[] {
            "通道状态",
            "通道别名",
            "通道余额"});
            this.查询类型comboBox.Location = new System.Drawing.Point(190, 53);
            this.查询类型comboBox.Name = "查询类型comboBox";
            this.查询类型comboBox.Size = new System.Drawing.Size(172, 32);
            this.查询类型comboBox.TabIndex = 1;
            this.查询类型comboBox.SelectedIndexChanged += new System.EventHandler(this.查询类型comboBox_SelectedIndexChanged);
            // 
            // 查询条件comboBox
            // 
            this.查询条件comboBox.FormattingEnabled = true;
            this.查询条件comboBox.Location = new System.Drawing.Point(572, 53);
            this.查询条件comboBox.Name = "查询条件comboBox";
            this.查询条件comboBox.Size = new System.Drawing.Size(160, 32);
            this.查询条件comboBox.TabIndex = 4;
            this.查询条件comboBox.SelectedIndexChanged += new System.EventHandler(this.查询条件comboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(444, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "查询条件";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listView2);
            this.groupBox3.Location = new System.Drawing.Point(17, 167);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1127, 614);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "通道信息";
            // 
            // listView2
            // 
            this.listView2.AllowDrop = true;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(6, 44);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(1115, 564);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "通道别名";
            this.columnHeader9.Width = 202;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "对端账户";
            this.columnHeader10.Width = 200;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "通道状态";
            this.columnHeader11.Width = 192;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "通道余额";
            this.columnHeader12.Width = 166;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(8, 39);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1150, 796);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "节点管理";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 862);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "通道交易：";
            this.通道转账groupBox.ResumeLayout(false);
            this.通道转账groupBox.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.可用通道列表groupBox.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox 对端账户textBox;
        private System.Windows.Forms.TextBox 转账金额textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button 创建通道button;
        private System.Windows.Forms.Button 拆除通道button;
        private System.Windows.Forms.GroupBox 通道转账groupBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button 转账button;
        private System.Windows.Forms.GroupBox 可用通道列表groupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox 资产类型comboBox;
        private System.Windows.Forms.ListView 通道列表listView;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox 查询类型comboBox;
        private System.Windows.Forms.ComboBox 查询条件comboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
    }
}