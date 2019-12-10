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
    public partial class UploadInformation : Form
    {
        string strsql;//declare variables to record SQL Server statement
        SqlCommand command;//used to execute Transact-SQL statement
        bool test;
        public UploadInformation()
        {
            InitializeComponent();
        }

        private void UploadInformation_Load(object sender, EventArgs e)
        {
            SignIn.judge = 3; //set the judge = 3 in order to enter to the 3 judge at the "Staff Management Interface"

            UploadInformation UI = (UploadInformation)this.Owner;
            //snumber = user.number; //get the staff number from the staff management interface and save it at the snumber

            ConnectDatabase con = new ConnectDatabase();
            con.Connect();

            DateTime now = dtpCT.Value.Date;//save the date time of user selected at the date time picker
            //DateTime back = dtpReturnTime2.Value.Date; //save the date time of user selected at the date time picker
            //System.TimeSpan ts = back.Date - now.Date; //use timespan method to do calculate of back time - departure time to get the time of the business trip
            //lblTripTime.Text = ts.Days.ToString();//show the result at the label
        }

        private void Confirm()
        {
            test = false;
            if (txtRoomCharge.Text.Length <= 10 && txtDietaryExpenses.Text.Length <= 10 && txtEntertainmentExpenses.Text.Length <= 10 && txtOtherExpenses.Text.Length <= 30)
                test = true;
            else
                test = false;
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            ConnectDatabase con = new ConnectDatabase();//declare Class ConnectDatabase to use its method Connect
            con.Connect();//use method con to connect database

            //this "if" is used to test the textbox whether exist the null value
            if (txtRoomCharge.Text.Trim() == "" || txtDietaryExpenses.Text.Trim() == "" || txtEntertainmentExpenses.Text.Trim() == "" || txtOtherExpenses.Text.Trim() == "" || txtLearningSituation.Text.Trim() == "" || txtEntertainmentExpenses.Text.Trim() == "" || dtpCT.Text.Trim() == "")
            {
                MessageBox.Show("Please do not enter information that is empty!");
                return;
            }

            Confirm();//use confirm method
            if (test)//if pass the "Test" turn to the "if"
            {
                //this command is used to judge staff input staff number is exist or not
                //strsql = string.Format("select count(*) from [Staff] where StaffName='{0}' AND StaffId='{1}' ", txtName.Text.Trim(), txtStaffId.Text.Trim());
                command = new SqlCommand(strsql, con.mycon);//declare and execute Transact-SQL statement                
                //int result = Convert.ToInt32(command.ExecuteScalar());//convert execute result to integer
                //if (result <= 0) //if result < = 0 means this staff name is not correct with the staff id
                //{
                    //remind information of user input is wrong
               //     MessageBox.Show("This staff name and id is not correct!");
               //     return;
                //}
               // else
               // {
               //     MessageBox.Show("This staff name and id is Correct!");
               // }

                //this sql command is used to judge staff's staffid whether belong with the department of his has been input the department id
               // strsql = string.Format("select count(*) from [Department],[Staff] where Department.DepartmentId = Staff.DepartmentId AND StaffId ='{0}' and Staff.DepartmentId ='{1}' and Department.DepartmentName ='{2}'", txtStaffId.Text.Trim(), txtDepartmentId.Text.Trim(), txtDepartmentName.Text.Trim());
                //command = new SqlCommand(strsql, con.mycon);//execute Transact-SQL statement
                //result = Convert.ToInt32(command.ExecuteScalar());
               // if (result <= 0)//if result < = 0 means this staff id is not belong with the department id of user has been input 
                //{
                //    MessageBox.Show("Your Staff ID is not correct with your Department ID! or your Department Name is not correct!");//remind student that this account has been registered
                //    return;
               // }
               // else
               // {
               //     MessageBox.Show("Your staff id is correct with your Department id and Department Name is Correct!");
                //}


                //if (cmbBusinessTripCatrgory.Text.Equals("Domestic Business Trip Application"))//if user select the "Domestic Busines Trip Application" then the system will save this data at the database
               // {
                    //this sql server query statement is used to insert the domestic business trip application's data
                    strsql = string.Format("insert into [Report](RoomCharge,DietaryExpenses,EntertainmentExpenses,OtherExpenses,LivingSituation,ExerciseSituation,OtherInformationOfLiving,UploadTime)values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", txtRoomCharge.Text.Trim(),txtDietaryExpenses.Text.Trim(), txtEntertainmentExpenses.Text.Trim(), txtOtherExpenses.Text.Trim(), txtLearningSituation.Text.Trim(), txtExerciseSituation.Text.Trim(), txtOtherInformationOfLiving.Text.Trim(),dtpCT.Text.Trim());

                    //remind student that insert successfully
                    MessageBox.Show("Write Report for your parents successfully! ");
                    command = new SqlCommand(strsql, con.mycon);//declare and execute Transact-SQL statement               
                    command.ExecuteScalar();//execute the Sql command
                    //clear all items when ststem finsh insert
                    txtRoomCharge.Clear();
                    txtDietaryExpenses.Clear();
                    txtEntertainmentExpenses.Clear();
                    txtOtherExpenses.Clear();
                    txtLearningSituation.Clear();
                    txtExerciseSituation.Clear();
                    txtOtherInformationOfLiving.Clear();
                    dtpCT.Text = DateTime.Now.ToString();
                //}

                //else //when user has been not select category or input the wrong message then the system will show an error message for user
                //{
                   // MessageBox.Show("The Category of your Business Trip Application is wrong! Please check it again!");
               // }

            }
            //else
            //    //remind users when they input information too long
            //    MessageBox.Show("Please check your input information that all information should shorted than ten characters.");
        }
    }
}
