namespace DapperLibrary.Interfaces
{
    public interface ICampus
    {
        int CampusNr { get; set; }
        string Gemeente { get; set; }
        string HuisNr { get; set; }
        string Naam { get; set; }
        string PostCode { get; set; }
        string Straat { get; set; }

        string ToString();
    }
}