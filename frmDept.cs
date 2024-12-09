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
    public partial class frmDept : Form
    {
        string connStr = "server=localhost; database=crud; pwd=uslt; uid=root; port=3306";
        string query;

        public frmDept()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {


            if (cboCRUD.SelectedIndex == -1)
            {
                MessageBox.Show("Nothing selected. Select smth bruv");
            } 
            else if (cboCRUD.SelectedIndex == 0) // Create
            {
                query = ($"INSERT INTO department(deptName) VALUES('{txtDepartmentName.Text}')");
                MySqlConnection conn = new MySqlConnection(connStr);

                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show($"{txtDepartmentName.Text} is successfully added");
                conn.Close();
                
            }
            else if (cboCRUD.SelectedIndex == 1) // Update
            {
                query = ($"UPDATE department SET deptName='{txtDepartmentName.Text}' WHERE deptName='{txtprevName.Text}'");
                MySqlConnection conn = new MySqlConnection(connStr);

                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully updated");
                conn.Close();
            }
            else if (cboCRUD.SelectedIndex == 2) // Delete
            {
                query = ($"DELETE FROM department WHERE deptName='{txtDepartmentName.Text}'");
                MySqlConnection conn = new MySqlConnection(connStr);

                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show($"{txtDepartmentName.Text} is successfully deleted");
                conn.Close();
            }

            
        }

        private void cboCRUD_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Enable textbox when Update is chosen
            if (cboCRUD.SelectedIndex == 1)
            {
                txtprevName.Enabled = true;
            }
            else
            {
                txtprevName.Enabled = false;
            }
        }
    }
}
