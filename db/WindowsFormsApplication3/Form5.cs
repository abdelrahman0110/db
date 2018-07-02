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
    public partial class Form5 : Form
    {

        OracleDataAdapter adpter;
        OracleCommandBuilder builder;
        DataSet ds;
        public Form5()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string cs = "data source =orcl ; user id = scott ; password = tiger;";
            string ss = "";
            ss = "select * from expenditure";
            adpter = new OracleDataAdapter(ss, cs);
            ds = new DataSet();
            adpter.Fill(ds);
            grid_expenditure.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adpter);
            adpter.Update(ds.Tables[0]);
            MessageBox.Show("table updated");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.grid_expenditure.SelectedRows.Count > 0)
            {
                grid_expenditure.Rows.RemoveAt(this.grid_expenditure.SelectedRows[0].Index);
            }
            builder = new OracleCommandBuilder(adpter);
            adpter.Update(ds.Tables[0]);
            MessageBox.Show("column deleted");
        }

        private void button1_Click(object sender, EventArgs e)
        {
           string cs = "data source =orcl ; user id = scott ; password = tiger;";
           string ss = @"select * from expenditure where MAINTENANCE = :n";
           OracleDataAdapter adpter = new OracleDataAdapter(ss, cs);
           adpter.SelectCommand.Parameters.Add("n", textBox1.Text);
           DataSet ds = new DataSet();
           adpter.Fill(ds);
           grid_expenditure.DataSource = ds.Tables[0];
           textBox1.Clear();
 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Close();
            Form2 f2 = new Form2();
            f2.Close();
            this.Close();
        }
    }
}
