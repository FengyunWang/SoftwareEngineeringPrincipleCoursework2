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
    public partial class ViewStudentsinformation : Form
    {
        string strsql;//declare variables to record SQL Server statement
        SqlCommand command;//used to execute Transact-SQL statement

        public ViewStudentsinformation()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewStudentsinformation_Load(object sender, EventArgs e)
        {
            ConnectDatabase con = new ConnectDatabase();
            con.Connect();

            //this.dgvViewStudentsInformation.Columns[0].Width = 60;
            //this.dgvViewStudentsInformation.Columns[1].Width = 200;
            //this.dgvViewStudentsInformation.Columns[2].Width = 80;
            //this.dgvViewStudentsInformation.Columns[3].Width = 80;
            //this.dgvViewStudentsInformation.Columns[4].Width = 150;
            //this.dgvViewStudentsInformation.Columns[5].Width = 100;
            //this.dgvViewStudentsInformation.Columns[6].Width = 60;
            //this.dgvViewStudentsInformation.Columns[7].Width = 60;
            //this.dgvViewStudentsInformation.Columns[8].Width = 60;
            //this.dgvViewStudentsInformation.Columns[9].Width = 60;
            //this.dgvViewStudentsInformation.Columns[10].Width = 60;
            //this.dgvViewStudentsInformation.Columns[11].Width = 60;
            //this.dgvViewStudentsInformation.Columns[12].Width = 60;
            //dgvViewStudentsInformation.RowHeadersVisible = false;
        }
        private void showdata()//this method is used to show the function at the "Application Category"
        {
            //this is used to judge the result of user has been selected at the combo box
                ConnectDatabase con = new ConnectDatabase();
                con.Connect();
                command = new SqlCommand(strsql, con.mycon);
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                da.Fill(ds, "Reports");
                dgvViewStudentsInformation.DataSource = ds.Tables["Reports"];
            
        }

        private void CmbReportInformation_TextChanged(object sender, EventArgs e)
        {
            //srearch the all result of the reimbursement application
            if (cmbReportInformation.Text.Equals("All information send form my children"))
            {
                //sql command to search the all information of reimbursement application and the key words is staff id
                strsql = string.Format("select ReportNo,RoomCharge,DietaryExpenses DietaryExpenese,EntertainmentExpenses EntertainmentExpenese,OtherExpenses OtherExpenese,LivingSituation,ExerciseSituation,OtherInformationOfLiving from Report");
                showdata(); // use showdata function to show all reuslt.
            }
        }
    }
}
