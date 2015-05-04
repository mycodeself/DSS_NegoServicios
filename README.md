# NegoServicios
Proyecto de DSS de la Universidad de Alicante

Configuración que debe tener SQL Server:
- Servidor: localhost\sqlexpress
- User: nhibernateUser
- Pass: nhibernatePass
- DB: NegoServiciosGenNHibernate

En el primer arranque del proyecto en una máquina:
- Establecer Initialize DB como proyecto de inicio
- Ejecutar, creara DB y tambien la inicializara con datos
- Se pueden modificar os datos de inicializacion CreateDB.cs en el proyecto InitializeDB

Si por algúna razón no os conecta a vuestra base de datos:
- Asegurarse de que efectivamente teneis el servidor corriendo y con la configuración anterior
- Asegurarse sde que el origines de datos del proyecto esta incluido (debería estarlo por defecto)


Intentar no cambiar muchas cosas de la configuración, que debido a OOH4RIA se rompe fácil y es necesario regenerar todo de nuevo así como los archivos generados por OOH4RIA (excepto los custom con regiones protegidas).
