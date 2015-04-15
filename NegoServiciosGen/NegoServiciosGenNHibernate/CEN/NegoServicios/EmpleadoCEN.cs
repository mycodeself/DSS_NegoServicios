

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
public partial class EmpleadoCEN
{
private IEmpleadoCAD _IEmpleadoCAD;

public EmpleadoCEN()
{
        this._IEmpleadoCAD = new EmpleadoCAD ();
}

public EmpleadoCEN(IEmpleadoCAD _IEmpleadoCAD)
{
        this._IEmpleadoCAD = _IEmpleadoCAD;
}

public IEmpleadoCAD get_IEmpleadoCAD ()
{
        return this._IEmpleadoCAD;
}

public int New_ (string p_usuario, string p_password, string p_email, string p_nombre)
{
        EmpleadoEN empleadoEN = null;
        int oid;

        //Initialized EmpleadoEN
        empleadoEN = new EmpleadoEN ();
        empleadoEN.Usuario = p_usuario;

        empleadoEN.Password = p_password;

        empleadoEN.Email = p_email;

        empleadoEN.Nombre = p_nombre;

        //Call to EmpleadoCAD

        oid = _IEmpleadoCAD.New_ (empleadoEN);
        return oid;
}

public void Modify (int p_Empleado_OID, string p_usuario, string p_password, string p_email, string p_nombre)
{
        EmpleadoEN empleadoEN = null;

        //Initialized EmpleadoEN
        empleadoEN = new EmpleadoEN ();
        empleadoEN.Id = p_Empleado_OID;
        empleadoEN.Usuario = p_usuario;
        empleadoEN.Password = p_password;
        empleadoEN.Email = p_email;
        empleadoEN.Nombre = p_nombre;
        //Call to EmpleadoCAD

        _IEmpleadoCAD.Modify (empleadoEN);
}

public void Destroy (int id)
{
        _IEmpleadoCAD.Destroy (id);
}
}
}
