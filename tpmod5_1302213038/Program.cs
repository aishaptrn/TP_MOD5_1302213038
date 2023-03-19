// See https://aka.ms/new-console-template for more information

class HaloGeneric
{
    public void SapaUser<T>(T user)
    {
        Console.WriteLine("Halo user " + user + "!");
    }
}

class MainProgram
{
    static void Main(string[] args)
    {
        HaloGeneric sapa = new HaloGeneric();

        string nickname = "Ais";
        sapa.SapaUser(nickname);
    }
}