namespace Labirintus
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
            label1 = new Label();
            buttonEasy = new Button();
            buttonMedium = new Button();
            buttonHard = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(225, 58);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // buttonEasy
            // 
            buttonEasy.Location = new Point(49, 135);
            buttonEasy.Name = "buttonEasy";
            buttonEasy.Size = new Size(184, 90);
            buttonEasy.TabIndex = 1;
            buttonEasy.Text = "Könnyű";
            buttonEasy.UseVisualStyleBackColor = true;
            buttonEasy.Click += buttonEasy_Click;
            // 
            // buttonMedium
            // 
            buttonMedium.Location = new Point(276, 135);
            buttonMedium.Name = "buttonMedium";
            buttonMedium.Size = new Size(184, 90);
            buttonMedium.TabIndex = 2;
            buttonMedium.Text = "Közepes";
            buttonMedium.UseVisualStyleBackColor = true;
            buttonMedium.Click += buttonMedium_Click;
            // 
            // buttonHard
            // 
            buttonHard.Location = new Point(509, 135);
            buttonHard.Name = "buttonHard";
            buttonHard.Size = new Size(184, 90);
            buttonHard.TabIndex = 3;
            buttonHard.Text = "Nehéz";
            buttonHard.UseVisualStyleBackColor = true;
            buttonHard.Click += buttonHard_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 275);
            Controls.Add(buttonHard);
            Controls.Add(buttonMedium);
            Controls.Add(buttonEasy);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonEasy;
        private Button buttonMedium;
        private Button buttonHard;
    }
}
