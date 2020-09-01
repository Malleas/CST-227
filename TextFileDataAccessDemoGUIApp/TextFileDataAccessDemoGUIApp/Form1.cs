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

namespace TextFileDataAccessDemoGUIApp
{
    public partial class Form1 : Form
    {
        List<Person> people = new List<Person>();
        BindingSource personListBinding = new BindingSource();
        
        public Form1()
        {
           
            InitializeComponent();
            setBindings();
        }
        private void setBindings()
        {
            personListBinding.DataSource = people;
            personsListBox.DataSource = personListBinding;
            personsListBox.DisplayMember = "Display";
           // personsListBox.ValueMember = "Display";

        }

        private void addToListBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!firstNameTextBox.Text.Equals("") && !lastNameTextBox.Text.Equals("") && !urlTextBox.Text.Equals(""))
                {
                    Person person = new Person();
                    person.firstName = firstNameTextBox.Text;
                    person.lastName = lastNameTextBox.Text;
                    person.url = urlTextBox.Text;
                    people.Add(person);
                    firstNameTextBox.Clear();
                    lastNameTextBox.Clear();
                    urlTextBox.Clear();
                    personListBinding.ResetBindings(false);
                }
                else
                {
                    throw new Exception("Entries can not be blank, please ensure all fields are filled in");
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> outputLines = new List<string>();
            string outPath = @"C:\demos\GUIOutput.txt";
            foreach(Person person in people)
            {
                outputLines.Add(person.firstName + "," + person.lastName + "," + person.url);
            }
            File.WriteAllLines(outPath, outputLines);
        }

        private void loadFromFileBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string inPath = @"C:\demos\GUIOutput.txt";
                if (inPath == null)
                {
                    throw new Exception();
                }
                List<string> lines = File.ReadAllLines(inPath).ToList();

                foreach (string line in lines)
                {

                    string[] entries = line.Split(',');
                    Person person = new Person();
                    person.firstName = entries[0];
                    person.lastName = entries[1];
                    person.url = entries[2];

                    people.Add(person);

                    personListBinding.ResetBindings(true);
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
