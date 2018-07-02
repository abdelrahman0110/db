using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
    
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
  
            string cs = "data source =orcl ; user id = scott ; password = tiger;";
            string ss = "";
            ss ="select * from subcontractor where garage_name = '" + txt_garage_name.Text.Trim() + "' and password = '" + txt_password.Text.Trim() + "'";
            OracleDataAdapter adpter = new OracleDataAdapter(ss, cs);
            DataTable ds = new DataTable();
            adpter.Fill(ds);
  
            if (ds.Rows.Count == 1)
            {
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();

            }
            else
            {
            
                MessageBox.Show("the garage name or password are wrong 3) !!");
            }
            }
            
            
        }
    }

