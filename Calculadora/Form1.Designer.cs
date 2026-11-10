namespace Calculadora
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            btnSuma = new Button();
            btnResta = new Button();
            btnMultiplicacion = new Button();
            btnDivision = new Button();
            btnModulo = new Button();
            txtResultado = new TextBox();
            btnLimpiar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(141, 28);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(123, 23);
            txtNum1.TabIndex = 0;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(141, 70);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(123, 23);
            txtNum2.TabIndex = 1;
            // 
            // btnSuma
            // 
            btnSuma.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnSuma.Location = new Point(35, 122);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(39, 38);
            btnSuma.TabIndex = 2;
            btnSuma.Text = "+";
            btnSuma.UseVisualStyleBackColor = true;
            btnSuma.Click += btnSuma_Click;
            // 
            // btnResta
            // 
            btnResta.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnResta.Location = new Point(83, 122);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(39, 38);
            btnResta.TabIndex = 3;
            btnResta.Text = "-";
            btnResta.UseVisualStyleBackColor = true;
            btnResta.Click += btnResta_Click;
            // 
            // btnMultiplicacion
            // 
            btnMultiplicacion.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnMultiplicacion.Location = new Point(131, 122);
            btnMultiplicacion.Name = "btnMultiplicacion";
            btnMultiplicacion.Size = new Size(39, 38);
            btnMultiplicacion.TabIndex = 4;
            btnMultiplicacion.Text = "×";
            btnMultiplicacion.UseVisualStyleBackColor = true;
            btnMultiplicacion.Click += btnMultiplicacion_Click;
            // 
            // btnDivision
            // 
            btnDivision.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnDivision.Location = new Point(176, 122);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(39, 38);
            btnDivision.TabIndex = 5;
            btnDivision.Text = "÷";
            btnDivision.UseVisualStyleBackColor = true;
            btnDivision.Click += btnDivision_Click;
            // 
            // btnModulo
            // 
            btnModulo.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnModulo.Location = new Point(225, 122);
            btnModulo.Name = "btnModulo";
            btnModulo.Size = new Size(39, 38);
            btnModulo.TabIndex = 6;
            btnModulo.Text = "%";
            btnModulo.UseVisualStyleBackColor = true;
            btnModulo.Click += btnModulo_Click;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(120, 191);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(123, 23);
            txtResultado.TabIndex = 7;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(49, 249);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(184, 28);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 31);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 2;
            label1.Text = "Primer número:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 78);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 1;
            label2.Text = "Segundo número:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 194);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 0;
            label3.Text = "Resultado:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 328);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLimpiar);
            Controls.Add(txtResultado);
            Controls.Add(btnModulo);
            Controls.Add(btnDivision);
            Controls.Add(btnMultiplicacion);
            Controls.Add(btnResta);
            Controls.Add(btnSuma);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Name = "Form1";
            Text = "Calculadora Básica";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnMultiplicacion;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnModulo;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}