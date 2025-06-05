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
            groupBox4 = new GroupBox();
            btn_resetuj_filtry = new Button();
            cb_filtruj_newsletter = new CheckBox();
            tb_filtruj_email = new TextBox();
            tb_filtruj_numer_telefonu = new TextBox();
            tb_filtruj_imie = new TextBox();
            tb_filtruj_nazwisko = new TextBox();
            groupBox3 = new GroupBox();
            rb_nazwisko_malejaco = new RadioButton();
            rb_imie_rosnaco = new RadioButton();
            rb_imie_malejaco = new RadioButton();
            rb_nazwisko_rosnaco = new RadioButton();
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
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
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
            panel1.Controls.Add(groupBox4);
            panel1.Controls.Add(groupBox3);
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
            // groupBox4
            // 
            groupBox4.Controls.Add(btn_resetuj_filtry);
            groupBox4.Controls.Add(cb_filtruj_newsletter);
            groupBox4.Controls.Add(tb_filtruj_email);
            groupBox4.Controls.Add(tb_filtruj_numer_telefonu);
            groupBox4.Controls.Add(tb_filtruj_imie);
            groupBox4.Controls.Add(tb_filtruj_nazwisko);
            groupBox4.Location = new Point(0, 343);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(982, 174);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "Filtracja";
            // 
            // btn_resetuj_filtry
            // 
            btn_resetuj_filtry.AutoSize = true;
            btn_resetuj_filtry.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_resetuj_filtry.Dock = DockStyle.Right;
            btn_resetuj_filtry.Location = new Point(878, 131);
            btn_resetuj_filtry.Name = "btn_resetuj_filtry";
            btn_resetuj_filtry.Size = new Size(101, 40);
            btn_resetuj_filtry.TabIndex = 8;
            btn_resetuj_filtry.Text = "Resetuj filtry";
            btn_resetuj_filtry.UseVisualStyleBackColor = true;
            btn_resetuj_filtry.Click += btn_resetuj_filtry_Click;
            // 
            // cb_filtruj_newsletter
            // 
            cb_filtruj_newsletter.AutoSize = true;
            cb_filtruj_newsletter.Dock = DockStyle.Left;
            cb_filtruj_newsletter.Location = new Point(3, 131);
            cb_filtruj_newsletter.Name = "cb_filtruj_newsletter";
            cb_filtruj_newsletter.Size = new Size(301, 40);
            cb_filtruj_newsletter.TabIndex = 7;
            cb_filtruj_newsletter.Text = "Tylko z zasubskrybowanym newsletterem";
            cb_filtruj_newsletter.UseVisualStyleBackColor = true;
            // 
            // tb_filtruj_email
            // 
            tb_filtruj_email.Dock = DockStyle.Top;
            tb_filtruj_email.Location = new Point(3, 104);
            tb_filtruj_email.Name = "tb_filtruj_email";
            tb_filtruj_email.PlaceholderText = "Podaj email";
            tb_filtruj_email.Size = new Size(976, 27);
            tb_filtruj_email.TabIndex = 3;
            // 
            // tb_filtruj_numer_telefonu
            // 
            tb_filtruj_numer_telefonu.Dock = DockStyle.Top;
            tb_filtruj_numer_telefonu.Location = new Point(3, 77);
            tb_filtruj_numer_telefonu.Name = "tb_filtruj_numer_telefonu";
            tb_filtruj_numer_telefonu.PlaceholderText = "Podaj numer telefonu";
            tb_filtruj_numer_telefonu.Size = new Size(976, 27);
            tb_filtruj_numer_telefonu.TabIndex = 2;
            // 
            // tb_filtruj_imie
            // 
            tb_filtruj_imie.Dock = DockStyle.Top;
            tb_filtruj_imie.Location = new Point(3, 50);
            tb_filtruj_imie.Name = "tb_filtruj_imie";
            tb_filtruj_imie.PlaceholderText = "Podaj imię";
            tb_filtruj_imie.Size = new Size(976, 27);
            tb_filtruj_imie.TabIndex = 1;
            // 
            // tb_filtruj_nazwisko
            // 
            tb_filtruj_nazwisko.Dock = DockStyle.Top;
            tb_filtruj_nazwisko.Location = new Point(3, 23);
            tb_filtruj_nazwisko.Name = "tb_filtruj_nazwisko";
            tb_filtruj_nazwisko.PlaceholderText = "Podaj nazwisko";
            tb_filtruj_nazwisko.Size = new Size(976, 27);
            tb_filtruj_nazwisko.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rb_nazwisko_malejaco);
            groupBox3.Controls.Add(rb_imie_rosnaco);
            groupBox3.Controls.Add(rb_imie_malejaco);
            groupBox3.Controls.Add(rb_nazwisko_rosnaco);
            groupBox3.Location = new Point(406, 190);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(10, 3, 3, 3);
            groupBox3.Size = new Size(336, 147);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Sortowanie";
            // 
            // rb_nazwisko_malejaco
            // 
            rb_nazwisko_malejaco.AutoSize = true;
            rb_nazwisko_malejaco.Location = new Point(19, 53);
            rb_nazwisko_malejaco.Name = "rb_nazwisko_malejaco";
            rb_nazwisko_malejaco.Size = new Size(158, 24);
            rb_nazwisko_malejaco.TabIndex = 3;
            rb_nazwisko_malejaco.Text = "Nazwisko malejąco";
            rb_nazwisko_malejaco.UseVisualStyleBackColor = true;
            // 
            // rb_imie_rosnaco
            // 
            rb_imie_rosnaco.AutoSize = true;
            rb_imie_rosnaco.Location = new Point(19, 83);
            rb_imie_rosnaco.Name = "rb_imie_rosnaco";
            rb_imie_rosnaco.Size = new Size(115, 24);
            rb_imie_rosnaco.TabIndex = 2;
            rb_imie_rosnaco.Text = "Imię rosnąco";
            rb_imie_rosnaco.UseVisualStyleBackColor = true;
            // 
            // rb_imie_malejaco
            // 
            rb_imie_malejaco.AutoSize = true;
            rb_imie_malejaco.Location = new Point(19, 113);
            rb_imie_malejaco.Name = "rb_imie_malejaco";
            rb_imie_malejaco.Size = new Size(124, 24);
            rb_imie_malejaco.TabIndex = 1;
            rb_imie_malejaco.Text = "Imię malejąco";
            rb_imie_malejaco.UseVisualStyleBackColor = true;
            // 
            // rb_nazwisko_rosnaco
            // 
            rb_nazwisko_rosnaco.AutoSize = true;
            rb_nazwisko_rosnaco.Checked = true;
            rb_nazwisko_rosnaco.Location = new Point(19, 23);
            rb_nazwisko_rosnaco.Name = "rb_nazwisko_rosnaco";
            rb_nazwisko_rosnaco.Size = new Size(149, 24);
            rb_nazwisko_rosnaco.TabIndex = 0;
            rb_nazwisko_rosnaco.TabStop = true;
            rb_nazwisko_rosnaco.Text = "Nazwisko rosnąco";
            rb_nazwisko_rosnaco.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox2.Controls.Add(btn_zasub_newsletter);
            groupBox2.Controls.Add(cb_zasub_newsletter);
            groupBox2.Controls.Add(tb_zasub_numer_telefonu);
            groupBox2.Location = new Point(748, 190);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(234, 147);
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
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
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
        private GroupBox groupBox3;
        private RadioButton rb_nazwisko_malejaco;
        private RadioButton rb_imie_rosnaco;
        private RadioButton rb_imie_malejaco;
        private RadioButton rb_nazwisko_rosnaco;
        private GroupBox groupBox4;
        private TextBox tb_filtruj_email;
        private TextBox tb_filtruj_numer_telefonu;
        private TextBox tb_filtruj_imie;
        private TextBox tb_filtruj_nazwisko;
        private Button btn_resetuj_filtry;
        private CheckBox cb_filtruj_newsletter;
    }
}