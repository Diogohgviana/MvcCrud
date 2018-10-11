using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcCrud.Models
{
    public class Tarefas
    {
        [Key]
        public int IdTarefa { get; set; }

        [Required]
        public string DescricaoTarefa { get; set; }

        [Required]
        public string NomeResponsavel { get; set; }

        [Required]
        [EmailAddress(ErrorMessage ="Informe um E-mail válido")]
        public string EmailResponsavel { get; set; }
    
    }
}