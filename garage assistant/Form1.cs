using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Windows.Forms;
using System.Data.Entity.Migrations;
using System.Windows;
using System.Diagnostics;

namespace garage_assistant
{
    public partial class Form1 : Form
    {
        ApplicationContext db;
        Docs Doc;

        private void SaveDoc()
        {
            this.Doc.Summs.SummW = 0;
            this.Doc.Summs.SummD = 0;

            this.Doc.Id = Int32.TryParse(this.TBoxNumb.Text, out int id) ? id : new int();
            this.Doc.date = this.dTPicker.Value;
            this.Doc.Worker = this.db.Workers.ToList()[this.CBoxWorker.SelectedIndex];



            this.db.Docs.Update(this.Doc);
            db.SaveChanges();
            PrintDoc printDoc = new PrintDoc();
            this.Doc.Works.Clear();
            this.Doc.Details.Clear();
            foreach (DataGridViewRow row in dataGridWorks.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    Work work = new Work
                    {
                        Name = row.Cells[0].Value != null ? row.Cells[0].Value.ToString() : "",
                        NumType = row.Cells[1].Value != null ? row.Cells[1].Value.ToString() : "",
                        Amount = Int16.Parse(row.Cells[2].Value != null ? row.Cells[2].Value.ToString() : "0"),
                        Price = Double.Parse(row.Cells[3].Value != null ? row.Cells[3].Value.ToString() : "0"),
                        Summ = double.TryParse(row.Cells[4].Value.ToString(), out double sum) ? sum : 0,
                        Doc = this.Doc,
                    };
                    Doc.Summs.SummW += work.Summ;
                    Doc.Works.Add(work);
                }
            }
            foreach (DataGridViewRow row in dataGridDetails.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    Details detail = new Details
                    {
                        Name = row.Cells[0].Value != null ? row.Cells[0].Value.ToString() : "",
                        NumType = row.Cells[1].Value != null ? row.Cells[1].Value.ToString() : "",
                        Amount = Int16.Parse(row.Cells[2].Value != null ? row.Cells[2].Value.ToString() : "0"),
                        Price = Double.Parse(row.Cells[3].Value != null ? row.Cells[3].Value.ToString() : "0"),
                        Summ = double.TryParse(row.Cells[4].Value.ToString(), out double sum) ? sum : 0,
                        Doc = this.Doc,
                    };
                    Doc.Summs.SummD += detail.Summ;
                    Doc.Details.Add(detail);
                }
            }
            db.SaveChanges();
        }
        private void addRow(Work work)
        {
            dataGridWorks.Rows.Add(work.Name, work.NumType, work.Amount, work.Price, work.Summ);
        }
        private void addRow(Details detail)
        {

            dataGridDetails.Rows.Add(detail.Name, detail.NumType, detail.Amount, detail.Price, detail.Summ);
        }
        public Form1()
        {
            InitializeComponent();
            db = new ApplicationContext();
            db.Database.EnsureCreated();
            //Works = new List<Work>();
            //Details = new List<Details>();
            //dataGridWorks.DataSource = Works;
            //dataGridDetails.DataSource = Details;
            //dataGridView1.DataSource = db.Works.Local.ToBindingList();
             
        }
        private void AutoCompleteWork(ItemForm ItForm)
        {
            string[] Names = db.Works.Select(u => u.Name).ToArray();
            ItForm.NameTBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            var sourceN = new AutoCompleteStringCollection();
            sourceN.AddRange(Names);
            ItForm.NameTBox.AutoCompleteCustomSource = sourceN;

            string[] NumType = db.Works.Select(u => u.NumType).ToArray();
            ItForm.NumTypeTBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            var sourceNT = new AutoCompleteStringCollection();
            sourceNT.AddRange(NumType);
            ItForm.PriceTBox.AutoCompleteCustomSource = sourceNT;

            string[] Prices = db.Works.Select(u => u.Price.ToString()).ToArray();
            ItForm.PriceTBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            var sourceP = new AutoCompleteStringCollection();
            sourceP.AddRange(Prices);
            ItForm.PriceTBox.AutoCompleteCustomSource = sourceP;
        }
        private void AutoCompleteDetails(ItemForm ItForm)
        {
            string[] Names = db.Details.Select(u => u.Name).ToArray();
            ItForm.NameTBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            var sourceN = new AutoCompleteStringCollection();
            sourceN.AddRange(Names);
            ItForm.NameTBox.AutoCompleteCustomSource = sourceN;

            string[] NumType = db.Details.Select(u => u.NumType).ToArray();
            ItForm.NumTypeTBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            var sourceNT = new AutoCompleteStringCollection();
            sourceNT.AddRange(NumType);
            ItForm.PriceTBox.AutoCompleteCustomSource = sourceNT;

            string[] Prices = db.Details.Select(u => u.Price.ToString()).ToArray();
            ItForm.PriceTBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            var sourceP = new AutoCompleteStringCollection();
            sourceP.AddRange(Prices);
            ItForm.PriceTBox.AutoCompleteCustomSource = sourceP;
        }
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
                ItemForm ItForm = new ItemForm();
                AutoCompleteWork(ItForm);
                DialogResult result = ItForm.ShowDialog();
                if (result == DialogResult.Cancel)
                    return;
                //Id Name NumType Amount Price Summ
                // создаем Work
                Work work1 = new Work
                {
                    Name = ItForm.NameTBox.Text,
                    NumType = ItForm.NumTypeTBox.Text,
                    Amount = Int16.Parse(ItForm.AmountTBox.Text),
                    Price = Double.Parse(ItForm.PriceTBox.Text),
                };
                work1.Summ = double.TryParse(ItForm.SumLabel.Text, out double sum)?sum:0;
                addRow(work1);
        }
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridWorks.SelectedRows.Count > 0)
            {
                ItemForm ItForm = new ItemForm();
                AutoCompleteWork(ItForm);
                var row = dataGridWorks.SelectedRows[0];
                ItForm.NameTBox.Text = row.Cells[0].Value!=null ? row.Cells[0].Value.ToString() : "";
                ItForm.NumTypeTBox.Text = row.Cells[1].Value!=null ? row.Cells[1].Value.ToString() :"";
                ItForm.AmountTBox.Text = row.Cells[2].Value!=null ? row.Cells[2].Value.ToString() : "";
                ItForm.PriceTBox.Text = row.Cells[3].Value != null ? row.Cells[3].Value.ToString() : "";
                ItForm.SumLabel.Text = row.Cells[4].Value != null ? row.Cells[4].Value.ToString() : "";


                DialogResult result = ItForm.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;

                dataGridWorks.SelectedRows[0].SetValues(
                ItForm.NameTBox.Text,
                ItForm.NumTypeTBox.Text,
                Int16.Parse(ItForm.AmountTBox.Text),
                Double.Parse(ItForm.PriceTBox.Text),
                (double.TryParse(ItForm.SumLabel.Text, out double sum) ? sum : 0)
                );
                dataGridWorks.Refresh(); // обновляем грид

            }
        }
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridWorks.SelectedRows)
            {
                dataGridWorks.Rows.RemoveAt(item.Index);
            }
        }
        private void ButtonAddDetail_Click(object sender, EventArgs e)
        {
            ItemForm ItForm = new ItemForm();
            AutoCompleteDetails(ItForm);
            DialogResult result = ItForm.ShowDialog();
            if (result == DialogResult.Cancel)
                return;
            Details detail = new Details
            {
                Name = ItForm.NameTBox.Text,
                NumType = ItForm.NumTypeTBox.Text,
                Amount = Int16.Parse(ItForm.AmountTBox.Text),
                Price = Double.Parse(ItForm.PriceTBox.Text),
            };
            detail.Summ = double.TryParse(ItForm.SumLabel.Text, out double sum) ? sum : 0;
            addRow(detail);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Doc = new Docs();

            dataGridWorks.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Name",
                HeaderText = "Наименование"
            });
            dataGridWorks.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NumType",
                HeaderText = "Ед.изм."
            });
            dataGridWorks.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Amount",
                HeaderText = "Количество"
            });
            dataGridWorks.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Price",
                HeaderText = "Цена"
            });
            dataGridWorks.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Summ",
                HeaderText = "Сумма"
            });
            foreach (DataGridViewColumn col in dataGridWorks.Columns)
            {
                if (col.Visible)
                {
                    dataGridDetails.Columns.Add((DataGridViewColumn)col.Clone());
                }
            }


            var i = this.CBoxWorker.SelectedIndex;
            this.db.Workers.Load();
            this.CBoxWorker.DataSource = null;
            this.CBoxWorker.DataSource = db.Workers.Local.ToList();
            this.CBoxWorker.DisplayMember = "ShortName";
            this.CBoxWorker.SelectedIndex = i;
        }
        private void Apply_Click(object sender, EventArgs e)
        {

            this.Doc.date = this.dTPicker.Value;
            if (this.Doc.Worker == null) {
                this.Doc.Worker = this.db.Workers.ToList()[this.CBoxWorker.SelectedIndex];
            }
            this.db.Docs.Update(this.Doc);
            db.SaveChanges();
            PrintDoc printDoc = new PrintDoc();
            foreach (DataGridViewRow row in dataGridWorks.Rows) {
                if (row.Cells[0].Value != null)
                {
                    Work work = new Work
                    {
                        Name    = row.Cells[0].Value != null ? row.Cells[0].Value.ToString() : "",
                        NumType = row.Cells[1].Value != null ? row.Cells[1].Value.ToString() : "",
                        Amount  = Int16.Parse(row.Cells[2].Value != null ? row.Cells[2].Value.ToString() : "0"),
                        Price   = Double.Parse(row.Cells[3].Value != null ? row.Cells[3].Value.ToString() : "0"),
                        Summ    = double.TryParse(row.Cells[4].Value.ToString(), out double sum) ? sum : 0,
                        Doc     = this.Doc,
                    };
                    Doc.Works.Add(work);
                    printDoc.AddRowWorks(row.Index+1,work);
                }
            }
            foreach (DataGridViewRow row in dataGridDetails.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    Details detail = new Details
                    {
                        Name    = row.Cells[0].Value != null ? row.Cells[0].Value.ToString() : "",
                        NumType = row.Cells[1].Value != null ? row.Cells[1].Value.ToString() : "",
                        Amount  = Int16.Parse(row.Cells[2].Value != null ? row.Cells[2].Value.ToString() : "0"),
                        Price   = Double.Parse(row.Cells[3].Value != null ? row.Cells[3].Value.ToString() : "0"),
                        Summ    = double.TryParse(row.Cells[4].Value.ToString(), out double sum) ? sum : 0,
                        Doc     = this.Doc,
                    };
                    Doc.Details.Add(detail);
                    printDoc.AddRowDetails(row.Index + 1, detail);
                }
            }
            this.db.Docs.Update(this.Doc);
            db.SaveChanges();
            printDoc.CompleteDoc(this.Doc);
            new Process { StartInfo = new ProcessStartInfo($@".\Заказ_наряд#{this.Doc.Id}.html") { UseShellExecute = true } }.Start();
            //end write text
        }
        private void ButtonEditDetail_Click(object sender, EventArgs e)
        {
            if (dataGridDetails.SelectedRows.Count > 0)
            {
                int index = dataGridDetails.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridDetails[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                ItemForm ItForm = new ItemForm();
                AutoCompleteWork(ItForm);
                var row = dataGridDetails.SelectedRows[0];
                ItForm.NameTBox.Text = row.Cells[0].Value != null ? row.Cells[0].Value.ToString() : "";
                ItForm.NumTypeTBox.Text = row.Cells[1].Value != null ? row.Cells[1].Value.ToString() : "";
                ItForm.AmountTBox.Text = row.Cells[2].Value != null ? row.Cells[2].Value.ToString() : "";
                ItForm.PriceTBox.Text = row.Cells[3].Value != null ? row.Cells[3].Value.ToString() : "";
                ItForm.SumLabel.Text = row.Cells[4].Value != null ? row.Cells[4].Value.ToString() : "";


                DialogResult result = ItForm.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;

                dataGridDetails.SelectedRows[0].SetValues(
                ItForm.NameTBox.Text,
                ItForm.NumTypeTBox.Text,
                Int16.Parse(ItForm.AmountTBox.Text),
                Double.Parse(ItForm.PriceTBox.Text),
                (double.TryParse(ItForm.SumLabel.Text, out double sum) ? sum : 0)
                );
                dataGridDetails.Refresh(); // обновляем грид



            }
        }
        private void ButtonDeleteDetail_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridDetails.SelectedRows)
            {
                dataGridDetails.Rows.RemoveAt(item.Index);
            }
        }
        private void ClearWorks_Click(object sender, EventArgs e)
        {
            dataGridWorks.Rows.Clear();
            dataGridWorks.Refresh();
        }
        private void ClearDetails_Click(object sender, EventArgs e)
        {
            dataGridDetails.Rows.Clear();
            dataGridDetails.Refresh();
        }
        private void LabelSumm_TextChanged(object sender, EventArgs e)
        {
            double sum1 = Double.TryParse(LabelWorksSumm.Text.Split(':')[1], out double sw) ? sw : 0;
            double sum2 = Double.TryParse(LabelDetailsSumm.Text.Split(':')[1], out double sd) ? sd : 0;
            LabelTotalSumm.Text = sum1 + sum2 != 0 ?"Всего:"+(sum1 + sum2).ToString() : "Всего:______";
        }
        private void dataGridWorks_SelectionChanged(object sender, EventArgs e)
        {
            double summ = 0;
            foreach (DataGridViewRow row in dataGridWorks.Rows)
            {
                if (row.Cells[4].Value != null)
                {
                    summ += Double.TryParse(row.Cells[4].Value.ToString(), out double sum) ? sum : 0;
                }
            }
            LabelWorksSumm.Text = summ > 0 ? "Итого работы:" + summ.ToString() : "Итого работы:______";
        }
        private void dataGridDetails_SelectionChanged(object sender, EventArgs e)
        {
            double summ = 0;
            foreach (DataGridViewRow row in dataGridDetails.Rows)
            {
                if (row.Cells[4].Value != null)
                {
                    summ += Double.TryParse(row.Cells[4].Value.ToString(), out double sum) ? sum : 0;
                }
            }
            LabelDetailsSumm.Text = summ > 0 ? "Итого детали:" + summ.ToString() : "Итого детали:______";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButtonOpen_Click(object sender, EventArgs e)
        {

        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {

        }

        private void WorkersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkersForm WrForm = new WorkersForm();
            WrForm.Show();
        }

        private void CarButton_Click(object sender, EventArgs e)
        {
            AutoForm AuForm = new AutoForm();
            AuForm.TBoxRC.Text = Doc.CrInfo.rc;
            AuForm.TBoxGN.Text = Doc.CrInfo.GovNumb;
            AuForm.TBoxVIN.Text = Doc.CrInfo.VIN;
            AuForm.TBoxMileage.Text = Doc.CrInfo.Mileage;

            DialogResult result = AuForm.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;


            this.Doc.CrInfo.rc = AuForm.TBoxRC.Text;
            this.Doc.CrInfo.GovNumb = AuForm.TBoxGN.Text;
            this.Doc.CrInfo.VIN = AuForm.TBoxVIN.Text;
            this.Doc.CrInfo.Mileage = AuForm.TBoxMileage.Text;

            this.CarInfoLabel.Text = this.Doc.CrInfo.rc + " " + this.Doc.CrInfo.GovNumb + " " + this.Doc.CrInfo.VIN + " " + this.Doc.CrInfo.Mileage;
        }

        private void CBoxWorker_DropDown(object sender, EventArgs e)
        {
            var i = this.CBoxWorker.SelectedIndex;
            this.db.Workers.Load();
            this.CBoxWorker.DataSource = null;
            this.CBoxWorker.DataSource = db.Workers.Local.ToList();
            this.CBoxWorker.DisplayMember = "ShortName";
            this.CBoxWorker.SelectedIndex = i;
        }

        private void ToolBarFile_Save_Click(object sender, EventArgs e)
        {
            SaveDoc();
        }

        private void ToolBarFile_Open_Click(object sender, EventArgs e)
        {
            OpenForm OpForm = new OpenForm(db.Docs.Select(u => u.Id).ToList());
            DialogResult result = OpForm.ShowDialog();

            if (result == DialogResult.Cancel)
                return;

            this.Doc = this.db.Docs.Where(u => u.Id == Int32.Parse(OpForm.comboBox1.SelectedItem.ToString())).FirstOrDefault();

            this.TBoxNumb.Text = this.Doc.Id.ToString();
            this.dTPicker.Value = this.Doc.date;
            this.TestLabel.Text = this.Doc.Worker.ShortName;
            //this.CBoxWorker.Text = this.Doc.Worker.ShortName;
            //if (this.Doc.Worker.IsActive==false)
            //{
            //    this.CBoxWorker.Items.Add(this.Doc.Worker);
            //    this.CBoxWorker.SelectedItem = this.Doc.Worker;
            //    this.CBoxWorker.E
            //} 
        }

        private void CBoxWorker_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
 