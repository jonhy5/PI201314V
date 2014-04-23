using System;

namespace DomainFactory.RepoFactory
{
    public class RepositoryFactory
    {
        public static T GetInstanceAnuncio<T>()
        {
            Type t = Config.AnuncioRepositoryTypeName;
            return (T)Activator.CreateInstance(t);
        }
    }
}
