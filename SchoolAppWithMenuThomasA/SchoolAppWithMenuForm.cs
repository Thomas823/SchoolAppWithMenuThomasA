/*
 * Created by: Thomas Aubin
 * Created on: 07-Feb-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #4 - School App
 * This program displays the school name and their school team name, as well as a menu.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolAppWithMenuThomasA
{
    public partial class frmSchoolAppWithMenu : Form
    {
        public frmSchoolAppWithMenu()
        {
            InitializeComponent();
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            // Close the program
            this.Close();
        }
    }
}