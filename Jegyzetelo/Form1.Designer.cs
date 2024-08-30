namespace Jegyzetelo
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
            this.BT_Keres = new System.Windows.Forms.Button();
            this.LB_Lista = new System.Windows.Forms.ListBox();
            this.TB_Keres = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.TB_Hozza = new System.Windows.Forms.TextBox();
            this.RTB_Szoveg = new System.Windows.Forms.RichTextBox();
            this.LB_Szoveg = new System.Windows.Forms.Label();
            this.LB_Cim = new System.Windows.Forms.Label();
            this.BT_Szerkezzt = new System.Windows.Forms.Button();
            this.BT_Mentes = new System.Windows.Forms.Button();
            this.BT_torles = new System.Windows.Forms.Button();
            this.BT_Betolt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BT_Keres
            // 
            this.BT_Keres.BackColor = System.Drawing.Color.Lime;
            this.BT_Keres.ForeColor = System.Drawing.Color.Black;
            this.BT_Keres.Location = new System.Drawing.Point(121, 67);
            this.BT_Keres.Name = "BT_Keres";
            this.BT_Keres.Size = new System.Drawing.Size(130, 23);
            this.BT_Keres.TabIndex = 0;
            this.BT_Keres.Text = "Keresés";
            this.BT_Keres.UseVisualStyleBackColor = false;
            this.BT_Keres.Click += new System.EventHandler(this.BT_Keres_Click);
            // 
            // LB_Lista
            // 
            this.LB_Lista.BackColor = System.Drawing.Color.Gray;
            this.LB_Lista.FormattingEnabled = true;
            this.LB_Lista.ItemHeight = 16;
            this.LB_Lista.Location = new System.Drawing.Point(39, 192);
            this.LB_Lista.Name = "LB_Lista";
            this.LB_Lista.Size = new System.Drawing.Size(292, 324);
            this.LB_Lista.TabIndex = 1;
            // 
            // TB_Keres
            // 
            this.TB_Keres.BackColor = System.Drawing.Color.Gray;
            this.TB_Keres.Location = new System.Drawing.Point(39, 22);
            this.TB_Keres.Name = "TB_Keres";
            this.TB_Keres.Size = new System.Drawing.Size(292, 22);
            this.TB_Keres.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.Location = new System.Drawing.Point(530, 550);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Hozzáad";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TB_Hozza
            // 
            this.TB_Hozza.BackColor = System.Drawing.Color.Gray;
            this.TB_Hozza.Location = new System.Drawing.Point(455, 68);
            this.TB_Hozza.Name = "TB_Hozza";
            this.TB_Hozza.Size = new System.Drawing.Size(292, 22);
            this.TB_Hozza.TabIndex = 4;
            // 
            // RTB_Szoveg
            // 
            this.RTB_Szoveg.BackColor = System.Drawing.Color.Gray;
            this.RTB_Szoveg.Location = new System.Drawing.Point(455, 192);
            this.RTB_Szoveg.Name = "RTB_Szoveg";
            this.RTB_Szoveg.Size = new System.Drawing.Size(292, 324);
            this.RTB_Szoveg.TabIndex = 6;
            this.RTB_Szoveg.Text = "";
            // 
            // LB_Szoveg
            // 
            this.LB_Szoveg.AutoSize = true;
            this.LB_Szoveg.BackColor = System.Drawing.Color.IndianRed;
            this.LB_Szoveg.ForeColor = System.Drawing.Color.White;
            this.LB_Szoveg.Location = new System.Drawing.Point(452, 149);
            this.LB_Szoveg.Name = "LB_Szoveg";
            this.LB_Szoveg.Size = new System.Drawing.Size(53, 16);
            this.LB_Szoveg.TabIndex = 7;
            this.LB_Szoveg.Text = "Szöveg";
            // 
            // LB_Cim
            // 
            this.LB_Cim.AutoSize = true;
            this.LB_Cim.BackColor = System.Drawing.Color.IndianRed;
            this.LB_Cim.ForeColor = System.Drawing.Color.White;
            this.LB_Cim.Location = new System.Drawing.Point(452, 25);
            this.LB_Cim.Name = "LB_Cim";
            this.LB_Cim.Size = new System.Drawing.Size(48, 16);
            this.LB_Cim.TabIndex = 8;
            this.LB_Cim.Text = "Címke:";
            // 
            // BT_Szerkezzt
            // 
            this.BT_Szerkezzt.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BT_Szerkezzt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BT_Szerkezzt.ForeColor = System.Drawing.Color.Black;
            this.BT_Szerkezzt.Location = new System.Drawing.Point(121, 107);
            this.BT_Szerkezzt.Name = "BT_Szerkezzt";
            this.BT_Szerkezzt.Size = new System.Drawing.Size(130, 23);
            this.BT_Szerkezzt.TabIndex = 9;
            this.BT_Szerkezzt.Text = "Szerkesztés";
            this.BT_Szerkezzt.UseVisualStyleBackColor = false;
            this.BT_Szerkezzt.Click += new System.EventHandler(this.BT_Szerkezzt_Click);
            // 
            // BT_Mentes
            // 
            this.BT_Mentes.BackColor = System.Drawing.Color.Indigo;
            this.BT_Mentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BT_Mentes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BT_Mentes.Location = new System.Drawing.Point(121, 550);
            this.BT_Mentes.Name = "BT_Mentes";
            this.BT_Mentes.Size = new System.Drawing.Size(130, 23);
            this.BT_Mentes.TabIndex = 10;
            this.BT_Mentes.Text = "Mentés";
            this.BT_Mentes.UseVisualStyleBackColor = false;
            this.BT_Mentes.Click += new System.EventHandler(this.BT_Mentes_Click);
            // 
            // BT_torles
            // 
            this.BT_torles.BackColor = System.Drawing.Color.DeepPink;
            this.BT_torles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BT_torles.ForeColor = System.Drawing.Color.White;
            this.BT_torles.Location = new System.Drawing.Point(121, 149);
            this.BT_torles.Name = "BT_torles";
            this.BT_torles.Size = new System.Drawing.Size(130, 23);
            this.BT_torles.TabIndex = 11;
            this.BT_torles.Text = "Törlés";
            this.BT_torles.UseVisualStyleBackColor = false;
            this.BT_torles.Click += new System.EventHandler(this.BT_torles_Click);
            // 
            // BT_Betolt
            // 
            this.BT_Betolt.BackColor = System.Drawing.Color.Yellow;
            this.BT_Betolt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BT_Betolt.ForeColor = System.Drawing.Color.Black;
            this.BT_Betolt.Location = new System.Drawing.Point(121, 589);
            this.BT_Betolt.Name = "BT_Betolt";
            this.BT_Betolt.Size = new System.Drawing.Size(130, 23);
            this.BT_Betolt.TabIndex = 12;
            this.BT_Betolt.Text = "Betöltés";
            this.BT_Betolt.UseVisualStyleBackColor = false;
            this.BT_Betolt.Click += new System.EventHandler(this.BT_Betolt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(795, 638);
            this.Controls.Add(this.BT_Betolt);
            this.Controls.Add(this.BT_torles);
            this.Controls.Add(this.BT_Mentes);
            this.Controls.Add(this.BT_Szerkezzt);
            this.Controls.Add(this.LB_Cim);
            this.Controls.Add(this.LB_Szoveg);
            this.Controls.Add(this.RTB_Szoveg);
            this.Controls.Add(this.TB_Hozza);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TB_Keres);
            this.Controls.Add(this.LB_Lista);
            this.Controls.Add(this.BT_Keres);
            this.Name = "Form1";
            this.Text = "Jegyzet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_Keres;
        private System.Windows.Forms.ListBox LB_Lista;
        private System.Windows.Forms.TextBox TB_Keres;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TB_Hozza;
        private System.Windows.Forms.RichTextBox RTB_Szoveg;
        private System.Windows.Forms.Label LB_Szoveg;
        private System.Windows.Forms.Label LB_Cim;
        private System.Windows.Forms.Button BT_Szerkezzt;
        private System.Windows.Forms.Button BT_Mentes;
        private System.Windows.Forms.Button BT_torles;
        private System.Windows.Forms.Button BT_Betolt;
    }
}

