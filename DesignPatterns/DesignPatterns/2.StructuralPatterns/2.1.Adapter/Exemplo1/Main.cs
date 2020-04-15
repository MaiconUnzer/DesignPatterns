namespace DesignPatterns._2.StructuralPatterns._2._1.Adapter
{
    public class Main
    {
        public void Executar()
        {
            var pagamentoLogPadrao = new TransacaoService(new Logger());
            pagamentoLogPadrao.RealizarTransacao();

            var pagamentoLogCustomizado = new TransacaoService(new LogAdapter(new LogNetMasterService()));
            pagamentoLogCustomizado.RealizarTransacao();
        }
    }
}