using System.Data;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.EntityFrameworkCore;
using System.Collections;
namespace garage_assistant
{
    public partial class Form1 : Form
    {
        ApplicationContext db;
        Docs Doc;

        BindingSource bsw,bsd;

        Dictionary<string, string> desiredColumns = new Dictionary<string, string>()    // Dictioary of allowed visible columns
         {
          {"Name", "Наименование"},
          {"NumType", "Ед.изм."},
          {"Amount", "Количество"},
          {"Price", "Цена"},
          {"Summ", "Сумма"}
         };

        public void calculate_Summ()                                                    // method calculating and showing summs in labels
        {
            LabelWorksSumm.Text = this.Doc.TotalWorks != null ? "Итого работы: " + this.Doc.TotalWorks.ToString() : "Итого работы:_______";
            LabelDetailsSumm.Text = this.Doc.TotalDetails != null ? "Итого детали: " + this.Doc.TotalDetails.ToString() : "Итого детали:_______";
            LabelTotalSumm.Text = "Всего: " + this.Doc.Total.ToString();
        }
        void bindingSource_AddingNew(object sender, AddingNewEventArgs e, Type type)    // universal method for DataGrids BindingSource. Works with all types
        {
            e.NewObject = Activator.CreateInstance(type,null);                          // calling constructor of type "type"
        }
                  
        private void SaveDoc()
        {
            this.Doc.Id = Int32.TryParse(this.TBoxNumb.Text, out int id) ? id : new int();  // check if user want to use custom ID
            this.Doc.date = this.dTPicker.Value;                                            
            if (this.Doc.Worker == null && this.CBoxWorker.SelectedItem != null)            // check if current doc doesnt have worker and any worker selected
            {
                this.Doc.Worker = (Workers)this.CBoxWorker.SelectedItem;                    // just take worker from worker combobox
            }
            else if (this.Doc.Worker == null)                                               // if current doc doesnt have worker but no worker selected
            {
                MessageBox.Show("Выберите работника!");                                     // show hint to choose worker and exit from func
                return;
            }
            this.db.Docs.Update(this.Doc);                                                 
            db.SaveChanges();

        }
        public Form1()                                                                      // this is just has to be there
        {
            InitializeComponent();
            db = new ApplicationContext();
            db.Database.EnsureCreated();
        }
        private void ButtonDelete_Click<T>(object sender, EventArgs e, DataGridView dGV, List<T> DbSt) where T : class, IDbSet      // method for both datagridview delete buttons
        {
            foreach (DataGridViewRow item in dGV.SelectedRows)
            {
                dGV.Rows.RemoveAt(item.Index);                                                                                      // removing row from datagridview rows calls removing same row from binded source
            }
            this.db.SaveChanges();
        }
        private void Bind_Table<T>(BindingSource BS, DataGridView dGV, List<T> table, Type type) where T : class, IDbSet        // func for usable binding Table to DataGrid
        {
            BS = new BindingSource();                                                                                           // initialize new Binding Source to given 
            BS.DataSource = table;
            BS.AddingNew +=
                delegate (object sender, AddingNewEventArgs e) { bindingSource_AddingNew(sender, e, type); };                   // add custom AddingNew 

            BS.AllowNew = true;

            dGV.DataSource = BS;                                                                                                 // bind BindingSource to datagridview
            dGV.Columns.Cast<DataGridViewColumn>()                                                                               // and hide restricted columns
                                .Where(u => !desiredColumns.ContainsKey(u.DataPropertyName))
                                .ToList().ForEach(u => u.Visible = false);                                                      
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Doc = new Docs();
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///
            ///
            ///     Making columns
            ///
            /**/    foreach (var i in desiredColumns)                                  
            /**/    {
            /**/        dataGridWorks.Columns.Add(new DataGridViewTextBoxColumn
            /**/        {
            /**/            DataPropertyName = i.Key,
            /**/            HeaderText = i.Value,
            /**/            Name = i.Key,
            /**/        });
            /**/        dataGridDetails.Columns.Add(new DataGridViewTextBoxColumn
            /**/        {
            /**/            DataPropertyName = i.Key,
            /**/            HeaderText = i.Value,
            /**/            Name = i.Key,
            /**/        });
            /**/    }
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///
            ///
            ///     Workers Combobox Part
            /// 
            /**/    this.db.Workers.Load();
            /**/    this.CBoxWorker.DataSource = null;
            /**/    this.CBoxWorker.DataSource = db.Workers.Local.OrderByDescending(u => u.IsActive).ThenBy(u => u.ShortName.ToLower()).ToList();  
            /**/    this.CBoxWorker.DisplayMember = "ShortName";
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///
            ///
            ///     Binding Tables 
            /// 
            /**/    Bind_Table(bsw,dataGridWorks,Doc.Works,typeof(Work));
            /**/    Bind_Table(bsd, dataGridDetails, Doc.Details, typeof(Details));
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///
            ///
            ///     Adding  Handlers Zone
            ///     
            /**/    dataGridWorks.EditingControlShowing +=
            /**/       delegate (object sender, DataGridViewEditingControlShowingEventArgs e)
            /**/            { dataGridView_EditingControlShowing(sender, e, db.Works); };
            /**/
            /**/    dataGridDetails.EditingControlShowing +=
            /**/        delegate (object sender, DataGridViewEditingControlShowingEventArgs e)
            /**/            { dataGridView_EditingControlShowing(sender, e, db.Details); };
            /**/
            /**/
            /**/    ButtonDeleteWork.Click += 
            /**/        delegate (object sender, EventArgs e)
            /**/        { ButtonDelete_Click<Work>(sender, e, dataGridWorks, this.Doc.Works); }; 
            /**/
            /**/    ButtonDeleteDetail.Click +=
            /**/        delegate (object sender, EventArgs e)
            /**/        { ButtonDelete_Click<Details>(sender, e, dataGridDetails, this.Doc.Details); };
            /**/
            /**/
            /**/    ClearWorks.Click += delegate (object sender, EventArgs e) { Clear_Click(sender, e, dataGridWorks); };
            /**/    ClearDetails.Click += delegate (object sender, EventArgs e) { Clear_Click(sender,e,dataGridDetails); };
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////  
        }
        private void Apply_Click(object sender, EventArgs e)                 
        {

            SaveDoc();
            
            PrintDoc printDoc = new PrintDoc();                             // create printDoc utility and add rows from Doc 
            foreach (Work work in Doc.Works)                                // TODO
            {
                
                printDoc.AddRowWorks(Doc.Works.ToList().IndexOf(work),work);
            }
            foreach (Details detail in Doc.Details)
            {

                printDoc.AddRowDetails(Doc.Details.ToList().IndexOf(detail), detail);
            }

            this.db.Docs.Update(this.Doc);
            db.SaveChanges();
            printDoc.CompleteDoc(this.Doc);
            new Process { StartInfo = new ProcessStartInfo($@".\Заказ_наряд#{this.Doc.Id}.html") { UseShellExecute = true } }.Start();
            //end write text
        }
        private void Clear_Click(object sender, EventArgs e, DataGridView dGV)      //  universal method for clear buttons on datagridview panels
        {
            dGV.Rows.Clear();
            dGV.Refresh();
            calculate_Summ();                                                       // changing values from code doesnt call cellvaluechanged
        }
        private void WorkersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkersForm WrForm = new WorkersForm();
            WrForm.Show();
        }
        private void CarButton_Click(object sender, EventArgs e)                    // call AutoForm and change CarInfo
        {
            AutoForm AuForm = new AutoForm(this.Doc.CrInfo);
            DialogResult result = AuForm.ShowDialog(this);
            if (result == DialogResult.Cancel)
                return;

            this.Doc.CrInfo = AuForm.carInfo;
            this.CarInfoLabel.Text = this.Doc.CrInfo.String;                        
        }
        private void ToolBarFile_Save_Click(object sender, EventArgs e)
        {
            SaveDoc();
        }
        private void ToolBarFile_Open_Click(object sender, EventArgs e)             // call Doc OpenForm and change Doc
        {
            OpenForm OpForm = new OpenForm(db.Docs.ToList());
            DialogResult result = OpForm.ShowDialog();
            if (result == DialogResult.Cancel)
                return;


            this.Doc = (Docs)OpForm.comboBox1.SelectedItem;

            this.TBoxNumb.Text = this.Doc.Id.ToString();
            this.dTPicker.Value = this.Doc.date;
            this.CBoxWorker.SelectedItem = this.Doc.Worker;


            db.Works.Load();
            db.Details.Load();

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///
            ///
            ///     Binding Tables 
            /// 
            /**/    Bind_Table(bsw,dataGridWorks,Doc.Works,typeof(Work));
            /**/    Bind_Table(bsd, dataGridDetails, Doc.Details, typeof(Details));
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)      // universal CellValueChanged for both datagridviews. 
        {
            if (e.ColumnIndex == 4 || e.ColumnIndex == 3)                                           // if calculatable cells changed -> calculate summ
            {
                calculate_Summ();
            };
        }

        KeyPressEventHandler KeyPressOld;                                                           // these two lines have to be there for EditingControlShowing
        TextBox tb = new TextBox();
        private void dataGridView_EditingControlShowing<T>(object sender, DataGridViewEditingControlShowingEventArgs e, DbSet<T> DbSt) where T : class, IDbSet // this is universal method for manipulating the behaivor of cells editing     
        {
            tb.KeyPress -= KeyPressOld;                                                             // deleting old delegate from old control
            DataGridView dataGridView = (DataGridView)sender;                                       // get selected DataGridView
            tb  = e.Control as TextBox;                                                             // reset control
            tb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            AutoCompleteStringCollection sourceP = new AutoCompleteStringCollection();

            if ((dataGridView.CurrentCell.ColumnIndex == dataGridView.Columns["Name"].Index))       // if selected column is Name column -> add autocomplete
            {
                if (tb != null)
                {
                    var arr = DbSt.Select(u => u.Name.ToString()).ToArray();
                    sourceP.AddRange(arr);
                }
            }
            if ((dataGridView.CurrentCell.ColumnIndex == dataGridView.Columns["NumType"].Index))    // if selected column is NumType column -> add autocomplete
            {
                if (tb != null)
                {
                    sourceP.AddRange(DbSt.Select(u => u.NumType.ToString()).ToArray());
                }
            }
            if ((dataGridView.CurrentCell.ColumnIndex == dataGridView.Columns["Price"].Index))      // if selected column is Price column -> add autocomplete and KeyPress for handling inputing format
            {
                if (tb != null)
                {
                    KeyPressOld = delegate (object sender, KeyPressEventArgs e) { AnyColumnKeyPress(sender, e, "decimal"); };   // create and save delegate for clear work
                    tb.KeyPress += KeyPressOld;
                    sourceP.AddRange(DbSt.Select(u => u.Price.ToString()).ToArray()); 
                }
            }
            if ((dataGridView.CurrentCell.ColumnIndex == dataGridView.Columns["Amount"].Index))     // if selected column is Amount column -> add autocomplete and KeyPress for handling inputing format
            {
                if (tb != null)
                {
                    KeyPressOld = delegate (object sender, KeyPressEventArgs e) { AnyColumnKeyPress(sender, e, "int"); };       // create and save delegate for clear work
                    tb.KeyPress += KeyPressOld;
                }
            }
            tb.AutoCompleteCustomSource = sourceP;
            tb.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        private void AnyColumnKeyPress(object sender, KeyPressEventArgs e, string type)         // method for handling inputing format
        {
            switch (type)
            {
                case "decimal":
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' || (e.KeyChar == ',' && ((TextBox)sender).Text.Contains(',')))   // this allows one coma for decimal
                    {
                        e.Handled = true;
                    }
                    break;
                case "int":
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))             // this allows only digit
                    {
                        e.Handled = true;
                    }
                    break;
            }
        }

        private void dataGridView_CellLeave(object sender, DataGridViewCellEventArgs e)         // aditional format checker. if value is not correct make it == 0
        {
            DataGridView dataGridView = (DataGridView)sender;
            DataGridViewCell cell = dataGridView[e.ColumnIndex, e.RowIndex];
            if ((dataGridView.CurrentCell.ColumnIndex == dataGridView.Columns["Price"].Index) || (dataGridView.CurrentCell.ColumnIndex == dataGridView.Columns["Amount"].Index))
            {
                string val = cell.EditedFormattedValue.ToString();
                if (val == "," || val == "") { 
                cell.Value = 0;
                }
            }
        }

        private void workersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkersForm WrForm = new WorkersForm(true);
            WrForm.Show();
        }

        private void DocsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteForm deleteForm = new DeleteForm();
            deleteForm.Show();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Doc = new Docs();
        }
<<<<<<< HEAD


        private void организацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrgForm orgForm = new OrgForm(this.db.orgInfo());
            DialogResult result = orgForm.ShowDialog(this);
            if (result == DialogResult.Cancel)
                return;

            this.db.orgInfo(orgForm.orgInfo);
            this.db.SaveChanges();
        }

        private void базаДанныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = Microsoft.VisualBasic.Interaction.InputBox("Вы действительно хотите удалить базу данных? Это сотрет все записи! Введите 'Я действительно хочу удалить базу данных'", "Удаление базы данных", "");
            if (text == "Я действительно хочу удалить базу данных")
            {
                db.Database.EnsureDeleted();

                db = new ApplicationContext();
                db.Database.EnsureCreated();
            }
        }

=======
>>>>>>> parent of 7a79ec7 ()
        private void CBoxWorker_DropDown(object sender, EventArgs e)
        {
            var item = this.CBoxWorker.SelectedItem;
            this.db.Workers.Load();
            this.CBoxWorker.DataSource = null;

            this.CBoxWorker.DataSource = db.Workers.Local.OrderByDescending(u => u.IsActive).ThenBy(u => u.ShortName.ToLower()).ToList();
            this.CBoxWorker.DisplayMember = "ShortName";
            this.CBoxWorker.SelectedItem=item;
        }
    }
}
 