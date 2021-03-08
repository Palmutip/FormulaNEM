using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoNariz.Classes;

namespace ProjetoNariz.Telas
{
    public partial class Principal : Form
    {
        #region Inicializadores do programa
        public Principal()
        {
            InitializeComponent();
        }
        private void Principal_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region Variáveis utilizadas para manipulação dos dados
        FuncoesBanco f = new FuncoesBanco();
        Tradutor t = new Tradutor();
        List<TextBox> ControleTxtMN = new List<TextBox>();
        List<String> ControleObjMN = new List<String>();
        private static bool Salva = false;
        private int contaparenteses = 0;
        #endregion

        #region Funções
        private void ClicaInicio()
        {
            this.btnalimentos.BackColor = Color.FromArgb(174, 214, 129);
            this.btnavaliar.BackColor = Color.FromArgb(174, 214, 129);
            this.btndietas.BackColor = Color.FromArgb(174, 214, 129);
            this.btnformular.BackColor = Color.FromArgb(174, 214, 129);
            this.btnhome.BackColor = Color.FromArgb(125, 164, 83);
            this.btnespecies.BackColor = Color.FromArgb(174, 214, 129);

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
            this.btnespecies.BackColor = Color.FromArgb(174, 214, 129);

            this.btnconfig.BackColor = Color.FromArgb(174, 214, 129);
            this.btnsair.BackColor = Color.FromArgb(174, 214, 129);

            CarregaCombobox();
            CarregaTips();

            PaineisPrincipais(pnlselecionaalimento);
        }
        private void ClicaSair()
        {
            this.btnalimentos.BackColor = Color.FromArgb(174, 214, 129);
            this.btnavaliar.BackColor = Color.FromArgb(174, 214, 129);
            this.btndietas.BackColor = Color.FromArgb(174, 214, 129);
            this.btnformular.BackColor = Color.FromArgb(174, 214, 129);
            this.btnhome.BackColor = Color.FromArgb(174, 214, 129);
            this.btnespecies.BackColor = Color.FromArgb(174, 214, 129);

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
            this.btnespecies.BackColor = Color.FromArgb(174, 214, 129);

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
            this.btnespecies.BackColor = Color.FromArgb(174, 214, 129);

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
            this.btnespecies.BackColor = Color.FromArgb(174, 214, 129);

            this.btnconfig.BackColor = Color.FromArgb(174, 214, 129);
            this.btnsair.BackColor = Color.FromArgb(174, 214, 129);

            PaineisPrincipais(pnlformulacao);
        }
        private void ClicaConfiguracoes()
        {
            this.btnalimentos.BackColor = Color.FromArgb(174, 214, 129);
            this.btnavaliar.BackColor = Color.FromArgb(174, 214, 129);
            this.btndietas.BackColor = Color.FromArgb(174, 214, 129);
            this.btnformular.BackColor = Color.FromArgb(174, 214, 129);
            this.btnhome.BackColor = Color.FromArgb(174, 214, 129);
            this.btnespecies.BackColor = Color.FromArgb(174, 214, 129);

            this.btnconfig.BackColor = Color.FromArgb(125, 164, 83);
            this.btnsair.BackColor = Color.FromArgb(174, 214, 129);

            //PaineisPrincipais(pnlali);
        }
        private void ClicaEspecie()
        {
            this.btnalimentos.BackColor = Color.FromArgb(174, 214, 129);
            this.btnavaliar.BackColor = Color.FromArgb(174, 214, 129);
            this.btndietas.BackColor = Color.FromArgb(174, 214, 129);
            this.btnformular.BackColor = Color.FromArgb(174, 214, 129);
            this.btnhome.BackColor = Color.FromArgb(174, 214, 129);
            this.btnespecies.BackColor = Color.FromArgb(125, 164, 83);

            this.btnconfig.BackColor = Color.FromArgb(174, 214, 129);
            this.btnsair.BackColor = Color.FromArgb(174, 214, 129);

            LimpaCampos(3);

            PaineisPrincipais(pnlespecies);
        }
        private void PaineisPrincipais(Panel panel1, Panel panel2, Panel panel3)
        {
            pnlalimentosmn.Visible = false;
            pnlalimentosms.Visible = false;
            pnlvisualizaalimentosmn.Visible = false;
            pnlvisualizaalimentosms.Visible = false;
            pnlsuperioralimentosmn.Visible = false;
            pnlsuperioralimentosms.Visible = false;
            pnlselecionaalimento.Visible = false;

            panel1.Visible = true;
            panel2.Visible = true;
            panel3.Visible = true;
        }
        private void PaineisPrincipais(Panel panel1, Panel panel2)
        {
            pnlalimentosmn.Visible = false;
            pnlalimentosms.Visible = false;
            pnlvisualizaalimentosmn.Visible = false;
            pnlvisualizaalimentosms.Visible = false;
            pnlsuperioralimentosmn.Visible = false;
            pnlsuperioralimentosms.Visible = false;
            pnlselecionaalimento.Visible = false;

            panel1.Visible = true;
            panel2.Visible = true;
        }
        private void PaineisPrincipais(Panel panel)
        {
            pnlalimentosmn.Visible = false;
            pnlalimentosms.Visible = false;
            pnlvisualizaalimentosmn.Visible = false;
            pnlvisualizaalimentosms.Visible = false;
            pnlsuperioralimentosmn.Visible = false;
            pnlsuperioralimentosms.Visible = false;
            pnlselecionaalimento.Visible = false;
            pnlformulacao.Visible = false;
            pnlespecies.Visible = false;

            panel.Visible = true;
        }
        private void CarregaCombobox()
        {
            cbxfiltroalimentomn.Text = "Filtro";
            cbxfiltroalimentoms.Text = "Filtro";
        }
        private void LimpaCampos(int modulo)
        {
            #region Modulo  1 é Alimentos MN
            if (modulo == 1)
            {
                cbxfiltroalimentomn.Text = "Filtro";
                txtbuscaalimentomn.Text = "O que você procura?";

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
                txtvalacaraquidonico.Text = string.Empty;
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

                btneditaalimentomn.Visible = true;
                btneditaalimentomn.Enabled = true;
                btneditaalimentomn.Text = "Editar";
                btneditaalimentomn.ForeColor = Color.White;
                btneditaalimentomn.BackColor = Color.FromArgb(255, 179, 0);
                btnexcluiralimentomn.Visible = true;
                btnexcluiralimentomn.Enabled = true;

                btnsalvaalimentomn.Enabled = false;
                btnsalvaalimentomn.Visible = false;
                btncancelareditaoalimentomn.Visible = false;
                btncancelareditaoalimentomn.Enabled = false;

                txtnomealimentomn.Visible = false;
                txtnomealimentomn.Enabled = false;
            }
            #endregion

            #region Módulo 2 é Alimentos MS
            else if (modulo == 2)
            {
                cbxfiltroalimentoms.Text = "Filtro";

                txtbuscaalimentoms.Text = "O que você procura?";

                lblnomealimentoms.Text = string.Empty;
                txtvalenergiams.Text = string.Empty;
                txtvalumidadems.Text = string.Empty;
                txtvalmateriasecams.Text = string.Empty;
                txtvalproteinabrutams.Text = string.Empty;
                txtvalextratoetereoms.Text = string.Empty;
                txtvalfibrabrutams.Text = string.Empty;
                txtvalmateriamineralms.Text = string.Empty;
                txtvalennms.Text = string.Empty;
                txtvalaclinoleicon3ms.Text = string.Empty;
                txtvalaclinoleicon6ms.Text = string.Empty;
                txtvalacaraquidonicoms.Text = string.Empty;
                txtvalepadhams.Text = string.Empty;
                txtvalcnfms.Text = string.Empty;
                txtvalfdams.Text = string.Empty;
                txtvalfdnms.Text = string.Empty;
                txtvalargms.Text = string.Empty;
                txtvalhisms.Text = string.Empty;
                txtvalisoms.Text = string.Empty;
                txtvalleums.Text = string.Empty;
                txtvallisms.Text = string.Empty;
                txtvalmetms.Text = string.Empty;
                txtvalmetcisms.Text = string.Empty;
                txtvalfenms.Text = string.Empty;
                txtvalfentirms.Text = string.Empty;
                txtvaltreoms.Text = string.Empty;
                txtvaltrims.Text = string.Empty;
                txtvalvalms.Text = string.Empty;
                txtvaltaums.Text = string.Empty;
                txtvalcams.Text = string.Empty;
                txtvalp.Text = string.Empty;
                txtvalkms.Text = string.Empty;
                txtvalnams.Text = string.Empty;
                txtvalclms.Text = string.Empty;
                txtvalmgms.Text = string.Empty;
                txtvalcums.Text = string.Empty;
                txtvalims.Text = string.Empty;
                txtvalfems.Text = string.Empty;
                txtvalmnms.Text = string.Empty;
                txtvalsems.Text = string.Empty;
                txtvalznms.Text = string.Empty;
                txtvalsms.Text = string.Empty;
                txtvalvitams.Text = string.Empty;
                txtvalvitdms.Text = string.Empty;
                txtvalvitems.Text = string.Empty;
                txtvaltiaminams.Text = string.Empty;
                txtvalriboflavinams.Text = string.Empty;
                txtvalacpantotenicoms.Text = string.Empty;
                txtvalvitb6ms.Text = string.Empty;
                txtvalvitb12ms.Text = string.Empty;
                txtvalniacinams.Text = string.Empty;
                txtvalacfolicoms.Text = string.Empty;
                txtvalbiotinams.Text = string.Empty;
                txtvalcolinams.Text = string.Empty;
                txtvalvitkms.Text = string.Empty;
                txtvalvitcms.Text = string.Empty;

                btneditaalimentoms.Visible = true;
                btneditaalimentoms.Enabled = true;
                btneditaalimentoms.Text = "Editar";
                btneditaalimentoms.ForeColor = Color.White;
                btneditaalimentoms.BackColor = Color.FromArgb(255, 179, 0);
                btnexcluiralimentoms.Visible = true;
                btnexcluiralimentoms.Enabled = true;

                btnsalvaalimentoms.Enabled = false;
                btnsalvaalimentoms.Visible = false;
                btncancelaalimentoms.Visible = false;
                btncancelaalimentoms.Enabled = false;

                txtnomealimentoms.Visible = false;
                txtnomealimentoms.Enabled = false;
            }
            #endregion

            #region Módulo 3 é Espécies
            else if (modulo == 3)
            {
                txtnomeespecie.Text = "Nome";
                txtcadastronomeespecie.Text = string.Empty;
                txtcadastronomeespecie.Enabled = false;
                txtcadastronem.Text = string.Empty;
                txtcadastronem.Enabled = false;
                txtformulanem.Text = string.Empty;

                btnsalvacadastroespecie.Visible = false;
                btnsalvacadastroespecie.Enabled = false;
                btncancelacadastroespecie.Visible = false;
                btncancelacadastroespecie.Enabled = false;

                pnlcalcnem.Visible = false;
            }
            #endregion

        }
        private void CarregaTips()
        {
            tipalimentosmn.SetToolTip(pbxhelpalimentomn, "Composição de alimento por 100 gramas de parte comestível.");
            tipalimentosmn.SetToolTip(pbxtooltipalimentoms, "Composição de alimento por 100 gramas de parte comestível.");
        }
        private void Listacontroletxt(bool MateriaNatural)
        {
            if (MateriaNatural)
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
                ControleTxtMN.Add(txtvalacaraquidonico);
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
            else
            {
                ControleTxtMN.Add(txtnomealimentoms);
                ControleTxtMN.Add(txtvalenergiams);
                ControleTxtMN.Add(txtvalumidadems);
                ControleTxtMN.Add(txtvalmateriasecams);
                ControleTxtMN.Add(txtvalproteinabrutams);
                ControleTxtMN.Add(txtvalextratoetereoms);
                ControleTxtMN.Add(txtvalfibrabrutams);
                ControleTxtMN.Add(txtvalmateriamineralms);
                ControleTxtMN.Add(txtvalennms);
                ControleTxtMN.Add(txtvalaclinoleicon3ms);
                ControleTxtMN.Add(txtvalaclinoleicon6ms);
                ControleTxtMN.Add(txtvalacaraquidonicoms);
                ControleTxtMN.Add(txtvalepadhams);
                ControleTxtMN.Add(txtvalcnfms);
                ControleTxtMN.Add(txtvalfdams);
                ControleTxtMN.Add(txtvalfdnms);
                ControleTxtMN.Add(txtvalargms);
                ControleTxtMN.Add(txtvalhisms);
                ControleTxtMN.Add(txtvalisoms);
                ControleTxtMN.Add(txtvalleums);
                ControleTxtMN.Add(txtvallisms);
                ControleTxtMN.Add(txtvalmetms);
                ControleTxtMN.Add(txtvalmetcisms);
                ControleTxtMN.Add(txtvalfenms);
                ControleTxtMN.Add(txtvalfentirms);
                ControleTxtMN.Add(txtvaltreoms);
                ControleTxtMN.Add(txtvaltrims);
                ControleTxtMN.Add(txtvalvalms);
                ControleTxtMN.Add(txtvaltaums);
                ControleTxtMN.Add(txtvalcams);
                ControleTxtMN.Add(txtvalpms);
                ControleTxtMN.Add(txtvalkms);
                ControleTxtMN.Add(txtvalnams);
                ControleTxtMN.Add(txtvalclms);
                ControleTxtMN.Add(txtvalmgms);
                ControleTxtMN.Add(txtvalcums);
                ControleTxtMN.Add(txtvalims);
                ControleTxtMN.Add(txtvalfems);
                ControleTxtMN.Add(txtvalmnms);
                ControleTxtMN.Add(txtvalsems);
                ControleTxtMN.Add(txtvalznms);
                ControleTxtMN.Add(txtvalsms);
                ControleTxtMN.Add(txtvalvitams);
                ControleTxtMN.Add(txtvalvitdms);
                ControleTxtMN.Add(txtvalvitems);
                ControleTxtMN.Add(txtvaltiaminams);
                ControleTxtMN.Add(txtvalriboflavinams);
                ControleTxtMN.Add(txtvalacpantotenicoms);
                ControleTxtMN.Add(txtvalvitb6ms);
                ControleTxtMN.Add(txtvalvitb12ms);
                ControleTxtMN.Add(txtvalniacinams);
                ControleTxtMN.Add(txtvalacfolicoms);
                ControleTxtMN.Add(txtvalbiotinams);
                ControleTxtMN.Add(txtvalcolinams);
                ControleTxtMN.Add(txtvalvitkms);
                ControleTxtMN.Add(txtvalvitcms);
            }
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
            ControleObjMN.Add(f.Ac_Linolenico3);
            ControleObjMN.Add(f.Ac_Linoleico6);
            ControleObjMN.Add(f.Ac_Araquidonico);
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
        private void Controlatxt(bool Digitar, bool MateriaNatural)
        {
            try
            {
                if (MateriaNatural)
                {
                    Listacontroletxt(true);
                    if (Digitar == false)
                    {
                        int i = 0, j = ControleTxtMN.Count;
                        while (i != j)
                        {
                            ControleTxtMN[i].BackColor = Color.White;
                            ControleTxtMN[i].Enabled = false;
                            if (ControleTxtMN[i] == txtnomealimentomn)
                            {
                                ControleTxtMN[i].Visible = false;
                            }
                            i++;
                        }
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
                else
                {
                    Listacontroletxt(false);
                    if (Digitar == false)
                    {
                        int i = 0, j = ControleTxtMN.Count;
                        while (i != j)
                        {
                            ControleTxtMN[i].BackColor = Color.White;
                            ControleTxtMN[i].Enabled = false;
                            if (ControleTxtMN[i] == txtnomealimentoms)
                            {
                                ControleTxtMN[i].Visible = false;
                            }
                            i++;
                        }
                    }
                    else
                    {
                        int i = 0, j = ControleTxtMN.Count;
                        while (i != j)
                        {
                            ControleTxtMN[i].Enabled = true;
                            if (ControleTxtMN[i] == txtnomealimentoms)
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
            }
            catch (Exception) { }
            finally
            {
                ControleTxtMN.Clear();
            }
        }
        private void Atribuicoes(object parametros)
        {
            List<bool> param = (List<bool>)parametros;
            bool search = param[0];
            bool primeirametade = param[1];
            if (!search)
            {
                if (!primeirametade)
                {
                    f.Ca = txtvalca.Text;
                    f.P = txtvalp.Text;
                    f.K = txtvalk.Text;
                    f.Na = txtvalna.Text;
                    f.Cl = txtvalcl.Text;
                    f.Mg = txtvalmg.Text;
                    f.Cu = txtvalcu.Text;
                    f.I = txtvali.Text;
                    f.Fe = txtvalfe.Text;
                    f.Mn = txtvalmn.Text;
                    f.Se = txtvalse.Text;
                    f.Zn = txtvalzn.Text;
                    f.S = txtvals.Text;
                    f.Vit_A = txtvalvita.Text;
                    f.Vit_D = txtvalvitd.Text;
                    f.Vit_E = txtvalvite.Text;
                    f.Tiamina = txtvaltiamina.Text;
                    f.Riboflavina = txtvalriboflavina.Text;
                    f.Ac_Pantotenico = txtvalacpantotenico.Text;
                    f.Vit_B6 = txtvalvitb6.Text;
                    f.Vit_B12 = txtvalvitb12.Text;
                    f.Niacina = txtvalniacina.Text;
                    f.Ac_Folico = txtvalacfolico.Text;
                    f.Biotina = txtvalbiotina.Text;
                    f.Colina = txtvalcolina.Text;
                    f.Vit_K = txtvalvitk.Text;
                    f.Vit_C = txtvalvitc.Text;
                }
                else
                {
                    f.Alimento = txtnomealimentomn.Text;
                    f.Energia = txtvalenergia.Text;
                    f.Umidade = txtvalumidade.Text;
                    f.MS = txtvalmateriaseca.Text;
                    f.PB = txtvalproteinabruta.Text;
                    f.EE = txtvalextratoetereo.Text;
                    f.FB = txtvalfibrabruta.Text;
                    f.MM = txtvalmateriamineral.Text;
                    f.ENN = txtvalenn.Text;
                    f.Ac_Linolenico3 = txtvalaclinoleicon3.Text;
                    f.Ac_Linoleico6 = txtvalaclinoleicon6.Text;
                    f.Ac_Araquidonico = txtvalacaraquidonico.Text;
                    f.EPA_DHA = txtvalepadha.Text;
                    f.CNF = txtvalcnf.Text;
                    f.FDA = txtvalfda.Text;
                    f.FDN = txtvalfdn.Text;
                    f.Arg = txtvalarg.Text;
                    f.His = txtvalhis.Text;
                    f.Iso = txtvaliso.Text;
                    f.Leu = txtvalleu.Text;
                    f.Lis = txtvallis.Text;
                    f.Met = txtvalmet.Text;
                    f.Met_Cis = txtvalmetcis.Text;
                    f.Fen = txtvalfen.Text;
                    f.Fen_Tir = txtvalfentir.Text;
                    f.Treo = txtvaltreo.Text;
                    f.Tri = txtvaltri.Text;
                    f.Val = txtvalval.Text;
                    f.Tau = txtvaltau.Text;
                }
            }
            else
            {
                if (!primeirametade)
                {
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
                }
                else
                {
                    lblnomealimentomn.Text = f.Alimento;
                    txtvalenergia.Text = f.Energia;
                    txtvalumidade.Text = f.Umidade;
                    txtvalmateriaseca.Text = f.MS;
                    txtvalproteinabruta.Text = f.PB;
                    txtvalextratoetereo.Text = f.EE;
                    txtvalfibrabruta.Text = f.FB;
                    txtvalmateriamineral.Text = f.MM;
                    txtvalenn.Text = f.ENN;
                    txtvalaclinoleicon3.Text = f.Ac_Linolenico3;
                    txtvalaclinoleicon6.Text = f.Ac_Linoleico6;
                    txtvalacaraquidonico.Text = f.Ac_Araquidonico;
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
                }
            }
        }
        #endregion

        #region Botões Menu Lateral
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
        private void btnespecies_Click(object sender, EventArgs e)
        {
            ClicaEspecie();
        }
        #endregion

        #region Painel para escolher com qual seção de alimentos trabalhar
        private void btnescolhealimentoms_Click(object sender, EventArgs e)
        {
            PaineisPrincipais(pnlalimentosms, pnlsuperioralimentosms);
            dgvalimentosms.DataSource = f.AtualizaAlimentosMS();
        }
        private void btnescolhealimentomn_Click(object sender, EventArgs e)
        {
            PaineisPrincipais(pnlalimentosmn, pnlsuperioralimentosmn);
            dgvalimentosmn.DataSource = f.AtualizaAlimentosMN();
        }
        #endregion

        #region Painel Alimentos MN
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
            PaineisPrincipais(pnlalimentosmn, pnlsuperioralimentosmn, pnlvisualizaalimentosmn);
            Controlatxt(false, true);

            f.id = dgvalimentosmn.CurrentRow.Cells[0].Value.ToString();
            try
            {
                f.SelecionaAlimentoMN();
                /*Control.CheckForIllegalCrossThreadCalls = false;
                //atribuição das variáveis
                Thread t = new Thread(new ParameterizedThreadStart(Atribuicoes));
                List<bool> parametros = new List<bool>();
                parametros.Add(true);
                parametros.Add(false);
                Thread t2 = new Thread(new ParameterizedThreadStart(Atribuicoes));
                List<bool> parametros2 = new List<bool>();
                parametros2.Add(true);
                parametros2.Add(true);
                t.Start(parametros);
                t2.Start(parametros2);*/


                /*f.Alimento = txtnomealimentomn.Text;
                f.Energia = txtvalenergia.Text;
                f.Umidade = txtvalumidade.Text;
                f.MS = txtvalmateriaseca.Text;
                f.PB = txtvalproteinabruta.Text;
                f.EE = txtvalextratoetereo.Text;
                f.FB = txtvalfibrabruta.Text;
                f.MM = txtvalmateriamineral.Text;
                f.ENN = txtvalenn.Text;
                f.Ac_Linolenico3 = txtvalaclinoleicon3.Text;
                f.Ac_Linoleico6 = txtvalaclinoleicon6.Text;
                f.Ac_Araquidonico = txtvalacaraquidonico.Text;
                f.EPA_DHA = txtvalepadha.Text;
                f.CNF = txtvalcnf.Text;
                f.FDA = txtvalfda.Text;
                f.FDN = txtvalfdn.Text;
                f.Arg = txtvalarg.Text;
                f.His = txtvalhis.Text;
                f.Iso = txtvaliso.Text;
                f.Leu = txtvalleu.Text;
                f.Lis = txtvallis.Text;
                f.Met = txtvalmet.Text;
                f.Met_Cis = txtvalmetcis.Text;
                f.Fen = txtvalfen.Text;
                f.Fen_Tir = txtvalfentir.Text;
                f.Treo = txtvaltreo.Text;
                f.Tri = txtvaltri.Text;
                f.Val = txtvalval.Text;
                f.Tau = txtvaltau.Text;
                f.Ca = txtvalca.Text;
                f.P = txtvalp.Text;
                f.K = txtvalk.Text;
                f.Na = txtvalna.Text;
                f.Cl = txtvalcl.Text;
                f.Mg = txtvalmg.Text;
                f.Cu = txtvalcu.Text;
                f.I = txtvali.Text;
                f.Fe = txtvalfe.Text;
                f.Mn = txtvalmn.Text;
                f.Se = txtvalse.Text;
                f.Zn = txtvalzn.Text;
                f.S = txtvals.Text;
                f.Vit_A = txtvalvita.Text;
                f.Vit_D = txtvalvitd.Text;
                f.Vit_E = txtvalvite.Text;
                f.Tiamina = txtvaltiamina.Text;
                f.Riboflavina = txtvalriboflavina.Text;
                f.Ac_Pantotenico = txtvalacpantotenico.Text;
                f.Vit_B6 = txtvalvitb6.Text;
                f.Vit_B12 = txtvalvitb12.Text;
                f.Niacina = txtvalniacina.Text;
                f.Ac_Folico = txtvalacfolico.Text;
                f.Biotina = txtvalbiotina.Text;
                f.Colina = txtvalcolina.Text;
                f.Vit_K = txtvalvitk.Text;
                f.Vit_C = txtvalvitc.Text;*/

                lblnomealimentomn.Text = f.Alimento;
                txtvalenergia.Text = f.Energia;
                txtvalumidade.Text = f.Umidade;
                txtvalmateriaseca.Text = f.MS;
                txtvalproteinabruta.Text = f.PB;
                txtvalextratoetereo.Text = f.EE;
                txtvalfibrabruta.Text = f.FB;
                txtvalmateriamineral.Text = f.MM;
                txtvalenn.Text = f.ENN;
                txtvalaclinoleicon3.Text = f.Ac_Linolenico3;
                txtvalaclinoleicon6.Text = f.Ac_Linoleico6;
                txtvalacaraquidonico.Text = f.Ac_Araquidonico;
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
            }
            catch (Exception) { }
            finally
            {
                //f.Desconstrutor();
                //t.Abort();
                //t2.Abort();
            }
        }
        private void btnvoltavisualizaalimentomn_Click(object sender, EventArgs e)
        {
            PaineisPrincipais(pnlalimentosmn, pnlsuperioralimentosmn);
            LimpaCampos(1);
        }
        private void btneditaalimentomn_Click(object sender, EventArgs e)
        {
            Controlatxt(true, true);
            btneditaalimentomn.Enabled = false;
            btneditaalimentomn.Text = "Editando";
            btneditaalimentomn.ForeColor = Color.White;
            btneditaalimentomn.BackColor = Color.Beige;

            btnsalvaalimentomn.Enabled = true;
            btnsalvaalimentomn.Visible = true;
            btncancelareditaoalimentomn.Visible = true;
            btncancelareditaoalimentomn.Enabled = true;

            txtnomealimentomn.Visible = true;
            txtnomealimentomn.Enabled = true;

            Salva = false;
        }
        private void btnsalvaalimentomn_Click(object sender, EventArgs e)
        {
            if (Salva)
            {
                DialogResult resultado = MessageBox.Show("Deseja salvar o novo alimento?", "Atenção", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    f.Alimento = txtnomealimentomn.Text;
                    f.Energia = txtvalenergia.Text;
                    f.Umidade = txtvalumidade.Text;
                    f.MS = txtvalmateriaseca.Text;
                    f.PB = txtvalproteinabruta.Text;
                    f.EE = txtvalextratoetereo.Text;
                    f.FB = txtvalfibrabruta.Text;
                    f.MM = txtvalmateriamineral.Text;
                    f.ENN = txtvalenn.Text;
                    f.Ac_Linolenico3 = txtvalaclinoleicon3.Text;
                    f.Ac_Linoleico6 = txtvalaclinoleicon6.Text;
                    f.Ac_Araquidonico = txtvalacaraquidonico.Text;
                    f.EPA_DHA = txtvalepadha.Text;
                    f.CNF = txtvalcnf.Text;
                    f.FDA = txtvalfda.Text;
                    f.FDN = txtvalfdn.Text;
                    f.Arg = txtvalarg.Text;
                    f.His = txtvalhis.Text;
                    f.Iso = txtvaliso.Text;
                    f.Leu = txtvalleu.Text;
                    f.Lis = txtvallis.Text;
                    f.Met = txtvalmet.Text;
                    f.Met_Cis = txtvalmetcis.Text;
                    f.Fen = txtvalfen.Text;
                    f.Fen_Tir = txtvalfentir.Text;
                    f.Treo = txtvaltreo.Text;
                    f.Tri = txtvaltri.Text;
                    f.Val = txtvalval.Text;
                    f.Tau = txtvaltau.Text;
                    f.Ca = txtvalca.Text;
                    f.P = txtvalp.Text;
                    f.K = txtvalk.Text;
                    f.Na = txtvalna.Text;
                    f.Cl = txtvalcl.Text;
                    f.Mg = txtvalmg.Text;
                    f.Cu = txtvalcu.Text;
                    f.I = txtvali.Text;
                    f.Fe = txtvalfe.Text;
                    f.Mn = txtvalmn.Text;
                    f.Se = txtvalse.Text;
                    f.Zn = txtvalzn.Text;
                    f.S = txtvals.Text;
                    f.Vit_A = txtvalvita.Text;
                    f.Vit_D = txtvalvitd.Text;
                    f.Vit_E = txtvalvite.Text;
                    f.Tiamina = txtvaltiamina.Text;
                    f.Riboflavina = txtvalriboflavina.Text;
                    f.Ac_Pantotenico = txtvalacpantotenico.Text;
                    f.Vit_B6 = txtvalvitb6.Text;
                    f.Vit_B12 = txtvalvitb12.Text;
                    f.Niacina = txtvalniacina.Text;
                    f.Ac_Folico = txtvalacfolico.Text;
                    f.Biotina = txtvalbiotina.Text;
                    f.Colina = txtvalcolina.Text;
                    f.Vit_K = txtvalvitk.Text;
                    f.Vit_C = txtvalvitc.Text;

                    f.InsereAlimentoMN();
                    f.Desconstrutor();
                    LimpaCampos(1);

                    //t.Abort();
                    //t2.Abort();
                    Controlatxt(false, true);
                    dgvalimentosmn.DataSource = f.AtualizaAlimentosMN();
                    PaineisPrincipais(pnlalimentosmn, pnlsuperioralimentosmn);
                }
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Deseja alterar os valores nutricionais do alimento?", "Atenção", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    //atribuição dos valores
                    /*Thread t = new Thread(new ParameterizedThreadStart(Atribuicoes));
                    List<bool> parametros = new List<bool>();
                    parametros.Add(true);
                    parametros.Add(false);
                    Thread t2 = new Thread(new ParameterizedThreadStart(Atribuicoes));
                    List<bool> parametros2 = new List<bool>();
                    parametros2.Add(true);
                    parametros2.Add(true);
                    t.Start(parametros);
                    t2.Start(parametros2);*/
                    f.Alimento = txtnomealimentomn.Text;
                    f.Energia = txtvalenergia.Text;
                    f.Umidade = txtvalumidade.Text;
                    f.MS = txtvalmateriaseca.Text;
                    f.PB = txtvalproteinabruta.Text;
                    f.EE = txtvalextratoetereo.Text;
                    f.FB = txtvalfibrabruta.Text;
                    f.MM = txtvalmateriamineral.Text;
                    f.ENN = txtvalenn.Text;
                    f.Ac_Linolenico3 = txtvalaclinoleicon3.Text;
                    f.Ac_Linoleico6 = txtvalaclinoleicon6.Text;
                    f.Ac_Araquidonico = txtvalacaraquidonico.Text;
                    f.EPA_DHA = txtvalepadha.Text;
                    f.CNF = txtvalcnf.Text;
                    f.FDA = txtvalfda.Text;
                    f.FDN = txtvalfdn.Text;
                    f.Arg = txtvalarg.Text;
                    f.His = txtvalhis.Text;
                    f.Iso = txtvaliso.Text;
                    f.Leu = txtvalleu.Text;
                    f.Lis = txtvallis.Text;
                    f.Met = txtvalmet.Text;
                    f.Met_Cis = txtvalmetcis.Text;
                    f.Fen = txtvalfen.Text;
                    f.Fen_Tir = txtvalfentir.Text;
                    f.Treo = txtvaltreo.Text;
                    f.Tri = txtvaltri.Text;
                    f.Val = txtvalval.Text;
                    f.Tau = txtvaltau.Text;
                    f.Ca = txtvalca.Text;
                    f.P = txtvalp.Text;
                    f.K = txtvalk.Text;
                    f.Na = txtvalna.Text;
                    f.Cl = txtvalcl.Text;
                    f.Mg = txtvalmg.Text;
                    f.Cu = txtvalcu.Text;
                    f.I = txtvali.Text;
                    f.Fe = txtvalfe.Text;
                    f.Mn = txtvalmn.Text;
                    f.Se = txtvalse.Text;
                    f.Zn = txtvalzn.Text;
                    f.S = txtvals.Text;
                    f.Vit_A = txtvalvita.Text;
                    f.Vit_D = txtvalvitd.Text;
                    f.Vit_E = txtvalvite.Text;
                    f.Tiamina = txtvaltiamina.Text;
                    f.Riboflavina = txtvalriboflavina.Text;
                    f.Ac_Pantotenico = txtvalacpantotenico.Text;
                    f.Vit_B6 = txtvalvitb6.Text;
                    f.Vit_B12 = txtvalvitb12.Text;
                    f.Niacina = txtvalniacina.Text;
                    f.Ac_Folico = txtvalacfolico.Text;
                    f.Biotina = txtvalbiotina.Text;
                    f.Colina = txtvalcolina.Text;
                    f.Vit_K = txtvalvitk.Text;
                    f.Vit_C = txtvalvitc.Text;

                    f.AlteraAlimentoMN();
                    f.Desconstrutor();
                    LimpaCampos(1);

                    //t.Abort();
                    //t2.Abort();
                    Controlatxt(false, true);
                    dgvalimentosmn.DataSource = f.AtualizaAlimentosMN();
                    PaineisPrincipais(pnlalimentosmn, pnlsuperioralimentosmn);
                }
            }

        }
        private void btnexcluiralimentomn_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir o alimento?", "Atenção", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                f.DeletaAlimentoMN();
                f.Desconstrutor();
                LimpaCampos(1);
                Controlatxt(false, true);
                dgvalimentosmn.DataSource = f.AtualizaAlimentosMN();
                PaineisPrincipais(pnlalimentosmn, pnlsuperioralimentosmn);
            }
        }
        private void btncancelareditaoalimentomn_Click(object sender, EventArgs e)
        {
            Controlatxt(false, true);
            btneditaalimentomn.Enabled = true;
            btneditaalimentomn.Text = "Editar";
            btneditaalimentomn.ForeColor = Color.White;
            btneditaalimentomn.BackColor = Color.Beige;

            btnsalvaalimentomn.Enabled = false;
            btnsalvaalimentomn.Visible = false;
            btncancelareditaoalimentomn.Visible = false;
            btncancelareditaoalimentomn.Enabled = false;

            txtnomealimentomn.Visible = false;
            txtnomealimentomn.Enabled = false;
        }
        private void btnnovoalimentomn_Click(object sender, EventArgs e)
        {
            PaineisPrincipais(pnlalimentosmn, pnlsuperioralimentosmn, pnlvisualizaalimentosmn);
            LimpaCampos(1);
            Controlatxt(true, true);

            btneditaalimentomn.Visible = false;
            btneditaalimentomn.Enabled = false;
            btnexcluiralimentomn.Visible = false;
            btnexcluiralimentomn.Enabled = false;

            btnsalvaalimentomn.Enabled = true;
            btnsalvaalimentomn.Visible = true;
            btncancelareditaoalimentomn.Visible = true;
            btncancelareditaoalimentomn.Enabled = true;

            txtnomealimentomn.Visible = true;
            txtnomealimentomn.Enabled = true;

            Salva = true;

        }
        #endregion

        #region Painel Alimentos MS
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
        private void txtbuscaalimentoms_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cbxfiltroalimentoms.Text == "Filtro")
                {
                    dgvalimentosms.DataSource = f.AtualizaAlimentosMS();
                }
                else
                {
                    string aux = t.TraduzCombobox(cbxfiltroalimentoms.Text);
                    dgvalimentosms.DataSource = f.PesquisaAlimentosMS(txtbuscaalimentoms.Text, aux);
                }
            }
        }
        private void btnpesquisaalimentoms_Click(object sender, EventArgs e)
        {
            if (cbxfiltroalimentoms.Text == "Filtro")
            {
                dgvalimentosms.DataSource = f.AtualizaAlimentosMS();
            }
            else
            {
                string aux = t.TraduzCombobox(cbxfiltroalimentoms.Text);
                dgvalimentosms.DataSource = f.PesquisaAlimentosMS(txtbuscaalimentoms.Text, aux);
            }
        }
        private void btnvisalimentoms_Click(object sender, EventArgs e)
        {
            PaineisPrincipais(pnlalimentosms, pnlsuperioralimentosms, pnlvisualizaalimentosms);
            Controlatxt(false, false);
            f.id = dgvalimentosms.CurrentRow.Cells[0].Value.ToString();
            try
            {
                f.SelecionaAlimentoMS();

                lblnomealimentoms.Text = f.Alimento;
                txtvalenergiams.Text = f.Energia;
                txtvalumidadems.Text = f.Umidade;
                txtvalmateriasecams.Text = f.MS;
                txtvalproteinabrutams.Text = f.PB;
                txtvalextratoetereoms.Text = f.EE;
                txtvalfibrabrutams.Text = f.FB;
                txtvalmateriamineralms.Text = f.MM;
                txtvalennms.Text = f.ENN;
                txtvalaclinoleicon3ms.Text = f.Ac_Linolenico3;
                txtvalaclinoleicon6ms.Text = f.Ac_Linoleico6;
                txtvalacaraquidonicoms.Text = f.Ac_Araquidonico;
                txtvalepadhams.Text = f.EPA_DHA;
                txtvalcnfms.Text = f.CNF;
                txtvalfdams.Text = f.FDA;
                txtvalfdnms.Text = f.FDN;
                txtvalargms.Text = f.Arg;
                txtvalhisms.Text = f.His;
                txtvalisoms.Text = f.Iso;
                txtvalleums.Text = f.Leu;
                txtvallisms.Text = f.Lis;
                txtvalmetms.Text = f.Met;
                txtvalmetcisms.Text = f.Met_Cis;
                txtvalfenms.Text = f.Fen;
                txtvalfentirms.Text = f.Fen_Tir;
                txtvaltreoms.Text = f.Treo;
                txtvaltrims.Text = f.Tri;
                txtvalvalms.Text = f.Val;
                txtvaltaums.Text = f.Tau;
                txtvalcams.Text = f.Ca;
                txtvalp.Text = f.P;
                txtvalkms.Text = f.K;
                txtvalnams.Text = f.Na;
                txtvalclms.Text = f.Cl;
                txtvalmgms.Text = f.Mg;
                txtvalcums.Text = f.Cu;
                txtvalims.Text = f.I;
                txtvalfems.Text = f.Fe;
                txtvalmnms.Text = f.Mn;
                txtvalsems.Text = f.Se;
                txtvalznms.Text = f.Zn;
                txtvalsms.Text = f.S;
                txtvalvitams.Text = f.Vit_A;
                txtvalvitdms.Text = f.Vit_D;
                txtvalvitems.Text = f.Vit_E;
                txtvaltiaminams.Text = f.Tiamina;
                txtvalriboflavinams.Text = f.Riboflavina;
                txtvalacpantotenicoms.Text = f.Ac_Pantotenico;
                txtvalvitb6ms.Text = f.Vit_B6;
                txtvalvitb12ms.Text = f.Vit_B12;
                txtvalniacinams.Text = f.Niacina;
                txtvalacfolicoms.Text = f.Ac_Folico;
                txtvalbiotinams.Text = f.Biotina;
                txtvalcolinams.Text = f.Colina;
                txtvalvitkms.Text = f.Vit_K;
                txtvalvitcms.Text = f.Vit_C;
            }
            catch (Exception) { }

        }
        private void btnvoltavisualimentoms_Click(object sender, EventArgs e)
        {
            PaineisPrincipais(pnlalimentosms, pnlsuperioralimentosms);
            LimpaCampos(2);
        }
        private void btneditaralimentoms_Click(object sender, EventArgs e)
        {
            Controlatxt(true, false);
            btneditaalimentoms.Enabled = false;
            btneditaalimentoms.Text = "Editando";
            btneditaalimentoms.ForeColor = Color.White;
            btneditaalimentoms.BackColor = Color.Beige;

            btnsalvaalimentoms.Enabled = true;
            btnsalvaalimentoms.Visible = true;
            btncancelaalimentoms.Visible = true;
            btncancelaalimentoms.Enabled = true;

            txtnomealimentoms.Visible = true;
            txtnomealimentoms.Enabled = true;

            Salva = false;
        }
        private void btnsalvaalimentoms_Click(object sender, EventArgs e)
        {
            if (Salva)
            {
                DialogResult resultado = MessageBox.Show("Deseja inserir o novo alimento?", "Atenção", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    f.Alimento = txtnomealimentoms.Text;
                    f.Energia = txtvalenergiams.Text;
                    f.Umidade = txtvalumidadems.Text;
                    f.MS = txtvalmateriasecams.Text;
                    f.PB = txtvalproteinabrutams.Text;
                    f.EE = txtvalextratoetereoms.Text;
                    f.FB = txtvalfibrabrutams.Text;
                    f.MM = txtvalmateriamineralms.Text;
                    f.ENN = txtvalennms.Text;
                    f.Ac_Linolenico3 = txtvalaclinoleicon3ms.Text;
                    f.Ac_Linoleico6 = txtvalaclinoleicon6ms.Text;
                    f.Ac_Araquidonico = txtvalacaraquidonicoms.Text;
                    f.EPA_DHA = txtvalepadhams.Text;
                    f.CNF = txtvalcnfms.Text;
                    f.FDA = txtvalfdams.Text;
                    f.FDN = txtvalfdnms.Text;
                    f.Arg = txtvalargms.Text;
                    f.His = txtvalhisms.Text;
                    f.Iso = txtvalisoms.Text;
                    f.Leu = txtvalleums.Text;
                    f.Lis = txtvallisms.Text;
                    f.Met = txtvalmetms.Text;
                    f.Met_Cis = txtvalmetcisms.Text;
                    f.Fen = txtvalfenms.Text;
                    f.Fen_Tir = txtvalfentirms.Text;
                    f.Treo = txtvaltreoms.Text;
                    f.Tri = txtvaltrims.Text;
                    f.Val = txtvalvalms.Text;
                    f.Tau = txtvaltaums.Text;
                    f.Ca = txtvalcams.Text;
                    f.P = txtvalpms.Text;
                    f.K = txtvalkms.Text;
                    f.Na = txtvalnams.Text;
                    f.Cl = txtvalclms.Text;
                    f.Mg = txtvalmgms.Text;
                    f.Cu = txtvalcums.Text;
                    f.I = txtvalims.Text;
                    f.Fe = txtvalfems.Text;
                    f.Mn = txtvalmnms.Text;
                    f.Se = txtvalsems.Text;
                    f.Zn = txtvalznms.Text;
                    f.S = txtvalsms.Text;
                    f.Vit_A = txtvalvitams.Text;
                    f.Vit_D = txtvalvitdms.Text;
                    f.Vit_E = txtvalvitems.Text;
                    f.Tiamina = txtvaltiaminams.Text;
                    f.Riboflavina = txtvalriboflavinams.Text;
                    f.Ac_Pantotenico = txtvalacpantotenicoms.Text;
                    f.Vit_B6 = txtvalvitb6ms.Text;
                    f.Vit_B12 = txtvalvitb12ms.Text;
                    f.Niacina = txtvalniacinams.Text;
                    f.Ac_Folico = txtvalacfolicoms.Text;
                    f.Biotina = txtvalbiotinams.Text;
                    f.Colina = txtvalcolinams.Text;
                    f.Vit_K = txtvalvitkms.Text;
                    f.Vit_C = txtvalvitcms.Text;

                    f.InsereAlimentoMS();
                    f.Desconstrutor();
                    LimpaCampos(2);

                    //t.Abort();
                    //t2.Abort();
                    Controlatxt(false, false);
                    dgvalimentosms.DataSource = f.AtualizaAlimentosMS();
                    PaineisPrincipais(pnlalimentosms, pnlsuperioralimentosms);
                }
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Deseja alterar os valores nutricionais do alimento?", "Atenção", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    //atribuição dos valores
                    /*Thread t = new Thread(new ParameterizedThreadStart(Atribuicoes));
                    List<bool> parametros = new List<bool>();
                    parametros.Add(true);
                    parametros.Add(false);
                    Thread t2 = new Thread(new ParameterizedThreadStart(Atribuicoes));
                    List<bool> parametros2 = new List<bool>();
                    parametros2.Add(true);
                    parametros2.Add(true);
                    t.Start(parametros);
                    t2.Start(parametros2);*/
                    f.Alimento = txtnomealimentoms.Text;
                    f.Energia = txtvalenergiams.Text;
                    f.Umidade = txtvalumidadems.Text;
                    f.MS = txtvalmateriasecams.Text;
                    f.PB = txtvalproteinabrutams.Text;
                    f.EE = txtvalextratoetereoms.Text;
                    f.FB = txtvalfibrabrutams.Text;
                    f.MM = txtvalmateriamineralms.Text;
                    f.ENN = txtvalennms.Text;
                    f.Ac_Linolenico3 = txtvalaclinoleicon3ms.Text;
                    f.Ac_Linoleico6 = txtvalaclinoleicon6ms.Text;
                    f.Ac_Araquidonico = txtvalacaraquidonicoms.Text;
                    f.EPA_DHA = txtvalepadhams.Text;
                    f.CNF = txtvalcnfms.Text;
                    f.FDA = txtvalfdams.Text;
                    f.FDN = txtvalfdnms.Text;
                    f.Arg = txtvalargms.Text;
                    f.His = txtvalhisms.Text;
                    f.Iso = txtvalisoms.Text;
                    f.Leu = txtvalleums.Text;
                    f.Lis = txtvallisms.Text;
                    f.Met = txtvalmetms.Text;
                    f.Met_Cis = txtvalmetcisms.Text;
                    f.Fen = txtvalfenms.Text;
                    f.Fen_Tir = txtvalfentirms.Text;
                    f.Treo = txtvaltreoms.Text;
                    f.Tri = txtvaltrims.Text;
                    f.Val = txtvalvalms.Text;
                    f.Tau = txtvaltaums.Text;
                    f.Ca = txtvalcams.Text;
                    f.P = txtvalpms.Text;
                    f.K = txtvalkms.Text;
                    f.Na = txtvalnams.Text;
                    f.Cl = txtvalclms.Text;
                    f.Mg = txtvalmgms.Text;
                    f.Cu = txtvalcums.Text;
                    f.I = txtvalims.Text;
                    f.Fe = txtvalfems.Text;
                    f.Mn = txtvalmnms.Text;
                    f.Se = txtvalsems.Text;
                    f.Zn = txtvalznms.Text;
                    f.S = txtvalsms.Text;
                    f.Vit_A = txtvalvitams.Text;
                    f.Vit_D = txtvalvitdms.Text;
                    f.Vit_E = txtvalvitems.Text;
                    f.Tiamina = txtvaltiaminams.Text;
                    f.Riboflavina = txtvalriboflavinams.Text;
                    f.Ac_Pantotenico = txtvalacpantotenicoms.Text;
                    f.Vit_B6 = txtvalvitb6ms.Text;
                    f.Vit_B12 = txtvalvitb12ms.Text;
                    f.Niacina = txtvalniacinams.Text;
                    f.Ac_Folico = txtvalacfolicoms.Text;
                    f.Biotina = txtvalbiotinams.Text;
                    f.Colina = txtvalcolinams.Text;
                    f.Vit_K = txtvalvitkms.Text;
                    f.Vit_C = txtvalvitcms.Text;

                    f.AlteraAlimentoMS();
                    f.Desconstrutor();
                    LimpaCampos(2);

                    //t.Abort();
                    //t2.Abort();
                    Controlatxt(false, false);
                    dgvalimentosms.DataSource = f.AtualizaAlimentosMS();
                    PaineisPrincipais(pnlalimentosms, pnlsuperioralimentosms);
                }
            }

        }
        private void btnexcluiralimentoms_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir o alimento?", "Atenção", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                f.DeletaAlimentoMS();
                f.Desconstrutor();
                LimpaCampos(2);
                Controlatxt(false, false);
                dgvalimentosms.DataSource = f.AtualizaAlimentosMS();
                PaineisPrincipais(pnlalimentosms, pnlvisualizaalimentosms, pnlsuperioralimentosms);
            }
        }
        private void btncancelaalimentoms_Click(object sender, EventArgs e)
        {
            Controlatxt(false, false);
            btneditaalimentoms.Enabled = true;
            btneditaalimentoms.Text = "Editar";
            btneditaalimentoms.ForeColor = Color.White;
            btneditaalimentoms.BackColor = Color.Beige;

            btnsalvaalimentoms.Enabled = false;
            btnsalvaalimentoms.Visible = false;
            btncancelaalimentoms.Visible = false;
            btncancelaalimentoms.Enabled = false;

            txtnomealimentoms.Visible = false;
            txtnomealimentoms.Enabled = false;
        }
        private void btnnovoalimentoms_Click(object sender, EventArgs e)
        {
            PaineisPrincipais(pnlalimentosms, pnlsuperioralimentosms, pnlvisualizaalimentosms);
            LimpaCampos(2);
            Controlatxt(true, false);

            btneditaalimentoms.Visible = false;
            btneditaalimentoms.Enabled = false;
            btnexcluiralimentoms.Visible = false;
            btnexcluiralimentoms.Enabled = false;

            btnsalvaalimentoms.Enabled = true;
            btnsalvaalimentoms.Visible = true;
            btncancelaalimentoms.Visible = true;
            btncancelaalimentoms.Enabled = true;

            txtnomealimentoms.Visible = true;
            txtnomealimentoms.Enabled = true;

            Salva = true;
        }
        #endregion

        #region Painel Formulacao

        #endregion

        #region Painel Especies
        private void btnvisualizarespecie_Click(object sender, EventArgs e)
        {
            txtcadastronomeespecie.Enabled = true;
            txtcadastronem.Enabled = true;
        }
        private void btnadicionarespecie_Click(object sender, EventArgs e)
        {
            pnlcalcnem.Visible = true;
        }
        private void btncancelacadastroespecie_Click(object sender, EventArgs e)
        {
            LimpaCampos(3);
        }
        private void btncalcnem1_Click(object sender, EventArgs e)
        {
            txtformulanem.Text += "1";
        }
        private void btncalcnem2_Click(object sender, EventArgs e)
        {
            txtformulanem.Text += "2";
        }
        private void btncalcnem3_Click(object sender, EventArgs e)
        {
            txtformulanem.Text += "3";
        }
        private void btncalcnem4_Click(object sender, EventArgs e)
        {
            txtformulanem.Text += "4";
        }
        private void btncalcnem5_Click(object sender, EventArgs e)
        {
            txtformulanem.Text += "5";
        }
        private void btncalcnem6_Click(object sender, EventArgs e)
        {
            txtformulanem.Text += "6";
        }
        private void btncalcnem7_Click(object sender, EventArgs e)
        {
            txtformulanem.Text += "7";
        }
        private void btncalcnem8_Click(object sender, EventArgs e)
        {
            txtformulanem.Text += "8";
        }
        private void btncalcnem9_Click(object sender, EventArgs e)
        {
            txtformulanem.Text += "9";
        }
        private void btncalcnemparentesesd_Click(object sender, EventArgs e)
        {
            txtformulanem.Text += "(";
        }
        private void btncalcnemparentesese_Click(object sender, EventArgs e)
        {
            txtformulanem.Text += ")";
        }
        private void btncalcnemdivisao_Click(object sender, EventArgs e)
        {
            txtformulanem.Text += @"/";
        }
        private void btncalcnemmultiplicacao_Click(object sender, EventArgs e)
        {
            txtformulanem.Text += "*";
        }
        private void btncalcnempeso_Click(object sender, EventArgs e)
        {
            txtformulanem.Text += "PESO";
        }
        private void btncalcnemraiz_Click(object sender, EventArgs e)
        {
            txtformulanem.Text += "√(";
        }
        private void btncalcnempotencia_Click(object sender, EventArgs e)
        {
            txtformulanem.Text += "^(";
        }
        private void btncalcnemapagar_Click(object sender, EventArgs e)
        {
            txtformulanem.Text = string.Empty;
        }
        private void btncalcnemsubtracao_Click(object sender, EventArgs e)
        {
            txtformulanem.Text += "-";
        }
        private void btncalcnemadicao_Click(object sender, EventArgs e)
        {
            txtformulanem.Text += "+";
        }
        private void btncalcnemvirugla_Click(object sender, EventArgs e)
        {
            txtformulanem.Text += ",";
        }
        private void btncalcnemsalvaformula_Click(object sender, EventArgs e)
        {
            foreach(char c in txtformulanem.Text)
            {
                if (txtformulanem.Text.Contains("("))
                {
                    contaparenteses++;
                }
                else if (txtformulanem.Text.Contains(")"))
                {
                    contaparenteses--;
                }
            }
            if (contaparenteses > 0)
            {
                MessageBox.Show("Você se esqueceu de fechar o parenteses em algum lugar. Por favor verifique a função");
            }
            else if(contaparenteses < 0)
            {
                MessageBox.Show("Você colocou mais parenteses que o necessário. Por favor verifique a função");
            }
            else
            {/*
                List<string> entreparenteses = new List<string>();
                string funcao = string.Empty;
                bool montando = false;
                foreach (char c in txtformulanem.Text)
                {
                    if (montando)
                    {
                        funcao += c.ToString();
                    }
                    if (txtformulanem.Text.Contains("("))
                    {
                        contaparenteses++;
                    }
                    else if (txtformulanem.Text.Contains(")"))
                    {
                        contaparenteses--;
                    }
                    if (contaparenteses == 0)
                    {
                        if (funcao == "ok")
                        {
                            funcao = funcao.Substring(2);
                            entreparenteses.Add(funcao);
                        }
                       Math.Sqrt(123);
                    }
                    else if(contaparenteses>0)
                    {
                        funcao = "ok";
                        montando = true;
                    }
                    if (c == '√')
                    {
                        
                        string aux;
                        //aux = txtformulanem.Text.Substring()
                    }
                }
                if (txtformulanem.Text.Contains("√"))
                {
                    string aux;
                    //aux = txtformulanem.Text.Substring()
                }*/
            }
        }
        private void btnsalvacadastroespecie_Click(object sender, EventArgs e)
        {

        }


        #endregion


    }
}

