namespace garage_assistant
{
    partial class WorkersForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.Delete = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.TBoxF = new System.Windows.Forms.TextBox();
            this.Edit = new System.Windows.Forms.Button();
            this.TBoxLN = new System.Windows.Forms.TextBox();
            this.TBoxFN = new System.Windows.Forms.TextBox();
            this.Fathers = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.workersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LBWorkers = new System.Windows.Forms.ListBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.Delete);
            this.panel3.Controls.Add(this.Add);
            this.panel3.Controls.Add(this.TBoxF);
            this.panel3.Controls.Add(this.Edit);
            this.panel3.Controls.Add(this.TBoxLN);
            this.panel3.Controls.Add(this.TBoxFN);
            this.panel3.Controls.Add(this.Fathers);
            this.panel3.Controls.Add(this.LastName);
            this.panel3.Controls.Add(this.FirstName);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(365, 254);
            this.panel3.TabIndex = 15;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(238, 210);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(94, 29);
            this.Delete.TabIndex = 19;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(138, 210);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(94, 29);
            this.Add.TabIndex = 18;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.button2_Click);
            // 
            // TBoxF
            // 
            this.TBoxF.Location = new System.Drawing.Point(161, 123);
            this.TBoxF.Name = "TBoxF";
            this.TBoxF.Size = new System.Drawing.Size(125, 27);
            this.TBoxF.TabIndex = 28;
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(38, 210);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(94, 29);
            this.Edit.TabIndex = 17;
            this.Edit.Text = "Изменить";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.button1_Click);
            // 
            // TBoxLN
            // 
            this.TBoxLN.Location = new System.Drawing.Point(161, 91);
            this.TBoxLN.Name = "TBoxLN";
            this.TBoxLN.Size = new System.Drawing.Size(125, 27);
            this.TBoxLN.TabIndex = 27;
            // 
            // TBoxFN
            // 
            this.TBoxFN.Location = new System.Drawing.Point(161, 59);
            this.TBoxFN.Name = "TBoxFN";
            this.TBoxFN.Size = new System.Drawing.Size(125, 27);
            this.TBoxFN.TabIndex = 26;
            // 
            // Fathers
            // 
            this.Fathers.AutoSize = true;
            this.Fathers.Location = new System.Drawing.Point(83, 123);
            this.Fathers.Name = "Fathers";
            this.Fathers.Size = new System.Drawing.Size(72, 20);
            this.Fathers.TabIndex = 25;
            this.Fathers.Text = "Отчество";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(82, 91);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(73, 20);
            this.LastName.TabIndex = 24;
            this.LastName.Text = "Фамилия";
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(116, 59);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(39, 20);
            this.FirstName.TabIndex = 23;
            this.FirstName.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(30, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 32);
            this.label1.TabIndex = 22;
            this.label1.Text = "Работник";
            // 
            // workersBindingSource
            // 
            this.workersBindingSource.DataSource = typeof(garage_assistant.Workers);
            // 
            // LBWorkers
            // 
            this.LBWorkers.DataSource = this.workersBindingSource;
            this.LBWorkers.DisplayMember = "ShortName";
            this.LBWorkers.FormattingEnabled = true;
            this.LBWorkers.ItemHeight = 20;
            this.LBWorkers.Location = new System.Drawing.Point(423, 12);
            this.LBWorkers.Name = "LBWorkers";
            this.LBWorkers.Size = new System.Drawing.Size(365, 424);
            this.LBWorkers.TabIndex = 16;
            this.LBWorkers.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.LBWorkers_DrawItem);
            this.LBWorkers.SelectedIndexChanged += new System.EventHandler(this.LBWorkers_SelectedIndexChanged);
            // 
            // WorkersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LBWorkers);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "WorkersForm";
            this.Text = "WorkersForm";
            this.Load += new System.EventHandler(this.WorkersForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel3;
        private TextBox TBoxF;
        private TextBox TBoxLN;
        private TextBox TBoxFN;
        private Label Fathers;
        private Label LastName;
        private Label FirstName;
        private Label label1;
        private BindingSource workersBindingSource;
        private Button Edit;
        private Button Add;
        private Button Delete;
        private ListBox LBWorkers;
    }
}