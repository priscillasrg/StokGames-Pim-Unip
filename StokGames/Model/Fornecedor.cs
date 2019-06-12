﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokGames.Model
{
    public class Fornecedor : Pessoa
    {
        public string CNPJ { get; set; }
        public List<Entrada> Entradas { get; set; }
    }
}
