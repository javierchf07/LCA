namespace GUIComun
{
    partial class ucProceso
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.paSuperior = new DevExpress.XtraEditors.PanelControl();
            this.paCentral = new DevExpress.XtraEditors.PanelControl();
            this.paInferior = new DevExpress.XtraEditors.PanelControl();
            this.sbuCerrar = new DevExpress.XtraEditors.SimpleButton();
            this.sbuEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.sbuCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.sbuGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.datos = new System.Data.DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.paSuperior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paCentral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paInferior)).BeginInit();
            this.paInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datos)).BeginInit();
            this.SuspendLayout();
            // 
            // paSuperior
            // 
            this.paSuperior.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.paSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.paSuperior.Location = new System.Drawing.Point(0, 0);
            this.paSuperior.Name = "paSuperior";
            this.paSuperior.Size = new System.Drawing.Size(714, 80);
            this.paSuperior.TabIndex = 0;
            // 
            // paCentral
            // 
            this.paCentral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paCentral.Appearance.BackColor = System.Drawing.Color.White;
            this.paCentral.Appearance.Options.UseBackColor = true;
            this.paCentral.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.paCentral.Enabled = false;
            this.paCentral.Location = new System.Drawing.Point(0, 80);
            this.paCentral.Name = "paCentral";
            this.paCentral.Size = new System.Drawing.Size(714, 285);
            this.paCentral.TabIndex = 1;
            // 
            // paInferior
            // 
            this.paInferior.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paInferior.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.paInferior.Controls.Add(this.sbuCerrar);
            this.paInferior.Controls.Add(this.sbuEliminar);
            this.paInferior.Controls.Add(this.sbuCancelar);
            this.paInferior.Controls.Add(this.sbuGuardar);
            this.paInferior.Location = new System.Drawing.Point(0, 365);
            this.paInferior.Name = "paInferior";
            this.paInferior.Size = new System.Drawing.Size(714, 68);
            this.paInferior.TabIndex = 2;
            // 
            // sbuCerrar
            // 
            this.sbuCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbuCerrar.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.sbuCerrar.Appearance.Options.UseFont = true;
            this.sbuCerrar.Location = new System.Drawing.Point(585, 16);
            this.sbuCerrar.Name = "sbuCerrar";
            this.sbuCerrar.Size = new System.Drawing.Size(101, 36);
            this.sbuCerrar.TabIndex = 3;
            this.sbuCerrar.Text = "Cerrar";
            this.sbuCerrar.Click += new System.EventHandler(this.sbuCerrar_Click);
            // 
            // sbuEliminar
            // 
            this.sbuEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbuEliminar.Location = new System.Drawing.Point(461, 16);
            this.sbuEliminar.Name = "sbuEliminar";
            this.sbuEliminar.Size = new System.Drawing.Size(105, 36);
            this.sbuEliminar.TabIndex = 2;
            this.sbuEliminar.Text = "Eliminar";
            this.sbuEliminar.Click += new System.EventHandler(this.sbuEliminar_Click);
            // 
            // sbuCancelar
            // 
            this.sbuCancelar.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.sbuCancelar.Appearance.Options.UseFont = true;
            this.sbuCancelar.Location = new System.Drawing.Point(139, 16);
            this.sbuCancelar.Name = "sbuCancelar";
            this.sbuCancelar.Size = new System.Drawing.Size(113, 36);
            this.sbuCancelar.TabIndex = 1;
            this.sbuCancelar.Text = "Cancelar";
            this.sbuCancelar.Click += new System.EventHandler(this.sbuCancelar_Click);
            // 
            // sbuGuardar
            // 
            this.sbuGuardar.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.sbuGuardar.Appearance.Options.UseFont = true;
            this.sbuGuardar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.BottomLeft;
            this.sbuGuardar.Location = new System.Drawing.Point(14, 16);
            this.sbuGuardar.Name = "sbuGuardar";
            this.sbuGuardar.Size = new System.Drawing.Size(104, 36);
            this.sbuGuardar.TabIndex = 0;
            this.sbuGuardar.Text = "Guardar";
            this.sbuGuardar.Click += new System.EventHandler(this.sbuGuardar_Click);
            // 
            // datos
            // 
            this.datos.DataSetName = "NewDataSet";
            // 
            // ucProceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.paInferior);
            this.Controls.Add(this.paCentral);
            this.Controls.Add(this.paSuperior);
            this.Name = "ucProceso";
            this.Size = new System.Drawing.Size(714, 433);
            ((System.ComponentModel.ISupportInitialize)(this.paSuperior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paCentral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paInferior)).EndInit();
            this.paInferior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl paInferior;
        private DevExpress.XtraEditors.SimpleButton sbuCerrar;
        private DevExpress.XtraEditors.SimpleButton sbuEliminar;
        private DevExpress.XtraEditors.SimpleButton sbuCancelar;
        private DevExpress.XtraEditors.SimpleButton sbuGuardar;
        protected DevExpress.XtraEditors.PanelControl paSuperior;
        protected DevExpress.XtraEditors.PanelControl paCentral;
        protected System.Data.DataSet datos;
    }
}
