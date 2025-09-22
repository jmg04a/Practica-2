namespace Nomina
{
    partial class frmNomina
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
            this.components = new System.ComponentModel.Container();
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajustesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvInformacion = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegHRValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OTHrsValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DHrsValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ttsHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.ofdExcel = new System.Windows.Forms.OpenFileDialog();
            this.tmrReloj = new System.Windows.Forms.Timer(this.components);
            this.menuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformacion)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuPrincipal.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.operacionesToolStripMenuItem,
            this.ajustesToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(1214, 36);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(147, 34);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importarExcelToolStripMenuItem});
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(127, 29);
            this.operacionesToolStripMenuItem.Text = "Operaciones";
            // 
            // importarExcelToolStripMenuItem
            // 
            this.importarExcelToolStripMenuItem.Name = "importarExcelToolStripMenuItem";
            this.importarExcelToolStripMenuItem.Size = new System.Drawing.Size(227, 34);
            this.importarExcelToolStripMenuItem.Text = "Importar Excel";
            this.importarExcelToolStripMenuItem.Click += new System.EventHandler(this.importarExcelToolStripMenuItem_Click);
            // 
            // ajustesToolStripMenuItem
            // 
            this.ajustesToolStripMenuItem.Name = "ajustesToolStripMenuItem";
            this.ajustesToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
            this.ajustesToolStripMenuItem.Text = "Ajustes";
            this.ajustesToolStripMenuItem.Click += new System.EventHandler(this.ajustesToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 36);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvInformacion);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnCalcular);
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(1214, 530);
            this.splitContainer1.SplitterDistance = 384;
            this.splitContainer1.TabIndex = 1;
            // 
            // dgvInformacion
            // 
            this.dgvInformacion.AllowUserToAddRows = false;
            this.dgvInformacion.AllowUserToDeleteRows = false;
            this.dgvInformacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInformacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.RegHRValor,
            this.OTHrsValor,
            this.DHrsValor,
            this.ValorTotal});
            this.dgvInformacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInformacion.Location = new System.Drawing.Point(0, 0);
            this.dgvInformacion.Name = "dgvInformacion";
            this.dgvInformacion.ReadOnly = true;
            this.dgvInformacion.RowHeadersWidth = 62;
            this.dgvInformacion.RowTemplate.Height = 28;
            this.dgvInformacion.Size = new System.Drawing.Size(1214, 384);
            this.dgvInformacion.TabIndex = 2;
            this.dgvInformacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInformacion_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "No Empleado";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 110;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Apellido";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Reg HR";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 50;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "OT Hrs";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 50;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "D Hrs";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 50;
            // 
            // RegHRValor
            // 
            this.RegHRValor.HeaderText = "RegTotal";
            this.RegHRValor.MinimumWidth = 8;
            this.RegHRValor.Name = "RegHRValor";
            this.RegHRValor.ReadOnly = true;
            this.RegHRValor.Width = 50;
            // 
            // OTHrsValor
            // 
            this.OTHrsValor.HeaderText = "OTTotal";
            this.OTHrsValor.MinimumWidth = 8;
            this.OTHrsValor.Name = "OTHrsValor";
            this.OTHrsValor.ReadOnly = true;
            this.OTHrsValor.Width = 50;
            // 
            // DHrsValor
            // 
            this.DHrsValor.HeaderText = "DTotal";
            this.DHrsValor.MinimumWidth = 8;
            this.DHrsValor.Name = "DHrsValor";
            this.DHrsValor.ReadOnly = true;
            this.DHrsValor.Width = 50;
            // 
            // ValorTotal
            // 
            this.ValorTotal.HeaderText = "Total";
            this.ValorTotal.MinimumWidth = 8;
            this.ValorTotal.Name = "ValorTotal";
            this.ValorTotal.ReadOnly = true;
            this.ValorTotal.Width = 70;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(819, 25);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(141, 69);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular tablas";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ttsHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 120);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1214, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ttsHora
            // 
            this.ttsHora.Name = "ttsHora";
            this.ttsHora.Size = new System.Drawing.Size(0, 15);
            // 
            // ofdExcel
            // 
            this.ofdExcel.Filter = "Archivo de Excel|*.xlsx";
            // 
            // tmrReloj
            // 
            this.tmrReloj.Enabled = true;
            this.tmrReloj.Interval = 1000;
            this.tmrReloj.Tick += new System.EventHandler(this.tmrReloj_Tick);
            // 
            // frmNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 566);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuPrincipal);
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "frmNomina";
            this.Text = "Procesamiento de Nomina";
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformacion)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarExcelToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvInformacion;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.OpenFileDialog ofdExcel;
        private System.Windows.Forms.ToolStripStatusLabel ttsHora;
        private System.Windows.Forms.Timer tmrReloj;
        private System.Windows.Forms.ToolStripMenuItem ajustesToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegHRValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn OTHrsValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn DHrsValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotal;
        private System.Windows.Forms.Button btnCalcular;
    }
}

