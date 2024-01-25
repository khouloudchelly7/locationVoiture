using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using classesADO;
namespace tp5
{
    public partial class FClient : MetroFramework.Forms.MetroForm
    {
        public FClient()
        {
            InitializeComponent();
        }
        List<Client> Lc = new List<Client>();



        private void Affiche_Client()
        {
            Lc = ClientADO.List_Client();
            Dg_Client.Rows.Clear();
            if (Lc != null)
            {
                foreach (Client C in Lc)
                    Dg_Client.Rows.Add(C.Id_Cl, C.Nom_Cl, C.Adr_Cl, C.Tel_Cl, C.Num_CIN);
            }
        }

            private void FClient_Load(object sender, EventArgs e)
            {
                Affiche_Client();
            }
        

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_id.Text))
                MessageBox.Show("saisir id  ");
            else

            {
                Client c = new Client
                {
                    Id_Cl = int.Parse(Txt_id.Text),
                    Nom_Cl = Txt_nom.Text,
                    Adr_Cl = Txt_adresse.Text,
                    Tel_Cl = Txt_tel.Text,
                    Num_CIN = Txt_cin.Text,
                };
                Client c1 = ClientADO.Recherche_ID(int.Parse(Txt_id.Text));

                if (c1 == null)
                {
                    ClientADO.Ajouter(c);
                    Affiche_Client();
                }
                else
                    MessageBox.Show(" id de client existe dejà");
            }
        }

        private void Rechercher_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Txt_id.Text))
            {
                Client c = ClientADO.Recherche_ID(int.Parse(Txt_id.Text));
                if (c != null)
                {
                    Txt_id.Text = c.Id_Cl.ToString();
                    Txt_cin.Text = c.Num_CIN.ToString();
                    Txt_nom.Text = c.Nom_Cl.ToString();
                    Txt_adresse.Text = c.Nom_Cl.ToString();
                    Txt_tel.Text = c.Tel_Cl.ToString();
                    Dg_Client.Rows.Clear();
                    Dg_Client.Rows.Add(c.Id_Cl, c.Nom_Cl, c.Adr_Cl, c.Tel_Cl, c.Num_CIN);

                }
                else
                    MessageBox.Show("Aucun client trouvée", "attention");
            }
           
        }

        private void modifier_Click(object sender, EventArgs e)
        {

            Client c = new Client
            {
                Id_Cl = int.Parse(Txt_id.Text),
                Nom_Cl = Txt_nom.Text,
                Adr_Cl = Txt_adresse.Text,
                Tel_Cl = Txt_tel.Text,
                Num_CIN = Txt_cin.Text,


            };
            ClientADO.Modifier(c);
            Affiche_Client();
        }

        private void actualiser_Click(object sender, EventArgs e)
        {
            Affiche_Client();

        }

        private void Dg_Client_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Dg_Client_DoubleClick(object sender, EventArgs e)
        {
            int ind = Dg_Client.CurrentRow.Index;
            Txt_id.Text = Dg_Client[0, ind].Value.ToString();
            Txt_nom.Text = Dg_Client[1, ind].Value.ToString();
            Txt_adresse.Text = Dg_Client[2, ind].Value.ToString();
            Txt_tel.Text = Dg_Client[3, ind].Value.ToString();
            Txt_cin.Text = Dg_Client[4, ind].Value.ToString();

        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            ClientADO.Supprimer(int.Parse(Txt_id.Text));
            Affiche_Client();
        }

        private void FClient_Load_1(object sender, EventArgs e)
        {
            Affiche_Client();
        }
    }
}
