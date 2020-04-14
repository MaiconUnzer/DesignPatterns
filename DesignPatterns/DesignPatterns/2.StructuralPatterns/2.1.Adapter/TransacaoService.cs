namespace DesignPatterns._2.StructuralPatterns._2._1.Adapter
{
    //Client
    public class TransacaoService
    {
        private readonly ILogger _logger;

        public TransacaoService(ILogger logger)
        {
            _logger = logger;
        }

        public void RealizarTransacao()
        {
            _logger.Log("Transação Realizada");
        }
    }
}
