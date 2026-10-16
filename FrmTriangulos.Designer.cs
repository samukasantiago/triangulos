namespace triangulos
{
    partial class FrmTriangulos
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlDados = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudlado1 = new System.Windows.Forms.NumericUpDown();
            this.nudlado2 = new System.Windows.Forms.NumericUpDown();
            this.nudlado3 = new System.Windows.Forms.NumericUpDown();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudlado1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudlado2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudlado3)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDados
            // 
            this.pnlDados.Controls.Add(this.btnVerificar);
            this.pnlDados.Controls.Add(this.nudlado3);
            this.pnlDados.Controls.Add(this.nudlado2);
            this.pnlDados.Controls.Add(this.nudlado1);
            this.pnlDados.Controls.Add(this.label5);
            this.pnlDados.Controls.Add(this.label4);
            this.pnlDados.Controls.Add(this.label3);
            this.pnlDados.Controls.Add(this.label2);
            this.pnlDados.Controls.Add(this.label1);
            this.pnlDados.Location = new System.Drawing.Point(72, 16);
            this.pnlDados.Name = "pnlDados";
            this.pnlDados.Size = new System.Drawing.Size(384, 296);
            this.pnlDados.TabIndex = 0;
            this.pnlDados.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDados_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.WindowText;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(0, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "vamos descobrir os tipos de triangulo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(0, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "informe os 3 lados do triangulo:\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(16, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "lado 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(16, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "lado 2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(16, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "lado 3:";
            // 
            // nudlado1
            // 
            this.nudlado1.BackColor = System.Drawing.SystemColors.ControlText;
            this.nudlado1.ForeColor = System.Drawing.Color.Red;
            this.nudlado1.Location = new System.Drawing.Point(80, 96);
            this.nudlado1.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudlado1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudlado1.Name = "nudlado1";
            this.nudlado1.Size = new System.Drawing.Size(96, 27);
            this.nudlado1.TabIndex = 5;
            this.nudlado1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudlado1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudlado1.ValueChanged += new System.EventHandler(this.nud1_ValueChanged);
            // 
            // nudlado2
            // 
            this.nudlado2.BackColor = System.Drawing.SystemColors.ControlText;
            this.nudlado2.ForeColor = System.Drawing.Color.Red;
            this.nudlado2.Location = new System.Drawing.Point(80, 128);
            this.nudlado2.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudlado2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudlado2.Name = "nudlado2";
            this.nudlado2.Size = new System.Drawing.Size(96, 27);
            this.nudlado2.TabIndex = 6;
            this.nudlado2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudlado2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudlado2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // nudlado3
            // 
            this.nudlado3.BackColor = System.Drawing.SystemColors.ControlText;
            this.nudlado3.ForeColor = System.Drawing.Color.Red;
            this.nudlado3.Location = new System.Drawing.Point(80, 160);
            this.nudlado3.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudlado3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudlado3.Name = "nudlado3";
            this.nudlado3.Size = new System.Drawing.Size(96, 27);
            this.nudlado3.TabIndex = 7;
            this.nudlado3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudlado3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudlado3.ValueChanged += new System.EventHandler(this.nud3_ValueChanged);
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnVerificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerificar.ForeColor = System.Drawing.Color.Red;
            this.btnVerificar.Location = new System.Drawing.Point(232, 176);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(144, 56);
            this.btnVerificar.TabIndex = 8;
            this.btnVerificar.Text = "verificar";
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(496, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "tipo de triangulo";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(480, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 24);
            this.label7.TabIndex = 2;
            this.label7.Text = "???";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmTriangulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(677, 350);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pnlDados);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmTriangulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Descubra o tipo do Triangulo";
            this.Load += new System.EventHandler(this.FrmTriangulos_Load);
            this.pnlDados.ResumeLayout(false);
            this.pnlDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudlado1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudlado2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudlado3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudlado2;
        private System.Windows.Forms.NumericUpDown nudlado1;
        private System.Windows.Forms.NumericUpDown nudlado3;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

