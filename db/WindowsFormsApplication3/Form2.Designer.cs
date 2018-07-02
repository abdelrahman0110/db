namespace WindowsFormsApplication3
{
    partial class Form2
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
            this.btn_rent = new System.Windows.Forms.Button();
            this.btn_rev = new System.Windows.Forms.Button();
            this.btn_exp = new System.Windows.Forms.Button();
            this.btn_purchase = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_rent
            // 
            this.btn_rent.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rent.Location = new System.Drawing.Point(121, 12);
            this.btn_rent.Name = "btn_rent";
            this.btn_rent.Size = new System.Drawing.Size(286, 119);
            this.btn_rent.TabIndex = 0;
            this.btn_rent.Text = "Rental  cars";
            this.btn_rent.UseVisualStyleBackColor = true;
            this.btn_rent.Click += new System.EventHandler(this.btn_rent_Click);
            // 
            // btn_rev
            // 
            this.btn_rev.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rev.Location = new System.Drawing.Point(121, 149);
            this.btn_rev.Name = "btn_rev";
            this.btn_rev.Size = new System.Drawing.Size(286, 121);
            this.btn_rev.TabIndex = 1;
            this.btn_rev.Text = "Show Revenues";
            this.btn_rev.UseVisualStyleBackColor = true;
            this.btn_rev.Click += new System.EventHandler(this.btn_rev_Click);
            // 
            // btn_exp
            // 
            this.btn_exp.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exp.Location = new System.Drawing.Point(121, 285);
            this.btn_exp.Name = "btn_exp";
            this.btn_exp.Size = new System.Drawing.Size(286, 116);
            this.btn_exp.TabIndex = 2;
            this.btn_exp.Text = "Show Expenditure";
            this.btn_exp.UseVisualStyleBackColor = true;
            this.btn_exp.Click += new System.EventHandler(this.btn_exp_Click);
            // 
            // btn_purchase
            // 
            this.btn_purchase.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_purchase.Location = new System.Drawing.Point(121, 418);
            this.btn_purchase.Name = "btn_purchase";
            this.btn_purchase.Size = new System.Drawing.Size(286, 109);
            this.btn_purchase.TabIndex = 3;
            this.btn_purchase.Text = "Show Customers and CARS";
            this.btn_purchase.UseVisualStyleBackColor = true;
            this.btn_purchase.Click += new System.EventHandler(this.btn_purchase_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Ravie", 15.75F);
            this.button1.Location = new System.Drawing.Point(516, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 80);
            this.button1.TabIndex = 4;
            this.button1.Text = "Repot";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources.Best_Wallpapers_2011__Fun12_com__28;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(729, 530);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_purchase);
            this.Controls.Add(this.btn_exp);
            this.Controls.Add(this.btn_rev);
            this.Controls.Add(this.btn_rent);
            this.Name = "Form2";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_rent;
        private System.Windows.Forms.Button btn_rev;
        private System.Windows.Forms.Button btn_exp;
        private System.Windows.Forms.Button btn_purchase;
        private System.Windows.Forms.Button button1;
    }
}