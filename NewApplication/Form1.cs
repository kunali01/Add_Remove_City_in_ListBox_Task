using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Check if the textbox is not empty
            if (!string.IsNullOrWhiteSpace(txtCity.Text))
            {
                // Check if the city already exists in the list box
                if (!listBoxCities.Items.Contains(txtCity.Text))
                {
                    // Add the text to the listbox
                    listBoxCities.Items.Add(txtCity.Text);
                    // Clear the textbox for the next input
                    txtCity.Clear();
                }
                else
                {
                    MessageBox.Show("This city is already in the list.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please enter a city name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Check if an item is selected
            if (listBoxCities.SelectedItem != null)
            {
                // Remove the selected item
                listBoxCities.Items.Remove(listBoxCities.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please select a city to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
