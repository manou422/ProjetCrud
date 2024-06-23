namespace ProjetCrud
{
    partial class ConfirmationArchivage
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
            BTOui = new Button();
            BTNon = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // BTOui
            // 
            BTOui.Location = new Point(126, 93);
            BTOui.Name = "BTOui";
            BTOui.Size = new Size(94, 29);
            BTOui.TabIndex = 0;
            BTOui.Text = "Oui";
            BTOui.UseVisualStyleBackColor = true;
            BTOui.Click += BTOui_Click;
            // 
            // BTNon
            // 
            BTNon.Location = new Point(250, 93);
            BTNon.Name = "BTNon";
            BTNon.Size = new Size(94, 29);
            BTNon.TabIndex = 1;
            BTNon.Text = "Non";
            BTNon.UseVisualStyleBackColor = true;
            BTNon.Click += BTNon_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(24, 31);
            label1.Name = "label1";
            label1.Size = new Size(320, 20);
            label1.TabIndex = 2;
            label1.Text = "Êtes vous sûr de vouloir archiver cet utilisateur?";
            // 
            // ConfirmationArchivage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(372, 143);
            Controls.Add(label1);
            Controls.Add(BTNon);
            Controls.Add(BTOui);
            Name = "ConfirmationArchivage";
            Text = "Confirmer l'achivage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTOui;
        private Button BTNon;
        private Label label1;
    }
}