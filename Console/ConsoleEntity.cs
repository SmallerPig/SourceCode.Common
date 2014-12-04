using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WXSSK.Common.Console
{
    public abstract class ConsoleEntity : IDeleteable, IIndexable
    {
        //如果这里是抽象类，则在其子类中将不定义该字段，从而无法在数据库中建立相应的字段。
        public int Id { get; set; }

        public bool Status { get; set; }

    }
}
