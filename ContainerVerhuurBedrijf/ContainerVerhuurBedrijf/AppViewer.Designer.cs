namespace ContainerVerhuurBedrijf
{
    partial class AppViewer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppViewer));
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.containersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addContainerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem_About = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Close = new System.Windows.Forms.ToolStripMenuItem();
            this.notififyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage_General = new System.Windows.Forms.TabPage();
            this.label_Rent_Output = new System.Windows.Forms.Label();
            this.label_Disposal_OutputLess = new System.Windows.Forms.Label();
            this.label_Disposal_OutputMore = new System.Windows.Forms.Label();
            this.label_Disposal = new System.Windows.Forms.Label();
            this.label_Rent = new System.Windows.Forms.Label();
            this.label_Prices = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_LongestRentalPeriod = new System.Windows.Forms.Label();
            this.label_LongestRentalPeriod_Output = new System.Windows.Forms.Label();
            this.label_AverageVolume_Output = new System.Windows.Forms.Label();
            this.label_TotalProfits_Output = new System.Windows.Forms.Label();
            this.label_TotalProfits = new System.Windows.Forms.Label();
            this.label_AvgVolume = new System.Windows.Forms.Label();
            this.tabPage_Containers = new System.Windows.Forms.TabPage();
            this.tableOverviewPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label_Container = new System.Windows.Forms.Label();
            this.label_Availability = new System.Windows.Forms.Label();
            this.label_Volume = new System.Windows.Forms.Label();
            this.tabPage_CheckInputs = new System.Windows.Forms.TabPage();
            this.dateTimePicker_CheckInputEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_CheckInputBegin = new System.Windows.Forms.DateTimePicker();
            this.label_OutputCosts = new System.Windows.Forms.Label();
            this.label_LongestPeriod = new System.Windows.Forms.Label();
            this.label_CheckTotalProfits = new System.Windows.Forms.Label();
            this.label_CheckOutput_LongestPeriod = new System.Windows.Forms.Label();
            this.label_CheckOutput_TotalProfits = new System.Windows.Forms.Label();
            this.label_CheckOutput_Costs = new System.Windows.Forms.Label();
            this.button_CalculateCosts = new System.Windows.Forms.Button();
            this.textBox_CheckInputContainer = new System.Windows.Forms.TextBox();
            this.label_CheckInputEnd = new System.Windows.Forms.Label();
            this.label_CheckInputBegin = new System.Windows.Forms.Label();
            this.label_CheckInputContainer = new System.Windows.Forms.Label();
            this.contextMenuStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage_General.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage_Containers.SuspendLayout();
            this.tableOverviewPanel.SuspendLayout();
            this.tabPage_CheckInputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalToolStripMenuItem,
            this.containersToolStripMenuItem,
            this.addContainerToolStripMenuItem,
            this.toolStripSeparator,
            this.toolStripMenuItem_About,
            this.toolStripMenuItem_Close});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(162, 130);
            // 
            // generalToolStripMenuItem
            // 
            this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            this.generalToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.generalToolStripMenuItem.Text = "General";
            this.generalToolStripMenuItem.Click += new System.EventHandler(this.generalToolStripMenuItem_Click);
            // 
            // containersToolStripMenuItem
            // 
            this.containersToolStripMenuItem.Name = "containersToolStripMenuItem";
            this.containersToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.containersToolStripMenuItem.Text = "Containers";
            this.containersToolStripMenuItem.Click += new System.EventHandler(this.containersToolStripMenuItem_Click);
            // 
            // addContainerToolStripMenuItem
            // 
            this.addContainerToolStripMenuItem.Name = "addContainerToolStripMenuItem";
            this.addContainerToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.addContainerToolStripMenuItem.Text = "Check Inputs";
            this.addContainerToolStripMenuItem.Click += new System.EventHandler(this.addContainerToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(158, 6);
            // 
            // toolStripMenuItem_About
            // 
            this.toolStripMenuItem_About.Name = "toolStripMenuItem_About";
            this.toolStripMenuItem_About.Size = new System.Drawing.Size(161, 24);
            this.toolStripMenuItem_About.Text = "About";
            this.toolStripMenuItem_About.Click += new System.EventHandler(this.toolStripMenuItem_About_Click);
            // 
            // toolStripMenuItem_Close
            // 
            this.toolStripMenuItem_Close.Name = "toolStripMenuItem_Close";
            this.toolStripMenuItem_Close.Size = new System.Drawing.Size(161, 24);
            this.toolStripMenuItem_Close.Text = "Close";
            this.toolStripMenuItem_Close.Click += new System.EventHandler(this.toolStripMenuItem_Close_Click);
            // 
            // notififyIcon
            // 
            this.notififyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notififyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notififyIcon.Icon")));
            this.notififyIcon.Text = "Container Verhuurbedrijf";
            this.notififyIcon.Visible = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage_General);
            this.tabControl.Controls.Add(this.tabPage_Containers);
            this.tabControl.Controls.Add(this.tabPage_CheckInputs);
            this.tabControl.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(900, 591);
            this.tabControl.TabIndex = 1;
            // 
            // tabPage_General
            // 
            this.tabPage_General.BackColor = System.Drawing.Color.Transparent;
            this.tabPage_General.Controls.Add(this.label_Rent_Output);
            this.tabPage_General.Controls.Add(this.label_Disposal_OutputLess);
            this.tabPage_General.Controls.Add(this.label_Disposal_OutputMore);
            this.tabPage_General.Controls.Add(this.label_Disposal);
            this.tabPage_General.Controls.Add(this.label_Rent);
            this.tabPage_General.Controls.Add(this.label_Prices);
            this.tabPage_General.Controls.Add(this.tableLayoutPanel1);
            this.tabPage_General.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tabPage_General.Location = new System.Drawing.Point(4, 30);
            this.tabPage_General.Name = "tabPage_General";
            this.tabPage_General.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_General.Size = new System.Drawing.Size(892, 557);
            this.tabPage_General.TabIndex = 0;
            this.tabPage_General.Text = "General";
            // 
            // label_Rent_Output
            // 
            this.label_Rent_Output.AutoSize = true;
            this.label_Rent_Output.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label_Rent_Output.Location = new System.Drawing.Point(435, 310);
            this.label_Rent_Output.Name = "label_Rent_Output";
            this.label_Rent_Output.Size = new System.Drawing.Size(215, 21);
            this.label_Rent_Output.TabIndex = 7;
            this.label_Rent_Output.Text = "$40,- per m3 + disposal costs";
            // 
            // label_Disposal_OutputLess
            // 
            this.label_Disposal_OutputLess.AutoSize = true;
            this.label_Disposal_OutputLess.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label_Disposal_OutputLess.Location = new System.Drawing.Point(435, 355);
            this.label_Disposal_OutputLess.Name = "label_Disposal_OutputLess";
            this.label_Disposal_OutputLess.Size = new System.Drawing.Size(124, 21);
            this.label_Disposal_OutputLess.TabIndex = 6;
            this.label_Disposal_OutputLess.Text = "0 - 2 m3 is $60,-";
            // 
            // label_Disposal_OutputMore
            // 
            this.label_Disposal_OutputMore.AutoSize = true;
            this.label_Disposal_OutputMore.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label_Disposal_OutputMore.Location = new System.Drawing.Point(435, 376);
            this.label_Disposal_OutputMore.Name = "label_Disposal_OutputMore";
            this.label_Disposal_OutputMore.Size = new System.Drawing.Size(121, 21);
            this.label_Disposal_OutputMore.TabIndex = 5;
            this.label_Disposal_OutputMore.Text = "2+ m3 is $125,-";
            // 
            // label_Disposal
            // 
            this.label_Disposal.AutoSize = true;
            this.label_Disposal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label_Disposal.Location = new System.Drawing.Point(317, 355);
            this.label_Disposal.Name = "label_Disposal";
            this.label_Disposal.Size = new System.Drawing.Size(79, 21);
            this.label_Disposal.TabIndex = 4;
            this.label_Disposal.Text = "Disposal:";
            // 
            // label_Rent
            // 
            this.label_Rent.AutoSize = true;
            this.label_Rent.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label_Rent.Location = new System.Drawing.Point(347, 310);
            this.label_Rent.Name = "label_Rent";
            this.label_Rent.Size = new System.Drawing.Size(49, 21);
            this.label_Rent.TabIndex = 3;
            this.label_Rent.Text = "Rent:";
            // 
            // label_Prices
            // 
            this.label_Prices.AutoSize = true;
            this.label_Prices.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label_Prices.Location = new System.Drawing.Point(403, 263);
            this.label_Prices.Name = "label_Prices";
            this.label_Prices.Size = new System.Drawing.Size(59, 21);
            this.label_Prices.TabIndex = 2;
            this.label_Prices.Text = "Prices:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.27856F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.72144F));
            this.tableLayoutPanel1.Controls.Add(this.label_LongestRentalPeriod, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_LongestRentalPeriod_Output, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_AverageVolume_Output, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_TotalProfits_Output, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_TotalProfits, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_AvgVolume, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(257, 40);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(499, 151);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label_LongestRentalPeriod
            // 
            this.label_LongestRentalPeriod.AutoSize = true;
            this.label_LongestRentalPeriod.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label_LongestRentalPeriod.Location = new System.Drawing.Point(3, 95);
            this.label_LongestRentalPeriod.Name = "label_LongestRentalPeriod";
            this.label_LongestRentalPeriod.Size = new System.Drawing.Size(177, 21);
            this.label_LongestRentalPeriod.TabIndex = 5;
            this.label_LongestRentalPeriod.Text = "Longest Rental Period";
            // 
            // label_LongestRentalPeriod_Output
            // 
            this.label_LongestRentalPeriod_Output.AutoSize = true;
            this.label_LongestRentalPeriod_Output.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label_LongestRentalPeriod_Output.Location = new System.Drawing.Point(199, 95);
            this.label_LongestRentalPeriod_Output.Name = "label_LongestRentalPeriod_Output";
            this.label_LongestRentalPeriod_Output.Size = new System.Drawing.Size(91, 21);
            this.label_LongestRentalPeriod_Output.TabIndex = 4;
            this.label_LongestRentalPeriod_Output.Text = "Total Profits";
            // 
            // label_AverageVolume_Output
            // 
            this.label_AverageVolume_Output.AutoSize = true;
            this.label_AverageVolume_Output.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label_AverageVolume_Output.Location = new System.Drawing.Point(199, 45);
            this.label_AverageVolume_Output.Name = "label_AverageVolume_Output";
            this.label_AverageVolume_Output.Size = new System.Drawing.Size(91, 21);
            this.label_AverageVolume_Output.TabIndex = 3;
            this.label_AverageVolume_Output.Text = "Total Profits";
            // 
            // label_TotalProfits_Output
            // 
            this.label_TotalProfits_Output.AutoSize = true;
            this.label_TotalProfits_Output.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label_TotalProfits_Output.Location = new System.Drawing.Point(199, 0);
            this.label_TotalProfits_Output.Name = "label_TotalProfits_Output";
            this.label_TotalProfits_Output.Size = new System.Drawing.Size(91, 21);
            this.label_TotalProfits_Output.TabIndex = 2;
            this.label_TotalProfits_Output.Text = "Total Profits";
            // 
            // label_TotalProfits
            // 
            this.label_TotalProfits.AutoSize = true;
            this.label_TotalProfits.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label_TotalProfits.Location = new System.Drawing.Point(3, 0);
            this.label_TotalProfits.Name = "label_TotalProfits";
            this.label_TotalProfits.Size = new System.Drawing.Size(102, 21);
            this.label_TotalProfits.TabIndex = 0;
            this.label_TotalProfits.Text = "Total Profits";
            // 
            // label_AvgVolume
            // 
            this.label_AvgVolume.AutoSize = true;
            this.label_AvgVolume.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label_AvgVolume.Location = new System.Drawing.Point(3, 45);
            this.label_AvgVolume.Name = "label_AvgVolume";
            this.label_AvgVolume.Size = new System.Drawing.Size(136, 21);
            this.label_AvgVolume.TabIndex = 1;
            this.label_AvgVolume.Text = "Average Volume";
            // 
            // tabPage_Containers
            // 
            this.tabPage_Containers.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage_Containers.Controls.Add(this.tableOverviewPanel);
            this.tabPage_Containers.Location = new System.Drawing.Point(4, 30);
            this.tabPage_Containers.Name = "tabPage_Containers";
            this.tabPage_Containers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Containers.Size = new System.Drawing.Size(892, 557);
            this.tabPage_Containers.TabIndex = 1;
            this.tabPage_Containers.Text = "Containers";
            // 
            // tableOverviewPanel
            // 
            this.tableOverviewPanel.AutoSize = true;
            this.tableOverviewPanel.ColumnCount = 4;
            this.tableOverviewPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableOverviewPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableOverviewPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableOverviewPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableOverviewPanel.Controls.Add(this.label_Container, 0, 0);
            this.tableOverviewPanel.Controls.Add(this.label_Availability, 2, 0);
            this.tableOverviewPanel.Controls.Add(this.label_Volume, 1, 0);
            this.tableOverviewPanel.Location = new System.Drawing.Point(238, 84);
            this.tableOverviewPanel.Name = "tableOverviewPanel";
            this.tableOverviewPanel.RowCount = 2;
            this.tableOverviewPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableOverviewPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableOverviewPanel.Size = new System.Drawing.Size(453, 100);
            this.tableOverviewPanel.TabIndex = 6;
            // 
            // label_Container
            // 
            this.label_Container.AutoSize = true;
            this.label_Container.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label_Container.Location = new System.Drawing.Point(3, 0);
            this.label_Container.Name = "label_Container";
            this.label_Container.Size = new System.Drawing.Size(104, 21);
            this.label_Container.TabIndex = 3;
            this.label_Container.Text = "Container Id";
            // 
            // label_Availability
            // 
            this.label_Availability.AutoSize = true;
            this.label_Availability.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label_Availability.Location = new System.Drawing.Point(230, 0);
            this.label_Availability.Name = "label_Availability";
            this.label_Availability.Size = new System.Drawing.Size(82, 21);
            this.label_Availability.TabIndex = 5;
            this.label_Availability.Text = "Available";
            // 
            // label_Volume
            // 
            this.label_Volume.AutoSize = true;
            this.label_Volume.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label_Volume.Location = new System.Drawing.Point(113, 0);
            this.label_Volume.Name = "label_Volume";
            this.label_Volume.Size = new System.Drawing.Size(111, 21);
            this.label_Volume.TabIndex = 4;
            this.label_Volume.Text = "Total Volume";
            // 
            // tabPage_CheckInputs
            // 
            this.tabPage_CheckInputs.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage_CheckInputs.Controls.Add(this.dateTimePicker_CheckInputEnd);
            this.tabPage_CheckInputs.Controls.Add(this.dateTimePicker_CheckInputBegin);
            this.tabPage_CheckInputs.Controls.Add(this.label_OutputCosts);
            this.tabPage_CheckInputs.Controls.Add(this.label_LongestPeriod);
            this.tabPage_CheckInputs.Controls.Add(this.label_CheckTotalProfits);
            this.tabPage_CheckInputs.Controls.Add(this.label_CheckOutput_LongestPeriod);
            this.tabPage_CheckInputs.Controls.Add(this.label_CheckOutput_TotalProfits);
            this.tabPage_CheckInputs.Controls.Add(this.label_CheckOutput_Costs);
            this.tabPage_CheckInputs.Controls.Add(this.button_CalculateCosts);
            this.tabPage_CheckInputs.Controls.Add(this.textBox_CheckInputContainer);
            this.tabPage_CheckInputs.Controls.Add(this.label_CheckInputEnd);
            this.tabPage_CheckInputs.Controls.Add(this.label_CheckInputBegin);
            this.tabPage_CheckInputs.Controls.Add(this.label_CheckInputContainer);
            this.tabPage_CheckInputs.Location = new System.Drawing.Point(4, 30);
            this.tabPage_CheckInputs.Name = "tabPage_CheckInputs";
            this.tabPage_CheckInputs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_CheckInputs.Size = new System.Drawing.Size(892, 557);
            this.tabPage_CheckInputs.TabIndex = 3;
            this.tabPage_CheckInputs.Text = "Check Containers";
            // 
            // dateTimePicker_CheckInputEnd
            // 
            this.dateTimePicker_CheckInputEnd.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.dateTimePicker_CheckInputEnd.Location = new System.Drawing.Point(592, 138);
            this.dateTimePicker_CheckInputEnd.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_CheckInputEnd.Name = "dateTimePicker_CheckInputEnd";
            this.dateTimePicker_CheckInputEnd.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker_CheckInputEnd.TabIndex = 14;
            // 
            // dateTimePicker_CheckInputBegin
            // 
            this.dateTimePicker_CheckInputBegin.Location = new System.Drawing.Point(344, 138);
            this.dateTimePicker_CheckInputBegin.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_CheckInputBegin.Name = "dateTimePicker_CheckInputBegin";
            this.dateTimePicker_CheckInputBegin.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker_CheckInputBegin.TabIndex = 13;
            // 
            // label_OutputCosts
            // 
            this.label_OutputCosts.AutoSize = true;
            this.label_OutputCosts.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_OutputCosts.Location = new System.Drawing.Point(158, 300);
            this.label_OutputCosts.Name = "label_OutputCosts";
            this.label_OutputCosts.Size = new System.Drawing.Size(52, 23);
            this.label_OutputCosts.TabIndex = 12;
            this.label_OutputCosts.Text = "Costs";
            // 
            // label_LongestPeriod
            // 
            this.label_LongestPeriod.AutoSize = true;
            this.label_LongestPeriod.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_LongestPeriod.Location = new System.Drawing.Point(633, 300);
            this.label_LongestPeriod.Name = "label_LongestPeriod";
            this.label_LongestPeriod.Size = new System.Drawing.Size(129, 23);
            this.label_LongestPeriod.TabIndex = 11;
            this.label_LongestPeriod.Text = "Longest Period";
            // 
            // label_CheckTotalProfits
            // 
            this.label_CheckTotalProfits.AutoSize = true;
            this.label_CheckTotalProfits.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CheckTotalProfits.Location = new System.Drawing.Point(390, 300);
            this.label_CheckTotalProfits.Name = "label_CheckTotalProfits";
            this.label_CheckTotalProfits.Size = new System.Drawing.Size(107, 23);
            this.label_CheckTotalProfits.TabIndex = 10;
            this.label_CheckTotalProfits.Text = "Total Profits";
            // 
            // label_CheckOutput_LongestPeriod
            // 
            this.label_CheckOutput_LongestPeriod.AutoSize = true;
            this.label_CheckOutput_LongestPeriod.Location = new System.Drawing.Point(588, 357);
            this.label_CheckOutput_LongestPeriod.Name = "label_CheckOutput_LongestPeriod";
            this.label_CheckOutput_LongestPeriod.Size = new System.Drawing.Size(0, 21);
            this.label_CheckOutput_LongestPeriod.TabIndex = 9;
            // 
            // label_CheckOutput_TotalProfits
            // 
            this.label_CheckOutput_TotalProfits.AutoSize = true;
            this.label_CheckOutput_TotalProfits.Location = new System.Drawing.Point(416, 357);
            this.label_CheckOutput_TotalProfits.Name = "label_CheckOutput_TotalProfits";
            this.label_CheckOutput_TotalProfits.Size = new System.Drawing.Size(0, 21);
            this.label_CheckOutput_TotalProfits.TabIndex = 8;
            // 
            // label_CheckOutput_Costs
            // 
            this.label_CheckOutput_Costs.AutoSize = true;
            this.label_CheckOutput_Costs.Location = new System.Drawing.Point(158, 357);
            this.label_CheckOutput_Costs.Name = "label_CheckOutput_Costs";
            this.label_CheckOutput_Costs.Size = new System.Drawing.Size(0, 21);
            this.label_CheckOutput_Costs.TabIndex = 7;
            // 
            // button_CalculateCosts
            // 
            this.button_CalculateCosts.Location = new System.Drawing.Point(371, 215);
            this.button_CalculateCosts.Name = "button_CalculateCosts";
            this.button_CalculateCosts.Size = new System.Drawing.Size(143, 35);
            this.button_CalculateCosts.TabIndex = 6;
            this.button_CalculateCosts.Text = "Calculate";
            this.button_CalculateCosts.UseVisualStyleBackColor = true;
            this.button_CalculateCosts.Click += new System.EventHandler(this.button_CalculateCosts_Click);
            // 
            // textBox_CheckInputContainer
            // 
            this.textBox_CheckInputContainer.Location = new System.Drawing.Point(108, 138);
            this.textBox_CheckInputContainer.Name = "textBox_CheckInputContainer";
            this.textBox_CheckInputContainer.Size = new System.Drawing.Size(172, 29);
            this.textBox_CheckInputContainer.TabIndex = 3;
            // 
            // label_CheckInputEnd
            // 
            this.label_CheckInputEnd.AutoSize = true;
            this.label_CheckInputEnd.BackColor = System.Drawing.Color.Transparent;
            this.label_CheckInputEnd.Cursor = System.Windows.Forms.Cursors.Default;
            this.label_CheckInputEnd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CheckInputEnd.Location = new System.Drawing.Point(667, 93);
            this.label_CheckInputEnd.Name = "label_CheckInputEnd";
            this.label_CheckInputEnd.Size = new System.Drawing.Size(40, 23);
            this.label_CheckInputEnd.TabIndex = 2;
            this.label_CheckInputEnd.Text = "End";
            // 
            // label_CheckInputBegin
            // 
            this.label_CheckInputBegin.AutoSize = true;
            this.label_CheckInputBegin.BackColor = System.Drawing.Color.Transparent;
            this.label_CheckInputBegin.Cursor = System.Windows.Forms.Cursors.Default;
            this.label_CheckInputBegin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CheckInputBegin.Location = new System.Drawing.Point(416, 93);
            this.label_CheckInputBegin.Name = "label_CheckInputBegin";
            this.label_CheckInputBegin.Size = new System.Drawing.Size(56, 23);
            this.label_CheckInputBegin.TabIndex = 1;
            this.label_CheckInputBegin.Text = "Begin";
            // 
            // label_CheckInputContainer
            // 
            this.label_CheckInputContainer.AutoSize = true;
            this.label_CheckInputContainer.BackColor = System.Drawing.Color.Transparent;
            this.label_CheckInputContainer.Cursor = System.Windows.Forms.Cursors.Default;
            this.label_CheckInputContainer.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CheckInputContainer.Location = new System.Drawing.Point(144, 93);
            this.label_CheckInputContainer.Name = "label_CheckInputContainer";
            this.label_CheckInputContainer.Size = new System.Drawing.Size(88, 23);
            this.label_CheckInputContainer.TabIndex = 0;
            this.label_CheckInputContainer.Text = "Container";
            // 
            // AppViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(900, 591);
            this.ContextMenuStrip = this.contextMenuStrip;
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "AppViewer";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Container Verhuurbedrijf";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AppViewer_FormClosed);
            this.contextMenuStrip.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage_General.ResumeLayout(false);
            this.tabPage_General.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPage_Containers.ResumeLayout(false);
            this.tabPage_Containers.PerformLayout();
            this.tableOverviewPanel.ResumeLayout(false);
            this.tableOverviewPanel.PerformLayout();
            this.tabPage_CheckInputs.ResumeLayout(false);
            this.tabPage_CheckInputs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_About;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Close;
        private System.Windows.Forms.NotifyIcon notififyIcon;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage_General;
        private System.Windows.Forms.Label label_TotalProfits;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_LongestRentalPeriod;
        private System.Windows.Forms.Label label_LongestRentalPeriod_Output;
        private System.Windows.Forms.Label label_AverageVolume_Output;
        private System.Windows.Forms.Label label_TotalProfits_Output;
        private System.Windows.Forms.Label label_AvgVolume;
        private System.Windows.Forms.Label label_Rent_Output;
        private System.Windows.Forms.Label label_Disposal_OutputLess;
        private System.Windows.Forms.Label label_Disposal_OutputMore;
        private System.Windows.Forms.Label label_Disposal;
        private System.Windows.Forms.Label label_Rent;
        private System.Windows.Forms.Label label_Prices;
        private System.Windows.Forms.TabPage tabPage_Containers;
        private System.Windows.Forms.TableLayoutPanel tableOverviewPanel;
        private System.Windows.Forms.Label label_Container;
        private System.Windows.Forms.Label label_Availability;
        private System.Windows.Forms.Label label_Volume;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem containersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addContainerToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage_CheckInputs;
        private System.Windows.Forms.DateTimePicker dateTimePicker_CheckInputEnd;
        private System.Windows.Forms.DateTimePicker dateTimePicker_CheckInputBegin;
        private System.Windows.Forms.Label label_OutputCosts;
        private System.Windows.Forms.Label label_LongestPeriod;
        private System.Windows.Forms.Label label_CheckTotalProfits;
        private System.Windows.Forms.Label label_CheckOutput_LongestPeriod;
        private System.Windows.Forms.Label label_CheckOutput_TotalProfits;
        private System.Windows.Forms.Label label_CheckOutput_Costs;
        private System.Windows.Forms.Button button_CalculateCosts;
        private System.Windows.Forms.TextBox textBox_CheckInputContainer;
        private System.Windows.Forms.Label label_CheckInputEnd;
        private System.Windows.Forms.Label label_CheckInputBegin;
        private System.Windows.Forms.Label label_CheckInputContainer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
    }
}