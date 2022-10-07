namespace Bədən_Kütlə_indeksi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.txt_mass = new System.Windows.Forms.TextBox();
            this.txt_height = new System.Windows.Forms.TextBox();
            this.txt_index = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(341, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(236, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Body Mass-Height index Calculator";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Historic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mass of person:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Historic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Height of person:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Variable Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Purple;
            this.label5.Location = new System.Drawing.Point(30, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 40);
            this.label5.TabIndex = 4;
            this.label5.Text = "Index:";
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_exit.Location = new System.Drawing.Point(33, 439);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(94, 68);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Yellow;
            this.btn_clear.Location = new System.Drawing.Point(210, 439);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(94, 67);
            this.btn_clear.TabIndex = 6;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_calculate
            // 
            this.btn_calculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_calculate.Location = new System.Drawing.Point(399, 439);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(123, 68);
            this.btn_calculate.TabIndex = 7;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = false;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // txt_mass
            // 
            this.txt_mass.Location = new System.Drawing.Point(200, 124);
            this.txt_mass.Multiline = true;
            this.txt_mass.Name = "txt_mass";
            this.txt_mass.Size = new System.Drawing.Size(125, 34);
            this.txt_mass.TabIndex = 8;
            // 
            // txt_height
            // 
            this.txt_height.Location = new System.Drawing.Point(200, 164);
            this.txt_height.Multiline = true;
            this.txt_height.Name = "txt_height";
            this.txt_height.Size = new System.Drawing.Size(125, 33);
            this.txt_height.TabIndex = 9;
            // 
            // txt_index
            // 
            this.txt_index.Location = new System.Drawing.Point(200, 255);
            this.txt_index.Multiline = true;
            this.txt_index.Name = "txt_index";
            this.txt_index.Size = new System.Drawing.Size(125, 40);
            this.txt_index.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(25, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 40);
            this.label6.TabIndex = 11;
            this.label6.Text = "Status";
            // 
            // txt_status
            // 
            this.txt_status.Location = new System.Drawing.Point(200, 349);
            this.txt_status.Multiline = true;
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(125, 34);
            this.txt_status.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(822, 547);
            this.Controls.Add(this.txt_status);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_index);
            this.Controls.Add(this.txt_height);
            this.Controls.Add(this.txt_mass);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bədən kütlə indeksi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btn_exit;
        private Button btn_clear;
        private Button btn_calculate;
        private TextBox txt_mass;
        private TextBox txt_height;
        private TextBox txt_index;
        private Label label6;
        private TextBox txt_status;
    }
}