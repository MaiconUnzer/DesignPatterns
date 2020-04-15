namespace DesignPatterns._2.StructuralPatterns._2._1.Adapter.Exemplo2
{
    public class Main
    {
        public static void Executar()
        {
            MediaPlayer audioPlayerMp3 = new MediaPlayer(new Mp3Player());
            audioPlayerMp3.PlayMedia("meuarquivo");

            MediaPlayer audioPlayerMp4 = new MediaPlayer(new MediaAdapter(new Mp4Player()));
            audioPlayerMp4.PlayMedia("meuarquivo");

            MediaPlayer audioPlayerVlc = new MediaPlayer(new MediaAdapter(new VlcPlayer()));
            audioPlayerVlc.PlayMedia("meuarquivo");
        }
    }
}
