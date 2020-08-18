using System;
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
    public partial class Form2 : Form
    {


        public Form2()
        {
            InitializeComponent();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = SuperHeroList.listOfHeros;
            heroListBox.DataSource = bindingSource;
            heroListBox.DisplayMember = "name";
            
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Close();
            f1.Show();
        }

        private void heroListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            string skills = "";
            foreach (var abilities in SuperHeroList.listOfHeros[heroListBox.SelectedIndex].Skills)
            {
                skills += abilities + ", ";
            }
            aboutTextBox.Text = "Name: " + SuperHeroList.listOfHeros[heroListBox.SelectedIndex].Name
           + Environment.NewLine + "Special Abilities: " + skills
           + Environment.NewLine + "Birthday: " + SuperHeroList.listOfHeros[heroListBox.SelectedIndex].ImportantDates[0].ToString()
           + Environment.NewLine + "Super Power Discovery Day: " + SuperHeroList.listOfHeros[heroListBox.SelectedIndex].ImportantDates[1].ToString()
           + Environment.NewLine + "Fateful Day: " + SuperHeroList.listOfHeros[heroListBox.SelectedIndex].ImportantDates[2].ToString()
           + Environment.NewLine + "Office Location: " + SuperHeroList.listOfHeros[heroListBox.SelectedIndex].OfficeLocation
           + Environment.NewLine + "Preferred Travel: " + SuperHeroList.listOfHeros[heroListBox.SelectedIndex].PreferredTravel
           + Environment.NewLine + "Years Experience: " + SuperHeroList.listOfHeros[heroListBox.SelectedIndex].YearsExperience.ToString()
           + Environment.NewLine + "Cape Color: " + SuperHeroList.listOfHeros[heroListBox.SelectedIndex].CapeColor
           + Environment.NewLine + "Villain Potential: " + SuperHeroList.listOfHeros[heroListBox.SelectedIndex].VillainPotential.ToString()
           + Environment.NewLine + "Speed: " + SuperHeroList.listOfHeros[heroListBox.SelectedIndex].StatsArray[0].ToString()
           + Environment.NewLine + "Stamina: " + SuperHeroList.listOfHeros[heroListBox.SelectedIndex].StatsArray[1].ToString()
           + Environment.NewLine + "Strength: " + SuperHeroList.listOfHeros[heroListBox.SelectedIndex].StatsArray[2].ToString();

        }
    }
}
