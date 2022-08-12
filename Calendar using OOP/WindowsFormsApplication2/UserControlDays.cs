using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class UserControlDays : UserControl
    {
        EventForm eform = new EventForm();

        public static string staticdate; 
        public UserControlDays()
        {
          
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }

        public void days(int numday)
        {
            if (numday == 0)
            {
                DayLabel.Visible = false;
                button1.Visible = false;
            }
            else
            {
                DayLabel.Visible = true;
                button1.Text = numday + " ";
                DayLabel.Text = numday + " ";
            }
        }
        private void LabelMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) 
            
            {
                string eventnm;
                var ContainsEvent = eform.events.TryGetValue(eform.Txdate, out eventnm);

                if (ContainsEvent)
                {
                    Label l = (Label)sender;

                    toolTip2.SetToolTip(l, eventnm);

                }
            
            }
            else if (e.Button == MouseButtons.Left) 
            
            {
                staticdate = DayLabel.Text;
                eform.Show();
            }

        }    
    }
}
