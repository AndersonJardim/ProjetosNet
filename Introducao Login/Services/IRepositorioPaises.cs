using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Login.Services
{
    public interface IRepositorioPaises
    {
        List<string> ObterPaises();
    }
}
