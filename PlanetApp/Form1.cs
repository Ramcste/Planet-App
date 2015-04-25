using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanetApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Dictionary<string, int> dict = new Dictionary<string, int>();

            //dict.Add("Mercury",1);
            //dict.Add("Venus",2);
            //dict.Add("Earth",3);
            //dict.Add("Mars",4);
            //dict.Add("Jupiter",5);
            //dict.Add("Saturn",6);
            //dict.Add("Uranus", 7);
            //dict.Add("Neptune", 8);



        }


       

        // Mercury, Venus, Earth, Mars, Jupiter, Saturn, Uranus, Neptune.

        private void showDetailsButton_Click(object sender, EventArgs e)
        {
            if (planetListComboBox.SelectedItem == "Mercury")
            {
                MessageBox.Show("It is in 1st position");
            }

            else if (planetListComboBox.SelectedItem == "Venus")
            {
                MessageBox.Show("It is in 2nd position");
            }
            else if (planetListComboBox.SelectedItem == "Earth")
            {
                MessageBox.Show("It is in 3rd position");
            }
            else  if (planetListComboBox.SelectedItem == "Mars")
            {
                MessageBox.Show("It is in 4th position");
            }
            else if (planetListComboBox.SelectedItem == "Jupiter")
            {
                MessageBox.Show("It is in 5th position");
            }
            else if (planetListComboBox.SelectedItem == "Saturn")
            {
                MessageBox.Show("It is in 6th position");
            }

            else if (planetListComboBox.SelectedItem == "Uranus")
            {
                MessageBox.Show("It is in 7th position");
            }

            else if (planetListComboBox.SelectedItem == "Neptune")
            {
                MessageBox.Show("It is in 8th position");
            }

            else
            {
                MessageBox.Show("You haven't selected");
            }
      
        }
    }
}
