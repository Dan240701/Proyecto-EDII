namespace Estructuras
{
    partial class Arbol
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
            panel1 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnHojas = new Button();
            btnEliminar = new Button();
            btnBuscar = new Button();
            txtArbol = new TextBox();
            label2 = new Label();
            btnAgregar = new Button();
            txtDato = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(87, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(537, 137);
            panel1.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 102);
            label6.Name = "label6";
            label6.Size = new Size(419, 14);
            label6.TabIndex = 3;
            label6.Text = "Se añadio un eliminar que funciona si solo es hoja para el crud";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 77);
            label5.Name = "label5";
            label5.Size = new Size(503, 14);
            label5.TabIndex = 2;
            label5.Text = "Funcionalidad: Insertar, contar e imprimir. / Método que retorna un entero.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 52);
            label4.Name = "label4";
            label4.Size = new Size(390, 14);
            label4.TabIndex = 1;
            label4.Text = "Implementa un árbol binario y cuenta cuantas hojas tiene.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 13);
            label3.Name = "label3";
            label3.Size = new Size(150, 14);
            label3.TabIndex = 0;
            label3.Text = "Ejercicio 5 de arboles";
            // 
            // btnHojas
            // 
            btnHojas.FlatAppearance.BorderColor = Color.White;
            btnHojas.FlatStyle = FlatStyle.Popup;
            btnHojas.Font = new Font("Verdana", 9F, FontStyle.Bold);
            btnHojas.Location = new Point(426, 335);
            btnHojas.Name = "btnHojas";
            btnHojas.Size = new Size(75, 23);
            btnHojas.TabIndex = 16;
            btnHojas.Text = "Hojas";
            btnHojas.UseVisualStyleBackColor = true;
            btnHojas.Click += btnHojas_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.FlatAppearance.BorderColor = Color.White;
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Font = new Font("Verdana", 9F, FontStyle.Bold);
            btnEliminar.Location = new Point(300, 335);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.FlatAppearance.BorderColor = Color.White;
            btnBuscar.FlatStyle = FlatStyle.Popup;
            btnBuscar.Font = new Font("Verdana", 9F, FontStyle.Bold);
            btnBuscar.Location = new Point(167, 332);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 14;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtArbol
            // 
            txtArbol.Font = new Font("Verdana", 9F, FontStyle.Bold);
            txtArbol.Location = new Point(219, 225);
            txtArbol.Multiline = true;
            txtArbol.Name = "txtArbol";
            txtArbol.ReadOnly = true;
            txtArbol.Size = new Size(300, 66);
            txtArbol.TabIndex = 13;
            txtArbol.KeyPress += txtArbol_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label2.Location = new Point(106, 253);
            label2.Name = "label2";
            label2.Size = new Size(111, 14);
            label2.TabIndex = 12;
            label2.Text = "Arbol Ordenado";
            // 
            // btnAgregar
            // 
            btnAgregar.FlatAppearance.BorderColor = Color.White;
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.Font = new Font("Verdana", 9F, FontStyle.Bold);
            btnAgregar.Location = new Point(401, 171);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtDato
            // 
            txtDato.Font = new Font("Verdana", 9F, FontStyle.Bold);
            txtDato.Location = new Point(230, 171);
            txtDato.Name = "txtDato";
            txtDato.Size = new Size(137, 22);
            txtDato.TabIndex = 10;
            txtDato.KeyPress += txtDato_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(106, 174);
            label1.Name = "label1";
            label1.Size = new Size(111, 14);
            label1.TabIndex = 9;
            label1.Text = "Ingrese un dato";
            // 
            // Arbol
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(663, 374);
            Controls.Add(btnHojas);
            Controls.Add(btnEliminar);
            Controls.Add(btnBuscar);
            Controls.Add(txtArbol);
            Controls.Add(label2);
            Controls.Add(btnAgregar);
            Controls.Add(txtDato);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Arbol";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            Load += Inicio_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label5;
        private Button btnHojas;
        private Button btnEliminar;
        private Button btnBuscar;
        private TextBox txtArbol;
        private Label label2;
        private Button btnAgregar;
        private TextBox txtDato;
        private Label label1;
    }
}