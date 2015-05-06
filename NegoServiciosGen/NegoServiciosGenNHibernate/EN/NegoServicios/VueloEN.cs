
using System;

namespace NegoServiciosGenNHibernate.EN.NegoServicios
{
public partial class VueloEN
{
/**
 *
 */

private int id;

/**
 *
 */

private NegoServiciosGenNHibernate.EN.NegoServicios.AerolineaEN aerolinea;

/**
 *
 */

private System.Collections.Generic.IList<NegoServiciosGenNHibernate.EN.NegoServicios.ReservaEN> reserva;

/**
 *
 */

private string origen;

/**
 *
 */

private string destino;

/**
 *
 */

private Nullable<DateTime> fecha_salida;

/**
 *
 */

private Nullable<DateTime> fecha_llegada;

/**
 *
 */

private Nullable<DateTime> hora_salida;

/**
 *
 */

private Nullable<DateTime> hora_llegada;

/**
 *
 */

private int plazas;

/**
 *
 */

private int precio_plaza;





public virtual int Id {
        get { return id; } set { id = value;  }
}


public virtual NegoServiciosGenNHibernate.EN.NegoServicios.AerolineaEN Aerolinea {
        get { return aerolinea; } set { aerolinea = value;  }
}


public virtual System.Collections.Generic.IList<NegoServiciosGenNHibernate.EN.NegoServicios.ReservaEN> Reserva {
        get { return reserva; } set { reserva = value;  }
}


public virtual string Origen {
        get { return origen; } set { origen = value;  }
}


public virtual string Destino {
        get { return destino; } set { destino = value;  }
}


public virtual Nullable<DateTime> Fecha_salida {
        get { return fecha_salida; } set { fecha_salida = value;  }
}


public virtual Nullable<DateTime> Fecha_llegada {
        get { return fecha_llegada; } set { fecha_llegada = value;  }
}


public virtual Nullable<DateTime> Hora_salida {
        get { return hora_salida; } set { hora_salida = value;  }
}


public virtual Nullable<DateTime> Hora_llegada {
        get { return hora_llegada; } set { hora_llegada = value;  }
}


public virtual int Plazas {
        get { return plazas; } set { plazas = value;  }
}


public virtual int Precio_plaza {
        get { return precio_plaza; } set { precio_plaza = value;  }
}





public VueloEN()
{
        reserva = new System.Collections.Generic.List<NegoServiciosGenNHibernate.EN.NegoServicios.ReservaEN>();
}



public VueloEN(int id, NegoServiciosGenNHibernate.EN.NegoServicios.AerolineaEN aerolinea, System.Collections.Generic.IList<NegoServiciosGenNHibernate.EN.NegoServicios.ReservaEN> reserva, string origen, string destino, Nullable<DateTime> fecha_salida, Nullable<DateTime> fecha_llegada, Nullable<DateTime> hora_salida, Nullable<DateTime> hora_llegada, int plazas, int precio_plaza)
{
        this.init (id, aerolinea, reserva, origen, destino, fecha_salida, fecha_llegada, hora_salida, hora_llegada, plazas, precio_plaza);
}


public VueloEN(VueloEN vuelo)
{
        this.init (vuelo.Id, vuelo.Aerolinea, vuelo.Reserva, vuelo.Origen, vuelo.Destino, vuelo.Fecha_salida, vuelo.Fecha_llegada, vuelo.Hora_salida, vuelo.Hora_llegada, vuelo.Plazas, vuelo.Precio_plaza);
}

private void init (int id, NegoServiciosGenNHibernate.EN.NegoServicios.AerolineaEN aerolinea, System.Collections.Generic.IList<NegoServiciosGenNHibernate.EN.NegoServicios.ReservaEN> reserva, string origen, string destino, Nullable<DateTime> fecha_salida, Nullable<DateTime> fecha_llegada, Nullable<DateTime> hora_salida, Nullable<DateTime> hora_llegada, int plazas, int precio_plaza)
{
        this.Id = id;


        this.Aerolinea = aerolinea;

        this.Reserva = reserva;

        this.Origen = origen;

        this.Destino = destino;

        this.Fecha_salida = fecha_salida;

        this.Fecha_llegada = fecha_llegada;

        this.Hora_salida = hora_salida;

        this.Hora_llegada = hora_llegada;

        this.Plazas = plazas;

        this.Precio_plaza = precio_plaza;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        VueloEN t = obj as VueloEN;
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
