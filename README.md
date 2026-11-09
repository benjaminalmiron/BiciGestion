
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

## Instalación y ejecución

### Requisitos

- Visual Studio 2022.
- SQL Server.
- SQL Server Management Studio (SSMS).
- Versión de .NET compatible con el proyecto.

### Configuración de la base de datos

1. Descargar o clonar este repositorio.
2. Abrir SQL Server Management Studio.
3. Conectarse a la instancia de SQL Server.
4. Abrir el archivo `Script_BiciGestion.sql`.
5. Ejecutar el script para crear la base de datos, las tablas y los tipos de bicicletas iniciales.

### Configuración de la conexión

Abrir `BiciGestion.UI/App.config` y modificar la cadena de conexión según la instancia de SQL Server instalada:

```xml
<connectionStrings>
    <add name="BiciGestion"
         connectionString="Data Source=xxxxxx;Initial Catalog=BiciGestion;Integrated Security=True;TrustServerCertificate=True"
         providerName="System.Data.SqlClient" />
</connectionStrings>
```

### Ejecutar la aplicación

1. Abrir `BiciGestion.sln` con Visual Studio 2022.
2. Configurar `BiciGestion.UI` como proyecto de inicio.
3. Compilar la solución.
4. Ejecutar con F5.

## Autor Benjamin Thomas Almiron

Proyecto desarrollado con fines académicos y de práctica de programación.
