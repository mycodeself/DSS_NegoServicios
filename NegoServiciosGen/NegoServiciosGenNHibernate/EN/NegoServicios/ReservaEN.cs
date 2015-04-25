
using System;

namespace NegoServiciosGenNHibernate.EN.NegoServicios
{
public partial class ReservaEN
{
/**
 *
 */

private int id;

/**
 *
 */

private NegoServiciosGenNHibernate.EN.NegoServicios.ClienteEN cliente;

/**
 *
 */

private NegoServiciosGenNHibernate.EN.NegoServicios.VueloEN vuelo;

/**
 *
 */

private int plazas;

/**
 *
 */

private NegoServiciosGenNHibernate.Enumerated.NegoServicios.EstadoReservaEnum estado;





public virtual int Id {
        get { return id; } set { id = value;  }
}


public virtual NegoServiciosGenNHibernate.EN.NegoServicios.ClienteEN Cliente {
        get { return cliente; } set { cliente = value;  }
}


public virtual NegoServiciosGenNHibernate.EN.NegoServicios.VueloEN Vuelo {
        get { return vuelo; } set { vuelo = value;  }
}


public virtual int Plazas {
        get { return plazas; } set { plazas = value;  }
}


public virtual NegoServiciosGenNHibernate.Enumerated.NegoServicios.EstadoReservaEnum Estado {
        get { return estado; } set { estado = value;  }
}





public ReservaEN()
{
}



public ReservaEN(int id, NegoServiciosGenNHibernate.EN.NegoServicios.ClienteEN cliente, NegoServiciosGenNHibernate.EN.NegoServicios.VueloEN vuelo, int plazas, NegoServiciosGenNHibernate.Enumerated.NegoServicios.EstadoReservaEnum estado)
{
        this.init (id, cliente, vuelo, plazas, estado);
}


public ReservaEN(ReservaEN reserva)
{
        this.init (reserva.Id, reserva.Cliente, reserva.Vuelo, reserva.Plazas, reserva.Estado);
}

private void init (int id, NegoServiciosGenNHibernate.EN.NegoServicios.ClienteEN cliente, NegoServiciosGenNHibernate.EN.NegoServicios.VueloEN vuelo, int plazas, NegoServiciosGenNHibernate.Enumerated.NegoServicios.EstadoReservaEnum estado)
{
        this.Id = id;


        this.Cliente = cliente;

        this.Vuelo = vuelo;

        this.Plazas = plazas;

        this.Estado = estado;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ReservaEN t = obj as ReservaEN;
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
