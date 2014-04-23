using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataDomain.Entity;

namespace DataDomain.RepositoryInterface
{
    public interface IAnuncioRepository
    {
        IEnumerable<Anuncio> GetAll();
        void Add(Anuncio todo);
    }
}
