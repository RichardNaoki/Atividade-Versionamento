namespace Atividade_Versionamento
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtValor1 = new TextBox();
            txtValor2 = new TextBox();
            txtResultado = new TextBox();
            btnCalcular = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 118);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Valor 1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(212, 118);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Valor 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(186, 139);
            label3.Name = "label3";
            label3.Size = new Size(15, 15);
            label3.TabIndex = 2;
            label3.Text = "+";
            // 
            // txtValor1
            // 
            txtValor1.Location = new Point(82, 136);
            txtValor1.Name = "txtValor1";
            txtValor1.Size = new Size(100, 23);
            txtValor1.TabIndex = 3;
            // 
            // txtValor2
            // 
            txtValor2.Location = new Point(207, 136);
            txtValor2.Name = "txtValor2";
            txtValor2.Size = new Size(100, 23);
            txtValor2.TabIndex = 4;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(141, 225);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(100, 23);
            txtResultado.TabIndex = 5;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(154, 176);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(154, 207);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 7;
            label4.Text = "Resultado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 354);
            Controls.Add(label4);
            Controls.Add(btnCalcular);
            Controls.Add(txtResultado);
            Controls.Add(txtValor2);
            Controls.Add(txtValor1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Soma";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtValor1;
        private TextBox txtValor2;
        private TextBox txtResultado;
        private Button btnCalcular;
        private Label label4;
    }
}
