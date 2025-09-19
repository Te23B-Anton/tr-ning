// Title();

// Intro();


// Console.ReadLine();

// static void Title()
// {
//     Console.WriteLine("");
//     Console.WriteLine("       _.-;;-._");
//     Console.WriteLine("'-..-'|   ||   |");
//     Console.WriteLine("'-..-'|   ||   |");
//     Console.WriteLine("'-..-'|   ||   |");
//     Console.WriteLine("'-..-'|_.-''-._|");
// }

// static void Intro(){
//     Console.WriteLine("Det var en gång för länge sedan ...");

// }

Typewriter("hello all sigmas");

// string text = "hello";
 
static void Typewriter(string text)
{
    for (int i = 0; i < text.Length; i++)
    {
        Console.WriteLine(text [i]);
        Thread.Sleep(100);

    }
}

Console.ReadLine();
