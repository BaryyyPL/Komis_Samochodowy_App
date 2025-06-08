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
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            groupBox3 = new GroupBox();
            cb_sprzedaj_klient = new ComboBox();
            tb_sprzedaj_vin = new TextBox();
            btn_sprzedaj = new Button();
            groupBox2 = new GroupBox();
            tb_zmien_cena = new TextBox();
            btn_zmien_cene = new Button();
            tb_zmien_vin = new TextBox();
            groupBox1 = new GroupBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            rb_filtruj_cena = new RadioButton();
            rb_filtruj_marka = new RadioButton();
            rb_filtruj_przebieg = new RadioButton();
            rb_filtruj_rocznik = new RadioButton();
            rb_filtruj_moc = new RadioButton();
            cb_filtruj_malejaco = new CheckBox();
            groupBox4 = new GroupBox();
            flowLayoutPanel3 = new FlowLayoutPanel();
            tb_marka = new TextBox();
            tb_model = new TextBox();
            tb_cena = new TextBox();
            tb_rok_produkcji = new TextBox();
            tb_przebieg = new TextBox();
            tb_vin = new TextBox();
            tb_pojemnosc_silnika = new TextBox();
            tb_moc = new TextBox();
            tb_kolor = new TextBox();
            cb_rodzaj_paliwa = new ComboBox();
            cb_skrzynia_biegow = new ComboBox();
            cb_kraj_pochodzenia = new ComboBox();
            cb_rodzaj_napedu = new ComboBox();
            cb_rodzaj_nadwozia = new ComboBox();
            cb_uszkodzony = new CheckBox();
            btn_dodaj = new Button();
            groupBox5 = new GroupBox();
            flowLayoutPanel4 = new FlowLayoutPanel();
            tb_filtruj_marka = new TextBox();
            tb_filtruj_model = new TextBox();
            tb_minimalna_cena = new TextBox();
            tb_maksymalna_cena = new TextBox();
            tb_minimalny_rok = new TextBox();
            tb_maksymalny_rok = new TextBox();
            tb_minimalny_przebieg = new TextBox();
            tb_maksymalny_przebieg = new TextBox();
            tb_filtruj_vin = new TextBox();
            tb_minimalna_pojemnosc = new TextBox();
            tb_maksymalna_pojemnosc = new TextBox();
            tb_minimalna_moc = new TextBox();
            tb_maksymalna_moc = new TextBox();
            tb_filtruj_kolor = new TextBox();
            cb_filtruj_rodzaj_paliwa = new ComboBox();
            cb_filtruj_skrzynia_biegow = new ComboBox();
            cb_filtruj_kraj_pochodzenia = new ComboBox();
            cb_filtruj_rodzaj_napedu = new ComboBox();
            cb_filtruj_rodzaj_nadwozia = new ComboBox();
            cb_filtruj_wlasciciel = new ComboBox();
            cb_filtruj_nieuszkodzony = new CheckBox();
            cb_filtruj_sprzedany = new CheckBox();
            btn_filtruj_zastosuj = new Button();
            btn_filtruj_resetuj = new Button();
            data_samochody_osobowe = new DataGridView();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            groupBox4.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            groupBox5.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
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
            btn_cofnij.Size = new Size(983, 29);
            btn_cofnij.TabIndex = 2;
            btn_cofnij.Text = "Cofnij";
            btn_cofnij.UseVisualStyleBackColor = true;
            btn_cofnij.Click += btn_cofnij_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(data_samochody_osobowe);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(983, 552);
            panel1.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(groupBox4);
            flowLayoutPanel1.Controls.Add(groupBox5);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 190);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(983, 362);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.Controls.Add(groupBox3);
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(groupBox1);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(979, 104);
            panel2.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cb_sprzedaj_klient);
            groupBox3.Controls.Add(tb_sprzedaj_vin);
            groupBox3.Controls.Add(btn_sprzedaj);
            groupBox3.Location = new Point(611, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(365, 98);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Sprzedaj";
            // 
            // cb_sprzedaj_klient
            // 
            cb_sprzedaj_klient.FormattingEnabled = true;
            cb_sprzedaj_klient.Location = new Point(142, 27);
            cb_sprzedaj_klient.Name = "cb_sprzedaj_klient";
            cb_sprzedaj_klient.Size = new Size(214, 28);
            cb_sprzedaj_klient.TabIndex = 5;
            // 
            // tb_sprzedaj_vin
            // 
            tb_sprzedaj_vin.Location = new Point(6, 27);
            tb_sprzedaj_vin.Name = "tb_sprzedaj_vin";
            tb_sprzedaj_vin.PlaceholderText = "VIN";
            tb_sprzedaj_vin.Size = new Size(117, 27);
            tb_sprzedaj_vin.TabIndex = 4;
            // 
            // btn_sprzedaj
            // 
            btn_sprzedaj.Location = new Point(142, 61);
            btn_sprzedaj.Name = "btn_sprzedaj";
            btn_sprzedaj.Size = new Size(94, 29);
            btn_sprzedaj.TabIndex = 2;
            btn_sprzedaj.Text = "Sprzedaj";
            btn_sprzedaj.UseVisualStyleBackColor = true;
            btn_sprzedaj.Click += btn_sprzedaj_Click;
            // 
            // groupBox2
            // 
            groupBox2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox2.Controls.Add(tb_zmien_cena);
            groupBox2.Controls.Add(btn_zmien_cene);
            groupBox2.Controls.Add(tb_zmien_vin);
            groupBox2.Location = new Point(329, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(276, 98);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Zmień cenę";
            // 
            // tb_zmien_cena
            // 
            tb_zmien_cena.Location = new Point(147, 25);
            tb_zmien_cena.Name = "tb_zmien_cena";
            tb_zmien_cena.PlaceholderText = "Nowa cena";
            tb_zmien_cena.Size = new Size(120, 27);
            tb_zmien_cena.TabIndex = 3;
            // 
            // btn_zmien_cene
            // 
            btn_zmien_cene.Location = new Point(88, 61);
            btn_zmien_cene.Name = "btn_zmien_cene";
            btn_zmien_cene.Size = new Size(94, 29);
            btn_zmien_cene.TabIndex = 2;
            btn_zmien_cene.Text = "Zmień cenę";
            btn_zmien_cene.UseVisualStyleBackColor = true;
            btn_zmien_cene.Click += btn_zmien_cene_Click;
            // 
            // tb_zmien_vin
            // 
            tb_zmien_vin.Location = new Point(6, 25);
            tb_zmien_vin.Name = "tb_zmien_vin";
            tb_zmien_vin.PlaceholderText = "VIN";
            tb_zmien_vin.Size = new Size(135, 27);
            tb_zmien_vin.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox1.Controls.Add(flowLayoutPanel2);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(323, 98);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sortowanie";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel2.Controls.Add(rb_filtruj_cena);
            flowLayoutPanel2.Controls.Add(rb_filtruj_marka);
            flowLayoutPanel2.Controls.Add(rb_filtruj_przebieg);
            flowLayoutPanel2.Controls.Add(rb_filtruj_rocznik);
            flowLayoutPanel2.Controls.Add(rb_filtruj_moc);
            flowLayoutPanel2.Controls.Add(cb_filtruj_malejaco);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(3, 23);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(317, 72);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // rb_filtruj_cena
            // 
            rb_filtruj_cena.AutoSize = true;
            rb_filtruj_cena.Checked = true;
            rb_filtruj_cena.Location = new Point(3, 3);
            rb_filtruj_cena.Name = "rb_filtruj_cena";
            rb_filtruj_cena.Size = new Size(85, 24);
            rb_filtruj_cena.TabIndex = 0;
            rb_filtruj_cena.TabStop = true;
            rb_filtruj_cena.Text = "Po cenie";
            rb_filtruj_cena.UseVisualStyleBackColor = true;
            rb_filtruj_cena.CheckedChanged += btn_wyswietl_liste_Click;
            // 
            // rb_filtruj_marka
            // 
            rb_filtruj_marka.AutoSize = true;
            rb_filtruj_marka.Location = new Point(94, 3);
            rb_filtruj_marka.Name = "rb_filtruj_marka";
            rb_filtruj_marka.Size = new Size(91, 24);
            rb_filtruj_marka.TabIndex = 1;
            rb_filtruj_marka.Text = "Po marce";
            rb_filtruj_marka.UseVisualStyleBackColor = true;
            rb_filtruj_marka.CheckedChanged += btn_wyswietl_liste_Click;
            // 
            // rb_filtruj_przebieg
            // 
            rb_filtruj_przebieg.AutoSize = true;
            rb_filtruj_przebieg.Location = new Point(191, 3);
            rb_filtruj_przebieg.Name = "rb_filtruj_przebieg";
            rb_filtruj_przebieg.Size = new Size(117, 24);
            rb_filtruj_przebieg.TabIndex = 2;
            rb_filtruj_przebieg.Text = "Po przebiegu";
            rb_filtruj_przebieg.UseVisualStyleBackColor = true;
            rb_filtruj_przebieg.CheckedChanged += btn_wyswietl_liste_Click;
            // 
            // rb_filtruj_rocznik
            // 
            rb_filtruj_rocznik.AutoSize = true;
            rb_filtruj_rocznik.Location = new Point(3, 33);
            rb_filtruj_rocznik.Name = "rb_filtruj_rocznik";
            rb_filtruj_rocznik.Size = new Size(105, 24);
            rb_filtruj_rocznik.TabIndex = 3;
            rb_filtruj_rocznik.Text = "Po roczniku";
            rb_filtruj_rocznik.UseVisualStyleBackColor = true;
            rb_filtruj_rocznik.CheckedChanged += btn_wyswietl_liste_Click;
            // 
            // rb_filtruj_moc
            // 
            rb_filtruj_moc.AutoSize = true;
            rb_filtruj_moc.Location = new Point(114, 33);
            rb_filtruj_moc.Name = "rb_filtruj_moc";
            rb_filtruj_moc.Size = new Size(86, 24);
            rb_filtruj_moc.TabIndex = 4;
            rb_filtruj_moc.Text = "Po mocy";
            rb_filtruj_moc.UseVisualStyleBackColor = true;
            rb_filtruj_moc.CheckedChanged += btn_wyswietl_liste_Click;
            // 
            // cb_filtruj_malejaco
            // 
            cb_filtruj_malejaco.AutoSize = true;
            cb_filtruj_malejaco.Location = new Point(206, 33);
            cb_filtruj_malejaco.Name = "cb_filtruj_malejaco";
            cb_filtruj_malejaco.Size = new Size(92, 24);
            cb_filtruj_malejaco.TabIndex = 7;
            cb_filtruj_malejaco.Text = "Malejąco";
            cb_filtruj_malejaco.UseVisualStyleBackColor = true;
            cb_filtruj_malejaco.CheckedChanged += btn_wyswietl_liste_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(flowLayoutPanel3);
            groupBox4.Dock = DockStyle.Top;
            groupBox4.Location = new Point(3, 113);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(979, 98);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Dodaj";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(tb_marka);
            flowLayoutPanel3.Controls.Add(tb_model);
            flowLayoutPanel3.Controls.Add(tb_cena);
            flowLayoutPanel3.Controls.Add(tb_rok_produkcji);
            flowLayoutPanel3.Controls.Add(tb_przebieg);
            flowLayoutPanel3.Controls.Add(tb_vin);
            flowLayoutPanel3.Controls.Add(tb_pojemnosc_silnika);
            flowLayoutPanel3.Controls.Add(tb_moc);
            flowLayoutPanel3.Controls.Add(tb_kolor);
            flowLayoutPanel3.Controls.Add(cb_rodzaj_paliwa);
            flowLayoutPanel3.Controls.Add(cb_skrzynia_biegow);
            flowLayoutPanel3.Controls.Add(cb_kraj_pochodzenia);
            flowLayoutPanel3.Controls.Add(cb_rodzaj_napedu);
            flowLayoutPanel3.Controls.Add(cb_rodzaj_nadwozia);
            flowLayoutPanel3.Controls.Add(cb_uszkodzony);
            flowLayoutPanel3.Controls.Add(btn_dodaj);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.Location = new Point(3, 23);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(973, 72);
            flowLayoutPanel3.TabIndex = 0;
            // 
            // tb_marka
            // 
            tb_marka.Location = new Point(3, 3);
            tb_marka.Name = "tb_marka";
            tb_marka.PlaceholderText = "Marka";
            tb_marka.Size = new Size(115, 27);
            tb_marka.TabIndex = 0;
            // 
            // tb_model
            // 
            tb_model.Location = new Point(124, 3);
            tb_model.Name = "tb_model";
            tb_model.PlaceholderText = "Model";
            tb_model.Size = new Size(115, 27);
            tb_model.TabIndex = 1;
            // 
            // tb_cena
            // 
            tb_cena.Location = new Point(245, 3);
            tb_cena.Name = "tb_cena";
            tb_cena.PlaceholderText = "Cena";
            tb_cena.Size = new Size(115, 27);
            tb_cena.TabIndex = 2;
            // 
            // tb_rok_produkcji
            // 
            tb_rok_produkcji.Location = new Point(366, 3);
            tb_rok_produkcji.Name = "tb_rok_produkcji";
            tb_rok_produkcji.PlaceholderText = "Rok produkcji";
            tb_rok_produkcji.Size = new Size(115, 27);
            tb_rok_produkcji.TabIndex = 3;
            // 
            // tb_przebieg
            // 
            tb_przebieg.Location = new Point(487, 3);
            tb_przebieg.Name = "tb_przebieg";
            tb_przebieg.PlaceholderText = "Przebieg";
            tb_przebieg.Size = new Size(115, 27);
            tb_przebieg.TabIndex = 4;
            // 
            // tb_vin
            // 
            tb_vin.Location = new Point(608, 3);
            tb_vin.Name = "tb_vin";
            tb_vin.PlaceholderText = "VIN";
            tb_vin.Size = new Size(115, 27);
            tb_vin.TabIndex = 5;
            // 
            // tb_pojemnosc_silnika
            // 
            tb_pojemnosc_silnika.Location = new Point(729, 3);
            tb_pojemnosc_silnika.Name = "tb_pojemnosc_silnika";
            tb_pojemnosc_silnika.PlaceholderText = "Pojemność silnika";
            tb_pojemnosc_silnika.Size = new Size(115, 27);
            tb_pojemnosc_silnika.TabIndex = 6;
            // 
            // tb_moc
            // 
            tb_moc.Location = new Point(850, 3);
            tb_moc.Name = "tb_moc";
            tb_moc.PlaceholderText = "Moc";
            tb_moc.Size = new Size(115, 27);
            tb_moc.TabIndex = 7;
            // 
            // tb_kolor
            // 
            tb_kolor.Location = new Point(3, 36);
            tb_kolor.Name = "tb_kolor";
            tb_kolor.PlaceholderText = "Kolor";
            tb_kolor.Size = new Size(115, 27);
            tb_kolor.TabIndex = 8;
            // 
            // cb_rodzaj_paliwa
            // 
            cb_rodzaj_paliwa.FormattingEnabled = true;
            cb_rodzaj_paliwa.Location = new Point(124, 36);
            cb_rodzaj_paliwa.Name = "cb_rodzaj_paliwa";
            cb_rodzaj_paliwa.Size = new Size(115, 28);
            cb_rodzaj_paliwa.TabIndex = 9;
            // 
            // cb_skrzynia_biegow
            // 
            cb_skrzynia_biegow.FormattingEnabled = true;
            cb_skrzynia_biegow.Location = new Point(245, 36);
            cb_skrzynia_biegow.Name = "cb_skrzynia_biegow";
            cb_skrzynia_biegow.Size = new Size(115, 28);
            cb_skrzynia_biegow.TabIndex = 10;
            // 
            // cb_kraj_pochodzenia
            // 
            cb_kraj_pochodzenia.FormattingEnabled = true;
            cb_kraj_pochodzenia.Location = new Point(366, 36);
            cb_kraj_pochodzenia.Name = "cb_kraj_pochodzenia";
            cb_kraj_pochodzenia.Size = new Size(115, 28);
            cb_kraj_pochodzenia.TabIndex = 11;
            // 
            // cb_rodzaj_napedu
            // 
            cb_rodzaj_napedu.FormattingEnabled = true;
            cb_rodzaj_napedu.Location = new Point(487, 36);
            cb_rodzaj_napedu.Name = "cb_rodzaj_napedu";
            cb_rodzaj_napedu.Size = new Size(115, 28);
            cb_rodzaj_napedu.TabIndex = 12;
            // 
            // cb_rodzaj_nadwozia
            // 
            cb_rodzaj_nadwozia.FormattingEnabled = true;
            cb_rodzaj_nadwozia.Location = new Point(608, 36);
            cb_rodzaj_nadwozia.Name = "cb_rodzaj_nadwozia";
            cb_rodzaj_nadwozia.Size = new Size(115, 28);
            cb_rodzaj_nadwozia.TabIndex = 13;
            // 
            // cb_uszkodzony
            // 
            cb_uszkodzony.AutoSize = true;
            cb_uszkodzony.Location = new Point(729, 36);
            cb_uszkodzony.Name = "cb_uszkodzony";
            cb_uszkodzony.Size = new Size(110, 24);
            cb_uszkodzony.TabIndex = 14;
            cb_uszkodzony.Text = "Uszkodzony";
            cb_uszkodzony.UseVisualStyleBackColor = true;
            // 
            // btn_dodaj
            // 
            btn_dodaj.Location = new Point(845, 36);
            btn_dodaj.Name = "btn_dodaj";
            btn_dodaj.Size = new Size(115, 28);
            btn_dodaj.TabIndex = 15;
            btn_dodaj.Text = "Dodaj";
            btn_dodaj.UseVisualStyleBackColor = true;
            btn_dodaj.Click += btn_dodaj_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(flowLayoutPanel4);
            groupBox5.Location = new Point(3, 217);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(976, 139);
            groupBox5.TabIndex = 3;
            groupBox5.TabStop = false;
            groupBox5.Text = "Filtracja";
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(tb_filtruj_marka);
            flowLayoutPanel4.Controls.Add(tb_filtruj_model);
            flowLayoutPanel4.Controls.Add(tb_minimalna_cena);
            flowLayoutPanel4.Controls.Add(tb_maksymalna_cena);
            flowLayoutPanel4.Controls.Add(tb_minimalny_rok);
            flowLayoutPanel4.Controls.Add(tb_maksymalny_rok);
            flowLayoutPanel4.Controls.Add(tb_minimalny_przebieg);
            flowLayoutPanel4.Controls.Add(tb_maksymalny_przebieg);
            flowLayoutPanel4.Controls.Add(tb_filtruj_vin);
            flowLayoutPanel4.Controls.Add(tb_minimalna_pojemnosc);
            flowLayoutPanel4.Controls.Add(tb_maksymalna_pojemnosc);
            flowLayoutPanel4.Controls.Add(tb_minimalna_moc);
            flowLayoutPanel4.Controls.Add(tb_maksymalna_moc);
            flowLayoutPanel4.Controls.Add(tb_filtruj_kolor);
            flowLayoutPanel4.Controls.Add(cb_filtruj_rodzaj_paliwa);
            flowLayoutPanel4.Controls.Add(cb_filtruj_skrzynia_biegow);
            flowLayoutPanel4.Controls.Add(cb_filtruj_kraj_pochodzenia);
            flowLayoutPanel4.Controls.Add(cb_filtruj_rodzaj_napedu);
            flowLayoutPanel4.Controls.Add(cb_filtruj_rodzaj_nadwozia);
            flowLayoutPanel4.Controls.Add(cb_filtruj_wlasciciel);
            flowLayoutPanel4.Controls.Add(cb_filtruj_nieuszkodzony);
            flowLayoutPanel4.Controls.Add(cb_filtruj_sprzedany);
            flowLayoutPanel4.Controls.Add(btn_filtruj_zastosuj);
            flowLayoutPanel4.Controls.Add(btn_filtruj_resetuj);
            flowLayoutPanel4.Dock = DockStyle.Fill;
            flowLayoutPanel4.Location = new Point(3, 23);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(970, 113);
            flowLayoutPanel4.TabIndex = 0;
            // 
            // tb_filtruj_marka
            // 
            tb_filtruj_marka.Location = new Point(3, 3);
            tb_filtruj_marka.Name = "tb_filtruj_marka";
            tb_filtruj_marka.PlaceholderText = "Marka";
            tb_filtruj_marka.Size = new Size(115, 27);
            tb_filtruj_marka.TabIndex = 1;
            // 
            // tb_filtruj_model
            // 
            tb_filtruj_model.Location = new Point(124, 3);
            tb_filtruj_model.Name = "tb_filtruj_model";
            tb_filtruj_model.PlaceholderText = "Model";
            tb_filtruj_model.Size = new Size(115, 27);
            tb_filtruj_model.TabIndex = 2;
            // 
            // tb_minimalna_cena
            // 
            tb_minimalna_cena.Location = new Point(245, 3);
            tb_minimalna_cena.Name = "tb_minimalna_cena";
            tb_minimalna_cena.PlaceholderText = "Min. cena";
            tb_minimalna_cena.Size = new Size(115, 27);
            tb_minimalna_cena.TabIndex = 3;
            // 
            // tb_maksymalna_cena
            // 
            tb_maksymalna_cena.Location = new Point(366, 3);
            tb_maksymalna_cena.Name = "tb_maksymalna_cena";
            tb_maksymalna_cena.PlaceholderText = "Maks. cena";
            tb_maksymalna_cena.Size = new Size(115, 27);
            tb_maksymalna_cena.TabIndex = 4;
            // 
            // tb_minimalny_rok
            // 
            tb_minimalny_rok.Location = new Point(487, 3);
            tb_minimalny_rok.Name = "tb_minimalny_rok";
            tb_minimalny_rok.PlaceholderText = "Min. rok";
            tb_minimalny_rok.Size = new Size(115, 27);
            tb_minimalny_rok.TabIndex = 5;
            // 
            // tb_maksymalny_rok
            // 
            tb_maksymalny_rok.Location = new Point(608, 3);
            tb_maksymalny_rok.Name = "tb_maksymalny_rok";
            tb_maksymalny_rok.PlaceholderText = "Maks. rok";
            tb_maksymalny_rok.Size = new Size(115, 27);
            tb_maksymalny_rok.TabIndex = 6;
            // 
            // tb_minimalny_przebieg
            // 
            tb_minimalny_przebieg.Location = new Point(729, 3);
            tb_minimalny_przebieg.Name = "tb_minimalny_przebieg";
            tb_minimalny_przebieg.PlaceholderText = "Min. przebieg";
            tb_minimalny_przebieg.Size = new Size(115, 27);
            tb_minimalny_przebieg.TabIndex = 7;
            // 
            // tb_maksymalny_przebieg
            // 
            tb_maksymalny_przebieg.Location = new Point(850, 3);
            tb_maksymalny_przebieg.Name = "tb_maksymalny_przebieg";
            tb_maksymalny_przebieg.PlaceholderText = "Maks. przebieg";
            tb_maksymalny_przebieg.Size = new Size(115, 27);
            tb_maksymalny_przebieg.TabIndex = 8;
            // 
            // tb_filtruj_vin
            // 
            tb_filtruj_vin.Location = new Point(3, 36);
            tb_filtruj_vin.Name = "tb_filtruj_vin";
            tb_filtruj_vin.PlaceholderText = "VIN";
            tb_filtruj_vin.Size = new Size(115, 27);
            tb_filtruj_vin.TabIndex = 9;
            // 
            // tb_minimalna_pojemnosc
            // 
            tb_minimalna_pojemnosc.Location = new Point(124, 36);
            tb_minimalna_pojemnosc.Name = "tb_minimalna_pojemnosc";
            tb_minimalna_pojemnosc.PlaceholderText = "Min. pojemność";
            tb_minimalna_pojemnosc.Size = new Size(115, 27);
            tb_minimalna_pojemnosc.TabIndex = 10;
            // 
            // tb_maksymalna_pojemnosc
            // 
            tb_maksymalna_pojemnosc.Location = new Point(245, 36);
            tb_maksymalna_pojemnosc.Name = "tb_maksymalna_pojemnosc";
            tb_maksymalna_pojemnosc.PlaceholderText = "Maks. pojemność";
            tb_maksymalna_pojemnosc.Size = new Size(115, 27);
            tb_maksymalna_pojemnosc.TabIndex = 11;
            // 
            // tb_minimalna_moc
            // 
            tb_minimalna_moc.Location = new Point(366, 36);
            tb_minimalna_moc.Name = "tb_minimalna_moc";
            tb_minimalna_moc.PlaceholderText = "Min. moc";
            tb_minimalna_moc.Size = new Size(115, 27);
            tb_minimalna_moc.TabIndex = 12;
            // 
            // tb_maksymalna_moc
            // 
            tb_maksymalna_moc.Location = new Point(487, 36);
            tb_maksymalna_moc.Name = "tb_maksymalna_moc";
            tb_maksymalna_moc.PlaceholderText = "Maks. moc";
            tb_maksymalna_moc.Size = new Size(115, 27);
            tb_maksymalna_moc.TabIndex = 13;
            // 
            // tb_filtruj_kolor
            // 
            tb_filtruj_kolor.Location = new Point(608, 36);
            tb_filtruj_kolor.Name = "tb_filtruj_kolor";
            tb_filtruj_kolor.PlaceholderText = "Kolor";
            tb_filtruj_kolor.Size = new Size(115, 27);
            tb_filtruj_kolor.TabIndex = 14;
            // 
            // cb_filtruj_rodzaj_paliwa
            // 
            cb_filtruj_rodzaj_paliwa.FormattingEnabled = true;
            cb_filtruj_rodzaj_paliwa.Location = new Point(729, 36);
            cb_filtruj_rodzaj_paliwa.Name = "cb_filtruj_rodzaj_paliwa";
            cb_filtruj_rodzaj_paliwa.Size = new Size(115, 28);
            cb_filtruj_rodzaj_paliwa.TabIndex = 15;
            // 
            // cb_filtruj_skrzynia_biegow
            // 
            cb_filtruj_skrzynia_biegow.FormattingEnabled = true;
            cb_filtruj_skrzynia_biegow.Location = new Point(850, 36);
            cb_filtruj_skrzynia_biegow.Name = "cb_filtruj_skrzynia_biegow";
            cb_filtruj_skrzynia_biegow.Size = new Size(115, 28);
            cb_filtruj_skrzynia_biegow.TabIndex = 16;
            // 
            // cb_filtruj_kraj_pochodzenia
            // 
            cb_filtruj_kraj_pochodzenia.FormattingEnabled = true;
            cb_filtruj_kraj_pochodzenia.Location = new Point(3, 70);
            cb_filtruj_kraj_pochodzenia.Name = "cb_filtruj_kraj_pochodzenia";
            cb_filtruj_kraj_pochodzenia.Size = new Size(115, 28);
            cb_filtruj_kraj_pochodzenia.TabIndex = 17;
            // 
            // cb_filtruj_rodzaj_napedu
            // 
            cb_filtruj_rodzaj_napedu.FormattingEnabled = true;
            cb_filtruj_rodzaj_napedu.Location = new Point(124, 70);
            cb_filtruj_rodzaj_napedu.Name = "cb_filtruj_rodzaj_napedu";
            cb_filtruj_rodzaj_napedu.Size = new Size(115, 28);
            cb_filtruj_rodzaj_napedu.TabIndex = 18;
            // 
            // cb_filtruj_rodzaj_nadwozia
            // 
            cb_filtruj_rodzaj_nadwozia.FormattingEnabled = true;
            cb_filtruj_rodzaj_nadwozia.Location = new Point(245, 70);
            cb_filtruj_rodzaj_nadwozia.Name = "cb_filtruj_rodzaj_nadwozia";
            cb_filtruj_rodzaj_nadwozia.Size = new Size(115, 28);
            cb_filtruj_rodzaj_nadwozia.TabIndex = 19;
            // 
            // cb_filtruj_wlasciciel
            // 
            cb_filtruj_wlasciciel.FormattingEnabled = true;
            cb_filtruj_wlasciciel.Location = new Point(366, 70);
            cb_filtruj_wlasciciel.Name = "cb_filtruj_wlasciciel";
            cb_filtruj_wlasciciel.Size = new Size(115, 28);
            cb_filtruj_wlasciciel.TabIndex = 20;
            // 
            // cb_filtruj_nieuszkodzony
            // 
            cb_filtruj_nieuszkodzony.AutoSize = true;
            cb_filtruj_nieuszkodzony.Location = new Point(487, 70);
            cb_filtruj_nieuszkodzony.Name = "cb_filtruj_nieuszkodzony";
            cb_filtruj_nieuszkodzony.Size = new Size(123, 24);
            cb_filtruj_nieuszkodzony.TabIndex = 21;
            cb_filtruj_nieuszkodzony.Text = "Nieszkodzony";
            cb_filtruj_nieuszkodzony.UseVisualStyleBackColor = true;
            // 
            // cb_filtruj_sprzedany
            // 
            cb_filtruj_sprzedany.AutoSize = true;
            cb_filtruj_sprzedany.Location = new Point(616, 70);
            cb_filtruj_sprzedany.Name = "cb_filtruj_sprzedany";
            cb_filtruj_sprzedany.Size = new Size(100, 24);
            cb_filtruj_sprzedany.TabIndex = 24;
            cb_filtruj_sprzedany.Text = "Sprzedany";
            cb_filtruj_sprzedany.UseVisualStyleBackColor = true;
            // 
            // btn_filtruj_zastosuj
            // 
            btn_filtruj_zastosuj.Location = new Point(722, 70);
            btn_filtruj_zastosuj.Name = "btn_filtruj_zastosuj";
            btn_filtruj_zastosuj.Size = new Size(115, 28);
            btn_filtruj_zastosuj.TabIndex = 22;
            btn_filtruj_zastosuj.Text = "Zastosuj";
            btn_filtruj_zastosuj.UseVisualStyleBackColor = true;
            btn_filtruj_zastosuj.Click += btn_filtruj_zastosuj_Click;
            // 
            // btn_filtruj_resetuj
            // 
            btn_filtruj_resetuj.Location = new Point(843, 70);
            btn_filtruj_resetuj.Name = "btn_filtruj_resetuj";
            btn_filtruj_resetuj.Size = new Size(115, 28);
            btn_filtruj_resetuj.TabIndex = 23;
            btn_filtruj_resetuj.Text = "Resetuj";
            btn_filtruj_resetuj.UseVisualStyleBackColor = true;
            btn_filtruj_resetuj.Click += btn_filtruj_resetuj_Click;
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
            data_samochody_osobowe.Size = new Size(983, 190);
            data_samochody_osobowe.TabIndex = 2;
            // 
            // Samochody_Osobowe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 653);
            Controls.Add(panel1);
            Controls.Add(btn_cofnij);
            Controls.Add(label1);
            Name = "Samochody_Osobowe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Samochody Osobowe";
            Load += Samochody_Osobowe_Load;
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            groupBox4.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            groupBox5.ResumeLayout(false);
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)data_samochody_osobowe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_cofnij;
        private Panel panel1;
        private DataGridView data_samochody_osobowe;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private GroupBox groupBox1;
        private FlowLayoutPanel flowLayoutPanel2;
        private RadioButton rb_filtruj_cena;
        private RadioButton rb_filtruj_marka;
        private RadioButton rb_filtruj_przebieg;
        private RadioButton rb_filtruj_rocznik;
        private RadioButton rb_filtruj_moc;
        private RadioButton radioButton6;
        private RadioButton radioButton7;
        private CheckBox cb_filtruj_malejaco;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btn_sprzedaj;
        private Button btn_zmien_cene;
        private TextBox tb_zmien_vin;
        private ComboBox cb_sprzedaj_klient;
        private TextBox tb_sprzedaj_vin;
        private TextBox tb_zmien_cena;
        private GroupBox groupBox4;
        private FlowLayoutPanel flowLayoutPanel3;
        private TextBox tb_marka;
        private TextBox tb_model;
        private TextBox tb_cena;
        private TextBox tb_rok_produkcji;
        private TextBox tb_przebieg;
        private TextBox tb_vin;
        private TextBox tb_pojemnosc_silnika;
        private TextBox tb_moc;
        private TextBox tb_kolor;
        private ComboBox cb_rodzaj_paliwa;
        private ComboBox cb_skrzynia_biegow;
        private ComboBox cb_kraj_pochodzenia;
        private ComboBox cb_rodzaj_napedu;
        private ComboBox cb_rodzaj_nadwozia;
        private CheckBox cb_uszkodzony;
        private Button btn_dodaj;
        private GroupBox groupBox5;
        private FlowLayoutPanel flowLayoutPanel4;
        private TextBox tb_filtruj_marka;
        private TextBox tb_filtruj_model;
        private TextBox tb_minimalna_cena;
        private TextBox tb_maksymalna_cena;
        private TextBox tb_minimalny_rok;
        private TextBox tb_maksymalny_rok;
        private TextBox tb_minimalny_przebieg;
        private TextBox tb_maksymalny_przebieg;
        private TextBox tb_filtruj_vin;
        private TextBox tb_minimalna_pojemnosc;
        private TextBox tb_maksymalna_pojemnosc;
        private TextBox tb_minimalna_moc;
        private TextBox tb_maksymalna_moc;
        private TextBox tb_filtruj_kolor;
        private ComboBox cb_filtruj_rodzaj_paliwa;
        private ComboBox cb_filtruj_skrzynia_biegow;
        private ComboBox cb_filtruj_kraj_pochodzenia;
        private ComboBox cb_filtruj_rodzaj_napedu;
        private ComboBox cb_filtruj_rodzaj_nadwozia;
        private ComboBox cb_filtruj_wlasciciel;
        private CheckBox cb_filtruj_nieuszkodzony;
        private Button btn_filtruj_zastosuj;
        private Button btn_filtruj_resetuj;
        private CheckBox cb_filtruj_sprzedany;
    }
}