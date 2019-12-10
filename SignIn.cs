using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SEPCW2
{
    public partial class SignIn : Form
    {
        string strsql;//declare variables to record SQL Server statement
        SqlCommand command;//this variable is used to execute Transact-SQL statement
        public string userId;//record username and transport to "Write Business Trip Applicaiton Page", "Write Reimbursement Application Page" and "View My Application"
        public static int judge;//judge "Write Business Trip Applicaiton Page", "Write Reimbursement Application Page" and "View My Application"

        public SignIn()
        {
            InitializeComponent();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            //display the first page
            this.Hide();
            frmFirstPage First = new frmFirstPage();
            First.Show();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            judge = 1;

            ConnectDatabase con = new ConnectDatabase();//declare Class ConnectDatabase to use its method Connect
            con.Connect();//use method con to connect database

            try
            {
                if (cmbSignInCategory.Text.Equals("Parent"))
                {
                    //this sql server query statement is used to return a value to judge staff input account is exist or not
                    strsql = string.Format("select count(*) from [Parents] where (ParentsNo='{0}' and PPassword='{1}')   ", txtUserName.Text, txtPassword.Text);
                    command = new SqlCommand(strsql, con.mycon);//declare and execute Transact-SQL statement
                    int result = Convert.ToInt32(command.ExecuteScalar());//judge the staffname and password is exist or not
                    if (result > 0)
                    {
                        MessageBox.Show("Enter Successfully!");//remind staff enter successfully
                        userId = txtUserName.Text;//record staffname                
                        this.Hide();//close current interface                    
                        ViewStudentsinformation VSI = new ViewStudentsinformation();//declare variable to show new form              
                        VSI.ShowDialog(this);//show the satff management interface
                    }
                    else
                        MessageBox.Show("Your username or password is error, please try again!");//remind staff enter failed and try again
                }
                else if (cmbSignInCategory.Text.Equals("Student"))
                {
                    //this sql server query statement is used to return a value to judge manager input account is exist or not
                    strsql = string.Format("select count(*) from [Students] where (StudentsNo='{0}' and SPassword='{1}')   ", txtUserName.Text, txtPassword.Text);
                    command = new SqlCommand(strsql, con.mycon);//declare and execute Transact-SQL statement
                    int result = Convert.ToInt32(command.ExecuteScalar());//judge the managername and password is exist or not
                    if (result > 0)
                    {
                        MessageBox.Show("Enter Successfully!");//remind manager enter successfully
                        userId = txtUserName.Text;//record managername                
                        this.Hide();//close current interface                    
                        UploadInformation UI = new UploadInformation();//declare variable to show new form              
                        UI.ShowDialog(this);//show the Manager Management Interface
                    }
                    else
                        MessageBox.Show("Your username or password is error or Category, please try again!"); //if managaer name or password wrong. then the meesage will be display
                }
                else
                    MessageBox.Show("Please check you Category"); //if user select the wrong category. then this message box will be display

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex.ToString());//catch and show the error
            }
        }
    }
}
