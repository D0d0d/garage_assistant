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
        public OpenForm(List<int> Ids)
        {
            InitializeComponent();
            foreach (int i in Ids)
            {
                this.comboBox1.Items.Add(i);
            }

        }

        private void OpenForm_Load(object sender, EventArgs e)
        {

        }
    }
}
