
namespace Laborator1
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
            this.Connect = new System.Windows.Forms.Button();
            this.dataGridView_Adresse = new System.Windows.Forms.DataGridView();
            this.dataGridView_Kunde = new System.Windows.Forms.DataGridView();
            this.Adresse = new System.Windows.Forms.Label();
            this.Runway = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_CL_ID = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBoxAdresse_ID = new System.Windows.Forms.TextBox();
            this.Insert_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Update_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Adresse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Kunde)).BeginInit();
            this.SuspendLayout();
            // 
            // Connect
            // 
            this.Connect.BackColor = System.Drawing.Color.RosyBrown;
            this.Connect.FlatAppearance.BorderSize = 0;
            this.Connect.Font = new System.Drawing.Font("Eras Medium ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connect.ForeColor = System.Drawing.Color.Black;
            this.Connect.Location = new System.Drawing.Point(12, 31);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(127, 38);
            this.Connect.TabIndex = 0;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = false;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // dataGridView_Adresse
            // 
            this.dataGridView_Adresse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_Adresse.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Adresse.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView_Adresse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Adresse.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView_Adresse.Location = new System.Drawing.Point(171, 58);
            this.dataGridView_Adresse.Name = "dataGridView_Adresse";
            this.dataGridView_Adresse.RowHeadersWidth = 51;
            this.dataGridView_Adresse.Size = new System.Drawing.Size(300, 172);
            this.dataGridView_Adresse.TabIndex = 1;
            this.dataGridView_Adresse.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Adresse_CellContentClick);
            // 
            // dataGridView_Kunde
            // 
            this.dataGridView_Kunde.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_Kunde.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Kunde.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView_Kunde.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Kunde.Location = new System.Drawing.Point(171, 263);
            this.dataGridView_Kunde.Name = "dataGridView_Kunde";
            this.dataGridView_Kunde.RowHeadersWidth = 51;
            this.dataGridView_Kunde.Size = new System.Drawing.Size(300, 176);
            this.dataGridView_Kunde.TabIndex = 2;
            this.dataGridView_Kunde.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Kunde_CellContentClick);
            // 
            // Adresse
            // 
            this.Adresse.AutoSize = true;
            this.Adresse.BackColor = System.Drawing.Color.RosyBrown;
            this.Adresse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Adresse.Font = new System.Drawing.Font("Eras Medium ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adresse.Location = new System.Drawing.Point(171, 31);
            this.Adresse.Name = "Adresse";
            this.Adresse.Size = new System.Drawing.Size(99, 29);
            this.Adresse.TabIndex = 3;
            this.Adresse.Text = "Adresse\r\n";
            // 
            // Runway
            // 
            this.Runway.AutoSize = true;
            this.Runway.BackColor = System.Drawing.Color.RosyBrown;
            this.Runway.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Runway.Font = new System.Drawing.Font("Eras Medium ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Runway.Location = new System.Drawing.Point(171, 236);
            this.Runway.Name = "Runway";
            this.Runway.Size = new System.Drawing.Size(83, 29);
            this.Runway.TabIndex = 4;
            this.Runway.Text = "Kunde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(504, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "CL_ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(504, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(504, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Adresse_ID";
            // 
            // textBox_CL_ID
            // 
            this.textBox_CL_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_CL_ID.Location = new System.Drawing.Point(581, 262);
            this.textBox_CL_ID.Name = "textBox_CL_ID";
            this.textBox_CL_ID.Size = new System.Drawing.Size(141, 26);
            this.textBox_CL_ID.TabIndex = 8;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_Name.Location = new System.Drawing.Point(581, 296);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(140, 26);
            this.textBox_Name.TabIndex = 9;
            // 
            // textBoxAdresse_ID
            // 
            this.textBoxAdresse_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxAdresse_ID.Location = new System.Drawing.Point(604, 332);
            this.textBoxAdresse_ID.Name = "textBoxAdresse_ID";
            this.textBoxAdresse_ID.Size = new System.Drawing.Size(117, 26);
            this.textBoxAdresse_ID.TabIndex = 10;
            // 
            // Insert_button
            // 
            this.Insert_button.BackColor = System.Drawing.Color.RosyBrown;
            this.Insert_button.FlatAppearance.BorderSize = 0;
            this.Insert_button.Font = new System.Drawing.Font("Eras Medium ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert_button.ForeColor = System.Drawing.Color.Black;
            this.Insert_button.Location = new System.Drawing.Point(502, 367);
            this.Insert_button.Name = "Insert_button";
            this.Insert_button.Size = new System.Drawing.Size(90, 31);
            this.Insert_button.TabIndex = 11;
            this.Insert_button.Text = "Insert";
            this.Insert_button.UseVisualStyleBackColor = false;
            this.Insert_button.Click += new System.EventHandler(this.Insert_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.BackColor = System.Drawing.Color.RosyBrown;
            this.Delete_button.FlatAppearance.BorderSize = 0;
            this.Delete_button.Font = new System.Drawing.Font("Eras Medium ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_button.ForeColor = System.Drawing.Color.Black;
            this.Delete_button.Location = new System.Drawing.Point(598, 367);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(92, 31);
            this.Delete_button.TabIndex = 12;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = false;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Update_button
            // 
            this.Update_button.BackColor = System.Drawing.Color.RosyBrown;
            this.Update_button.FlatAppearance.BorderSize = 0;
            this.Update_button.Font = new System.Drawing.Font("Eras Medium ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_button.ForeColor = System.Drawing.Color.Black;
            this.Update_button.Location = new System.Drawing.Point(696, 367);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(88, 31);
            this.Update_button.TabIndex = 13;
            this.Update_button.Text = "Update";
            this.Update_button.UseVisualStyleBackColor = false;
            this.Update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(796, 481);
            this.Controls.Add(this.Update_button);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Insert_button);
            this.Controls.Add(this.textBoxAdresse_ID);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.textBox_CL_ID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Runway);
            this.Controls.Add(this.Adresse);
            this.Controls.Add(this.dataGridView_Kunde);
            this.Controls.Add(this.dataGridView_Adresse);
            this.Controls.Add(this.Connect);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Adresse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Kunde)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.DataGridView dataGridView_Adresse;
        private System.Windows.Forms.DataGridView dataGridView_Kunde;
        private System.Windows.Forms.Label Adresse;
        private System.Windows.Forms.Label Runway;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_CL_ID;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBoxAdresse_ID;
        private System.Windows.Forms.Button Insert_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Update_button;
    }
}

