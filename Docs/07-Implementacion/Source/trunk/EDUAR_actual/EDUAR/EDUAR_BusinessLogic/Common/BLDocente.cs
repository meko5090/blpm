﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDUAR_DataAccess.Common;
using EDUAR_Entities;
using EDUAR_BusinessLogic.Shared;
using EDUAR_Entities.Shared;
using EDUAR_Utility.Excepciones;
using EDUAR_Utility.Enumeraciones;
using EDUAR_DataAccess.Shared;

namespace EDUAR_BusinessLogic.Common
{
    public class BLDocente : BusinessLogicBase<Docente, DADocente>
    {
        #region --[Constante]--
        private const string ClassName = "BLDocente";
        #endregion

        #region --[Constructores]--
        /// <summary>
        /// Constructor con DTO como parámetro.
        /// </summary>
        public BLDocente(DTBase objDocente)
        {
            Data = (Docente)objDocente;
        }
        /// <summary>
        /// Constructor vacio
        /// </summary>
        public BLDocente()
        {
            Data = new Docente();
        }
        #endregion

        #region --[Propiedades Override]--
        protected override sealed DADocente DataAcces
        {
            get { return dataAcces; }
            set { dataAcces = value; }
        }

        public override sealed Docente Data
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
                int idDocente = 0;

                if (Data.idDocente == 0)
                    DataAcces.Create(Data, out idDocente);
                else
                    DataAcces.Update(Data);

                //Se da el OK para la transaccion.
                DataAcces.Transaction.CommitTransaction();
            }
            catch (CustomizedException ex)
            {
                if (DataAcces != null && DataAcces.Transaction != null)
                    DataAcces.Transaction.RollbackTransaction();
                throw ex;
            }
            catch (Exception ex)
            {
                if (DataAcces != null && DataAcces.Transaction != null)
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
                DataAcces = new DADocente(objDATransaction);
                if (Data.idDocente == 0)
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
                DataAcces = new DADocente(objDATransaction);
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
        public List<Docente> GetDocentes(Docente entidad)
        {
            try
            {
                return DataAcces.GetDocentes(entidad);
            }
            catch (CustomizedException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new CustomizedException(string.Format("Fallo en {0} - GetDocentes", ClassName), ex,
                                              enuExceptionType.BusinessLogicException);
            }
        }

        public List<Docente> GetDocentes(int entidad)
        {
            try
            {
                return DataAcces.GetDocentes(entidad);
            }
            catch (CustomizedException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new CustomizedException(string.Format("Fallo en {0} - GetDocentes", ClassName), ex,
                                              enuExceptionType.BusinessLogicException);
            }
        }
        #endregion
    }
}
