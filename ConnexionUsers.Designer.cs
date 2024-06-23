namespace ProjetCrud
{
    partial class ConnexionUsers
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
            DGVConnexion = new DataGridView();
            DateFiltre = new DateTimePicker();
            BTValid = new Button();
            BTFiltre = new Button();
            BTVider = new Button();
            ((System.ComponentModel.ISupportInitialize)DGVConnexion).BeginInit();
            SuspendLayout();
            // 
            // DGVConnexion
            // 
            DGVConnexion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVConnexion.Location = new Point(153, 89);
            DGVConnexion.Name = "DGVConnexion";
            DGVConnexion.RowHeadersWidth = 51;
            DGVConnexion.Size = new Size(473, 320);
            DGVConnexion.TabIndex = 0;
            // 
            // DateFiltre
            // 
            DateFiltre.Location = new Point(166, 30);
            DateFiltre.Name = "DateFiltre";
            DateFiltre.Size = new Size(185, 27);
            DateFiltre.TabIndex = 1;
            // 
            // BTValid
            // 
            BTValid.Location = new Point(403, 30);
            BTValid.Name = "BTValid";
            BTValid.Size = new Size(91, 29);
            BTValid.TabIndex = 2;
            BTValid.Text = "Valider";
            BTValid.UseVisualStyleBackColor = true;
            BTValid.Click += BTValid_Click;
            // 
            // BTFiltre
            // 
            BTFiltre.Location = new Point(532, 425);
            BTFiltre.Name = "BTFiltre";
            BTFiltre.Size = new Size(94, 29);
            BTFiltre.TabIndex = 3;
            BTFiltre.Text = "Conn -5j";
            BTFiltre.UseVisualStyleBackColor = true;
            BTFiltre.Click += BTFiltre_Click;
            // 
            // BTVider
            // 
            BTVider.Location = new Point(551, 31);
            BTVider.Name = "BTVider";
            BTVider.Size = new Size(75, 29);
            BTVider.TabIndex = 4;
            BTVider.Text = "RAZ";
            BTVider.UseVisualStyleBackColor = true;
            BTVider.Click += BTVider_Click;
            // 
            // ConnexionUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(800, 477);
            Controls.Add(BTVider);
            Controls.Add(BTFiltre);
            Controls.Add(BTValid);
            Controls.Add(DateFiltre);
            Controls.Add(DGVConnexion);
            Name = "ConnexionUsers";
            Text = "Connexions utilisateurs";
            Load += ConnexionUsers_Load;
            ((System.ComponentModel.ISupportInitialize)DGVConnexion).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGVConnexion;
        private DateTimePicker DateFiltre;
        private Button BTValid;
        private Button BTFiltre;
        private Button BTVider;
    }
}