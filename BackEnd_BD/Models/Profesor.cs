﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEnd_BD.Models
{
    public class Profesor
    {
        public int Id { get; set; }
        public string Matricula { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Edad { get; set; }
        public string Salario { get; set; }
        public string Materias { get; set; }

    }
}