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
    public partial class AutoForm : Form
    {
        public CarInfo carInfo;
        public AutoForm()
        {
            InitializeComponent();
        }
        public AutoForm(CarInfo cI)
        {
            InitializeComponent();
            carInfo = cI;
        }
        private void AutoForm_Load(object sender, EventArgs e)
        {

        }

        private void TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            switch (tb.Name)
            {
                case "TBoxRC":
                    carInfo.rc = this.TBoxRC.Text;
                    break;
                case "TBoxGN":
                    carInfo.GovNumb = this.TBoxGN.Text;
                    break;
                case "TBoxVIN":
                    carInfo.VIN = this.TBoxVIN.Text;
                    break;
                case "TBoxMileage":
                    carInfo.Mileage = this.TBoxMileage.Text;
                    break;
            }
        }
    }
}
