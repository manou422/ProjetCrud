namespace ProjetCrud
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DGVUser = new DataGridView();
            BTDelete = new Button();
            BTUpdate = new Button();
            BTAdd = new Button();
            BTArchive = new Button();
            BTDeconnect = new Button();
            BTConnexion = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DGVUser).BeginInit();
            SuspendLayout();
            // 
            // DGVUser
            // 
            DGVUser.BackgroundColor = Color.FloralWhite;
            DGVUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVUser.Location = new Point(34, 167);
            DGVUser.Name = "DGVUser";
            DGVUser.RowHeadersWidth = 51;
            DGVUser.Size = new Size(697, 220);
            DGVUser.TabIndex = 4;
            // 
            // BTDelete
            // 
            BTDelete.Location = new Point(319, 107);
            BTDelete.Name = "BTDelete";
            BTDelete.Size = new Size(117, 29);
            BTDelete.TabIndex = 3;
            BTDelete.Text = "Supprimer";
            BTDelete.UseVisualStyleBackColor = true;
            BTDelete.Click += BTDelete_Click;
            // 
            // BTUpdate
            // 
            BTUpdate.Location = new Point(169, 107);
            BTUpdate.Name = "BTUpdate";
            BTUpdate.Size = new Size(117, 29);
            BTUpdate.TabIndex = 2;
            BTUpdate.Text = "Modifier";
            BTUpdate.UseVisualStyleBackColor = true;
            BTUpdate.Click += BTUpdate_Click;
            // 
            // BTAdd
            // 
            BTAdd.Location = new Point(34, 107);
            BTAdd.Name = "BTAdd";
            BTAdd.Size = new Size(117, 29);
            BTAdd.TabIndex = 1;
            BTAdd.Text = "Ajouter";
            BTAdd.UseVisualStyleBackColor = true;
            BTAdd.Click += BTAdd_Click;
            // 
            // BTArchive
            // 
            BTArchive.Location = new Point(469, 107);
            BTArchive.Name = "BTArchive";
            BTArchive.Size = new Size(117, 29);
            BTArchive.TabIndex = 6;
            BTArchive.Text = "(des)Archiver";
            BTArchive.UseVisualStyleBackColor = true;
            BTArchive.Click += BTArchive_Click;
            // 
            // BTDeconnect
            // 
            BTDeconnect.Location = new Point(614, 409);
            BTDeconnect.Name = "BTDeconnect";
            BTDeconnect.Size = new Size(117, 29);
            BTDeconnect.TabIndex = 7;
            BTDeconnect.Text = "Déconnexion";
            BTDeconnect.UseVisualStyleBackColor = true;
            BTDeconnect.Click += BTDeconnect_Click;
            // 
            // BTConnexion
            // 
            BTConnexion.Location = new Point(614, 107);
            BTConnexion.Name = "BTConnexion";
            BTConnexion.Size = new Size(117, 29);
            BTConnexion.TabIndex = 8;
            BTConnexion.Text = "Connexions";
            BTConnexion.UseVisualStyleBackColor = true;
            BTConnexion.Click += BTConnexion_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(34, 59);
            label1.Name = "label1";
            label1.Size = new Size(141, 20);
            label1.TabIndex = 9;
            label1.Text = "Liste des utilisateurs";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(758, 450);
            Controls.Add(label1);
            Controls.Add(BTConnexion);
            Controls.Add(BTDeconnect);
            Controls.Add(BTArchive);
            Controls.Add(DGVUser);
            Controls.Add(BTDelete);
            Controls.Add(BTUpdate);
            Controls.Add(BTAdd);
            Name = "Form1";
            Text = "Liste des utiisateurs";
            FormClosed += quit;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DGVUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView DGVUser;
        private Button BTDelete;
        private Button BTUpdate;
        private Button BTAdd;
        private Button BTArchive;
        private Button BTDeconnect;
        private Button BTConnexion;
        private Label label1;
    }
}