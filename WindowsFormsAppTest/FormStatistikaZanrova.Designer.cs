namespace WindowsFormsAppTest
{
    partial class FormStatistikaZanrova
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstStats = new System.Windows.Forms.ListBox();
            this.btnZatvori2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(22, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Statistika zanrova";
            // 
            // lstStats
            // 
            this.lstStats.FormattingEnabled = true;
            this.lstStats.Location = new System.Drawing.Point(27, 88);
            this.lstStats.Name = "lstStats";
            this.lstStats.Size = new System.Drawing.Size(278, 212);
            this.lstStats.TabIndex = 1;
            // 
            // btnZatvori2
            // 
            this.btnZatvori2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZatvori2.Location = new System.Drawing.Point(27, 320);
            this.btnZatvori2.Name = "btnZatvori2";
            this.btnZatvori2.Size = new System.Drawing.Size(64, 28);
            this.btnZatvori2.TabIndex = 2;
            this.btnZatvori2.Text = "Zatvori";
            this.btnZatvori2.UseVisualStyleBackColor = true;
            // 
            // FormStatistikaZanrova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnZatvori2);
            this.Controls.Add(this.lstStats);
            this.Controls.Add(this.label1);
            this.Name = "FormStatistikaZanrova";
            this.Text = "FormStatistikaZanrova";
            this.Load += new System.EventHandler(this.FormStatistikaZanrova_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstStats;
        private System.Windows.Forms.Button btnZatvori2;
    }
}