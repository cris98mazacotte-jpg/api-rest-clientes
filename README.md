# API REST Clientes

## Alumno

Cristian Adrian Mazacotte Von Streber

## Descripción del proyecto

API REST desarrollada con ASP.NET Core Web API, Entity Framework Core y SQL Server para administrar clientes de una empresa.

La aplicación permite:

- Registrar clientes
- Consultar clientes
- Consultar cliente por ID
- Modificar clientes
- Eliminar clientes

La información se almacena de forma persistente en SQL Server.

---

## Tecnologías utilizadas

- ASP.NET Core Web API
- C#
- Entity Framework Core
- SQL Server Express
- Swagger
- Repository Pattern
- Service Layer
- Dependency Injection

---

## Base de Datos

**Base de datos:**

```text
EmpresaDB
```

**Tabla:**

```text
Clientes
```

**Campos:**

- Id
- Nombre
- Apellido
- Email
- Telefono

---

## Arquitectura

```text
Controller
   ↓
Service
   ↓
Repository
   ↓
Entity Framework Core
   ↓
SQL Server
```

---

## Endpoints

### Obtener todos los clientes

```http
GET /api/Clientes
```

### Obtener cliente por ID

```http
GET /api/Clientes/{id}
```

### Registrar cliente

```http
POST /api/Clientes
```

### Actualizar cliente

```http
PUT /api/Clientes/{id}
```

### Eliminar cliente

```http
DELETE /api/Clientes/{id}
```

---

## Instrucciones para ejecutar el proyecto

1. Instalar SQL Server Express.
2. Ejecutar el archivo `script.sql`.
3. Verificar la cadena de conexión en `appsettings.json`.
4. Restaurar los paquetes NuGet.
5. Ejecutar el proyecto.
6. Abrir Swagger desde el navegador.

---

## Evidencias

Las evidencias de las pruebas realizadas se encuentran dentro de la carpeta:

```text
Evidencias
```

Incluyen:

- POST
- GET
- GET por ID
- PUT
- DELETE
- SQL Server
- Swagger