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
            panel1 = new Panel();
            data_klienci = new DataGridView();
            btn_wyswietl_liste = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_klienci).BeginInit();
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
            // panel1
            // 
            panel1.Controls.Add(data_klienci);
            panel1.Controls.Add(btn_wyswietl_liste);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 552);
            panel1.TabIndex = 7;
            // 
            // data_klienci
            // 
            data_klienci.AllowUserToAddRows = false;
            data_klienci.AllowUserToDeleteRows = false;
            data_klienci.AllowUserToResizeColumns = false;
            data_klienci.AllowUserToResizeRows = false;
            data_klienci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data_klienci.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            data_klienci.BackgroundColor = SystemColors.Control;
            data_klienci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_klienci.Dock = DockStyle.Top;
            data_klienci.Location = new Point(0, 0);
            data_klienci.Name = "data_klienci";
            data_klienci.ReadOnly = true;
            data_klienci.RowHeadersWidth = 51;
            data_klienci.RowTemplate.Height = 29;
            data_klienci.Size = new Size(982, 190);
            data_klienci.TabIndex = 2;
            // 
            // btn_wyswietl_liste
            // 
            btn_wyswietl_liste.Dock = DockStyle.Bottom;
            btn_wyswietl_liste.Location = new Point(0, 523);
            btn_wyswietl_liste.Name = "btn_wyswietl_liste";
            btn_wyswietl_liste.Size = new Size(982, 29);
            btn_wyswietl_liste.TabIndex = 3;
            btn_wyswietl_liste.Text = "Wyświetl Listę";
            btn_wyswietl_liste.UseVisualStyleBackColor = true;
            btn_wyswietl_liste.Click += btn_wyswietl_liste_Click;
            // 
            // Klienci
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 653);
            Controls.Add(panel1);
            Controls.Add(btn_cofnij);
            Controls.Add(label1);
            Name = "Klienci";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Klienci";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)data_klienci).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_cofnij;
        private Label label1;
        private Panel panel1;
        private DataGridView data_klienci;
        private Button btn_wyswietl_liste;
    }
}