using AppModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shitAPp.Data
{
    public class AppDataService : IAppDataService
    {
        public IEnumerable<Friend> GetAll()
        {
            yield return new Friend { FirstName = "Chajma", LastName = "-", Email = "@" };
            yield return new Friend { FirstName = "Chafsma", LastName = "-", Email = "@" };
            yield return new Friend { FirstName = "Chataveba", LastName = "-", Email = "@" };

        }
    }
}
