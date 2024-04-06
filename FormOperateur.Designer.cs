namespace Test_projet
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
            LBWelcome = new Label();
            SuspendLayout();
            // 
            // LBWelcome
            // 
            LBWelcome.AutoSize = true;
            LBWelcome.ForeColor = Color.Red;
            LBWelcome.Location = new Point(231, 82);
            LBWelcome.Name = "LBWelcome";
            LBWelcome.Size = new Size(77, 20);
            LBWelcome.TabIndex = 0;
            LBWelcome.Text = "Bienvenue";
            // 
            // FormOperateur
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LBWelcome);
            Name = "FormOperateur";
            Text = "FormOperateur";
            Load += FormOperateur_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LBWelcome;
    }
}