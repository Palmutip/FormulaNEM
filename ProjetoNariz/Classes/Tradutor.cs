using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNariz.Classes
{
    class Tradutor
    {
        public string TraduzCombobox(string combobox)
        {
            if(combobox == "Energia (kcal)")
            {
                combobox = "Energia";
            }
            else if (combobox == "Umidade (%)")
            {
                combobox = "Umidade";
            }
            else if (combobox == "MS (%)")
            {
                combobox = "MS";
            }
            else if (combobox == "Arg (%)")
            {
                combobox = "Arg";
            }
            else if (combobox == "His (%)")
            {
                combobox = "His";
            }
            else if (combobox == "Lis (%)")
            {
                combobox = "Lis";
            }
            else if (combobox == "Iso (%)")
            {
                combobox = "Iso";
            }
            else if (combobox == "Leu (%)")
            {
                combobox = "Leu";
            }
            else if (combobox == "Met (%)")
            {
                combobox = "Met";
            }
            else if (combobox == "Met + Cis (%)")
            {
                combobox = "Met_Cis";
            }
            else if (combobox == "Fen (%)")
            {
                combobox = "Fen";
            }
            else if (combobox == "Fen + Tir (%)")
            {
                combobox = "Fen_Tir";
            }
            else if (combobox == "Treo (%)")
            {
                combobox = "Treo";
            }
            else if (combobox == "Tri (%)")
            {
                combobox = "Tri";
            }
            else if (combobox == "Val (%)")
            {
                combobox = "Val";
            }
            else if (combobox == "Tau (%)")
            {
                combobox = "Tau";
            }
            else if (combobox == "EE (%)")
            {
                combobox = "EE";
            }
            else if (combobox == "Ac. Araquidonico (mg)")
            {
                combobox = "Ac_Araquidonico";
            }
            else if (combobox == "Ac. Linoleico n-6 (%)")
            {
                combobox = "Ac_Linoleico6";
            }
            else if (combobox == "Ac. Linoleico n-3 (%)")
            {
                combobox = "Ac_Linoleico3";
            }
            else if (combobox == "EPA + DHA (%)")
            {
                combobox = "EPA_DHA";
            }
            else if (combobox == "MM (%)")
            {
                combobox = "MM";
            }
            else if (combobox == "Ca (mg)")
            {
                combobox = "Ca";
            }
            else if (combobox == "P (mg)")
            {
                combobox = "P";
            }
            else if (combobox == "K (mg)")
            {
                combobox = "K";
            }
            else if (combobox == "Na (mg)")
            {
                combobox = "Na";
            }
            else if (combobox == "Cl (mg)")
            {
                combobox = "Cl";
            }
            else if (combobox == "Mg (mg)")
            {
                combobox = "Mg";
            }
            else if (combobox == "Cu (mg)")
            {
                combobox = "Cu";
            }
            else if (combobox == "Mg (mg)")
            {
                combobox = "Mg";
            }
            else if (combobox == "I (mg)")
            {
                combobox = "I";
            }
            else if (combobox == "Fe (mg)")
            {
                combobox = "Fe";
            }
            else if (combobox == "Mn (mg)")
            {
                combobox = "Mn";
            }
            else if (combobox == "Se (mg)")
            {
                combobox = "Se";
            }
            else if (combobox == "Zn (mg)")
            {
                combobox = "Zn";
            }
            else if (combobox == "S (mg)")
            {
                combobox = "S";
            }
            else if (combobox == "Carboidratos (%)")
            {
                combobox = "Carboidratos";
            }
            else if (combobox == "FB (%)")
            {
                combobox = "FB";
            }
            else if (combobox == "ENN (%)")
            {
                combobox = "ENN";
            }
            else if (combobox == "FDN (%)")
            {
                combobox = "FDN";
            }
            else if (combobox == "FDA (%)")
            {
                combobox = "FDA";
            }
            else if (combobox == "CNF (%)")
            {
                combobox = "CNF";
            }
            else if (combobox == "Vit A (UI)")
            {
                combobox = "Vit_A";
            }
            else if (combobox == "Vit D (UI)")
            {
                combobox = "Vit_D";
            }
            else if (combobox == "Vit E (UI)")
            {
                combobox = "Vit_E";
            }
            else if (combobox == "Tiamina (mg)")
            {
                combobox = "Tiamina";
            }
            else if (combobox == "Riboflavina (mg)")
            {
                combobox = "Riboflavina";
            }
            else if (combobox == "Ac. Pantotenico (mg)")
            {
                combobox = "Ac_Pantotenico";
            }
            else if (combobox == "Vit. B6 (mg)")
            {
                combobox = "Vit_B6";
            }
            else if (combobox == "Vit. B12 (mg)")
            {
                combobox = "Vit_B12";
            }
            else if (combobox == "Niacina (mg)")
            {
                combobox = "Niacina";
            }
            else if (combobox == "Ac. Folico (mg)")
            {
                combobox = "Ac_Folico";
            }
            else if (combobox == "Biotina (mg)")
            {
                combobox = "Biotina";
            }
            else if (combobox == "Colina (mg)")
            {
                combobox = "Colina";
            }
            else if (combobox == "Vit. K (mg)")
            {
                combobox = "Vit_K";
            }
            else if (combobox == "Vit. C (mg)")
            {
                combobox = "Vit_C";
            }
            else if (combobox == "Preco//kg (R$)")
            {
                combobox = "Preco";
            }
            else if (combobox == "Unidade pequena (g)")
            {
                combobox = "Un_P";
            }
            else if (combobox == "Unidade media (g)")
            {
                combobox = "Un_M";
            }
            else if (combobox == "Unidade grande (g)")
            {
                combobox = "Un_G";
            }
            else if (combobox == "Tiamina (mg)")
            {
                combobox = "Tiamina";
            }
            else if (combobox == "Folha pequena (g)")
            {
                combobox = "Folha_P";
            }
            else if (combobox == "Folha media (g)")
            {
                combobox = "Folha_M";
            }
            else if (combobox == "Folha grande (g)")
            {
                combobox = "Folha_G";
            }
            else if (combobox == "Colher de sopa rasa (g)")
            {
                combobox = "Colher_Sopa_P";
            }
            else if (combobox == "Colher de sopa media (g)")
            {
                combobox = "Colher_Sopa_M";
            }
            else if (combobox == "Colher de sopa grande (g)")
            {
                combobox = "Colher_Sopa_G";
            }
            else if (combobox == "Colher de arroz cheia (g)")
            {
                combobox = "Colher_Arroz";
            }
            else if (combobox == "Escumadeira media cheia (g)")
            {
                combobox = "Escumadeira_G";
            }
            else if (combobox == "Escumadeira media (g)")
            {
                combobox = "Escumadeira_M";
            }
            else if (combobox == "Escumadeira media rasa (g)")
            {
                combobox = "Escumadeira_P";
            }
            else if (combobox == "Fatia pequena (g)")
            {
                combobox = "Fatia_P";
            }
            else if (combobox == "Fatia media (g)")
            {
                combobox = "Fatia_M";
            }
            else if (combobox == "Fatia grande (g)")
            {
                combobox = "Fatia_G";
            }
            else if (combobox == "Pedaco pequeno (g)")
            {
                combobox = "Pedaco_P";
            }
            else if (combobox == "Pedaco medio (g)")
            {
                combobox = "Pedaco_M";
            }
            else if (combobox == "Pedaco grande (g)")
            {
                combobox = "Pedaco_G";
            }
            else if (combobox == "Prato pires raso (g)")
            {
                combobox = "Pires";
            }
            else if (combobox == "Colher de servir (g)")
            {
                combobox = "Colher";
            }
            else if (combobox == "Xicara de cha (g)")
            {
                combobox = "Xicara";
            }
            else if (combobox == "Copo de requeijao (g)")
            {
                combobox = "Copo_Requeijao";
            }
            else if (combobox == "Prato fundo (g)")
            {
                combobox = "Prato_G";
            }
            else if (combobox == "Prato raso (g)")
            {
                combobox = "Prato_P";
            }
            else if (combobox == "Colher de sobremesa (g)")
            {
                combobox = "Colher_Sobremesa";
            }
            else if (combobox == "Bago (g)")
            {
                combobox = "Bago";
            }
            else if (combobox == "File (g)")
            {
                combobox = "File";
            }
            else if (combobox == "Bife (g)")
            {
                combobox = "Bife";
            }
            else if (combobox == "Lata (g)")
            {
                combobox = "Lata";
            }
            else if (combobox == "Copo (g)")
            {
                combobox = "Copo";
            }
            else if (combobox == "Ramo (g)")
            {
                combobox = "Ramo";
            }
            else if (combobox == "Maco (g)")
            {
                combobox = "Maco";
            }
            else if (combobox == "Pitada (g)")
            {
                combobox = "Pitada";
            }
            else if (combobox == "Cacho grande (g)")
            {
                combobox = "Cacho_G";
            }
            else if (combobox == "Cacho medio (g)")
            {
                combobox = "Cacho_M";
            }
            else if (combobox == "Cacho pequeno(g)")
            {
                combobox = "Cacho_P";
            }
            else if (combobox == "Colher de cafe (g)")
            {
                combobox = "Colher_Cafe";
            }
            else if (combobox == "Colher de cha (g)")
            {
                combobox = "Colher_Cha";
            }
            else if (combobox == "Filtro")
            {
                return combobox;
            }
            return combobox;
        }
    }
}
