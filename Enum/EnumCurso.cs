using System.ComponentModel;

namespace MongoDBAPIC.Enum
{
    public enum EnumCurso
    {
        [Description("Não Definido")]
        NAO_DEFINIDO = -1,

        [Description("MEDCURSO")]
        MEDCURSO = 16,
        [Description("MED")]
        MED = 17,
        [Description("CPMED")]
        CPMED_PREMIUM = 53,
        [Description("CP-MED EXTENSIVO")]
        CPMED_EXTENSIVO = 100,
        [Description("CPMED REVALIDA")]
        CPMED_REVALIDA = 101,

        [Description("CPMED PREMIUM")]
        CPMED = 53,
        [Description("INTENSIVÃO")]
        INTENSIVAO = 14,

        [Description("MEDELETRO")]
        MEDELETRO = 56,
        [Description("RAC")]
        RAC = 58,
        [Description("RACIPE")]
        RACIPE = 61,
        [Description("REVALIDA")]
        REVALIDA = 63,
        [Description("CPMED R")]
        CPMEDR = 74,

        [Description("R+ CLINICA")]
        R3Clinica = 77,
        [Description("R+ CIRURGIA")]
        R3Cirurgia = 78,
        [Description("R+ PEDIATRIA")]
        R3Pediatria = 79,
        [Description("R+ GO")]
        R4GO = 80,
        [Description("MEDELETRO IMED")]
        MEDELETRO_IMED = 88,

        [Description("RAC")]
        RAC_IMED = 91,
        [Description("RACIPE")]
        RACIPE_IMED = 92,
        [Description("R+ TEGO")]
        TEGO = 95,
        [Description("R+ MASTOLOGIA")]
        MASTO = 96,

        [Description("MEDIMAGEM")]
        MEDIMAGEM = 102,
        [Description("NO PAPO")]
        NOPAPO = 103,
        [Description("VENTILAMED")]
        VENTILAMED = 104,
        [Description("MEDIMAGEM R")]
        MEDIMAGEMR = 105,
        [Description("MEDMASTER (MEDCURSO/MED)")]
        MEDMASTER = 98,
        [Description("R+ ENDOSCOPIA")]
        R3ENDOSCOPIA = 108,
        [DescriptionAttribute("INTENSIVÃO R")]
        INTENSIVAO_R = 109
    }
}
