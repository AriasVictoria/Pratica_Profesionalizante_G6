﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_Proyecto
{
    public class Administrador
    {
        public string NombreAdministrador { get; set; }
        public string ApellidoAdministrador { get; set; }
        public string contraseña { get; set; }
        public string A
        {
            get { return "Nombre: " + NombreAdministrador + ", Aoellido: " + ApellidoAdministrador + ", Contraseña: " + contraseña; }
        }
    }
}