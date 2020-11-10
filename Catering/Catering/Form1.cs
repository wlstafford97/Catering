using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catering
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum;
            int guestTotal;
            int guestCost = 35;
            try
            {
                guestTotal = Convert.ToInt32(textBox3.Text);
                sum = guestCost * guestTotal;
                label8.Text = "$" + Convert.ToString(sum);
            }
            catch (Exception h)
            {
                label8.Text = "$0";
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int itemsChecked = checkedListBox1.Items.Count;
            int count = 0;
            for(int i=0; i < itemsChecked; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    count++;
                }
                if(count > 1)
                {
                    for (int x = 0; x < itemsChecked; x++)
                    {
                        checkedListBox1.SetItemChecked(x, false);
                    }
                }
            }

        }

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
