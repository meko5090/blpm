﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using EDUAR_DataAccess.Shared;
using EDUAR_Entities;
using EDUAR_Utility.Enumeraciones;
using EDUAR_Utility.Excepciones;

namespace EDUAR_DataAccess.Common
{
	public class DAAlumno : DataAccesBase<Alumno>
	{
		#region --[Atributos]--
		private const string ClassName = "DAAlumno";
		#endregion

		#region --[Constructor]--
		public DAAlumno()
		{
		}

		public DAAlumno(DATransaction objDATransaction)
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

		public override Alumno GetById(Alumno entidad)
		{
			throw new NotImplementedException();
		}

		public override void Create(Alumno entidad)
		{
			throw new NotImplementedException();
		}

		public override void Create(Alumno entidad, out int identificador)
		{
			throw new NotImplementedException();
		}

		public override void Update(Alumno entidad)
		{
			throw new NotImplementedException();
		}

		public override void Delete(Alumno entidad)
		{
			throw new NotImplementedException();
		}
		#endregion

		#region --[Métodos Públicos]--
		/// <summary>
		/// Gets the alumnos.
		/// </summary>
		/// <param name="entidad">The entidad.</param>
		/// <returns></returns>
		public List<Alumno> GetAlumnos(AlumnoCurso entidad)
		{
			try
			{
				Transaction.DBcomand = Transaction.DataBase.GetStoredProcCommand("AlumnosPorCurso_Select");
				if (entidad != null)
				{
					if (entidad.alumno.idAlumno > 0)
						Transaction.DataBase.AddInParameter(Transaction.DBcomand, "@idAlumno", DbType.Int32, entidad.alumno.idAlumno);
					if (entidad.curso.idCurso > 0)
						Transaction.DataBase.AddInParameter(Transaction.DBcomand, "@idCurso", DbType.Int32, entidad.curso.idCurso);
					if (!string.IsNullOrEmpty(entidad.alumno.username))
						Transaction.DataBase.AddInParameter(Transaction.DBcomand, "@username", DbType.String, entidad.alumno.username);
				}

				IDataReader reader = Transaction.DataBase.ExecuteReader(Transaction.DBcomand);

				List<Alumno> listaAlumnos = new List<Alumno>();
				Alumno objAlumno;
				while (reader.Read())
				{
					objAlumno = new Alumno();

					objAlumno.idAlumno = Convert.ToInt32(reader["idAlumno"]);
					objAlumno.nombre = reader["nombre"].ToString();
					objAlumno.apellido = reader["apellido"].ToString();
					if (!string.IsNullOrEmpty(reader["fechaAlta"].ToString()))
						objAlumno.fechaAlta = (DateTime)reader["fechaAlta"];
					if (!string.IsNullOrEmpty(reader["fechaBaja"].ToString()))
						objAlumno.fechaBaja = (DateTime)reader["fechaBaja"];
					objAlumno.activo = Convert.ToBoolean(reader["activo"]);
					objAlumno.idPersona = Convert.ToInt32(reader["idPersona"]);
					//TODO: Completar los miembros que faltan de alumno

					listaAlumnos.Add(objAlumno);
				}
				return listaAlumnos;
			}
			catch (SqlException ex)
			{
				throw new CustomizedException(string.Format("Fallo en {0} - GetAlumnosPorCurso()", ClassName),
									ex, enuExceptionType.SqlException);
			}
			catch (Exception ex)
			{
				throw new CustomizedException(string.Format("Fallo en {0} - GetalumnosPorCurso()", ClassName),
									ex, enuExceptionType.DataAccesException);
			}
		}

		/// <summary>
		/// Gets the curso alumno.
		/// </summary>
		/// <param name="entidad">The entidad.</param>
		/// <returns></returns>
		public AlumnoCurso GetCursoAlumno(Alumno entidad)
		{
			try
			{
				Transaction.DBcomand = Transaction.DataBase.GetStoredProcCommand("AlumnosPorCurso_Select");
				if (entidad != null)
				{
					if (!string.IsNullOrEmpty(entidad.username))
						Transaction.DataBase.AddInParameter(Transaction.DBcomand, "@username", DbType.String, entidad.username);
				}

				IDataReader reader = Transaction.DataBase.ExecuteReader(Transaction.DBcomand);

				AlumnoCurso objAlumnoCurso = null;
				while (reader.Read())
				{
					objAlumnoCurso = new AlumnoCurso();
					objAlumnoCurso.alumno.idAlumno = Convert.ToInt32(reader["idAlumno"]);
					objAlumnoCurso.alumno.nombre = reader["nombre"].ToString();
					objAlumnoCurso.alumno.apellido = reader["apellido"].ToString();
					if (!string.IsNullOrEmpty(reader["fechaAlta"].ToString()))
						objAlumnoCurso.alumno.fechaAlta = (DateTime)reader["fechaAlta"];
					if (!string.IsNullOrEmpty(reader["fechaBaja"].ToString()))
						objAlumnoCurso.alumno.fechaBaja = (DateTime)reader["fechaBaja"];
					objAlumnoCurso.alumno.activo = Convert.ToBoolean(reader["activo"]);
					objAlumnoCurso.alumno.idPersona = Convert.ToInt32(reader["idPersona"]);
					objAlumnoCurso.curso.idCurso = Convert.ToInt32(reader["idCurso"]);
					return objAlumnoCurso;
				}
				return null;
			}
			catch (SqlException ex)
			{
				throw new CustomizedException(string.Format("Fallo en {0} - GetCursoAlumno()", ClassName),
									ex, enuExceptionType.SqlException);
			}
			catch (Exception ex)
			{
				throw new CustomizedException(string.Format("Fallo en {0} - GetCursoAlumno()", ClassName),
									ex, enuExceptionType.DataAccesException);
			}
		}
		#endregion
	}
}