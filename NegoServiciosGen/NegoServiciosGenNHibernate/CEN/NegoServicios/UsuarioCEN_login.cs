
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
public bool Login (string p_user, string p_password)
{
        /*PROTECTED REGION ID(NegoServiciosGenNHibernate.CEN.NegoServicios_Usuario_login) ENABLED START*/

        // Write here your custom code...
        UsuarioEN usuarioEN = _IUsuarioCAD.ReadByUsuario (p_user);

        if (usuarioEN == null) {
                return false;
        }
        else if (usuarioEN.Password == p_password) {
                return true;
        }
        return false;
        /*PROTECTED REGION END*/
}
}
}
