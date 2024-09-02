namespace KH_CS_September;
class Program
{
    static void Main(string[] args)
    {
        // string datatype variabel
        string helloWorld = "Hello, World!";
        // heltall variabel
        int myNumber = 10;
        // desimaltall/double variabel
        double myDecimal = 10.25;
        // bruker Console klassen til å skrive ut til terminalen
        Console.WriteLine(helloWorld);
        Console.WriteLine(myNumber);
        Console.WriteLine(myDecimal);
        
        // Skriver ut en melding til brukeren 
        Console.WriteLine("Hei, hva heter du? ");
        // string variabel navn holder på verdien vi gir til konsollen
        string? navn = Console.ReadLine();
        // skriver ut en liten melding + navnet som er gitt til konsollen
        Console.WriteLine("Hei " + navn);
        // char typen, tar en bestemt bokstav
        char a = '@';
        Console.WriteLine(a);
    }
}
