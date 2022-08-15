namespace garage_assistant
{
    partial class AutoForm
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
            this.TBoxMileage = new System.Windows.Forms.TextBox();
            this.TBoxVIN = new System.Windows.Forms.TextBox();
            this.LabelMileage = new System.Windows.Forms.Label();
            this.LabelVIN = new System.Windows.Forms.Label();
            this.TBoxGN = new System.Windows.Forms.TextBox();
            this.LabelGovNum = new System.Windows.Forms.Label();
            this.LabelRC = new System.Windows.Forms.Label();
            this.TBoxRC = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBoxMileage
            // 
            this.TBoxMileage.Location = new System.Drawing.Point(111, 109);
            this.TBoxMileage.Name = "TBoxMileage";
            this.TBoxMileage.Size = new System.Drawing.Size(125, 27);
            this.TBoxMileage.TabIndex = 28;
            this.TBoxMileage.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // TBoxVIN
            // 
            this.TBoxVIN.Location = new System.Drawing.Point(111, 77);
            this.TBoxVIN.Name = "TBoxVIN";
            this.TBoxVIN.Size = new System.Drawing.Size(125, 27);
            this.TBoxVIN.TabIndex = 27;
            this.TBoxVIN.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // LabelMileage
            // 
            this.LabelMileage.AutoSize = true;
            this.LabelMileage.Location = new System.Drawing.Point(30, 109);
            this.LabelMileage.Name = "LabelMileage";
            this.LabelMileage.Size = new System.Drawing.Size(61, 20);
            this.LabelMileage.TabIndex = 24;
            this.LabelMileage.Text = "Пробег";
            // 
            // LabelVIN
            // 
            this.LabelVIN.AutoSize = true;
            this.LabelVIN.Location = new System.Drawing.Point(58, 77);
            this.LabelVIN.Name = "LabelVIN";
            this.LabelVIN.Size = new System.Drawing.Size(33, 20);
            this.LabelVIN.TabIndex = 23;
            this.LabelVIN.Text = "VIN";
            // 
            // TBoxGN
            // 
            this.TBoxGN.Location = new System.Drawing.Point(111, 44);
            this.TBoxGN.Name = "TBoxGN";
            this.TBoxGN.Size = new System.Drawing.Size(125, 27);
            this.TBoxGN.TabIndex = 26;
            this.TBoxGN.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // LabelGovNum
            // 
            this.LabelGovNum.AutoSize = true;
            this.LabelGovNum.Location = new System.Drawing.Point(14, 44);
            this.LabelGovNum.Name = "LabelGovNum";
            this.LabelGovNum.Size = new System.Drawing.Size(81, 20);
            this.LabelGovNum.TabIndex = 22;
            this.LabelGovNum.Text = "Гос.номер";
            // 
            // LabelRC
            // 
            this.LabelRC.AutoSize = true;
            this.LabelRC.Location = new System.Drawing.Point(74, 12);
            this.LabelRC.Name = "LabelRC";
            this.LabelRC.Size = new System.Drawing.Size(21, 20);
            this.LabelRC.TabIndex = 21;
            this.LabelRC.Text = "rc";
            // 
            // TBoxRC
            // 
            this.TBoxRC.Location = new System.Drawing.Point(111, 12);
            this.TBoxRC.Name = "TBoxRC";
            this.TBoxRC.Size = new System.Drawing.Size(125, 27);
            this.TBoxRC.TabIndex = 25;
            this.TBoxRC.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // Save
            // 
            this.Save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Save.Location = new System.Drawing.Point(111, 203);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(125, 28);
            this.Save.TabIndex = 29;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cancel.Location = new System.Drawing.Point(16, 203);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(89, 28);
            this.Cancel.TabIndex = 30;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // AutoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 243);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.TBoxMileage);
            this.Controls.Add(this.TBoxVIN);
            this.Controls.Add(this.LabelMileage);
            this.Controls.Add(this.LabelVIN);
            this.Controls.Add(this.TBoxGN);
            this.Controls.Add(this.LabelGovNum);
            this.Controls.Add(this.LabelRC);
            this.Controls.Add(this.TBoxRC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AutoForm";
            this.Text = "AutoForm";
            this.Load += new System.EventHandler(this.AutoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label LabelMileage;
        private Label LabelVIN;
        private Label LabelGovNum;
        private Label LabelRC;
        private Button Save;
        private Button Cancel;
        public TextBox TBoxMileage;
        public TextBox TBoxVIN;
        public TextBox TBoxGN;
        public TextBox TBoxRC;
    }
}