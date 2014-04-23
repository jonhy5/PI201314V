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

        public static Type ComentarioRepositoryTypeName
        {
            get 
            {
                return Type.GetType("DAL.ComentarioRepository,DAL");
            }
        }
    }
}
