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
    public partial class Form3 : Form
    {
        string ordb = "data source = orcl ; user id = scott ; password = tiger ;";
        OracleConnection con;
        public Form3()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void grid_rent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(ordb);
            con.Open();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from car where status = :s";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(":s", txt1.Text);
            OracleDataReader dr = cmd.ExecuteReader();

            DataTable car = new DataTable();
            car.Columns.Add("Reg_num");
            car.Columns.Add("Fuel_type");
            car.Columns.Add("Engine_size");
            car.Columns.Add("Prouction_year");
            car.Columns.Add("Model");
            car.Columns.Add("Passengers_num");
            car.Columns.Add("Begining_date");
            car.Columns.Add("End_date");
            car.Columns.Add("Installment");
            car.Columns.Add("Customer_id");
            car.Columns.Add("Status");
            car.Columns.Add("Purcchase_date");
            car.Columns.Add("Purchase_price");
            car.Columns.Add("garage_id");

            DataRow row;
            while (dr.Read())
            {

                row = car.NewRow();
                row["Reg_num"] = dr["REGISTRATION_NUMBER"];
                row["Fuel_type"] = dr["FUEL_TYPE"];
                row["Engine_size"] = dr["ENGINE_SIZE"];
                row["Prouction_year"] = dr["YEAR_OF_PRODUCTION"];
                row["Model"] = dr["CAR_MODEL"];
                row["Passengers_num"] = dr["NUMBER_OF_PASSENGER"];
                row["Begining_date"] = dr["BEGINING_DATE"];
                row["End_date"] = dr["END_DATE"];
                row["Installment"] = dr["INSTALLMENT"];
                row["Customer_id"] = dr["C1"];
                row["Status"] = dr["status"];
                row["Purcchase_date"] = dr["PURCHASE_DATE"];
                row["Purchase_price"] = dr["PURCHASE_PRICE"];
                row["garage_id"] = dr["G1"];


                car.Rows.Add(row);

            }
            dr.Close();
            grid_rent.DataSource = car;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_all_cars_Click(object sender, EventArgs e)
        {
            

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from car";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();

            DataTable car = new DataTable();
            car.Columns.Add("Reg_num");
            car.Columns.Add("Fuel_type");
            car.Columns.Add("Engine_size");
            car.Columns.Add("Prouction_year");
            car.Columns.Add("Model");
            car.Columns.Add("Passengers_num");
            car.Columns.Add("Begining_date");
            car.Columns.Add("End_date");
            car.Columns.Add("Installment");
            car.Columns.Add("Customer_id");
            car.Columns.Add("Status");
            car.Columns.Add("Purcchase_date");
            car.Columns.Add("Purchase_price");
            car.Columns.Add("garage_id");

            DataRow row;
            while (dr.Read())
            {

                row = car.NewRow();
                row["Reg_num"] = dr["REGISTRATION_NUMBER"];
                row["Fuel_type"] = dr["FUEL_TYPE"];
                row["Engine_size"] = dr["ENGINE_SIZE"];
                row["Prouction_year"] = dr["YEAR_OF_PRODUCTION"];
                row["Model"] = dr["CAR_MODEL"];
                row["Passengers_num"] = dr["NUMBER_OF_PASSENGER"];
                row["Begining_date"] = dr["BEGINING_DATE"];
                row["End_date"] = dr["END_DATE"];
                row["Installment"] = dr["INSTALLMENT"];
                row["Customer_id"] = dr["C1"];
                row["Status"] = dr["status"];
                row["Purcchase_date"] = dr["PURCHASE_DATE"];
                row["Purchase_price"] = dr["PURCHASE_PRICE"];
                row["garage_id"] = dr["G1"];


                car.Rows.Add(row);
           
            }
            dr.Close();
            grid_rent.DataSource = car;
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into CAR (REGISTRATION_NUMBER,FUEL_TYPE,ENGINE_SIZE,YEAR_OF_PRODUCTION,CAR_MODEL,NUMBER_OF_PASSENGER,BEGINING_DATE,END_DATE,INSTALLMENT,PURCHASE_DATE,PURCHASE_PRICE,C1,status,G1) values (:reg_num,:fuel,:eng_size,:prod_year,:model,:pass_num,:beg_date ,:end_date,:instal,NULL,NULL, :cust_id,:status,:g_id)";

            cmd.Parameters.Add("reg_num", txt_reg_num.Text);
            cmd.Parameters.Add("fuel", txt_fuel.Text);
            cmd.Parameters.Add("eng_size", txt_engine.Text);
            cmd.Parameters.Add("prod_year", txt_production.Text);
            cmd.Parameters.Add("model", txt_model.Text);
            cmd.Parameters.Add("pass_num", txt_pass_num.Text);
            cmd.Parameters.Add("beg_date", txt_begining_date.Text);
            cmd.Parameters.Add("end_date", txt_end_date.Text);
            cmd.Parameters.Add("instal", txt_installment.Text);
            cmd.Parameters.Add("cust_id", txt_cust_id.Text);
            cmd.Parameters.Add("status", txt_status.Text);
            cmd.Parameters.Add("g_id", txt_g.Text);

            int r = cmd.ExecuteNonQuery();
           if (r != -1)
            {

                MessageBox.Show("New rent is added");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = con;
            cmd2.CommandText = "delete from car where REGISTRATION_NUMBER =:r";
            cmd2.Parameters.Add(":r",txt_reg_num.Text);
            int r = cmd2.ExecuteNonQuery();
            if(r!= -1)
            {
                MessageBox.Show("car deleted");
                txt_reg_num.Text = "";
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = con;

            cmd2.CommandText = "update car set REGISTRATION_NUMBER =:reg_num ,FUEL_TYPE =:fuel,ENGINE_SIZE =:eng_size,YEAR_OF_PRODUCTION =:prod_year,CAR_MODEL =:model,NUMBER_OF_PASSENGER =:pass_num,BEGINING_DATE =:beg_date,END_DATE =:end_date,C1 =:cust_id,status =:status ,G1 =:g_id where REGISTRATION_NUMBER =:reg_num ";
            cmd2.Parameters.Add("reg_num", txt_reg_num.Text);
            cmd2.Parameters.Add("fuel", txt_fuel.Text);
            cmd2.Parameters.Add("eng_size", txt_engine.Text);
            cmd2.Parameters.Add("prod_year", txt_production.Text);
            cmd2.Parameters.Add("model", txt_model.Text);
            cmd2.Parameters.Add("pass_num", txt_pass_num.Text);
            cmd2.Parameters.Add("beg_date", txt_begining_date.Text);
            cmd2.Parameters.Add("end_date", txt_end_date.Text);
            cmd2.Parameters.Add("cust_id", txt_cust_id.Text);
            cmd2.Parameters.Add("status", txt_status.Text);
            cmd2.Parameters.Add("g_id", txt_g.Text);




            int r1 = cmd2.ExecuteNonQuery();
            if (r1 != -1)
            {
                MessageBox.Show("car updated");
            }

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
