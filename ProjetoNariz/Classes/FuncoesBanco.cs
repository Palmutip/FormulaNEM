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
        ConectaBanco conectabanco = new ConectaBanco();
        ConectaMySQL conectaMySQL = new ConectaMySQL();
        public int Id { get; set; }
        public string id { get; set; }
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
        public string Ac_Linoleico3 { get; set; }
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
        //Vit_D

        //Painel Alimentos Materia Natural
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
                "Ac_Araquidonico AS 'Ac. Araquidonico (mg)', Ac_Linoleico3 AS 'Ac. Linolenico n-3 (%)'," +
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
                Ac_Linoleico3 = dados["Ac_Linoleico3"].ToString();
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
                Correcao_ENN = dados["Correcao_ENN"].ToString();
                Preco = dados["Preco"].ToString();
                Un_P = dados["Un_P"].ToString();
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
                Pitada = dados["Pitada"].ToString();
            }
            conectaMySQL.FechaMySQL();
        }

        //Testes

    }
}


/*
 * "Select id, Alimento, Energia AS 'Energia (kcal)', Umidade AS	'Umidade (%)'," +
                "MS AS 'MS (%)', PB AS 'PB (%)', Arg AS 'Arg (%)', His AS 'His (%)', Iso AS 'Iso (%)'," +
                "Leu AS 'Leu (%)', Lis AS 'Lis (%)', Met AS 'Met (%)', Met_Cis AS 'Met + Cis  (%)'," +
                "Fen AS 'Fen  (%)', Fen_Tir AS 'Fen + Tir (%)', Treo AS 'Treo (%)', Tri AS 'Tri (%)'," +
                "Val AS 'Val (%)', Tau AS 'Tau (%)', EE AS 'EE (%)', Ac_Linoleico6 AS 'Ac. Linoleico n-6 (%)'," +
                "Ac_Araquidonico AS 'Ac. Araquidonico (mg)', Ac_Linoleico3 AS 'Ac. Linolenico n-3 (%)'," +
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