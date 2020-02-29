﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoModeloDDD.MVC.ViewModels
{
    public class ClienteViewModel
    {
        [Key]
        public int ClienteId { get; set; }
        [Required(ErrorMessage = "Preencha o campo nome.")]
        [MaxLength(150, ErrorMessage = "Máximo de 150 caracteres.")]
        [MinLength(2, ErrorMessage = "Mínimo de 2 caracteres.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Preencha o campo sobrenome.")]
        [MaxLength(150, ErrorMessage = "Máximo de 150 caracteres.")]
        [MinLength(2, ErrorMessage = "Mínimo de 2 caracteres.")]
        public string Sobrenome { get; set; }
        [Required(ErrorMessage = "Preencha o campo e-mail.")]
        [MaxLength(100, ErrorMessage = "Máximo de 100 caracteres.")]
        [EmailAddress(ErrorMessage = "Preencha o e-mail valido.")]
        [DisplayName("E-mail")]
        public string Email { get; set; }
        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        public virtual IEnumerable<ProdutoViewModel> Produtos { get; set; }
       
    }
}