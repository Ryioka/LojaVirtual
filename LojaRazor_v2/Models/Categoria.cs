﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LojaRazor_v2.Models
{
    public class Categoria
    {
        public string Nome { get; set; }

        public Categoria(string nome)
        {
            this.Nome = nome;
        }
    }
}
