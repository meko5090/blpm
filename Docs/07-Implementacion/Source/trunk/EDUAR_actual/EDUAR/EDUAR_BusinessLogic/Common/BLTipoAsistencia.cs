﻿using System;
using System.Collections.Generic;
using EDUAR_BusinessLogic.Shared;
using EDUAR_DataAccess.Common;
using EDUAR_DataAccess.Shared;
using EDUAR_Entities;
using EDUAR_Entities.Shared;
using EDUAR_Utility.Enumeraciones;
using EDUAR_Utility.Excepciones;

namespace EDUAR_BusinessLogic.Common
{
    public class BLTipoAsistencia : BusinessLogicBase<TipoAsistencia, DATipoAsistencia>
    {
        #region --[Constante]--
        private const string ClassName = "BLTipoAsistencia";
        #endregion

        #region --[Constructores]--
        /// <summary>
        /// Constructor con DTO como parámetro.
        /// </summary>
        public BLTipoAsistencia(DTBase objTipoAsistencia)
        {
            Data = (TipoAsistencia)objTipoAsistencia;
        }
        /// <summary>
        /// Constructor vacio
        /// </summary>
        public BLTipoAsistencia()
        {
            Data = new TipoAsistencia();
        }
        #endregion

        #region --[Propiedades Override]--
        protected override sealed DATipoAsistencia DataAcces
        {
            get { return dataAcces; }
            set { dataAcces = value; }
        }

        public override sealed TipoAsistencia Data
        {
            get { return data; }
            set { data = value; }
        }

        public override string FieldId
        {
            get { return DataAcces.FieldID; }
        }

        public override string FieldDescription
        {
            get { return DataAcces.FieldDescription; }
        }

        /// <summary>
        /// Gets the by id.
        /// </summary>
        public override void GetById()
        {
            try
            {
                Data = DataAcces.GetById(Data);
            }
            catch (CustomizedException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new CustomizedException(string.Format("Fallo en {0} - GetById", ClassName), ex,
                                              enuExceptionType.BusinessLogicException);
            }
        }

        /// <summary>
        /// Método que guarda el registro actualmente cargado en memoria. No importa si se trata de una alta o modificación.
        /// </summary>
        public override void Save()
        {
            try
            {
                //Abre la transaccion que se va a utilizar
                DataAcces.Transaction.OpenTransaction();
                Int32 idTipoAsistencia = 0;

                if (Data.idTipoAsistencia == 0)
                    DataAcces.Create(Data, out idTipoAsistencia);
                else
                    DataAcces.Update(Data);

                //Se da el OK para la transaccion.
                DataAcces.Transaction.CommitTransaction();
            }
            catch (CustomizedException ex)
            {
                DataAcces.Transaction.RollbackTransaction();
                throw ex;
            }
            catch (Exception ex)
            {
                DataAcces.Transaction.RollbackTransaction();
                throw new CustomizedException(string.Format("Fallo en {0} - Save()", ClassName), ex,
                                              enuExceptionType.BusinessLogicException);
            }
        }

        /// <summary>
        /// Método que guarda el registro actualmente cargado en memoria. No importa si se trata de una alta o modificación.
        /// </summary>
        public override void Save(DATransaction objDATransaction)
        {
            try
            {
                //Si no viene el Id es porque se esta creando la entidad
                DataAcces = new DATipoAsistencia(objDATransaction);
                if (Data.idTipoAsistencia == 0)
                    DataAcces.Create(Data);
                else
                {
                    DataAcces.Update(Data);
                }
            }
            catch (CustomizedException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new CustomizedException(string.Format("Fallo en {0} - Save()", ClassName), ex,
                                              enuExceptionType.BusinessLogicException);
            }
        }

        public override void Delete()
        {
            throw new NotImplementedException();
        }

        public override void Delete(DATransaction objDATransaction)
        {
            try
            {
                DataAcces = new DATipoAsistencia(objDATransaction);
                DataAcces.Delete(Data);
            }
            catch (CustomizedException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new CustomizedException(string.Format("Fallo en {0} - Delete()", ClassName), ex,
                                              enuExceptionType.BusinessLogicException);
            }
        }
        #endregion

        #region --[Métodos publicos]--
		/// <summary>
		/// Gets the tipo asistencia.
		/// </summary>
		/// <param name="entidad">The entidad.</param>
		/// <returns></returns>
        public List<TipoAsistencia> GetTipoAsistencia(TipoAsistencia entidad)
        {
            try
            {
                return DataAcces.GetTipoAsistencia(entidad);
            }
            catch (CustomizedException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
				throw new CustomizedException(string.Format("Fallo en {0} - GetTipoAsistencia", ClassName), ex,
                                              enuExceptionType.BusinessLogicException);
            }
        }
        #endregion
    }
}
