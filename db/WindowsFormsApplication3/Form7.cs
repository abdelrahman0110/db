using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form7 : Form
    {
        string ordb = "data source = orcl ; user id = scott ; password = tiger ;";
        OracleConnection con;
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(ordb);
            con.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string add = "insert into subcontractor (garage_id , garage_name , password)  values ('" + txtid.Text.Trim() + "','" + txtname.Text.Trim() + "','" + txtpass.Text.Trim() + "')";

            OracleCommand cmd = new OracleCommand(add, con);

            try
            {
                cmd.ExecuteNonQuery();

                MessageBox.Show("successfully registered !!");
                Form1 f2 = new Form1();
                f2.Show();
                this.Hide();
            }
            catch
            {
   
                    MessageBox.Show("there is unvalid data please try again with correct information ");

            }

            
        }

     

        
    }
}
