namespace Komis_Samochodowy_App
{
    partial class Pracownicy
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
            data_pracownicy = new DataGridView();
            btn_wyswietl_liste = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_pracownicy).BeginInit();
            SuspendLayout();
            // 
            // btn_cofnij
            // 
            btn_cofnij.Dock = DockStyle.Bottom;
            btn_cofnij.Location = new Point(0, 624);
            btn_cofnij.Name = "btn_cofnij";
            btn_cofnij.Size = new Size(982, 29);
            btn_cofnij.TabIndex = 8;
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
            label1.Size = new Size(318, 72);
            label1.TabIndex = 7;
            label1.Text = "Pracownicy";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(data_pracownicy);
            panel1.Controls.Add(btn_wyswietl_liste);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 552);
            panel1.TabIndex = 9;
            // 
            // data_pracownicy
            // 
            data_pracownicy.AllowUserToAddRows = false;
            data_pracownicy.AllowUserToDeleteRows = false;
            data_pracownicy.AllowUserToResizeColumns = false;
            data_pracownicy.AllowUserToResizeRows = false;
            data_pracownicy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data_pracownicy.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            data_pracownicy.BackgroundColor = SystemColors.Control;
            data_pracownicy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_pracownicy.Dock = DockStyle.Top;
            data_pracownicy.Location = new Point(0, 0);
            data_pracownicy.Name = "data_pracownicy";
            data_pracownicy.ReadOnly = true;
            data_pracownicy.RowHeadersWidth = 51;
            data_pracownicy.RowTemplate.Height = 29;
            data_pracownicy.Size = new Size(982, 190);
            data_pracownicy.TabIndex = 2;
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
            // Pracownicy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 653);
            Controls.Add(panel1);
            Controls.Add(btn_cofnij);
            Controls.Add(label1);
            Name = "Pracownicy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pracownicy";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)data_pracownicy).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_cofnij;
        private Label label1;
        private Panel panel1;
        private DataGridView data_pracownicy;
        private Button btn_wyswietl_liste;
    }
}