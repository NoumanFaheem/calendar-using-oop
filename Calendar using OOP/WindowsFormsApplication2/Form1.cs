using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    
    public partial class DayLabel : Form
    {
        public static string staticmonth;
        public static string staticyear;

        int month, year;

        public DayLabel()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displayDays();
            timer1.Start();
        }

        public void printCalendar()
        {
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;
            staticmonth = Convert.ToString(month);
            staticyear = Convert.ToString(year);
            DateTime startofthemonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(0);
                DayContainer.Controls.Add(ucdays);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                DayContainer.Controls.Add(ucdays);
            }
        } 

        private void displayDays()
        {
            DateTime now = DateTime.Now;

            month = now.Month;
            year = now.Year;

            printCalendar();

         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DayContainer.Controls.Clear();

            month--;

            if (month > 12)
            {
                month = 1;
                year++;
            }

            else if (month < 1)
            {
                month = 12;
                year--;
            }

            printCalendar();
        }
        private void DayContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            DayContainer.Controls.Clear();

            month++;

            if (month > 12)
            {
                month = 1;
                year++;
            }

            else if (month < 1)
            {
                month = 12;
                year--;
            }

            printCalendar();
           
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label8.Text = DateTime.Now.ToLongTimeString();
            label9.Text = DateTime.Now.ToLongDateString();
        }

    }
}