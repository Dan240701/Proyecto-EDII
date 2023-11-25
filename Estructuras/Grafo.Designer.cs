namespace Estructuras
{
    partial class Grafo
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
            btnCrear = new Button();
            btnAgArista = new Button();
            btnEliminar = new Button();
            btnImprimir = new Button();
            txtVertice = new TextBox();
            txtOrigen = new TextBox();
            txtDestino = new TextBox();
            txtImprimir = new TextBox();
            txtEliminar = new TextBox();
            txtVerticead = new TextBox();
            panel1 = new Panel();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label8 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCrear
            // 
            btnCrear.FlatAppearance.BorderColor = Color.White;
            btnCrear.FlatStyle = FlatStyle.Popup;
            btnCrear.Font = new Font("Verdana", 9F, FontStyle.Bold | FontStyle.Italic);
            btnCrear.Location = new Point(390, 130);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(75, 23);
            btnCrear.TabIndex = 0;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnAgArista
            // 
            btnAgArista.FlatAppearance.BorderColor = Color.White;
            btnAgArista.FlatStyle = FlatStyle.Popup;
            btnAgArista.Font = new Font("Verdana", 9F, FontStyle.Bold | FontStyle.Italic);
            btnAgArista.Location = new Point(483, 176);
            btnAgArista.Name = "btnAgArista";
            btnAgArista.Size = new Size(75, 23);
            btnAgArista.TabIndex = 1;
            btnAgArista.Text = "Agregar";
            btnAgArista.UseVisualStyleBackColor = true;
            btnAgArista.Click += btnAgArista_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.FlatAppearance.BorderColor = Color.White;
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Font = new Font("Verdana", 9F, FontStyle.Bold | FontStyle.Italic);
            btnEliminar.Location = new Point(451, 227);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.FlatAppearance.BorderColor = Color.White;
            btnImprimir.FlatStyle = FlatStyle.Popup;
            btnImprimir.Font = new Font("Verdana", 9F, FontStyle.Bold | FontStyle.Italic);
            btnImprimir.Location = new Point(437, 281);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(89, 23);
            btnImprimir.TabIndex = 3;
            btnImprimir.Text = "Adyacentes";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // txtVertice
            // 
            txtVertice.Font = new Font("Verdana", 9F, FontStyle.Bold | FontStyle.Italic);
            txtVertice.Location = new Point(262, 130);
            txtVertice.Name = "txtVertice";
            txtVertice.Size = new Size(100, 22);
            txtVertice.TabIndex = 4;
            txtVertice.KeyPress += txtVertice_KeyPress;
            // 
            // txtOrigen
            // 
            txtOrigen.Font = new Font("Verdana", 9F, FontStyle.Bold | FontStyle.Italic);
            txtOrigen.Location = new Point(173, 176);
            txtOrigen.Name = "txtOrigen";
            txtOrigen.Size = new Size(100, 22);
            txtOrigen.TabIndex = 5;
            txtOrigen.KeyPress += txtVertice_KeyPress;
            // 
            // txtDestino
            // 
            txtDestino.Font = new Font("Verdana", 9F, FontStyle.Bold | FontStyle.Italic);
            txtDestino.Location = new Point(346, 176);
            txtDestino.Name = "txtDestino";
            txtDestino.Size = new Size(100, 22);
            txtDestino.TabIndex = 6;
            txtDestino.KeyPress += txtVertice_KeyPress;
            // 
            // txtImprimir
            // 
            txtImprimir.Font = new Font("Verdana", 9F, FontStyle.Bold | FontStyle.Italic);
            txtImprimir.Location = new Point(173, 356);
            txtImprimir.Multiline = true;
            txtImprimir.Name = "txtImprimir";
            txtImprimir.Size = new Size(298, 73);
            txtImprimir.TabIndex = 7;
            // 
            // txtEliminar
            // 
            txtEliminar.Font = new Font("Verdana", 9F, FontStyle.Bold | FontStyle.Italic);
            txtEliminar.Location = new Point(231, 227);
            txtEliminar.Name = "txtEliminar";
            txtEliminar.Size = new Size(184, 22);
            txtEliminar.TabIndex = 8;
            txtEliminar.KeyPress += txtVertice_KeyPress;
            // 
            // txtVerticead
            // 
            txtVerticead.Font = new Font("Verdana", 9F, FontStyle.Bold | FontStyle.Italic);
            txtVerticead.Location = new Point(231, 282);
            txtVerticead.Name = "txtVerticead";
            txtVerticead.Size = new Size(184, 22);
            txtVerticead.TabIndex = 9;
            txtVerticead.KeyPress += txtVertice_KeyPress;
            // 
            // panel1
            // 
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Font = new Font("Verdana", 9F, FontStyle.Bold | FontStyle.Italic);
            panel1.Location = new Point(50, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(589, 114);
            panel1.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 9F, FontStyle.Bold | FontStyle.Italic);
            label9.Location = new Point(3, 10);
            label9.Name = "label9";
            label9.Size = new Size(77, 14);
            label9.TabIndex = 2;
            label9.Text = "Ejercicio 2";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 9F, FontStyle.Bold | FontStyle.Italic);
            label7.Location = new Point(3, 64);
            label7.Name = "label7";
            label7.Size = new Size(567, 14);
            label7.TabIndex = 1;
            label7.Text = "en su lista. Además, se incluyo un eliminar las arista solo si su vértice es sumidero\r\n";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 9F, FontStyle.Bold | FontStyle.Italic);
            label6.Location = new Point(3, 35);
            label6.Name = "label6";
            label6.Size = new Size(557, 14);
            label6.TabIndex = 0;
            label6.Text = " Dado un vértice o nodo verifique, si existe e imprima todos los nodos adyacentes";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(112, 134);
            label1.Name = "label1";
            label1.Size = new Size(144, 14);
            label1.TabIndex = 11;
            label1.Text = "Cantidad de vertices";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(115, 180);
            label2.Name = "label2";
            label2.Size = new Size(52, 14);
            label2.TabIndex = 12;
            label2.Text = "Origen";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(282, 179);
            label3.Name = "label3";
            label3.Size = new Size(58, 14);
            label3.TabIndex = 13;
            label3.Text = "Destino";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(119, 231);
            label4.Name = "label4";
            label4.Size = new Size(106, 14);
            label4.TabIndex = 14;
            label4.Text = "Eliminar arista";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(70, 285);
            label5.Name = "label5";
            label5.Size = new Size(155, 14);
            label5.TabIndex = 15;
            label5.Text = "Encontras adyacentes";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 9F, FontStyle.Bold | FontStyle.Italic);
            label8.Location = new Point(262, 329);
            label8.Name = "label8";
            label8.Size = new Size(136, 14);
            label8.TabIndex = 16;
            label8.Text = "Resultado del grafo";
            // 
            // Grafo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(663, 453);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(txtVerticead);
            Controls.Add(txtEliminar);
            Controls.Add(txtImprimir);
            Controls.Add(txtDestino);
            Controls.Add(txtOrigen);
            Controls.Add(txtVertice);
            Controls.Add(btnImprimir);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgArista);
            Controls.Add(btnCrear);
            Name = "Grafo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Grafo";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCrear;
        private Button btnAgArista;
        private Button btnEliminar;
        private Button btnImprimir;
        private TextBox txtVertice;
        private TextBox txtOrigen;
        private TextBox txtDestino;
        private TextBox txtImprimir;
        private TextBox txtEliminar;
        private TextBox txtVerticead;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}