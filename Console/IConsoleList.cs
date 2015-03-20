using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WXSSK.Common.Console
{
    /// <summary>
    /// 可以在CMS里面呈现列表接口
    /// </summary>
    public interface IConsoleListable<T> where T : ConsoleEntity 
    {
        int GetCount(bool islocked);
        IList<T> GetList(int from, int count,bool isLock);
        //IEnumerable<T> Search(string keyword);
        T GetById(int id);
        void ToRecycle(T t);
        void Restore(T t);
        void Delete(T t);
        T Insert(T t);
        void Update(T t);
    }
}
