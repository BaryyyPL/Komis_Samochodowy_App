namespace Komis_Samochodowy_App
{
    partial class Samochody_Osobowe
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
            btn_cofnij = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(576, 72);
            label1.TabIndex = 1;
            label1.Text = "Samochody Osobowe";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_cofnij
            // 
            btn_cofnij.Location = new Point(190, 453);
            btn_cofnij.Name = "btn_cofnij";
            btn_cofnij.Size = new Size(94, 29);
            btn_cofnij.TabIndex = 2;
            btn_cofnij.Text = "button1";
            btn_cofnij.UseVisualStyleBackColor = true;
            btn_cofnij.Click += btn_cofnij_Click;
            // 
            // Samochody_Osobowe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 653);
            Controls.Add(btn_cofnij);
            Controls.Add(label1);
            Name = "Samochody_Osobowe";
            Text = "Samochody_Osobowe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_cofnij;
    }
}