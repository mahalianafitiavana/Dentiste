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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acceuil));
            this.navbar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.client = new System.Windows.Forms.Button();
            this.p = new System.Windows.Forms.Panel();
            this.quit = new System.Windows.Forms.Button();
            this.care = new System.Windows.Forms.Button();
            this.visit = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.reduire = new System.Windows.Forms.Panel();
            this.reduice = new System.Windows.Forms.Button();
            this.mobile = new System.Windows.Forms.Panel();
            this.birth = new System.Windows.Forms.DateTimePicker();
            this.oldclient = new System.Windows.Forms.Button();
            this.newclient = new System.Windows.Forms.Button();
            this.listclient = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.navbar.SuspendLayout();
            this.reduire.SuspendLayout();
            this.mobile.SuspendLayout();
            this.SuspendLayout();
            // 
            // navbar
            // 
            this.navbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(64)))));
            this.navbar.Controls.Add(this.panel1);
            this.navbar.Controls.Add(this.client);
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
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(58, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 120);
            this.panel1.TabIndex = 6;
            // 
            // client
            // 
            this.client.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(64)))));
            this.client.FlatAppearance.BorderSize = 0;
            this.client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.client.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.client.Location = new System.Drawing.Point(12, 263);
            this.client.Name = "client";
            this.client.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.client.Size = new System.Drawing.Size(251, 52);
            this.client.TabIndex = 5;
            this.client.Text = "Client";
            this.client.UseVisualStyleBackColor = false;
            this.client.Click += new System.EventHandler(this.client_Click);
            // 
            // p
            // 
            this.p.BackColor = System.Drawing.Color.White;
            this.p.ForeColor = System.Drawing.Color.White;
            this.p.Location = new System.Drawing.Point(1, 183);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(10, 52);
            this.p.TabIndex = 4;
            // 
            // quit
            // 
            this.quit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(64)))));
            this.quit.FlatAppearance.BorderSize = 0;
            this.quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.quit.Location = new System.Drawing.Point(12, 492);
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
            this.care.Location = new System.Drawing.Point(12, 413);
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
            this.visit.Location = new System.Drawing.Point(12, 332);
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
            this.home.Location = new System.Drawing.Point(12, 183);
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
            this.reduire.Controls.Add(this.reduice);
            this.reduire.Dock = System.Windows.Forms.DockStyle.Top;
            this.reduire.Location = new System.Drawing.Point(266, 0);
            this.reduire.Name = "reduire";
            this.reduire.Size = new System.Drawing.Size(550, 37);
            this.reduire.TabIndex = 1;
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
            // mobile
            // 
            this.mobile.Controls.Add(this.birth);
            this.mobile.Controls.Add(this.oldclient);
            this.mobile.Controls.Add(this.newclient);
            this.mobile.Controls.Add(this.listclient);
            this.mobile.Controls.Add(this.label5);
            this.mobile.Controls.Add(this.label4);
            this.mobile.Controls.Add(this.name);
            this.mobile.Controls.Add(this.label3);
            this.mobile.Controls.Add(this.label2);
            this.mobile.Controls.Add(this.label1);
            this.mobile.Location = new System.Drawing.Point(266, 37);
            this.mobile.Name = "mobile";
            this.mobile.Size = new System.Drawing.Size(548, 529);
            this.mobile.TabIndex = 3;
            // 
            // birth
            // 
            this.birth.Location = new System.Drawing.Point(224, 198);
            this.birth.Name = "birth";
            this.birth.Size = new System.Drawing.Size(177, 20);
            this.birth.TabIndex = 21;
            // 
            // oldclient
            // 
            this.oldclient.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.oldclient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oldclient.Location = new System.Drawing.Point(305, 421);
            this.oldclient.Name = "oldclient";
            this.oldclient.Size = new System.Drawing.Size(67, 23);
            this.oldclient.TabIndex = 20;
            this.oldclient.Text = "GO";
            this.oldclient.UseVisualStyleBackColor = false;
            // 
            // newclient
            // 
            this.newclient.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.newclient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newclient.Location = new System.Drawing.Point(305, 251);
            this.newclient.Name = "newclient";
            this.newclient.Size = new System.Drawing.Size(67, 23);
            this.newclient.TabIndex = 19;
            this.newclient.Text = "ADD";
            this.newclient.UseVisualStyleBackColor = false;
            this.newclient.Click += new System.EventHandler(this.newclient_Click);
            // 
            // listclient
            // 
            this.listclient.FormattingEnabled = true;
            this.listclient.Location = new System.Drawing.Point(231, 378);
            this.listclient.Name = "listclient";
            this.listclient.Size = new System.Drawing.Size(141, 21);
            this.listclient.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(150, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(149, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Birth :";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(224, 141);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(177, 20);
            this.name.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(148, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(224, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Client";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "New CLient";
            // 
            // Acceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(816, 567);
            this.Controls.Add(this.mobile);
            this.Controls.Add(this.reduire);
            this.Controls.Add(this.navbar);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Acceuil";
            this.Text = "-";
            this.Load += new System.EventHandler(this.Acceuil_Load);
            this.navbar.ResumeLayout(false);
            this.reduire.ResumeLayout(false);
            this.mobile.ResumeLayout(false);
            this.mobile.PerformLayout();
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
        private System.Windows.Forms.Button client;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel mobile;
        private System.Windows.Forms.DateTimePicker birth;
        private System.Windows.Forms.Button oldclient;
        private System.Windows.Forms.Button newclient;
        private System.Windows.Forms.ComboBox listclient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

