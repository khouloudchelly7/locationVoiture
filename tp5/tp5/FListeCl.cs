using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using classesADO;
using Entities;

namespace tp5
{
    public partial class FListeCl : MetroFramework.Forms.MetroForm
    {
        public FListeCl()
        {
            InitializeComponent();
        }
        public List<Client> LC;
        public Client Cl;
        private void FListeCl_Load(object sender, EventArgs e)
        {
            LC = ClientADO.List_Client();
            if (LC != null)
            {
                foreach (Client C in LC)
                    Dg_Cl.Rows.Add(C.Id_Cl, C.Nom_Cl, C.Adr_Cl, C.Tel_Cl, C.Num_CIN);
            }
        }
     

        private void Dg_Cl_DoubleClick(object sender, EventArgs e)
        {
            int ind = Dg_Cl.CurrentRow.Index;
            Cl = new Client()
            {
                Id_Cl = int.Parse(Dg_Cl[0, ind].Value.ToString()),
                Nom_Cl = Dg_Cl[1, ind].Value.ToString(),
                Adr_Cl = Dg_Cl[2, ind].Value.ToString(),
                Tel_Cl = Dg_Cl[3, ind].Value.ToString(),
                Num_CIN = Dg_Cl[4, ind].Value.ToString()
            };
            this.Close();

        }

        private void FListeCl_Load_1(object sender, EventArgs e)
        {
            LC = ClientADO.List_Client();
            if (LC != null)
            {
                foreach (Client C in LC)
                    Dg_Cl.Rows.Add(C.Id_Cl, C.Nom_Cl, C.Adr_Cl, C.Tel_Cl, C.Num_CIN);
            }
        }

       
    }
}
