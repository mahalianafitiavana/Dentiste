﻿namespace Dentiste
{
    partial class ClientForm
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
            this.cliente = new System.Windows.Forms.Panel();
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
            this.cliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // cliente
            // 
            this.cliente.Controls.Add(this.birth);
            this.cliente.Controls.Add(this.oldclient);
            this.cliente.Controls.Add(this.newclient);
            this.cliente.Controls.Add(this.listclient);
            this.cliente.Controls.Add(this.label5);
            this.cliente.Controls.Add(this.label4);
            this.cliente.Controls.Add(this.name);
            this.cliente.Controls.Add(this.label3);
            this.cliente.Controls.Add(this.label2);
            this.cliente.Controls.Add(this.label1);
            this.cliente.Location = new System.Drawing.Point(106, 70);
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(326, 398);
            this.cliente.TabIndex = 0;
            // 
            // birth
            // 
            this.birth.Location = new System.Drawing.Point(126, 135);
            this.birth.Name = "birth";
            this.birth.Size = new System.Drawing.Size(177, 20);
            this.birth.TabIndex = 11;
            // 
            // oldclient
            // 
            this.oldclient.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.oldclient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oldclient.Location = new System.Drawing.Point(207, 358);
            this.oldclient.Name = "oldclient";
            this.oldclient.Size = new System.Drawing.Size(67, 23);
            this.oldclient.TabIndex = 10;
            this.oldclient.Text = "GO";
            this.oldclient.UseVisualStyleBackColor = false;
            // 
            // newclient
            // 
            this.newclient.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.newclient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newclient.Location = new System.Drawing.Point(207, 188);
            this.newclient.Name = "newclient";
            this.newclient.Size = new System.Drawing.Size(67, 23);
            this.newclient.TabIndex = 9;
            this.newclient.Text = "ADD";
            this.newclient.UseVisualStyleBackColor = false;
            this.newclient.Click += new System.EventHandler(this.newclient_Click);
            // 
            // listclient
            // 
            this.listclient.FormattingEnabled = true;
            this.listclient.Location = new System.Drawing.Point(133, 315);
            this.listclient.Name = "listclient";
            this.listclient.Size = new System.Drawing.Size(141, 21);
            this.listclient.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Birth :";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(126, 78);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(177, 20);
            this.name.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Client";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "New CLient";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(548, 529);
            this.Controls.Add(this.cliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.cliente.ResumeLayout(false);
            this.cliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel cliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox listclient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button newclient;
        private System.Windows.Forms.Button oldclient;
        private System.Windows.Forms.DateTimePicker birth;
    }
}