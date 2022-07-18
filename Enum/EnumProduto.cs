using System.ComponentModel;

namespace MongoDBAPIC.Enum
{
   public enum EnumProduto
    {   
        [Description("NAO DEFINIDO")]
        NAO_DEFINIDO = -1,
        MED = 5,
        MEDCURSO = 1,
        [Description("MED EAD")]
        MED_EAD = 8,
        [Description("MEDCURSO EAD")]
        MEDCURSO_EAD = 9,
        INTENSIVAO = 14,
        [Description("CPMED PREMIUM")]
        CPMED_PREMIUM = 51,
        [Description("APOSTILA CPMED")]
        APOSTILA_CPMED = 53,
        MEDELETRO = 57,
        RAC = 58,
        RACIPE = 61,
        REVALIDA = 63,
        ADAPTAMED = 72,
        [Description("COMBO INTENSIVAO EAD")]
        COMBOINTENSIVAO = 64,
        [Description("INTENSIVAO CIRURGIA")]
        INTENSIVAO_CIRURGIA = 64,
        [Description("INTENSIVAO PREVENTIVA")]
        INTENSIVAO_PREVENTIVA = 69,
        [Description("INTENSIVAO GINECOLOGIA")]
        INTENSIVAO_GINECOLOGIA = 68,
        [Description("INTENSIVAO PEDIATRIA")]
        INTENSIVAO_PEDIATRIA = 67,
        [Description("INTENSIVAO CLINICA1")]
        INTENSIVAO_CLINICA1 = 65,
        [Description("INTENSIVAO CLINICA2")]
        INTENSIVAO_CLINICA2 = 66,
        [Description("R3 CLINICA")]       
        R3CLINICA = 76,
        [Description("R3 CIRURGIA")]
        R3CIRURGIA = 81,
        [Description("R3 PEDIATRIA")]
        R3PEDIATRIA = 82,
        [Description("R4 GO")]
        R4GO = 83,
        [Description("MEDELETRO IMED")]
        MEDELETRO_IMED = 88,
        [Description("RAC IMED")]
        RAC_IMED = 91,
        [Description("RACIPE IMED")]
        RACIPE_IMED = 92,
        TEGO = 93,
        MASTO = 94,
        [Description("MEDMASTER")]
        MED_MASTER = 98,
        [Description("CPMED EXTENSIVO")]
        CPMED_EXTENSIVO = 97,
        [Description("CPMED REVALIDA")]
        CPMED_REVALIDA = 99,
        [Description("NO PAPO")]
        NO_PAPO = 103,
        MEDIMAGEM = 102,
        VENTILAMED = 104,
        MEDIMAGEMR = 105,
        [Description("R+ ENDOSCOPIA")]
        RMAIS_ENDOSCOPIA = 108,
        [Description("INTENSIVÃO R")]
        INTENSIVAO_R = 109
    }
}
