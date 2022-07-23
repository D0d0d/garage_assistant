namespace garage_assistant
{
    partial class ItemForm
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
            this.ItemName = new System.Windows.Forms.Label();
            this.ItemNumType = new System.Windows.Forms.Label();
            this.ItemGroupBox = new System.Windows.Forms.GroupBox();
            this.SumLabel = new System.Windows.Forms.Label();
            this.PriceTBox = new System.Windows.Forms.TextBox();
            this.AmountTBox = new System.Windows.Forms.TextBox();
            this.NumTypeTBox = new System.Windows.Forms.TextBox();
            this.NameTBox = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ItemPrice = new System.Windows.Forms.Label();
            this.ItemAmount = new System.Windows.Forms.Label();
            this.ItemGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemName
            // 
            this.ItemName.AutoSize = true;
            this.ItemName.Location = new System.Drawing.Point(19, 29);
            this.ItemName.Name = "ItemName";
            this.ItemName.Size = new System.Drawing.Size(116, 20);
            this.ItemName.TabIndex = 0;
            this.ItemName.Text = "Наименование";
            // 
            // ItemNumType
            // 
            this.ItemNumType.AutoSize = true;
            this.ItemNumType.Location = new System.Drawing.Point(19, 63);
            this.ItemNumType.Name = "ItemNumType";
            this.ItemNumType.Size = new System.Drawing.Size(58, 20);
            this.ItemNumType.TabIndex = 1;
            this.ItemNumType.Text = "Ед.изм.";
            // 
            // ItemGroupBox
            // 
            this.ItemGroupBox.Controls.Add(this.SumLabel);
            this.ItemGroupBox.Controls.Add(this.PriceTBox);
            this.ItemGroupBox.Controls.Add(this.AmountTBox);
            this.ItemGroupBox.Controls.Add(this.NumTypeTBox);
            this.ItemGroupBox.Controls.Add(this.NameTBox);
            this.ItemGroupBox.Controls.Add(this.Cancel);
            this.ItemGroupBox.Controls.Add(this.OK);
            this.ItemGroupBox.Controls.Add(this.label1);
            this.ItemGroupBox.Controls.Add(this.ItemPrice);
            this.ItemGroupBox.Controls.Add(this.ItemAmount);
            this.ItemGroupBox.Controls.Add(this.ItemName);
            this.ItemGroupBox.Controls.Add(this.ItemNumType);
            this.ItemGroupBox.Location = new System.Drawing.Point(12, 12);
            this.ItemGroupBox.Name = "ItemGroupBox";
            this.ItemGroupBox.Size = new System.Drawing.Size(551, 258);
            this.ItemGroupBox.TabIndex = 3;
            this.ItemGroupBox.TabStop = false;
            this.ItemGroupBox.Text = "Item";
            this.ItemGroupBox.Enter += new System.EventHandler(this.ItemGroupBox_Enter);
            // 
            // SumLabel
            // 
            this.SumLabel.AutoSize = true;
            this.SumLabel.Location = new System.Drawing.Point(244, 165);
            this.SumLabel.Name = "SumLabel";
            this.SumLabel.Size = new System.Drawing.Size(51, 20);
            this.SumLabel.TabIndex = 16;
            this.SumLabel.Text = "_______";
            // 
            // PriceTBox
            // 
            this.PriceTBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.PriceTBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.PriceTBox.Location = new System.Drawing.Point(244, 128);
            this.PriceTBox.Name = "PriceTBox";
            this.PriceTBox.Size = new System.Drawing.Size(301, 27);
            this.PriceTBox.TabIndex = 15;
            this.PriceTBox.TextChanged += new System.EventHandler(this.PriceTBox_TextChanged);
            // 
            // AmountTBox
            // 
            this.AmountTBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.AmountTBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.AmountTBox.Location = new System.Drawing.Point(244, 94);
            this.AmountTBox.Name = "AmountTBox";
            this.AmountTBox.Size = new System.Drawing.Size(301, 27);
            this.AmountTBox.TabIndex = 14;
            this.AmountTBox.TextChanged += new System.EventHandler(this.AmountTBox_TextChanged);
            // 
            // NumTypeTBox
            // 
            this.NumTypeTBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.NumTypeTBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.NumTypeTBox.Location = new System.Drawing.Point(244, 60);
            this.NumTypeTBox.Name = "NumTypeTBox";
            this.NumTypeTBox.Size = new System.Drawing.Size(301, 27);
            this.NumTypeTBox.TabIndex = 13;
            // 
            // NameTBox
            // 
            this.NameTBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.NameTBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.NameTBox.Location = new System.Drawing.Point(244, 22);
            this.NameTBox.Name = "NameTBox";
            this.NameTBox.Size = new System.Drawing.Size(301, 27);
            this.NameTBox.TabIndex = 12;
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(351, 223);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(94, 29);
            this.Cancel.TabIndex = 11;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // OK
            // 
            this.OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK.Location = new System.Drawing.Point(451, 223);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(94, 29);
            this.OK.TabIndex = 10;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Цена, сумм";
            // 
            // ItemPrice
            // 
            this.ItemPrice.AutoSize = true;
            this.ItemPrice.Location = new System.Drawing.Point(19, 131);
            this.ItemPrice.Name = "ItemPrice";
            this.ItemPrice.Size = new System.Drawing.Size(70, 20);
            this.ItemPrice.TabIndex = 3;
            this.ItemPrice.Text = "Цена, шт";
            // 
            // ItemAmount
            // 
            this.ItemAmount.AutoSize = true;
            this.ItemAmount.Location = new System.Drawing.Point(19, 97);
            this.ItemAmount.Name = "ItemAmount";
            this.ItemAmount.Size = new System.Drawing.Size(90, 20);
            this.ItemAmount.TabIndex = 2;
            this.ItemAmount.Text = "Количество";
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 282);
            this.Controls.Add(this.ItemGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ItemForm";
            this.Text = "ItemForm";
            this.ItemGroupBox.ResumeLayout(false);
            this.ItemGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label ItemName;
        private Label ItemNumType;
        private GroupBox ItemGroupBox;
        private Button Cancel;
        private Button OK;
        private Label label1;
        private Label ItemPrice;
        private Label ItemAmount;
        public TextBox PriceTBox;
        public TextBox AmountTBox;
        public TextBox NumTypeTBox;
        public TextBox NameTBox;
        public Label SumLabel;
    }
}