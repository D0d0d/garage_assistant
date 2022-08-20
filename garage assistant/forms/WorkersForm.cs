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
    public partial class WorkersForm : Form
    {
        private ApplicationContext db;
        private bool cleaning;
        public void LoadWorkers()                // Load Workers List to LBWorkers    
        {
            var item = this.LBWorkers.SelectedItem ?? 0;
            this.db.Workers.Load();

            List<Workers> filteredData;
            if (cleaning)
            {
                filteredData = db.Workers.Local.Where(u => u.IsActive == false).OrderByDescending(u => u.IsActive).ThenBy(u => u.ShortName.ToLower()).ToList();
            } else
            {
                filteredData = db.Workers.Local.OrderByDescending(u => u.IsActive).ThenBy(u => u.ShortName.ToLower()).ToList();
            }
            this.LBWorkers.DataSource = null;
            this.LBWorkers.DataSource = filteredData;
            this.LBWorkers.DisplayMember = "ShortName";
            if (LBWorkers.Items.Contains(item) && item != null)
                this.LBWorkers.SelectedItem = item;
            else
                LBWorkers.ClearSelected();
        }
        public WorkersForm()
        {
            db = new ApplicationContext();
            InitializeComponent();
            this.cleaning = false;
        }
        public WorkersForm(bool cleaning)
        {
            this.cleaning = cleaning;
            db = new ApplicationContext();
            InitializeComponent();
        }

        private void WorkersForm_Load(object sender, EventArgs e)
        {
            LoadWorkers();
            LBWorkers.DrawMode = DrawMode.OwnerDrawFixed;        // CHECK
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // get selected Workers entity, change and update it
            var item = this.LBWorkers.SelectedItem as Workers;
            item.FirstName = this.TBoxFN.Text;
            item.LastName = this.TBoxLN.Text;
            item.Fathers = this.TBoxF.Text;
            this.db.Workers.Update(item);
            this.db.SaveChanges();

            // refresh list of Workers
            LoadWorkers();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var item = new Workers
            {
                FirstName = this.TBoxFN.Text,
                LastName = this.TBoxLN.Text,
                Fathers = this.TBoxF.Text,
                IsActive = true
            };

            if (LBWorkers.SelectedItem!=null&& item.FullName == ((Workers)LBWorkers.SelectedItem).FullName)//item.FullName == ((Workers)LBWorkers.SelectedItem).FullName)
            {
                //((Workers)LBWorkers.SelectedItem).IsActive = true;
                this.db.Workers.Update((Workers)LBWorkers.SelectedItem);
            } else
            {
                this.db.Workers.Update(item);
            }
            
            this.db.SaveChanges();

            // refresh list of Workers
            LoadWorkers();
        }

        private void LBWorkers_SelectedValueChanged(object sender, EventArgs e)
        {


        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (LBWorkers.SelectedItem != null)
            {
                Workers worker = ((Workers)this.LBWorkers.SelectedItem);
                if (this.cleaning && this.db.Workers.Contains(worker))
                {
                   
                    var nDoc = this.db.Docs.Where(u => u.WorkersId == worker.Id).ToList();
                    foreach (Docs d in nDoc)
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
                    this.db.Workers.Remove(worker);

                }
                else
                {
                    ((Workers)this.LBWorkers.SelectedItem).IsActive = false;
                }
                this.db.SaveChanges();
                LoadWorkers();
            }
        }

        private void LBWorkers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LBWorkers.SelectedIndex >= 0)
            {
                Workers item = (Workers)this.LBWorkers.SelectedItem;
                this.TBoxFN.Text = item.FirstName;
                this.TBoxLN.Text = item.LastName;
                this.TBoxF.Text = item.Fathers;
                
            }
        }

        private void LBWorkers_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (((ListBox)sender).Items.Count > 0)
            {
                // Draw the background 
                e.DrawBackground();

                Graphics g = e.Graphics;
                // Get the item text
                Workers item = (Workers)((ListBox)sender).Items[e.Index];
                string text = item.ShortName;

                Brush tbrush;

                if (item.IsActive == true)
                {
                    tbrush = new SolidBrush(Color.Black);
                }
                else
                {
                    tbrush = new SolidBrush(Color.DarkGray);
                }
                Brush brush = ((e.State & DrawItemState.Selected) == DrawItemState.Selected) ?
                            new SolidBrush(Color.FromArgb(50, Color.White)) : new SolidBrush(e.BackColor);

                g.FillRectangle(brush, e.Bounds);
                // Draw the text    
                e.Graphics.DrawString(text, e.Font, tbrush, e.Bounds, StringFormat.GenericDefault);

                //e.Graphics.DrawString(this.Items[e.Index].ToString(), e.Font, tBrush, e.Bounds, StringFormat.GenericDefault);

                //TextRenderer.DrawText(text, this.Font, brush, e.Bounds, StringFormat.GenericDefault);
                brush.Dispose();
                tbrush.Dispose();
            }
            
        }
    }
}
