namespace Projet_BTS2
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
            LBWelcome = new Label();
            ((System.ComponentModel.ISupportInitialize)DGVUser).BeginInit();
            SuspendLayout();
            // 
            // DGVUser
            // 
            DGVUser.BackgroundColor = Color.Silver;
            DGVUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVUser.Location = new Point(34, 201);
            DGVUser.Name = "DGVUser";
            DGVUser.RowHeadersWidth = 51;
            DGVUser.RowTemplate.Height = 29;
            DGVUser.Size = new Size(683, 188);
            DGVUser.TabIndex = 4;
            // 
            // BTDelete
            // 
            BTDelete.Location = new Point(529, 135);
            BTDelete.Name = "BTDelete";
            BTDelete.Size = new Size(94, 29);
            BTDelete.TabIndex = 3;
            BTDelete.Text = "Supprimer";
            BTDelete.UseVisualStyleBackColor = true;
            BTDelete.Click += BTDelete_Click;
            // 
            // BTUpdate
            // 
            BTUpdate.Location = new Point(340, 135);
            BTUpdate.Name = "BTUpdate";
            BTUpdate.Size = new Size(94, 29);
            BTUpdate.TabIndex = 2;
            BTUpdate.Text = "Modifier";
            BTUpdate.UseVisualStyleBackColor = true;
            BTUpdate.Click += BTUpdate_Click;
            // 
            // BTAdd
            // 
            BTAdd.Location = new Point(140, 135);
            BTAdd.Name = "BTAdd";
            BTAdd.Size = new Size(94, 29);
            BTAdd.TabIndex = 1;
            BTAdd.Text = "Ajouter";
            BTAdd.UseVisualStyleBackColor = true;
            BTAdd.Click += BTAdd_Click;
            // 
            // LBWelcome
            // 
            LBWelcome.AutoSize = true;
            LBWelcome.ForeColor = Color.Red;
            LBWelcome.Location = new Point(357, 63);
            LBWelcome.Name = "LBWelcome";
            LBWelcome.Size = new Size(77, 20);
            LBWelcome.TabIndex = 5;
            LBWelcome.Text = "Bienvenue";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(800, 450);
            Controls.Add(LBWelcome);
            Controls.Add(DGVUser);
            Controls.Add(BTDelete);
            Controls.Add(BTUpdate);
            Controls.Add(BTAdd);
            Name = "Form1";
            Text = "Form1";
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
        private Label LBWelcome;
    }
}