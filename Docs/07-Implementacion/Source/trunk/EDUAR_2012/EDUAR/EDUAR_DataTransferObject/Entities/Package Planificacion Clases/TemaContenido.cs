///////////////////////////////////////////////////////////
//  TemaContenido.cs
//  Implementation of the Class TemaContenido
//  Generated by Enterprise Architect
//  Created on:      20-jun-2011 16:21:56
//  Original author: Pablo Nicoliello
///////////////////////////////////////////////////////////

using System;
using EDUAR_Entities.Shared;
namespace EDUAR_Entities
{
    [Serializable]
    public class TemaContenido: DTBase
    {
        public int idTemaContenido { get; set; }
		public string titulo { get; set; }
		public string detalle { get; set; }
		public bool obligatorio { get; set; }
		public int idContenido { get; set; }

        public TemaContenido()
        {
			obligatorio = true;
        }

        ~TemaContenido()
        {

        }

        public virtual void Dispose()
        {

        }
    }//end TemaContenido
}