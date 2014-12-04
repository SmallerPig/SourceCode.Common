using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WXSSK.Common.Console
{
    public interface ISearchable
    {
        IEnumerable<ConsoleEntity> Search(string keyword);
    }
}
