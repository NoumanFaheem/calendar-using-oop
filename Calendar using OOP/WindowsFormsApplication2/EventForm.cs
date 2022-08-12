using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class EventForm : Form
    {

        public static string eventname;
        public Dictionary<string, string> events = new Dictionary<string, string>();

        public EventForm()
        {
            InitializeComponent();
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            txdate.Text = UserControlDays.staticdate + "/ " + DayLabel.staticmonth + " / " + DayLabel.staticyear;
        }

    

        private void btnsave_Click(object sender, EventArgs e)
        {
            events[txdate.Text] = txevent.Text;
            //events.Add(txdate.Text,txevent.Text);
            eventname = events[txdate.Text];
            eventlbl.Text = eventname;
        }
        public string Txdate
        {
            get { return txdate.Text;}
        }

        public string Eventlbl
        {

            set { eventlbl.Text = value; }
            get { return Eventlbl; }
            
        }

        public string Txevent
        {
            get { return txevent.Text; }
        }
    }
}
