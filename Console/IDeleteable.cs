using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WUXI.SourceCode.Common.Console
{
    public interface IDeleteable
    {
        bool IsLock { get; set; }
    }
}
