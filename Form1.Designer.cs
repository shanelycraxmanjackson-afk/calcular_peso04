namespace calcular_peso04
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.box1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.box2 = new System.Windows.Forms.TextBox();
            this.boton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.box3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1 - peso
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "peso";
            // 
            // box1 - ingreso peso
            // 
            this.box1.Location = new System.Drawing.Point(298, 49);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(141, 22);
            this.box1.TabIndex = 1;
            // 
            // label2 - altura
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "altura";
            // 
            // box2 - ingreso altura
            // 
            this.box2.Location = new System.Drawing.Point(298, 129);
            this.box2.Name = "box2";
            this.box2.Size = new System.Drawing.Size(141, 22);
            this.box2.TabIndex = 3;
            // 
            // boton - calcular
            // 
            this.boton.Location = new System.Drawing.Point(298, 230);
            this.boton.Name = "boton";
            this.boton.Size = new System.Drawing.Size(141, 28);
            this.boton.TabIndex = 4;
            this.boton.Text = "calcular";
            this.boton.UseVisualStyleBackColor = true;
            this.boton.Click += new System.EventHandler(this.boton_Click);
            // 
            // label3 - es sano❤️?
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "es sano❤️?";
            // 
            // box3 - resultado
            // 
            this.box3.Location = new System.Drawing.Point(298, 319);
            this.box3.Name = "box3";
            this.box3.Size = new System.Drawing.Size(141, 22);
            this.box3.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.box3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boton);
            this.Controls.Add(this.box2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.box1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculadora IMC";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox box1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox box2;
        private System.Windows.Forms.Button boton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox box3;
    }
}
