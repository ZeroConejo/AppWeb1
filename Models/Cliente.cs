using System.ComponentModel.DataAnnotations;

namespace appweb1.Models
{
    public class Cliente
    {
        [Key]
        public int IdCliente {get;set;}
        public string Nombres{get;set;}
        public string Apellidos{get;set;}
        public string Dni{get;set;}
    }
}