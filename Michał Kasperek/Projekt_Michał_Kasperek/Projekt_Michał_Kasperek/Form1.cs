using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_Michał_Kasperek
{
    public partial class Form1 : Form
    {
        List<string> imie = new List<string>();
        List<string> wartość = new List<string>();

        string[] rachunek = { "Produkt", "Ilość", "Cena"}; //kolumny tabeli_rechunek
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            FileStream fs = new FileStream("historia.nbfk", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(fs, wartość);
            bf.Serialize(fs, imie);

            fs.Close();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown_należność.Enabled = false;
            numericUpDown_należność.ForeColor = Color.Red;
            foreach (string tab_dane in rachunek) //tabelka
            {
                dataGridView_rachunek.Columns.Add(tab_dane, tab_dane);

            }

            try
            {
                FileStream fs = new FileStream("historia.nbfk", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();

                wartość = (List<string>)bf.Deserialize(fs);
                imie = (List<string>)bf.Deserialize(fs);

                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Nie udało się przywrócić historii zamówień.");
            }

            tabelka_historii();

        }
        private void button_wyczyść_Click(object sender, EventArgs e)
        {
            textBox_imię.Clear();
        }

        private void checkBox_espresso_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_espresso.Checked == true)
            {
                numericUpDown_espresso.Enabled = true;
                numericUpDown_espresso.Value = 1;
            }
            else
            {
                numericUpDown_espresso.Enabled = false;
                numericUpDown_espresso.Value = 0;
            }
               
        }

        private void checkBox_americanom_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_americanom.Checked == true)
            {
                numericUpDown_americanom.Enabled = true;
                numericUpDown_americanom.Value = 1;
            }
            else
            {
                numericUpDown_americanom.Enabled = false;
                numericUpDown_americanom.Value = 0;

            }
        }

        private void checkBox_americanod_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_americanod.Checked == true)
            {
                numericUpDown_americanod.Enabled = true;
                numericUpDown_americanod.Value = 1;
            }
            else
            {
                numericUpDown_americanod.Enabled = false;
                numericUpDown_americanod.Value = 0;

            }
        }

        private void checkBox_kawam_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_kawam.Checked == true)
            {
                numericUpDown_mala.Enabled = true;
                numericUpDown_mala.Value = 1;
            }
            else
            {
                numericUpDown_mala.Enabled = false;
                numericUpDown_mala.Value = 0;
            }
        }

        private void checkBox_kawad_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_kawad.Checked == true)
            {
                numericUpDown_duza.Enabled = true;
                numericUpDown_duza.Value = 1;
            }
            else
            {
                numericUpDown_duza.Enabled = false;
                numericUpDown_duza.Value = 0;
            }
        }


        private void button2_Click(object sender, EventArgs e) //zatwierdź
        {
         zatwierdz();
        }
        void zatwierdz()
        {
            string espresso = checkBox_espresso.Text;
            decimal il_espresso = numericUpDown_espresso.Value;
            decimal cena_espresso = 3.50m * il_espresso;


            string americanom = checkBox_americanom.Text;
            decimal il_americanom = numericUpDown_americanom.Value;
            decimal cena_americanom = 4.50m * il_americanom;


            string americanod = checkBox_americanod.Text;
            decimal il_americanod = numericUpDown_americanod.Value;
            decimal cena_americanod = 5.25m * il_americanod;


            decimal il_mala = numericUpDown_mala.Value;
            string mala = checkBox_kawam.Text;
            decimal cena_mala = 3.50m * il_mala;


            decimal il_duza = numericUpDown_duza.Value;
            string duza = checkBox_kawad.Text;
            decimal cena_duza = 4.25m * il_duza;



            string imie = textBox_imię.Text;

            if ( il_espresso > 0)
            {
                dataGridView_rachunek.Rows.Add(espresso,il_espresso, cena_espresso);

                numericUpDown_espresso.Value = 0;
                numericUpDown_espresso.Enabled = false;
                checkBox_espresso.Checked = false;
            }
            if (il_americanom > 0)
            {
                dataGridView_rachunek.Rows.Add(americanom, il_americanom, cena_americanom);

                numericUpDown_americanom.Value = 0;
                numericUpDown_americanom.Enabled = false;
                checkBox_americanom.Checked = false;
            }
            if (il_americanod > 0)
            {
                dataGridView_rachunek.Rows.Add(americanod, il_americanod, cena_americanod);

                numericUpDown_americanod.Value = 0;
                numericUpDown_americanod.Enabled = false;
                checkBox_americanod.Checked = false;
            }
            if (il_mala > 0)
            {
                dataGridView_rachunek.Rows.Add(mala, il_mala, cena_mala);

                numericUpDown_mala.Value = 0;
                numericUpDown_mala.Enabled = false;
                checkBox_kawam.Checked = false;
            }
            if (il_duza > 0)
            {
                dataGridView_rachunek.Rows.Add(duza, il_duza, cena_duza);

                numericUpDown_duza.Value = 0;
                numericUpDown_americanod.Enabled = false;
                checkBox_kawad.Checked = false;
            }
        }
        private void button_oblicznaleznosc_Click(object sender, EventArgs e)
        {
            decimal wartość_wierszy = 0;

            if (dataGridView_rachunek.Rows.Count == 0 )
                MessageBox.Show("Zatwierdź swoje produkty", "Brak produktów");
            if (textBox_imię.Text == "")
                MessageBox.Show("Wproawdź swoje Imię.");
            else
            {
                for (int i = 0; i < dataGridView_rachunek.Rows.Count; i++)
                {
                        wartość_wierszy = wartość_wierszy + decimal.Parse(dataGridView_rachunek.Rows[i].Cells[2].Value.ToString());

                    numericUpDown_należność.Value = wartość_wierszy;
                }
            }
            
          
        }
        private void button_usunpozycje_Click(object sender, EventArgs e)
        {
            if (dataGridView_rachunek.SelectedCells.Count > 0)
            { 
            MessageBox.Show("Usunięto pozycje.");
            dataGridView_rachunek.Rows.RemoveAt(dataGridView_rachunek.CurrentCell.RowIndex);
        }
            else
                MessageBox.Show("Najpierw coś wybierz");
        }

        private void button_zapłać_Click(object sender, EventArgs e)
        {
            decimal należność, wpłata;
            decimal reszta, resztaa;
            
            wpłata = numericUpDown_zapłata.Value;
            należność = numericUpDown_należność.Value;
            reszta = wpłata - należność;
            label_reszta.Text = reszta.ToString("0.00") + " zł";

            if (należność == 0.00m)
            {
                MessageBox.Show("Musisz najpierw coś wybrać!");
                label_reszta.Text = "";
                return;
            }
            if (wpłata < należność)
            {
                resztaa = reszta * (-1);
                label_reszta.Text = "Musisz najpierw zapłacić " + resztaa.ToString("0.00")+" zł.";
                label_reszta.ForeColor = Color.Red;
                button_zapłać.ForeColor = Color.Green;
            }
            else if (wpłata > należność)
            {

                    label_reszta.Text = reszta.ToString() + " zł.";
                    label_reszta.ForeColor = Color.LightYellow;
                    button_zapłać.ForeColor = Color.LightYellow;
                    button_zapłać.Text = "Zapłacono!";
             

                    tabelka_2_wyswietlanie();

            }
            if (wpłata == należność)
            {
               label_reszta.Text = "Dziękujemy!";
                label_reszta.ForeColor = Color.Green;
                button_zapłać.ForeColor = Color.Green;
                button_zapłać.Text = "Zapłacono!";

                tabelka_2_wyswietlanie();
            }


        }
        void tabelka_historii()
        {
            dataGridView_zamówienia.Rows.Clear(); // 
            for (int i = 0; i < wartość.Count; i++)
                dataGridView_zamówienia.Rows.Add(new object[] { i + 1, imie[i], wartość[i].ToString() });


        }
        void tabelka_2_wyswietlanie()
        {
            string imię = textBox_imię.Text;
            imie.Add(imię);
            decimal wartość_wierszy = 0;

            for (int i = 0; i < dataGridView_rachunek.Rows.Count; i++)
            {
               // try

                    wartość_wierszy = wartość_wierszy + decimal.Parse(dataGridView_rachunek.Rows[i].Cells[2].Value.ToString());

             //   catch { }
                numericUpDown_należność.Value = wartość_wierszy;
            }
            string cena = wartość_wierszy.ToString();

            wartość.Add(cena);
            tabelka_historii();
        }

        private void button_nowezam_Click(object sender, EventArgs e)
        {
            dataGridView_rachunek.Rows.Clear();

            numericUpDown_należność.Value = 0.00m;
            numericUpDown_zapłata.Value = 0.00m;
            textBox_imię.Clear();
            label_reszta.Text = "";

            button_zapłać.Text = "Zapłać";
            button_zapłać.ForeColor = Color.Red;
        }
    }
}
