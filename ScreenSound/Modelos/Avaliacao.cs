namespace ScreenSound.Modelos;

internal class Avaliacao
{
    public Avaliacao(int nota)
    {
        Nota = nota;
    }

    public int Nota { get;}

    public static Avaliacao Parse(string texto)//metodo estatico, pq é direto
    {
        int nota = int.Parse(texto);
        return new Avaliacao(nota);
    }
}
