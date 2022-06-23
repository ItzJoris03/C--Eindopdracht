using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ContainerVerhuurBedrijf
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        System.Windows.Forms.Timer tmr;

        private void SplashScreen_Shown(object sender, EventArgs e)
        {
            Thread.Sleep(500);
            tmr = new System.Windows.Forms.Timer();

            //set time interval 3 sec

            tmr.Interval = 3000;

            //starts the timer

            tmr.Start();
            
            while(this.progressBar.Value != 100)
            {
                Thread.Sleep(10);
                this.progressBar.Value += 1;
            }
            

            tmr.Tick += tmr_Tick;

        }

        void tmr_Tick(object sender, EventArgs e)
        {

            //after 3 sec stop the timer

            tmr.Stop();

            //display mainform

            AppViewer app = new AppViewer();

            app.Show();

            //hide this form

            this.Hide();

        }
    }
}
