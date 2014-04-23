using System;

namespace DomainFactory
{
    class Config
    {
        public static Type AnuncioRepositoryTypeName
        {
            get
            {
                return Type.GetType("DAL.AnuncioRepository,DAL");
            }
        }
    }
}
