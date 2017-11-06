namespace PrestaMe.Windows.Forms
{
    partial class formSplash
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
            this.labelVersion = new System.Windows.Forms.Label();
            this.radProgressBar1 = new Telerik.WinControls.UI.RadProgressBar();
            this.labelProgressMsg = new System.Windows.Forms.Label();
            this.labelCopyRight = new System.Windows.Forms.Label();
            this.labelSiglas = new System.Windows.Forms.Label();
            this.labelProducto = new System.Windows.Forms.Label();
            this.labelAlias = new System.Windows.Forms.Label();
            this.timerProgressBar = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radProgressBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(198, 71);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(46, 17);
            this.labelVersion.TabIndex = 1;
            this.labelVersion.Text = "label1";
            // 
            // radProgressBar1
            // 
            this.radProgressBar1.Location = new System.Drawing.Point(252, 230);
            this.radProgressBar1.Name = "radProgressBar1";
            this.radProgressBar1.Size = new System.Drawing.Size(162, 30);
            this.radProgressBar1.TabIndex = 2;
            this.radProgressBar1.Text = "radProgressBar1";
            // 
            // labelProgressMsg
            // 
            this.labelProgressMsg.AutoSize = true;
            this.labelProgressMsg.Location = new System.Drawing.Point(201, 103);
            this.labelProgressMsg.Name = "labelProgressMsg";
            this.labelProgressMsg.Size = new System.Drawing.Size(46, 17);
            this.labelProgressMsg.TabIndex = 3;
            this.labelProgressMsg.Text = "label1";
            // 
            // labelCopyRight
            // 
            this.labelCopyRight.AutoSize = true;
            this.labelCopyRight.Location = new System.Drawing.Point(201, 136);
            this.labelCopyRight.Name = "labelCopyRight";
            this.labelCopyRight.Size = new System.Drawing.Size(46, 17);
            this.labelCopyRight.TabIndex = 4;
            this.labelCopyRight.Text = "label1";
            // 
            // labelSiglas
            // 
            this.labelSiglas.AutoSize = true;
            this.labelSiglas.Location = new System.Drawing.Point(204, 167);
            this.labelSiglas.Name = "labelSiglas";
            this.labelSiglas.Size = new System.Drawing.Size(46, 17);
            this.labelSiglas.TabIndex = 5;
            this.labelSiglas.Text = "label1";
            // 
            // labelProducto
            // 
            this.labelProducto.AutoSize = true;
            this.labelProducto.Location = new System.Drawing.Point(276, 70);
            this.labelProducto.Name = "labelProducto";
            this.labelProducto.Size = new System.Drawing.Size(46, 17);
            this.labelProducto.TabIndex = 6;
            this.labelProducto.Text = "label1";
            // 
            // labelAlias
            // 
            this.labelAlias.AutoSize = true;
            this.labelAlias.Location = new System.Drawing.Point(279, 103);
            this.labelAlias.Name = "labelAlias";
            this.labelAlias.Size = new System.Drawing.Size(46, 17);
            this.labelAlias.TabIndex = 7;
            this.labelAlias.Text = "label1";
            // 
            // formSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 322);
            this.Controls.Add(this.labelAlias);
            this.Controls.Add(this.labelProducto);
            this.Controls.Add(this.labelSiglas);
            this.Controls.Add(this.labelCopyRight);
            this.Controls.Add(this.labelProgressMsg);
            this.Controls.Add(this.radProgressBar1);
            this.Controls.Add(this.labelVersion);
            this.Name = "formSplash";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.radProgressBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelVersion;
        private Telerik.WinControls.UI.RadProgressBar radProgressBar1;
        private System.Windows.Forms.Label labelProgressMsg;
        private System.Windows.Forms.Label labelCopyRight;
        private System.Windows.Forms.Label labelSiglas;
        private System.Windows.Forms.Label labelProducto;
        private System.Windows.Forms.Label labelAlias;
        private System.Windows.Forms.Timer timerProgressBar;
    }
}

