namespace Projekt_Michał_Kasperek
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_imię = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_wyczyść = new System.Windows.Forms.Button();
            this.checkBox_espresso = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_kawad = new System.Windows.Forms.CheckBox();
            this.checkBox_kawam = new System.Windows.Forms.CheckBox();
            this.checkBox_americanod = new System.Windows.Forms.CheckBox();
            this.checkBox_americanom = new System.Windows.Forms.CheckBox();
            this.numericUpDown_espresso = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_americanom = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_americanod = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_mala = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_duza = new System.Windows.Forms.NumericUpDown();
            this.button_zatwierdz = new System.Windows.Forms.Button();
            this.dataGridView_rachunek = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button_oblicznaleznosc = new System.Windows.Forms.Button();
            this.button_usunpozycje = new System.Windows.Forms.Button();
            this.dataGridView_zamówienia = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numericUpDown_zapłata = new System.Windows.Forms.NumericUpDown();
            this.button_zapłać = new System.Windows.Forms.Button();
            this.numericUpDown_należność = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label_reszta = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button = new System.Windows.Forms.Button();
            this.button_nowezam = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_espresso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_americanom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_americanod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_mala)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_duza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_rachunek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_zamówienia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_zapłata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_należność)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_imię
            // 
            this.textBox_imię.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_imię.Location = new System.Drawing.Point(128, 27);
            this.textBox_imię.Name = "textBox_imię";
            this.textBox_imię.Size = new System.Drawing.Size(100, 26);
            this.textBox_imię.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(6, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Podaj swoje imię:";
            this.label6.UseWaitCursor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox_imię);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 57);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dane";
            // 
            // button_wyczyść
            // 
            this.button_wyczyść.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_wyczyść.Location = new System.Drawing.Point(12, 71);
            this.button_wyczyść.Name = "button_wyczyść";
            this.button_wyczyść.Size = new System.Drawing.Size(247, 34);
            this.button_wyczyść.TabIndex = 20;
            this.button_wyczyść.Text = "Wyczyść";
            this.button_wyczyść.UseVisualStyleBackColor = true;
            this.button_wyczyść.Click += new System.EventHandler(this.button_wyczyść_Click);
            // 
            // checkBox_espresso
            // 
            this.checkBox_espresso.AutoSize = true;
            this.checkBox_espresso.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_espresso.Location = new System.Drawing.Point(6, 31);
            this.checkBox_espresso.Name = "checkBox_espresso";
            this.checkBox_espresso.Size = new System.Drawing.Size(98, 25);
            this.checkBox_espresso.TabIndex = 21;
            this.checkBox_espresso.Text = "Espresso";
            this.checkBox_espresso.UseVisualStyleBackColor = true;
            this.checkBox_espresso.CheckedChanged += new System.EventHandler(this.checkBox_espresso_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.checkBox_kawad);
            this.groupBox1.Controls.Add(this.checkBox_kawam);
            this.groupBox1.Controls.Add(this.checkBox_americanod);
            this.groupBox1.Controls.Add(this.checkBox_americanom);
            this.groupBox1.Controls.Add(this.checkBox_espresso);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(12, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 195);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kawy";
            // 
            // checkBox_kawad
            // 
            this.checkBox_kawad.AutoSize = true;
            this.checkBox_kawad.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_kawad.Location = new System.Drawing.Point(6, 167);
            this.checkBox_kawad.Name = "checkBox_kawad";
            this.checkBox_kawad.Size = new System.Drawing.Size(162, 25);
            this.checkBox_kawad.TabIndex = 25;
            this.checkBox_kawad.Text = "Kawa biała (duża)";
            this.checkBox_kawad.UseVisualStyleBackColor = true;
            this.checkBox_kawad.CheckedChanged += new System.EventHandler(this.checkBox_kawad_CheckedChanged);
            // 
            // checkBox_kawam
            // 
            this.checkBox_kawam.AutoSize = true;
            this.checkBox_kawam.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_kawam.Location = new System.Drawing.Point(6, 133);
            this.checkBox_kawam.Name = "checkBox_kawam";
            this.checkBox_kawam.Size = new System.Drawing.Size(161, 25);
            this.checkBox_kawam.TabIndex = 24;
            this.checkBox_kawam.Text = "Kawa biała (mała)";
            this.checkBox_kawam.UseVisualStyleBackColor = true;
            this.checkBox_kawam.CheckedChanged += new System.EventHandler(this.checkBox_kawam_CheckedChanged);
            // 
            // checkBox_americanod
            // 
            this.checkBox_americanod.AutoSize = true;
            this.checkBox_americanod.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_americanod.Location = new System.Drawing.Point(6, 99);
            this.checkBox_americanod.Name = "checkBox_americanod";
            this.checkBox_americanod.Size = new System.Drawing.Size(162, 25);
            this.checkBox_americanod.TabIndex = 23;
            this.checkBox_americanod.Text = "Americano (duża)";
            this.checkBox_americanod.UseVisualStyleBackColor = true;
            this.checkBox_americanod.CheckedChanged += new System.EventHandler(this.checkBox_americanod_CheckedChanged);
            // 
            // checkBox_americanom
            // 
            this.checkBox_americanom.AutoSize = true;
            this.checkBox_americanom.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_americanom.Location = new System.Drawing.Point(6, 65);
            this.checkBox_americanom.Name = "checkBox_americanom";
            this.checkBox_americanom.Size = new System.Drawing.Size(161, 25);
            this.checkBox_americanom.TabIndex = 22;
            this.checkBox_americanom.Text = "Americano (mała)";
            this.checkBox_americanom.UseVisualStyleBackColor = true;
            this.checkBox_americanom.CheckedChanged += new System.EventHandler(this.checkBox_americanom_CheckedChanged);
            // 
            // numericUpDown_espresso
            // 
            this.numericUpDown_espresso.Enabled = false;
            this.numericUpDown_espresso.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_espresso.Location = new System.Drawing.Point(214, 142);
            this.numericUpDown_espresso.Name = "numericUpDown_espresso";
            this.numericUpDown_espresso.Size = new System.Drawing.Size(44, 26);
            this.numericUpDown_espresso.TabIndex = 24;
            // 
            // numericUpDown_americanom
            // 
            this.numericUpDown_americanom.Enabled = false;
            this.numericUpDown_americanom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_americanom.Location = new System.Drawing.Point(214, 176);
            this.numericUpDown_americanom.Name = "numericUpDown_americanom";
            this.numericUpDown_americanom.Size = new System.Drawing.Size(44, 26);
            this.numericUpDown_americanom.TabIndex = 25;
            // 
            // numericUpDown_americanod
            // 
            this.numericUpDown_americanod.Enabled = false;
            this.numericUpDown_americanod.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_americanod.Location = new System.Drawing.Point(214, 210);
            this.numericUpDown_americanod.Name = "numericUpDown_americanod";
            this.numericUpDown_americanod.Size = new System.Drawing.Size(44, 26);
            this.numericUpDown_americanod.TabIndex = 26;
            // 
            // numericUpDown_mala
            // 
            this.numericUpDown_mala.Enabled = false;
            this.numericUpDown_mala.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_mala.Location = new System.Drawing.Point(214, 244);
            this.numericUpDown_mala.Name = "numericUpDown_mala";
            this.numericUpDown_mala.Size = new System.Drawing.Size(44, 26);
            this.numericUpDown_mala.TabIndex = 27;
            // 
            // numericUpDown_duza
            // 
            this.numericUpDown_duza.Enabled = false;
            this.numericUpDown_duza.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_duza.Location = new System.Drawing.Point(214, 280);
            this.numericUpDown_duza.Name = "numericUpDown_duza";
            this.numericUpDown_duza.Size = new System.Drawing.Size(44, 26);
            this.numericUpDown_duza.TabIndex = 28;
            // 
            // button_zatwierdz
            // 
            this.button_zatwierdz.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_zatwierdz.FlatAppearance.BorderSize = 2;
            this.button_zatwierdz.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_zatwierdz.Location = new System.Drawing.Point(11, 309);
            this.button_zatwierdz.Name = "button_zatwierdz";
            this.button_zatwierdz.Size = new System.Drawing.Size(246, 57);
            this.button_zatwierdz.TabIndex = 36;
            this.button_zatwierdz.Text = "Zatwierdź";
            this.button_zatwierdz.UseVisualStyleBackColor = true;
            this.button_zatwierdz.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView_rachunek
            // 
            this.dataGridView_rachunek.AllowUserToAddRows = false;
            this.dataGridView_rachunek.AllowUserToDeleteRows = false;
            this.dataGridView_rachunek.AllowUserToResizeColumns = false;
            this.dataGridView_rachunek.AllowUserToResizeRows = false;
            this.dataGridView_rachunek.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_rachunek.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_rachunek.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView_rachunek.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_rachunek.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView_rachunek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_rachunek.Location = new System.Drawing.Point(11, 381);
            this.dataGridView_rachunek.Name = "dataGridView_rachunek";
            this.dataGridView_rachunek.ReadOnly = true;
            this.dataGridView_rachunek.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView_rachunek.RowHeadersVisible = false;
            this.dataGridView_rachunek.Size = new System.Drawing.Size(247, 195);
            this.dataGridView_rachunek.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(264, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 38;
            this.label1.Text = "Do zapłaty:";
            // 
            // button_oblicznaleznosc
            // 
            this.button_oblicznaleznosc.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_oblicznaleznosc.Location = new System.Drawing.Point(12, 582);
            this.button_oblicznaleznosc.Name = "button_oblicznaleznosc";
            this.button_oblicznaleznosc.Size = new System.Drawing.Size(247, 27);
            this.button_oblicznaleznosc.TabIndex = 39;
            this.button_oblicznaleznosc.Text = "Oblicz należność";
            this.button_oblicznaleznosc.UseVisualStyleBackColor = true;
            this.button_oblicznaleznosc.Click += new System.EventHandler(this.button_oblicznaleznosc_Click);
            // 
            // button_usunpozycje
            // 
            this.button_usunpozycje.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_usunpozycje.Location = new System.Drawing.Point(12, 612);
            this.button_usunpozycje.Name = "button_usunpozycje";
            this.button_usunpozycje.Size = new System.Drawing.Size(247, 27);
            this.button_usunpozycje.TabIndex = 41;
            this.button_usunpozycje.Text = "Usuń wybraną pozycje";
            this.button_usunpozycje.UseVisualStyleBackColor = true;
            this.button_usunpozycje.Click += new System.EventHandler(this.button_usunpozycje_Click);
            // 
            // dataGridView_zamówienia
            // 
            this.dataGridView_zamówienia.AllowUserToAddRows = false;
            this.dataGridView_zamówienia.AllowUserToDeleteRows = false;
            this.dataGridView_zamówienia.AllowUserToResizeColumns = false;
            this.dataGridView_zamówienia.AllowUserToResizeRows = false;
            this.dataGridView_zamówienia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_zamówienia.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_zamówienia.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView_zamówienia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_zamówienia.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView_zamówienia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_zamówienia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView_zamówienia.Location = new System.Drawing.Point(268, 39);
            this.dataGridView_zamówienia.Name = "dataGridView_zamówienia";
            this.dataGridView_zamówienia.ReadOnly = true;
            this.dataGridView_zamówienia.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView_zamówienia.RowHeadersVisible = false;
            this.dataGridView_zamówienia.Size = new System.Drawing.Size(184, 264);
            this.dataGridView_zamówienia.TabIndex = 44;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 45.68528F;
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 127.1574F;
            this.Column2.HeaderText = "Imię";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 127.1574F;
            this.Column3.HeaderText = "Wartość zamówienia";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // numericUpDown_zapłata
            // 
            this.numericUpDown_zapłata.DecimalPlaces = 2;
            this.numericUpDown_zapłata.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_zapłata.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.numericUpDown_zapłata.Location = new System.Drawing.Point(337, 408);
            this.numericUpDown_zapłata.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_zapłata.Name = "numericUpDown_zapłata";
            this.numericUpDown_zapłata.Size = new System.Drawing.Size(61, 25);
            this.numericUpDown_zapłata.TabIndex = 45;
            // 
            // button_zapłać
            // 
            this.button_zapłać.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_zapłać.ForeColor = System.Drawing.Color.Red;
            this.button_zapłać.Location = new System.Drawing.Point(268, 443);
            this.button_zapłać.Name = "button_zapłać";
            this.button_zapłać.Size = new System.Drawing.Size(184, 45);
            this.button_zapłać.TabIndex = 46;
            this.button_zapłać.Text = "Zapłać";
            this.button_zapłać.UseVisualStyleBackColor = true;
            this.button_zapłać.Click += new System.EventHandler(this.button_zapłać_Click);
            // 
            // numericUpDown_należność
            // 
            this.numericUpDown_należność.AutoSize = true;
            this.numericUpDown_należność.BackColor = System.Drawing.Color.AliceBlue;
            this.numericUpDown_należność.DecimalPlaces = 2;
            this.numericUpDown_należność.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_należność.ForeColor = System.Drawing.Color.Black;
            this.numericUpDown_należność.Location = new System.Drawing.Point(358, 381);
            this.numericUpDown_należność.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_należność.Name = "numericUpDown_należność";
            this.numericUpDown_należność.Size = new System.Drawing.Size(62, 25);
            this.numericUpDown_należność.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(264, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 48;
            this.label2.Text = "Wpłata:";
            // 
            // label_reszta
            // 
            this.label_reszta.AutoSize = true;
            this.label_reszta.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_reszta.Location = new System.Drawing.Point(264, 523);
            this.label_reszta.Name = "label_reszta";
            this.label_reszta.Size = new System.Drawing.Size(0, 21);
            this.label_reszta.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(264, 491);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 21);
            this.label3.TabIndex = 50;
            this.label3.Text = "Reszta:";
            // 
            // groupBox3
            // 
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.Location = new System.Drawing.Point(268, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(184, 21);
            this.groupBox3.TabIndex = 51;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Historia ostatnich zamowień";
            // 
            // button
            // 
            this.button.Enabled = false;
            this.button.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button.Location = new System.Drawing.Point(268, 309);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(184, 57);
            this.button.TabIndex = 52;
            this.button.UseVisualStyleBackColor = true;
            // 
            // button_nowezam
            // 
            this.button_nowezam.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_nowezam.Location = new System.Drawing.Point(265, 582);
            this.button_nowezam.Name = "button_nowezam";
            this.button_nowezam.Size = new System.Drawing.Size(187, 57);
            this.button_nowezam.TabIndex = 53;
            this.button_nowezam.Text = "Nowe zamówienie";
            this.button_nowezam.UseVisualStyleBackColor = true;
            this.button_nowezam.Click += new System.EventHandler(this.button_nowezam_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(458, 661);
            this.Controls.Add(this.button_nowezam);
            this.Controls.Add(this.button);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_reszta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown_należność);
            this.Controls.Add(this.button_zapłać);
            this.Controls.Add(this.numericUpDown_zapłata);
            this.Controls.Add(this.dataGridView_zamówienia);
            this.Controls.Add(this.button_usunpozycje);
            this.Controls.Add(this.button_oblicznaleznosc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_rachunek);
            this.Controls.Add(this.button_zatwierdz);
            this.Controls.Add(this.numericUpDown_espresso);
            this.Controls.Add(this.numericUpDown_americanom);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numericUpDown_duza);
            this.Controls.Add(this.button_wyczyść);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.numericUpDown_americanod);
            this.Controls.Add(this.numericUpDown_mala);
            this.Name = "Form1";
            this.Text = "Michał Kasperek";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_espresso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_americanom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_americanod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_mala)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_duza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_rachunek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_zamówienia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_zapłata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_należność)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_imię;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_wyczyść;
        private System.Windows.Forms.CheckBox checkBox_espresso;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox_kawad;
        private System.Windows.Forms.CheckBox checkBox_kawam;
        private System.Windows.Forms.CheckBox checkBox_americanod;
        private System.Windows.Forms.CheckBox checkBox_americanom;
        private System.Windows.Forms.NumericUpDown numericUpDown_espresso;
        private System.Windows.Forms.NumericUpDown numericUpDown_americanom;
        private System.Windows.Forms.NumericUpDown numericUpDown_americanod;
        private System.Windows.Forms.NumericUpDown numericUpDown_mala;
        private System.Windows.Forms.NumericUpDown numericUpDown_duza;
        private System.Windows.Forms.Button button_zatwierdz;
        private System.Windows.Forms.DataGridView dataGridView_rachunek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_oblicznaleznosc;
        private System.Windows.Forms.Button button_usunpozycje;
        private System.Windows.Forms.DataGridView dataGridView_zamówienia;
        private System.Windows.Forms.NumericUpDown numericUpDown_zapłata;
        private System.Windows.Forms.Button button_zapłać;
        private System.Windows.Forms.NumericUpDown numericUpDown_należność;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_reszta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button button_nowezam;
    }
}

