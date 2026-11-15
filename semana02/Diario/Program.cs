using System;


class Program
{
    static void Main(string[] args)
    {
        Diario meuDiario = new Diario();
        GeradorDePerguntas gerador = new GeradorDePerguntas();
        string escolha = "";

        while (escolha != "5")
        {
            Console.WriteLine("Por favor, escolha uma das opções a seguir:");
            Console.WriteLine("1. Escrever");
            Console.WriteLine("2. Exibir");
            Console.WriteLine("3. Carregar");
            Console.WriteLine("4. Salvar");
            Console.WriteLine("5. Sair");
            Console.WriteLine("O que você gostaria de fazer? ");
            escolha = Console.ReadLine();

            if(escolha =="1")
            {
                string pergunta = gerador.ObterPerguntaAleatoria();
                Console.WriteLine(pergunta);
                Console.WriteLine("> ");
                string resposta = Console.ReadLine();

                Registro novo = new Registro();
                novo._data = DateTime.Now.ToShortDateString();
                novo._textoPergunta = pergunta;
                novo._textoResposta = resposta;

                meuDiario.AdicionarRegistro(novo);

            }
            else if (escolha =="2")
            {
                meuDiario.ExibirTodos();
            }
            else if (escolha == "3")
            {
                Console.Write("Qual é o nome do arquivo? ");
                string nomeArquivo = Console.ReadLine();
                meuDiario.CarregarDoArquivo(nomeArquivo);
            }
            else if (escolha == "4")
            {
                Console.Write("Qual é o nome do arquivo? ");
                string nomeArquivo = Console.ReadLine();
                meuDiario.SalvarNoArquivo(nomeArquivo);
            }
       
        }
    }
}