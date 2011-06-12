///////////////////////////////////////////////////////////
//  Plan.cs
//  Implementation of the Class Plan
//  Generated by Enterprise Architect
//  Created on:      12-jun-2011 07:38:40 p.m.
//  Original author: Pablo Nicoliello
///////////////////////////////////////////////////////////




public class Plan {

	private Asignatura _asignaturas;
	private Contenido _contenidos;
	private Usuario _creador;
	private Datetime _fechaCreacion;
	private string _nombrePlan;
	private int _periodoFinVigencia;
	private int _periodoInicioVigencia;
	public Orientacion m_Orientacion;

	public Plan(){

	}

	~Plan(){

	}

	public virtual void Dispose(){

	}

	public Asignatura _asignaturas{
		get{
			return _asignaturas;
		}
		set{
			_asignaturas = value;
		}
	}

	public Contenido _contenidos{
		get{
			return _contenidos;
		}
		set{
			_contenidos = value;
		}
	}

	public Usuario _creador{
		get{
			return _creador;
		}
		set{
			_creador = value;
		}
	}

	public Datetime _fechaCreacion{
		get{
			return _fechaCreacion;
		}
		set{
			_fechaCreacion = value;
		}
	}

	public string _nombrePlan{
		get{
			return _nombrePlan;
		}
		set{
			_nombrePlan = value;
		}
	}

	public int _periodoFinVigencia{
		get{
			return _periodoFinVigencia;
		}
		set{
			_periodoFinVigencia = value;
		}
	}

	public int _periodoInicioVigencia{
		get{
			return _periodoInicioVigencia;
		}
		set{
			_periodoInicioVigencia = value;
		}
	}

}//end Plan