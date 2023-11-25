namespace Estructuras
{
    partial class Index
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
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            btnArboles = new Button();
            btnGrafo = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(135, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(440, 57);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 12);
            label1.Name = "label1";
            label1.Size = new Size(411, 29);
            label1.TabIndex = 0;
            label1.Text = "Proyecto Final De Estructuras";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(233, 336);
            label2.Name = "label2";
            label2.Size = new Size(204, 29);
            label2.TabIndex = 1;
            label2.Text = "Rodrigo López";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.unan_mangua_escudo_png_757x1024;
            pictureBox1.Location = new Point(281, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 152);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnArboles
            // 
            btnArboles.FlatStyle = FlatStyle.Popup;
            btnArboles.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic);
            btnArboles.Location = new Point(161, 262);
            btnArboles.Name = "btnArboles";
            btnArboles.Size = new Size(139, 23);
            btnArboles.TabIndex = 3;
            btnArboles.Text = "Arbol";
            btnArboles.UseVisualStyleBackColor = true;
            btnArboles.Click += btnArboles_Click;
            // 
            // btnGrafo
            // 
            btnGrafo.FlatStyle = FlatStyle.Popup;
            btnGrafo.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic);
            btnGrafo.Location = new Point(395, 262);
            btnGrafo.Name = "btnGrafo";
            btnGrafo.Size = new Size(139, 23);
            btnGrafo.TabIndex = 4;
            btnGrafo.Text = "Grafos con lista";
            btnGrafo.UseVisualStyleBackColor = true;
            btnGrafo.Click += btnGrafo_Click;
            // 
            // Index
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(663, 374);
            Controls.Add(btnGrafo);
            Controls.Add(btnArboles);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Index";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Index";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Button btnArboles;
        private Button btnGrafo;
    }
}