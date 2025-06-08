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
            groupBox4 = new GroupBox();
            btn_zastosuj_filtry = new Button();
            btn_resetuj_filtry = new Button();
            tb_filtruj_stanowisko = new TextBox();
            tb_filtruj_pensja_maksymalna = new TextBox();
            tb_filtruj_pensja_minimalna = new TextBox();
            tb_filtruj_email = new TextBox();
            tb_filtruj_numer_telefonu = new TextBox();
            tb_filtruj_nazwisko = new TextBox();
            tb_filtruj_imie = new TextBox();
            groupBox3 = new GroupBox();
            btn_daj_podwyzke = new Button();
            tb_podwyzka_kwota_podwyzki = new TextBox();
            tb_podwyzka_numer_telefonu = new TextBox();
            groupBox2 = new GroupBox();
            rb_nazwisko_malejaco = new RadioButton();
            rb_imie_rosnaco = new RadioButton();
            rb_stanowisko_rosnaco = new RadioButton();
            rb_stanowisko_malejaco = new RadioButton();
            rb_pensja_malejaco = new RadioButton();
            rb_pensja_rosnaco = new RadioButton();
            rb_imie_malejco = new RadioButton();
            rb_nazwisko_rosnaco = new RadioButton();
            groupBox1 = new GroupBox();
            btn_dodaj_pracownika = new Button();
            tb_email = new TextBox();
            tb_pensja = new TextBox();
            tb_stanowisko = new TextBox();
            tb_imie = new TextBox();
            tb_numer_telefonu = new TextBox();
            tb_nazwisko = new TextBox();
            data_pracownicy = new DataGridView();
            panel1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
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
            panel1.Controls.Add(groupBox4);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(data_pracownicy);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 552);
            panel1.TabIndex = 9;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btn_zastosuj_filtry);
            groupBox4.Controls.Add(btn_resetuj_filtry);
            groupBox4.Controls.Add(tb_filtruj_stanowisko);
            groupBox4.Controls.Add(tb_filtruj_pensja_maksymalna);
            groupBox4.Controls.Add(tb_filtruj_pensja_minimalna);
            groupBox4.Controls.Add(tb_filtruj_email);
            groupBox4.Controls.Add(tb_filtruj_numer_telefonu);
            groupBox4.Controls.Add(tb_filtruj_nazwisko);
            groupBox4.Controls.Add(tb_filtruj_imie);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(434, 268);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(548, 284);
            groupBox4.TabIndex = 13;
            groupBox4.TabStop = false;
            groupBox4.Text = "Filtracja";
            // 
            // btn_zastosuj_filtry
            // 
            btn_zastosuj_filtry.Location = new Point(7, 176);
            btn_zastosuj_filtry.Name = "btn_zastosuj_filtry";
            btn_zastosuj_filtry.Size = new Size(264, 29);
            btn_zastosuj_filtry.TabIndex = 8;
            btn_zastosuj_filtry.Text = "Zastosuj filtry";
            btn_zastosuj_filtry.UseVisualStyleBackColor = true;
            btn_zastosuj_filtry.Click += btn_zastosuj_filtry_Click;
            // 
            // btn_resetuj_filtry
            // 
            btn_resetuj_filtry.Location = new Point(277, 176);
            btn_resetuj_filtry.Name = "btn_resetuj_filtry";
            btn_resetuj_filtry.Size = new Size(265, 29);
            btn_resetuj_filtry.TabIndex = 7;
            btn_resetuj_filtry.Text = "Resetuj filtry";
            btn_resetuj_filtry.UseVisualStyleBackColor = true;
            btn_resetuj_filtry.Click += btn_resetuj_filtry_Click;
            // 
            // tb_filtruj_stanowisko
            // 
            tb_filtruj_stanowisko.Location = new Point(7, 125);
            tb_filtruj_stanowisko.Name = "tb_filtruj_stanowisko";
            tb_filtruj_stanowisko.PlaceholderText = "Podaj stanowisko";
            tb_filtruj_stanowisko.Size = new Size(264, 27);
            tb_filtruj_stanowisko.TabIndex = 6;
            // 
            // tb_filtruj_pensja_maksymalna
            // 
            tb_filtruj_pensja_maksymalna.Location = new Point(277, 92);
            tb_filtruj_pensja_maksymalna.Name = "tb_filtruj_pensja_maksymalna";
            tb_filtruj_pensja_maksymalna.PlaceholderText = "Podaj pensję maksymalną";
            tb_filtruj_pensja_maksymalna.Size = new Size(265, 27);
            tb_filtruj_pensja_maksymalna.TabIndex = 5;
            // 
            // tb_filtruj_pensja_minimalna
            // 
            tb_filtruj_pensja_minimalna.Location = new Point(7, 92);
            tb_filtruj_pensja_minimalna.Name = "tb_filtruj_pensja_minimalna";
            tb_filtruj_pensja_minimalna.PlaceholderText = "Podaj pensję minimalną";
            tb_filtruj_pensja_minimalna.Size = new Size(264, 27);
            tb_filtruj_pensja_minimalna.TabIndex = 4;
            // 
            // tb_filtruj_email
            // 
            tb_filtruj_email.Location = new Point(277, 59);
            tb_filtruj_email.Name = "tb_filtruj_email";
            tb_filtruj_email.PlaceholderText = "Podaj email";
            tb_filtruj_email.Size = new Size(265, 27);
            tb_filtruj_email.TabIndex = 3;
            // 
            // tb_filtruj_numer_telefonu
            // 
            tb_filtruj_numer_telefonu.Location = new Point(7, 59);
            tb_filtruj_numer_telefonu.Name = "tb_filtruj_numer_telefonu";
            tb_filtruj_numer_telefonu.PlaceholderText = "Podaj numer telefonu";
            tb_filtruj_numer_telefonu.Size = new Size(264, 27);
            tb_filtruj_numer_telefonu.TabIndex = 2;
            // 
            // tb_filtruj_nazwisko
            // 
            tb_filtruj_nazwisko.Location = new Point(277, 26);
            tb_filtruj_nazwisko.Name = "tb_filtruj_nazwisko";
            tb_filtruj_nazwisko.PlaceholderText = "Podaj nazwisko";
            tb_filtruj_nazwisko.Size = new Size(265, 27);
            tb_filtruj_nazwisko.TabIndex = 1;
            // 
            // tb_filtruj_imie
            // 
            tb_filtruj_imie.Location = new Point(7, 26);
            tb_filtruj_imie.Name = "tb_filtruj_imie";
            tb_filtruj_imie.PlaceholderText = "Podaj imię";
            tb_filtruj_imie.Size = new Size(264, 27);
            tb_filtruj_imie.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.AutoSize = true;
            groupBox3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox3.Controls.Add(btn_daj_podwyzke);
            groupBox3.Controls.Add(tb_podwyzka_kwota_podwyzki);
            groupBox3.Controls.Add(tb_podwyzka_numer_telefonu);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Location = new Point(434, 190);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(548, 78);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Daj podwyżkę";
            // 
            // btn_daj_podwyzke
            // 
            btn_daj_podwyzke.AutoSize = true;
            btn_daj_podwyzke.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_daj_podwyzke.Location = new Point(429, 22);
            btn_daj_podwyzke.Name = "btn_daj_podwyzke";
            btn_daj_podwyzke.Size = new Size(113, 30);
            btn_daj_podwyzke.TabIndex = 2;
            btn_daj_podwyzke.Text = "Daj podwyżkę";
            btn_daj_podwyzke.UseVisualStyleBackColor = true;
            btn_daj_podwyzke.Click += btn_daj_podwyzke_Click;
            // 
            // tb_podwyzka_kwota_podwyzki
            // 
            tb_podwyzka_kwota_podwyzki.Location = new Point(218, 25);
            tb_podwyzka_kwota_podwyzki.Name = "tb_podwyzka_kwota_podwyzki";
            tb_podwyzka_kwota_podwyzki.PlaceholderText = "Podaj kwotę podwyżki";
            tb_podwyzka_kwota_podwyzki.Size = new Size(205, 27);
            tb_podwyzka_kwota_podwyzki.TabIndex = 1;
            // 
            // tb_podwyzka_numer_telefonu
            // 
            tb_podwyzka_numer_telefonu.Location = new Point(7, 25);
            tb_podwyzka_numer_telefonu.Name = "tb_podwyzka_numer_telefonu";
            tb_podwyzka_numer_telefonu.PlaceholderText = "Podaj numer telefonu";
            tb_podwyzka_numer_telefonu.Size = new Size(205, 27);
            tb_podwyzka_numer_telefonu.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.AutoSize = true;
            groupBox2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox2.Controls.Add(rb_nazwisko_malejaco);
            groupBox2.Controls.Add(rb_imie_rosnaco);
            groupBox2.Controls.Add(rb_stanowisko_rosnaco);
            groupBox2.Controls.Add(rb_stanowisko_malejaco);
            groupBox2.Controls.Add(rb_pensja_malejaco);
            groupBox2.Controls.Add(rb_pensja_rosnaco);
            groupBox2.Controls.Add(rb_imie_malejco);
            groupBox2.Controls.Add(rb_nazwisko_rosnaco);
            groupBox2.Dock = DockStyle.Left;
            groupBox2.Location = new Point(250, 190);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5);
            groupBox2.Size = new Size(184, 362);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sortowanie";
            // 
            // rb_nazwisko_malejaco
            // 
            rb_nazwisko_malejaco.AutoSize = true;
            rb_nazwisko_malejaco.Location = new Point(6, 62);
            rb_nazwisko_malejaco.Name = "rb_nazwisko_malejaco";
            rb_nazwisko_malejaco.Size = new Size(158, 24);
            rb_nazwisko_malejaco.TabIndex = 7;
            rb_nazwisko_malejaco.Text = "Nazwisko malejąco";
            rb_nazwisko_malejaco.UseVisualStyleBackColor = true;
            rb_nazwisko_malejaco.CheckedChanged += btn_wyswietl_liste_Click;
            // 
            // rb_imie_rosnaco
            // 
            rb_imie_rosnaco.AutoSize = true;
            rb_imie_rosnaco.Location = new Point(6, 95);
            rb_imie_rosnaco.Name = "rb_imie_rosnaco";
            rb_imie_rosnaco.Size = new Size(115, 24);
            rb_imie_rosnaco.TabIndex = 6;
            rb_imie_rosnaco.Text = "Imię rosnąco";
            rb_imie_rosnaco.UseVisualStyleBackColor = true;
            rb_imie_rosnaco.CheckedChanged += btn_wyswietl_liste_Click;
            // 
            // rb_stanowisko_rosnaco
            // 
            rb_stanowisko_rosnaco.AutoSize = true;
            rb_stanowisko_rosnaco.Location = new Point(6, 163);
            rb_stanowisko_rosnaco.Name = "rb_stanowisko_rosnaco";
            rb_stanowisko_rosnaco.Size = new Size(161, 24);
            rb_stanowisko_rosnaco.TabIndex = 5;
            rb_stanowisko_rosnaco.Text = "Stanowisko rosnąco";
            rb_stanowisko_rosnaco.UseVisualStyleBackColor = true;
            rb_stanowisko_rosnaco.CheckedChanged += btn_wyswietl_liste_Click;
            // 
            // rb_stanowisko_malejaco
            // 
            rb_stanowisko_malejaco.AutoSize = true;
            rb_stanowisko_malejaco.Location = new Point(6, 196);
            rb_stanowisko_malejaco.Name = "rb_stanowisko_malejaco";
            rb_stanowisko_malejaco.Size = new Size(170, 24);
            rb_stanowisko_malejaco.TabIndex = 4;
            rb_stanowisko_malejaco.Text = "Stanowisko malejąco";
            rb_stanowisko_malejaco.UseVisualStyleBackColor = true;
            rb_stanowisko_malejaco.CheckedChanged += btn_wyswietl_liste_Click;
            // 
            // rb_pensja_malejaco
            // 
            rb_pensja_malejaco.AutoSize = true;
            rb_pensja_malejaco.Location = new Point(6, 256);
            rb_pensja_malejaco.Name = "rb_pensja_malejaco";
            rb_pensja_malejaco.Size = new Size(136, 24);
            rb_pensja_malejaco.TabIndex = 3;
            rb_pensja_malejaco.Text = "Pensja malejąco";
            rb_pensja_malejaco.UseVisualStyleBackColor = true;
            rb_pensja_malejaco.CheckedChanged += btn_wyswietl_liste_Click;
            // 
            // rb_pensja_rosnaco
            // 
            rb_pensja_rosnaco.AutoSize = true;
            rb_pensja_rosnaco.Location = new Point(6, 226);
            rb_pensja_rosnaco.Name = "rb_pensja_rosnaco";
            rb_pensja_rosnaco.Size = new Size(127, 24);
            rb_pensja_rosnaco.TabIndex = 2;
            rb_pensja_rosnaco.Text = "Pensja rosnąco";
            rb_pensja_rosnaco.UseVisualStyleBackColor = true;
            rb_pensja_rosnaco.CheckedChanged += btn_wyswietl_liste_Click;
            // 
            // rb_imie_malejco
            // 
            rb_imie_malejco.AutoSize = true;
            rb_imie_malejco.Location = new Point(6, 130);
            rb_imie_malejco.Name = "rb_imie_malejco";
            rb_imie_malejco.Size = new Size(124, 24);
            rb_imie_malejco.TabIndex = 1;
            rb_imie_malejco.Text = "Imię malejąco";
            rb_imie_malejco.UseVisualStyleBackColor = true;
            rb_imie_malejco.CheckedChanged += btn_wyswietl_liste_Click;
            // 
            // rb_nazwisko_rosnaco
            // 
            rb_nazwisko_rosnaco.AutoSize = true;
            rb_nazwisko_rosnaco.Checked = true;
            rb_nazwisko_rosnaco.Location = new Point(6, 28);
            rb_nazwisko_rosnaco.Name = "rb_nazwisko_rosnaco";
            rb_nazwisko_rosnaco.Size = new Size(149, 24);
            rb_nazwisko_rosnaco.TabIndex = 0;
            rb_nazwisko_rosnaco.TabStop = true;
            rb_nazwisko_rosnaco.Text = "Nazwisko rosnąco";
            rb_nazwisko_rosnaco.UseVisualStyleBackColor = true;
            rb_nazwisko_rosnaco.CheckedChanged += btn_wyswietl_liste_Click;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox1.Controls.Add(btn_dodaj_pracownika);
            groupBox1.Controls.Add(tb_email);
            groupBox1.Controls.Add(tb_pensja);
            groupBox1.Controls.Add(tb_stanowisko);
            groupBox1.Controls.Add(tb_imie);
            groupBox1.Controls.Add(tb_numer_telefonu);
            groupBox1.Controls.Add(tb_nazwisko);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 190);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(250, 362);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dodaj pracownika";
            // 
            // btn_dodaj_pracownika
            // 
            btn_dodaj_pracownika.Location = new Point(12, 254);
            btn_dodaj_pracownika.Name = "btn_dodaj_pracownika";
            btn_dodaj_pracownika.Size = new Size(230, 29);
            btn_dodaj_pracownika.TabIndex = 7;
            btn_dodaj_pracownika.Text = "Dodaj pracownika";
            btn_dodaj_pracownika.UseVisualStyleBackColor = true;
            btn_dodaj_pracownika.Click += btn_dodaj_pracownika_Click;
            // 
            // tb_email
            // 
            tb_email.Location = new Point(12, 127);
            tb_email.Name = "tb_email";
            tb_email.PlaceholderText = "Podaj email";
            tb_email.Size = new Size(230, 27);
            tb_email.TabIndex = 6;
            // 
            // tb_pensja
            // 
            tb_pensja.Location = new Point(12, 193);
            tb_pensja.Name = "tb_pensja";
            tb_pensja.PlaceholderText = "Podaj pensje";
            tb_pensja.Size = new Size(230, 27);
            tb_pensja.TabIndex = 5;
            // 
            // tb_stanowisko
            // 
            tb_stanowisko.Location = new Point(12, 160);
            tb_stanowisko.Name = "tb_stanowisko";
            tb_stanowisko.PlaceholderText = "Podaj stanowisko";
            tb_stanowisko.Size = new Size(230, 27);
            tb_stanowisko.TabIndex = 4;
            // 
            // tb_imie
            // 
            tb_imie.Location = new Point(12, 61);
            tb_imie.Name = "tb_imie";
            tb_imie.PlaceholderText = "Podaj imię";
            tb_imie.Size = new Size(230, 27);
            tb_imie.TabIndex = 3;
            // 
            // tb_numer_telefonu
            // 
            tb_numer_telefonu.Location = new Point(12, 94);
            tb_numer_telefonu.Name = "tb_numer_telefonu";
            tb_numer_telefonu.PlaceholderText = "Podaj numer telefonu";
            tb_numer_telefonu.Size = new Size(230, 27);
            tb_numer_telefonu.TabIndex = 2;
            // 
            // tb_nazwisko
            // 
            tb_nazwisko.Location = new Point(12, 28);
            tb_nazwisko.Name = "tb_nazwisko";
            tb_nazwisko.PlaceholderText = "Podaj nazwisko";
            tb_nazwisko.Size = new Size(230, 27);
            tb_nazwisko.TabIndex = 1;
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
            Load += btn_wyswietl_liste_Click;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)data_pracownicy).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_cofnij;
        private Label label1;
        private Panel panel1;
        private DataGridView data_pracownicy;
        private GroupBox groupBox1;
        private TextBox tb_imie;
        private TextBox tb_numer_telefonu;
        private TextBox tb_nazwisko;
        private TextBox tb_email;
        private TextBox tb_pensja;
        private TextBox tb_stanowisko;
        private Button btn_dodaj_pracownika;
        private GroupBox groupBox2;
        private RadioButton rb_nazwisko_rosnaco;
        private RadioButton rb_nazwisko_malejaco;
        private RadioButton rb_imie_rosnaco;
        private RadioButton rb_stanowisko_rosnaco;
        private RadioButton rb_stanowisko_malejaco;
        private RadioButton rb_pensja_malejaco;
        private RadioButton rb_pensja_rosnaco;
        private RadioButton rb_imie_malejco;
        private GroupBox groupBox3;
        private TextBox tb_podwyzka_kwota_podwyzki;
        private TextBox tb_podwyzka_numer_telefonu;
        private Button btn_daj_podwyzke;
        private GroupBox groupBox4;
        private TextBox tb_filtruj_nazwisko;
        private TextBox tb_filtruj_imie;
        private Button btn_resetuj_filtry;
        private TextBox tb_filtruj_stanowisko;
        private TextBox tb_filtruj_pensja_maksymalna;
        private TextBox tb_filtruj_pensja_minimalna;
        private TextBox tb_filtruj_email;
        private TextBox tb_filtruj_numer_telefonu;
        private Button btn_zastosuj_filtry;
    }
}