using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataDomain.Entity;
using DataDomain.RepositoryInterface;
using DomainFactory.RepoFactory;

namespace DataDomain.DomainAcess
{
    public class AnuncioModel
    {

        private IAnuncioRepository _repository = RepositoryFactory.GetInstanceAnuncio<IAnuncioRepository>();

        public AnuncioModel()
        {
            FillMemoRepository();
        }

        public IEnumerable<Anuncio> GetAll()
        {
            return _repository.GetAll();
        }

        public void Add(Anuncio a)
        {
            _repository.Add(a);   
        }

        public void FillMemoRepository()
        {
            Anuncio p = new Anuncio { Title = "Renault" };
            Anuncio p1 = new Anuncio { Title = "Ford"   };

            Add(p);
            Add(p1);
        }
    }
}
