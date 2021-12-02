
namespace Calculator
{
    partial class Hasil
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lvwHasilAkhir = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lvwHasilAkhir);
            this.groupBox1.Location = new System.Drawing.Point(-1, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 304);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasil";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(498, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Hitung";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lvwHasilAkhir
            // 
            this.lvwHasilAkhir.HideSelection = false;
            this.lvwHasilAkhir.Location = new System.Drawing.Point(13, 19);
            this.lvwHasilAkhir.Name = "lvwHasilAkhir";
            this.lvwHasilAkhir.Size = new System.Drawing.Size(498, 246);
            this.lvwHasilAkhir.TabIndex = 0;
            this.lvwHasilAkhir.UseCompatibleStateImageBehavior = false;
            this.lvwHasilAkhir.SelectedIndexChanged += new System.EventHandler(this.HasilAkhir_SelectedIndexChanged);
            // 
            // Hasil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 305);
            this.Controls.Add(this.groupBox1);
            this.Name = "Hasil";
            this.Text = "AlatHitung";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView lvwHasilAkhir;
    }
}

