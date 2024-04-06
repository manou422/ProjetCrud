namespace Test_projet
{
    partial class FormUtilisateur
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
            TBNom = new TextBox();
            TBPrenom = new TextBox();
            LBNom = new Label();
            LBPrenom = new Label();
            TBMail = new TextBox();
            TBMdp = new TextBox();
            LBMail = new Label();
            LBMdp = new Label();
            BTChangeMDP = new Button();
            BTAnnuler = new Button();
            BtnValide = new Button();
            LBAdmin = new Label();
            TBAdmin = new TextBox();
            SuspendLayout();
            // 
            // TBNom
            // 
            TBNom.Location = new Point(174, 32);
            TBNom.Name = "TBNom";
            TBNom.Size = new Size(206, 27);
            TBNom.TabIndex = 2;
            // 
            // TBPrenom
            // 
            TBPrenom.Location = new Point(174, 96);
            TBPrenom.Name = "TBPrenom";
            TBPrenom.Size = new Size(206, 27);
            TBPrenom.TabIndex = 3;
            // 
            // LBNom
            // 
            LBNom.AutoSize = true;
            LBNom.Location = new Point(37, 35);
            LBNom.Name = "LBNom";
            LBNom.Size = new Size(42, 20);
            LBNom.TabIndex = 4;
            LBNom.Text = "Nom";
            // 
            // LBPrenom
            // 
            LBPrenom.AutoSize = true;
            LBPrenom.Location = new Point(37, 96);
            LBPrenom.Name = "LBPrenom";
            LBPrenom.Size = new Size(60, 20);
            LBPrenom.TabIndex = 5;
            LBPrenom.Text = "Prénom";
            // 
            // TBMail
            // 
            TBMail.Location = new Point(174, 160);
            TBMail.Name = "TBMail";
            TBMail.Size = new Size(206, 27);
            TBMail.TabIndex = 6;
            // 
            // TBMdp
            // 
            TBMdp.Location = new Point(174, 331);
            TBMdp.Name = "TBMdp";
            TBMdp.Size = new Size(206, 27);
            TBMdp.TabIndex = 7;
            // 
            // LBMail
            // 
            LBMail.AutoSize = true;
            LBMail.Location = new Point(37, 163);
            LBMail.Name = "LBMail";
            LBMail.Size = new Size(38, 20);
            LBMail.TabIndex = 8;
            LBMail.Text = "Mail";
            // 
            // LBMdp
            // 
            LBMdp.AutoSize = true;
            LBMdp.Location = new Point(37, 338);
            LBMdp.Name = "LBMdp";
            LBMdp.Size = new Size(98, 20);
            LBMdp.TabIndex = 9;
            LBMdp.Text = "Mot de passe";
            // 
            // BTChangeMDP
            // 
            BTChangeMDP.Location = new Point(37, 400);
            BTChangeMDP.Name = "BTChangeMDP";
            BTChangeMDP.Size = new Size(134, 29);
            BTChangeMDP.TabIndex = 10;
            BTChangeMDP.Text = "Changer MDP";
            BTChangeMDP.UseVisualStyleBackColor = true;
            BTChangeMDP.Click += BTChangeMDP_Click;
            // 
            // BTAnnuler
            // 
            BTAnnuler.Location = new Point(257, 400);
            BTAnnuler.Name = "BTAnnuler";
            BTAnnuler.Size = new Size(94, 29);
            BTAnnuler.TabIndex = 11;
            BTAnnuler.Text = "Annuler";
            BTAnnuler.UseVisualStyleBackColor = true;
            // 
            // BtnValide
            // 
            BtnValide.Location = new Point(445, 400);
            BtnValide.Name = "BtnValide";
            BtnValide.Size = new Size(94, 29);
            BtnValide.TabIndex = 12;
            BtnValide.Text = "Valider";
            BtnValide.UseVisualStyleBackColor = true;
            BtnValide.Click += BTOk_Click;
            // 
            // LBAdmin
            // 
            LBAdmin.AutoSize = true;
            LBAdmin.Location = new Point(37, 258);
            LBAdmin.Name = "LBAdmin";
            LBAdmin.Size = new Size(53, 20);
            LBAdmin.TabIndex = 13;
            LBAdmin.Text = "Admin";
            // 
            // TBAdmin
            // 
            TBAdmin.Location = new Point(174, 255);
            TBAdmin.Name = "TBAdmin";
            TBAdmin.Size = new Size(206, 27);
            TBAdmin.TabIndex = 14;
            // 
            // FormUtilisateur
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TBAdmin);
            Controls.Add(LBAdmin);
            Controls.Add(BtnValide);
            Controls.Add(BTAnnuler);
            Controls.Add(BTChangeMDP);
            Controls.Add(LBMdp);
            Controls.Add(LBMail);
            Controls.Add(TBMdp);
            Controls.Add(TBMail);
            Controls.Add(LBPrenom);
            Controls.Add(LBNom);
            Controls.Add(TBPrenom);
            Controls.Add(TBNom);
            Name = "FormUtilisateur";
            Text = "FormUtilisateur";
            Load += FormUtilisateur_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TBNom;
        private TextBox TBPrenom;
        private Label LBNom;
        private Label LBPrenom;
        private TextBox TBMail;
        private TextBox TBMdp;
        private Label LBMail;
        private Label LBMdp;
        private Button BTChangeMDP;
        private Button BTAnnuler;
        private Button BtnValide;
        private Label LBAdmin;
        private TextBox TBAdmin;
    }
}