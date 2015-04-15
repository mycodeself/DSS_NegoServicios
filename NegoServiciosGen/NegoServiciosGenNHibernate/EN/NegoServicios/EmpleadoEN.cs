
using System;

namespace NegoServiciosGenNHibernate.EN.NegoServicios
{
public partial class EmpleadoEN                 :                           NegoServiciosGenNHibernate.EN.NegoServicios.UsuarioEN


{
/**
 *
 */

private string nombre;





public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}





public EmpleadoEN() : base ()
{
}



public EmpleadoEN(int id, string nombre, string usuario, string password, string email)
{
        this.init (id, nombre, usuario, password, email);
}


public EmpleadoEN(EmpleadoEN empleado)
{
        this.init (empleado.Id, empleado.Nombre, empleado.Usuario, empleado.Password, empleado.Email);
}

private void init (int id, string nombre, string usuario, string password, string email)
{
        this.Id = id;


        this.Nombre = nombre;

        this.Usuario = usuario;

        this.Password = password;

        this.Email = email;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        EmpleadoEN t = obj as EmpleadoEN;
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
