using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            

        }

        private void capeColorBtn_Click(object sender, EventArgs e)
        {
            if(capeColorDialogBox.ShowDialog() == DialogResult.OK)
            {
               capeColorBtn.BackColor = capeColorDialogBox.Color;
            }

        }

        private void speedHScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            int totalStats = 0;
            if(e.ScrollOrientation == ScrollOrientation.HorizontalScroll)
            {
                speedValueLabel.Text = e.NewValue.ToString();

                try
                {
                    totalStats = e.NewValue + staminaHScrollBar.Value + strengthHScrollBar.Value;
                    if (totalStats > 100)
                    {
                        e.NewValue = e.NewValue - 1;
                        throw new Exception("Stats can not be more than 100, please lower your stats.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void staminaHScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            int totalStats = 0;
            if(e.ScrollOrientation == ScrollOrientation.HorizontalScroll)
            {
                staminaValueLabel.Text = e.NewValue.ToString();

                try
                {
                    totalStats = e.NewValue + speedHScrollBar.Value + strengthHScrollBar.Value;
                    if (totalStats > 100)
                    {
                        e.NewValue = e.NewValue - 1;
                        throw new Exception("Stats can not be more than 100, please lower your stats.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void strengthHScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            int totalStats = 0;
            if(e.ScrollOrientation == ScrollOrientation.HorizontalScroll)
            {
                strengthValueLabel.Text = e.NewValue.ToString();

                try
                {
                    totalStats = e.NewValue + speedHScrollBar.Value + staminaHScrollBar.Value;
                    if (totalStats > 100)
                    {
                        e.NewValue = e.NewValue - 1;
                        throw new Exception("Stats can not be more than 100, please lower your stats.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void villainPotentialTrackBar_Scroll(object sender, EventArgs e)
        {
            villainPotentialValueLabel.Text = villainPotentialTrackBar.Value.ToString();
        }

        private void portraitPictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            //open.Filter = ("Image Files(*.png)");
            if(open.ShowDialog() == DialogResult.OK)
            {
                
                portraitPictureBox.Size = new System.Drawing.Size(240, 240);
                portraitPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
                portraitPictureBox.Image = new Bitmap(open.FileName);
            }
        }

        private void createHeroBtn_Click(object sender, EventArgs e)
        {
            string name = herosNameTextBox.Text;
            ArrayList skills = new ArrayList();
            string officeLocation = officeLocationListBox.SelectedItem.ToString();
            string preferredTravel = "";
            decimal yearsExperience = yearsExperienceNumberSpinner.Value;
            string capeColor = capeColorDialogBox.Color.ToString();
            int villainPotential = villainPotentialTrackBar.Value;
            string portraitFile = portraitPictureBox.Name;
            

            //check skills
            if(superStrengthCheckBox.CheckState == CheckState.Checked)
            {
                skills.Add("Super Strength");
            }
            if(flyCheckBox.CheckState == CheckState.Checked)
            {
                skills.Add("Fly");
            }
            if (xRayVisionCheckBox.CheckState == CheckState.Checked)
            {
                skills.Add("X-Ray Vision");
            }
            if (invisibilityCheckBox.CheckState == CheckState.Checked)
            {
                skills.Add("Invisibility");
            }
            if (absorbEnergyCheckBox.CheckState == CheckState.Checked)
            {
                skills.Add("Absorb Energy");
            }
            if (telepathyCheckBox.CheckState == CheckState.Checked)
            {
                skills.Add("Telepathy");
            }
            if (extremeLuckCheckBox.CheckState == CheckState.Checked)
            {
                skills.Add("Extreme Luck");
            }
            if (forceFieldCheckBox.CheckState == CheckState.Checked)
            {
                skills.Add("Force Field");
            }
            if (explosiveFartsCheckBox.CheckState == CheckState.Checked)
            {
                skills.Add("Explosive Farts");
            }
            if (insectControlCheckBox.CheckState == CheckState.Checked)
            {
                skills.Add("Insect Control");
            }
            if (waterBreathingCheckBox.CheckState == CheckState.Checked)
            {
                skills.Add("Water Breathing");
            }
            if (timeChangerCheckBox.CheckState == CheckState.Checked)
            {
                skills.Add("Time Changer");
            }

            //record dates

            DateTime[] importantDates = new DateTime[3] { birthdayDatePicker.Value, superPowerDiscoveryDatePicker.Value, fatefulDayDatePicker.Value };

            //Preferred Transportation Radio btns

            if (jetpackRadioBtn.Checked)
            {
                preferredTravel = "Jetpack";
            }
            if (landspeederRadioBtn.Checked)
            {
                preferredTravel = "Landspeeder";
            }
            if (teleportRadioBtn.Checked)
            {
                preferredTravel = "Teleport";
            }
            if (batmobileRadioBtn.Checked)
            {
                preferredTravel = "Batmobile";
            }

            //set stats

            int[] stats = new int[3] { speedHScrollBar.Value, staminaHScrollBar.Value, strengthHScrollBar.Value };




            SuperHero superHero = new SuperHero(name, skills, officeLocation, preferredTravel, importantDates, yearsExperience, capeColor, villainPotential, stats, portraitFile);
            

            SuperHeroList.listOfHeros.Add(superHero);

          

            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }

}
