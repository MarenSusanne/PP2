namespace PP2;

public class Movies

    {
    public string Title;
    public int Year;
    public string Description;
    public string Director;
    public string Actors;

    public Movies(string title, int year, string description, string director, string actors)
    {
        Title = title;
        Year = year;
        Description = description;
        Director = director;
        Actors = actors;
    }

    public void MovieInfo()
    {
        Console.WriteLine($"Tittel: {Title}");
        Console.WriteLine("År: " + Year);
        Console.WriteLine($"Beskrivelse: {Description}");
        Console.WriteLine($"Regissør: {Director}");
        Console.WriteLine($"Skuespillere: {Actors}");
    }

}

