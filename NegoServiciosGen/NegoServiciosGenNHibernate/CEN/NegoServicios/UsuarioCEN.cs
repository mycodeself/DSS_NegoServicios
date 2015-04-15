

using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;

using NegoServiciosGenNHibernate.EN.NegoServicios;
using NegoServiciosGenNHibernate.CAD.NegoServicios;

namespace NegoServiciosGenNHibernate.CEN.NegoServicios
{
public partial class UsuarioCEN
{
private IUsuarioCAD _IUsuarioCAD;

public UsuarioCEN()
{
        this._IUsuarioCAD = new UsuarioCAD ();
}

public UsuarioCEN(IUsuarioCAD _IUsuarioCAD)
{
        this._IUsuarioCAD = _IUsuarioCAD;
}

public IUsuarioCAD get_IUsuarioCAD ()
{
        return this._IUsuarioCAD;
}

public int New_ (string p_usuario, string p_password, string p_email)
{
        UsuarioEN usuarioEN = null;
        int oid;

        //Initialized UsuarioEN
        usuarioEN = new UsuarioEN ();
        usuarioEN.Usuario = p_usuario;

        usuarioEN.Password = p_password;

        usuarioEN.Email = p_email;

        //Call to UsuarioCAD

        oid = _IUsuarioCAD.New_ (usuarioEN);
        return oid;
}

public void Modify (int p_Usuario_OID, string p_usuario, string p_password, string p_email)
{
        UsuarioEN usuarioEN = null;

        //Initialized UsuarioEN
        usuarioEN = new UsuarioEN ();
        usuarioEN.Id = p_Usuario_OID;
        usuarioEN.Usuario = p_usuario;
        usuarioEN.Password = p_password;
        usuarioEN.Email = p_email;
        //Call to UsuarioCAD

        _IUsuarioCAD.Modify (usuarioEN);
}

public void Destroy (int id)
{
        _IUsuarioCAD.Destroy (id);
}

public UsuarioEN ReadOID (int id)
{
        UsuarioEN usuarioEN = null;

        usuarioEN = _IUsuarioCAD.ReadOID (id);
        return usuarioEN;
}

public System.Collections.Generic.IList<UsuarioEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<UsuarioEN> list = null;

        list = _IUsuarioCAD.ReadAll (first, size);
        return list;
}
public System.Collections.Generic.IList<NegoServiciosGenNHibernate.EN.NegoServicios.ReservaEN> ReadByUsuario (string p_user)
{
        return _IUsuarioCAD.ReadByUsuario (p_user);
}
}
}
