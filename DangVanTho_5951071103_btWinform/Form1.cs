using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace DangVanTho_5951071103_btWinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GetStudentRecord();
        }

     private void GetStudentRecord()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-H6BPC8N\SQLEXPRESS;Initial Catalog=Demo_winform;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from StudentTB", conn);
            DataTable dt = new DataTable();
            conn.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            conn.Close();
            StudentRecordData.DataSource = dt;
        }
        private bool IsValidData()
        {
            if (txtHName.Text == string.Empty || txtNName.Text == string.Empty
                || txtAddress.Text == string.Empty || string.IsNullOrEmpty(txtPhone.Text)
                || string.IsNullOrEmpty(txtRoll.Text))
            {
                MessageBox.Show("Co cho chua nhap du lieu !", "Loi du lieu",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }



        public int StudentID;

   

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (StudentID > 0)
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-H6BPC8N\SQLEXPRESS;Initial Catalog=Demo_winform;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("Update StudentTb Set " + " Name = @Name, FatherName = @FatherName, " + " RollNumber = @RollNumber, Address = @Adress" + "Mobile = @Mobile Where StudentID = @ID", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Name", txtHName.Text);
                cmd.Parameters.AddWithValue("@FatherName", txtNName.Text);
                cmd.Parameters.AddWithValue("@RollNumber", txtRoll.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@Mobile", txtPhone.Text);
                cmd.Parameters.AddWithValue("@ID", this.StudentID);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                GetStudentRecord();

            }
            else
            {
                MessageBox.Show("Cap nhap bi loi !", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (StudentID > 0)
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-H6BPC8N\SQLEXPRESS;Initial Catalog=Demo_winform;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("Delete from StudentTb Where StudentID = @ID", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", this.StudentID);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                GetStudentRecord();

            }
            else
            {
                MessageBox.Show("Cap nhap bi loi !", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void StudentRecordData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int nurrow = e.RowIndex;
            if (nurrow == -1)
            {
                return;
            }
            else
            {
                StudentID = Convert.ToInt32(StudentRecordData.Rows[0].Cells[0].Value);
                txtHName.Text = StudentRecordData.Rows[nurrow].Cells[1].Value.ToString();
                txtNName.Text = StudentRecordData.Rows[nurrow].Cells[2].Value.ToString();
                txtRoll.Text = StudentRecordData.Rows[nurrow].Cells[3].Value.ToString();
                txtAddress.Text = StudentRecordData.Rows[nurrow].Cells[4].Value.ToString();
                txtPhone.Text = StudentRecordData.Rows[nurrow].Cells[5].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-H6BPC8N\SQLEXPRESS;Initial Catalog=Demo_winform;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("Insert Into StudentTb VALUES " + "(@Name, @FatherName, @RollNumber, @Address, @Mobile)", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Name", txtHName.Text);
                cmd.Parameters.AddWithValue("@FatherName", txtNName.Text);
                cmd.Parameters.AddWithValue("@RollNumber", txtRoll.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@Mobile", txtPhone.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                GetStudentRecord();
            }
        }
    }
}
