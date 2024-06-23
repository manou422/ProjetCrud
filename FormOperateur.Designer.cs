namespace ProjetCrud
{
    partial class FormOperateur
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
            DGVLivres = new DataGridView();
            BTConsulter = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DGVLivres).BeginInit();
            SuspendLayout();
            // 
            // DGVLivres
            // 
            DGVLivres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVLivres.Location = new Point(71, 125);
            DGVLivres.Name = "DGVLivres";
            DGVLivres.RowHeadersWidth = 51;
            DGVLivres.Size = new Size(1130, 638);
            DGVLivres.TabIndex = 1;
            // 
            // BTConsulter
            // 
            BTConsulter.Location = new Point(1107, 53);
            BTConsulter.Name = "BTConsulter";
            BTConsulter.Size = new Size(94, 29);
            BTConsulter.TabIndex = 2;
            BTConsulter.Text = "Consulter";
            BTConsulter.UseVisualStyleBackColor = true;
            BTConsulter.Click += BTConsulter_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(81, 53);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 3;
            label1.Text = "Liste des livres";
            // 
            // FormOperateur
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1260, 819);
            Controls.Add(label1);
            Controls.Add(BTConsulter);
            Controls.Add(DGVLivres);
            Name = "FormOperateur";
            Text = "Liste des livres";
            FormClosed += quit;
            Load += FormOperateur_Load;
            ((System.ComponentModel.ISupportInitialize)DGVLivres).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView DGVLivres;
        private Button BTConsulter;
        private Label label1;
    }
}