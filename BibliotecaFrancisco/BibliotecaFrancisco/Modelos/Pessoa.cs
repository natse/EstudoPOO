﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaFrancisco.Modelos
{
    class Pessoa
    {
        private string cpf;
        private int id;
        private string nome;

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
    }
}
