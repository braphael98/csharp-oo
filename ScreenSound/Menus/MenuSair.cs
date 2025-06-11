using System;
using ScreenSound.Modelos;
namespace ScreenSound.Menus
{
    internal class MenuSair : Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            Console.WriteLine("Tchau tchau :)");
            Environment.Exit(0); // Encerra o programa com código de saída 0 (sem erros)
        }
    }
}
