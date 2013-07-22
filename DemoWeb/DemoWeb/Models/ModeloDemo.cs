using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DemoWeb.Models
{
    public class ModeloDemo
    {
        [Required]
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }
}