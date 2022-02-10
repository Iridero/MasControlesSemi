
namespace MasControles
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
            this.uC_SelectorSexo1 = new MasControles.UC_SelectorSexo();
            this.uC_Switch1 = new MasControles.UC_Switch();
            this.SuspendLayout();
            // 
            // uC_SelectorSexo1
            // 
            this.uC_SelectorSexo1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.uC_SelectorSexo1.Location = new System.Drawing.Point(30, 37);
            this.uC_SelectorSexo1.Name = "uC_SelectorSexo1";
            this.uC_SelectorSexo1.Sexo = MasControles.Sexos.Masculino;
            this.uC_SelectorSexo1.Size = new System.Drawing.Size(80, 78);
            this.uC_SelectorSexo1.TabIndex = 0;
            this.uC_SelectorSexo1.SexoActualizado += new System.EventHandler<MasControles.SelectorSexoEventArgs>(this.uC_SelectorSexo1_SexoActualizado);
            // 
            // uC_Switch1
            // 
            this.uC_Switch1.Encendido = false;
            this.uC_Switch1.Location = new System.Drawing.Point(223, 65);
            this.uC_Switch1.Name = "uC_Switch1";
            this.uC_Switch1.Size = new System.Drawing.Size(312, 50);
            this.uC_Switch1.TabIndex = 1;
            this.uC_Switch1.Texto = "Estas de acuerdo?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uC_Switch1);
            this.Controls.Add(this.uC_SelectorSexo1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private UC_SelectorSexo uC_SelectorSexo1;
        private UC_Switch uC_Switch1;
    }
}

