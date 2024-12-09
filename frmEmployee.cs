using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace _046_Pattaguan_Caranguian
{
    public partial class frmEmployee : Form
    {
        string connStr = "server=localhost; database=crud; pwd=uslt; uid=root; port=3306";
        MySqlConnection conn;
        string query;
        DataTable dt = new DataTable();
 
        

        public frmEmployee()
        {
            InitializeComponent();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            disableAllInputFields();

            // This displays the whole sql table data in the datagrid view
            selectAll();

            // Populates the combobox with deptID
            query = "SELECT deptID FROM department";

            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cboDeptID.Items.Add(dr["deptID"].ToString());
            }

            dr.Close();
            conn.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (cboCRUD.SelectedIndex == 0) // Create
            {
                query = ($@"INSERT INTO employee(emp_name, emp_age, emp_sex, marital_status, deptID) 
                        VALUES('{txtEmpName.Text}', {txtEmpAge.Text}, '{txtEmpSex.Text}', '{txtMarStat.Text}', {cboDeptID.Text})");
                MySqlConnection conn = new MySqlConnection(connStr);

                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show($"{txtEmpName.Text} is successfully added");
                conn.Close();

                selectAll();
                clearAllInputFields();
            }
            else if (cboCRUD.SelectedIndex == 1) // Read
            {


                // Add columns
                dt.Columns.Add("Name");
                dt.Columns.Add("Sex");
                dt.Columns.Add("Department");

                query = ($"SELECT emp_name, emp_sex FROM employee WHERE EmpID = '{txtEmpID.Text}'");


                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                conn.Close();
                

                dtgMain.DataSource = dt;

                clearAllInputFields();
            }
            else if (cboCRUD.SelectedIndex == 2) // Update
            {
                query = ($@"UPDATE employee SET emp_name='{txtEmpName.Text}', emp_age={txtEmpAge.Text},
                        emp_sex='{txtEmpSex.Text}', marital_status='{txtMarStat.Text}', deptID={cboDeptID.Text} 
                        WHERE EmpID={txtEmpID.Text}");
                MySqlConnection conn = new MySqlConnection(connStr);

                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show($"{txtEmpName.Text} is successfully Updated!");
                conn.Close();

                selectAll();
                clearAllInputFields();
            }
            else if (cboCRUD.SelectedIndex == 3) //Delete
            {
                query = ($"DELETE FROM employee WHERE emp_name='{txtEmpName.Text}' AND emp_age={txtEmpAge.Text}");
                MySqlConnection conn = new MySqlConnection(connStr);

                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show($"{txtEmpName.Text} is successfully deleted");
                conn.Close();

                selectAll();
                clearAllInputFields();
            }
        }

        private void cboCRUD_SelectedIndexChanged(object sender, EventArgs e)
        {
            disableAllInputFields();

            if (cboCRUD.SelectedIndex == 0) // Create
            {
                
                txtEmpName.Enabled = true;
                txtEmpAge.Enabled = true;
                txtEmpSex.Enabled = true;
                txtMarStat.Enabled = true;
                cboDeptID.Enabled = true;

            }
            else if (cboCRUD.SelectedIndex == 1) // Read
            {
                txtEmpID.Enabled = true;
            }
            else if (cboCRUD.SelectedIndex == 2) // Update
            {
                txtEmpID.Enabled = true;
                txtEmpName.Enabled = true;
                txtEmpAge.Enabled = true;
                txtEmpSex.Enabled = true;
                txtMarStat.Enabled = true;
                cboDeptID.Enabled = true;
            }
            else if (cboCRUD.SelectedIndex == 3) //Delete
            {
                txtEmpAge.Enabled = true;
                txtEmpName.Enabled = true;
            }
           
        }

        void selectAll()
        {
            dt.Clear();
            dtgMain.DataSource = null;

            query = "SELECT * FROM employee";
            conn = new MySqlConnection(connStr);
            conn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            adapter.Fill(dt);
            conn.Close();
            dtgMain.DataSource = dt;
        }

        void disableAllInputFields()
        {
            txtEmpID.Enabled = false;
            txtEmpName.Enabled = false;
            txtEmpAge.Enabled = false;
            txtEmpSex.Enabled = false;
            txtMarStat.Enabled = false;
            cboDeptID.Enabled = false;
        }

        void clearAllInputFields()
        {
            txtEmpID.Clear();
            txtEmpName.Clear();
            txtEmpAge.Clear();
            txtEmpSex.Clear();
            txtMarStat.Clear();
            cboDeptID.SelectedIndex = -1;
        }
    }
}
