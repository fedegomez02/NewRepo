namespace WindowsFormsApp1_
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
            this.BtnMostrarMedicos = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.GridPacientes = new System.Windows.Forms.DataGridView();
            this.MedicosClinicosList = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ListaHabitaciones = new System.Windows.Forms.ListBox();
            this.BtnCalcularEdad = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnMostrarMedicos
            // 
            this.BtnMostrarMedicos.Location = new System.Drawing.Point(155, 258);
            this.BtnMostrarMedicos.Name = "BtnMostrarMedicos";
            this.BtnMostrarMedicos.Size = new System.Drawing.Size(157, 63);
            this.BtnMostrarMedicos.TabIndex = 0;
            this.BtnMostrarMedicos.Text = "mostrarPacientes";
            this.BtnMostrarMedicos.UseVisualStyleBackColor = true;
            this.BtnMostrarMedicos.Click += new System.EventHandler(this.BtnMostrarMedicos_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(445, 272);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 63);
            this.button2.TabIndex = 1;
            this.button2.Text = "Mostrar Clinicos y lista medicos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GridPacientes
            // 
            this.GridPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPacientes.Location = new System.Drawing.Point(105, 82);
            this.GridPacientes.Name = "GridPacientes";
            this.GridPacientes.RowHeadersWidth = 62;
            this.GridPacientes.RowTemplate.Height = 28;
            this.GridPacientes.Size = new System.Drawing.Size(240, 150);
            this.GridPacientes.TabIndex = 2;
            // 
            // MedicosClinicosList
            // 
            this.MedicosClinicosList.FormattingEnabled = true;
            this.MedicosClinicosList.ItemHeight = 20;
            this.MedicosClinicosList.Location = new System.Drawing.Point(489, 121);
            this.MedicosClinicosList.Name = "MedicosClinicosList";
            this.MedicosClinicosList.Size = new System.Drawing.Size(120, 84);
            this.MedicosClinicosList.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(821, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListaHabitaciones
            // 
            this.ListaHabitaciones.FormattingEnabled = true;
            this.ListaHabitaciones.ItemHeight = 20;
            this.ListaHabitaciones.Location = new System.Drawing.Point(791, 121);
            this.ListaHabitaciones.Name = "ListaHabitaciones";
            this.ListaHabitaciones.Size = new System.Drawing.Size(120, 84);
            this.ListaHabitaciones.TabIndex = 5;
            // 
            // BtnCalcularEdad
            // 
            this.BtnCalcularEdad.Location = new System.Drawing.Point(477, 393);
            this.BtnCalcularEdad.Name = "BtnCalcularEdad";
            this.BtnCalcularEdad.Size = new System.Drawing.Size(164, 45);
            this.BtnCalcularEdad.TabIndex = 6;
            this.BtnCalcularEdad.Text = "Calcular Edad";
            this.BtnCalcularEdad.UseVisualStyleBackColor = true;
            this.BtnCalcularEdad.Click += new System.EventHandler(this.BtnCalcularEdad_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(890, 415);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BtnCalcularEdad);
            this.Controls.Add(this.ListaHabitaciones);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MedicosClinicosList);
            this.Controls.Add(this.GridPacientes);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnMostrarMedicos);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GridPacientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnMostrarMedicos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView GridPacientes;
        private System.Windows.Forms.ListBox MedicosClinicosList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox ListaHabitaciones;
        private System.Windows.Forms.Button BtnCalcularEdad;
        private System.Windows.Forms.Button button3;
    }
}

