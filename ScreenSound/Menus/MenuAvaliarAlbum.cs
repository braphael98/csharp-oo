using ScreenSound.Modelos;
namespace ScreenSound.Menus;

internal class MenuAvaliarAlbum : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        Console.Clear();
        ExibirTituloDaOpcao("Avaliar Album");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.Write("Agora digite o título do álbum: ");
            string tituloAlbum = Console.ReadLine()!;
            if (banda.Albuns.Any(a => a.Nome.Equals(tituloAlbum)))
            {
                Album album = banda.Albuns.First(a => a.Nome.Equals(tituloAlbum));
                Console.Write($"Qual a nota que o Album {tituloAlbum} merece: ");
                Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);//criando objeto nota para o contexto atual
                album.AdicionarNota(nota);//adicionando nota no metodo da banda

                Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para o album {tituloAlbum}");
                Thread.Sleep(2000);
                Console.Clear();

            }
            else
            {
            Console.WriteLine($"\nAlbum {tituloAlbum} não foi encontrado!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
            }

        }
    }
}