using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
namespace garage_assistant
{
    public partial class DeleteForm : Form
    {
        private ApplicationContext db;
        public DeleteForm()
        {
            db = new ApplicationContext();
            InitializeComponent();
        }
        public void LoadDocs() { 
            var item = this.comboBox1.SelectedItem ?? 0;
            this.db.Docs.Load();

            List<Docs> filteredData;
            filteredData = db.Docs.Local.OrderByDescending(u => u.Id).ToList();

            this.comboBox1.DataSource = null;
            this.comboBox1.DataSource = filteredData;
            this.comboBox1.DisplayMember = "Id";
            if (comboBox1.Items.Contains(item) && item != null)
                this.comboBox1.SelectedItem = item;
            else
                comboBox1.SelectionLength = 0;
        }
        private void DeleteForm_Load(object sender, EventArgs e)
        {
            LoadDocs();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Docs d = (Docs)this.comboBox1.SelectedItem;
            if (d != null)
            {
                foreach (var work in db.Works.Where(u => u.DocId == d.Id).ToList())
                {
                    db.Works.Remove(work);
                };
                foreach (var detail in db.Details.Where(u => u.DocId == d.Id).ToList())
                {
                    db.Details.Remove(detail);
                };
                this.db.Docs.Remove(d);
            }
            this.db.SaveChanges();
            LoadDocs();
        }
    }
}
