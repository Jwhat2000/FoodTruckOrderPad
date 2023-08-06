/*
Jeffrey Janvier
Module Five Assignment
This program prompts and calculates the customer order of a hamburger
on a food truck. It offers additonal selections to the hamburgers,
while providing a discount if paid with cash to the total.
10/9/2022
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

namespace Food_Truck_Order_Pad
{
    public partial class Form1 : Form
    {
        // Constants for add-on prices and fries
        const decimal BASE_BURGER_PRICE = 4.99m;
        const decimal cheese = .99m;
        const decimal fried_egg = 1.99m;
        const decimal bacon = 1.99m;
        const decimal avocado = .99m;
 

        // Global variables
        decimal addOnPrice = 0;     // To hold add-on prices
        decimal fries;          // To hold the price of fries
        decimal cashDiscount;   // To hold the cash discount

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        } 
        
        private void cheeseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Determine if the cheese add-on is selected
            if (cheeseCheckBox.Checked)
            {
                if (addOnPrice == 0)
                {
                    addOnPrice = cheese;
                }
                else
                {
                    addOnPrice += cheese;
                }

                // Display the add-on price
                addOnDiplayLabel.Text = "Add " + addOnPrice.ToString("f");
            }
        }

        private void friedeggCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Determine if the fried egg add-on is selected
            if (friedeggCheckBox.Checked)
            {
                if (addOnPrice == 0)
                {
                    addOnPrice = fried_egg;
                }
                else
                {
                    addOnPrice += fried_egg;
                }

                // Display the add-on price
                addOnDiplayLabel.Text = "Add " + addOnPrice.ToString("f");
            }
        }

        private void baconCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Determine if the bacon add-on is selected
            if (baconCheckBox.Checked)
            {
                if (addOnPrice == 0)
                {
                    addOnPrice = bacon;
                }
                else
                {
                    addOnPrice += bacon;
                }

                // Display the add-on price
                addOnDiplayLabel.Text = "Add " + addOnPrice.ToString("f");
            }
        }

        private void avocadoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Determine if the avocado add-on is selected
            if (avocadoCheckBox.Checked)
            {
                if (addOnPrice == 0)
                {
                    addOnPrice = avocado;
                }
                else
                {
                    addOnPrice += avocado;
                }

                // Display the add-on price
                addOnDiplayLabel.Text = "Add " + addOnPrice.ToString("f");
            }
        } 
        
        private void rareRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void mediumRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void welldoneRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
 
        private void yesFriesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Determine if fries are selected
            if (yesFriesRadioButton.Checked)
            {
                fries = 2.99m;
            }
        }

        private void noFriesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Determine if fries are not selected
            if (noFriesRadioButton.Checked)
            {
                fries = 0;
            }
        }

        private void cashRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Determine if cash is selected to apply discount
            if (cashRadioButton.Checked)
            {
                cashDiscount = .10m;
            }
        }
        
        private void creditRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Determine if credit is selected
            if (creditRadioButton.Checked)
            {
                cashDiscount = 0;
            }
        }

        private void totalButton_Click(object sender, EventArgs e)
        {
            decimal total;  // To hold the total price of order

            // Calculate the total of the order
            total = BASE_BURGER_PRICE + addOnPrice + fries;
            
            // Calculate discount if customer paying with cash
            if (cashDiscount != 0)
            {
                cashDiscount *= total;  // Calculate discount

                total -= cashDiscount;  // Substract discount from total
            }
           

            // Diplay the total of the order
            totalLabel.Text = total.ToString("c2");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the addOnDisplayLabel and totalLabel  
            addOnDiplayLabel.Text = "";
            totalLabel.Text = "";

            // Reset the add-on price and cash discount
            addOnPrice = 0;
            cashDiscount = 0;

            // Reset the checkBoxes and radioButtons
            cheeseCheckBox.Checked = false;
            friedeggCheckBox.Checked = false;
            baconCheckBox.Checked = false; 
            avocadoCheckBox.Checked = false;
            rareRadioButton.Checked = false;
            mediumRadioButton.Checked = false;
            welldoneRadioButton.Checked = false;
            yesFriesRadioButton.Checked = false;
            noFriesRadioButton.Checked = false;
            cashRadioButton.Checked = false;
            creditRadioButton.Checked = false;

            // Reset the focus
            cheeseCheckBox.Focus();
        }
    }
}
