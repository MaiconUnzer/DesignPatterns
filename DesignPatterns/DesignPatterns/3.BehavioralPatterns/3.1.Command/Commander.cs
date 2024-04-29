namespace DesignPatterns._3.BehavioralPatterns._3._1.Command
{
    /// <summary>
    /// 'Command' abstract class
    /// </summary>
    public abstract class Commander
    {
        public abstract void Executar();
        public abstract void Desfazer();
    }
}