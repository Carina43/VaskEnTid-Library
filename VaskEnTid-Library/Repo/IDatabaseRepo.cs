using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaskEnTid_Library.Repo
{
    public interface IDatabaseRepo<T, Tkey>

    {
        List<T> GetAll();

        void Add(T item);

        void Delete(Tkey key);

        void Update(T item, Tkey key);

    }
}
