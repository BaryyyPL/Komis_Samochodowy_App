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
            groupBox2 = new GroupBox();
            btn_zasub_newsletter = new Button();
            cb_zasub_newsletter = new CheckBox();
            tb_zasub_numer_telefonu = new TextBox();
            groupBox1 = new GroupBox();
            btn_dodaj_klienta = new Button();
            cb_newsletter = new CheckBox();
            tb_numer_telefonu = new TextBox();
            tb_nazwisko = new TextBox();
            tb_email = new TextBox();
            tb_imie = new TextBox();
            data_klienci = new DataGridView();
            btn_wyswietl_liste = new Button();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
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
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(data_klienci);
            panel1.Controls.Add(btn_wyswietl_liste);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 552);
            panel1.TabIndex = 7;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox2.AutoSize = true;
            groupBox2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox2.Controls.Add(btn_zasub_newsletter);
            groupBox2.Controls.Add(cb_zasub_newsletter);
            groupBox2.Controls.Add(tb_zasub_numer_telefonu);
            groupBox2.Location = new Point(748, 193);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(234, 144);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Zasubskrybuj newsletter";
            // 
            // btn_zasub_newsletter
            // 
            btn_zasub_newsletter.Location = new Point(38, 89);
            btn_zasub_newsletter.Name = "btn_zasub_newsletter";
            btn_zasub_newsletter.Size = new Size(190, 29);
            btn_zasub_newsletter.TabIndex = 7;
            btn_zasub_newsletter.Text = "Ustaw newsletter";
            btn_zasub_newsletter.UseVisualStyleBackColor = true;
            btn_zasub_newsletter.Click += btn_zasub_newsletter_Click;
            // 
            // cb_zasub_newsletter
            // 
            cb_zasub_newsletter.AutoSize = true;
            cb_zasub_newsletter.Location = new Point(80, 61);
            cb_zasub_newsletter.Name = "cb_zasub_newsletter";
            cb_zasub_newsletter.Size = new Size(109, 24);
            cb_zasub_newsletter.TabIndex = 6;
            cb_zasub_newsletter.Text = "Newsletter?";
            cb_zasub_newsletter.UseVisualStyleBackColor = true;
            // 
            // tb_zasub_numer_telefonu
            // 
            tb_zasub_numer_telefonu.Location = new Point(38, 26);
            tb_zasub_numer_telefonu.Name = "tb_zasub_numer_telefonu";
            tb_zasub_numer_telefonu.PlaceholderText = "Podaj numer telefonu";
            tb_zasub_numer_telefonu.Size = new Size(190, 27);
            tb_zasub_numer_telefonu.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox1.Controls.Add(btn_dodaj_klienta);
            groupBox1.Controls.Add(cb_newsletter);
            groupBox1.Controls.Add(tb_numer_telefonu);
            groupBox1.Controls.Add(tb_nazwisko);
            groupBox1.Controls.Add(tb_email);
            groupBox1.Controls.Add(tb_imie);
            groupBox1.Location = new Point(0, 190);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 147);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dodaj klienta";
            // 
            // btn_dodaj_klienta
            // 
            btn_dodaj_klienta.Location = new Point(204, 92);
            btn_dodaj_klienta.Name = "btn_dodaj_klienta";
            btn_dodaj_klienta.Size = new Size(190, 29);
            btn_dodaj_klienta.TabIndex = 5;
            btn_dodaj_klienta.Text = "Dodaj klienta";
            btn_dodaj_klienta.UseVisualStyleBackColor = true;
            btn_dodaj_klienta.Click += btn_dodaj_klienta_Click;
            // 
            // cb_newsletter
            // 
            cb_newsletter.AutoSize = true;
            cb_newsletter.Location = new Point(12, 92);
            cb_newsletter.Name = "cb_newsletter";
            cb_newsletter.Size = new Size(109, 24);
            cb_newsletter.TabIndex = 5;
            cb_newsletter.Text = "Newsletter?";
            cb_newsletter.UseVisualStyleBackColor = true;
            // 
            // tb_numer_telefonu
            // 
            tb_numer_telefonu.Location = new Point(12, 59);
            tb_numer_telefonu.Name = "tb_numer_telefonu";
            tb_numer_telefonu.PlaceholderText = "Podaj numer telefonu";
            tb_numer_telefonu.Size = new Size(190, 27);
            tb_numer_telefonu.TabIndex = 4;
            // 
            // tb_nazwisko
            // 
            tb_nazwisko.Location = new Point(12, 26);
            tb_nazwisko.Name = "tb_nazwisko";
            tb_nazwisko.PlaceholderText = "Podaj nazwisko";
            tb_nazwisko.Size = new Size(190, 27);
            tb_nazwisko.TabIndex = 3;
            // 
            // tb_email
            // 
            tb_email.Location = new Point(204, 59);
            tb_email.Name = "tb_email";
            tb_email.PlaceholderText = "Podaj email";
            tb_email.Size = new Size(190, 27);
            tb_email.TabIndex = 2;
            // 
            // tb_imie
            // 
            tb_imie.Location = new Point(204, 26);
            tb_imie.Name = "tb_imie";
            tb_imie.PlaceholderText = "Podaj imię";
            tb_imie.Size = new Size(190, 27);
            tb_imie.TabIndex = 1;
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
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private GroupBox groupBox1;
        private TextBox tb_nazwisko;
        private TextBox tb_email;
        private TextBox tb_imie;
        private CheckBox cb_newsletter;
        private TextBox tb_numer_telefonu;
        private Button btn_dodaj_klienta;
        private GroupBox groupBox2;
        private CheckBox cb_zasub_newsletter;
        private TextBox tb_zasub_numer_telefonu;
        private Button btn_zasub_newsletter;
    }
}