using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WXSSK.Common.Console
{
    public abstract class BLLCLass : IConsoleListable<ConsoleEntity>
    {
        private IConsoleListable<ConsoleEntity> helper;

        private ISearchable search;

        public BLLCLass(IConsoleListable<ConsoleEntity> h)
        {
            this.helper = h;
        }

        public void SetSearcher(ISearchable s)
        {
            this.search = s;
        }

        public int GetCount(bool islocked)
        {
            return helper.GetCount(islocked);
        }

        public IList<ConsoleEntity> GetList(int from, int count, bool isLock)
        {
            return helper.GetList(from, count, isLock);
        }

        public IEnumerable<ConsoleEntity> Search(string keyword)
        {
            return search.Search(keyword);
        }

        public ConsoleEntity GetById(int id)
        {
            return helper.GetById(id);
        }

        public void ToRecycle(ConsoleEntity t)
        {
            helper.ToRecycle(t);
        }

        public void Restore(ConsoleEntity t)
        {
            helper.Restore(t);
        }

        public void Delete(ConsoleEntity t)
        {
            helper.Delete(t);
        }

        public ConsoleEntity Insert(ConsoleEntity t)
        {
            return helper.Insert(t);
        }

        public void Update(ConsoleEntity t)
        {
            helper.Update(t);
        }
    }
}
