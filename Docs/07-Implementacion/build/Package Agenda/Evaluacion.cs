///////////////////////////////////////////////////////////
//  Evaluacion.cs
//  Implementation of the Class Evaluacion
//  Generated by Enterprise Architect
//  Created on:      12-jun-2011 07:38:34 p.m.
//  Original author: Pablo Nicoliello
///////////////////////////////////////////////////////////




public class Evaluacion {

	private Asignatura _asignatura;
	private Datetime _fecha;
	public Asignatura m_Asignatura;

	public Evaluacion(){

	}

	~Evaluacion(){

	}

	public virtual void Dispose(){

	}

	public Asignatura _asignatura{
		get{
			return _asignatura;
		}
		set{
			_asignatura = value;
		}
	}

	public Datetime _fecha{
		get{
			return _fecha;
		}
		set{
			_fecha = value;
		}
	}

}//end Evaluacion