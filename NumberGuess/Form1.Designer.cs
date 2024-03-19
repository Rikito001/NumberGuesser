
namespace NumberGuess
{
    partial class NumberGuesser
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
            this.Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MinCislo = new System.Windows.Forms.TextBox();
            this.MaxCislo = new System.Windows.Forms.TextBox();
            this.SpustHru = new System.Windows.Forms.Button();
            this.pokusHadat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TajneRiesenie = new System.Windows.Forms.Label();
            this.vysledok = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.PocetPokusov = new System.Windows.Forms.Label();
            this.Vstup1 = new System.Windows.Forms.NumericUpDown();
            this.Vstup2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Vstup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vstup2)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Exit.Location = new System.Drawing.Point(856, 938);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(221, 68);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "EXIT";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(42, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zadaj minimálne číslo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(700, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(343, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Zadaj maximálne číslo:";
            // 
            // MinCislo
            // 
            this.MinCislo.Enabled = false;
            this.MinCislo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MinCislo.Location = new System.Drawing.Point(49, 180);
            this.MinCislo.Name = "MinCislo";
            this.MinCislo.Size = new System.Drawing.Size(328, 44);
            this.MinCislo.TabIndex = 3;
            this.MinCislo.Visible = false;
            this.MinCislo.TextChanged += new System.EventHandler(this.MinCislo_TextChanged);
            // 
            // MaxCislo
            // 
            this.MaxCislo.Enabled = false;
            this.MaxCislo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MaxCislo.Location = new System.Drawing.Point(707, 180);
            this.MaxCislo.Name = "MaxCislo";
            this.MaxCislo.Size = new System.Drawing.Size(336, 44);
            this.MaxCislo.TabIndex = 4;
            this.MaxCislo.Visible = false;
            this.MaxCislo.TextChanged += new System.EventHandler(this.MaxCislo_TextChanged);
            // 
            // SpustHru
            // 
            this.SpustHru.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SpustHru.Location = new System.Drawing.Point(448, 264);
            this.SpustHru.Name = "SpustHru";
            this.SpustHru.Size = new System.Drawing.Size(181, 105);
            this.SpustHru.TabIndex = 5;
            this.SpustHru.Text = "Vygeneruj číslo";
            this.SpustHru.UseVisualStyleBackColor = true;
            this.SpustHru.Click += new System.EventHandler(this.SpustHru_Click);
            // 
            // pokusHadat
            // 
            this.pokusHadat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pokusHadat.Location = new System.Drawing.Point(395, 565);
            this.pokusHadat.Name = "pokusHadat";
            this.pokusHadat.Size = new System.Drawing.Size(274, 44);
            this.pokusHadat.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(362, 495);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(345, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "Uhádni číslo od 0 po 0:";
            // 
            // TajneRiesenie
            // 
            this.TajneRiesenie.AutoSize = true;
            this.TajneRiesenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TajneRiesenie.Location = new System.Drawing.Point(12, 960);
            this.TajneRiesenie.Name = "TajneRiesenie";
            this.TajneRiesenie.Size = new System.Drawing.Size(209, 37);
            this.TajneRiesenie.TabIndex = 8;
            this.TajneRiesenie.Text = "Ukáž riešenie";
            this.TajneRiesenie.Click += new System.EventHandler(this.TajneRiesenie_Click);
            // 
            // vysledok
            // 
            this.vysledok.AutoSize = true;
            this.vysledok.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vysledok.Location = new System.Drawing.Point(364, 703);
            this.vysledok.Name = "vysledok";
            this.vysledok.Size = new System.Drawing.Size(0, 37);
            this.vysledok.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(395, 644);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(274, 58);
            this.button1.TabIndex = 10;
            this.button1.Text = "Skús šťastie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PocetPokusov
            // 
            this.PocetPokusov.AutoSize = true;
            this.PocetPokusov.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PocetPokusov.Location = new System.Drawing.Point(12, 495);
            this.PocetPokusov.Name = "PocetPokusov";
            this.PocetPokusov.Size = new System.Drawing.Size(235, 37);
            this.PocetPokusov.TabIndex = 11;
            this.PocetPokusov.Text = "Počet pokusov:";
            // 
            // Vstup1
            // 
            this.Vstup1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Vstup1.Location = new System.Drawing.Point(49, 288);
            this.Vstup1.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.Vstup1.Name = "Vstup1";
            this.Vstup1.Size = new System.Drawing.Size(328, 44);
            this.Vstup1.TabIndex = 12;
            // 
            // Vstup2
            // 
            this.Vstup2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Vstup2.Location = new System.Drawing.Point(707, 288);
            this.Vstup2.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.Vstup2.Name = "Vstup2";
            this.Vstup2.Size = new System.Drawing.Size(336, 44);
            this.Vstup2.TabIndex = 13;
            // 
            // NumberGuesser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1089, 1027);
            this.Controls.Add(this.Vstup2);
            this.Controls.Add(this.Vstup1);
            this.Controls.Add(this.PocetPokusov);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.vysledok);
            this.Controls.Add(this.TajneRiesenie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pokusHadat);
            this.Controls.Add(this.SpustHru);
            this.Controls.Add(this.MaxCislo);
            this.Controls.Add(this.MinCislo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "NumberGuesser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Number Guesser";
            ((System.ComponentModel.ISupportInitialize)(this.Vstup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vstup2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MinCislo;
        private System.Windows.Forms.TextBox MaxCislo;
        private System.Windows.Forms.Button SpustHru;
        private System.Windows.Forms.TextBox pokusHadat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TajneRiesenie;
        private System.Windows.Forms.Label vysledok;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label PocetPokusov;
        private System.Windows.Forms.NumericUpDown Vstup1;
        private System.Windows.Forms.NumericUpDown Vstup2;
    }
}

