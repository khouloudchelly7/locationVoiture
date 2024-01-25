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
    public partial class FListeVoit : MetroFramework.Forms.MetroForm
    {
        public FListeVoit()
        {
            InitializeComponent();
        }
        List<Voiture> LV;
        // événement de chargement du formulaire pour remplir le datagridview 
        //par la liste de toutes les voitures disponibles
       


        public Voiture Vt;
        // événement double click du datagridview pour sélectionner une voiture
        // et la stocker dans l'objet Vt
        private void Dg_Voit_DoubleClick(object sender, EventArgs e)
        {
            int ind = Dg_Voit.CurrentRow.Index;
            Vt = new Voiture
            {
                Immat_V = Dg_Voit[0, ind].Value.ToString(),
                Marq_V = Dg_Voit[1, ind].Value.ToString(),
                Mod_V = Dg_Voit[2, ind].Value.ToString(),
                Kilom_V = int.Parse(Dg_Voit[3, ind].Value.ToString()),
                PrixLoc_V = float.Parse(Dg_Voit[4, ind].Value.ToString()),
                Est_Disp = true

            };
            this.Close();
        }
       
        private void Rech_Voit_Click(object sender, EventArgs e)
        {
            Dg_Voit.Rows.Clear();
            if (string.IsNullOrEmpty(txtmodele.Text))
            {
                var LV = VoitureADO.Recherche_Marque_disp(combomarque.Text);
                if (LV != null)
                    foreach (var V in LV)
                        Dg_Voit.Rows.Add(V.Immat_V, V.Marq_V, V.Mod_V, V.Kilom_V, V.PrixLoc_V);
            }
            else
            {
                var LV = VoitureADO.Recherche_modele_disp(txtmodele.Text);
                if (LV != null)
                    foreach (var V in LV)
                        Dg_Voit.Rows.Add(V.Immat_V, V.Marq_V, V.Mod_V, V.Kilom_V, V.PrixLoc_V);
            }

        }

        private void FListeVoit_Load(object sender, EventArgs e)
        {
           
                List<Voiture> LV = VoitureADO.List_Voit_Disp();
                if (LV != null)
                    foreach (var V in LV)
                        Dg_Voit.Rows.Add(V.Immat_V, V.Marq_V, V.Mod_V, V.Kilom_V, V.PrixLoc_V);
                // Chargement du combobox combomarque par les marques des voitures disponibles
                List<string> l = new List<string>();
                l.AddRange(VoitureADO.List_Voit_Disp().Select(x => x.Marq_V).Distinct());
                combomarque.DisplayMember = "marq_v";
                combomarque.DataSource = l;

            

        }

        private void Dg_Voit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
        }
