using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
namespace garage_assistant
{
    public partial class WorkersForm : Form
    {
        private ApplicationContext db;
        private BindingList<Workers> _workers;
        public WorkersForm()
        {
            db = new ApplicationContext();
            InitializeComponent();
        }

        private void WorkersForm_Load(object sender, EventArgs e)
        {
            this.db.Workers.Load();
            //_workers = db.Workers.Local.ToBindingList().Where(x=>x.IsActive==true);

            var filteredData = db.Workers.Local.Where(x => x.IsActive == true).ToList();
            //_workers = new BindingList<Workers>(filteredData);
            //filteredData.Count() > 0 ?
            //filteredData : filteredData.ToArray();
            this.LBWorkers.DataSource = null;
            this.LBWorkers.DataSource = filteredData;
            this.LBWorkers.DisplayMember = "ShortName";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var id = this.db.Workers.ToList()[this.LBWorkers.SelectedIndex].Id;
            //var item = this.db.Workers.FirstOrDefault(item => item.Id == id);
            var item = this.db.Workers.ToList()[this.LBWorkers.SelectedIndex];
            item.FirstName = this.TBoxFN.Text;
            item.LastName = this.TBoxLN.Text;
            item.Fathers = this.TBoxF.Text;
            this.db.Workers.Update(item);
            this.db.SaveChanges();

            this.LBWorkers.DataSource = null;
            this.LBWorkers.DataSource = _workers;
            this.LBWorkers.DisplayMember = "ShortName";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // var query = db.Workers
            //.Where(s => s.e == "Bill")
            //.FirstOrDefault<Workers>();

            //this.TBoxFN = db.Workers.Find(Name =);

            this.db.Workers.Update(new Workers
            {
                FirstName = this.TBoxFN.Text,
                LastName = this.TBoxLN.Text,
                Fathers = this.TBoxF.Text,
                IsActive = true

            }); 
            this.db.SaveChanges();
        }

        private void LBWorkers_SelectedValueChanged(object sender, EventArgs e)
        {


        }

        private void Delete_Click(object sender, EventArgs e)
        {
            this.db.Workers.ToList()[this.LBWorkers.SelectedIndex].IsActive = false;
            this.db.SaveChanges();
        }
    }
}
