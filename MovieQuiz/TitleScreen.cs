using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieQuiz
{
    public partial class TitleScreen : Form
    {
        public TitleScreen()
        {
            InitializeComponent();
            LoadCategories();
        }

        private void LoadCategories()
        {
            categoryComboBox.Items.Clear();

            // Populate the ComboBox with categories from MovieLibrary
            foreach (var category in MovieLibrary.Categories.Keys)
            {
                categoryComboBox.Items.Add(category);
            }

            // Optionally select the first category
            if (categoryComboBox.Items.Count > 0)
            {
                categoryComboBox.SelectedIndex = 0; // Select the first category by default
            }
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            // Check if a category is selected
            if (categoryComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a category to start the quiz.");
                return; // Exit the method if no category is selected
            }

            // Get the selected category
            string selectedCategory = categoryComboBox.SelectedItem.ToString();

            // Create and show the quiz form as a modal dialog
            using (var quizForm = new Form1(selectedCategory))
            {
                this.Hide();  // Hide the title screen while the quiz form is active
                quizForm.ShowDialog(); // Block here until the quiz form closes
                this.Show();  // Show the title screen again after the quiz ends
            }
        
    }
    }
}
