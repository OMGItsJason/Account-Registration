using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Registration
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
            StudentInfoClass studentInfoClass = new StudentInfoClass();
        }

        private void nextbtn_Click(object sender, EventArgs e)
        {
            StudentInfoClass.Program = programcb.Text;
            StudentInfoClass.LastName = lntb.Text;
            StudentInfoClass.FirstName = fntb.Text;
            StudentInfoClass.MiddleName = mntb.Text;
            StudentInfoClass.Address = addresstb.Text;

            if (long.TryParse(agetb.Text.Trim(), out long age))
            {
                StudentInfoClass.Age = age;
            }

            if (long.TryParse(contactnotb.Text.Trim(), out long contactNo))
            {
                StudentInfoClass.ContactNo = contactNo;
            }


            if (long.TryParse(studentnotb.Text.Trim(), out long studentNo))
            {
                StudentInfoClass.StudentNo = studentNo;
            }


            if (string.IsNullOrWhiteSpace(lntb.Text) || string.IsNullOrWhiteSpace(fntb.Text) || string.IsNullOrWhiteSpace(mntb.Text) || string.IsNullOrWhiteSpace(programcb.Text) || string.IsNullOrWhiteSpace(agetb.Text) || string.IsNullOrWhiteSpace(contactnotb.Text) || string.IsNullOrWhiteSpace(studentnotb.Text) || string.IsNullOrWhiteSpace(addresstb.Text))
            {
                MessageBox.Show("Something Is Missing In The Information");
            }
            else
            {
                FrmConfirm frmConfirm = new FrmConfirm();
                DialogResult result = frmConfirm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    lntb.Clear();

                    fntb.Clear();
                    mntb.Clear();
                    programcb.SelectedIndex = -1;
                    addresstb.Clear();
                    studentnotb.Clear();
                    agetb.Clear();
                    contactnotb.Clear();
                }
            }
        }

        private void studentnotb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please Use Numbers Only");
            }
        }

        private void lntb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void fntb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void mntb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void agetb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void contactnotb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void programcb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
