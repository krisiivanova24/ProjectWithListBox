using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Documents;
using System.Windows.Forms;

namespace SomeBasicEventsWithListBoxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Text = listBox1.Items.Count.ToString();
            label6.Text = listBox2.Items.Count.ToString();
            label9.Text = listBox3.Items.Count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!listBox3.Items.Contains(listBox1.SelectedItem))
                {
                    listBox3.Items.Add(listBox1.SelectedItem);
                }
                else
                {
                    MessageBox.Show("Sorry, List already contains it!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please, call the administator!");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!listBox3.Items.Contains(listBox2.SelectedItem))
                {
                    listBox3.Items.Add(listBox2.SelectedItem);
                }
                else
                {
                    MessageBox.Show("Sorry, List already contains it!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please, select a name!");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Sorry, first enter something!");
                }
                else if (!listBox3.Items.Contains(textBox1.Text))
                {
                    listBox3.Items.Add(textBox1.Text);
                }
                else
                {
                    MessageBox.Show("Sorry, List already contains it!");
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Please, first enter something!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox3.Items.Count != 0)
                {
                    listBox3.Items.Remove(listBox3.SelectedItem);
                    label9.Text = listBox3.Items.Count.ToString();
                }
                else
                {
                    MessageBox.Show("The List is empty!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please, select an item from List!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox3.Items.Count != 0)
                {
                    listBox3.Items.Clear();
                    label9.Text = listBox3.Items.Count.ToString();
                }
                else
                {
                    MessageBox.Show("The List is empty!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("The List is empty!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                SortListBoxNum(listBox1);
            }
            catch (Exception)
            {
                MessageBox.Show("Please, enter some items in Numbers!");
            }
            
        }

        private ListBox SortListBoxNum(ListBox list1)
        {
            List<int> list = new List<int>();
            try
            {
                foreach (var item in list1.Items)
                {
                    list.Add(int.Parse(item.ToString()));
                }
                list.Sort();
                list1.Items.Clear();
                foreach (var item in list)
                {
                    list1.Items.Add(item);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong! Please, conntact the administator!");
            }
            return list1;
        }
        private ListBox SortListBox(ListBox list1)
        {
            List<string> list = new List<string>();
            try
            {
                foreach (var item in list1.Items)
                {
                    list.Add(item.ToString());
                }
                list.Sort();
                list1.Items.Clear();
                foreach (var item in list)
                {
                    list1.Items.Add(item);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong! Please, conntact the administator!");
            }
            return list1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                SortListBox(listBox2);
            }
            catch (Exception)
            {
                MessageBox.Show("Please, enter some items in Names!");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox3.Items.Count==0)
                {
                    MessageBox.Show("Please, enter some items in List! It is empty!");
                }
                else
                {
                    SortListBox(listBox3);
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Please, enter some items in List!");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
