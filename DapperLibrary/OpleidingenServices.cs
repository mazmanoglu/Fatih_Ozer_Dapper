using DapperLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
using DapperLibrary.Interfaces;

namespace DapperLibrary
{
    public class OpleidingenServices : IOpleidingenServices
    {
        public IEnumerable<ICampus> GetCampuses()
        {
            using (IDbConnection connection = new SqlConnection(OpleidingenDbManager.GetConnection("Opleidingen")))
            {
                var campusses = connection.Query<Campus>("spGetAllCampusses", commandType: CommandType.StoredProcedure).ToList();
                return campusses;
            }
        }
        public IEnumerable<IDocent> GetDocents()
        {
            using (IDbConnection connection = new SqlConnection(OpleidingenDbManager.GetConnection("Opleidingen")))
            {
                var docents = connection.Query<Docent>("spGetAllDocents", commandType: CommandType.StoredProcedure).ToList();
                return docents;
            }
        }

        public void AddNewDocent(IDocent docent)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@Voornaam", docent.Voornaam);
            param.Add("@Familienaam", docent.Familienaam);
            param.Add("@Wedde", docent.Wedde);
            param.Add("@CampusNr", docent.CampusNr);

            using (IDbConnection connection = new SqlConnection(OpleidingenDbManager.GetConnection("Opleidingen")))
            {
                connection.Execute("spAddNewDocent", param, commandType: CommandType.StoredProcedure);
            }
        }
        public void DeleteDocent(IDocent docent)
        {
            using (IDbConnection connection = new SqlConnection(OpleidingenDbManager.GetConnection("Opleidingen")))
            {
                connection.Execute("spDeleteDocent", commandType: CommandType.StoredProcedure);
            }
        }
    }
}
