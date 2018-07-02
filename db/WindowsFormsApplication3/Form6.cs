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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            string cs = "data source =orcl ; user id = scott ; password = tiger;";
            DataSet ds = new DataSet();
            OracleDataAdapter adapter1 = new OracleDataAdapter("select * from customer", cs);
            adapter1.Fill(ds, "cust");

            OracleDataAdapter adapter2 = new OracleDataAdapter("select * from car", cs);
            adapter2.Fill(ds, "ca");

            DataRelation r = new DataRelation("fk", ds.Tables[0].Columns["id"], ds.Tables[1].Columns["c1"]);
            ds.Relations.Add(r);

            BindingSource master = new BindingSource(ds , "cust");
            BindingSource child = new BindingSource(master, "fk");

            grid_purchase.DataSource = master;
            dataGridView1.DataSource = child;
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Close();
            Form2 f2 = new Form2();
            f2.Close();
            this.Close();
        }
    }
}
