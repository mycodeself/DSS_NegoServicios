
using System;

namespace NegoServiciosGenNHibernate.EN.NegoServicios
{
public partial class ClienteEN                  :                           NegoServiciosGenNHibernate.EN.NegoServicios.UsuarioEN


{
/**
 *
 */

private string dNI;

/**
 *
 */

private System.Collections.Generic.IList<NegoServiciosGenNHibernate.EN.NegoServicios.ReservaEN> reserva;





public virtual string DNI {
        get { return dNI; } set { dNI = value;  }
}


public virtual System.Collections.Generic.IList<NegoServiciosGenNHibernate.EN.NegoServicios.ReservaEN> Reserva {
        get { return reserva; } set { reserva = value;  }
}





public ClienteEN() : base ()
{
        reserva = new System.Collections.Generic.List<NegoServiciosGenNHibernate.EN.NegoServicios.ReservaEN>();
}



public ClienteEN(int id, string dNI, System.Collections.Generic.IList<NegoServiciosGenNHibernate.EN.NegoServicios.ReservaEN> reserva, string usuario, string password, string email)
{
        this.init (id, dNI, reserva, usuario, password, email);
}


public ClienteEN(ClienteEN cliente)
{
        this.init (cliente.Id, cliente.DNI, cliente.Reserva, cliente.Usuario, cliente.Password, cliente.Email);
}

private void init (int id, string dNI, System.Collections.Generic.IList<NegoServiciosGenNHibernate.EN.NegoServicios.ReservaEN> reserva, string usuario, string password, string email)
{
        this.Id = id;


        this.DNI = dNI;

        this.Reserva = reserva;

        this.Usuario = usuario;

        this.Password = password;

        this.Email = email;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ClienteEN t = obj as ClienteEN;
        if (t == null)
                return false;
        if (Id.Equals (t.Id))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id.GetHashCode ();
        return hash;
}
}
}
