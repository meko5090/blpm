///////////////////////////////////////////////////////////
//  Usuario.cs
//  Implementation of the Class Usuario
//  Generated by Enterprise Architect
//  Created on:      12-jun-2011 07:38:45 p.m.
//  Original author: Pablo Nicoliello
///////////////////////////////////////////////////////////




public class Usuario {

	private int _estadoCuenta;
	private Datetime _fechaAlta;
	private Datetime _fechaBaja;
	private string _nombre;
	private Perfil _perfil;
	public Perfil m_Perfil;

	public Usuario(){

	}

	~Usuario(){

	}

	public virtual void Dispose(){

	}

	public int _estadoCuenta{
		get{
			return _estadoCuenta;
		}
		set{
			_estadoCuenta = value;
		}
	}

	public Datetime _fechaAlta{
		get{
			return _fechaAlta;
		}
		set{
			_fechaAlta = value;
		}
	}

	public Datetime _fechaBaja{
		get{
			return _fechaBaja;
		}
		set{
			_fechaBaja = value;
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

	public Perfil _perfil{
		get{
			return _perfil;
		}
		set{
			_perfil = value;
		}
	}

}//end Usuario