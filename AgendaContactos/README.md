# 📒 Agenda de Contactos — ASP.NET Core 9 + SQL Server

Aplicación web CRUD completa para gestionar una agenda de contactos, desarrollada con **ASP.NET Core 9 MVC** y **Entity Framework Core** con SQL Server.

---

## 🚀 Tecnologías Utilizadas

| Tecnología | Versión |
|---|---|
| .NET | 9.0 |
| ASP.NET Core MVC | 9.0 |
| Entity Framework Core | 9.0 |
| SQL Server (LocalDB) | - |
| Bootstrap | 5.3 |

---

## 📁 Estructura del Proyecto

```
AgendaContactos/
│
├── Models/
│   └── Contacto.cs
├── Data/
│   └── ApplicationDbContext.cs
├── Controllers/
│   └── InicioController.cs
├── Views/
│   ├── Inicio/
│   │   ├── Index.cshtml
│   │   ├── Crear.cshtml
│   │   ├── Editar.cshtml
│   │   └── Borrar.cshtml
│   └── Shared/
│       ├── _Layout.cshtml
│       └── _ValidationScriptsPartial.cshtml
├── appsettings.json
└── Program.cs
```

---

## ⚙️ Instalación

### 1. Clonar el repositorio
```bash
git clone https://github.com/TU_USUARIO/AgendaContactos.git
cd AgendaContactos
```

### 2. Restaurar paquetes NuGet
```bash
dotnet restore
```

### 3. Crear la base de datos
En la **Consola del Administrador de Paquetes** de Visual Studio:
```
Add-Migration Inicial
Update-Database
```

### 4. Ejecutar
```bash
dotnet run
```

---

## ✅ Funcionalidades

- ✅ Listar todos los contactos
- ✅ Crear nuevo contacto con validaciones
- ✅ Editar contacto existente
- ✅ Eliminar con pantalla de confirmación

---

## 👨‍💻 Autor
Proyecto del curso ASP.NET Core MVC con .NET 9.
