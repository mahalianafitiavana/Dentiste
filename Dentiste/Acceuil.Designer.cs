namespace Dentiste
{
    partial class Acceuil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.navbar = new System.Windows.Forms.Panel();
            this.p = new System.Windows.Forms.Panel();
            this.quit = new System.Windows.Forms.Button();
            this.care = new System.Windows.Forms.Button();
            this.visit = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.reduire = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reduice = new System.Windows.Forms.Button();
            this.navbar.SuspendLayout();
            this.reduire.SuspendLayout();
            this.SuspendLayout();
            // 
            // navbar
            // 
            this.navbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(64)))));
            this.navbar.Controls.Add(this.p);
            this.navbar.Controls.Add(this.quit);
            this.navbar.Controls.Add(this.care);
            this.navbar.Controls.Add(this.visit);
            this.navbar.Controls.Add(this.home);
            this.navbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.navbar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(64)))));
            this.navbar.Location = new System.Drawing.Point(0, 0);
            this.navbar.Name = "navbar";
            this.navbar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.navbar.Size = new System.Drawing.Size(266, 567);
            this.navbar.TabIndex = 0;
            // 
            // p
            // 
            this.p.BackColor = System.Drawing.Color.White;
            this.p.ForeColor = System.Drawing.Color.White;
            this.p.Location = new System.Drawing.Point(1, 149);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(10, 52);
            this.p.TabIndex = 4;
            this.p.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // quit
            // 
            this.quit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(64)))));
            this.quit.FlatAppearance.BorderSize = 0;
            this.quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.quit.Location = new System.Drawing.Point(12, 392);
            this.quit.Name = "quit";
            this.quit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.quit.Size = new System.Drawing.Size(251, 52);
            this.quit.TabIndex = 3;
            this.quit.Text = "Quit";
            this.quit.UseVisualStyleBackColor = false;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // care
            // 
            this.care.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(64)))));
            this.care.FlatAppearance.BorderSize = 0;
            this.care.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.care.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.care.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.care.Location = new System.Drawing.Point(12, 313);
            this.care.Name = "care";
            this.care.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.care.Size = new System.Drawing.Size(251, 52);
            this.care.TabIndex = 2;
            this.care.Text = "Care";
            this.care.UseVisualStyleBackColor = false;
            this.care.Click += new System.EventHandler(this.care_Click);
            // 
            // visit
            // 
            this.visit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(64)))));
            this.visit.FlatAppearance.BorderSize = 0;
            this.visit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.visit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.visit.Location = new System.Drawing.Point(12, 232);
            this.visit.Name = "visit";
            this.visit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.visit.Size = new System.Drawing.Size(251, 52);
            this.visit.TabIndex = 1;
            this.visit.Text = "Visit";
            this.visit.UseVisualStyleBackColor = false;
            this.visit.Click += new System.EventHandler(this.visit_Click);
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(64)))));
            this.home.FlatAppearance.BorderSize = 0;
            this.home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.home.Location = new System.Drawing.Point(12, 149);
            this.home.Name = "home";
            this.home.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.home.Size = new System.Drawing.Size(251, 52);
            this.home.TabIndex = 0;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // reduire
            // 
            this.reduire.Controls.Add(this.panel1);
            this.reduire.Controls.Add(this.reduice);
            this.reduire.Dock = System.Windows.Forms.DockStyle.Top;
            this.reduire.Location = new System.Drawing.Point(266, 0);
            this.reduire.Name = "reduire";
            this.reduire.Size = new System.Drawing.Size(550, 37);
            this.reduire.TabIndex = 1;
            this.reduire.Paint += new System.Windows.Forms.PaintEventHandler(this.reduire_Paint);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 1;
            // 
            // reduice
            // 
            this.reduice.Dock = System.Windows.Forms.DockStyle.Right;
            this.reduice.FlatAppearance.BorderSize = 0;
            this.reduice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reduice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reduice.Location = new System.Drawing.Point(492, 0);
            this.reduice.Name = "reduice";
            this.reduice.Size = new System.Drawing.Size(58, 37);
            this.reduice.TabIndex = 0;
            this.reduice.Text = "-";
            this.reduice.UseVisualStyleBackColor = true;
            this.reduice.Click += new System.EventHandler(this.button2_Click);
            // 
            // Acceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(816, 567);
            this.Controls.Add(this.reduire);
            this.Controls.Add(this.navbar);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Acceuil";
            this.Text = "-";
            this.Load += new System.EventHandler(this.Acceuil_Load);
            this.navbar.ResumeLayout(false);
            this.reduire.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navbar;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.Button care;
        private System.Windows.Forms.Button visit;
        private System.Windows.Forms.Panel reduire;
        private System.Windows.Forms.Button reduice;
        private System.Windows.Forms.Panel p;
        private System.Windows.Forms.Panel panel1;
    }
}

