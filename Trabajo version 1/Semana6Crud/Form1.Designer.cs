namespace Semana6Crud
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
            Nombretxtbox = new TextBox();
            Direcciontxtbox = new TextBox();
            Apellidotxtbox = new TextBox();
            ClienteIdtxtbox = new TextBox();
            Actualizarbttn = new Button();
            Crearbttn = new Button();
            Eliminarbttn = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Nombretxtbox
            // 
            Nombretxtbox.Location = new Point(138, 112);
            Nombretxtbox.Name = "Nombretxtbox";
            Nombretxtbox.Size = new Size(100, 23);
            Nombretxtbox.TabIndex = 0;
            // 
            // Direcciontxtbox
            // 
            Direcciontxtbox.Location = new Point(138, 232);
            Direcciontxtbox.Name = "Direcciontxtbox";
            Direcciontxtbox.Size = new Size(100, 23);
            Direcciontxtbox.TabIndex = 1;
            Direcciontxtbox.TextChanged += Direcciontxtbox_TextChanged;
            // 
            // Apellidotxtbox
            // 
            Apellidotxtbox.Location = new Point(138, 172);
            Apellidotxtbox.Name = "Apellidotxtbox";
            Apellidotxtbox.Size = new Size(100, 23);
            Apellidotxtbox.TabIndex = 2;
            // 
            // ClienteIdtxtbox
            // 
            ClienteIdtxtbox.AccessibleDescription = "";
            ClienteIdtxtbox.Location = new Point(138, 307);
            ClienteIdtxtbox.Name = "ClienteIdtxtbox";
            ClienteIdtxtbox.ReadOnly = true;
            ClienteIdtxtbox.Size = new Size(100, 23);
            ClienteIdtxtbox.TabIndex = 3;
            ClienteIdtxtbox.Text = "Administrativo";
            ClienteIdtxtbox.TextChanged += ClienteIdtxtbox_TextChanged;
            // 
            // Actualizarbttn
            // 
            Actualizarbttn.Location = new Point(283, 378);
            Actualizarbttn.Name = "Actualizarbttn";
            Actualizarbttn.Size = new Size(75, 23);
            Actualizarbttn.TabIndex = 4;
            Actualizarbttn.Text = "Actualizar";
            Actualizarbttn.UseVisualStyleBackColor = true;
            Actualizarbttn.Click += Actualizarbttn_Click;
            // 
            // Crearbttn
            // 
            Crearbttn.Location = new Point(408, 378);
            Crearbttn.Name = "Crearbttn";
            Crearbttn.Size = new Size(75, 23);
            Crearbttn.TabIndex = 5;
            Crearbttn.Text = "Crear";
            Crearbttn.UseVisualStyleBackColor = true;
            Crearbttn.Click += Crearbttn_Click;
            // 
            // Eliminarbttn
            // 
            Eliminarbttn.Location = new Point(521, 378);
            Eliminarbttn.Name = "Eliminarbttn";
            Eliminarbttn.Size = new Size(75, 23);
            Eliminarbttn.TabIndex = 6;
            Eliminarbttn.Text = "Eliminar";
            Eliminarbttn.UseVisualStyleBackColor = true;
            Eliminarbttn.Click += Eliminarbttn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(296, 112);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(424, 238);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 112);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 8;
            label1.Text = "Nombre";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 172);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 9;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 232);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 10;
            label3.Text = "Direccion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 310);
            label4.Name = "label4";
            label4.Size = new Size(24, 15);
            label4.TabIndex = 11;
            label4.Text = "Rol";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Britannic Bold", 21.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(261, 42);
            label5.Name = "label5";
            label5.Size = new Size(249, 32);
            label5.TabIndex = 12;
            label5.Text = "Crud de Biblioteca";
            label5.Click += label5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(Eliminarbttn);
            Controls.Add(Crearbttn);
            Controls.Add(Actualizarbttn);
            Controls.Add(ClienteIdtxtbox);
            Controls.Add(Apellidotxtbox);
            Controls.Add(Direcciontxtbox);
            Controls.Add(Nombretxtbox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Nombretxtbox;
        private TextBox Direcciontxtbox;
        private TextBox Apellidotxtbox;
        private TextBox ClienteIdtxtbox;
        private Button Actualizarbttn;
        private Button Crearbttn;
        private Button Eliminarbttn;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
