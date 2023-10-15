using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RubricaTelefonicaWPF
{
    public partial class FormModificaContatto : Form
    {
        private Contatto contatto;
        public FormModificaContatto()
        {
            InitializeComponent();
        }

      

        public FormModificaContatto(Contatto contattoDaModificare)
        {
            InitializeComponent();
            contatto = contattoDaModificare;

            // Popola i TextBox con i dati del contatto
            txtNome.Text = contatto.Nome;
            txtCognome.Text = contatto.Cognome;
            txtNumero.Text = contatto.NumeroTelefonico;
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormModificaContatto_Load(object sender, EventArgs e)
        {

        }

        private void SalvaModifica_Click(object sender, EventArgs e)
        {
            // Aggiorna i dati del contatto con i nuovi dati dai TextBox
            contatto.Nome = txtNome.Text;
            contatto.Cognome = txtCognome.Text;
            contatto.NumeroTelefonico = txtNumero.Text;
            MessageBox.Show("Modifica riuscita, aggiorna con il button Cerca");
            // Chiudi il form
            this.Close();
        }
    }
}
