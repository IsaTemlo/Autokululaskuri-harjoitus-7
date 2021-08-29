
namespace Autokululaskuri
{
    partial class Form1
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LainaTB = new System.Windows.Forms.TextBox();
            this.NesteetTB = new System.Windows.Forms.TextBox();
            this.VakuutuksetTB = new System.Windows.Forms.TextBox();
            this.MuutTB = new System.Windows.Forms.TextBox();
            this.PolttonesteetTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.HuollotTB = new System.Windows.Forms.TextBox();
            this.RenkaatTB = new System.Windows.Forms.TextBox();
            this.PesutTB = new System.Windows.Forms.TextBox();
            this.KilometriCB = new System.Windows.Forms.ComboBox();
            this.VastausLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lainan lyhenne korkoineen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lisättävät nesteet yms:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vakuutusmaksut:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Muut kulut:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Polttoneste:";
            // 
            // LainaTB
            // 
            this.LainaTB.Location = new System.Drawing.Point(367, 19);
            this.LainaTB.Name = "LainaTB";
            this.LainaTB.Size = new System.Drawing.Size(100, 35);
            this.LainaTB.TabIndex = 5;
            this.LainaTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // NesteetTB
            // 
            this.NesteetTB.Location = new System.Drawing.Point(367, 87);
            this.NesteetTB.Name = "NesteetTB";
            this.NesteetTB.Size = new System.Drawing.Size(100, 35);
            this.NesteetTB.TabIndex = 6;
            // 
            // VakuutuksetTB
            // 
            this.VakuutuksetTB.Location = new System.Drawing.Point(367, 157);
            this.VakuutuksetTB.Name = "VakuutuksetTB";
            this.VakuutuksetTB.Size = new System.Drawing.Size(100, 35);
            this.VakuutuksetTB.TabIndex = 7;
            // 
            // MuutTB
            // 
            this.MuutTB.Location = new System.Drawing.Point(367, 228);
            this.MuutTB.Name = "MuutTB";
            this.MuutTB.Size = new System.Drawing.Size(100, 35);
            this.MuutTB.TabIndex = 8;
            // 
            // PolttonesteetTB
            // 
            this.PolttonesteetTB.Location = new System.Drawing.Point(367, 298);
            this.PolttonesteetTB.Name = "PolttonesteetTB";
            this.PolttonesteetTB.Size = new System.Drawing.Size(100, 35);
            this.PolttonesteetTB.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(541, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "Pesut:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(541, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 29);
            this.label7.TabIndex = 11;
            this.label7.Text = "Huollot:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(541, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 29);
            this.label8.TabIndex = 12;
            this.label8.Text = "Renkaat:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(541, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(194, 29);
            this.label9.TabIndex = 13;
            this.label9.Text = "Kilometrit / Vuosi";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // HuollotTB
            // 
            this.HuollotTB.Location = new System.Drawing.Point(741, 90);
            this.HuollotTB.Name = "HuollotTB";
            this.HuollotTB.Size = new System.Drawing.Size(100, 35);
            this.HuollotTB.TabIndex = 14;
            // 
            // RenkaatTB
            // 
            this.RenkaatTB.Location = new System.Drawing.Point(741, 160);
            this.RenkaatTB.Name = "RenkaatTB";
            this.RenkaatTB.Size = new System.Drawing.Size(100, 35);
            this.RenkaatTB.TabIndex = 15;
            // 
            // PesutTB
            // 
            this.PesutTB.Location = new System.Drawing.Point(741, 22);
            this.PesutTB.Name = "PesutTB";
            this.PesutTB.Size = new System.Drawing.Size(100, 35);
            this.PesutTB.TabIndex = 16;
            // 
            // KilometriCB
            // 
            this.KilometriCB.FormattingEnabled = true;
            this.KilometriCB.Location = new System.Drawing.Point(741, 301);
            this.KilometriCB.Name = "KilometriCB";
            this.KilometriCB.Size = new System.Drawing.Size(121, 37);
            this.KilometriCB.TabIndex = 17;
            this.KilometriCB.SelectedIndexChanged += new System.EventHandler(this.KilometriCB_SelectedIndexChanged);
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Location = new System.Drawing.Point(17, 407);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(376, 29);
            this.VastausLB.TabIndex = 18;
            this.VastausLB.Text = "kustannukset kilometriä kohti ovat:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 560);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.KilometriCB);
            this.Controls.Add(this.PesutTB);
            this.Controls.Add(this.RenkaatTB);
            this.Controls.Add(this.HuollotTB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PolttonesteetTB);
            this.Controls.Add(this.MuutTB);
            this.Controls.Add(this.VakuutuksetTB);
            this.Controls.Add(this.NesteetTB);
            this.Controls.Add(this.LainaTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "Form1";
            this.Text = "KilometriCB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LainaTB;
        private System.Windows.Forms.TextBox NesteetTB;
        private System.Windows.Forms.TextBox VakuutuksetTB;
        private System.Windows.Forms.TextBox MuutTB;
        private System.Windows.Forms.TextBox PolttonesteetTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox HuollotTB;
        private System.Windows.Forms.TextBox RenkaatTB;
        private System.Windows.Forms.TextBox PesutTB;
        private System.Windows.Forms.ComboBox KilometriCB;
        private System.Windows.Forms.Label VastausLB;
    }
}

