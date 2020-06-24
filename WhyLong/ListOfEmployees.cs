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
namespace WhyLong
{
    public partial class ListOfEmployees : Form
    {
        string conStr = "Data Source = DESKTOP-TAL0KGO\\SQLEXPRESS; Initial Catalog = WhyLong; Integrated Security=true";
        string flag;
        DataTable dtAdmins;
        AdminsBLL bllAdmins;
        public ListOfEmployees()
        {
            InitializeComponent();
            bllAdmins = new AdminsBLL();
        }
        public DataTable createTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("CodeEmployee");
            dt.Columns.Add("FullName");
            dt.Columns.Add("YearOfBirth");
            dt.Columns.Add("Gender");
            dt.Columns.Add("Email");
            dt.Columns.Add("Phone");
            dt.Columns.Add("UserName");
            dt.Columns.Add("Password");
            dt.Columns.Add("Address");
            dt.Columns.Add("Position");
            return dt;
        }
        public void ShowAllAdmins()
        {
            DataTable dt = bllAdmins.getAllAdmins();
            dataGridView1.DataSource = dt;
        }
        private void ListOfEmployees_Load(object sender, EventArgs e)
        {
            LockControl();
            dtAdmins = createTable();
            ShowAllAdmins();
        }
        public bool CheckData()
        {
            if (string.IsNullOrWhiteSpace(txtCode.Text))
            {
                MessageBox.Show("Вы не ввели код сотрудника", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCode.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Вы не ввели ФИО сотрудника", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFullName.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Вы не ввели почту сотрудника", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Вы не ввели номер телефона сотрудника", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPhone.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                MessageBox.Show("Вы не ввели логин для сотрудника", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUserName.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Вы не ввели парль для сотрудника", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassword.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(dtpYearOfBirth.Text))
            {
                MessageBox.Show("Вы не ввели год рождения сотрудника", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpYearOfBirth.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(cbbGender.Text))
            {
                MessageBox.Show("Вы не ввели пол сотрудника", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbbGender.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(cbbPosition.Text))
            {
                MessageBox.Show("Вы не ввели пол должности", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbbPosition.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Вы не ввели пол адреса", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAddress.Focus();
                return false;
            }
            return true;
        }
        public void LockControl()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = false;

            txtCode.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtFullName.ReadOnly = true;
            txtAddress.ReadOnly = true;
            txtPhone.ReadOnly = true;
            txtUserName.ReadOnly = true;
            txtPassword.ReadOnly = true;
            dtpYearOfBirth.Enabled = false;
            cbbGender.Enabled = false;
            cbbPosition.Enabled = false;
            button1.Focus();
        }
        public void UnlockCotrol()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = true;

            txtCode.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtFullName.ReadOnly = false;
            txtAddress.ReadOnly = false;
            txtPhone.ReadOnly = false;
            txtUserName.ReadOnly = false;
            txtPassword.ReadOnly = false;
            dtpYearOfBirth.Enabled = true;
            cbbGender.Enabled = true;
            cbbPosition.Enabled = true;
            txtCode.Focus();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            UnlockCotrol();
            flag = "add";

            txtCode.Text = "";
            txtEmail.Text = "";
            txtFullName.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
            dtpYearOfBirth.Text = "";
            cbbGender.Text = "";
            cbbPosition.Text = "";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            UnlockCotrol();
            flag = "edit";
        }
        int ID;

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int Index = dataGridView1.CurrentRow.Index;
            if (Index >= 0)
            {
                ID = Int32.Parse(dataGridView1.Rows[Index].Cells["column1"].Value.ToString());
                txtCode.Text = dataGridView1.Rows[Index].Cells["CodeEmployee"].Value.ToString();
                txtFullName.Text = dataGridView1.Rows[Index].Cells["FullName"].Value.ToString();
                dtpYearOfBirth.Text = dataGridView1.Rows[Index].Cells["YearOfBirth"].Value.ToString();
                cbbGender.Text = dataGridView1.Rows[Index].Cells["Gender"].Value.ToString();
                txtEmail.Text = dataGridView1.Rows[Index].Cells["Email"].Value.ToString();
                txtAddress.Text = dataGridView1.Rows[Index].Cells["Address"].Value.ToString();
                txtPhone.Text = dataGridView1.Rows[Index].Cells["Phone"].Value.ToString();
                txtUserName.Text = dataGridView1.Rows[Index].Cells["UserName"].Value.ToString();
                txtPassword.Text = dataGridView1.Rows[Index].Cells["Password"].Value.ToString();
                cbbPosition.Text = dataGridView1.Rows[Index].Cells["Position"].Value.ToString();
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (flag == "add")
            {
                if (CheckData())
                {
                    Admins admins = new Admins();
                    admins.CodeEmployee = txtCode.Text;
                    admins.FullName = txtFullName.Text;
                    admins.YearOfBirth = DateTime.Parse(dtpYearOfBirth.Text);
                    admins.Gender = cbbGender.Text.Trim();
                    admins.Email = txtEmail.Text;
                    admins.Address = txtAddress.Text;
                    admins.Phone = txtPhone.Text;
                    admins.UserName = txtUserName.Text;
                    admins.Password = txtPassword.Text;
                    admins.Position = cbbPosition.Text.Trim();
                    if (bllAdmins.InsertAdmins(admins))
                        ShowAllAdmins();
                    else
                        MessageBox.Show("Произошла ошибка", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else if (flag == "edit")
            {
                if (CheckData())
                {
                    Admins admins = new Admins();
                    admins.ID = ID;
                    admins.CodeEmployee = txtCode.Text;
                    admins.FullName = txtFullName.Text;
                    admins.YearOfBirth = DateTime.Parse(dtpYearOfBirth.Text);
                    admins.Gender = cbbGender.Text.Trim();
                    admins.Email = txtEmail.Text;
                    admins.Address = txtAddress.Text;
                    admins.Phone = txtPhone.Text;
                    admins.UserName = txtUserName.Text;
                    admins.Password = txtPassword.Text;
                    admins.Position = cbbPosition.Text.Trim();
                    if (bllAdmins.UpdateAdmins(admins))
                        ShowAllAdmins();
                    else
                        MessageBox.Show("Произошла ошибка", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            LockControl();
        }
        public void load()
        {
            SqlConnection conn = new SqlConnection(conStr);
            try
            {
                conn.Open();
                string sql = "select *from Admins";
                SqlDataAdapter dt = new SqlDataAdapter(sql, conn);
                DataTable tb = new DataTable();
                dt.Fill(tb);
                dataGridView1.DataSource = tb;
            }
            catch (Exception e)
            {
                MessageBox.Show("Произошла ошибка:" + e.Message);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            DialogResult notification;
            notification = MessageBox.Show("Вы хотите удалить этого сотрудника?", "Сообщение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (notification == DialogResult.OK)
            {
                SqlConnection conn = new SqlConnection(conStr);
                conn.Open();
                string sql = "delete from Admins where CodeEmployee like '%" + txtCode.Text + "%'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Успешно удалить!");
                load();
                conn.Close();
            }
        }

        private void TxtFindCode_TextChanged(object sender, EventArgs e)
        {
            string value = txtFindCode.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = bllAdmins.FindCode(value);
                dataGridView1.DataSource = dt;
            }
            else
                ShowAllAdmins();
        }

        private void TxtFindFullName_TextChanged(object sender, EventArgs e)
        {
            string value = txtFindFullName.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = bllAdmins.FindFullName(value);
                dataGridView1.DataSource = dt;
            }
            else
                ShowAllAdmins();
        }

        private void DtpFindYearOfBirth_ValueChanged(object sender, EventArgs e)
        {
            string value = dtpFindYearOfBirth.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = bllAdmins.FindYearOfBirth(value);
                dataGridView1.DataSource = dt;
            }
            else
                ShowAllAdmins();
        }

        private void CbbFindGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = cbbFindGender.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = bllAdmins.FindGender(value);
                dataGridView1.DataSource = dt;
            }
            else
                ShowAllAdmins();
        }

        private void TxtFindEmail_TextChanged(object sender, EventArgs e)
        {
            string value = txtFindEmail.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = bllAdmins.FindEmail(value);
                dataGridView1.DataSource = dt;
            }
            else
                ShowAllAdmins();
        }

        private void TxtFindPhone_TextChanged(object sender, EventArgs e)
        {
            string value = txtFindPhone.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = bllAdmins.FindPhone(value);
                dataGridView1.DataSource = dt;
            }
            else
                ShowAllAdmins();
        }
        private void TxtFindAddress_TextChanged(object sender, EventArgs e)
        {
            string value = txtFindAddress.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = bllAdmins.FindAddress(value);
                dataGridView1.DataSource = dt;
            }
            else
                ShowAllAdmins();
        }
        private void CbbFindPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = cbbFindPosition.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = bllAdmins.FindPosition(value);
                dataGridView1.DataSource = dt;
            }
            else
                ShowAllAdmins();
        }
        private void BtnConclusion_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            ExcelApp.Application.Workbooks.Add(Type.Missing);
            ExcelApp.Columns.ColumnWidth = 15;

            ExcelApp.Cells[1, 1] = "ID";
            ExcelApp.Cells[1, 2] = "Код сотрудника";
            ExcelApp.Cells[1, 3] = "ФИО сотрудника";
            ExcelApp.Cells[1, 4] = "Год рождения";
            ExcelApp.Cells[1, 5] = "Пол";
            ExcelApp.Cells[1, 6] = "Почта";
            ExcelApp.Cells[1, 7] = "Номер телефона";
            ExcelApp.Cells[1, 8] = "Логин";
            ExcelApp.Cells[1, 9] = "Пароль";
            ExcelApp.Cells[1, 10] = "Адрес";
            ExcelApp.Cells[1, 11] = "Должность";

            for (int j = 0; j < dataGridView1.Rows.Count; j++)
            {
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    ExcelApp.Cells[j + 2, i + 1] = dataGridView1.Rows[j].Cells[i].Value;
                }
            }
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
        }
        private void BntExit_Click(object sender, EventArgs e)
        {
            DialogResult Quesion;
            Quesion = MessageBox.Show("Вы хотите выйти?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Quesion == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
