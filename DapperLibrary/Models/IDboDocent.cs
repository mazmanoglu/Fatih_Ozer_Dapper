namespace DapperLibrary.Models
{
    public interface IDboDocent
    {
        Campus CampusNr { get; set; }
        int DocentNr { get; set; }
        string Familienaam { get; set; }
        string Voornaam { get; set; }
        decimal Wedde { get; set; }

        string ToString();
    }
}