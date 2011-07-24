﻿using System;

namespace EDUAR_Entities.Reports
{
    public class InasistenciasAlumnoPeriodo
    {

        public string nombreAlumno { get; set; }
        public DateTime fechaInasistencia { get; set; }
        public string motivoInasistencia { get; set; }

        public InasistenciasAlumnoPeriodo()
        {
            nombreAlumno = string.Empty;
            fechaInasistencia = System.DateTime.Now;
            motivoInasistencia = string.Empty;
        }

    }
}