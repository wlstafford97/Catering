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

//Developer: William Stafford
namespace Catering
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Submitt button method
        private void button1_Click(object sender, EventArgs e)
        {
            int sum; //integer to hold the total cost for guests
            int guestTotal; //integer to hold the number of guests
            int guestCost = 35; //cost per guest
            string str = null; //string to hold customer reciept to print to text file

            //try-catch clause to test if the guesttotal is numeric
            try
            {
                guestTotal = Convert.ToInt32(textBox3.Text); //converts the guesttotal into a integer to calculate
                sum = guestCost * guestTotal; //equation to calculate the price for guests
                label8.Text = "$" + Convert.ToString(sum); //prints the cost into the label
                if (textBox1.TextLength < 1)//checks to see if the customer entered anything into the name textbox
                {
                    //if nothing was entered, string will be replaced with "none"
                    str += "Name:none" + " ";
                }
                else //if the textbox contains a string
                {
                    str += "Name:" + textBox1.Text + " "; //input will be added to the string
                }
                //same comments as above for the next two if statements
                if (textBox2.TextLength < 1)
                {
                    str += "PhoneNumber:none" + " ";
                }
                else
                {
                    str += "PhoneNumber:" + textBox2.Text + " ";
                }
                str += "Guests:" + textBox3.Text + " "; //guest total added to string
                if (checkedListBox1.CheckedItems.Count == 0)
                {
                    str += "Entrée:none ";
                }
                else
                {
                    //for loop to check which item was selected in the checkedlist box
                    for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
                    {
                        //adds that item to the string
                        str += "Entrée:" + checkedListBox1.CheckedItems[i].ToString() + " ";
                    }
                }
                //for the next two if statements, checking to see if the user inputed anything into the textboxes
                if (checkedListBox2.CheckedItems.Count == 0)
                {
                    //if no inpute, "none" will be inserted for the specific item
                    str += "Sides:none ";
                }
                else
                {
                    //same as before, looping to see which items were selected
                    for (int i = 0; i < checkedListBox2.CheckedItems.Count; i++)
                    {
                        //adds items to the string for printing to text file
                        if (i == 0)
                        {
                            str += "Sides:" + checkedListBox2.CheckedItems[i].ToString() + " ";
                        }
                        else
                        {
                            str += checkedListBox2.CheckedItems[i].ToString() + " ";
                        }
                    }
                }
                //same comments as the if statement stated above
                if (checkedListBox3.CheckedItems.Count == 0)
                {
                    str += "Desert:none ";
                }
                else
                {
                    for (int i = 0; i < checkedListBox3.CheckedItems.Count; i++)
                    {
                        str += "Desert:" + checkedListBox3.CheckedItems[i].ToString() + " ";
                    }
                }
                /*File is located in ./Catering/Catering/bin/Debug/Event.txt*/
                System.IO.File.WriteAllText(@".\Event.txt", str); //writes the string to the text file
            }
            //catch will be executed if the guestTotal was not able to convert to a integer
            catch (Exception h)
            {
                label8.Text = "$0"; //cost was set to zero as stated in the directions

                //for the next if statementssit is checking to see if the user input into the text fields
                if (textBox1.TextLength < 1) {
                    str += "Name:none" + " ";
                } else //else executes if the user input something into the textfield
                {
                    str += "Name:" + textBox1.Text + " ";
                }
                if (textBox2.TextLength < 1)
                {
                    str += "PhoneNumber:none" + " ";
                }
                else
                {
                    str += "PhoneNumber:" + textBox2.Text + " ";
                }
                str += "Guests:0" + " "; //adds guest total to the string
                if (checkedListBox1.CheckedItems.Count == 0)
                {
                    str += "Entrée:none ";
                }
                else
                {
                    //same as comments above, looping to see which item was selected
                    for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
                    {
                        str += "Entrée:" + checkedListBox1.CheckedItems[i].ToString() + " ";
                    }
                }
                if (checkedListBox2.CheckedItems.Count == 0)
                {
                    str += "Sides:none ";
                }
                else
                {
                    //same as comments above, looping to see which item was selected
                    for (int i = 0; i < checkedListBox2.CheckedItems.Count; i++)
                    {
                        if (i == 0)
                        {
                            str += "Sides:" + checkedListBox2.CheckedItems[i].ToString() + " ";
                        }
                        else
                        {
                            str += checkedListBox2.CheckedItems[i].ToString() + " ";
                        }
                    }
                }
                if (checkedListBox3.CheckedItems.Count == 0)
                {
                    str += "Desert:none ";
                }
                else
                {
                    //same as comments above, looping to see which item was selected
                    for (int i = 0; i < checkedListBox3.CheckedItems.Count; i++)
                    {
                        str += "Desert:" + checkedListBox3.CheckedItems[i].ToString() + " ";
                    }
                }
                /*File is located in ./Catering/Catering/bin/Debug/Event.txt*/
                System.IO.File.WriteAllText(@".\Event.txt", str);
            }
        }

        //method for interacting with the checklistbox1
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int itemsChecked = checkedListBox1.Items.Count; //integer to hold the number of items selected
            int count = 0;
            //loop through all items selected
            for(int i=0; i < itemsChecked; i++)
            {
                //if statement to count items selected
                if (checkedListBox1.GetItemChecked(i))
                {
                    count++; //count increases when items are selected
                }
                //if count is greater than one, deselect those items
                if(count > 1)
                {
                    //will loop through the items checked 
                    for (int x = 0; x < itemsChecked; x++)
                    {
                        //item selected will be set to false, allowing users to select again
                        checkedListBox1.SetItemChecked(x, false); 
                    }
                }
            }

        }

        //same method as checkedlistbox1 but just for checkedlistbox3
        private void checkedListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int itemsChecked = checkedListBox3.Items.Count;
            int count = 0;
            for (int i = 0; i < itemsChecked; i++)
            {
                if (checkedListBox3.GetItemChecked(i))
                {
                    count++;
                }
                if (count > 1)
                {
                    for (int x = 0; x < itemsChecked; x++)
                    {
                        checkedListBox3.SetItemChecked(x, false);
                    }
                }
            }
        }

        //same as the two aboe methods, except for the fact that the count is raised to 2 instead of 1
        //allowing the users to select two choices instead of one
        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int itemsChecked = checkedListBox2.Items.Count;
            int count = 0;
            for (int i = 0; i < itemsChecked; i++)
            {
                if (checkedListBox2.GetItemChecked(i))
                {
                    count++;
                }
                if (count > 2)
                {
                    for (int x = 0; x < itemsChecked; x++)
                    {
                        checkedListBox2.SetItemChecked(x, false);
                    }
                }
            }
        }
    }
}
