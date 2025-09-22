namespace Nomina
{
    partial class frmAjustes
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
            this.tbHorasRegulares = new System.Windows.Forms.TextBox();
            this.tbHorasExtra = new System.Windows.Forms.TextBox();
            this.tbHorasDobles = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAjustes = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbHorasRegulares
            // 
            this.tbHorasRegulares.Location = new System.Drawing.Point(84, 124);
            this.tbHorasRegulares.Name = "tbHorasRegulares";
            this.tbHorasRegulares.Size = new System.Drawing.Size(100, 26);
            this.tbHorasRegulares.TabIndex = 0;
            // 
            // tbHorasExtra
            // 
            this.tbHorasExtra.Location = new System.Drawing.Point(84, 196);
            this.tbHorasExtra.Name = "tbHorasExtra";
            this.tbHorasExtra.Size = new System.Drawing.Size(100, 26);
            this.tbHorasExtra.TabIndex = 1;
            // 
            // tbHorasDobles
            // 
            this.tbHorasDobles.Location = new System.Drawing.Point(84, 279);
            this.tbHorasDobles.Name = "tbHorasDobles";
            this.tbHorasDobles.Size = new System.Drawing.Size(100, 26);
            this.tbHorasDobles.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Valores";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Horas regulares";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Horas extra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Horas dobles";
            // 
            // btnAjustes
            // 
            this.btnAjustes.Location = new System.Drawing.Point(12, 350);
            this.btnAjustes.Name = "btnAjustes";
            this.btnAjustes.Size = new System.Drawing.Size(136, 58);
            this.btnAjustes.TabIndex = 7;
            this.btnAjustes.Text = "Guardar";
            this.btnAjustes.UseVisualStyleBackColor = true;
            this.btnAjustes.Click += new System.EventHandler(this.btnAjustes_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(154, 350);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(117, 58);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Cancelar";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmAjustes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 441);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAjustes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbHorasDobles);
            this.Controls.Add(this.tbHorasExtra);
            this.Controls.Add(this.tbHorasRegulares);
            this.Name = "frmAjustes";
            this.Text = "Ajustes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbHorasRegulares;
        private System.Windows.Forms.TextBox tbHorasExtra;
        private System.Windows.Forms.TextBox tbHorasDobles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAjustes;
        private System.Windows.Forms.Button btnSalir;
    }
}