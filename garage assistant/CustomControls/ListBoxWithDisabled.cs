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
    public partial class ListBoxWithDisabled : System.Windows.Forms.ListBox
    {
        public ListBoxWithDisabled()
        {
            InitializeComponent();

            DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {

            // Draw the background 
            e.DrawBackground();

            if (e.Index >= 0)
            {

                Graphics g = e.Graphics;
                // Get the item text
                Workers item = (Workers)Items[e.Index];
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
                base.OnDrawItem(e);
            }
        }
    }
}
