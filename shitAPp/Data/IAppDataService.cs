using AppModel;
using System.Collections.Generic;

namespace shitAPp.Data
{
    public interface IAppDataService
    {
        IEnumerable<Friend> GetAll();
    }
}