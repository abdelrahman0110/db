namespace WindowsFormsApplication3
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grid_rent = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_rentals = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_reg_num = new System.Windows.Forms.TextBox();
            this.txt_fuel = new System.Windows.Forms.TextBox();
            this.txt_production = new System.Windows.Forms.TextBox();
            this.txt_engine = new System.Windows.Forms.TextBox();
            this.txt_model = new System.Windows.Forms.TextBox();
            this.txt_pass_num = new System.Windows.Forms.TextBox();
            this.txt_begining_date = new System.Windows.Forms.TextBox();
            this.txt_end_date = new System.Windows.Forms.TextBox();
            this.txt_installment = new System.Windows.Forms.TextBox();
            this.txt_cust_id = new System.Windows.Forms.TextBox();
            this.btn_all_cars = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_g = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_rent)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_rent
            // 
            this.grid_rent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_rent.Location = new System.Drawing.Point(12, 12);
            this.grid_rent.Name = "grid_rent";
            this.grid_rent.Size = new System.Drawing.Size(576, 280);
            this.grid_rent.TabIndex = 0;
            this.grid_rent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_rent_CellContentClick);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Forte", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(21, 460);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(151, 49);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Add New Rent";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Forte", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(219, 460);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(151, 58);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "Update Rent info";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Forte", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(390, 465);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(151, 49);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Delete Rent";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(670, 486);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 32);
            this.button4.TabIndex = 4;
            this.button4.Text = "back";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_rentals
            // 
            this.btn_rentals.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rentals.Location = new System.Drawing.Point(594, 147);
            this.btn_rentals.Name = "btn_rentals";
            this.btn_rentals.Size = new System.Drawing.Size(151, 58);
            this.btn_rentals.TabIndex = 5;
            this.btn_rentals.Text = "Show all rentals";
            this.btn_rentals.UseVisualStyleBackColor = true;
            this.btn_rentals.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 10.25F);
            this.label1.Location = new System.Drawing.Point(9, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "REG_NUM :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 10.25F);
            this.label2.Location = new System.Drawing.Point(9, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fuel type :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 10.25F);
            this.label3.Location = new System.Drawing.Point(9, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Engine size :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 10.25F);
            this.label4.Location = new System.Drawing.Point(9, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Prouction year :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 10.25F);
            this.label5.Location = new System.Drawing.Point(260, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Model :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cooper Black", 10.25F);
            this.label6.Location = new System.Drawing.Point(260, 423);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "End date :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cooper Black", 10.25F);
            this.label7.Location = new System.Drawing.Point(260, 390);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Begining date :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cooper Black", 10.25F);
            this.label8.Location = new System.Drawing.Point(260, 361);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Passengers_num :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cooper Black", 10.25F);
            this.label9.Location = new System.Drawing.Point(523, 328);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Installment :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cooper Black", 10.25F);
            this.label10.Location = new System.Drawing.Point(524, 364);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Customer ID :";
            // 
            // txt_reg_num
            // 
            this.txt_reg_num.Location = new System.Drawing.Point(135, 331);
            this.txt_reg_num.Name = "txt_reg_num";
            this.txt_reg_num.Size = new System.Drawing.Size(100, 20);
            this.txt_reg_num.TabIndex = 18;
            // 
            // txt_fuel
            // 
            this.txt_fuel.Location = new System.Drawing.Point(135, 359);
            this.txt_fuel.Name = "txt_fuel";
            this.txt_fuel.Size = new System.Drawing.Size(100, 20);
            this.txt_fuel.TabIndex = 19;
            // 
            // txt_production
            // 
            this.txt_production.Location = new System.Drawing.Point(135, 418);
            this.txt_production.Name = "txt_production";
            this.txt_production.Size = new System.Drawing.Size(100, 20);
            this.txt_production.TabIndex = 20;
            // 
            // txt_engine
            // 
            this.txt_engine.Location = new System.Drawing.Point(135, 389);
            this.txt_engine.Name = "txt_engine";
            this.txt_engine.Size = new System.Drawing.Size(100, 20);
            this.txt_engine.TabIndex = 21;
            // 
            // txt_model
            // 
            this.txt_model.Location = new System.Drawing.Point(405, 327);
            this.txt_model.Name = "txt_model";
            this.txt_model.Size = new System.Drawing.Size(100, 20);
            this.txt_model.TabIndex = 22;
            // 
            // txt_pass_num
            // 
            this.txt_pass_num.Location = new System.Drawing.Point(405, 359);
            this.txt_pass_num.Name = "txt_pass_num";
            this.txt_pass_num.Size = new System.Drawing.Size(100, 20);
            this.txt_pass_num.TabIndex = 23;
            // 
            // txt_begining_date
            // 
            this.txt_begining_date.Location = new System.Drawing.Point(405, 386);
            this.txt_begining_date.Name = "txt_begining_date";
            this.txt_begining_date.Size = new System.Drawing.Size(100, 20);
            this.txt_begining_date.TabIndex = 24;
            // 
            // txt_end_date
            // 
            this.txt_end_date.Location = new System.Drawing.Point(405, 418);
            this.txt_end_date.Name = "txt_end_date";
            this.txt_end_date.Size = new System.Drawing.Size(100, 20);
            this.txt_end_date.TabIndex = 25;
            // 
            // txt_installment
            // 
            this.txt_installment.Location = new System.Drawing.Point(645, 324);
            this.txt_installment.Name = "txt_installment";
            this.txt_installment.Size = new System.Drawing.Size(100, 20);
            this.txt_installment.TabIndex = 26;
            // 
            // txt_cust_id
            // 
            this.txt_cust_id.Location = new System.Drawing.Point(645, 360);
            this.txt_cust_id.Name = "txt_cust_id";
            this.txt_cust_id.Size = new System.Drawing.Size(100, 20);
            this.txt_cust_id.TabIndex = 27;
            // 
            // btn_all_cars
            // 
            this.btn_all_cars.Font = new System.Drawing.Font("Cooper Black", 14.25F);
            this.btn_all_cars.Location = new System.Drawing.Point(594, 34);
            this.btn_all_cars.Name = "btn_all_cars";
            this.btn_all_cars.Size = new System.Drawing.Size(143, 74);
            this.btn_all_cars.TabIndex = 30;
            this.btn_all_cars.Text = "Show all cars";
            this.btn_all_cars.UseVisualStyleBackColor = true;
            this.btn_all_cars.Click += new System.EventHandler(this.btn_all_cars_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cooper Black", 10.25F);
            this.label11.Location = new System.Drawing.Point(524, 397);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 16);
            this.label11.TabIndex = 31;
            this.label11.Text = "Status :";
            // 
            // txt_status
            // 
            this.txt_status.Location = new System.Drawing.Point(645, 390);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(100, 20);
            this.txt_status.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cooper Black", 9.25F);
            this.label12.Location = new System.Drawing.Point(591, 214);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 15);
            this.label12.TabIndex = 33;
            this.label12.Text = "Status : (y/n)";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(645, 232);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 35;
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F);
            this.button1.Location = new System.Drawing.Point(589, 486);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 36;
            this.button1.Text = "exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cooper Black", 10.25F);
            this.label13.Location = new System.Drawing.Point(524, 426);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 16);
            this.label13.TabIndex = 37;
            this.label13.Text = "garage  id : ";
            // 
            // txt_g
            // 
            this.txt_g.Location = new System.Drawing.Point(645, 419);
            this.txt_g.Name = "txt_g";
            this.txt_g.Size = new System.Drawing.Size(100, 20);
            this.txt_g.TabIndex = 38;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources.Best_Wallpapers_2011__Fun12_com__28;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(757, 530);
            this.Controls.Add(this.txt_g);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_status);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_all_cars);
            this.Controls.Add(this.txt_cust_id);
            this.Controls.Add(this.txt_installment);
            this.Controls.Add(this.txt_end_date);
            this.Controls.Add(this.txt_begining_date);
            this.Controls.Add(this.txt_pass_num);
            this.Controls.Add(this.txt_model);
            this.Controls.Add(this.txt_engine);
            this.Controls.Add(this.txt_production);
            this.Controls.Add(this.txt_fuel);
            this.Controls.Add(this.txt_reg_num);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_rentals);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.grid_rent);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_rent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_rent;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_rentals;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_reg_num;
        private System.Windows.Forms.TextBox txt_fuel;
        private System.Windows.Forms.TextBox txt_production;
        private System.Windows.Forms.TextBox txt_engine;
        private System.Windows.Forms.TextBox txt_model;
        private System.Windows.Forms.TextBox txt_pass_num;
        private System.Windows.Forms.TextBox txt_begining_date;
        private System.Windows.Forms.TextBox txt_end_date;
        private System.Windows.Forms.TextBox txt_installment;
        private System.Windows.Forms.TextBox txt_cust_id;
        private System.Windows.Forms.Button btn_all_cars;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_g;
    }
}