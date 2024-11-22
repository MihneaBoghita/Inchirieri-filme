namespace Inchirieri_filme
{
    partial class Videoteca
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_Mesaj = new System.Windows.Forms.Label();
            this.comboBox_Domeniul = new System.Windows.Forms.ComboBox();
            this.comboBox_Filmul = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_Nume = new System.Windows.Forms.TextBox();
            this.button_Inchiriez = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 11.89565F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(57, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Domeniul";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 11.89565F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(46, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Selecteaza filmul";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 11.89565F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(61, 210);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numele";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 11.89565F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 264);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data returnarii filmului";
            // 
            // label_Mesaj
            // 
            this.label_Mesaj.AutoSize = true;
            this.label_Mesaj.Font = new System.Drawing.Font("Palatino Linotype", 11.89565F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Mesaj.ForeColor = System.Drawing.Color.White;
            this.label_Mesaj.Location = new System.Drawing.Point(31, 289);
            this.label_Mesaj.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Mesaj.MaximumSize = new System.Drawing.Size(300, 0);
            this.label_Mesaj.MinimumSize = new System.Drawing.Size(300, 0);
            this.label_Mesaj.Name = "label_Mesaj";
            this.label_Mesaj.Size = new System.Drawing.Size(300, 23);
            this.label_Mesaj.TabIndex = 4;
            this.label_Mesaj.Text = "sir vid";
            // 
            // comboBox_Domeniul
            // 
            this.comboBox_Domeniul.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Domeniul.FormattingEnabled = true;
            this.comboBox_Domeniul.Items.AddRange(new object[] {
            "",
            "Dragoste",
            "Animatie",
            "Actiune",
            "Anime"});
            this.comboBox_Domeniul.Location = new System.Drawing.Point(129, 31);
            this.comboBox_Domeniul.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Domeniul.Name = "comboBox_Domeniul";
            this.comboBox_Domeniul.Size = new System.Drawing.Size(92, 21);
            this.comboBox_Domeniul.TabIndex = 5;
            this.comboBox_Domeniul.SelectedIndexChanged += new System.EventHandler(this.comboBox_Domeniul_SelectedIndexChanged);
            // 
            // comboBox_Filmul
            // 
            this.comboBox_Filmul.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Filmul.FormattingEnabled = true;
            this.comboBox_Filmul.Location = new System.Drawing.Point(158, 76);
            this.comboBox_Filmul.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Filmul.Name = "comboBox_Filmul";
            this.comboBox_Filmul.Size = new System.Drawing.Size(92, 21);
            this.comboBox_Filmul.TabIndex = 6;
            this.comboBox_Filmul.SelectedIndexChanged += new System.EventHandler(this.comboBox_Filmul_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(180, 267);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(76, 101);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_Nume
            // 
            this.textBox_Nume.Location = new System.Drawing.Point(119, 214);
            this.textBox_Nume.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Nume.Name = "textBox_Nume";
            this.textBox_Nume.Size = new System.Drawing.Size(76, 20);
            this.textBox_Nume.TabIndex = 10;
            // 
            // button_Inchiriez
            // 
            this.button_Inchiriez.BackColor = System.Drawing.Color.PaleGreen;
            this.button_Inchiriez.Location = new System.Drawing.Point(164, 337);
            this.button_Inchiriez.Margin = new System.Windows.Forms.Padding(2);
            this.button_Inchiriez.Name = "button_Inchiriez";
            this.button_Inchiriez.Size = new System.Drawing.Size(56, 19);
            this.button_Inchiriez.TabIndex = 11;
            this.button_Inchiriez.Text = "Inchiriez";
            this.button_Inchiriez.UseVisualStyleBackColor = false;
            this.button_Inchiriez.Click += new System.EventHandler(this.button_Inchiriez_Click);
            // 
            // button_Reset
            // 
            this.button_Reset.BackColor = System.Drawing.Color.PaleGreen;
            this.button_Reset.Location = new System.Drawing.Point(26, 337);
            this.button_Reset.Margin = new System.Windows.Forms.Padding(2);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(56, 19);
            this.button_Reset.TabIndex = 12;
            this.button_Reset.Text = "Reset selectii";
            this.button_Reset.UseVisualStyleBackColor = false;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // Videoteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(380, 366);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.button_Inchiriez);
            this.Controls.Add(this.textBox_Nume);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox_Filmul);
            this.Controls.Add(this.comboBox_Domeniul);
            this.Controls.Add(this.label_Mesaj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Videoteca";
            this.Text = "Inchirieri filme";
            this.Load += new System.EventHandler(this.Videoteca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_Mesaj;
        private System.Windows.Forms.ComboBox comboBox_Domeniul;
        private System.Windows.Forms.ComboBox comboBox_Filmul;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_Nume;
        private System.Windows.Forms.Button button_Inchiriez;
        private System.Windows.Forms.Button button_Reset;
    }
}

