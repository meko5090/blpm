///////////////////////////////////////////////////////////
//  Personal.cs
//  Implementation of the Class Personal
//  Generated by Enterprise Architect
//  Created on:      13-jun-2011 23:29:34
//  Original author: Laura Pastorino
///////////////////////////////////////////////////////////

using System;

namespace EDUAR_Entities
{
    [Serializable]
    public class Personal : Persona
    {
        private int _idPersonal;
        private int _idPersonalTransaccional;
        private DateTime _fechaAlta;
        private DateTime _fechaBaja;
        private int _legajo;
        private CargoPersonal _cargo;

        public Personal()
        {

        }

        ~Personal()
        {

        }

        public void Dispose()
        {

        }

        public int IdPersonal
        {
            get { return _idPersonal; }
            set { _idPersonal = value; }
        }

        public int IdPersonalTransaccional
        {
            get { return _idPersonalTransaccional; }
            set { _idPersonalTransaccional = value; }
        }

        public DateTime fechaAlta
        {
            get
            {
                return _fechaAlta;
            }
            set
            {
                _fechaAlta = value;
            }
        }

        public DateTime fechaBaja
        {
            get
            {
                return _fechaBaja;
            }
            set
            {
                _fechaBaja = value;
            }
        }

        public int legajo
        {
            get
            {
                return _legajo;
            }
            set
            {
                _legajo = value;
            }
        }

        public CargoPersonal cargo
        {
            get { return _cargo; }
            set { _cargo = value; }
        }

    }//end Personal
}