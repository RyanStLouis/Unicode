/*
 * Created by: Ryan St. Louis
 * Created on: 16-10-2015
 * Created for: ICS3U
 * Daily Assignment – unit# 3-11
 * This program displays ASCII
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

namespace Unicode
{
    public partial class frmUnicode : Form
    {
        public frmUnicode()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            // Varibles
            const int maxNumber = 91;
            // Process
            for (int loopCounter = 65; loopCounter != maxNumber; loopCounter++)
            {
                this.lstAnswer.Items.Add(Char.ConvertFromUtf32(loopCounter) + " --> " + loopCounter);
            }
        }
    }
}
