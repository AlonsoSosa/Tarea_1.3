using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;


namespace Tarea_1._3.Models
{
    public class Persona
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(100)]
        public String nombre { get; set; }

        [MaxLength(100)]
        public String apellidos { get; set; }

        [MaxLength(3)]
        public int edad { get; set; }

        public String correo { get; set; }

        [MaxLength(100)]
        public String direccion { get; set; }
    }
}