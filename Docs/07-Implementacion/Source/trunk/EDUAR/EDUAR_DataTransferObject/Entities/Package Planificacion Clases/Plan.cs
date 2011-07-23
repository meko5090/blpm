///////////////////////////////////////////////////////////
//  Plan.cs
//  Implementation of the Class Plan
//  Generated by Enterprise Architect
//  Created on:      20-jun-2011 16:21:53
//  Original author: Pablo Nicoliello
///////////////////////////////////////////////////////////


using System;
using System.Collections.Generic;
namespace EDUAR_Entities
{
    [Serializable]
    public class Plan
    {

        private List<Asignatura> _asignaturas;
        private List<Contenido> _contenidos;
        private Usuario _creador;
        private DateTime _fechaCreacion;
        private string _nombrePlan;
        private int _periodoFinVigencia;
        private int _periodoInicioVigencia;
        public Orientacion m_Orientacion;

        public Plan()
        {

        }

        ~Plan()
        {

        }

        public virtual void Dispose()
        {

        }

        public List<Asignatura> asignaturas
        {
            get
            {
                return _asignaturas;
            }
            set
            {
                _asignaturas = value;
            }
        }

        public List<Contenido> contenidos
        {
            get
            {
                return _contenidos;
            }
            set
            {
                _contenidos = value;
            }
        }

        public Usuario creador
        {
            get
            {
                return _creador;
            }
            set
            {
                _creador = value;
            }
        }

        public DateTime fechaCreacion
        {
            get
            {
                return _fechaCreacion;
            }
            set
            {
                _fechaCreacion = value;
            }
        }

        public string nombrePlan
        {
            get
            {
                return _nombrePlan;
            }
            set
            {
                _nombrePlan = value;
            }
        }

        public int periodoFinVigencia
        {
            get
            {
                return _periodoFinVigencia;
            }
            set
            {
                _periodoFinVigencia = value;
            }
        }

        public int periodoInicioVigencia
        {
            get
            {
                return _periodoInicioVigencia;
            }
            set
            {
                _periodoInicioVigencia = value;
            }
        }

    }//end Plan
}