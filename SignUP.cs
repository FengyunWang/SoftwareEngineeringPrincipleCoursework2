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
    public partial class SignUP : Form
    {
        string strsql;//declare variables to record SQL Server statement
        SqlCommand command;//used to execute Transact-SQL statement
        bool test;

        public SignUP()
        {
            InitializeComponent();
        }

        private void SignUP_Load(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmFirstPage FP = new frmFirstPage();
            FP.Show();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            //ConnectDatabase con = new ConnectDatabase();//declare Class ConnectDatabase to use its method Connect
            //con.Connect();//use method con to connect database

            ////judge the relevant textbox and combo box whether exist null value
            //if (cmbUserCategory.Text.Trim() == ""|| txtUserName.Text.Trim() == "" || txtUserID.Text.Trim() == "" || cmbGender.Text.Trim() == ""|| txtAge.Text.Trim() == "" || txtEmailAddress.Text.Trim() == "" || txtPassword.Text.Trim() == "" )
            //{
            //    MessageBox.Show("Please do not enter information that is empty!");
            //    return;
            //}
            //Confirm();
            //if (test)//if the length is right enter to the "if"
            //{
            //    if (cmbUserCategory.Text.Equals("Parents")) //if combo box text = staff enter to "if" and this is the satff account 
            //    {
            //        //this command is used to judge student input staff number is exist or not AND the staff id of user input whether has been register
            //        strsql = string.Format("select count(*) from [Paretns] where ParentsNo ='{0}' AND ParetnsName is Null", txtUserID.Text);
            //        command = new SqlCommand(strsql, con.mycon);//declare and execute Transact-SQL statement                
            //        int result = Convert.ToInt32(command.ExecuteScalar());//convert execute result to integer
            //        if (result <= 0) //if result <=0 means this staff id is not exist
            //        {
            //            //remind staff the account has been not exist OR which has been registered
            //            MessageBox.Show("This parents has been registered");
            //            return;
            //        }
            //        else//if result > 0 means this id is exist at the databse
            //        {
            //            MessageBox.Show("this is a right Parents Number!");
            //        }

            //        //this command is used to judge staff input department number is exist or not OR whether belong with his/her department
            //        strsql = string.Format("select count(*) from [Department],[Staff] where Department.DepartmentId = Staff.DepartmentId and Staff.DepartmentId ='{0}' and StaffId = '{1}'", txtDepartmentNo.Text, txtID.Text.Trim());
            //        command = new SqlCommand(strsql, con.mycon);//declare and execute Transact-SQL statement                
            //        result = Convert.ToInt32(command.ExecuteScalar());
            //        if (result <= 0)
            //        {
            //            //remind staff write a wrong department id
            //            MessageBox.Show("This Department number has been not exist! or not belong with your");
            //            return;
            //        }
            //        else
            //        {
            //            MessageBox.Show("this is a right Department Number!");
            //        }

            //        //this sql server query statement is used to insert new information of staff into database
            //        strsql = string.Format("Update Staff SET StaffName='{0}',StaffAge={1},StaffTelephoneNo='{2}',StaffPassword='{3}' where StaffId='{4}'", txtName.Text.Trim(), txtAge.Text.Trim(), txtTelephoneNo.Text.Trim(), txtPassword.Text.Trim(), txtID.Text);
            //        //remind staff that register successfully
            //        command = new SqlCommand(strsql, con.mycon);//declare and execute Transact-SQL statement               
            //        command.ExecuteScalar();

            //        if (cmbGender.Text.Equals("Male"))
            //        {
            //            strsql = string.Format("Update [Staff] SET StaffGender = 'Male' where StaffId = '{0}'", txtID.Text); //save the relevant gender at the database
            //            txtName.Clear();
            //            txtID.Clear();
            //            txtAge.Clear();
            //            txtDepartmentNo.Clear();
            //            txtTelephoneNo.Clear();
            //            txtPassword.Clear();
            //            cmbCategory.Text = "";
            //            cmbGender.Text = "";
            //        }
            //        else if (cmbGender.Text.Equals("Female"))
            //        {
            //            strsql = string.Format("Update [Staff] SET StaffGender = 'Female' where StaffId='{0}'", txtID.Text); //save the relevant gender at the database
            //            txtName.Clear();
            //            txtID.Clear();
            //            txtAge.Clear();
            //            txtDepartmentNo.Clear();
            //            txtTelephoneNo.Clear();
            //            txtPassword.Clear();
            //            cmbCategory.Text = "";
            //            cmbGender.Text = "";
            //        }

            //        MessageBox.Show("Register successfully! Please return to login interface.");
            //        command = new SqlCommand(strsql, con.mycon);//declare and execute Transact-SQL statement               
            //        command.ExecuteScalar();//execute the Sql command
            //    }
            //    else if (cmbCategory.Text.Equals("Manager"))
            //    {
            //        //this command is used to judge staff input staff number is exist or not
            //        strsql = string.Format("select count(*) from [Manager] where ManagerId ='{0}'", txtID.Text);
            //        command = new SqlCommand(strsql, con.mycon);//declare and execute Transact-SQL statement                
            //        int result = Convert.ToInt32(command.ExecuteScalar());//convert execute result to integer
            //        if (result <= 0)
            //        {
            //            //remind student the account has been registered before
            //            MessageBox.Show("This manager number has been not exist!");
            //            return;
            //        }
            //        else
            //        {
            //            MessageBox.Show("this is a right manger Number!");
            //        }


            //        //this sql command is used to judge staff input username is exist or not
            //        strsql = string.Format("select count(*) from [Manager] where ManagerName='{0}'and ManagerId ='{1}'", txtName.Text, txtID.Text);
            //        command = new SqlCommand(strsql, con.mycon);//execute Transact-SQL statement
            //        result = Convert.ToInt32(command.ExecuteScalar());
            //        if (result > 0)
            //        {
            //            MessageBox.Show("This username and it's ID has been registered!");//remind staff that this account has been registered
            //            return;
            //        }

            //        //this command is used to judge staff input staff number is exist or not
            //        strsql = string.Format("select count(*) from [Department] where DepartmentId ='{0}'", txtDepartmentNo.Text);
            //        command = new SqlCommand(strsql, con.mycon);//declare and execute Transact-SQL statement                
            //        result = Convert.ToInt32(command.ExecuteScalar());
            //        if (result <= 0)
            //        {
            //            //remind staff the account has been registered before
            //            MessageBox.Show("This Department number has been not exist!");
            //            return;
            //        }
            //        else
            //        {
            //            MessageBox.Show("this is a right Department Number!");
            //        }

            //        //this sql server query statement is used to insert new information of manager into database
            //        strsql = string.Format("Update Manager SET ManagerName='{0}',ManagerAge={1},ManagerTelephoneNo='{2}',ManagerPassword='{3}' where ManagerId='{4}'", txtName.Text.Trim(), txtAge.Text.Trim(), txtTelephoneNo.Text.Trim(), txtPassword.Text.Trim(), txtID.Text);
            //        //remind staff that register successfully
            //        command = new SqlCommand(strsql, con.mycon);//declare and execute Transact-SQL statement               
            //        command.ExecuteScalar();

            //        if (cmbGender.Text.Equals("Male"))// if user's gender = male 
            //        {
            //            strsql = string.Format("Update [Manager] SET ManagerGender = 'Male' where ManagerId = '{0}'", txtID.Text);//save the male at the database
            //            txtName.Clear();
            //            txtID.Clear();
            //            txtAge.Clear();
            //            txtDepartmentNo.Clear();
            //            txtTelephoneNo.Clear();
            //            txtPassword.Clear();
            //            cmbCategory.Text = "";
            //            cmbGender.Text = "";
            //        }
            //        else if (cmbGender.Text.Equals("Female"))//in user gender = felamle
            //        {
            //            strsql = string.Format("Update [Manager] SET ManagerGender = 'Female' where ManagerId='{0}'", txtID.Text); //save the male at the database
            //            txtName.Clear();
            //            txtID.Clear();
            //            txtAge.Clear();
            //            txtDepartmentNo.Clear();
            //            txtTelephoneNo.Clear();
            //            txtPassword.Clear();
            //            cmbCategory.Text = "";
            //            cmbGender.Text = "";
            //        }
            //        MessageBox.Show("Register successfully! Please return to login interface.");
            //        command = new SqlCommand(strsql, con.mycon);//declare and execute Transact-SQL statement               
            //        command.ExecuteScalar();//execute the Sql command
            //    }
            //    else
            //        //remind users when they input information too long
            //        MessageBox.Show("Please check your input information that all information should shorted than ten characters.");

            //}
        }
        private void Confirm()
        {
            test = false;
            //used to judge the length of the text of user input
            if (txtUserName.Text.Length <= 10 && txtUserID.Text.Length <= 10 && txtAge.Text.Length <= 10 && txtEmailAddress.Text.Length <= 10)
                test = true;
            else
                test = false;
        }
    }
}
