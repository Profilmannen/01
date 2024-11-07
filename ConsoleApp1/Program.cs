if( 6 >= 3)
{
    Console.WriteLine("Hej Världen!");
}

Console.WriteLine("Vad heter du?");

string namn = Console.ReadLine();

Console.WriteLine("Vad är lösenordet?");

string password = Console.ReadLine();

while( password != "12345")
{
    Console.WriteLine("Dra åt helvete! Fel namn eller lösenord");
    password = Console.ReadLine(); 
}

if( namn == "kalleanka" && password == "12345")
{
    Console.WriteLine("Välkommen!");
}

// for(int i=1; i<=32; i++)
// {
//     Console.WriteLine("Hej igen världen!");
// }

Console.ReadLine();