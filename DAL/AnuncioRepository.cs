using System.Collections.Generic;
using DataDomain.Entity;
using DataDomain.RepositoryInterface;

namespace DAL
{
    public class AnuncioRepository: IAnuncioRepository
    {
        private readonly IDictionary<string, Anuncio> _repo = new Dictionary<string, Anuncio>();

        public IEnumerable<Anuncio> GetAll()
        {
            return _repo.Values;
        }

        public void Add(Anuncio e)
        {
            _repo.Add(e.Title, e);
        }
    }
}
