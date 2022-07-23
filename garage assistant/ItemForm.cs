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
    public partial class ItemForm : Form
    {
        public ItemForm()
        {
            InitializeComponent();
        }
        public void ChangeSumm()
        {
            if (double.TryParse(PriceTBox.Text, out double price) && double.TryParse(AmountTBox.Text, out double amount))
            {
                SumLabel.Text = (price * amount).ToString();
            }
            else
            {
                SumLabel.Text = "_______";
            }
        }
        private void PriceTBox_TextChanged(object sender, EventArgs e)
        {
            ChangeSumm();
        }

        private void AmountTBox_TextChanged(object sender, EventArgs e)
        {
            ChangeSumm();
        }

        private void ItemGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void OK_Click(object sender, EventArgs e)
        {

        }
    }
}
