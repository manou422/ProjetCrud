﻿namespace ProjetCrud
{
    partial class ConfirmationDelete
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
            label1 = new Label();
            BTOui = new Button();
            BTNon = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(24, 32);
            label1.Name = "label1";
            label1.Size = new Size(335, 20);
            label1.TabIndex = 0;
            label1.Text = "Êtes vous sûr de vouloir supprimer cet utilisateur?";
            // 
            // BTOui
            // 
            BTOui.Location = new Point(133, 84);
            BTOui.Name = "BTOui";
            BTOui.Size = new Size(94, 29);
            BTOui.TabIndex = 1;
            BTOui.Text = "Oui";
            BTOui.UseVisualStyleBackColor = true;
            BTOui.Click += BTOui_Click;
            // 
            // BTNon
            // 
            BTNon.Location = new Point(265, 84);
            BTNon.Name = "BTNon";
            BTNon.Size = new Size(94, 29);
            BTNon.TabIndex = 2;
            BTNon.Text = "Non";
            BTNon.UseVisualStyleBackColor = true;
            BTNon.Click += BTNon_Click;
            // 
            // ConfirmationDelete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(396, 145);
            Controls.Add(BTNon);
            Controls.Add(BTOui);
            Controls.Add(label1);
            ForeColor = SystemColors.Desktop;
            Name = "ConfirmationDelete";
            Text = "Confirmation de supression";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BTOui;
        private Button BTNon;
    }
}