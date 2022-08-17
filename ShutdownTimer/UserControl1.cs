using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShutdownTimer
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
         
        }
        public event KeyPressEventHandler TotalHours_KeyPress;
        public event KeyPressEventHandler TotalMinutes_KeyPress;
        public event KeyPressEventHandler TotalSeconds_KeyPress;
        public event KeyPressEventHandler Hours_KeyPress;
        public event KeyPressEventHandler Minutes_KeyPress;
        public event KeyPressEventHandler Seconds_KeyPress;
        public  int TotalHours
        {
            get
            {
                if (txbTotalHours.Text == "") txbTotalHours.Text = "00";
                return int.Parse(txbTotalHours.Text);
            }
            set
            {
               txbTotalHours.Text = value.ToString("00");
            }
        }
        public int TotalMinutes
        {
            get
            {
                if (txbTotalMinutes.Text == "") txbTotalMinutes.Text ="00";
                return int.Parse(txbTotalMinutes.Text);
            }
            set
            {
                txbTotalMinutes.Text = value.ToString("00");
            }
        }
        public int TotalSeconds
        {
            get
            {
                if (txbTotalSeconds.Text == "") txbTotalSeconds.Text = "00";
                return int.Parse(txbTotalSeconds.Text);
            }
            set
            {
                txbTotalSeconds.Text = value.ToString("00");
            }
        }
        public int Hours
        {
            get
            {
                if (txbHours.Text == "") txbHours.Text = "00";
                return int.Parse(txbHours.Text);
            }
            set
            {
                txbHours.Text = value.ToString("00");
            }
        }
        public int Minutes
        {
            get
            {
                if (txbMinutes.Text =="") txbMinutes.Text = "00";
                return int.Parse(txbMinutes.Text);
            }
            set
            {
                txbMinutes.Text = value.ToString("00");
            }
        }
        public int Seconds
        {
            get
            {
                if (txbSeconds.Text =="") txbSeconds.Text = "00";
                return int.Parse(txbSeconds.Text);
            }
            set
            {
                txbSeconds.Text = value.ToString("00");
            }
        }
        public DateTime Date
        {
            get
            {
                return Datepicker.Value;
            }
            set
            {
                Datepicker.Value = value;
            }
        }
        public event EventHandler CheckBoxTotalTime_OnChange;
        public event EventHandler CheckBoxSelectedTime_OnChange;
        public bool CheckBoxTotalTime_Value
        {
            get
            {
                return chbxTotalTime.Checked;
            }
            set
            {
                chbxTotalTime.Checked = value;
            }
        }
        public bool CheckBoxSelectedTime_Value
        {
            get
            {
                return chbxSelectedTime.Checked;
            }
            set
            {
                chbxSelectedTime.Checked = value;
            }
        }
        private void TxbTotalHours_KeyPress(object sender, KeyPressEventArgs e)
        {
            TotalHours_KeyPress?.Invoke(this, e);
        }

        private void TxbTotalMinutes_KeyPress(object sender, KeyPressEventArgs e)
        {
            TotalMinutes_KeyPress?.Invoke(this, e);
        }

        private void TxbTotalSeconds_KeyPress(object sender, KeyPressEventArgs e)
        {
            TotalSeconds_KeyPress?.Invoke(this, e);
        }

        private void TxbHours_KeyPress(object sender, KeyPressEventArgs e)
        {
            Hours_KeyPress?.Invoke(this, e);
        }

        private void TxbMinutes_KeyPress(object sender, KeyPressEventArgs e)
        {
            Minutes_KeyPress?.Invoke(this, e);
        }

        private void TxbSeconds_KeyPress(object sender, KeyPressEventArgs e)
        {
            Seconds_KeyPress?.Invoke(this, e);
        }
        private void ChbxTotalTime_OnChange(object sender, EventArgs e)
        {
            CheckBoxTotalTime_OnChange(this, e);
        }

        private void ChbxSelectedTime_OnChange(object sender, EventArgs e)
        {
            CheckBoxSelectedTime_OnChange(this, e);
        }
    }
}
