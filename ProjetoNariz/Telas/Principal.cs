using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoNariz.Classes;

namespace ProjetoNariz.Telas
{
    public partial class Principal : Form
    {
        FuncoesBanco f = new FuncoesBanco();
        Tradutor t = new Tradutor();

        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            CarregaCombobox();
            CarregaTips();
            dgvalimentosmn.DataSource = f.AtualizaAlimentosMN();
        }

        //Funções
        private void ClicaInicio()
        {
            this.btnalimentos.BackColor = Color.FromArgb(174, 214, 129);
            this.btnavaliar.BackColor = Color.FromArgb(174, 214, 129);
            this.btndietas.BackColor = Color.FromArgb(174, 214, 129);
            this.btnformular.BackColor = Color.FromArgb(174, 214, 129);
            this.btnhome.BackColor = Color.FromArgb(125, 164, 83);

            this.btnconfig.BackColor = Color.FromArgb(174, 214, 129);
            this.btnsair.BackColor = Color.FromArgb(174, 214, 129);

            //PaineisPrincipais(pnlali);
        }
        private void ClicaAlimentos()
        {
            this.btnalimentos.BackColor = Color.FromArgb(125, 164, 83);
            this.btnavaliar.BackColor = Color.FromArgb(174, 214, 129);
            this.btndietas.BackColor = Color.FromArgb(174, 214, 129);
            this.btnformular.BackColor = Color.FromArgb(174, 214, 129);
            this.btnhome.BackColor = Color.FromArgb(174, 214, 129);

            this.btnconfig.BackColor = Color.FromArgb(174, 214, 129);
            this.btnsair.BackColor = Color.FromArgb(174, 214, 129);

            //PaineisPrincipais(pnlali);
        }
        private void ClicaSair()
        {
            this.btnalimentos.BackColor = Color.FromArgb(174, 214, 129);
            this.btnavaliar.BackColor = Color.FromArgb(174, 214, 129);
            this.btndietas.BackColor = Color.FromArgb(174, 214, 129);
            this.btnformular.BackColor = Color.FromArgb(174, 214, 129);
            this.btnhome.BackColor = Color.FromArgb(174, 214, 129);

            this.btnconfig.BackColor = Color.FromArgb(174, 214, 129);
            this.btnsair.BackColor = Color.FromArgb(125, 164, 83);

            //PaineisPrincipais(pnlali);
        }
        private void ClicaAvaliar()
        {
            this.btnalimentos.BackColor = Color.FromArgb(174, 214, 129);
            this.btnavaliar.BackColor = Color.FromArgb(125, 164, 83);
            this.btndietas.BackColor = Color.FromArgb(174, 214, 129);
            this.btnformular.BackColor = Color.FromArgb(174, 214, 129);
            this.btnhome.BackColor = Color.FromArgb(174, 214, 129);

            this.btnconfig.BackColor = Color.FromArgb(174, 214, 129);
            this.btnsair.BackColor = Color.FromArgb(174, 214, 129);

            //PaineisPrincipais(pnlali);
        }
        private void ClicaDietas()
        {
            this.btnalimentos.BackColor = Color.FromArgb(174, 214, 129);
            this.btnavaliar.BackColor = Color.FromArgb(174, 214, 129);
            this.btndietas.BackColor = Color.FromArgb(125, 164, 83);
            this.btnformular.BackColor = Color.FromArgb(174, 214, 129);
            this.btnhome.BackColor = Color.FromArgb(174, 214, 129);

            this.btnconfig.BackColor = Color.FromArgb(174, 214, 129);
            this.btnsair.BackColor = Color.FromArgb(174, 214, 129);

            //PaineisPrincipais(pnlali);
        }
        private void ClicaFormular()
        {
            this.btnalimentos.BackColor = Color.FromArgb(174, 214, 129);
            this.btnavaliar.BackColor = Color.FromArgb(174, 214, 129);
            this.btndietas.BackColor = Color.FromArgb(174, 214, 129);
            this.btnformular.BackColor = Color.FromArgb(125, 164, 83);
            this.btnhome.BackColor = Color.FromArgb(174, 214, 129);

            this.btnconfig.BackColor = Color.FromArgb(174, 214, 129);
            this.btnsair.BackColor = Color.FromArgb(174, 214, 129);

            //PaineisPrincipais(pnlali);
        }
        private void ClicaConfiguracoes()
        {
            this.btnalimentos.BackColor = Color.FromArgb(174, 214, 129);
            this.btnavaliar.BackColor = Color.FromArgb(174, 214, 129);
            this.btndietas.BackColor = Color.FromArgb(174, 214, 129);
            this.btnformular.BackColor = Color.FromArgb(174, 214, 129);
            this.btnhome.BackColor = Color.FromArgb(174, 214, 129);

            this.btnconfig.BackColor = Color.FromArgb(125, 164, 83);
            this.btnsair.BackColor = Color.FromArgb(174, 214, 129);

            //PaineisPrincipais(pnlali);
        }
        private void PaineisPrincipais(Panel panel)
        {
            pnlalimentosmn.Visible = false;
            pnlalimentosms.Visible = false;

            panel.Visible = true;
        }
        private void CarregaCombobox()
        {
            cbxfiltroalimentomn.Text = "Filtro";
            cbxfiltroalimentoms.Text = "Filtro";
        }
        private void LimpaCampos()
        {
            cbxfiltroalimentomn.Text = "Filtro";
            cbxfiltroalimentoms.Text = "Filtro";
            txtbuscaalimentomn.Text = "O que você procura?";
            txtbuscaalimentoms.Text = "O que você procura?";
        }
        private void CarregaTips()
        {
            tipalimentosmn.SetToolTip(pbxhelpalimentomn, "Composição de alimento por 100 gramas de parte comestível.");
        }

        //Botões Menu Lateral
        private void btnhome_Click(object sender, EventArgs e)
        {
            ClicaInicio();
        }
        private void btnalimentos_Click(object sender, EventArgs e)
        {
            ClicaAlimentos();
        }
        private void btnformular_Click(object sender, EventArgs e)
        {
            ClicaFormular();
        }
        private void btnavaliar_Click(object sender, EventArgs e)
        {
            ClicaAvaliar();
        }
        private void btndietas_Click(object sender, EventArgs e)
        {
            ClicaDietas();
        }
        private void btnconfig_Click(object sender, EventArgs e)
        {
            ClicaConfiguracoes();
        }
        private void btnsair_Click(object sender, EventArgs e)
        {
            ClicaSair();
        }

        //Painel Alimentos Materia Natural
        private void txtbuscaalimentomn_Enter(object sender, EventArgs e)
        {
            if (txtbuscaalimentomn.Text == "O que você procura?")
            {
                txtbuscaalimentomn.Text = "";
            }
            txtbuscaalimentomn.ForeColor = Color.Black;
        }
        private void txtbuscaalimentomn_Leave(object sender, EventArgs e)
        {
            if (txtbuscaalimentomn.Text == "")
            {
                txtbuscaalimentomn.Text = "O que você procura?";
            }

            txtbuscaalimentomn.ForeColor = Color.Silver;
        }
        private void txtbuscaalimentomn_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(cbxfiltroalimentomn.Text == "Filtro")
                {
                    dgvalimentosmn.DataSource = f.AtualizaAlimentosMN();
                }
                else
                {
                    string aux = t.TraduzCombobox(cbxfiltroalimentomn.Text);
                    dgvalimentosmn.DataSource = f.PesquisaAlimentosMN(txtbuscaalimentomn.Text,aux);
                }
            }
        }
        private void btnpesquisaalimentomn_Click(object sender, EventArgs e)
        {
            if (cbxfiltroalimentomn.Text == "Filtro")
            {
                dgvalimentosmn.DataSource = f.AtualizaAlimentosMN();
            }
            else
            {
                string aux = t.TraduzCombobox(cbxfiltroalimentomn.Text);
                dgvalimentosmn.DataSource = f.PesquisaAlimentosMN(txtbuscaalimentomn.Text, aux);
            }
        }
        private void btnvisalimentomn_Click(object sender, EventArgs e)
        {
            //asdasdadasdasad
            pnlvisualizaalimentosmn.Visible = true;

            f.id = dgvalimentosmn.CurrentRow.Cells[0].Value.ToString();
            f.SelecionaAlimentoMN();
            //atribuição das variáveis
            lblnomealimentomn.Text = f.Alimento;
            lblvalenergia.Text = f.Energia;
            lblvalumidade.Text = f.Umidade;
            lblvalmateriaseca.Text = f.MS;
            lblvalproteinabruta.Text = f.PB;
            lblvalextratoetereo.Text = f.EE;
            lblvalfibrabruta.Text = f.FB;
            lblvalmateriamineral.Text = f.MM;
            lblvalenn.Text = f.ENN;
            lblvalaclinoleicon3.Text = f.Ac_Linoleico3;
            lblvalaclinoleicon6.Text = f.Ac_Linoleico6;
            lblvalacaraquidonico.Text = "0"; //Nao possui no BD
            lblvalepadha.Text = f.EPA_DHA;
            lblvalcnf.Text = f.CNF;
            lblvalfda.Text = f.FDA;
            lblvalfdn.Text = f.FDN;
            lblvalarg.Text = f.Arg;
            lblvalhis.Text = f.His;
            lblvalisso.Text = f.Iso;
            lblvalleu.Text = f.Leu;
            lblvallis.Text = f.Lis;
            lblvalmet.Text = f.Met;
            lblvalmetcis.Text = f.Met_Cis;
            lblvalfen.Text = f.Fen;
            lblvalfentir.Text = f.Fen_Tir;
            lblvaltreo.Text = f.Treo;
            lblvaltri.Text = f.Tri;
            lblvalval.Text = f.Val;
            lblvaltau.Text = f.Tau;
            lblvalca.Text = f.Ca;
            lblvalp.Text = f.P;
            lblvalk.Text = f.K;
            lblvalna.Text = f.Na;
            lblvalcl.Text = f.Cl;
            lblvalmg.Text = f.Mg;
            lblvalcu.Text = f.Cu;
            lblvali.Text = f.I;
            lblvalfe.Text = f.Fe;
            lblvalmn.Text = f.Mn;
            lblvalse.Text = f.Se;
            lblvalzn.Text = f.Zn;
            lblvals.Text = f.S;
            lblvalvita.Text = f.Vit_A;
            lblvalvitd.Text = f.Vit_D;
            lblvalvite.Text = f.Vit_E;
            lblvaltiamina.Text = f.Tiamina;
            lblvalriboflavina.Text = f.Riboflavina;
            lblvalacpantotenico.Text = f.Ac_Pantotenico;
            lblvalvitb6.Text = f.Vit_B6;
            lblvalvitb12.Text = f.Vit_B12;
            lblvalniacina.Text = f.Niacina;
            lblvalacfolico.Text = f.Ac_Folico;
            lblvalbiotina.Text = f.Biotina;
            lblvalcolina.Text = f.Colina;
            lblvalvitk.Text = f.Vit_K;
            lblvalvitc.Text = f.Vit_C;
            f.Desconstrutor();
        }
        private void btnvoltavisualizaalimentomn_Click(object sender, EventArgs e)
        {
            pnlvisualizaalimentosmn.Visible = false;
            LimpaCampos();
        }

        //Painel Alimentos Materia Seca
        private void txtbuscaalimentoms_Enter(object sender, EventArgs e)
        {
            if (txtbuscaalimentoms.Text == "O que você procura?")
            {
                txtbuscaalimentoms.Text = "";
            }
            txtbuscaalimentoms.ForeColor = Color.Black;
        }
        private void txtbuscaalimentoms_Leave(object sender, EventArgs e)
        {
            if (txtbuscaalimentoms.Text == "")
            {
                txtbuscaalimentoms.Text = "O que você procura?";
            }

            txtbuscaalimentoms.ForeColor = Color.Silver;
        }

        private void btneditaalimentomn_Click(object sender, EventArgs e)
        {

        }
    }
}
