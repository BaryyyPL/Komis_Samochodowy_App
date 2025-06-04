namespace Komis_Samochodowy_App
{
    partial class Klienci
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
            btn_cofnij = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_cofnij
            // 
            btn_cofnij.Dock = DockStyle.Bottom;
            btn_cofnij.Location = new Point(0, 624);
            btn_cofnij.Name = "btn_cofnij";
            btn_cofnij.Size = new Size(982, 29);
            btn_cofnij.TabIndex = 6;
            btn_cofnij.Text = "Cofnij";
            btn_cofnij.UseVisualStyleBackColor = true;
            btn_cofnij.Click += btn_cofnij_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(198, 72);
            label1.TabIndex = 5;
            label1.Text = "Klienci";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Klienci
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 653);
            Controls.Add(btn_cofnij);
            Controls.Add(label1);
            Name = "Klienci";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Klienci";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_cofnij;
        private Label label1;
    }
}