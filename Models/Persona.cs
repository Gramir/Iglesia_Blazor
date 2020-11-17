using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea9_10.Models
{
    public class Persona
    {
        public int Id { get; set; }
        [Required]
        public byte[] Foto { get; set; }
        [Required]
        public string Sexo { get; set; }
        [Required]
        public string Apellidos { get; set; }
        [Required]
        public string Nombres { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime F_Nacimiento { get; set; }
        [Required]
        public string Pais_Nac { get; set; }
        [Required]
        public string Ciudad_Nac { get; set; }
        [Required]
        public string Pais_Res { get; set; }
        [Required]
        public string Ciudad_Res { get; set; }
        [Required]
        public string Direccion { get; set; }
        [Required]   
        [Phone]
        public string Telefono { get; set; }
        [Required]
        public string Celular { get; set; }
        [Required]
        [EmailAddress]
        public string Correo { get; set; }
        [Required]
        public string Tipo_Docum { get; set; }
        [Required]
        public string Documento_ID { get; set; }
        [Required]
        public string EstadoCivil { get; set; }
        public string Casado { get; set; }
        public string Tiene_Hijos { get; set; }
        public int N_Hijos { get; set; }
        public string Profesion { get; set; }
        public string Ocu_Actual { get; set; }
        public string Empr_Negocio { get; set; }
        [Phone]
        public string Prof_Tele { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime F_Conversion { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime F_Bautismo { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime F_Iglesia { get; set; }
        [Required]
        public string Denominacion { get; set; }
        [Required]
        public string Iglesia_Actual { get; set; }
        public string Iglesia_Anterior { get; set; }
        [Required]
        public string Pastor_Actual { get; set; }
        [Required]
        public string Disciplinado { get; set; }
        public int Cant_Disc { get; set; }
        public string Causas { get; set; }
        [Required]
        public string Funcion { get; set; }
        public string Ministerios { get; set; }
        public string Minis_frutos { get; set; }
        public string Mini_llamado { get; set; }
        public string Metas { get; set; }
        public string Respaldo { get; set; }
        public string N_Estudio { get; set; }
        public string Expulsado { get; set; }
        public string Exp_Razon { get; set; }
    }
}
