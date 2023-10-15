using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static RubricaTelefonicaWPF.Contatto;


namespace RubricaTelefonicaWPF
{
    public partial class Form1 : Form
    {
        private List<Contatto> rubrica = new List<Contatto>();

        public Form1()
        {
            InitializeComponent();
            ConfigureDataGridView();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Contatto nuovoContatto = new Contatto
            {
                Nome = Nome.Text,
                Cognome = Cognome.Text,
                NumeroTelefonico = Numero.Text
            };

            if (rubrica == null)
            {
                rubrica = new List<Contatto>(); // Inizializza la lista se è null
            }

            rubrica.Add(nuovoContatto);
            MessageBox.Show("Contatto aggiunto!");
            AggiornaDataGridView();
            RefreshTextbox();

        }

        private void RefreshTextbox()
        {
            Nome.Text = "";
            Cognome.Text = "";
            Numero.Text = "";
        }

        private void buttonModifica_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Ottieni la riga selezionata
                DataGridViewRow rigaSelezionata = dataGridView1.SelectedRows[0];
                Contatto contattoSelezionato = (Contatto)rigaSelezionata.DataBoundItem;

                // Crea un nuovo form per la modifica e passa il contatto
                FormModificaContatto formModifica = new FormModificaContatto(contattoSelezionato);
                formModifica.ShowDialog();

            }
            else
            {
                MessageBox.Show("Nessuna riga selezionata.");
            }
        }

        private void ConfigureDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;  // Disabilita la generazione automatica delle colonne
            dataGridView1.DataSource = rubrica;  // Imposta la sorgente dati come la lista dei contatti
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void AggiornaDataGridView()
        {
            // Imposta la lista come sorgente dati del DataGridView
            dataGridView1.DataSource = null; // Annulla la sorgente dati esistente
            dataGridView1.DataSource = rubrica; // Imposta la nuova sorgente dati
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void ricerca_button_Click(object sender, EventArgs e)
        {       
            
            string termineRicerca = Ricerca.Text.ToLower();  // Converti il termine di ricerca in minuscolo
            List<Contatto> contattiTrovati = rubrica
                    .Where(c => c.Nome.ToLower().Contains(termineRicerca) || c.Cognome.ToLower().Contains(termineRicerca) || c.NumeroTelefonico.Contains(termineRicerca))
                    .ToList();

            // Aggiorna il DataGridView con i risultati della ricerca
            dataGridView1.DataSource = contattiTrovati;

        }

        private void buttonCancella_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Ottiene il contatto selezionato
                var contactoSeleccionado = dataGridView1.SelectedRows[0].DataBoundItem as Contatto;

                // Elimina il contatto della lista
                rubrica.Remove(contactoSeleccionado);

                // Ricarica di nuovo i dati nella DataGridView dopo della cancellazione
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = rubrica;
                MessageBox.Show("Contatto eliminito con esito, con il buttone Cerca puoi verificare che non ci sia.");
            }
        }
    }
}
