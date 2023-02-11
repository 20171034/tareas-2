
namespace ejercise_2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MateriatextBox = new System.Windows.Forms.TextBox();
            this.Nota2textBox = new System.Windows.Forms.TextBox();
            this.Nota3textBox = new System.Windows.Forms.TextBox();
            this.nota4textBox = new System.Windows.Forms.TextBox();
            this.nota1textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PromediotextBox = new System.Windows.Forms.TextBox();
            this.resultadobutton = new System.Windows.Forms.Button();
            this.Limpiarbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de La Materia que Curso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nota 4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nota 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nota 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nota 1";
            // 
            // MateriatextBox
            // 
            this.MateriatextBox.Location = new System.Drawing.Point(245, 38);
            this.MateriatextBox.Name = "MateriatextBox";
            this.MateriatextBox.Size = new System.Drawing.Size(216, 20);
            this.MateriatextBox.TabIndex = 5;
            // 
            // Nota2textBox
            // 
            this.Nota2textBox.Location = new System.Drawing.Point(245, 122);
            this.Nota2textBox.Name = "Nota2textBox";
            this.Nota2textBox.Size = new System.Drawing.Size(216, 20);
            this.Nota2textBox.TabIndex = 6;
            // 
            // Nota3textBox
            // 
            this.Nota3textBox.Location = new System.Drawing.Point(245, 155);
            this.Nota3textBox.Name = "Nota3textBox";
            this.Nota3textBox.Size = new System.Drawing.Size(216, 20);
            this.Nota3textBox.TabIndex = 7;
            // 
            // nota4textBox
            // 
            this.nota4textBox.Location = new System.Drawing.Point(245, 188);
            this.nota4textBox.Name = "nota4textBox";
            this.nota4textBox.Size = new System.Drawing.Size(216, 20);
            this.nota4textBox.TabIndex = 8;
            // 
            // nota1textBox
            // 
            this.nota1textBox.Location = new System.Drawing.Point(245, 85);
            this.nota1textBox.Name = "nota1textBox";
            this.nota1textBox.Size = new System.Drawing.Size(216, 20);
            this.nota1textBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Promedio Final";
            // 
            // PromediotextBox
            // 
            this.PromediotextBox.Location = new System.Drawing.Point(245, 231);
            this.PromediotextBox.Name = "PromediotextBox";
            this.PromediotextBox.Size = new System.Drawing.Size(216, 20);
            this.PromediotextBox.TabIndex = 11;
            // 
            // resultadobutton
            // 
            this.resultadobutton.Location = new System.Drawing.Point(521, 46);
            this.resultadobutton.Name = "resultadobutton";
            this.resultadobutton.Size = new System.Drawing.Size(127, 58);
            this.resultadobutton.TabIndex = 12;
            this.resultadobutton.Text = "Resultado";
            this.resultadobutton.UseVisualStyleBackColor = true;
            this.resultadobutton.Click += new System.EventHandler(this.resultadobutton_Click);
            // 
            // Limpiarbutton
            // 
            this.Limpiarbutton.Location = new System.Drawing.Point(521, 135);
            this.Limpiarbutton.Name = "Limpiarbutton";
            this.Limpiarbutton.Size = new System.Drawing.Size(127, 58);
            this.Limpiarbutton.TabIndex = 13;
            this.Limpiarbutton.Text = "Limpiar";
            this.Limpiarbutton.UseVisualStyleBackColor = true;
            this.Limpiarbutton.Click += new System.EventHandler(this.Limpiarbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 291);
            this.Controls.Add(this.Limpiarbutton);
            this.Controls.Add(this.resultadobutton);
            this.Controls.Add(this.PromediotextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nota1textBox);
            this.Controls.Add(this.nota4textBox);
            this.Controls.Add(this.Nota3textBox);
            this.Controls.Add(this.Nota2textBox);
            this.Controls.Add(this.MateriatextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MateriatextBox;
        private System.Windows.Forms.TextBox Nota2textBox;
        private System.Windows.Forms.TextBox Nota3textBox;
        private System.Windows.Forms.TextBox nota4textBox;
        private System.Windows.Forms.TextBox nota1textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PromediotextBox;
        private System.Windows.Forms.Button resultadobutton;
        private System.Windows.Forms.Button Limpiarbutton;
    }
}

