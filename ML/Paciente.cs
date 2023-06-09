﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Paciente
    {
        public int IdPaciente { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string FechaNacimiento { get; set; }
        public string Sexo { get; set; }
        public string FechaIngreso { get; set; }
        public string Diagnostico { get; set; }
        public ML.TipoSangre TipoSangre { get; set; }
        public List<ML.Paciente> Pacientes { get; set; }
    }
}
