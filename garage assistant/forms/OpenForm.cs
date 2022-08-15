using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace garage_assistant
{
    public partial class OpenForm : Form
    {
        //public OpenForm(List<int> Ids)
        public OpenForm()
        {
            InitializeComponent();
        }
        public OpenForm(List<Docs> docs)
        {
            InitializeComponent();
            this.comboBox1.DataSource = null;
            this.comboBox1.DataSource = docs;
            this.comboBox1.DisplayMember = "Id";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
