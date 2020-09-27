namespace CalculadorDeMatrices
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxMatrizA = new System.Windows.Forms.GroupBox();
            this.btMatrizACrear = new System.Windows.Forms.Button();
            this.btLimpiarMatrizA = new System.Windows.Forms.Button();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btMatrizBCrear = new System.Windows.Forms.Button();
            this.groupBoxMatrizB = new System.Windows.Forms.GroupBox();
            this.btLimpiarMatrizB = new System.Windows.Forms.Button();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.brSumaMatrices = new System.Windows.Forms.Button();
            this.btRestaMatrices = new System.Windows.Forms.Button();
            this.btMultiMatrices = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBoxMatrizResultado = new System.Windows.Forms.GroupBox();
            this.btEscalar = new System.Windows.Forms.Button();
            this.txtEscalar = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBoxMatrizA);
            this.panel1.Controls.Add(this.btMatrizACrear);
            this.panel1.Controls.Add(this.btLimpiarMatrizA);
            this.panel1.Controls.Add(this.numericUpDown2);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(7, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 306);
            this.panel1.TabIndex = 0;
            // 
            // groupBoxMatrizA
            // 
            this.groupBoxMatrizA.Location = new System.Drawing.Point(8, 105);
            this.groupBoxMatrizA.Name = "groupBoxMatrizA";
            this.groupBoxMatrizA.Size = new System.Drawing.Size(331, 194);
            this.groupBoxMatrizA.TabIndex = 15;
            this.groupBoxMatrizA.TabStop = false;
            this.groupBoxMatrizA.Text = "Matriz A";
            // 
            // btMatrizACrear
            // 
            this.btMatrizACrear.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btMatrizACrear.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btMatrizACrear.Location = new System.Drawing.Point(235, 6);
            this.btMatrizACrear.Name = "btMatrizACrear";
            this.btMatrizACrear.Size = new System.Drawing.Size(104, 38);
            this.btMatrizACrear.TabIndex = 14;
            this.btMatrizACrear.Text = "Crear Matriz";
            this.btMatrizACrear.UseVisualStyleBackColor = false;
            this.btMatrizACrear.Click += new System.EventHandler(this.btMatrizACrear_Click);
            // 
            // btLimpiarMatrizA
            // 
            this.btLimpiarMatrizA.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btLimpiarMatrizA.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btLimpiarMatrizA.Location = new System.Drawing.Point(235, 51);
            this.btLimpiarMatrizA.Name = "btLimpiarMatrizA";
            this.btLimpiarMatrizA.Size = new System.Drawing.Size(104, 30);
            this.btLimpiarMatrizA.TabIndex = 13;
            this.btLimpiarMatrizA.Text = "Limpiar ";
            this.btLimpiarMatrizA.UseVisualStyleBackColor = false;
            this.btLimpiarMatrizA.Click += new System.EventHandler(this.btLimpiarMatrizA_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(107, 51);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(66, 20);
            this.numericUpDown2.TabIndex = 12;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(107, 19);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(66, 20);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Columnas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(8, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Matriz A";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btMatrizBCrear);
            this.panel2.Controls.Add(this.groupBoxMatrizB);
            this.panel2.Controls.Add(this.btLimpiarMatrizB);
            this.panel2.Controls.Add(this.numericUpDown3);
            this.panel2.Controls.Add(this.numericUpDown4);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(362, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(353, 306);
            this.panel2.TabIndex = 2;
            // 
            // btMatrizBCrear
            // 
            this.btMatrizBCrear.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btMatrizBCrear.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btMatrizBCrear.Location = new System.Drawing.Point(235, 7);
            this.btMatrizBCrear.Name = "btMatrizBCrear";
            this.btMatrizBCrear.Size = new System.Drawing.Size(104, 38);
            this.btMatrizBCrear.TabIndex = 17;
            this.btMatrizBCrear.Text = "Crear Matriz";
            this.btMatrizBCrear.UseVisualStyleBackColor = false;
            this.btMatrizBCrear.Click += new System.EventHandler(this.btMatrizBCrear_Click);
            // 
            // groupBoxMatrizB
            // 
            this.groupBoxMatrizB.Location = new System.Drawing.Point(8, 105);
            this.groupBoxMatrizB.Name = "groupBoxMatrizB";
            this.groupBoxMatrizB.Size = new System.Drawing.Size(331, 194);
            this.groupBoxMatrizB.TabIndex = 16;
            this.groupBoxMatrizB.TabStop = false;
            this.groupBoxMatrizB.Text = "Matriz B";
            // 
            // btLimpiarMatrizB
            // 
            this.btLimpiarMatrizB.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btLimpiarMatrizB.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btLimpiarMatrizB.Location = new System.Drawing.Point(235, 51);
            this.btLimpiarMatrizB.Name = "btLimpiarMatrizB";
            this.btLimpiarMatrizB.Size = new System.Drawing.Size(104, 30);
            this.btLimpiarMatrizB.TabIndex = 13;
            this.btLimpiarMatrizB.Text = "Limpiar ";
            this.btLimpiarMatrizB.UseVisualStyleBackColor = false;
            this.btLimpiarMatrizB.Click += new System.EventHandler(this.btLimpiarMatrizB_Click);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(107, 51);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(66, 20);
            this.numericUpDown3.TabIndex = 12;
            this.numericUpDown3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(107, 19);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(66, 20);
            this.numericUpDown4.TabIndex = 11;
            this.numericUpDown4.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Columnas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Filas:";
            // 
            // brSumaMatrices
            // 
            this.brSumaMatrices.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.brSumaMatrices.Font = new System.Drawing.Font("Tahoma", 12F);
            this.brSumaMatrices.Location = new System.Drawing.Point(56, 373);
            this.brSumaMatrices.Name = "brSumaMatrices";
            this.brSumaMatrices.Size = new System.Drawing.Size(114, 48);
            this.brSumaMatrices.TabIndex = 14;
            this.brSumaMatrices.Text = "+";
            this.brSumaMatrices.UseVisualStyleBackColor = false;
            this.brSumaMatrices.Click += new System.EventHandler(this.brSumaMatrices_Click);
            // 
            // btRestaMatrices
            // 
            this.btRestaMatrices.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btRestaMatrices.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btRestaMatrices.Location = new System.Drawing.Point(116, 427);
            this.btRestaMatrices.Name = "btRestaMatrices";
            this.btRestaMatrices.Size = new System.Drawing.Size(54, 40);
            this.btRestaMatrices.TabIndex = 15;
            this.btRestaMatrices.Text = "-";
            this.btRestaMatrices.UseVisualStyleBackColor = false;
            this.btRestaMatrices.Click += new System.EventHandler(this.btRestaMatrices_Click);
            // 
            // btMultiMatrices
            // 
            this.btMultiMatrices.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btMultiMatrices.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btMultiMatrices.Location = new System.Drawing.Point(56, 427);
            this.btMultiMatrices.Name = "btMultiMatrices";
            this.btMultiMatrices.Size = new System.Drawing.Size(54, 40);
            this.btMultiMatrices.TabIndex = 16;
            this.btMultiMatrices.Text = "*";
            this.btMultiMatrices.UseVisualStyleBackColor = false;
            this.btMultiMatrices.Click += new System.EventHandler(this.btMultiMatrices_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button9.Font = new System.Drawing.Font("Tahoma", 12F);
            this.button9.Location = new System.Drawing.Point(56, 540);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(114, 49);
            this.button9.TabIndex = 18;
            this.button9.Text = "Limpiar ";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label6.Location = new System.Drawing.Point(358, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 19);
            this.label6.TabIndex = 20;
            this.label6.Text = "Matriz B";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label7.Location = new System.Drawing.Point(231, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 19);
            this.label7.TabIndex = 21;
            this.label7.Text = "Matriz Resultante";
            // 
            // groupBoxMatrizResultado
            // 
            this.groupBoxMatrizResultado.Location = new System.Drawing.Point(225, 363);
            this.groupBoxMatrizResultado.Name = "groupBoxMatrizResultado";
            this.groupBoxMatrizResultado.Size = new System.Drawing.Size(478, 226);
            this.groupBoxMatrizResultado.TabIndex = 22;
            this.groupBoxMatrizResultado.TabStop = false;
            this.groupBoxMatrizResultado.Text = "Matriz Resultado";
            // 
            // btEscalar
            // 
            this.btEscalar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btEscalar.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btEscalar.Location = new System.Drawing.Point(56, 502);
            this.btEscalar.Name = "btEscalar";
            this.btEscalar.Size = new System.Drawing.Size(114, 32);
            this.btEscalar.TabIndex = 23;
            this.btEscalar.Text = "Escalar";
            this.btEscalar.UseVisualStyleBackColor = false;
            this.btEscalar.Click += new System.EventHandler(this.btEscalar_Click);
            // 
            // txtEscalar
            // 
            this.txtEscalar.BackColor = System.Drawing.SystemColors.Window;
            this.txtEscalar.Location = new System.Drawing.Point(56, 473);
            this.txtEscalar.Name = "txtEscalar";
            this.txtEscalar.Size = new System.Drawing.Size(114, 20);
            this.txtEscalar.TabIndex = 24;
            this.txtEscalar.Text = "ingresar escalar";
            this.txtEscalar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(719, 608);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.groupBoxMatrizResultado);
            this.Controls.Add(this.txtEscalar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.brSumaMatrices);
            this.Controls.Add(this.btEscalar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btRestaMatrices);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btMultiMatrices);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Matrices_Artino";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btMatrizACrear;
        private System.Windows.Forms.Button btLimpiarMatrizA;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btLimpiarMatrizB;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button brSumaMatrices;
        private System.Windows.Forms.Button btRestaMatrices;
        private System.Windows.Forms.Button btMultiMatrices;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBoxMatrizA;
        private System.Windows.Forms.GroupBox groupBoxMatrizB;
        private System.Windows.Forms.GroupBox groupBoxMatrizResultado;
        private System.Windows.Forms.Button btMatrizBCrear;
        private System.Windows.Forms.Button btEscalar;
        private System.Windows.Forms.TextBox txtEscalar;
    }
}

