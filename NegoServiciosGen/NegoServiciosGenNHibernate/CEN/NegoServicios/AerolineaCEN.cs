

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
public partial class AerolineaCEN
{
private IAerolineaCAD _IAerolineaCAD;

public AerolineaCEN()
{
        this._IAerolineaCAD = new AerolineaCAD ();
}

public AerolineaCEN(IAerolineaCAD _IAerolineaCAD)
{
        this._IAerolineaCAD = _IAerolineaCAD;
}

public IAerolineaCAD get_IAerolineaCAD ()
{
        return this._IAerolineaCAD;
}

public int New_ (string p_nombre)
{
        AerolineaEN aerolineaEN = null;
        int oid;

        //Initialized AerolineaEN
        aerolineaEN = new AerolineaEN ();
        aerolineaEN.Nombre = p_nombre;

        //Call to AerolineaCAD

        oid = _IAerolineaCAD.New_ (aerolineaEN);
        return oid;
}

public void Modify (int p_Aerolinea_OID, string p_nombre)
{
        AerolineaEN aerolineaEN = null;

        //Initialized AerolineaEN
        aerolineaEN = new AerolineaEN ();
        aerolineaEN.Id = p_Aerolinea_OID;
        aerolineaEN.Nombre = p_nombre;
        //Call to AerolineaCAD

        _IAerolineaCAD.Modify (aerolineaEN);
}

public void Destroy (int id)
{
        _IAerolineaCAD.Destroy (id);
}

public AerolineaEN ReadOID (int id)
{
        AerolineaEN aerolineaEN = null;

        aerolineaEN = _IAerolineaCAD.ReadOID (id);
        return aerolineaEN;
}

public System.Collections.Generic.IList<AerolineaEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<AerolineaEN> list = null;

        list = _IAerolineaCAD.ReadAll (first, size);
        return list;
}
public System.Collections.Generic.IList<NegoServiciosGenNHibernate.EN.NegoServicios.AerolineaEN> ReadByNombre (string p_nombre)
{
        return _IAerolineaCAD.ReadByNombre (p_nombre);
}
}
}
