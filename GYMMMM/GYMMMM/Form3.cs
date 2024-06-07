using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYMMMM
{
    public partial class Form3 : MaterialSkin.Controls.MaterialForm
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            DataTable dt = new DataTable();


            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
 
             
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
          
       
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {
         
        }

        private void checkedListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Código para manejar la selección de elementos en el CheckedListBox3
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Código para manejar el evento de clic en el Button3
        }

        private void checkedListBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Código para manejar la selección de elementos en el CheckedListBox4
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                List<string> selectedItems = new List<string>();

                foreach (object item in checkedListBox2.CheckedItems)
                
                    selectedItems.Add(item.ToString());
                

                string message = "Selected Items:\n" + string.Join("\n", selectedItems);
                MessageBox.Show(message, "Items Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            {
                List<string> selectedItems = new List<string>();

                foreach (object item in checkedListBox3.CheckedItems)
                
                    selectedItems.Add(item.ToString());
                

                string message = "Selected Items:\n" + string.Join("\n", selectedItems);
                MessageBox.Show(message, "Items Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            {
                List<string> selectedItems = new List<string>();

                foreach (object item in checkedListBox4.CheckedItems)
                
                   selectedItems.Add(item.ToString());
                

                string message = "Selected Items:\n" + string.Join("\n", selectedItems);
                MessageBox.Show(message, "Items Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string Message = "Selected Items:\n" + string.Join("\n", selectedItems);
                label1.Text = Message;
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
         
        }

        private void label13_Click(object sender, EventArgs e)
        {
            {
                List<string> selectedItems = new List<string>();

                foreach (object item in checkedListBox2.CheckedItems)

                    selectedItems.Add(item.ToString());


                string message = "Selected Items:\n" + string.Join("\n", selectedItems);
                MessageBox.Show(message, "Items Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            {
                List<string> selectedItems = new List<string>();

                foreach (object item in checkedListBox3.CheckedItems)

                    selectedItems.Add(item.ToString());


                string message = "Selected Items:\n" + string.Join("\n", selectedItems);
                MessageBox.Show(message, "Items Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            {
                List<string> selectedItems = new List<string>();

                foreach (object item in checkedListBox4.CheckedItems)

                    selectedItems.Add(item.ToString());


                string message = "Selected Items:\n" + string.Join("\n", selectedItems);
                MessageBox.Show(message, "Items Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string Message = "Selected Items:\n" + string.Join("\n", selectedItems);
                label1.Text = Message;
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            {
                List<string> selectedItems = new List<string>();

                foreach (object item in checkedListBox2.CheckedItems)

                    selectedItems.Add(item.ToString());


                string message = "Selected Items:\n" + string.Join("\n", selectedItems);
                MessageBox.Show(message, "Items Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            {
                List<string> selectedItems = new List<string>();

                foreach (object item in checkedListBox3.CheckedItems)

                    selectedItems.Add(item.ToString());


                string message = "Selected Items:\n" + string.Join("\n", selectedItems);
                MessageBox.Show(message, "Items Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            {
                List<string> selectedItems = new List<string>();

                foreach (object item in checkedListBox4.CheckedItems)

                    selectedItems.Add(item.ToString());


                string message = "Selected Items:\n" + string.Join("\n", selectedItems);
                MessageBox.Show(message, "Items Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string Message = "Selected Items:\n" + string.Join("\n", selectedItems);
                label1.Text = Message;
            }
            { textBox1.Text = button1.Text; 
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                
        }

        private void checkedListBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
    }

        
   