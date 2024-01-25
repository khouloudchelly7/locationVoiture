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
    public partial class FLocation : MetroFramework.Forms.MetroForm
    {
        public FLocation()
        {
            InitializeComponent();
        }

        private void Rech_Voit_Click(object sender, EventArgs e)
        {
            FListeVoit F = new FListeVoit();
            F.ShowDialog();
            Voiture V = F.Vt;
            if (V != null)
            {
                Txt_Voit.Text = V.Immat_V;
                Txt_Kil.Text = V.Kilom_V.ToString();
                Txt_Prix.Text = V.PrixLoc_V.ToString();
            }

        }

        private void FLocation_Load(object sender, EventArgs e)
        {

        }

        private void Rech_Voit_Click_1(object sender, EventArgs e)
        {
            FListeVoit F = new FListeVoit();
            F.ShowDialog();
            Voiture V = F.Vt;
            if (V != null)
            {
                Txt_Voit.Text = V.Immat_V;
                Txt_Kil.Text = V.Kilom_V.ToString();
                Txt_Prix.Text = V.PrixLoc_V.ToString();
            }
        }

        private void Rech_Cl_Click(object sender, EventArgs e)
        {

            FListeCl F = new FListeCl();
            F.LC = ClientADO.List_Client();
            F.ShowDialog();
            if (F.Cl != null)
                Txt_Cl.Text = F.Cl.Id_Cl.ToString();
        }

        private void DRet_Loc_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan t = DRet_Loc.Value - DDéb_Loc.Value;
            Txt_Nbj.Text = t.Days.ToString();
        }

        private void Txt_Nbj_TextChanged(object sender, EventArgs e)
        {
            int Nj = int.Parse(Txt_Nbj.Text);
            int Pr;
            if (int.TryParse(Txt_Prix.Text, out Pr) == true)
                Txt_Tot.Text = (Nj * Pr).ToString();

        }

        private void Txt_Prix_TextChanged(object sender, EventArgs e)
        {
            int Nj, Pr;
            if (int.TryParse(Txt_Nbj.Text, out Nj) == true)
            {
                Pr = int.Parse(Txt_Prix.Text);
                Txt_Tot.Text = (Nj * Pr).ToString();
            }
        }

        private void Valider_Click(object sender, EventArgs e)
        {
            if (Txt_Nbj.Text == "")
                MetroFramework.MetroMessageBox.Show(this, "Vous devez indiquer le nombre de jours");
            else
            {
                Location L = new Location
                {
                    Immat_V = Txt_Voit.Text,
                    Id_Cl = int.Parse(Txt_Cl.Text),
                    DDeb_Loc = DDéb_Loc.Value,
                    DRet_Loc = DRet_Loc.Value,
                    Kil_Dep = int.Parse(Txt_Kil.Text),
                    Nbj_Loc = int.Parse(Txt_Nbj.Text)
                };
                LocationADO.Ajouter(L);
                VoitureADO.Modif_Disp(L.Immat_V);
                MessageBox.Show("Location enregistrée");
            }
        }


    }
}