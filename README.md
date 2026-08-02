# 📚 Sistema de Librería

Sistema de gestión integral para el control de inventario, préstamos, devoluciones y usuarios de una librería o biblioteca. Desarrollado para optimizar los procesos administrativos y brindar una interfaz amigable para el personal.

## 🚀 Características principales

- [ ] **Gestión de Libros**: Alta, baja, modificación y consulta de ejemplares (ISBN, título, autor, editorial, stock).
- [ ] **Gestión de Usuarios**: Registro de socios/empleados con roles y permisos.
- [ ] **Préstamos y Devoluciones**: Control de fechas de entrega, cálculo de multas por demora.
- [ ] **Reportes**: Generación de listados (libros más prestados, usuarios morosos, inventario actual).
- [ ] **Búsquedas avanzadas**: Filtros por categoría, autor o disponibilidad.

## 🛠️ Tecnologías utilizadas

- **Lenguaje**: C# (.NET [versión, ej: 6.0 / 8.0])
- **Framework Web/UI**: [ASP.NET Core Razor Pages / Blazor / WinForms]
- **Base de datos**: [SQL Server / MySQL / SQLite]
- **ORM**: Entity Framework Core (Code-First)
- **Patrón arquitectónico**: Capas (Acceso a Datos, Repositorio, Helpers y Models)

## 📂 Estructura del proyecto

| Carpeta | Descripción |
| :--- | :--- |
| `Pages/` | Contiene las interfaces de usuario (vistas) y su lógica asociada. |
| `Models/` | Define las entidades del negocio (clases POCO). |
| `Data/` | Contexto de base de datos (DbContext) y configuraciones de migración. |
| `AccesoDatos/` | Capa intermedia para consultas personalizadas y procedimientos almacenados. |
| `Repositorio/` | Implementación del patrón Repositorio para abstraer la lógica de persistencia. |
| `Helpers/` | Utilidades reutilizables (encriptación, validaciones, manejo de sesiones). |
| `Properties/` | Configuraciones internas del proyecto (launchSettings, recursos). |
| `SVG/` | Archivos vectoriales para íconos y diseño de la interfaz. |

## ⚙️ Requisitos previos

- [.NET SDK (versión X.X)](https://dotnet.microsoft.com/)
- [SQL Server / MySQL Workbench]
- Visual Studio 2022 (o superior) / VS Code

## 🔧 Instalación y configuración

1. **Clonar el repositorio**
   ```bash
   git clone https://github.com/Isaacjesusacevedo/SistemaDeLibreria.git
