﻿
namespace Calculator
{
    partial class Kalkulator
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OperasiPilihan = new System.Windows.Forms.ComboBox();
            this.NilaiA = new System.Windows.Forms.TextBox();
            this.NilaiB = new System.Windows.Forms.TextBox();
            this.ProsesNilai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operasi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nilai A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nilai B";
            // 
            // OperasiPilihan
            // 
            this.OperasiPilihan.FormattingEnabled = true;
            this.OperasiPilihan.Location = new System.Drawing.Point(73, 24);
            this.OperasiPilihan.Name = "OperasiPilihan";
            this.OperasiPilihan.Size = new System.Drawing.Size(121, 21);
            this.OperasiPilihan.TabIndex = 3;
            // 
            // NilaiA
            // 
            this.NilaiA.Location = new System.Drawing.Point(73, 71);
            this.NilaiA.Name = "NilaiA";
            this.NilaiA.Size = new System.Drawing.Size(121, 20);
            this.NilaiA.TabIndex = 4;
            // 
            // NilaiB
            // 
            this.NilaiB.Location = new System.Drawing.Point(73, 108);
            this.NilaiB.Name = "NilaiB";
            this.NilaiB.Size = new System.Drawing.Size(121, 20);
            this.NilaiB.TabIndex = 5;
            this.NilaiB.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ProsesNilai
            // 
            this.ProsesNilai.Location = new System.Drawing.Point(50, 150);
            this.ProsesNilai.Name = "ProsesNilai";
            this.ProsesNilai.Size = new System.Drawing.Size(121, 23);
            this.ProsesNilai.TabIndex = 6;
            this.ProsesNilai.Text = "Proses";
            this.ProsesNilai.UseVisualStyleBackColor = true;
            this.ProsesNilai.Click += new System.EventHandler(this.ProsesNilai_Click);
            // 
            // Kalkulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 185);
            this.Controls.Add(this.ProsesNilai);
            this.Controls.Add(this.NilaiB);
            this.Controls.Add(this.NilaiA);
            this.Controls.Add(this.OperasiPilihan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Kalkulator";
            this.Text = "Kalkulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox OperasiPilihan;
        private System.Windows.Forms.TextBox NilaiA;
        private System.Windows.Forms.TextBox NilaiB;
        private System.Windows.Forms.Button ProsesNilai;
    }
}