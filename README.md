
# BiciGestion

Sistema de gestión de alquileres de bicicletas desarrollado en **C# y SQL Server**, aplicando una arquitectura por capas.

## Características

- Listado de alquileres registrados.
- Alta de alquileres mediante una lista de borrador.
- Confirmación de múltiples alquileres mediante transacciones.
- Modificación y eliminación de alquileres.
- Validaciones de datos y reglas de negocio.
- Consulta de información relacionada entre alquileres y tipos de bicicletas.

## Tecnologías utilizadas

- C#
- .NET Windows Forms
- SQL Server
- ADO.NET

## Arquitectura

El proyecto está organizado en las siguientes capas:

- **Entidades:** clases que representan los objetos del sistema.
- **Mapper:** transformación de los datos obtenidos desde la base de datos en entidades.
- **DAL:** acceso y operaciones sobre la base de datos.
- **BLL:** lógica de negocio y validaciones.
- **UI:** interfaz gráfica de usuario.

## Base de datos

El sistema utiliza SQL Server y trabaja con las tablas `ALQUILER` y `TIPO_BICICLETA`.

Para ejecutarlo, es necesario configurar la cadena de conexión en `App.config` y crear la base de datos correspondiente.

## Autor Benjamin Thomas Almiron

Proyecto desarrollado con fines académicos y de práctica de programación.
