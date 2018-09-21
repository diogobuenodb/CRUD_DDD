using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BRQ.UI.Web.ViewModels
{
    public class User
    {
        public int IdUser { get; set; }

        [Required]
        [Display(Name = "Nome")]
        [MaxLength(100, ErrorMessage = "Máximo permitido são 100 caracteres.")]
        public string name { get; set; }

        [Required]
        [Display(Name = "E-mail")]
        [MaxLength(100, ErrorMessage = "Máximo permitido são 100 caracteres.")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }
    }
}