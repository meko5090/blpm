///////////////////////////////////////////////////////////
//  Mensaje.cs
//  Implementation of the Class Mensaje
//  Generated by Enterprise Architect
//  Created on:      12-jun-2011 07:44:17 p.m.
//  Original author: Pablo Nicoliello
///////////////////////////////////////////////////////////




public class Mensaje {

	private Usuario _destinatarios;
	private Datetime _fechaEnvio;
	private Usuario _remitente;
	private string _textoMensaje;
	public Usuario m_Usuario;

	public Mensaje(){

	}

	~Mensaje(){

	}

	public virtual void Dispose(){

	}

	public Usuario _destinatarios{
		get{
			return _destinatarios;
		}
		set{
			_destinatarios = value;
		}
	}

	public Datetime _fechaEnvio{
		get{
			return _fechaEnvio;
		}
		set{
			_fechaEnvio = value;
		}
	}

	public Usuario _remitente{
		get{
			return _remitente;
		}
		set{
			_remitente = value;
		}
	}

	public string _textoMensaje{
		get{
			return _textoMensaje;
		}
		set{
			_textoMensaje = value;
		}
	}

}//end Mensaje