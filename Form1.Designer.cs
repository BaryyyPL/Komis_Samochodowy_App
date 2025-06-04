namespace Komis_Samochodowy_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btn_samochody_osobowe = new Button();
            btn_samochody_dostawcze = new Button();
            btn_pracownicy = new Button();
            btn_klienci = new Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(904, 72);
            label1.TabIndex = 0;
            label1.Text = "Witaj w Komisie Samochodowym! ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(0, 72);
            label2.Name = "label2";
            label2.Size = new Size(550, 60);
            label2.TabIndex = 1;
            label2.Text = "Czym chcesz się dziś zająć?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Bottom;
            label3.Location = new Point(0, 633);
            label3.Name = "label3";
            label3.Size = new Size(609, 20);
            label3.TabIndex = 2;
            label3.Text = "Aplikacja wykonana na 'Programowanie Zaawansowane' 2024/2025 przez Bardadyn Dawid";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(btn_samochody_osobowe);
            flowLayoutPanel1.Controls.Add(btn_samochody_dostawcze);
            flowLayoutPanel1.Controls.Add(btn_pracownicy);
            flowLayoutPanel1.Controls.Add(btn_klienci);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 132);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(30);
            flowLayoutPanel1.Size = new Size(982, 501);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // btn_samochody_osobowe
            // 
            btn_samochody_osobowe.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_samochody_osobowe.Location = new Point(33, 33);
            btn_samochody_osobowe.Name = "btn_samochody_osobowe";
            btn_samochody_osobowe.Size = new Size(450, 200);
            btn_samochody_osobowe.TabIndex = 0;
            btn_samochody_osobowe.Text = "Samochody Osobowe";
            btn_samochody_osobowe.Click += btn_samochody_osobowe_Click;
            // 
            // btn_samochody_dostawcze
            // 
            btn_samochody_dostawcze.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_samochody_dostawcze.Location = new Point(33, 239);
            btn_samochody_dostawcze.Name = "btn_samochody_dostawcze";
            btn_samochody_dostawcze.Size = new Size(450, 200);
            btn_samochody_dostawcze.TabIndex = 1;
            btn_samochody_dostawcze.Text = "Samochody Dostawcze";
            btn_samochody_dostawcze.Click += btn_samochody_dostawcze_Click;
            // 
            // btn_pracownicy
            // 
            btn_pracownicy.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_pracownicy.Location = new Point(489, 33);
            btn_pracownicy.Name = "btn_pracownicy";
            btn_pracownicy.Size = new Size(450, 200);
            btn_pracownicy.TabIndex = 2;
            btn_pracownicy.Text = "Pracownicy";
            btn_pracownicy.Click += btn_pracownicy_Click;
            // 
            // btn_klienci
            // 
            btn_klienci.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_klienci.Location = new Point(489, 239);
            btn_klienci.Name = "btn_klienci";
            btn_klienci.Size = new Size(450, 200);
            btn_klienci.TabIndex = 3;
            btn_klienci.Text = "Klienci";
            btn_klienci.UseVisualStyleBackColor = true;
            btn_klienci.Click += btn_klienci_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 653);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Komis Samochodowy";
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btn_samochody_osobowe;
        private Button btn_samochody_dostawcze;
        private Button btn_pracownicy;
        private Button btn_klienci;
    }
}
