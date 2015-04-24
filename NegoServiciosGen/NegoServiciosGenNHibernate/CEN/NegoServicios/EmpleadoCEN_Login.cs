
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
public bool Login (int p_id, string p_password)
{
        /*PROTECTED REGION ID(NegoServiciosGenNHibernate.CEN.NegoServicios_Usuario_login) ENABLED START*/

        // Write here your custom code...
    EmpleadoEN empleado = _IEmpleadoCAD.ReadOIDDefault(p_id);
    return empleado.Password == p_password;
        /*PROTECTED REGION END*/
}
}
}
