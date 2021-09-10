using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CiclosDeVidaEjemplo
{
    public interface ITransient { }
    public interface IScoped { }
    public interface ISingleton { }

    public class MiObjeto : ITransient, IScoped, ISingleton
    {
        public readonly int Value;

        public MiObjeto()
        {
            Value = new Random().Next(10000);
        }
    }
}
