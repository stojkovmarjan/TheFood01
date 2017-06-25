using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TheFood01.Models
{
    public class Artikal
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Полето е задолжително!")]
        [StringLength(20,ErrorMessage ="Најмногу 30 букви, најмалку 2 букви!")]
        [Index(IsUnique =true)]
        [Display(Name ="Назив на артикал")]
        public string Ime { get; set; }

        [Required(ErrorMessage = "Полето е задолжително!")]
        [StringLength(6, ErrorMessage = "Најмногу 6 букви, најмалку 1 буквa!")]
        [Display(Name = "Единечна мера")]
        public string Edm { get; set; }

    }
}