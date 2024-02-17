using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantracts
{
    public interface UnitOfWork
    {
        Task Commit();
        Task RollBack();
        Task Complete();
        Task Begin();

    }
}
