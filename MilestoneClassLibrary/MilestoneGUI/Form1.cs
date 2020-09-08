using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilestoneGUI
{
    public partial class Form1 : Form
    {
        static public int Difficulty { get; set; }

        public Form1()
        {
            InitializeComponent();
            

        }

        private void easyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(easyCheckBox.CheckState == CheckState.Checked)
            {
                Difficulty = 2;
                Form2 f2 = new Form2();
                this.Hide();
                f2.Show();
            }
        }

        private void moderateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (moderateCheckBox.CheckState == CheckState.Checked)
            {
                Difficulty = 66;
                Form2 f2 = new Form2();
                this.Hide();
                f2.Show();
            }
        }

        private void hardCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (hardCheckBox.CheckState == CheckState.Checked)
            {
                Difficulty = 99;
                Form2 f2 = new Form2();
                this.Hide();
                f2.Show();
            }
        }
    }
}
