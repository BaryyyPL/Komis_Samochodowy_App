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
            panel1 = new Panel();
            data_samochody_osobowe = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_samochody_osobowe).BeginInit();
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
            btn_cofnij.Dock = DockStyle.Bottom;
            btn_cofnij.Location = new Point(0, 624);
            btn_cofnij.Name = "btn_cofnij";
            btn_cofnij.Size = new Size(982, 29);
            btn_cofnij.TabIndex = 2;
            btn_cofnij.Text = "Cofnij";
            btn_cofnij.UseVisualStyleBackColor = true;
            btn_cofnij.Click += btn_cofnij_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(data_samochody_osobowe);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 552);
            panel1.TabIndex = 3;
            // 
            // data_samochody_osobowe
            // 
            data_samochody_osobowe.AllowUserToAddRows = false;
            data_samochody_osobowe.AllowUserToDeleteRows = false;
            data_samochody_osobowe.AllowUserToResizeColumns = false;
            data_samochody_osobowe.AllowUserToResizeRows = false;
            data_samochody_osobowe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            data_samochody_osobowe.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            data_samochody_osobowe.BackgroundColor = SystemColors.Control;
            data_samochody_osobowe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_samochody_osobowe.Dock = DockStyle.Top;
            data_samochody_osobowe.Location = new Point(0, 0);
            data_samochody_osobowe.Name = "data_samochody_osobowe";
            data_samochody_osobowe.ReadOnly = true;
            data_samochody_osobowe.RowHeadersWidth = 51;
            data_samochody_osobowe.RowTemplate.Height = 29;
            data_samochody_osobowe.Size = new Size(982, 190);
            data_samochody_osobowe.TabIndex = 2;
            // 
            // Samochody_Osobowe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 653);
            Controls.Add(panel1);
            Controls.Add(btn_cofnij);
            Controls.Add(label1);
            Name = "Samochody_Osobowe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Samochody Osobowe";
            Load += btn_wyswietl_liste_Click;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)data_samochody_osobowe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_cofnij;
        private Panel panel1;
        private DataGridView data_samochody_osobowe;
    }
}