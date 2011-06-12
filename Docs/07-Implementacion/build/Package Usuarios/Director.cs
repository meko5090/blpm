///////////////////////////////////////////////////////////
//  Director.cs
//  Implementation of the Class Director
//  Generated by Enterprise Architect
//  Created on:      12-jun-2011 07:38:33 p.m.
//  Original author: Pablo Nicoliello
///////////////////////////////////////////////////////////




public class Director : Persona {

	private Datetime _fechaAlta;
	private Datetime _fechaBaja;
	private int _legajo;

	public Director(){

	}

	~Director(){

	}

	public override void Dispose(){

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

	public int _legajo{
		get{
			return _legajo;
		}
		set{
			_legajo = value;
		}
	}

}//end Director