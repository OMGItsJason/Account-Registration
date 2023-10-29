using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Account_Registration.StudentInfoClass;

namespace Account_Registration
{
    public partial class FrmConfirm : Form
    {
        public FrmConfirm()

        {
            DelProgram = new DelegateText(StudentInfoClass.GetProgram);
            DelLastName = new DelegateText(StudentInfoClass.GetLastName);
            DelFirstName = new DelegateText(StudentInfoClass.GetFirstName);
            DelMiddleName = new DelegateText(StudentInfoClass.GetMiddleName);
            DelAddress = new DelegateText(StudentInfoClass.GetAddress);

            DelNumAge = new DelegateNumber(StudentInfoClass.GetAge);
            DelNumContactNo = new DelegateNumber(StudentInfoClass.GetContactNo);
            DelStudNo = new DelegateNumber(StudentInfoClass.GetStudentNo);
            InitializeComponent();
        }

        private DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;
        private DelegateNumber DelNumAge, DelNumContactNo, DelStudNo;
        private delegate long DelegateNumber(long number);

        private void FrmConfirm_Load(object sender, EventArgs e)
        {
            stunola.Text = DelStudNo(StudentInfoClass.StudentNo).ToString();
            progla.Text = DelProgram(StudentInfoClass.Program);
            lnla.Text = DelLastName(StudentInfoClass.LastName);
            fnla.Text = DelFirstName(StudentInfoClass.FirstName);
            mnla.Text = DelMiddleName(StudentInfoClass.MiddleName);
            agela.Text = DelNumAge(StudentInfoClass.Age).ToString();
            conla.Text = DelNumContactNo(StudentInfoClass.ContactNo).ToString();
            addla.Text = DelAddress(StudentInfoClass.Address);
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
