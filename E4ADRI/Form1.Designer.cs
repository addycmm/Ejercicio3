namespace E4ADRI
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dataGridView2 = new DataGridView();
            button4 = new Button();
            button5 = new Button();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            button6 = new Button();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(135, 75);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(717, 217);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(264, 37);
            label1.TabIndex = 1;
            label1.Text = "Personas Registradas";
            // 
            // button1
            // 
            button1.Location = new Point(401, 449);
            button1.Name = "button1";
            button1.Size = new Size(150, 40);
            button1.TabIndex = 2;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(868, 84);
            button2.Name = "button2";
            button2.Size = new Size(150, 40);
            button2.TabIndex = 3;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(621, 326);
            button3.Name = "button3";
            button3.Size = new Size(144, 40);
            button3.TabIndex = 4;
            button3.Text = "Ver cuentas";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(104, 336);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(172, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(104, 379);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(172, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(104, 421);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(172, 23);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(104, 471);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(172, 23);
            textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(401, 335);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(147, 23);
            textBox5.TabIndex = 9;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(401, 389);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(147, 23);
            textBox6.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 339);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 11;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 382);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 12;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 424);
            label4.Name = "label4";
            label4.Size = new Size(16, 15);
            label4.TabIndex = 13;
            label4.Text = "ci";
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 474);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 14;
            label5.Text = "correo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(330, 339);
            label6.Name = "label6";
            label6.Size = new Size(65, 15);
            label6.TabIndex = 15;
            label6.Text = "contraseña";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(313, 392);
            label7.Name = "label7";
            label7.Size = new Size(82, 15);
            label7.TabIndex = 16;
            label7.Text = "departamento";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(778, 326);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(336, 149);
            dataGridView2.TabIndex = 17;
            // 
            // button4
            // 
            button4.Location = new Point(768, 499);
            button4.Name = "button4";
            button4.Size = new Size(125, 37);
            button4.TabIndex = 18;
            button4.Text = "Eliminar cuentas";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(909, 499);
            button5.Name = "button5";
            button5.Size = new Size(125, 37);
            button5.TabIndex = 19;
            button5.Text = "Editar cuentas";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(1217, 312);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(147, 23);
            textBox7.TabIndex = 20;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(1217, 357);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(147, 23);
            textBox8.TabIndex = 21;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(1217, 407);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(147, 23);
            textBox9.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1132, 320);
            label8.Name = "label8";
            label8.Size = new Size(66, 15);
            label8.TabIndex = 23;
            label8.Text = "Nro cuenta";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1126, 360);
            label9.Name = "label9";
            label9.Size = new Size(85, 15);
            label9.TabIndex = 24;
            label9.Text = "Tipo de cuenta";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1149, 410);
            label10.Name = "label10";
            label10.Size = new Size(35, 15);
            label10.TabIndex = 25;
            label10.Text = "saldo";
            label10.Click += label10_Click;
            // 
            // button6
            // 
            button6.Location = new Point(1194, 463);
            button6.Name = "button6";
            button6.Size = new Size(125, 37);
            button6.TabIndex = 26;
            button6.Text = "Agregar cuenta";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(868, 144);
            button7.Name = "button7";
            button7.Size = new Size(150, 40);
            button7.TabIndex = 27;
            button7.Text = "Editar";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1376, 588);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(dataGridView2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label2;
        private Label label3;
        private Label label4;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Label label5;
        private Label label6;
        private Label label7;
        private DataGridView dataGridView2;
        private Button button4;
        private Button button5;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button button6;
        private Button button7;
    }
}
