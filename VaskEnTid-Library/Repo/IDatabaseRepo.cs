using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaskEnTid_Library.Repo
{
    public interface IDatabaseRepo
    {
        List<Object> GetAll();

        void Add(Object obj);

        void Delete(int id);

        void Update(Object obj);

    }
}
