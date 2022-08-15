namespace garage_assistant
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridWorks = new System.Windows.Forms.DataGridView();
            this.workBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ButtonDeleteWork = new System.Windows.Forms.Button();
            this.dataGridDetails = new System.Windows.Forms.DataGridView();
            this.panelWorksButtons = new System.Windows.Forms.Panel();
            this.ClearWorks = new System.Windows.Forms.Button();
            this.panelDetailsButtons = new System.Windows.Forms.Panel();
            this.ClearDetails = new System.Windows.Forms.Button();
            this.ButtonDeleteDetail = new System.Windows.Forms.Button();
            this.panelWorks = new System.Windows.Forms.Panel();
            this.LabelWorksSumm = new System.Windows.Forms.Label();
            this.panelDetails = new System.Windows.Forms.Panel();
            this.LabelDetailsSumm = new System.Windows.Forms.Label();
            this.Apply = new System.Windows.Forms.Button();
            this.LabelTotalSumm = new System.Windows.Forms.Label();
            this.dTPicker = new System.Windows.Forms.DateTimePicker();
            this.TBoxNumb = new System.Windows.Forms.TextBox();
            this.LabelDate = new System.Windows.Forms.Label();
            this.LabelNumber = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolBarFile = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolBarFile_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolBarFile_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolBarSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolBarSettings_Workers = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolBarSettings_Cleaning = new System.Windows.Forms.ToolStripMenuItem();
            this.работникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DocsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.workersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CarButton = new System.Windows.Forms.Button();
            this.CarInfoLabel = new System.Windows.Forms.Label();
            this.CBoxWorker = new garage_assistant.ComboBoxWithDisabling();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWorks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetails)).BeginInit();
            this.panelWorksButtons.SuspendLayout();
            this.panelDetailsButtons.SuspendLayout();
            this.panelWorks.SuspendLayout();
            this.panelDetails.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridWorks
            // 
            this.dataGridWorks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridWorks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridWorks.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridWorks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridWorks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridWorks.EnableHeadersVisualStyles = false;
            this.dataGridWorks.Location = new System.Drawing.Point(3, 6);
            this.dataGridWorks.Name = "dataGridWorks";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridWorks.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridWorks.RowHeadersVisible = false;
            this.dataGridWorks.RowHeadersWidth = 51;
            this.dataGridWorks.RowTemplate.Height = 29;
            this.dataGridWorks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridWorks.Size = new System.Drawing.Size(1092, 484);
            this.dataGridWorks.TabIndex = 0;
            this.dataGridWorks.Tag = "работы";
            this.dataGridWorks.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellLeave);
            this.dataGridWorks.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellValueChanged);
            // 
            // ButtonDeleteWork
            // 
            this.ButtonDeleteWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDeleteWork.Location = new System.Drawing.Point(3, 3);
            this.ButtonDeleteWork.Name = "ButtonDeleteWork";
            this.ButtonDeleteWork.Size = new System.Drawing.Size(92, 36);
            this.ButtonDeleteWork.TabIndex = 3;
            this.ButtonDeleteWork.Tag = "Works";
            this.ButtonDeleteWork.Text = "Удалить";
            this.ButtonDeleteWork.UseVisualStyleBackColor = true;
            // 
            // dataGridDetails
            // 
            this.dataGridDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridDetails.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDetails.EnableHeadersVisualStyles = false;
            this.dataGridDetails.Location = new System.Drawing.Point(3, 6);
            this.dataGridDetails.Name = "dataGridDetails";
            this.dataGridDetails.RowHeadersVisible = false;
            this.dataGridDetails.RowHeadersWidth = 51;
            this.dataGridDetails.RowTemplate.Height = 29;
            this.dataGridDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridDetails.Size = new System.Drawing.Size(1092, 484);
            this.dataGridDetails.TabIndex = 4;
            this.dataGridDetails.Tag = "детали";
            this.dataGridDetails.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellLeave);
            this.dataGridDetails.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellValueChanged);
            // 
            // panelWorksButtons
            // 
            this.panelWorksButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelWorksButtons.Controls.Add(this.ClearWorks);
            this.panelWorksButtons.Controls.Add(this.ButtonDeleteWork);
            this.panelWorksButtons.Location = new System.Drawing.Point(1101, 6);
            this.panelWorksButtons.Name = "panelWorksButtons";
            this.panelWorksButtons.Size = new System.Drawing.Size(99, 88);
            this.panelWorksButtons.TabIndex = 5;
            // 
            // ClearWorks
            // 
            this.ClearWorks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearWorks.Location = new System.Drawing.Point(3, 45);
            this.ClearWorks.Name = "ClearWorks";
            this.ClearWorks.Size = new System.Drawing.Size(92, 36);
            this.ClearWorks.TabIndex = 4;
            this.ClearWorks.Tag = "Works";
            this.ClearWorks.Text = "Очистить";
            this.ClearWorks.UseVisualStyleBackColor = true;
            // 
            // panelDetailsButtons
            // 
            this.panelDetailsButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDetailsButtons.Controls.Add(this.ClearDetails);
            this.panelDetailsButtons.Controls.Add(this.ButtonDeleteDetail);
            this.panelDetailsButtons.Location = new System.Drawing.Point(1101, 6);
            this.panelDetailsButtons.Name = "panelDetailsButtons";
            this.panelDetailsButtons.Size = new System.Drawing.Size(99, 88);
            this.panelDetailsButtons.TabIndex = 6;
            // 
            // ClearDetails
            // 
            this.ClearDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearDetails.Location = new System.Drawing.Point(3, 45);
            this.ClearDetails.Name = "ClearDetails";
            this.ClearDetails.Size = new System.Drawing.Size(92, 36);
            this.ClearDetails.TabIndex = 6;
            this.ClearDetails.Tag = "Works";
            this.ClearDetails.Text = "Очистить";
            this.ClearDetails.UseVisualStyleBackColor = true;
            // 
            // ButtonDeleteDetail
            // 
            this.ButtonDeleteDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDeleteDetail.Location = new System.Drawing.Point(3, 3);
            this.ButtonDeleteDetail.Name = "ButtonDeleteDetail";
            this.ButtonDeleteDetail.Size = new System.Drawing.Size(92, 36);
            this.ButtonDeleteDetail.TabIndex = 3;
            this.ButtonDeleteDetail.Tag = "Details";
            this.ButtonDeleteDetail.Text = "Удалить";
            this.ButtonDeleteDetail.UseVisualStyleBackColor = true;
            // 
            // panelWorks
            // 
            this.panelWorks.AutoSize = true;
            this.panelWorks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelWorks.Controls.Add(this.panelWorksButtons);
            this.panelWorks.Controls.Add(this.dataGridWorks);
            this.panelWorks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWorks.Location = new System.Drawing.Point(3, 3);
            this.panelWorks.Name = "panelWorks";
            this.panelWorks.Size = new System.Drawing.Size(1203, 493);
            this.panelWorks.TabIndex = 7;
            this.panelWorks.Tag = "Works";
            // 
            // LabelWorksSumm
            // 
            this.LabelWorksSumm.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LabelWorksSumm.AutoSize = true;
            this.LabelWorksSumm.Location = new System.Drawing.Point(18, 7);
            this.LabelWorksSumm.Name = "LabelWorksSumm";
            this.LabelWorksSumm.Size = new System.Drawing.Size(151, 20);
            this.LabelWorksSumm.TabIndex = 6;
            this.LabelWorksSumm.Text = "Итого работы:_______";
            // 
            // panelDetails
            // 
            this.panelDetails.Controls.Add(this.panelDetailsButtons);
            this.panelDetails.Controls.Add(this.dataGridDetails);
            this.panelDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetails.Location = new System.Drawing.Point(3, 3);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(1203, 493);
            this.panelDetails.TabIndex = 8;
            this.panelDetails.Tag = "Details";
            // 
            // LabelDetailsSumm
            // 
            this.LabelDetailsSumm.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LabelDetailsSumm.AutoSize = true;
            this.LabelDetailsSumm.Location = new System.Drawing.Point(23, 27);
            this.LabelDetailsSumm.Name = "LabelDetailsSumm";
            this.LabelDetailsSumm.Size = new System.Drawing.Size(146, 20);
            this.LabelDetailsSumm.TabIndex = 10;
            this.LabelDetailsSumm.Text = "Итого детали:_______";
            // 
            // Apply
            // 
            this.Apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Apply.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Apply.Location = new System.Drawing.Point(1091, 650);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(125, 39);
            this.Apply.TabIndex = 9;
            this.Apply.Text = "Получить";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // LabelTotalSumm
            // 
            this.LabelTotalSumm.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LabelTotalSumm.AutoSize = true;
            this.LabelTotalSumm.Location = new System.Drawing.Point(76, 47);
            this.LabelTotalSumm.Name = "LabelTotalSumm";
            this.LabelTotalSumm.Size = new System.Drawing.Size(93, 20);
            this.LabelTotalSumm.TabIndex = 10;
            this.LabelTotalSumm.Text = "Всего:_______";
            // 
            // dTPicker
            // 
            this.dTPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dTPicker.Location = new System.Drawing.Point(1042, 31);
            this.dTPicker.Name = "dTPicker";
            this.dTPicker.Size = new System.Drawing.Size(183, 27);
            this.dTPicker.TabIndex = 23;
            // 
            // TBoxNumb
            // 
            this.TBoxNumb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TBoxNumb.Location = new System.Drawing.Point(812, 31);
            this.TBoxNumb.Name = "TBoxNumb";
            this.TBoxNumb.Size = new System.Drawing.Size(183, 27);
            this.TBoxNumb.TabIndex = 21;
            // 
            // LabelDate
            // 
            this.LabelDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelDate.AutoSize = true;
            this.LabelDate.Location = new System.Drawing.Point(1012, 35);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(24, 20);
            this.LabelDate.TabIndex = 16;
            this.LabelDate.Text = "от";
            // 
            // LabelNumber
            // 
            this.LabelNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelNumber.AutoSize = true;
            this.LabelNumber.Location = new System.Drawing.Point(694, 34);
            this.LabelNumber.Name = "LabelNumber";
            this.LabelNumber.Size = new System.Drawing.Size(116, 20);
            this.LabelNumber.TabIndex = 15;
            this.LabelNumber.Text = "Заказ-наряд №";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 93);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1217, 532);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelWorks);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1209, 499);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Работы";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panelDetails);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1209, 499);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Детали";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolBarFile,
            this.ToolBarSettings});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1245, 28);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolBarFile
            // 
            this.ToolBarFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.ToolBarFile_Save,
            this.ToolBarFile_Open});
            this.ToolBarFile.Name = "ToolBarFile";
            this.ToolBarFile.Size = new System.Drawing.Size(59, 24);
            this.ToolBarFile.Text = "Файл";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.newToolStripMenuItem.Text = "Новый";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // ToolBarFile_Save
            // 
            this.ToolBarFile_Save.Name = "ToolBarFile_Save";
            this.ToolBarFile_Save.Size = new System.Drawing.Size(166, 26);
            this.ToolBarFile_Save.Text = "Сохранить";
            this.ToolBarFile_Save.Click += new System.EventHandler(this.ToolBarFile_Save_Click);
            // 
            // ToolBarFile_Open
            // 
            this.ToolBarFile_Open.Name = "ToolBarFile_Open";
            this.ToolBarFile_Open.Size = new System.Drawing.Size(166, 26);
            this.ToolBarFile_Open.Text = "Открыть";
            this.ToolBarFile_Open.Click += new System.EventHandler(this.ToolBarFile_Open_Click);
            // 
            // ToolBarSettings
            // 
            this.ToolBarSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolBarSettings_Workers,
            this.ToolBarSettings_Cleaning});
            this.ToolBarSettings.Name = "ToolBarSettings";
            this.ToolBarSettings.Size = new System.Drawing.Size(98, 24);
            this.ToolBarSettings.Text = "Настройки";
            // 
            // ToolBarSettings_Workers
            // 
            this.ToolBarSettings_Workers.Name = "ToolBarSettings_Workers";
            this.ToolBarSettings_Workers.Size = new System.Drawing.Size(166, 26);
            this.ToolBarSettings_Workers.Text = "Работники";
            this.ToolBarSettings_Workers.Click += new System.EventHandler(this.WorkersToolStripMenuItem_Click);
            // 
            // ToolBarSettings_Cleaning
            // 
            this.ToolBarSettings_Cleaning.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.работникиToolStripMenuItem,
            this.DocsToolStripMenuItem});
            this.ToolBarSettings_Cleaning.Name = "ToolBarSettings_Cleaning";
            this.ToolBarSettings_Cleaning.Size = new System.Drawing.Size(166, 26);
            this.ToolBarSettings_Cleaning.Text = "Чистка";
            // 
            // работникиToolStripMenuItem
            // 
            this.работникиToolStripMenuItem.Name = "работникиToolStripMenuItem";
            this.работникиToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.работникиToolStripMenuItem.Text = "Работники";
            this.работникиToolStripMenuItem.Click += new System.EventHandler(this.workersToolStripMenuItem_Click);
            // 
            // DocsToolStripMenuItem
            // 
            this.DocsToolStripMenuItem.Name = "DocsToolStripMenuItem";
            this.DocsToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.DocsToolStripMenuItem.Text = "Документы";
            this.DocsToolStripMenuItem.Click += new System.EventHandler(this.DocsToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.LabelTotalSumm);
            this.panel2.Controls.Add(this.LabelDetailsSumm);
            this.panel2.Controls.Add(this.LabelWorksSumm);
            this.panel2.Location = new System.Drawing.Point(805, 627);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 71);
            this.panel2.TabIndex = 21;
            // 
            // workersBindingSource
            // 
            this.workersBindingSource.DataSource = typeof(garage_assistant.Workers);
            // 
            // CarButton
            // 
            this.CarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CarButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CarButton.Location = new System.Drawing.Point(1042, 73);
            this.CarButton.Name = "CarButton";
            this.CarButton.Size = new System.Drawing.Size(183, 28);
            this.CarButton.TabIndex = 25;
            this.CarButton.Text = "Авто";
            this.CarButton.UseVisualStyleBackColor = true;
            this.CarButton.Click += new System.EventHandler(this.CarButton_Click);
            // 
            // CarInfoLabel
            // 
            this.CarInfoLabel.AutoSize = true;
            this.CarInfoLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CarInfoLabel.Location = new System.Drawing.Point(12, 28);
            this.CarInfoLabel.Name = "CarInfoLabel";
            this.CarInfoLabel.Size = new System.Drawing.Size(153, 41);
            this.CarInfoLabel.TabIndex = 26;
            this.CarInfoLabel.Text = "Auto Info";
            // 
            // CBoxWorker
            // 
            this.CBoxWorker.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBoxWorker.FormattingEnabled = true;
            this.CBoxWorker.Location = new System.Drawing.Point(812, 73);
            this.CBoxWorker.Name = "CBoxWorker";
            this.CBoxWorker.PreviousSelectedIndex = 0;
            this.CBoxWorker.Size = new System.Drawing.Size(183, 28);
            this.CBoxWorker.TabIndex = 28;
            this.CBoxWorker.DropDown += new System.EventHandler(this.CBoxWorker_DropDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 710);
            this.Controls.Add(this.CBoxWorker);
            this.Controls.Add(this.CarInfoLabel);
            this.Controls.Add(this.CarButton);
            this.Controls.Add(this.dTPicker);
            this.Controls.Add(this.LabelDate);
            this.Controls.Add(this.LabelNumber);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TBoxNumb);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Garage Assistant";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWorks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetails)).EndInit();
            this.panelWorksButtons.ResumeLayout(false);
            this.panelDetailsButtons.ResumeLayout(false);
            this.panelWorks.ResumeLayout(false);
            this.panelDetails.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button ButtonDeleteWork;
        private BindingSource workBindingSource;
        public DataGridView dataGridWorks;
        private BindingSource workBindingSource1;
        public DataGridView dataGridDetails;
        private Panel panelWorksButtons;
        private Panel panelDetailsButtons;
        private Button ButtonDeleteDetail;
        private Panel panelWorks;
        private Panel panelDetails;
        private Button Apply;
        private Button ClearWorks;
        private Button ClearDetails;
        private Label LabelWorksSumm;
        private Label LabelDetailsSumm;
        private Label LabelTotalSumm;
        private DateTimePicker dTPicker;
        private TextBox TBoxNumb;
        private Label LabelDate;
        private Label LabelNumber;
        private OpenFileDialog openFileDialog1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ToolBarFile;
        private ToolStripMenuItem ToolBarFile_Save;
        private Panel panel2;
        private ToolStripMenuItem ToolBarFile_Open;
        private ToolStripMenuItem ToolBarSettings;
        private ToolStripMenuItem ToolBarSettings_Cleaning;
        private ToolStripMenuItem ToolBarSettings_Workers;
        private Button CarButton;
        private Label CarInfoLabel;
        private BindingSource workersBindingSource;
        private CheckedListBox checkedListBox1;
        private ComboBoxWithDisabling CBoxWorker;
        private ToolStripMenuItem работникиToolStripMenuItem;
        private ToolStripMenuItem DocsToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
    }
}