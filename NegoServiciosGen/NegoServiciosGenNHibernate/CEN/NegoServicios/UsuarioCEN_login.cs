
using NegoServiciosGenNHibernate.CAD.NegoServicios;
using NegoServiciosGenNHibernate.EN.NegoServicios;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using System;
using System.Text;

namespace NegoServiciosGenNHibernate.CEN.NegoServicios
{
public partial class UsuarioCEN
{
    public bool Login (string p_usuario, string p_password)
    {
        /*PROTECTED REGION ID(NegoServiciosGenNHibernate.CEN.NegoServicios_Usuario_login) ENABLED START*/

        // Write here your custom code...
        UsuarioEN usuarioEN = _IUsuarioCAD.ReadByUsuario(p_usuario);
        if (usuarioEN == null)
        {
            return false;
        }
        else if (usuarioEN.Password == p_password)
        {
            return true;
        }
        return false;
        /*PROTECTED REGION END*/
    }
}
}
