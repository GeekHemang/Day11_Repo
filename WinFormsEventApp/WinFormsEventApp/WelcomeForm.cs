using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsEventApp
{
    public partial class WelcomeForm:Form
    {
        public WelcomeForm()
        {
            InitializeComponent();


            btnClickMe.Click += CallBack1;
            btnClickMe.Click += CallBack2;



        }

        void CallBack1(object sender,EventArgs e) {

            MessageBox.Show("God is listening!!");
        }
        void CallBack2(object sender, EventArgs e)
        {

            MessageBox.Show("Devil is listening!!");
        }
    }
}
