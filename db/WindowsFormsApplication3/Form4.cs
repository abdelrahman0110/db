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
    public partial class Form4 : Form
    {
        string ordb = "data source = orcl ; user id = scott ; password = tiger ;";
        OracleConnection con;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(ordb);
            con.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand c2 = new OracleCommand();
            c2.Connection = con;
            c2.CommandText = "insert_rev";
            c2.CommandType = CommandType.StoredProcedure;

            c2.Parameters.Add("rev_id",textBox2.Text);
            c2.Parameters.Add("inst_claims", textBox3.Text);
            c2.Parameters.Add("hire", textBox4.Text);
            c2.Parameters.Add("sales", textBox5.Text);
            c2.Parameters.Add("s_date",Convert .ToDateTime (textBox6.Text));
            c2.Parameters.Add("r4", textBox7.Text);
            c2.Parameters.Add("g_id", textBox8.Text);

            c2.ExecuteNonQuery();

            
            DataTable rev = new DataTable();

            DataRow row;
            rev.Columns.Add("REV_ID ");
            rev.Columns.Add("INSURANCE_CLAIMS");
            rev.Columns.Add("CAR_HIRE");
            rev.Columns.Add("CAR_SALES");
            rev.Columns.Add("START_DATE");
            rev.Columns.Add("R4");
            rev.Columns.Add("G1");

                row = rev.NewRow();
                row["REV_ID "] = c2.Parameters["rev_id"].Value;
                row["INSURANCE_CLAIMS"] = c2.Parameters["inst_claims"].Value;
                row["CAR_HIRE"] = c2.Parameters["hire"].Value;
                row["CAR_SALES"] =c2.Parameters["sales"].Value;
                row["START_DATE"] = c2.Parameters["s_date"].Value;
                row["R4"] = c2.Parameters["r4"].Value;
                row["G1"] = c2.Parameters["g_id"].Value;

                rev.Rows.Add(row);

            grid_revenue.DataSource = rev;
            MessageBox.Show("revenue is stored ");
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = con;
            c.CommandText = "showall_rev";
            c.CommandType = CommandType.StoredProcedure;
            DataTable rev = new DataTable();

            c.Parameters.Add("REV_1", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = c.ExecuteReader();

            DataRow row;
            rev.Columns.Add("REV_ID ");
            rev.Columns.Add("INSURANCE_CLAIMS");
            rev.Columns.Add("CAR_HIRE");
            rev.Columns.Add("CAR_SALES");
            rev.Columns.Add("START_DATE");
            rev.Columns.Add("R4");
            rev.Columns.Add("G1");


            while (dr.Read())
            {
                row = rev.NewRow();
                row["REV_ID "] = dr["REV_ID"];
                row["INSURANCE_CLAIMS"] = dr["INSURANCE_CLAIMS"];
                row["CAR_HIRE"] = dr["CAR_HIRE"];
                row["CAR_SALES"] = dr["CAR_SALES"];
                row["START_DATE"] = dr["START_DATE"];
                row["R4"] = dr["R4"];
                row["G1"] = dr["G1"];

                rev.Rows.Add(row);

            }
            dr.Close();
            grid_revenue.DataSource = rev;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int ava;
            OracleCommand c = new OracleCommand();
            c.Connection = con;
            c.CommandText = "Get_avrage_rev";
            c.CommandType = CommandType.StoredProcedure;

            c.Parameters.Add("s_date", Convert.ToDateTime(textBox1.Text));
            c.Parameters.Add("CAR_HIRE", OracleDbType.Int32, ParameterDirection.Output);

            c.ExecuteNonQuery();


            ava = Convert.ToInt32(c.Parameters["CAR_HIRE"].Value.ToString());

            DataTable rev = new DataTable();
            DataRow row;
            rev.Columns.Add("REV_ID");
          rev.Columns.Add("START_DATE");

                row = rev.NewRow();
                row["REV_ID"] = c.Parameters["CAR_HIRE"].Value;
                row["START_DATE"] = c.Parameters["START_DATE"].Value;

                rev.Rows.Add(row);
        
            grid_revenue.DataSource = rev;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OracleCommand c2 = new OracleCommand();
            c2.Connection = con;
            c2.CommandText = "update_rev";
            c2.CommandType = CommandType.StoredProcedure;

            c2.Parameters.Add("rev_id", textBox2.Text);
            c2.Parameters.Add("inst_claims", textBox3.Text);
            c2.Parameters.Add("hire", textBox4.Text);
            c2.Parameters.Add("sales", textBox5.Text);
            c2.Parameters.Add("s_date", Convert.ToDateTime(textBox6.Text));
            c2.Parameters.Add("r4", textBox7.Text);
            c2.Parameters.Add("g_id", textBox8.Text);

            c2.ExecuteNonQuery();


            DataTable rev = new DataTable();

            DataRow row;
            rev.Columns.Add("REV_ID ");
            rev.Columns.Add("INSURANCE_CLAIMS");
            rev.Columns.Add("CAR_HIRE");
            rev.Columns.Add("CAR_SALES");
            rev.Columns.Add("START_DATE");
            rev.Columns.Add("R4");
            rev.Columns.Add("G1");


            row = rev.NewRow();
            row["REV_ID "] = c2.Parameters["rev_id"].Value;
            row["INSURANCE_CLAIMS"] = c2.Parameters["inst_claims"].Value;
            row["CAR_HIRE"] = c2.Parameters["hire"].Value;
            row["CAR_SALES"] = c2.Parameters["sales"].Value;
            row["START_DATE"] = c2.Parameters["s_date"].Value;
            row["R4"] = c2.Parameters["r4"].Value;
            row["G1"] = c2.Parameters["g_id"].Value;

            rev.Rows.Add(row);

            grid_revenue.DataSource = rev;
            MessageBox.Show("revenue is updated ");
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OracleCommand c2 = new OracleCommand();
            c2.Connection = con;
            c2.CommandText = "delete_rev";
            c2.CommandType = CommandType.StoredProcedure;

            c2.Parameters.Add("rev_id", textBox2.Text);         
            c2.ExecuteNonQuery();

            MessageBox.Show("revenue is deleted ");
            textBox2.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Close();
            Form2 f2 = new Form2();
            f2.Close();
            this.Close();
        }

       
    }
}
