﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCRazorCRUD.Models
{
    public class ProfessorBase
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Endereco { get; set; }

        public string Telefone { get; set; }
    }
}

