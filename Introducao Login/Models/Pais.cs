﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Login.Models
{
    public class Pais
    {
        public Pais(string nome)
        {
            Nome = nome;
        }

        public int id { get; set; }

        public string Nome { get; set; }

    }
}
