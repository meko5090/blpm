///////////////////////////////////////////////////////////
//  Curso.cs
//  Implementation of the Class Curso
//  Generated by Enterprise Architect
//  Created on:      12-jun-2011 07:38:32 p.m.
//  Original author: orkus
///////////////////////////////////////////////////////////




public class Curso {

	private Alumno _alumnos;
	private Asignatura _asignaturas;
	private string _division;
	private Nivel _nivel;
	private string _nombre;
	private Preceptor _preceptor;
	public Alumno m_Alumno;
	public Asignatura m_Asignatura;
	public Nivel m_Nivel;
	public Preceptor m_Preceptor;

	public Curso(){

	}

	~Curso(){

	}

	public virtual void Dispose(){

	}

	public Alumno _alumnos{
		get{
			return _alumnos;
		}
		set{
			_alumnos = value;
		}
	}

	public Asignatura _asignaturas{
		get{
			return _asignaturas;
		}
		set{
			_asignaturas = value;
		}
	}

	public string _division{
		get{
			return _division;
		}
		set{
			_division = value;
		}
	}

	public Nivel _nivel{
		get{
			return _nivel;
		}
		set{
			_nivel = value;
		}
	}

	public string _nombre{
		get{
			return _nombre;
		}
		set{
			_nombre = value;
		}
	}

	public Preceptor _preceptor{
		get{
			return _preceptor;
		}
		set{
			_preceptor = value;
		}
	}

}//end Curso