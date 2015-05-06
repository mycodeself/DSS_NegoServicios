

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
public partial class ReservaCEN
{
private IReservaCAD _IReservaCAD;

public ReservaCEN()
{
        this._IReservaCAD = new ReservaCAD ();
}

public ReservaCEN(IReservaCAD _IReservaCAD)
{
        this._IReservaCAD = _IReservaCAD;
}

public IReservaCAD get_IReservaCAD ()
{
        return this._IReservaCAD;
}

public int New_ (int p_cliente, int p_vuelo, int p_plazas, NegoServiciosGenNHibernate.Enumerated.NegoServicios.EstadoReservaEnum p_estado)
{
        ReservaEN reservaEN = null;
        int oid;

        //Initialized ReservaEN
        reservaEN = new ReservaEN ();

        if (p_cliente != -1) {
                reservaEN.Cliente = new NegoServiciosGenNHibernate.EN.NegoServicios.ClienteEN ();
                reservaEN.Cliente.Id = p_cliente;
        }


        if (p_vuelo != -1) {
                reservaEN.Vuelo = new NegoServiciosGenNHibernate.EN.NegoServicios.VueloEN ();
                reservaEN.Vuelo.Id = p_vuelo;
        }

        reservaEN.Plazas = p_plazas;

        reservaEN.Estado = p_estado;

        //Call to ReservaCAD

        oid = _IReservaCAD.New_ (reservaEN);
        return oid;
}

public void Modify (int p_Reserva_OID, int p_plazas, NegoServiciosGenNHibernate.Enumerated.NegoServicios.EstadoReservaEnum p_estado)
{
        ReservaEN reservaEN = null;

        //Initialized ReservaEN
        reservaEN = new ReservaEN ();
        reservaEN.Id = p_Reserva_OID;
        reservaEN.Plazas = p_plazas;
        reservaEN.Estado = p_estado;
        //Call to ReservaCAD

        _IReservaCAD.Modify (reservaEN);
}

public void Destroy (int id)
{
        _IReservaCAD.Destroy (id);
}

public ReservaEN ReadOID (int id)
{
        ReservaEN reservaEN = null;

        reservaEN = _IReservaCAD.ReadOID (id);
        return reservaEN;
}

public System.Collections.Generic.IList<ReservaEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ReservaEN> list = null;

        list = _IReservaCAD.ReadAll (first, size);
        return list;
}
public System.Collections.Generic.IList<NegoServiciosGenNHibernate.EN.NegoServicios.ReservaEN> ReadByCliente (NegoServiciosGenNHibernate.EN.NegoServicios.ClienteEN p_usuario)
{
        return _IReservaCAD.ReadByCliente (p_usuario);
}
public System.Collections.Generic.IList<NegoServiciosGenNHibernate.EN.NegoServicios.ReservaEN> ReadByEstado (NegoServiciosGenNHibernate.Enumerated.NegoServicios.EstadoReservaEnum p_estado)
{
        return _IReservaCAD.ReadByEstado (p_estado);
}
public System.Collections.Generic.IList<NegoServiciosGenNHibernate.EN.NegoServicios.ReservaEN> ReadByVuelo (NegoServiciosGenNHibernate.EN.NegoServicios.VueloEN p_vuelo)
{
        return _IReservaCAD.ReadByVuelo (p_vuelo);
}
}
}
