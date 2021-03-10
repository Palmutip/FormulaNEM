using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoNariz.Classes;
using MySql.Data.MySqlClient;

namespace ProjetoNariz
{
    class FuncoesBanco
    {
        #region Variaveis de inicialização

        #region Variaveis do Banco
        ConectaBanco conectabanco = new ConectaBanco();
        ConectaMySQL conectaMySQL = new ConectaMySQL();
        #endregion

        public string id { get; set; }

        #region Variaveis das tabelas de Alimento
        public string Alimento { get; set; }
        public string Energia { get; set; }
        public string Umidade { get; set; }
        public string MS { get; set; }
        public string PB { get; set; }
        public string Arg { get; set; }
        public string His { get; set; }
        public string Iso { get; set; }
        public string Leu { get; set; }
        public string Lis { get; set; }
        public string Met { get; set; }
        public string Met_Cis { get; set; }
        public string Fen { get; set; }
        public string Fen_Tir { get; set; }
        public string Treo { get; set; }
        public string Tri { get; set; }
        public string Val { get; set; }
        public string Tau { get; set; }
        public string EE { get; set; }
        public string Ac_Linoleico6 { get; set; }
        public string Ac_Linolenico3 { get; set; }
        public string Ac_Araquidonico { get; set; }
        public string EPA_DHA { get; set; }
        public string MM { get; set; }
        public string Ca { get; set; }
        public string P { get; set; }
        public string K { get; set; }
        public string Na { get; set; }
        public string Cl { get; set; }
        public string Mg { get; set; }
        public string Cu { get; set; }
        public string I { get; set; }
        public string Fe { get; set; }
        public string Mn { get; set; }
        public string Se { get; set; }
        public string Zn { get; set; }
        public string S { get; set; }
        public string Carboidratos { get; set; }
        public string FB { get; set; }
        public string ENN { get; set; }
        public string FDN { get; set; }
        public string FDA { get; set; }
        public string CNF { get; set; }
        public string Vit_A { get; set; }
        public string Vit_D { get; set; }
        public string Vit_E { get; set; }
        public string Tiamina { get; set; }
        public string Riboflavina { get; set; }
        public string Ac_Pantotenico { get; set; }
        public string Vit_B6 { get; set; }
        public string Vit_B12 { get; set; }
        public string Niacina { get; set; }
        public string Ac_Folico { get; set; }
        public string Biotina { get; set; }
        public string Colina { get; set; }
        public string Vit_K { get; set; }
        public string Vit_C { get; set; }
        public string Correcao_ENN { get; set; }
        public string Preco { get; set; }
        #endregion

        #region Variaveis da Medida Caseira
        public string Un_P { get; set; }
        public string Un_M { get; set; }
        public string Un_G { get; set; }
        public string Folha_P { get; set; }
        public string Folha_M { get; set; }
        public string Folha_G { get; set; }
        public string Colher_Sopa_P { get; set; }
        public string Colher_Sopa_M { get; set; }
        public string Colher_Sopa_G { get; set; }
        public string Colher_Arroz { get; set; }
        public string Escumadeira_P { get; set; }
        public string Escumadeira_M { get; set; }
        public string Escumadeira_G { get; set; }
        public string Fatia_P { get; set; }
        public string Fatia_M { get; set; }
        public string Fatia_G { get; set; }
        public string Pedaco_P { get; set; }
        public string Pedaco_M { get; set; }
        public string Pedaco_G { get; set; }
        public string Pires { get; set; }
        public string Colher { get; set; }
        public string Xicara { get; set; }
        public string Copo_Requeijao { get; set; }
        public string Prato_G { get; set; }
        public string Prato_P { get; set; }
        public string Colher_Sobremesa { get; set; }
        public string Bago { get; set; }
        public string Cacho_P { get; set; }
        public string Cacho_M { get; set; }
        public string Cacho_G { get; set; }
        public string Colher_Cafe { get; set; }
        public string Colher_Cha { get; set; }
        public string File { get; set; }
        public string Bife { get; set; }
        public string Lata { get; set; }
        public string Copo { get; set; }
        public string Ramo { get; set; }
        public string Maco { get; set; }
        public string Pitada { get; set; }
        #endregion

        #region Variaveis das Especies
        public string Nome { get; set; }
        public string Formula { get; set; }
        #endregion

        #region Variaveis da criação de Dietas
        public double Percentagem { get; set; }
        public double Maximo { get; set; }
        public double Minimo { get; set; }
        #endregion
        //Vit_D
        #endregion

        public void Desconstrutor()
        {
            Alimento = string.Empty;
            Energia = string.Empty;
            Umidade = string.Empty;
            MS = string.Empty;
            Alimento = string.Empty;
            PB = string.Empty;
            Arg = string.Empty;
            His = string.Empty;
            Iso = string.Empty;
            Leu = string.Empty;
            Lis = string.Empty;
            Met = string.Empty;
            Met_Cis = string.Empty;
            Fen = string.Empty;
            Fen_Tir = string.Empty;
            Treo = string.Empty;
            Tri = string.Empty;
            Val = string.Empty;
            Tau = string.Empty;
            EE = string.Empty;
            Ac_Linolenico3 = string.Empty;
            Ac_Araquidonico = string.Empty;
            Ac_Linoleico6 = string.Empty;
            EPA_DHA = string.Empty;
            MM = string.Empty;
            Ca = string.Empty;
            P = string.Empty;
            K = string.Empty;
            Na = string.Empty;
            Cl = string.Empty;
            Mg = string.Empty;
            Cu = string.Empty;
            I = string.Empty;
            Fe = string.Empty;
            Mn = string.Empty;
            Se = string.Empty;
            Zn = string.Empty;
            S = string.Empty;
            Carboidratos = string.Empty;
            FB = string.Empty;
            ENN = string.Empty;
            FDN = string.Empty;
            FDA = string.Empty;
            CNF = string.Empty;
            Vit_A = string.Empty;
            Vit_D = string.Empty;
            Vit_E = string.Empty;
            Tiamina = string.Empty;
            Riboflavina = string.Empty;
            Ac_Pantotenico = string.Empty;
            Vit_B6 = string.Empty;
            Vit_B12 = string.Empty;
            Niacina = string.Empty;
            Ac_Folico = string.Empty;
            Biotina = string.Empty;
            Colina = string.Empty;
            Vit_K = string.Empty;
            Vit_C = string.Empty;
            Correcao_ENN = string.Empty;
            Preco = string.Empty;
            Un_P = string.Empty;
            Un_M = string.Empty;
            Un_G = string.Empty;
            Folha_P = string.Empty;
            Folha_M = string.Empty;
            Folha_G = string.Empty;
            Colher_Sopa_P = string.Empty;
            Colher_Sopa_M = string.Empty;
            Colher_Sopa_G = string.Empty;
            Colher_Arroz = string.Empty;
            Escumadeira_P = string.Empty;
            Escumadeira_M = string.Empty;
            Escumadeira_G = string.Empty;
            Fatia_P = string.Empty;
            Fatia_M = string.Empty;
            Fatia_G = string.Empty;
            Pedaco_P = string.Empty;
            Pedaco_M = string.Empty;
            Pedaco_G = string.Empty;
            Pires = string.Empty;
            Colher = string.Empty;
            Xicara = string.Empty;
            Copo_Requeijao = string.Empty;
            Prato_G = string.Empty;
            Prato_P = string.Empty;
            Colher_Sobremesa = string.Empty;
            Bago = string.Empty;
            Cacho_P = string.Empty;
            Cacho_M = string.Empty;
            Cacho_G = string.Empty;
            Colher_Cafe = string.Empty;
            Colher_Cha = string.Empty;
            File = string.Empty;
            Bife = string.Empty;
            Lata = string.Empty;
            Copo = string.Empty;
            Ramo = string.Empty;
            Maco = string.Empty;
            Pitada = string.Empty;
            Nome = string.Empty;
            Formula = string.Empty;
            Percentagem = 0.00;
            Maximo = 0.00;
            Minimo = 0.00;
        }

        //Controles Alimentos MN
        #region Alimentos_MN
        public DataTable AtualizaAlimentosMN()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conectaMySQL.AbreMySQL();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select id, Alimento, Energia AS 'Energia (kcal)', Umidade AS	'Umidade (%)'," +
                "MS AS 'MS (%)', PB AS 'PB (%)', Arg AS 'Arg (%)', His AS 'His (%)', Iso AS 'Iso (%)'," +
                "Leu AS 'Leu (%)', Lis AS 'Lis (%)', Met AS 'Met (%)', Met_Cis AS 'Met + Cis  (%)'," +
                "Fen AS 'Fen  (%)', Fen_Tir AS 'Fen + Tir (%)', Treo AS 'Treo (%)', Tri AS 'Tri (%)'," +
                "Val AS 'Val (%)', Tau AS 'Tau (%)', EE AS 'EE (%)', Ac_Linoleico6 AS 'Ac. Linoleico n-6 (%)'," +
                "Ac_Araquidonico AS 'Ac. Araquidonico (mg)', Ac_Linolenico3 AS 'Ac. Linolenico n-3 (%)'," +
                "EPA_DHA AS 'EPA + DHA (%)', MM AS 'MM (%)', Ca AS 'Ca (mg)', P AS 'P (mg)',K AS 'K (mg)'," +
                "Na AS 'Na (mg)', Cl AS 'Cl (mg)', Mg AS 'Mg (mg)', Cu AS 'Cu (mg)', I AS 'I (mg)'," +
                "Fe AS 'Fe (mg)', Mn AS 'Mn (mg)', Se AS 'Se (mg)', Zn AS 'Zn (mg)', S AS 'S (mg)'," +
                "Carboidratos AS 'Carboidratos (%)', FB AS 'FB (%)', ENN AS 'ENN (%)',FDN AS 'FDN (%)'," +
                "FDA AS 'FDA (%)', CNF AS 'CNF (%)', Vit_A AS 'Vit A (UI)', Vit_D AS 'Vit D (UI)'," +
                "Vit_E AS 'Vit E (UI)', Tiamina AS 'Tiamina (mg)', Riboflavina AS 'Riboflavina (mg)'," +
                "Ac_Pantotenico AS	'Ac. Pantotenico (mg)', Vit_B6 AS 'Vit. B6 (mg)', Vit_B12 AS 'Vit. B12 (mg)'," +
                "Niacina AS 'Niacina (mg)', Ac_Folico AS 'Ac. Folico (mg)', Biotina AS 'Biotina (mg)'," +
                "Colina AS 'Colina (mg)', Vit_K AS 'Vit. K (mg)', Vit_C AS 'Vit. C (mg)'," +
                "Preco AS 'Preco/kg (R$)' from alimentosmn";

            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = cmd;

            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            conectaMySQL.FechaMySQL();

            return dt;
        }
        public DataTable PesquisaAlimentosMN(string TextoPesquisa, string coluna)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conectaMySQL.AbreMySQL();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from alimentosmn where "  + coluna + " like '%" + TextoPesquisa + "%'";

            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = cmd;

            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            conectaMySQL.FechaMySQL();

            return dt;
        }
        public void SelecionaAlimentoMN()
        {
            string SQL;
            SQL = "Select * from alimentosmn where id=" + id;

            MySqlDataReader dados = conectaMySQL.ExecutaConsulta(SQL);

            if (dados.Read())
            {
                Alimento = dados["Alimento"].ToString();
                Energia = dados["Energia"].ToString();
                Umidade = dados["Umidade"].ToString();
                MS = dados["MS"].ToString();
                Alimento = dados["Alimento"].ToString();
                PB = dados["PB"].ToString();
                Arg = dados["Arg"].ToString();
                His = dados["His"].ToString();
                Iso = dados["Iso"].ToString();
                Leu = dados["Leu"].ToString();
                Lis = dados["Lis"].ToString();
                Met = dados["Met"].ToString();
                Met_Cis = dados["Met_Cis"].ToString();
                Fen = dados["Fen"].ToString();
                Fen_Tir = dados["Fen_Tir"].ToString();
                Treo = dados["Treo"].ToString();
                Tri = dados["Tri"].ToString();
                Val = dados["Val"].ToString();
                Tau = dados["Tau"].ToString();
                EE = dados["EE"].ToString();
                Ac_Linolenico3 = dados["Ac_Linolenico3"].ToString();
                Ac_Araquidonico = dados["Ac_Araquidonico"].ToString();
                Ac_Linoleico6 = dados["Ac_Linoleico6"].ToString();
                EPA_DHA = dados["EPA_DHA"].ToString();
                MM = dados["MM"].ToString();
                Ca = dados["Ca"].ToString();
                P = dados["P"].ToString();
                K = dados["K"].ToString();
                Na = dados["Na"].ToString();
                Cl = dados["Cl"].ToString();
                Mg = dados["Mg"].ToString();
                Cu = dados["Cu"].ToString();
                I = dados["I"].ToString();
                Fe = dados["Fe"].ToString();
                Mn = dados["Mn"].ToString();
                Se = dados["Se"].ToString();
                Zn = dados["Zn"].ToString();
                S = dados["S"].ToString();
                Carboidratos = dados["Carboidratos"].ToString();
                FB = dados["FB"].ToString();
                ENN = dados["ENN"].ToString();
                FDN = dados["FDN"].ToString();
                FDA = dados["FDA"].ToString();
                CNF = dados["CNF"].ToString();
                Vit_A = dados["Vit_A"].ToString();
                Vit_D = dados["Vit_D"].ToString();
                Vit_E = dados["Vit_E"].ToString();
                Tiamina = dados["Tiamina"].ToString();
                Riboflavina = dados["Riboflavina"].ToString();
                Ac_Pantotenico = dados["Ac_Pantotenico"].ToString();
                Vit_B6 = dados["Vit_B6"].ToString();
                Vit_B12 = dados["Vit_B12"].ToString();
                Niacina = dados["Niacina"].ToString();
                Ac_Folico = dados["Ac_Folico"].ToString();
                Biotina = dados["Biotina"].ToString();
                Colina = dados["Colina"].ToString();
                Vit_K = dados["Vit_K"].ToString();
                Vit_C = dados["Vit_C"].ToString();
                //Correcao_ENN = dados["Correcao_ENN"].ToString();
                Preco = dados["Preco"].ToString();
                /*Un_P = dados["Un_P"].ToString();
                Un_M = dados["Un_M"].ToString();
                Un_G = dados["Un_G"].ToString();
                Folha_P = dados["Folha_P"].ToString();
                Folha_M = dados["Folha_M"].ToString();
                Folha_G = dados["Folha_G"].ToString();
                Colher_Sopa_P = dados["Colher_Sopa_P"].ToString();
                Colher_Sopa_M = dados["Colher_Sopa_M"].ToString();
                Colher_Sopa_G = dados["Colher_Sopa_G"].ToString();
                Colher_Arroz = dados["Colher_Arroz"].ToString();
                Escumadeira_P = dados["Escumadeira_P"].ToString();
                Escumadeira_M = dados["Escumadeira_M"].ToString();
                Escumadeira_G = dados["Escumadeira_G"].ToString();
                Fatia_P = dados["Fatia_P"].ToString();
                Fatia_M = dados["Fatia_M"].ToString();
                Fatia_G = dados["Fatia_G"].ToString();
                Pedaco_P = dados["Pedaco_P"].ToString();
                Pedaco_M = dados["Pedaco_M"].ToString();
                Pedaco_G = dados["Pedaco_G"].ToString();
                Pires = dados["Pires"].ToString();
                Colher = dados["Colher"].ToString();
                Xicara = dados["Xicara"].ToString();
                Copo_Requeijao = dados["Copo_Requeijao"].ToString();
                Prato_G = dados["Prato_G"].ToString();
                Prato_P = dados["Prato_P"].ToString();
                Colher_Sobremesa = dados["Colher_Sobremesa"].ToString();
                Bago = dados["Bago"].ToString();
                Cacho_P = dados["Cacho_P"].ToString();
                Cacho_M = dados["Cacho_M"].ToString();
                Cacho_G = dados["Cacho_G"].ToString();
                Colher_Cafe = dados["Colher_Cafe"].ToString();
                Colher_Cha = dados["Colher_Cha"].ToString();
                File = dados["File"].ToString();
                Bife = dados["Bife"].ToString();
                Lata = dados["Lata"].ToString();
                Copo = dados["Copo"].ToString();
                Ramo = dados["Ramo"].ToString();
                Maco = dados["Maco"].ToString();
                Pitada = dados["Pitada"].ToString();*/
            }
            conectaMySQL.FechaMySQL();
        }
        public void InsereAlimentoMN()
        {
            string SQL;

            SQL = "Insert into alimentosmn (Alimento, Energia, Umidade, MS, PB, Arg, His, Iso, Leu, " +
            "Lis, Met, Met_Cis, Fen, Fen_Tir, Treo, Tri, " +
            " Val, Tau, EE, Ac_Linoleico6, Ac_Araquidonico, Ac_Linolenico3, EPA_DHA, MM, Ca, P, K, Na, Cl, Mg, Cu, I, Fe, Mn" +
            ", Se, Zn, S, Carboidratos, FB, ENN, FDN, FDA, CNF, Vit_A, Vit_D, Vit_E" +
            ", Tiamina, Riboflavina, Ac_Pantotenico, Vit_B6, Vit_B12, Niacina, Ac_Folico, Biotina, Colina, Vit_K, Vit_C) " +
            "values('" + Alimento + "','" + Energia + "','" + Umidade + "','" + MS + "','" + PB + "', " +
            "'" + Arg + "','" + His + "','" + Iso + "','" + Leu + "','" + Lis + "','" + Met + "'," +
            "'" + Met_Cis + "','" + Fen + "','" + Fen_Tir + "','" + Treo + "'," +
            "'" + Tri + "','" + Val + "','" + Tau + "','" + EE + "','" + Ac_Linoleico6 + "','" + Ac_Araquidonico + "','" + Ac_Linolenico3 + "', " +
            "'" + EPA_DHA + "','" + MM + "','" + Ca + "','" + P + "','" + K + "','" + Na + "','" + Cl + "','" + Mg + "', " +
            "'" + Cu + "','" + I + "','" + Fe + "','" + Mn + "','" + Se + "','" + Zn + "','" + S + "'" +
            ",'" + Carboidratos + "','" + FB + "','" + ENN + "','" + FDN + "','" + FDA + "','" + CNF + "'" +
            ",'" + Vit_A + "','" + Vit_D + "','" + Vit_E + "','" + Tiamina + "','" + Riboflavina + "','" + Ac_Pantotenico + "'" +
            ",'" + Vit_B6 + "','" + Vit_B12 + "','" + Niacina + "','" + Ac_Folico + "','" + Biotina + "','" + Colina + "'" +
            ",'" + Vit_K + "','" + Vit_C + "');";

            conectaMySQL.ExecutaComando(SQL);
            conectaMySQL.FechaMySQL();
        }
        public void AlteraAlimentoMN()
        {
            string SQL;

            SQL = "Update alimentosmn set Alimento ='" + Alimento + "', Energia ='" + Energia + "', Umidade ='" + Umidade + "', MS ='" + MS + "', PB ='" + PB + "'," +
            " Arg ='" + Arg + "', His ='" + His + "', Iso ='" + Iso + "', Leu ='" + Leu + "'," +
            " Lis ='" + Lis + "', Met ='" + Met + "', Met_Cis ='" + Met_Cis + "', Fen ='" + Fen + "', " +
            " Fen_Tir ='" + Fen_Tir + "', Treo ='" + Treo + "', Tri ='" + Tri + "', " +
            " Val ='" + Val + "', Tau ='" + Tau + "', EE='" + EE + "', Ac_Linoleico6 = '" + Ac_Linoleico6 + "', Ac_Araquidonico = '" + Ac_Araquidonico + "', " +
            " Ac_Linolenico3 = '" + Ac_Linolenico3 + "', EPA_DHA ='" + EPA_DHA + "', MM ='" + MM + "', Ca ='" + Ca + "', P ='" + P + "', K ='" + K + "', " +
            " Na ='" + Na + "', Cl ='" + Cl + "', Mg ='" + Mg + "', Cu ='" + Cu + "', I ='" + I + "', Fe ='" + Fe + "', Mn ='" + Mn + "'" +
            ", Se ='" + Se + "', Zn ='" + Zn + "', S ='" + S + "', Carboidratos ='" + Carboidratos + "', FB ='" + FB + "', ENN ='" + ENN + "'" +
            ", FDN ='" + FDN + "', FDA ='" + FDA + "', CNF ='" + CNF + "', Vit_A ='" + Vit_A + "', Vit_D ='" + Vit_D + "', Vit_E ='" + Vit_E + "'" +
            ", Tiamina ='" + Tiamina + "', Riboflavina ='" + Riboflavina + "', Ac_Pantotenico ='" + Ac_Pantotenico + "', Vit_B6 ='" + Vit_B6 + "', Vit_B12 ='" + Vit_B12 + "', Niacina ='" + Niacina + "', Ac_Folico ='" + Ac_Folico + "'" +
            ", Biotina ='" + Biotina + "', Colina ='" + Colina + "', Vit_K ='" + Vit_K + "', Vit_C ='" + Vit_C + "' where Id =" +id + ";";

            conectaMySQL.ExecutaComando(SQL);
            conectaMySQL.FechaMySQL();
        }
        public void DeletaAlimentoMN()
        {
            string SQL;

            SQL = "Delete from alimentosmn where Id=" + id + ";";
            conectaMySQL.ExecutaComando(SQL);
            conectaMySQL.FechaMySQL();
        }
        #endregion

        //Controles Alimentos MS
        #region Alimentos_MS
        public DataTable AtualizaAlimentosMS()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conectaMySQL.AbreMySQL();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select id, Alimento, Energia AS 'Energia (kcal)', Umidade AS	'Umidade (%)'," +
                "MS AS 'MS (%)', PB AS 'PB (%)', Arg AS 'Arg (%)', His AS 'His (%)', Iso AS 'Iso (%)'," +
                "Leu AS 'Leu (%)', Lis AS 'Lis (%)', Met AS 'Met (%)', Met_Cis AS 'Met + Cis  (%)'," +
                "Fen AS 'Fen  (%)', Fen_Tir AS 'Fen + Tir (%)', Treo AS 'Treo (%)', Tri AS 'Tri (%)'," +
                "Val AS 'Val (%)', Tau AS 'Tau (%)', EE AS 'EE (%)', Ac_Linoleico6 AS 'Ac. Linoleico n-6 (%)'," +
                "Ac_Araquidonico AS 'Ac. Araquidonico (mg)', Ac_Linolenico3 AS 'Ac. Linolenico n-3 (%)'," +
                "EPA_DHA AS 'EPA + DHA (%)', MM AS 'MM (%)', Ca AS 'Ca (mg)', P AS 'P (mg)',K AS 'K (mg)'," +
                "Na AS 'Na (mg)', Cl AS 'Cl (mg)', Mg AS 'Mg (mg)', Cu AS 'Cu (mg)', I AS 'I (mg)'," +
                "Fe AS 'Fe (mg)', Mn AS 'Mn (mg)', Se AS 'Se (mg)', Zn AS 'Zn (mg)', S AS 'S (mg)'," +
                "Carboidratos AS 'Carboidratos (%)', FB AS 'FB (%)', ENN AS 'ENN (%)',FDN AS 'FDN (%)'," +
                "FDA AS 'FDA (%)', CNF AS 'CNF (%)', Vit_A AS 'Vit A (UI)', Vit_D AS 'Vit D (UI)'," +
                "Vit_E AS 'Vit E (UI)', Tiamina AS 'Tiamina (mg)', Riboflavina AS 'Riboflavina (mg)'," +
                "Ac_Pantotenico AS	'Ac. Pantotenico (mg)', Vit_B6 AS 'Vit. B6 (mg)', Vit_B12 AS 'Vit. B12 (mg)'," +
                "Niacina AS 'Niacina (mg)', Ac_Folico AS 'Ac. Folico (mg)', Biotina AS 'Biotina (mg)'," +
                "Colina AS 'Colina (mg)', Vit_K AS 'Vit. K (mg)', Vit_C AS 'Vit. C (mg)'" +
                " from alimentosms";

            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = cmd;

            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            conectaMySQL.FechaMySQL();

            return dt;
        }
        public DataTable PesquisaAlimentosMS(string TextoPesquisa, string coluna)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conectaMySQL.AbreMySQL();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from alimentosms where " + coluna + " like '%" + TextoPesquisa + "%'";

            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = cmd;

            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            conectaMySQL.FechaMySQL();

            return dt;
        }
        public void SelecionaAlimentoMS()
        {
            string SQL;
            SQL = "Select * from alimentosms where id=" + id;

            MySqlDataReader dados = conectaMySQL.ExecutaConsulta(SQL);

            if (dados.Read())
            {
                Alimento = dados["Alimento"].ToString();
                Energia = dados["Energia"].ToString();
                Umidade = dados["Umidade"].ToString();
                MS = dados["MS"].ToString();
                Alimento = dados["Alimento"].ToString();
                PB = dados["PB"].ToString();
                Arg = dados["Arg"].ToString();
                His = dados["His"].ToString();
                Iso = dados["Iso"].ToString();
                Leu = dados["Leu"].ToString();
                Lis = dados["Lis"].ToString();
                Met = dados["Met"].ToString();
                Met_Cis = dados["Met_Cis"].ToString();
                Fen = dados["Fen"].ToString();
                Fen_Tir = dados["Fen_Tir"].ToString();
                Treo = dados["Treo"].ToString();
                Tri = dados["Tri"].ToString();
                Val = dados["Val"].ToString();
                Tau = dados["Tau"].ToString();
                EE = dados["EE"].ToString();
                Ac_Linolenico3 = dados["Ac_Linolenico3"].ToString();
                Ac_Araquidonico = dados["Ac_Araquidonico"].ToString();
                Ac_Linoleico6 = dados["Ac_Linoleico6"].ToString();
                EPA_DHA = dados["EPA_DHA"].ToString();
                MM = dados["MM"].ToString();
                Ca = dados["Ca"].ToString();
                P = dados["P"].ToString();
                K = dados["K"].ToString();
                Na = dados["Na"].ToString();
                Cl = dados["Cl"].ToString();
                Mg = dados["Mg"].ToString();
                Cu = dados["Cu"].ToString();
                I = dados["I"].ToString();
                Fe = dados["Fe"].ToString();
                Mn = dados["Mn"].ToString();
                Se = dados["Se"].ToString();
                Zn = dados["Zn"].ToString();
                S = dados["S"].ToString();
                Carboidratos = dados["Carboidratos"].ToString();
                FB = dados["FB"].ToString();
                ENN = dados["ENN"].ToString();
                FDN = dados["FDN"].ToString();
                FDA = dados["FDA"].ToString();
                CNF = dados["CNF"].ToString();
                Vit_A = dados["Vit_A"].ToString();
                Vit_D = dados["Vit_D"].ToString();
                Vit_E = dados["Vit_E"].ToString();
                Tiamina = dados["Tiamina"].ToString();
                Riboflavina = dados["Riboflavina"].ToString();
                Ac_Pantotenico = dados["Ac_Pantotenico"].ToString();
                Vit_B6 = dados["Vit_B6"].ToString();
                Vit_B12 = dados["Vit_B12"].ToString();
                Niacina = dados["Niacina"].ToString();
                Ac_Folico = dados["Ac_Folico"].ToString();
                Biotina = dados["Biotina"].ToString();
                Colina = dados["Colina"].ToString();
                Vit_K = dados["Vit_K"].ToString();
                Vit_C = dados["Vit_C"].ToString();
                Preco = dados["Preco"].ToString();
            }
            conectaMySQL.FechaMySQL();
        }
        public void InsereAlimentoMS()
        {
            string SQL;

            SQL = "Insert into alimentosms (Alimento, Energia, Umidade, MS, PB, Arg, His, Iso, Leu, " +
            "Lis, Met, Met_Cis, Fen, Fen_Tir, Treo, Tri, " +
            " Val, Tau, EE, Ac_Linoleico6, Ac_Araquidonico, Ac_Linolenico3, EPA_DHA, MM, Ca, P, K, Na, Cl, Mg, Cu, I, Fe, Mn" +
            ", Se, Zn, S, Carboidratos, FB, ENN, FDN, FDA, CNF, Vit_A, Vit_D, Vit_E" +
            ", Tiamina, Riboflavina, Ac_Pantotenico, Vit_B6, Vit_B12, Niacina, Ac_Folico, Biotina, Colina, Vit_K, Vit_C) " +
            "values('" + Alimento + "','" + Energia + "','" + Umidade + "','" + MS + "','" + PB + "', " +
            "'" + Arg + "','" + His + "','" + Iso + "','" + Leu + "','" + Lis + "','" + Met + "'," +
            "'" + Met_Cis + "','" + Fen + "','" + Fen_Tir + "','" + Treo + "'," +
            "'" + Tri + "','" + Val + "','" + Tau + "','" + EE + "','" + Ac_Linoleico6 + "','" + Ac_Araquidonico + "','" + Ac_Linolenico3 + "', " +
            "'" + EPA_DHA + "','" + MM + "','" + Ca + "','" + P + "','" + K + "','" + Na + "','" + Cl + "','" + Mg + "', " +
            "'" + Cu + "','" + I + "','" + Fe + "','" + Mn + "','" + Se + "','" + Zn + "','" + S + "'" +
            ",'" + Carboidratos + "','" + FB + "','" + ENN + "','" + FDN + "','" + FDA + "','" + CNF + "'" +
            ",'" + Vit_A + "','" + Vit_D + "','" + Vit_E + "','" + Tiamina + "','" + Riboflavina + "','" + Ac_Pantotenico + "'" +
            ",'" + Vit_B6 + "','" + Vit_B12 + "','" + Niacina + "','" + Ac_Folico + "','" + Biotina + "','" + Colina + "'" +
            ",'" + Vit_K + "','" + Vit_C + "');";

            conectaMySQL.ExecutaComando(SQL);
            conectaMySQL.FechaMySQL();
        }
        public void AlteraAlimentoMS()
        {
            string SQL;

            SQL = "Update alimentosms set Alimento ='" + Alimento + "', Energia ='" + Energia + "', Umidade ='" + Umidade + "', MS ='" + MS + "', PB ='" + PB + "'," +
            " Arg ='" + Arg + "', His ='" + His + "', Iso ='" + Iso + "', Leu ='" + Leu + "'," +
            " Lis ='" + Lis + "', Met ='" + Met + "', Met_Cis ='" + Met_Cis + "', Fen ='" + Fen + "', " +
            " Fen_Tir ='" + Fen_Tir + "', Treo ='" + Treo + "', Tri ='" + Tri + "', " +
            " Val ='" + Val + "', Tau ='" + Tau + "', EE='" + EE + "', Ac_Linoleico6 = '" + Ac_Linoleico6 + "', Ac_Araquidonico = '" + Ac_Araquidonico + "', " +
            " Ac_Linolenico3 = '" + Ac_Linolenico3 + "', EPA_DHA ='" + EPA_DHA + "', MM ='" + MM + "', Ca ='" + Ca + "', P ='" + P + "', K ='" + K + "', " +
            " Na ='" + Na + "', Cl ='" + Cl + "', Mg ='" + Mg + "', Cu ='" + Cu + "', I ='" + I + "', Fe ='" + Fe + "', Mn ='" + Mn + "'" +
            ", Se ='" + Se + "', Zn ='" + Zn + "', S ='" + S + "', Carboidratos ='" + Carboidratos + "', FB ='" + FB + "', ENN ='" + ENN + "'" +
            ", FDN ='" + FDN + "', FDA ='" + FDA + "', CNF ='" + CNF + "', Vit_A ='" + Vit_A + "', Vit_D ='" + Vit_D + "', Vit_E ='" + Vit_E + "'" +
            ", Tiamina ='" + Tiamina + "', Riboflavina ='" + Riboflavina + "', Ac_Pantotenico ='" + Ac_Pantotenico + "', Vit_B6 ='" + Vit_B6 + "', Vit_B12 ='" + Vit_B12 + "', Niacina ='" + Niacina + "', Ac_Folico ='" + Ac_Folico + "'" +
            ", Biotina ='" + Biotina + "', Colina ='" + Colina + "', Vit_K ='" + Vit_K + "', Vit_C ='" + Vit_C + "' where Id =" + id + ";";

            conectaMySQL.ExecutaComando(SQL);
            conectaMySQL.FechaMySQL();
        }
        public void DeletaAlimentoMS()
        {
            string SQL;

            SQL = "Delete from alimentosms where Id=" + id + ";";
            conectaMySQL.ExecutaComando(SQL);
            conectaMySQL.FechaMySQL();
        }
        #endregion

        //Controles Especies
        #region Especies
        public DataTable AtualizaEspecie()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conectaMySQL.AbreMySQL();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select id, Nome, Formula from especies";

            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = cmd;

            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            conectaMySQL.FechaMySQL();

            return dt;
        }
        public DataTable PesquisaEspecie(string TextoPesquisa)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conectaMySQL.AbreMySQL();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from especies where nome like '%" + TextoPesquisa + "%'";

            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = cmd;

            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            conectaMySQL.FechaMySQL();

            return dt;
        }
        public DataTable AtualizaComboEspecie()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conectaMySQL.AbreMySQL();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select Nome from especies";

            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = cmd;

            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            conectaMySQL.FechaMySQL();

            return dt;
        }
        public void InsereEspecie()
        {
            string SQL;

            SQL = "Insert into especies (Nome, Formula) values ('" + Nome + "','" + Formula + "');";

            conectaMySQL.ExecutaComando(SQL);
            conectaMySQL.FechaMySQL();
        }
        public void AlteraEspecie()
        {
            string SQL;

            SQL = "Update especies set Nome ='" + Nome + "', Formula ='" + Formula + "' where Id =" + id + ";";

            conectaMySQL.ExecutaComando(SQL);
            conectaMySQL.FechaMySQL();
        }
        public void DeletaEspecie()
        {
            string SQL;

            SQL = "Delete from especies where Id=" + id + ";";
            conectaMySQL.ExecutaComando(SQL);
            conectaMySQL.FechaMySQL();
        }
        public void SelecionaEspecie()
        {
            string SQL;
            SQL = "Select * from especies where id=" + id;

            MySqlDataReader dados = conectaMySQL.ExecutaConsulta(SQL);

            if (dados.Read())
            {
                Nome = dados["Nome"].ToString();
                Formula = dados["Formula"].ToString();
            }
            conectaMySQL.FechaMySQL();
        }
        #endregion

        //Controles Formulação de Fornecimento
        #region Dietas
        public void CriaDieta()
        {
            string SQL;

            SQL = "CREATE TABLE Dieta (id INT(6) UNSIGNED AUTO_INCREMENT PRIMARY KEY," +
                "Alimento VARCHAR(250) NOT NULL, Percentagem DOUBLE(3,2),Minimo DOUBLE(3,2)," +
                "Maximo DOUBLE(3,2));";

            conectaMySQL.ExecutaComando(SQL);
            conectaMySQL.FechaMySQL();
        }
        public void ExcluiDieta()
        {
            string SQL;

            SQL = "DROP TABLE Dieta;";

            conectaMySQL.ExecutaComando(SQL);
            conectaMySQL.FechaMySQL();
        }
        public DataTable AtualizaDieta()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conectaMySQL.AbreMySQL();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select id, Alimento, Percentagem AS '%'"+/*", Minimo AS 'MIN', Maximo AS 'MAX'"+*/" from Dieta";

            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = cmd;

            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            conectaMySQL.FechaMySQL();

            return dt;
        }
        public void InsereDieta()
        {
            string SQL;

            SQL = "Insert into Dieta (Alimento, Percentagem"+/*", Minimo, Maximo"+*/") values ('" + Alimento + "','" + Percentagem +
                "'"/*+",'" + Minimo + "','" + Maximo + "'*/+");";

            conectaMySQL.ExecutaComando(SQL);
            conectaMySQL.FechaMySQL();
        }
        public void AlteraDieta()
        {
            string SQL;

            SQL = "Update Dieta set Alimento ='" + Alimento + "', Percentagem ='" + Percentagem + "',Minimo =" +
                "'" + Minimo + "',Maximo ='" + Maximo + "', where id =" + id + ";";

            conectaMySQL.ExecutaComando(SQL);
            conectaMySQL.FechaMySQL();
        }
        public void DeletaDieta()
        {
            string SQL;

            SQL = "Delete from Dieta where id=" + id + ";";
            conectaMySQL.ExecutaComando(SQL);
            conectaMySQL.FechaMySQL();
        }
        public void SelecionaDieta()
        {
            string SQL;
            SQL = "Select * from Dieta where id=" + id;

            MySqlDataReader dados = conectaMySQL.ExecutaConsulta(SQL);

            if (dados.Read())
            {
                Alimento = dados["Alimento"].ToString();
                Percentagem = Convert.ToDouble(dados["Percentagem"].ToString());
                Minimo = Convert.ToDouble(dados["Minimo"].ToString());
                Maximo = Convert.ToDouble(dados["Maximo"].ToString());
            }
            conectaMySQL.FechaMySQL();
        }
        #endregion

        //Testes

    }
}


/*
 * "Select id, Alimento, Energia AS 'Energia (kcal)', Umidade AS	'Umidade (%)'," +
                "MS AS 'MS (%)', PB AS 'PB (%)', Arg AS 'Arg (%)', His AS 'His (%)', Iso AS 'Iso (%)'," +
                "Leu AS 'Leu (%)', Lis AS 'Lis (%)', Met AS 'Met (%)', Met_Cis AS 'Met + Cis  (%)'," +
                "Fen AS 'Fen  (%)', Fen_Tir AS 'Fen + Tir (%)', Treo AS 'Treo (%)', Tri AS 'Tri (%)'," +
                "Val AS 'Val (%)', Tau AS 'Tau (%)', EE AS 'EE (%)', Ac_Linoleico6 AS 'Ac. Linoleico n-6 (%)'," +
                "Ac_Araquidonico AS 'Ac. Araquidonico (mg)', Ac_Linolenico3 AS 'Ac. Linolenico n-3 (%)'," +
                "EPA_DHA AS 'EPA + DHA (%)', MM AS 'MM (%)', Ca AS 'Ca (mg)', P AS 'P (mg)',K AS 'K (mg)'," +
                "Na AS 'Na (mg)', Cl AS 'Cl (mg)', Mg AS 'Mg (mg)', Cu AS 'Cu (mg)', I AS 'I (mg)'," +
                "Fe AS 'Fe (mg)', Mn AS 'Mn (mg)', Se AS 'Se (mg)', Zn AS 'Zn (mg)', S AS 'S (mg)'," +
                "Carboidratos AS 'Carboidratos (%)', FB AS 'FB (%)', ENN AS 'ENN (%)',FDN AS 'FDN (%)'," +
                "FDA AS 'FDA (%)', CNF AS 'CNF (%)', Vit_A AS 'Vit A (UI)', Vit_D AS 'Vit D (UI)'," +
                "Vit_E AS 'Vit E (UI)', Tiamina AS 'Tiamina (mg)', Riboflavina AS 'Riboflavina (mg)'," +
                "Ac_Pantotenico AS	'Ac. Pantotenico (mg)', Vit_B6 AS 'Vit. B6 (mg)', Vit_B12 AS 'Vit. B12 (mg)'," +
                "Niacina AS 'Niacina (mg)', Ac_Folico AS 'Ac. Folico (mg)', Biotina AS 'Biotina (mg)'," +
                "Colina AS 'Colina (mg)', Vit_K AS 'Vit. K (mg)', Vit_C AS 'Vit. C (mg)'," +
                "Correcao_ENN AS 'Correcao ENN', Preco AS 'Preco/kg (R$)', Un_P AS 'Unidade pequena (g)'," +
                "Un_M AS 'Unidade media (g)', Un_G AS 'Unidade grande (g)', Folha_P AS 'Folha pequena (g)'," +
                "Folha_M AS 'Folha media (g)', Folha_G AS 'Folha grande (g)', Colher_Sopa_P AS 'Colher de sopa rasa (g)'," +
                "Colher_Sopa_M AS 'Colher de sopa media (g)', Colher_Sopa_G AS	'Colher de sopa cheia (g)'," +
                "Colher_Arroz AS 'Colher de arroz cheia (g)', Escumadeira_P AS 'Escumadeira media rasa (g)'," +
                "Escumadeira_M AS 'Escumadeira media (g)', Escumadeira_G AS	'Escumadeira media cheia (g)'," +
                "Fatia_P AS 'Fatia pequena (g)', Fatia_M AS 'Fatia media (g)', Fatia_G AS 'Fatia grande (g)'," +
                "Pedaco_P AS 'Pedaco pequeno (g)', Pedaco_M AS 'Pedaco medio (g)', Pedaco_G AS 'Pedaco grande (g)'," +
                "Pires AS 'Prato pires raso  (g)', Colher AS 'Colher de servir (g)', Xicara AS 'Xicara de cha (g)'," +
                "Copo_Requeijao AS 'Copo de requeijao (g)', Prato_G AS 'Prato fundo (g)',Prato_P AS 'Prato raso (g)'," +
                "Colher_Sobremesa AS 'Colher de sobremesa (g)', Bago AS 'Bago (g)', Cacho_P AS 'Cacho pequeno (g)'," +
                "Cacho_M AS 'Cacho medio (g)', Cacho_G AS 'Cacho grande (g)', Colher_Cafe AS 'Colher de cafe (g)'," +
                "Colher_Cha AS 'Colher de cha (g)', File AS 'File (g)', Bife AS 'Bife (g)', Lata AS 'Lata (g)'," +
                "Copo AS 'Copo (g)', Ramo AS 'Ramo (g)', Maco AS 'Maco (g)', Pitada AS 'Pitada (g)' from alimentosmn";

    */