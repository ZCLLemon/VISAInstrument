﻿namespace VISAInstrument
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.rbtRS232 = new System.Windows.Forms.RadioButton();
            this.cboRS232 = new System.Windows.Forms.ComboBox();
            this.rbtUSB = new System.Windows.Forms.RadioButton();
            this.cboUSB = new System.Windows.Forms.ComboBox();
            this.rbtGPIB = new System.Windows.Forms.RadioButton();
            this.cboGPIB = new System.Windows.Forms.ComboBox();
            this.rbtLAN = new System.Windows.Forms.RadioButton();
            this.cboLAN = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblBaudRate = new System.Windows.Forms.Label();
            this.cboBaudRate = new System.Windows.Forms.ComboBox();
            this.lblParity = new System.Windows.Forms.Label();
            this.cboParity = new System.Windows.Forms.ComboBox();
            this.lblStopBits = new System.Windows.Forms.Label();
            this.cboStopBits = new System.Windows.Forms.ComboBox();
            this.lblDataBits = new System.Windows.Forms.Label();
            this.cboDataBits = new System.Windows.Forms.ComboBox();
            this.lblFlowControl = new System.Windows.Forms.Label();
            this.cboFlowControl = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.groupBoxDisplay = new System.Windows.Forms.GroupBox();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.清除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.全选ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCommand = new System.Windows.Forms.Label();
            this.cboCommand = new System.Windows.Forms.ComboBox();
            this.cmsCommand = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aSCIIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.全选ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.复制ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.lblOverTime = new System.Windows.Forms.Label();
            this.nudTimeout = new System.Windows.Forms.NumericUpDown();
            this.lblTimeout = new System.Windows.Forms.Label();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblIP = new System.Windows.Forms.Label();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.btnCheckIP = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.githubToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.blogToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.byCNXYToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.时间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.groupBoxDisplay.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.cmsCommand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeout)).BeginInit();
            this.flowLayoutPanel5.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 661F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.flowLayoutPanel2, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.flowLayoutPanel4, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.groupBoxDisplay, 0, 5);
            this.tableLayoutPanel.Controls.Add(this.flowLayoutPanel3, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.flowLayoutPanel5, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.menuStrip1, 0, 6);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 7;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(786, 485);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.rbtRS232);
            this.flowLayoutPanel1.Controls.Add(this.cboRS232);
            this.flowLayoutPanel1.Controls.Add(this.rbtUSB);
            this.flowLayoutPanel1.Controls.Add(this.cboUSB);
            this.flowLayoutPanel1.Controls.Add(this.rbtGPIB);
            this.flowLayoutPanel1.Controls.Add(this.cboGPIB);
            this.flowLayoutPanel1.Controls.Add(this.rbtLAN);
            this.flowLayoutPanel1.Controls.Add(this.cboLAN);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 13);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(655, 54);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // rbtRS232
            // 
            this.rbtRS232.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbtRS232.AutoSize = true;
            this.rbtRS232.Location = new System.Drawing.Point(3, 5);
            this.rbtRS232.Name = "rbtRS232";
            this.rbtRS232.Size = new System.Drawing.Size(53, 16);
            this.rbtRS232.TabIndex = 2;
            this.rbtRS232.Text = "RS232";
            this.rbtRS232.UseVisualStyleBackColor = true;
            this.rbtRS232.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // cboRS232
            // 
            this.cboRS232.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboRS232.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRS232.FormattingEnabled = true;
            this.cboRS232.Location = new System.Drawing.Point(62, 3);
            this.cboRS232.Name = "cboRS232";
            this.cboRS232.Size = new System.Drawing.Size(261, 20);
            this.cboRS232.TabIndex = 3;
            // 
            // rbtUSB
            // 
            this.rbtUSB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbtUSB.AutoSize = true;
            this.rbtUSB.Location = new System.Drawing.Point(329, 5);
            this.rbtUSB.Name = "rbtUSB";
            this.rbtUSB.Size = new System.Drawing.Size(41, 16);
            this.rbtUSB.TabIndex = 4;
            this.rbtUSB.Text = "USB";
            this.rbtUSB.UseVisualStyleBackColor = true;
            this.rbtUSB.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // cboUSB
            // 
            this.cboUSB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboUSB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUSB.FormattingEnabled = true;
            this.cboUSB.Location = new System.Drawing.Point(376, 3);
            this.cboUSB.Name = "cboUSB";
            this.cboUSB.Size = new System.Drawing.Size(261, 20);
            this.cboUSB.TabIndex = 5;
            // 
            // rbtGPIB
            // 
            this.rbtGPIB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbtGPIB.AutoSize = true;
            this.rbtGPIB.Location = new System.Drawing.Point(3, 31);
            this.rbtGPIB.Name = "rbtGPIB";
            this.rbtGPIB.Size = new System.Drawing.Size(53, 16);
            this.rbtGPIB.TabIndex = 6;
            this.rbtGPIB.Text = "GPIB ";
            this.rbtGPIB.UseVisualStyleBackColor = true;
            this.rbtGPIB.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // cboGPIB
            // 
            this.cboGPIB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboGPIB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGPIB.FormattingEnabled = true;
            this.cboGPIB.Location = new System.Drawing.Point(62, 29);
            this.cboGPIB.Name = "cboGPIB";
            this.cboGPIB.Size = new System.Drawing.Size(261, 20);
            this.cboGPIB.TabIndex = 7;
            // 
            // rbtLAN
            // 
            this.rbtLAN.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbtLAN.AutoSize = true;
            this.rbtLAN.Location = new System.Drawing.Point(329, 31);
            this.rbtLAN.Name = "rbtLAN";
            this.rbtLAN.Size = new System.Drawing.Size(41, 16);
            this.rbtLAN.TabIndex = 8;
            this.rbtLAN.Text = "LAN";
            this.rbtLAN.UseVisualStyleBackColor = true;
            this.rbtLAN.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // cboLAN
            // 
            this.cboLAN.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboLAN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLAN.FormattingEnabled = true;
            this.cboLAN.Location = new System.Drawing.Point(376, 29);
            this.cboLAN.Name = "cboLAN";
            this.cboLAN.Size = new System.Drawing.Size(261, 20);
            this.cboLAN.TabIndex = 9;
            // 
            // flowLayoutPanel2
            // 
            this.tableLayoutPanel.SetColumnSpan(this.flowLayoutPanel2, 2);
            this.flowLayoutPanel2.Controls.Add(this.lblBaudRate);
            this.flowLayoutPanel2.Controls.Add(this.cboBaudRate);
            this.flowLayoutPanel2.Controls.Add(this.lblParity);
            this.flowLayoutPanel2.Controls.Add(this.cboParity);
            this.flowLayoutPanel2.Controls.Add(this.lblStopBits);
            this.flowLayoutPanel2.Controls.Add(this.cboStopBits);
            this.flowLayoutPanel2.Controls.Add(this.lblDataBits);
            this.flowLayoutPanel2.Controls.Add(this.cboDataBits);
            this.flowLayoutPanel2.Controls.Add(this.lblFlowControl);
            this.flowLayoutPanel2.Controls.Add(this.cboFlowControl);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 73);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(780, 29);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // lblBaudRate
            // 
            this.lblBaudRate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBaudRate.AutoSize = true;
            this.lblBaudRate.Location = new System.Drawing.Point(3, 7);
            this.lblBaudRate.Name = "lblBaudRate";
            this.lblBaudRate.Size = new System.Drawing.Size(41, 12);
            this.lblBaudRate.TabIndex = 0;
            this.lblBaudRate.Text = "波特率";
            // 
            // cboBaudRate
            // 
            this.cboBaudRate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBaudRate.FormattingEnabled = true;
            this.cboBaudRate.Location = new System.Drawing.Point(50, 3);
            this.cboBaudRate.Margin = new System.Windows.Forms.Padding(3, 3, 17, 3);
            this.cboBaudRate.Name = "cboBaudRate";
            this.cboBaudRate.Size = new System.Drawing.Size(73, 20);
            this.cboBaudRate.TabIndex = 1;
            // 
            // lblParity
            // 
            this.lblParity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblParity.AutoSize = true;
            this.lblParity.Location = new System.Drawing.Point(143, 7);
            this.lblParity.Name = "lblParity";
            this.lblParity.Size = new System.Drawing.Size(65, 12);
            this.lblParity.TabIndex = 0;
            this.lblParity.Text = "奇偶校验位";
            // 
            // cboParity
            // 
            this.cboParity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboParity.FormattingEnabled = true;
            this.cboParity.Location = new System.Drawing.Point(214, 3);
            this.cboParity.Margin = new System.Windows.Forms.Padding(3, 3, 17, 3);
            this.cboParity.Name = "cboParity";
            this.cboParity.Size = new System.Drawing.Size(73, 20);
            this.cboParity.TabIndex = 2;
            // 
            // lblStopBits
            // 
            this.lblStopBits.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStopBits.AutoSize = true;
            this.lblStopBits.Location = new System.Drawing.Point(307, 7);
            this.lblStopBits.Name = "lblStopBits";
            this.lblStopBits.Size = new System.Drawing.Size(41, 12);
            this.lblStopBits.TabIndex = 0;
            this.lblStopBits.Text = "停止位";
            // 
            // cboStopBits
            // 
            this.cboStopBits.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStopBits.FormattingEnabled = true;
            this.cboStopBits.Location = new System.Drawing.Point(354, 3);
            this.cboStopBits.Margin = new System.Windows.Forms.Padding(3, 3, 17, 3);
            this.cboStopBits.Name = "cboStopBits";
            this.cboStopBits.Size = new System.Drawing.Size(115, 20);
            this.cboStopBits.TabIndex = 3;
            // 
            // lblDataBits
            // 
            this.lblDataBits.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDataBits.AutoSize = true;
            this.lblDataBits.Location = new System.Drawing.Point(489, 7);
            this.lblDataBits.Name = "lblDataBits";
            this.lblDataBits.Size = new System.Drawing.Size(41, 12);
            this.lblDataBits.TabIndex = 0;
            this.lblDataBits.Text = "数据位";
            // 
            // cboDataBits
            // 
            this.cboDataBits.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDataBits.FormattingEnabled = true;
            this.cboDataBits.Location = new System.Drawing.Point(536, 3);
            this.cboDataBits.Margin = new System.Windows.Forms.Padding(3, 3, 17, 3);
            this.cboDataBits.Name = "cboDataBits";
            this.cboDataBits.Size = new System.Drawing.Size(73, 20);
            this.cboDataBits.TabIndex = 4;
            // 
            // lblFlowControl
            // 
            this.lblFlowControl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFlowControl.AutoSize = true;
            this.lblFlowControl.Location = new System.Drawing.Point(629, 7);
            this.lblFlowControl.Name = "lblFlowControl";
            this.lblFlowControl.Size = new System.Drawing.Size(41, 12);
            this.lblFlowControl.TabIndex = 0;
            this.lblFlowControl.Text = "控制流";
            // 
            // cboFlowControl
            // 
            this.cboFlowControl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboFlowControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFlowControl.FormattingEnabled = true;
            this.cboFlowControl.Location = new System.Drawing.Point(676, 3);
            this.cboFlowControl.Name = "cboFlowControl";
            this.cboFlowControl.Size = new System.Drawing.Size(73, 20);
            this.cboFlowControl.TabIndex = 5;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.btnRefresh);
            this.flowLayoutPanel4.Controls.Add(this.btnOpen);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(664, 13);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(119, 54);
            this.flowLayoutPanel4.TabIndex = 5;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(2, 2);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(88, 23);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(2, 28);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(2, 1, 1, 1);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(88, 23);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "打开";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // groupBoxDisplay
            // 
            this.tableLayoutPanel.SetColumnSpan(this.groupBoxDisplay, 2);
            this.groupBoxDisplay.Controls.Add(this.txtDisplay);
            this.groupBoxDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDisplay.Location = new System.Drawing.Point(3, 183);
            this.groupBoxDisplay.Name = "groupBoxDisplay";
            this.groupBoxDisplay.Size = new System.Drawing.Size(780, 274);
            this.groupBoxDisplay.TabIndex = 2;
            this.groupBoxDisplay.TabStop = false;
            this.groupBoxDisplay.Text = "显示";
            // 
            // txtDisplay
            // 
            this.txtDisplay.ContextMenuStrip = this.contextMenuStrip;
            this.txtDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDisplay.Location = new System.Drawing.Point(3, 17);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDisplay.Size = new System.Drawing.Size(774, 254);
            this.txtDisplay.TabIndex = 0;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.清除ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.全选ToolStripMenuItem,
            this.复制ToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(101, 76);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // 清除ToolStripMenuItem
            // 
            this.清除ToolStripMenuItem.Name = "清除ToolStripMenuItem";
            this.清除ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.清除ToolStripMenuItem.Text = "清除";
            this.清除ToolStripMenuItem.Click += new System.EventHandler(this.清除ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(97, 6);
            // 
            // 全选ToolStripMenuItem
            // 
            this.全选ToolStripMenuItem.Name = "全选ToolStripMenuItem";
            this.全选ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.全选ToolStripMenuItem.Text = "全选";
            this.全选ToolStripMenuItem.Click += new System.EventHandler(this.全选ToolStripMenuItem_Click);
            // 
            // 复制ToolStripMenuItem
            // 
            this.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem";
            this.复制ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.复制ToolStripMenuItem.Text = "复制";
            this.复制ToolStripMenuItem.Click += new System.EventHandler(this.复制ToolStripMenuItem_Click);
            // 
            // flowLayoutPanel3
            // 
            this.tableLayoutPanel.SetColumnSpan(this.flowLayoutPanel3, 2);
            this.flowLayoutPanel3.Controls.Add(this.lblCommand);
            this.flowLayoutPanel3.Controls.Add(this.cboCommand);
            this.flowLayoutPanel3.Controls.Add(this.btnWrite);
            this.flowLayoutPanel3.Controls.Add(this.btnRead);
            this.flowLayoutPanel3.Controls.Add(this.btnQuery);
            this.flowLayoutPanel3.Controls.Add(this.lblOverTime);
            this.flowLayoutPanel3.Controls.Add(this.nudTimeout);
            this.flowLayoutPanel3.Controls.Add(this.lblTimeout);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 143);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(742, 29);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // lblCommand
            // 
            this.lblCommand.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCommand.AutoSize = true;
            this.lblCommand.Location = new System.Drawing.Point(15, 8);
            this.lblCommand.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.lblCommand.Name = "lblCommand";
            this.lblCommand.Size = new System.Drawing.Size(29, 12);
            this.lblCommand.TabIndex = 0;
            this.lblCommand.Text = "命令";
            // 
            // cboCommand
            // 
            this.cboCommand.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboCommand.ContextMenuStrip = this.cmsCommand;
            this.cboCommand.FormattingEnabled = true;
            this.cboCommand.Location = new System.Drawing.Point(50, 4);
            this.cboCommand.Name = "cboCommand";
            this.cboCommand.Size = new System.Drawing.Size(277, 20);
            this.cboCommand.TabIndex = 1;
            // 
            // cmsCommand
            // 
            this.cmsCommand.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aSCIIToolStripMenuItem,
            this.hexToolStripMenuItem,
            this.toolStripMenuItem2,
            this.全选ToolStripMenuItem1,
            this.复制ToolStripMenuItem1,
            this.粘贴ToolStripMenuItem});
            this.cmsCommand.Name = "contextMenuStrip";
            this.cmsCommand.Size = new System.Drawing.Size(108, 120);
            this.cmsCommand.Opening += new System.ComponentModel.CancelEventHandler(this.cmsCommand_Opening);
            // 
            // aSCIIToolStripMenuItem
            // 
            this.aSCIIToolStripMenuItem.Checked = true;
            this.aSCIIToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.aSCIIToolStripMenuItem.Name = "aSCIIToolStripMenuItem";
            this.aSCIIToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aSCIIToolStripMenuItem.Text = "ASCII";
            this.aSCIIToolStripMenuItem.Click += new System.EventHandler(this.aSCIIToolStripMenuItem_Click);
            // 
            // hexToolStripMenuItem
            // 
            this.hexToolStripMenuItem.Name = "hexToolStripMenuItem";
            this.hexToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.hexToolStripMenuItem.Text = "Hex";
            this.hexToolStripMenuItem.Click += new System.EventHandler(this.hexToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(104, 6);
            // 
            // 全选ToolStripMenuItem1
            // 
            this.全选ToolStripMenuItem1.Name = "全选ToolStripMenuItem1";
            this.全选ToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.全选ToolStripMenuItem1.Text = "全选";
            this.全选ToolStripMenuItem1.Click += new System.EventHandler(this.全选ToolStripMenuItem1_Click);
            // 
            // 复制ToolStripMenuItem1
            // 
            this.复制ToolStripMenuItem1.Name = "复制ToolStripMenuItem1";
            this.复制ToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.复制ToolStripMenuItem1.Text = "复制";
            this.复制ToolStripMenuItem1.Click += new System.EventHandler(this.复制ToolStripMenuItem1_Click);
            // 
            // 粘贴ToolStripMenuItem
            // 
            this.粘贴ToolStripMenuItem.Name = "粘贴ToolStripMenuItem";
            this.粘贴ToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.粘贴ToolStripMenuItem.Text = "粘贴";
            this.粘贴ToolStripMenuItem.Click += new System.EventHandler(this.粘贴ToolStripMenuItem_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnWrite.Location = new System.Drawing.Point(333, 3);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(53, 23);
            this.btnWrite.TabIndex = 2;
            this.btnWrite.Text = "写入";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnRead
            // 
            this.btnRead.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnRead.Location = new System.Drawing.Point(392, 3);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(53, 23);
            this.btnRead.TabIndex = 3;
            this.btnRead.Text = "读取";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnQuery.Location = new System.Drawing.Point(451, 3);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(53, 23);
            this.btnQuery.TabIndex = 4;
            this.btnQuery.Text = "询问";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // lblOverTime
            // 
            this.lblOverTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOverTime.AutoSize = true;
            this.lblOverTime.Location = new System.Drawing.Point(537, 8);
            this.lblOverTime.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.lblOverTime.Name = "lblOverTime";
            this.lblOverTime.Size = new System.Drawing.Size(29, 12);
            this.lblOverTime.TabIndex = 5;
            this.lblOverTime.Text = "超时";
            // 
            // nudTimeout
            // 
            this.nudTimeout.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudTimeout.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudTimeout.Location = new System.Drawing.Point(572, 4);
            this.nudTimeout.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudTimeout.Name = "nudTimeout";
            this.nudTimeout.Size = new System.Drawing.Size(75, 21);
            this.nudTimeout.TabIndex = 6;
            this.nudTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudTimeout.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // lblTimeout
            // 
            this.lblTimeout.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTimeout.AutoSize = true;
            this.lblTimeout.Location = new System.Drawing.Point(653, 8);
            this.lblTimeout.Name = "lblTimeout";
            this.lblTimeout.Size = new System.Drawing.Size(17, 12);
            this.lblTimeout.TabIndex = 7;
            this.lblTimeout.Text = "ms";
            // 
            // flowLayoutPanel5
            // 
            this.tableLayoutPanel.SetColumnSpan(this.flowLayoutPanel5, 2);
            this.flowLayoutPanel5.Controls.Add(this.lblIP);
            this.flowLayoutPanel5.Controls.Add(this.txtIPAddress);
            this.flowLayoutPanel5.Controls.Add(this.btnCheckIP);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 108);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(780, 29);
            this.flowLayoutPanel5.TabIndex = 6;
            // 
            // lblIP
            // 
            this.lblIP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(3, 8);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(41, 12);
            this.lblIP.TabIndex = 0;
            this.lblIP.Text = "IP地址";
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtIPAddress.Location = new System.Drawing.Point(50, 4);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(277, 21);
            this.txtIPAddress.TabIndex = 1;
            // 
            // btnCheckIP
            // 
            this.btnCheckIP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCheckIP.Location = new System.Drawing.Point(333, 3);
            this.btnCheckIP.Name = "btnCheckIP";
            this.btnCheckIP.Size = new System.Drawing.Size(53, 23);
            this.btnCheckIP.TabIndex = 2;
            this.btnCheckIP.Text = "检测";
            this.btnCheckIP.UseVisualStyleBackColor = true;
            this.btnCheckIP.Click += new System.EventHandler(this.btnCheckIP_Click);
            // 
            // menuStrip1
            // 
            this.tableLayoutPanel.SetColumnSpan(this.menuStrip1, 2);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem,
            this.时间ToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 460);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(786, 25);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.githubToolStripMenuItem1,
            this.blogToolStripMenuItem1,
            this.toolStripMenuItem3,
            this.byCNXYToolStripMenuItem1});
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // githubToolStripMenuItem1
            // 
            this.githubToolStripMenuItem1.Name = "githubToolStripMenuItem1";
            this.githubToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.githubToolStripMenuItem1.Text = "Github";
            this.githubToolStripMenuItem1.Click += new System.EventHandler(this.githubToolStripMenuItem1_Click);
            // 
            // blogToolStripMenuItem1
            // 
            this.blogToolStripMenuItem1.Name = "blogToolStripMenuItem1";
            this.blogToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.blogToolStripMenuItem1.Text = "Blog";
            this.blogToolStripMenuItem1.Click += new System.EventHandler(this.blogToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(177, 6);
            // 
            // byCNXYToolStripMenuItem1
            // 
            this.byCNXYToolStripMenuItem1.Name = "byCNXYToolStripMenuItem1";
            this.byCNXYToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.byCNXYToolStripMenuItem1.Text = "By CNXY";
            this.byCNXYToolStripMenuItem1.Click += new System.EventHandler(this.byCNXYToolStripMenuItem1_Click);
            // 
            // 时间ToolStripMenuItem
            // 
            this.时间ToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.时间ToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.时间ToolStripMenuItem.Name = "时间ToolStripMenuItem";
            this.时间ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.时间ToolStripMenuItem.Text = "时间";
            this.时间ToolStripMenuItem.Click += new System.EventHandler(this.时间ToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AcceptButton = this.btnOpen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 485);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NI-VISA仪器控制 - For SCPI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.groupBoxDisplay.ResumeLayout(false);
            this.groupBoxDisplay.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.cmsCommand.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeout)).EndInit();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton rbtRS232;
        private System.Windows.Forms.ComboBox cboRS232;
        private System.Windows.Forms.RadioButton rbtUSB;
        private System.Windows.Forms.ComboBox cboUSB;
        private System.Windows.Forms.RadioButton rbtGPIB;
        private System.Windows.Forms.ComboBox cboGPIB;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label lblCommand;
        private System.Windows.Forms.ComboBox cboCommand;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.GroupBox groupBoxDisplay;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.RadioButton rbtLAN;
        private System.Windows.Forms.ComboBox cboLAN;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label lblParity;
        private System.Windows.Forms.ComboBox cboParity;
        private System.Windows.Forms.Label lblStopBits;
        private System.Windows.Forms.ComboBox cboStopBits;
        private System.Windows.Forms.Label lblDataBits;
        private System.Windows.Forms.ComboBox cboDataBits;
        private System.Windows.Forms.Label lblFlowControl;
        private System.Windows.Forms.ComboBox cboFlowControl;
        private System.Windows.Forms.Label lblBaudRate;
        private System.Windows.Forms.ComboBox cboBaudRate;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 清除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 全选ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复制ToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.TextBox txtIPAddress;
        private System.Windows.Forms.Button btnCheckIP;
        private System.Windows.Forms.Label lblOverTime;
        private System.Windows.Forms.NumericUpDown nudTimeout;
        private System.Windows.Forms.Label lblTimeout;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem githubToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem blogToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem byCNXYToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 时间ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsCommand;
        private System.Windows.Forms.ToolStripMenuItem aSCIIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hexToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 复制ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 粘贴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全选ToolStripMenuItem1;
    }
}

