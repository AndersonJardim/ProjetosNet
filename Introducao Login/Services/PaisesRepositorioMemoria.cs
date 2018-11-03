using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Login.Services
{
    public class PaisesRepositorioMemoria:IRepositorioPaises
    {
    public List<string> ObterPaises()
    {
        List<string> paises = new List<string>() { "Brasil", "Méxio", "Uruguai", "Suica", "Angola" }; //Adicionei Angola
        return paises;
    }
}
}
