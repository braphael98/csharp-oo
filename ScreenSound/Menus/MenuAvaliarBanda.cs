using ScreenSound.Modelos;
namespace ScreenSound.Menus;
internal class MenuAvaliarBanda: Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        Console.Clear();
        ExibirTituloDaOpcao("Avaliar banda");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];//puxar a chave da banda no dicionario.
            Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");

            Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);//criando objeto nota para o contexto atual
            banda.AdicionarNota(nota);//adicionando nota no metodo da banda

            Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para a banda {nomeDaBanda}");
            Thread.Sleep(2000);
            Console.Clear();

        }
    }
}