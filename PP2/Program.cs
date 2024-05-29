//    Lag en applikasjon der man kan skrive inn forskjellige detaljer, og etter man har skrevet inn alt få 
//    printet tilbake det som ble skrevet inn som et “produkt”, enten en film eller en bok, dere velger.
//    Man skal bli spurt av konsollen om Tittel, så år det kom ut, litt beskrivelse av hva filmen eller boken handler om, 
//    forfatter/regissør, hvilke skuespillere som var med.
//    Når alle spørsmål er besvart skal man kunne få se boken eller filmen man skrev inn som et produkt, med alle egenskaper listet opp.


using PP2;
CoolMovies();
static void CoolMovies()
{
    Console.WriteLine("Få informasjon om en film, ved å skrive inn det vi spør om!");

    Console.WriteLine("Tittel:");

    var input1 = Console.ReadLine();

    Console.WriteLine("År:");
    var input2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Beskrivelse:");
    var input3 = Console.ReadLine();

    Console.WriteLine("Regissør:");
    var input4 = Console.ReadLine();

    Console.WriteLine("Skuespillere:");
    var input5 = Console.ReadLine();


    var myMovie = new Movies(input1, input2, input3, input4, input5);


    myMovie.MovieInfo();

    Console.WriteLine("Vil du legge til en ekstra film, si ja");
    var inputAnswer = Console.ReadLine();

    if (inputAnswer == "ja")
    {
        CoolMovies();
    }
    else
    {
        Console.Clear();
    }
}
