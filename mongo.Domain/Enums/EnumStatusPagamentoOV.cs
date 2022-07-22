using System.ComponentModel;

namespace mongo.Domain.Enums
{
    public enum EnumStatusPagamentoOV
    {
        Pendente = 0,
        Suspensa = 1,
        Cancelada = 5,
        Adimplente = 6,
        Inadimplente = 7,
        Carencia = 8,
        [Description("Inadimplente Meses Anteriores")]
        InadimplenteMesesAnteriores = 9
    }
}
