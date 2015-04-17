using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using NegoServiciosGenNHibernate.Exceptions;
using System.Windows.Forms;

namespace NegoServiciosGenNHibernate.CAD.NegoServicios
{
public class BasicCAD
{
protected ISession session;

protected bool sessionInside;

protected ITransaction tx;

protected BasicCAD()
{
        sessionInside = true;
}

protected BasicCAD(ISession sessionAux)
{
        session = sessionAux;
        sessionInside = false;
}

protected void SessionInitializeTransaction ()
{
        if (session == null) {
                session = NHibernateHelper.OpenSession ();
                MessageBox.Show("correcto");
                tx = session.BeginTransaction ();
                
        }
}

protected void SessionCommit ()
{
        if (sessionInside && session != null)
                tx.Commit ();
}

protected void SessionRollBack ()
{
        if (sessionInside && session != null && session.IsOpen)
                tx.Rollback ();
}

protected void SessionClose ()
{
        if (sessionInside && session != null && session.IsOpen) {
                session.Close ();
                session.Dispose ();
                session = null;
        }
}
}
}
