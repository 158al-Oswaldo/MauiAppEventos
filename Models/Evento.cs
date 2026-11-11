namespace MauiAppEventos.Models
{
    public class Evento
    {
        public string Nome { get; set; } = string.Empty;
        public DateTime DataInicio { get; set; } = DateTime.Today;
        public DateTime DataTermino { get; set; } = DateTime.Today;
        public int NumeroParticipantes { get; set; }
        public string Local { get; set; } = string.Empty;
        public double CustoPorParticipante { get; set; }

        // Diferença entre as datas (DateTime - DateTime = TimeSpan)
        public TimeSpan Diferenca => DataTermino.Date - DataInicio.Date;

        // Duração em dias contando o dia inicial e o final
        // (evento que começa e termina no mesmo dia dura 1 dia).
        public int DuracaoDias => Diferenca.Days + 1;

        // Custo total com base no número de participantes
        public double CustoTotal => NumeroParticipantes * CustoPorParticipante;
    }
}
