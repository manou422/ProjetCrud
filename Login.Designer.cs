﻿namespace ProjetCrud
{
    partial class Login
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
            BTOk = new Button();
            LBMail = new Label();
            LBMdp = new Label();
            TBMail = new TextBox();
            TBMdp = new TextBox();
            label1 = new Label();
            LBTitre = new Label();
            SuspendLayout();
            // 
            // BTOk
            // 
            BTOk.Location = new Point(12, 409);
            BTOk.Name = "BTOk";
            BTOk.Size = new Size(376, 29);
            BTOk.TabIndex = 0;
            BTOk.Text = "Se connecter";
            BTOk.UseVisualStyleBackColor = true;
            BTOk.Click += BTOk_Click;
            // 
            // LBMail
            // 
            LBMail.AutoSize = true;
            LBMail.BackColor = Color.LightCoral;
            LBMail.Location = new Point(42, 240);
            LBMail.Name = "LBMail";
            LBMail.Size = new Size(38, 20);
            LBMail.TabIndex = 1;
            LBMail.Text = "Mail";
            // 
            // LBMdp
            // 
            LBMdp.AutoSize = true;
            LBMdp.BackColor = Color.LightCoral;
            LBMdp.Location = new Point(42, 316);
            LBMdp.Name = "LBMdp";
            LBMdp.Size = new Size(98, 20);
            LBMdp.TabIndex = 2;
            LBMdp.Text = "Mot de passe";
            // 
            // TBMail
            // 
            TBMail.BackColor = Color.White;
            TBMail.Location = new Point(110, 237);
            TBMail.Name = "TBMail";
            TBMail.Size = new Size(249, 27);
            TBMail.TabIndex = 4;
            // 
            // TBMdp
            // 
            TBMdp.Location = new Point(172, 313);
            TBMdp.Name = "TBMdp";
            TBMdp.Size = new Size(187, 27);
            TBMdp.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(42, 148);
            label1.Name = "label1";
            label1.Size = new Size(170, 20);
            label1.TabIndex = 6;
            label1.Text = "Merci de vous connecter";
            // 
            // LBTitre
            // 
            LBTitre.BackColor = Color.MistyRose;
            LBTitre.Font = new Font("Segoe UI", 14F);
            LBTitre.ForeColor = Color.Red;
            LBTitre.Location = new Point(42, 26);
            LBTitre.Name = "LBTitre";
            LBTitre.Size = new Size(317, 64);
            LBTitre.TabIndex = 8;
            LBTitre.Text = "Application de Gestion du fonds documentaire";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(400, 450);
            Controls.Add(LBTitre);
            Controls.Add(label1);
            Controls.Add(TBMdp);
            Controls.Add(TBMail);
            Controls.Add(LBMdp);
            Controls.Add(LBMail);
            Controls.Add(BTOk);
            Name = "Login";
            Text = "Se connecter";
            FormClosed += quit;
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTOk;
        private Label LBMail;
        private Label LBMdp;
        private TextBox TBMail;
        private TextBox TBMdp;
        private Label label1;
        private Label LBTitre;
    }
}