using System.ComponentModel;

namespace MongoDBAPIC.Enum
{
   public enum EnumAplicacao
    {
        [Description("MEDSoft Pro")]
        MEDSOFT_PRO = 1,
        [Description("Plantão de Recursos")]
        PLANTAO_RECURSOS = 2,
        [Description("Plantão de Concursos")]
        PLANTAO_CONCURSOS = 3,
        [Description("MEDEletro APP")]
        MEDELETRO_APP = 4   
    }
}
