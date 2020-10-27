using App.Entities.Queries;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data
{
    public class TrackDA
    {
        private ChinookModel _context;

        public TrackDA()
        {
            _context = new ChinookModel();
        }

       

        public IEnumerable<TrackConsult> GetTrackByName(string name)
        {
            name = !string.IsNullOrWhiteSpace(name) ? $"%{name}%" : "%";

            return _context.Database
           .SqlQuery<TrackConsult>("usp_GetTracks @artistName",
           new SqlParameter("@artistName", name)
           ).ToList();

        }
    }
}
