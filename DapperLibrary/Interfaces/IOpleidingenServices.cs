using DapperLibrary.Models;
using System.Collections.Generic;

namespace DapperLibrary.Interfaces
{
    public interface IOpleidingenServices
    {
        IEnumerable<ICampus> GetCampuses();
        IEnumerable<IDocent> GetDocents();
        void AddNewDocent(IDocent docent);
        void DeleteDocent(IDocent docent);
    }
}