namespace Komis_Samochodowy_App
{
    partial class Samochody_Dostawcze
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
            data_samochody_dostawcze = new DataGridView();
            btn_wyswietl_liste = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_samochody_dostawcze).BeginInit();
            SuspendLayout();
            // 
            // btn_cofnij
            // 
            btn_cofnij.Dock = DockStyle.Bottom;
            btn_cofnij.Location = new Point(0, 624);
            btn_cofnij.Name = "btn_cofnij";
            btn_cofnij.Size = new Size(982, 29);
            btn_cofnij.TabIndex = 4;
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
            label1.Size = new Size(611, 72);
            label1.TabIndex = 3;
            label1.Text = "Samochody Dostawcze";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(data_samochody_dostawcze);
            panel1.Controls.Add(btn_wyswietl_liste);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 552);
            panel1.TabIndex = 5;
            // 
            // data_samochody_dostawcze
            // 
            data_samochody_dostawcze.AllowUserToAddRows = false;
            data_samochody_dostawcze.AllowUserToDeleteRows = false;
            data_samochody_dostawcze.AllowUserToResizeColumns = false;
            data_samochody_dostawcze.AllowUserToResizeRows = false;
            data_samochody_dostawcze.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            data_samochody_dostawcze.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            data_samochody_dostawcze.BackgroundColor = SystemColors.Control;
            data_samochody_dostawcze.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_samochody_dostawcze.Dock = DockStyle.Top;
            data_samochody_dostawcze.Location = new Point(0, 0);
            data_samochody_dostawcze.Name = "data_samochody_dostawcze";
            data_samochody_dostawcze.ReadOnly = true;
            data_samochody_dostawcze.RowHeadersWidth = 51;
            data_samochody_dostawcze.RowTemplate.Height = 29;
            data_samochody_dostawcze.Size = new Size(982, 190);
            data_samochody_dostawcze.TabIndex = 2;
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
            // Samochody_Dostawcze
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 653);
            Controls.Add(panel1);
            Controls.Add(btn_cofnij);
            Controls.Add(label1);
            Name = "Samochody_Dostawcze";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Samochody Dostawcze";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)data_samochody_dostawcze).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_cofnij;
        private Label label1;
        private Panel panel1;
        private DataGridView data_samochody_dostawcze;
        private Button btn_wyswietl_liste;
    }
}