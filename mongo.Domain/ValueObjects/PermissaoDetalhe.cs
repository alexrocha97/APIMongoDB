using mongo.Domain.Enums;

namespace mongo.Domain.ValueObjects
{
    public class PermissaoDetalhe
    {
        public EnumStatusPermissao Status { get; private set; }
        public DateTime? Data { get; private set; }
        public int? MinimoDias { get; private set; }
        public int? MinimoMeses { get; private set; }
        public bool? OptanteRevalida { get; private set; }
        public bool? ConteudoSujeitoPagamento { get; private set; }

        public PermissaoDetalhe(EnumStatusPermissao status)
        {
            Status = status;
        }
    }
}
