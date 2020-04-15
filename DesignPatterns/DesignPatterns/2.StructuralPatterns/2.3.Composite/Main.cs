namespace DesignPatterns._2.StructuralPatterns._2._3.Composite
{
    public class Main
    {
        public static void Executar()
        {
            var validacaoCadastro = new Mensagem("O cadastro não foi realizado!");

            var usuarioFormErro = new Mensagem("O usuário informou um nome inválido!");

            var tamanhoNomeForm = new InputFormMessage("O nome precisa possuir mais de 2 caracteres!");
            var nomeVazioForm = new InputFormMessage("O nome não pode possuir numeros!");

            usuarioFormErro.AdicionarMensagem(tamanhoNomeForm);
            usuarioFormErro.AdicionarMensagem(nomeVazioForm);

            validacaoCadastro.AdicionarMensagem(usuarioFormErro);

            var domainUsuarioErro = new Mensagem("Problems ao processar o cadastro de usuario!");

            var cpfUsuarioDomain = new DomainMessage("O CPF informado está em uso!");
            var emailUsuarioDomain = new DomainMessage("O Email informado está em uso!");

            domainUsuarioErro.AdicionarMensagem(cpfUsuarioDomain);
            domainUsuarioErro.AdicionarMensagem(emailUsuarioDomain);

            validacaoCadastro.AdicionarMensagem(domainUsuarioErro);

            validacaoCadastro.ExibirMensagens(2);
        }
    }
}
