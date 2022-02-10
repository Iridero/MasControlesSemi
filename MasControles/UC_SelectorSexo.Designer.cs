
namespace MasControles
{
    partial class UC_SelectorSexo
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
            this.btnSexo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSexo
            // 
            this.btnSexo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSexo.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSexo.Location = new System.Drawing.Point(5, 5);
            this.btnSexo.Margin = new System.Windows.Forms.Padding(0);
            this.btnSexo.Name = "btnSexo";
            this.btnSexo.Size = new System.Drawing.Size(54, 52);
            this.btnSexo.TabIndex = 0;
            this.btnSexo.Text = "♂";
            this.btnSexo.UseVisualStyleBackColor = true;
            this.btnSexo.Click += new System.EventHandler(this.btnSexo_Click);
            // 
            // UC_SelectorSexo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSexo);
            this.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Name = "UC_SelectorSexo";
            this.Size = new System.Drawing.Size(64, 62);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSexo;
    }
}
