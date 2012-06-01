﻿using System;
using EDUAR_DataAccess.Shared;
using EDUAR_Entities;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using EDUAR_Utility.Enumeraciones;
using EDUAR_Utility.Excepciones;

namespace EDUAR_DataAccess.Common
{
    public class DAPlanificacionAnual : DataAccesBase<PlanificacionAnual>
    {
        #region --[Atributos]--
        private const string ClassName = "DAPlanificacionAnual";
        #endregion

        #region --[Constructor]--
        public DAPlanificacionAnual()
        {
        }

        public DAPlanificacionAnual(DATransaction objDATransaction)
            : base(objDATransaction)
        {

        }
        #endregion

        #region --[Implementación métodos heredados]--
        public override string FieldID
        {
            get { throw new NotImplementedException(); }
        }

        public override string FieldDescription
        {
            get { throw new NotImplementedException(); }
        }

        public override PlanificacionAnual GetById(PlanificacionAnual entidad)
        {
            throw new NotImplementedException();
        }

        public override void Create(PlanificacionAnual entidad)
        {
            throw new NotImplementedException();
        }

        public override void Create(PlanificacionAnual entidad, out int identificador)
        {
            throw new NotImplementedException();
        }

        public override void Update(PlanificacionAnual entidad)
        {
            throw new NotImplementedException();
        }

        public override void Delete(PlanificacionAnual entidad)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region --[Métodos Públicos]--
		/// <summary>
		/// Gets the planificacion.
		/// </summary>
		/// <param name="entidad">The entidad.</param>
		/// <returns></returns>
		public List<PlanificacionAnual> GetPlanificacion(PlanificacionAnual entidad)
		{
			try
			{
				Transaction.DBcomand = Transaction.DataBase.GetStoredProcCommand("PlanificacionAnual_Select");
				if (entidad != null)
				{
					if (entidad.asignaturaCicloLectivo.idAsignaturaCicloLectivo > 0)
						Transaction.DataBase.AddInParameter(Transaction.DBcomand, "@idAsignaturaCicloLectivo", DbType.Int32, entidad.asignaturaCicloLectivo.idAsignaturaCicloLectivo);
					if (entidad.idPlanificacionAnual > 0)
						Transaction.DataBase.AddInParameter(Transaction.DBcomand, "@idPlanificacionAnual", DbType.Int32, entidad.idPlanificacionAnual);
				}
				IDataReader reader = Transaction.DataBase.ExecuteReader(Transaction.DBcomand);

				List<PlanificacionAnual> listaEntidad = new List<PlanificacionAnual>();
				PlanificacionAnual objEntidad;
				while (reader.Read())
				{
					objEntidad = new PlanificacionAnual();
					objEntidad.idPlanificacionAnual = Convert.ToInt32(reader["idPlanificacionAnual"]);
					objEntidad.creador = new Persona() { idPersona = Convert.ToInt32(reader["idCreador"]) };
					objEntidad.fechaAprobada = Convert.ToDateTime(reader["fechaAprobada"]);
					objEntidad.fechaCreacion = Convert.ToDateTime(reader["fechaCreacion"]);
					objEntidad.observaciones = reader["observaciones"].ToString();
					objEntidad.asignaturaCicloLectivo = new AsignaturaCicloLectivo() { idAsignaturaCicloLectivo = Convert.ToInt32(reader["idAsignaturaCicloLectivo"]) };
					listaEntidad.Add(objEntidad);
				}
				return listaEntidad;
			}
			catch (SqlException ex)
			{
				throw new CustomizedException(string.Format("Fallo en {0} - GetPlanificacion()", ClassName),
									ex, enuExceptionType.SqlException);
			}
			catch (Exception ex)
			{
				throw new CustomizedException(string.Format("Fallo en {0} - GetPlanificacion()", ClassName),
									ex, enuExceptionType.DataAccesException);
			}
		}
        #endregion
    }
}