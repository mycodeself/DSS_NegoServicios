

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
public partial class VueloCEN
{
private IVueloCAD _IVueloCAD;

public VueloCEN()
{
        this._IVueloCAD = new VueloCAD ();
}

public VueloCEN(IVueloCAD _IVueloCAD)
{
        this._IVueloCAD = _IVueloCAD;
}

public IVueloCAD get_IVueloCAD ()
{
        return this._IVueloCAD;
}

public int New_ (int p_aerolinea, string p_origen, string p_destino, Nullable<DateTime> p_fecha_salida, Nullable<DateTime> p_fecha_llegada, Nullable<DateTime> p_hora_salida, Nullable<DateTime> p_hora_llegada, int p_plazas, int p_precio_plaza)
{
        VueloEN vueloEN = null;
        int oid;

        //Initialized VueloEN
        vueloEN = new VueloEN ();

        if (p_aerolinea != -1) {
                vueloEN.Aerolinea = new NegoServiciosGenNHibernate.EN.NegoServicios.AerolineaEN ();
                vueloEN.Aerolinea.Id = p_aerolinea;
        }

        vueloEN.Origen = p_origen;

        vueloEN.Destino = p_destino;

        vueloEN.Fecha_salida = p_fecha_salida;

        vueloEN.Fecha_llegada = p_fecha_llegada;

        vueloEN.Hora_salida = p_hora_salida;

        vueloEN.Hora_llegada = p_hora_llegada;

        vueloEN.Plazas = p_plazas;

        vueloEN.Precio_plaza = p_precio_plaza;

        //Call to VueloCAD

        oid = _IVueloCAD.New_ (vueloEN);
        return oid;
}

public void Modify (int p_Vuelo_OID, string p_origen, string p_destino, Nullable<DateTime> p_fecha_salida, Nullable<DateTime> p_fecha_llegada, Nullable<DateTime> p_hora_salida, Nullable<DateTime> p_hora_llegada, int p_plazas, int p_precio_plaza)
{
        VueloEN vueloEN = null;

        //Initialized VueloEN
        vueloEN = new VueloEN ();
        vueloEN.Id = p_Vuelo_OID;
        vueloEN.Origen = p_origen;
        vueloEN.Destino = p_destino;
        vueloEN.Fecha_salida = p_fecha_salida;
        vueloEN.Fecha_llegada = p_fecha_llegada;
        vueloEN.Hora_salida = p_hora_salida;
        vueloEN.Hora_llegada = p_hora_llegada;
        vueloEN.Plazas = p_plazas;
        vueloEN.Precio_plaza = p_precio_plaza;
        //Call to VueloCAD

        _IVueloCAD.Modify (vueloEN);
}

public void Destroy (int id)
{
        _IVueloCAD.Destroy (id);
}

public VueloEN ReadOID (int id)
{
        VueloEN vueloEN = null;

        vueloEN = _IVueloCAD.ReadOID (id);
        return vueloEN;
}

public System.Collections.Generic.IList<VueloEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<VueloEN> list = null;

        list = _IVueloCAD.ReadAll (first, size);
        return list;
}
public System.Collections.Generic.IList<NegoServiciosGenNHibernate.EN.NegoServicios.VueloEN> ReadByAerolinea (NegoServiciosGenNHibernate.EN.NegoServicios.AerolineaEN p_aerolinea)
{
        return _IVueloCAD.ReadByAerolinea (p_aerolinea);
}
}
}
