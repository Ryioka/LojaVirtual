﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LojaRazor_v2.Models
{
    public class Usuario
    {
        [Required]
        public String Nome { get; set; }

        [Required, EmailAddress]
        public String Email { get; set; }

        [Required, MinLength(3)]
        public String Senha { get; set; }

        [Required, DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = false)]
        public DateTime DataDeNascimento { get; set; }

        public Sexo sexo { get; set; }

        [Required]
        public String Endereco { get; set; }

        public String Complemento { get; set; }

        [Required, RegularExpression("\\d{5}-\\d{3}")]
        public String CEP { get; set; }

        public Estado estado { get; set; }

        public string Observacoes { get; set; }

        public bool RecebePromocoes { get; set; }

    }
}