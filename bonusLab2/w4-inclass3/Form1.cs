using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w4_inclass3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Are you sure you want to exit?",
                "myAppTitle",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);

            if (r == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Are you sure you want to exit?",
                "myAppTitle",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);

            if (r == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtNew.Text != "")
            {
                lstAnimals.Items.Add(txtNew.Text);
                txtNew.Clear();
                txtNew.Focus();
                btnAdd.Enabled = false;
            }
            btnClear.Enabled = true;

        }

        private void txtNew_TextChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int index = -1;
            int total = lstAnimals.Items.Count;
            if (lstAnimals.SelectedIndex != -1)
            {
                index = lstAnimals.SelectedIndex;
                lstAnimals.Items.Remove(lstAnimals.SelectedItem);
                total = lstAnimals.Items.Count;

            }
            if (index > -1)
            {  

                if (index >= total)
                {

                    lstAnimals.SelectedIndex = index-1;
                }
                else
                {
                    lstAnimals.SelectedIndex = index;
                }
                if (total == 0)
                {
                    btnRemove.Enabled = false;
                    btnClear.Enabled = false;
                }
            }
                
        }

        private void lstAnimals_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            if (lstAnimals.SelectedIndex != -1)
            {
                btnRemove.Enabled = true;
            }
            
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstAnimals.Items.Clear();
            txtNew.Focus();
            btnClear.Enabled = false;
            btnRemove.Enabled = false;
        }

        private void FilterTextBox(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            //// Let the system handle the key for letters
            //if (Char.IsLetter(e.KeyChar))
            //    e.Handled = false;
            //else
            //    // Ignore: tell the system we handled the character
            //    e.Handled = true;

        }




    }
}
