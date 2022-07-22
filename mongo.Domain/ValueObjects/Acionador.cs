using mongo.Domain.Enums;

namespace mongo.Domain.ValueObjects
{
    public class Acionador
    {
        public IEnumerable<EnumProduto> Produtos { get; private set; }
        public IEnumerable<int> Anos { get; private set; }
        public IEnumerable<EnumStatusPagamentoOV> StatusOvPossiveis { get; private set; }
        public bool? Quitado { get; private set; }
        public bool? ChamadoEmAberto { get; private set; }

        public bool? CicloMeioDeAnoCompleto { get; private set; }
        public int? AnoMaiorQue { get; private set; }
        public int? AnoMenorQue { get; private set; }
        public string? AcionadorPersonalizado { get; private set; }
        public ParametroAcionador? ParametrosAcionador { get; private set; }
    }
}
