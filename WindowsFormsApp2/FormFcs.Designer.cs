namespace WindowsFormsApp2
{
    partial class FormFcs
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
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnImprimir2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(249, 61);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(243, 59);
            this.btnImprimir.TabIndex = 0;
            this.btnImprimir.Text = "IMPRIMIR";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnImprimir2
            // 
            this.btnImprimir2.Location = new System.Drawing.Point(249, 186);
            this.btnImprimir2.Name = "btnImprimir2";
            this.btnImprimir2.Size = new System.Drawing.Size(243, 59);
            this.btnImprimir2.TabIndex = 1;
            this.btnImprimir2.Text = "IMPRIMIR2";
            this.btnImprimir2.UseVisualStyleBackColor = true;
            this.btnImprimir2.Click += new System.EventHandler(this.btnImprimir2_Click);
            // 
            // FormFcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnImprimir2);
            this.Controls.Add(this.btnImprimir);
            this.Name = "FormFcs";
            this.Text = "FormFcs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnImprimir2;
    }
}