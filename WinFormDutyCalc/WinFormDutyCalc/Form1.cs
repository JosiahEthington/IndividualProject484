using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormDutyCalc
{
    public partial class Form1 : Form
    {
        double hoursThisyear = 0;
        double hoursLastQuarter = 0;
        double hoursThisQuarter = 0;
        double hoursSinceLastFlight = -1;
        DateTime now; 
        int thisQuarter;
        public Form1()
        {
            InitializeComponent();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            hoursThisyear = 0;
            hoursThisQuarter = 0;
            hoursLastQuarter = 0;
            hoursSinceLastFlight = -1;
            now = System.DateTime.Now;
            thisQuarter = FindQuarter(now);
            string yourFile = fileNameBox.Text;
            StreamReader readFile = new StreamReader(yourFile);
            while (!readFile.EndOfStream)
            {
                string entry = readFile.ReadLine();
                var separated = entry.Split(',');
                DateTime start = Convert.ToDateTime(separated[0]+separated[1]);
                DateTime end = Convert.ToDateTime(separated[0] + separated[2]);
                string hoursAndMinutes = separated[3];
                var hoursSplitter = hoursAndMinutes.Split(':');
                double hours = (Double.Parse(hoursSplitter[0]) + Double.Parse(hoursSplitter[1])/60);
                if (start.Year == now.Year)
                {
                    hoursThisyear += hours;
                }
                int quarter = FindQuarter(start);
                if(quarter == thisQuarter)
                {
                    hoursThisQuarter += hours;
                }else if(thisQuarter - quarter == 1 || thisQuarter - quarter == -3)
                {
                    hoursLastQuarter += hours;
                }
                if(hoursSinceLastFlight < 0 || (now - end).TotalHours < hoursSinceLastFlight)
                {
                    hoursSinceLastFlight = (now - end).TotalHours;
                }
            }
            readFile.Close();
            SetLabels();
        }
        private void SetLabels()
        {
            double hoursLeftInYear = 1400;
            double hoursLeftInQuarter = 500;
            double hoursNextQuarter = 500;
            if(hoursSinceLastFlight > 12)
            {
                requiredRestLabel.Text = "Required Rest Period Remaining: " + "0";
            }
            else
            {
                requiredRestLabel.Text = "Required Rest Period Remaining: " + (12 -hoursSinceLastFlight);
            }

            hoursLeftInYear -= hoursThisyear;
            if (hoursLastQuarter > 300)
            {
                hoursLeftInQuarter = 800 - (hoursLastQuarter + hoursThisQuarter);
            }
            else
            {
                hoursLeftInQuarter -= hoursThisQuarter;
            }
            if(hoursThisQuarter > 300)
            {
                hoursNextQuarter = 800 - hoursThisQuarter;
            }

            hoursThisQuarterLabel.Text = "Hours flown this quarter: " + hoursThisQuarter;
            hoursFlownLastLabel.Text = "Hours flown last quarter: " + hoursLastQuarter;
            hoursLeftThisQuarterLabel.Text = "Hours left this quarter: " + hoursLeftInQuarter;
            hoursLeftThisYearLabel.Text = "Hours left this year: " + hoursLeftInYear;
            hoursAvailableNextQuarterLabel.Text = "Hours available next quarter:" + hoursNextQuarter;


        }

        private int FindQuarter(DateTime date)
        {
            switch (date.Month)
            {
                case 1:
                case 2:
                case 3:
                    return 1;              
                case 4:
                case 5:
                case 6:
                    return 2;
                case 7:
                case 8:
                case 9:
                    return 3;
                case 10:
                case 11:
                case 12:
                    return 4;
                default:
                    return 0;
            }
        }
    }
}
