namespace WindowsFormsApplication3
{
    partial class Form1
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
            this.btn_sign_up = new System.Windows.Forms.Button();
            this.btn_sign_in = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_garage_name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_sign_up
            // 
            this.btn_sign_up.Font = new System.Drawing.Font("Snap ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sign_up.Location = new System.Drawing.Point(568, 26);
            this.btn_sign_up.Name = "btn_sign_up";
            this.btn_sign_up.Size = new System.Drawing.Size(124, 66);
            this.btn_sign_up.TabIndex = 0;
            this.btn_sign_up.Text = "sign up";
            this.btn_sign_up.UseVisualStyleBackColor = true;
            this.btn_sign_up.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_sign_in
            // 
            this.btn_sign_in.Font = new System.Drawing.Font("Snap ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sign_in.Location = new System.Drawing.Point(162, 219);
            this.btn_sign_in.Name = "btn_sign_in";
            this.btn_sign_in.Size = new System.Drawing.Size(124, 55);
            this.btn_sign_in.TabIndex = 1;
            this.btn_sign_in.Text = "sign in";
            this.btn_sign_in.UseVisualStyleBackColor = true;
            this.btn_sign_in.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "garage name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Snap ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "password :";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(238, 167);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(100, 20);
            this.txt_password.TabIndex = 4;
            // 
            // txt_garage_name
            // 
            this.txt_garage_name.Location = new System.Drawing.Point(238, 110);
            this.txt_garage_name.Name = "txt_garage_name";
            this.txt_garage_name.Size = new System.Drawing.Size(100, 20);
            this.txt_garage_name.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources.Best_Wallpapers_2011__Fun12_com__28;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(758, 518);
            this.Controls.Add(this.txt_garage_name);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_sign_in);
            this.Controls.Add(this.btn_sign_up);
            this.Name = "Form1";
            this.Text = "Sign In Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sign_up;
        private System.Windows.Forms.Button btn_sign_in;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_garage_name;
    }
}

