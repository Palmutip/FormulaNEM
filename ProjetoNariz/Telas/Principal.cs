﻿using System;
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
        List<TextBox> ControleTxtMN = new List<TextBox>();
        List<String> ControleObjMN = new List<String>();
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

            txtnomealimentomn.Visible = false;
            txtnomealimentomn.Text = string.Empty;
            lblnomealimentomn.Text = string.Empty;
            txtvalenergia.Text = string.Empty;
            txtvalumidade.Text = string.Empty;
            txtvalmateriaseca.Text = string.Empty;
            txtvalproteinabruta.Text = string.Empty;
            txtvalextratoetereo.Text = string.Empty;
            txtvalfibrabruta.Text = string.Empty;
            txtvalmateriamineral.Text = string.Empty;
            txtvalenn.Text = string.Empty;
            txtvalaclinoleicon3.Text = string.Empty;
            txtvalaclinoleicon6.Text = string.Empty;
            txtvalacaraquidonico.Text = string.Empty;  //Nao possui no BD
            txtvalepadha.Text = string.Empty;
            txtvalcnf.Text = string.Empty;
            txtvalfda.Text = string.Empty;
            txtvalfdn.Text = string.Empty;
            txtvalarg.Text = string.Empty;
            txtvalhis.Text = string.Empty;
            txtvaliso.Text = string.Empty;
            txtvalleu.Text = string.Empty;
            txtvallis.Text = string.Empty;
            txtvalmet.Text = string.Empty;
            txtvalmetcis.Text = string.Empty;
            txtvalfen.Text = string.Empty;
            txtvalfentir.Text = string.Empty;
            txtvaltreo.Text = string.Empty;
            txtvaltri.Text = string.Empty;
            txtvalval.Text = string.Empty;
            txtvaltau.Text = string.Empty;
            txtvalca.Text = string.Empty;
            txtvalp.Text = string.Empty;
            txtvalk.Text = string.Empty;
            txtvalna.Text = string.Empty;
            txtvalcl.Text = string.Empty;
            txtvalmg.Text = string.Empty;
            txtvalcu.Text = string.Empty;
            txtvali.Text = string.Empty;
            txtvalfe.Text = string.Empty;
            txtvalmn.Text = string.Empty;
            txtvalse.Text = string.Empty;
            txtvalzn.Text = string.Empty;
            txtvals.Text = string.Empty;
            txtvalvita.Text = string.Empty;
            txtvalvitd.Text = string.Empty;
            txtvalvite.Text = string.Empty;
            txtvaltiamina.Text = string.Empty;
            txtvalriboflavina.Text = string.Empty;
            txtvalacpantotenico.Text = string.Empty;
            txtvalvitb6.Text = string.Empty;
            txtvalvitb12.Text = string.Empty;
            txtvalniacina.Text = string.Empty;
            txtvalacfolico.Text = string.Empty;
            txtvalbiotina.Text = string.Empty;
            txtvalcolina.Text = string.Empty;
            txtvalvitk.Text = string.Empty;
            txtvalvitc.Text = string.Empty;
        }
        private void CarregaTips()
        {
            tipalimentosmn.SetToolTip(pbxhelpalimentomn, "Composição de alimento por 100 gramas de parte comestível.");
        }
        private void Listacontrmn()
        {
            ControleTxtMN.Add(txtnomealimentomn);
            ControleTxtMN.Add(txtvalenergia);
            ControleTxtMN.Add(txtvalumidade);
            ControleTxtMN.Add(txtvalmateriaseca);
            ControleTxtMN.Add(txtvalproteinabruta);
            ControleTxtMN.Add(txtvalextratoetereo);
            ControleTxtMN.Add(txtvalfibrabruta);
            ControleTxtMN.Add(txtvalmateriamineral);
            ControleTxtMN.Add(txtvalenn);
            ControleTxtMN.Add(txtvalaclinoleicon3);
            ControleTxtMN.Add(txtvalaclinoleicon6);
            //ControleTxtMN.Add(txtvalacaraquidonico);
            ControleTxtMN.Add(txtvalepadha);
            ControleTxtMN.Add(txtvalcnf);
            ControleTxtMN.Add(txtvalfda);
            ControleTxtMN.Add(txtvalfdn);
            ControleTxtMN.Add(txtvalarg);
            ControleTxtMN.Add(txtvalhis);
            ControleTxtMN.Add(txtvaliso);
            ControleTxtMN.Add(txtvalleu);
            ControleTxtMN.Add(txtvallis);
            ControleTxtMN.Add(txtvalmet);
            ControleTxtMN.Add(txtvalmetcis);
            ControleTxtMN.Add(txtvalfen);
            ControleTxtMN.Add(txtvalfentir);
            ControleTxtMN.Add(txtvaltreo);
            ControleTxtMN.Add(txtvaltri);
            ControleTxtMN.Add(txtvalval);
            ControleTxtMN.Add(txtvaltau);
            ControleTxtMN.Add(txtvalca);
            ControleTxtMN.Add(txtvalp);
            ControleTxtMN.Add(txtvalk);
            ControleTxtMN.Add(txtvalna);
            ControleTxtMN.Add(txtvalcl);
            ControleTxtMN.Add(txtvalmg);
            ControleTxtMN.Add(txtvalcu);
            ControleTxtMN.Add(txtvali);
            ControleTxtMN.Add(txtvalfe);
            ControleTxtMN.Add(txtvalmn);
            ControleTxtMN.Add(txtvalse);
            ControleTxtMN.Add(txtvalzn);
            ControleTxtMN.Add(txtvals);
            ControleTxtMN.Add(txtvalvita);
            ControleTxtMN.Add(txtvalvitd);
            ControleTxtMN.Add(txtvalvite);
            ControleTxtMN.Add(txtvaltiamina);
            ControleTxtMN.Add(txtvalriboflavina);
            ControleTxtMN.Add(txtvalacpantotenico);
            ControleTxtMN.Add(txtvalvitb6);
            ControleTxtMN.Add(txtvalvitb12);
            ControleTxtMN.Add(txtvalniacina);
            ControleTxtMN.Add(txtvalacfolico);
            ControleTxtMN.Add(txtvalbiotina);
            ControleTxtMN.Add(txtvalcolina);
            ControleTxtMN.Add(txtvalvitk);
            ControleTxtMN.Add(txtvalvitc);
        }
        private void Listaobjmn()
        {
            ControleObjMN.Add(f.Alimento);
            ControleObjMN.Add(f.Energia);
            ControleObjMN.Add(f.Umidade);
            ControleObjMN.Add(f.MS);
            ControleObjMN.Add(f.PB);
            ControleObjMN.Add(f.EE);
            ControleObjMN.Add(f.FB);
            ControleObjMN.Add(f.MM);
            ControleObjMN.Add(f.ENN);
            ControleObjMN.Add(f.Ac_Linoleico3);
            ControleObjMN.Add(f.Ac_Linoleico6);
            //ControleObjMN.Add(txtvalacaraquidonico);
            ControleObjMN.Add(f.EPA_DHA);
            ControleObjMN.Add(f.CNF);
            ControleObjMN.Add(f.FDA);
            ControleObjMN.Add(f.FDN);
            ControleObjMN.Add(f.Arg);
            ControleObjMN.Add(f.His);
            ControleObjMN.Add(f.Iso);
            ControleObjMN.Add(f.Leu);
            ControleObjMN.Add(f.Lis);
            ControleObjMN.Add(f.Met);
            ControleObjMN.Add(f.Met_Cis);
            ControleObjMN.Add(f.Fen);
            ControleObjMN.Add(f.Fen_Tir);
            ControleObjMN.Add(f.Treo);
            ControleObjMN.Add(f.Tri);
            ControleObjMN.Add(f.Val);
            ControleObjMN.Add(f.Tau);
            ControleObjMN.Add(f.Ca);
            ControleObjMN.Add(f.P);
            ControleObjMN.Add(f.K);
            ControleObjMN.Add(f.Na);
            ControleObjMN.Add(f.Cl);
            ControleObjMN.Add(f.Mg);
            ControleObjMN.Add(f.Cu);
            ControleObjMN.Add(f.Lis);
            ControleObjMN.Add(f.Fe);
            ControleObjMN.Add(f.Mn);
            ControleObjMN.Add(f.Se);
            ControleObjMN.Add(f.Zn);
            ControleObjMN.Add(f.S);
            ControleObjMN.Add(f.Vit_A);
            ControleObjMN.Add(f.Vit_D);
            ControleObjMN.Add(f.Vit_E);
            ControleObjMN.Add(f.Tiamina);
            ControleObjMN.Add(f.Riboflavina);
            ControleObjMN.Add(f.Ac_Pantotenico);
            ControleObjMN.Add(f.Vit_B6);
            ControleObjMN.Add(f.Vit_B12);
            ControleObjMN.Add(f.Niacina);
            ControleObjMN.Add(f.Ac_Folico);
            ControleObjMN.Add(f.Biotina);
            ControleObjMN.Add(f.Colina);
            ControleObjMN.Add(f.Vit_K);
            ControleObjMN.Add(f.Vit_C);
        }
        private void Controlatxtmn(bool interruptor)
        {
            Listacontrmn();
            if (interruptor == false)
            {
                int i = 0, j = ControleTxtMN.Count;
                while(i!=j){
                    ControleTxtMN[i].BackColor = Color.White;
                    ControleTxtMN[i].Enabled = false;
                    if (ControleTxtMN[i] == txtnomealimentomn)
                    {
                        ControleTxtMN[i].Visible = false;
                    }
                    i++;
                }
                /*txtnomealimentomn.Enabled = false;
                txtnomealimentomn.Visible = false;
                txtvalenergia.Enabled = false;
                txtvalumidade.Enabled = false;
                txtvalmateriaseca.Enabled = false;
                txtvalproteinabruta.Enabled = false;
                txtvalextratoetereo.Enabled = false;
                txtvalfibrabruta.Enabled = false;
                txtvalmateriamineral.Enabled = false;
                txtvalenn.Enabled = false;
                txtvalaclinoleicon3.Enabled = false;
                txtvalaclinoleicon6.Enabled = false;
                txtvalacaraquidonico.Enabled = false;//Nao possui no BD
                txtvalepadha.Enabled = false;
                txtvalcnf.Enabled = false;
                txtvalfda.Enabled = false;
                txtvalfdn.Enabled = false;
                txtvalarg.Enabled = false;
                txtvalhis.Enabled = false;
                txtvaliso.Enabled = false;
                txtvalleu.Enabled = false;
                txtvallis.Enabled = false;
                txtvalmet.Enabled = false;
                txtvalmetcis.Enabled = false;
                txtvalfen.Enabled = false;
                txtvalfentir.Enabled = false;
                txtvaltreo.Enabled = false;
                txtvaltri.Enabled = false;
                txtvalval.Enabled = false;
                txtvaltau.Enabled = false;
                txtvalca.Enabled = false;
                txtvalp.Enabled = false;
                txtvalk.Enabled = false;
                txtvalna.Enabled = false;
                txtvalcl.Enabled = false;
                txtvalmg.Enabled = false;
                txtvalcu.Enabled = false;
                txtvali.Enabled = false;
                txtvalfe.Enabled = false;
                txtvalmn.Enabled = false;
                txtvalse.Enabled = false;
                txtvalzn.Enabled = false;
                txtvals.Enabled = false;
                txtvalvita.Enabled = false;
                txtvalvitd.Enabled = false;
                txtvalvite.Enabled = false;
                txtvaltiamina.Enabled = false;
                txtvalriboflavina.Enabled = false;
                txtvalacpantotenico.Enabled = false;
                txtvalvitb6.Enabled = false;
                txtvalvitb12.Enabled = false;
                txtvalniacina.Enabled = false;
                txtvalacfolico.Enabled = false;
                txtvalbiotina.Enabled = false;
                txtvalcolina.Enabled = false;
                txtvalvitk.Enabled = false;
                txtvalvitc.Enabled = false;*/
            }
            else
            {
                int i = 0, j = ControleTxtMN.Count;
                while (i != j)
                {
                    ControleTxtMN[i].Enabled = true;
                    if (ControleTxtMN[i] == txtnomealimentomn)
                    {
                        ControleTxtMN[i].BackColor = Color.White;
                        ControleTxtMN[i].Visible = true;
                    }
                    else
                    {
                        ControleTxtMN[i].BackColor = Color.Beige;
                    }
                        
                    i++;
                }
            }
            
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
            Controlatxtmn(false);

            f.id = dgvalimentosmn.CurrentRow.Cells[0].Value.ToString();
            f.SelecionaAlimentoMN();
            //atribuição das variáveis
            lblnomealimentomn.Text = f.Alimento;
            txtvalenergia.Text = f.Energia;
            txtvalumidade.Text = f.Umidade;
            txtvalmateriaseca.Text = f.MS;
            txtvalproteinabruta.Text = f.PB;
            txtvalextratoetereo.Text = f.EE;
            txtvalfibrabruta.Text = f.FB;
            txtvalmateriamineral.Text = f.MM;
            txtvalenn.Text = f.ENN;
            txtvalaclinoleicon3.Text = f.Ac_Linoleico3;
            txtvalaclinoleicon6.Text = f.Ac_Linoleico6;
            txtvalacaraquidonico.Text = "0"; //Nao possui no BD
            txtvalepadha.Text = f.EPA_DHA;
            txtvalcnf.Text = f.CNF;
            txtvalfda.Text = f.FDA;
            txtvalfdn.Text = f.FDN;
            txtvalarg.Text = f.Arg;
            txtvalhis.Text = f.His;
            txtvaliso.Text = f.Iso;
            txtvalleu.Text = f.Leu;
            txtvallis.Text = f.Lis;
            txtvalmet.Text = f.Met;
            txtvalmetcis.Text = f.Met_Cis;
            txtvalfen.Text = f.Fen;
            txtvalfentir.Text = f.Fen_Tir;
            txtvaltreo.Text = f.Treo;
            txtvaltri.Text = f.Tri;
            txtvalval.Text = f.Val;
            txtvaltau.Text = f.Tau;
            txtvalca.Text = f.Ca;
            txtvalp.Text = f.P;
            txtvalk.Text = f.K;
            txtvalna.Text = f.Na;
            txtvalcl.Text = f.Cl;
            txtvalmg.Text = f.Mg;
            txtvalcu.Text = f.Cu;
            txtvali.Text = f.I;
            txtvalfe.Text = f.Fe;
            txtvalmn.Text = f.Mn;
            txtvalse.Text = f.Se;
            txtvalzn.Text = f.Zn;
            txtvals.Text = f.S;
            txtvalvita.Text = f.Vit_A;
            txtvalvitd.Text = f.Vit_D;
            txtvalvite.Text = f.Vit_E;
            txtvaltiamina.Text = f.Tiamina;
            txtvalriboflavina.Text = f.Riboflavina;
            txtvalacpantotenico.Text = f.Ac_Pantotenico;
            txtvalvitb6.Text = f.Vit_B6;
            txtvalvitb12.Text = f.Vit_B12;
            txtvalniacina.Text = f.Niacina;
            txtvalacfolico.Text = f.Ac_Folico;
            txtvalbiotina.Text = f.Biotina;
            txtvalcolina.Text = f.Colina;
            txtvalvitk.Text = f.Vit_K;
            txtvalvitc.Text = f.Vit_C;
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
            txtvalenergia.Text = f.Energia;
            txtvalumidade.Text = f.Umidade;
            txtvalmateriaseca.Text = f.MS;
            txtvalproteinabruta.Text = f.PB;
            txtvalextratoetereo.Text = f.EE;
            txtvalfibrabruta.Text = f.FB;
            txtvalmateriamineral.Text = f.MM;
            txtvalenn.Text = f.ENN;
            txtvalaclinoleicon3.Text = f.Ac_Linoleico3;
            txtvalaclinoleicon6.Text = f.Ac_Linoleico6;
            txtvalacaraquidonico.Text = "0"; //Nao possui no BD
            txtvalepadha.Text = f.EPA_DHA;
            txtvalcnf.Text = f.CNF;
            txtvalfda.Text = f.FDA;
            txtvalfdn.Text = f.FDN;
            txtvalarg.Text = f.Arg;
            txtvalhis.Text = f.His;
            txtvaliso.Text = f.Iso;
            txtvalleu.Text = f.Leu;
            txtvallis.Text = f.Lis;
            txtvalmet.Text = f.Met;
            txtvalmetcis.Text = f.Met_Cis;
            txtvalfen.Text = f.Fen;
            txtvalfentir.Text = f.Fen_Tir;
            txtvaltreo.Text = f.Treo;
            txtvaltri.Text = f.Tri;
            txtvalval.Text = f.Val;
            txtvaltau.Text = f.Tau;
            txtvalca.Text = f.Ca;
            txtvalp.Text = f.P;
            txtvalk.Text = f.K;
            txtvalna.Text = f.Na;
            txtvalcl.Text = f.Cl;
            txtvalmg.Text = f.Mg;
            txtvalcu.Text = f.Cu;
            txtvali.Text = f.I;
            txtvalfe.Text = f.Fe;
            txtvalmn.Text = f.Mn;
            txtvalse.Text = f.Se;
            txtvalzn.Text = f.Zn;
            txtvals.Text = f.S;
            txtvalvita.Text = f.Vit_A;
            txtvalvitd.Text = f.Vit_D;
            txtvalvite.Text = f.Vit_E;
            txtvaltiamina.Text = f.Tiamina;
            txtvalriboflavina.Text = f.Riboflavina;
            txtvalacpantotenico.Text = f.Ac_Pantotenico;
            txtvalvitb6.Text = f.Vit_B6;
            txtvalvitb12.Text = f.Vit_B12;
            txtvalniacina.Text = f.Niacina;
            txtvalacfolico.Text = f.Ac_Folico;
            txtvalbiotina.Text = f.Biotina;
            txtvalcolina.Text = f.Colina;
            txtvalvitk.Text = f.Vit_K;
            txtvalvitc.Text = f.Vit_C;
            Controlatxtmn(true);
        }
    }
}
