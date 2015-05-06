
using System;

namespace NegoServiciosGenNHibernate.EN.NegoServicios
{
public partial class AerolineaEN
{
/**
 *
 */

private int id;

/**
 *
 */

private System.Collections.Generic.IList<NegoServiciosGenNHibernate.EN.NegoServicios.VueloEN> vuelo;

/**
 *
 */

private string nombre;





public virtual int Id {
        get { return id; } set { id = value;  }
}


public virtual System.Collections.Generic.IList<NegoServiciosGenNHibernate.EN.NegoServicios.VueloEN> Vuelo {
        get { return vuelo; } set { vuelo = value;  }
}


public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}





public AerolineaEN()
{
        vuelo = new System.Collections.Generic.List<NegoServiciosGenNHibernate.EN.NegoServicios.VueloEN>();
}



public AerolineaEN(int id, System.Collections.Generic.IList<NegoServiciosGenNHibernate.EN.NegoServicios.VueloEN> vuelo, string nombre)
{
        this.init (id, vuelo, nombre);
}


public AerolineaEN(AerolineaEN aerolinea)
{
        this.init (aerolinea.Id, aerolinea.Vuelo, aerolinea.Nombre);
}

private void init (int id, System.Collections.Generic.IList<NegoServiciosGenNHibernate.EN.NegoServicios.VueloEN> vuelo, string nombre)
{
        this.Id = id;


        this.Vuelo = vuelo;

        this.Nombre = nombre;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        AerolineaEN t = obj as AerolineaEN;
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
