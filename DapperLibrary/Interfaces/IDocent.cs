﻿namespace DapperLibrary.Interfaces
{
    public interface IDocent
    {
        int CampusNr { get; set; }
        int DocentNr { get; set; }
        string Voornaam { get; set; }
        string Familienaam { get; set; }
        decimal Wedde { get; set; }

        string ToString();
    }
}