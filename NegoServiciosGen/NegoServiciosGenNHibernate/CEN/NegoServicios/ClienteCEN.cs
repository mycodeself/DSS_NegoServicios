

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
public partial class ClienteCEN
{
private IClienteCAD _IClienteCAD;

public ClienteCEN()
{
        this._IClienteCAD = new ClienteCAD ();
}

public ClienteCEN(IClienteCAD _IClienteCAD)
{
        this._IClienteCAD = _IClienteCAD;
}

public IClienteCAD get_IClienteCAD ()
{
        return this._IClienteCAD;
}

public int New_ (string p_usuario, string p_password, string p_email, string p_DNI)
{
        ClienteEN clienteEN = null;
        int oid;

        //Initialized ClienteEN
        clienteEN = new ClienteEN ();
        clienteEN.Usuario = p_usuario;

        clienteEN.Password = p_password;

        clienteEN.Email = p_email;

        clienteEN.DNI = p_DNI;

        //Call to ClienteCAD

        oid = _IClienteCAD.New_ (clienteEN);
        return oid;
}

public void Modify (int p_Cliente_OID, string p_usuario, string p_password, string p_email, string p_DNI)
{
        ClienteEN clienteEN = null;

        //Initialized ClienteEN
        clienteEN = new ClienteEN ();
        clienteEN.Id = p_Cliente_OID;
        clienteEN.Usuario = p_usuario;
        clienteEN.Password = p_password;
        clienteEN.Email = p_email;
        clienteEN.DNI = p_DNI;
        //Call to ClienteCAD

        _IClienteCAD.Modify (clienteEN);
}

public void Destroy (int id)
{
        _IClienteCAD.Destroy (id);
}
}
}
