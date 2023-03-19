// See https://aka.ms/new-console-template for more information

public class DataGeneric<T>
{
    private T data;
    
    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void printData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + data);
    }
}

class MainProgram
{
    static void Main(string[] args)
    {
        DataGeneric<string> data = new DataGeneric<string>("1302213038");
        data.printData();
    }
}