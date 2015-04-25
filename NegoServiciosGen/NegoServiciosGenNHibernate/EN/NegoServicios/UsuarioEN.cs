
using System;

namespace NegoServiciosGenNHibernate.EN.NegoServicios
{
public partial class UsuarioEN
{
/**
 *
 */

private int id;

/**
 *
 */

private string usuario;

/**
 *
 */

private string password;

/**
 *
 */

private string email;





public virtual int Id {
        get { return id; } set { id = value;  }
}


public virtual string Usuario {
        get { return usuario; } set { usuario = value;  }
}


public virtual string Password {
        get { return password; } set { password = value;  }
}


public virtual string Email {
        get { return email; } set { email = value;  }
}





public UsuarioEN()
{
}



public UsuarioEN(int id, string usuario, string password, string email)
{
        this.init (id, usuario, password, email);
}


public UsuarioEN(UsuarioEN usuario)
{
        this.init (usuario.Id, usuario.Usuario, usuario.Password, usuario.Email);
}

private void init (int id, string usuario, string password, string email)
{
        this.Id = id;


        this.Usuario = usuario;

        this.Password = password;

        this.Email = email;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        UsuarioEN t = obj as UsuarioEN;
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
