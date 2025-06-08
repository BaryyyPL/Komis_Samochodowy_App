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
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            panel3 = new Panel();
            groupBox1 = new GroupBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            rb_filtruj_cena = new RadioButton();
            rb_filtruj_marka = new RadioButton();
            rb_filtruj_przebieg = new RadioButton();
            rb_filtruj_rocznik = new RadioButton();
            rb_filtruj_moc = new RadioButton();
            cb_filtruj_malejaco = new CheckBox();
            groupBox2 = new GroupBox();
            tb_zmien_vin = new TextBox();
            btn_zmien_cene = new Button();
            groupBox3 = new GroupBox();
            btn_sprzedaj = new Button();
            tb_zmien_cena = new TextBox();
            tb_sprzedaj_vin = new TextBox();
            cb_sprzedaj_klient = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_samochody_osobowe).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
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
            panel1.Controls.Add(flowLayoutPanel1);
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
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 190);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(982, 362);
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
            // panel3
            // 
            panel3.Location = new Point(988, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1079, 293);
            panel3.TabIndex = 1;
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
            rb_filtruj_cena.Location = new Point(3, 3);
            rb_filtruj_cena.Name = "rb_filtruj_cena";
            rb_filtruj_cena.Size = new Size(85, 24);
            rb_filtruj_cena.TabIndex = 0;
            rb_filtruj_cena.TabStop = true;
            rb_filtruj_cena.Text = "Po cenie";
            rb_filtruj_cena.UseVisualStyleBackColor = true;
            // 
            // rb_filtruj_marka
            // 
            rb_filtruj_marka.AutoSize = true;
            rb_filtruj_marka.Location = new Point(94, 3);
            rb_filtruj_marka.Name = "rb_filtruj_marka";
            rb_filtruj_marka.Size = new Size(91, 24);
            rb_filtruj_marka.TabIndex = 1;
            rb_filtruj_marka.TabStop = true;
            rb_filtruj_marka.Text = "Po marce";
            rb_filtruj_marka.UseVisualStyleBackColor = true;
            // 
            // rb_filtruj_przebieg
            // 
            rb_filtruj_przebieg.AutoSize = true;
            rb_filtruj_przebieg.Location = new Point(191, 3);
            rb_filtruj_przebieg.Name = "rb_filtruj_przebieg";
            rb_filtruj_przebieg.Size = new Size(117, 24);
            rb_filtruj_przebieg.TabIndex = 2;
            rb_filtruj_przebieg.TabStop = true;
            rb_filtruj_przebieg.Text = "Po przebiegu";
            rb_filtruj_przebieg.UseVisualStyleBackColor = true;
            // 
            // rb_filtruj_rocznik
            // 
            rb_filtruj_rocznik.AutoSize = true;
            rb_filtruj_rocznik.Location = new Point(3, 33);
            rb_filtruj_rocznik.Name = "rb_filtruj_rocznik";
            rb_filtruj_rocznik.Size = new Size(105, 24);
            rb_filtruj_rocznik.TabIndex = 3;
            rb_filtruj_rocznik.TabStop = true;
            rb_filtruj_rocznik.Text = "Po roczniku";
            rb_filtruj_rocznik.UseVisualStyleBackColor = true;
            // 
            // rb_filtruj_moc
            // 
            rb_filtruj_moc.AutoSize = true;
            rb_filtruj_moc.Location = new Point(114, 33);
            rb_filtruj_moc.Name = "rb_filtruj_moc";
            rb_filtruj_moc.Size = new Size(86, 24);
            rb_filtruj_moc.TabIndex = 4;
            rb_filtruj_moc.TabStop = true;
            rb_filtruj_moc.Text = "Po mocy";
            rb_filtruj_moc.UseVisualStyleBackColor = true;
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
            // tb_zmien_vin
            // 
            tb_zmien_vin.Location = new Point(6, 25);
            tb_zmien_vin.Name = "tb_zmien_vin";
            tb_zmien_vin.PlaceholderText = "VIN";
            tb_zmien_vin.Size = new Size(135, 27);
            tb_zmien_vin.TabIndex = 0;
            // 
            // btn_zmien_cene
            // 
            btn_zmien_cene.Location = new Point(101, 63);
            btn_zmien_cene.Name = "btn_zmien_cene";
            btn_zmien_cene.Size = new Size(94, 29);
            btn_zmien_cene.TabIndex = 2;
            btn_zmien_cene.Text = "Zmień cenę";
            btn_zmien_cene.UseVisualStyleBackColor = true;
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
            // btn_sprzedaj
            // 
            btn_sprzedaj.Location = new Point(142, 61);
            btn_sprzedaj.Name = "btn_sprzedaj";
            btn_sprzedaj.Size = new Size(94, 29);
            btn_sprzedaj.TabIndex = 2;
            btn_sprzedaj.Text = "Sprzedaj";
            btn_sprzedaj.UseVisualStyleBackColor = true;
            // 
            // tb_zmien_cena
            // 
            tb_zmien_cena.Location = new Point(147, 25);
            tb_zmien_cena.Name = "tb_zmien_cena";
            tb_zmien_cena.PlaceholderText = "Nowa cena";
            tb_zmien_cena.Size = new Size(120, 27);
            tb_zmien_cena.TabIndex = 3;
            // 
            // tb_sprzedaj_vin
            // 
            tb_sprzedaj_vin.Location = new Point(6, 27);
            tb_sprzedaj_vin.Name = "tb_sprzedaj_vin";
            tb_sprzedaj_vin.PlaceholderText = "VIN";
            tb_sprzedaj_vin.Size = new Size(117, 27);
            tb_sprzedaj_vin.TabIndex = 4;
            // 
            // cb_sprzedaj_klient
            // 
            cb_sprzedaj_klient.FormattingEnabled = true;
            cb_sprzedaj_klient.Location = new Point(142, 27);
            cb_sprzedaj_klient.Name = "cb_sprzedaj_klient";
            cb_sprzedaj_klient.Size = new Size(214, 28);
            cb_sprzedaj_klient.TabIndex = 5;
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
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
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
        private Panel panel3;
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
        private TextBox textBox4;
        private TextBox textBox2;
        private Button btn_zmien_cene;
        private TextBox tb_zmien_vin;
        private ComboBox cb_sprzedaj_klient;
        private TextBox tb_sprzedaj_vin;
        private TextBox tb_zmien_cena;
    }
}