# ClinifyBackend API Web

Esta es la **API web de Clinify**, diseñada siguiendo **Clean Architecture** y principios de **SOLID**, implementada con **ASP.NET Core**. La API permite manejar información de **Clientes, Doctores y Citas**.

---

## 🔹 Estructura del proyecto

El proyecto está dividido en **cuatro capas**, según Clean Architecture:

1. **Domain**  
   - Contiene las **entidades del dominio**: `Cliente`, `Doctor` y `Cita`.  
   - Solo contiene propiedades, sin lógica de negocio ni dependencias externas.  

2. **Application**  
   - Contiene **servicios**, **interfaces** y **DTOs**.  
   - Se encarga de la lógica de negocio y de mapear las entidades a objetos que el frontend consume.  
   - Incluye **mappers** para transformar entidades a DTOs.  
   - Incluye un **Facade** para combinar información de múltiples servicios (ej. citas completas con cliente y doctor).  

3. **Infrastructure**  
   - Contiene los **repositorios** que devuelven datos.  
   - Actualmente se usan datos estáticos para simular una base de datos.  
   - Incluye un **Adapter** de ejemplo para consumir datos de un proveedor externo.  

4. **API**  
   - Contiene los **controladores** que reciben las peticiones HTTP.  
   - Cada controlador se conecta a los servicios de Application mediante **inyección de dependencias**.  
   - Endpoints disponibles:  
     - `/Clientes` → Lista de clientes  
     - `/Doctores` → Lista de doctores  
     - `/Citas` → Lista de citas  
     - `/CitasCompletas` → Lista de citas con información completa de cliente y doctor  

---

## 🔹 Principios SOLID aplicados

| Principio | Evidencia en el proyecto |
|-----------|------------------------|
| **SRP** (Single Responsibility) | Cada clase tiene una única responsabilidad: entidades solo propiedades, servicios solo reglas de negocio, repositorios solo datos, controladores solo HTTP |
| **OCP** (Open/Closed) | Los servicios usan interfaces de repositorio, permitiendo cambiar la fuente de datos sin modificar la lógica |
| **LSP** (Liskov) | Cualquier implementación de `IClienteRepository`, `ICitaRepository` o `IDoctorRepository` puede sustituir otra sin romper el servicio |
| **ISP** (Interface Segregation) | Cada repositorio tiene su propia interfaz específica, evitando interfaces gigantes |
| **DIP** (Dependency Inversion) | Los servicios dependen de interfaces, no de implementaciones concretas, usando inyección de dependencias |

---

## 🔹 Patrones de diseño aplicados

1. **Adapter**  
   - `ExternalClienteAdapter` implementa `IClienteRepository` para simular la integración de datos de un proveedor externo.  
   - Permite cambiar la fuente de datos sin modificar la lógica de negocio.  

2. **Facade**  
   - `CitaFacadeService` combina información de `CitaService`, `ClienteService` y `DoctorService`.  
   - Permite obtener en un solo endpoint `/CitasCompletas` la información completa de cada cita.  
   - Simplifica el consumo de la API desde el frontend.  

---

## 🔹 Tecnologías usadas

- ASP.NET Core 7/8  
- C# 11  
- Swagger para documentación y prueba de endpoints  
- Clean Architecture  
- DTOs y Mappers para separar dominio de presentación  
- Inyección de dependencias  
- Datos estáticos (simulación de base de datos)  

---

## 🔹 Cómo ejecutar la API

1. Abrir el proyecto en **Visual Studio** o **VS Code**.  
2. Ejecutar el proyecto (F5 o `dotnet run`).  
3. Acceder a Swagger:  
https://localhost:7049/swagger
4. Probar los endpoints:  
- `/Clientes`  
- `/Doctores`  
- `/Citas`  
- `/CitasCompletas`  

> Nota: Los datos son estáticos por ahora. Se puede extender para usar **SQL Server** o cualquier otra fuente mediante los repositorios e interfaces.

---

## 🔹 Estructura de carpetas
ClinifyBackend
│
├─ ClinifyBackend.API # Controladores y punto de entrada
├─ ClinifyBackend.Application # Servicios, Interfaces, DTOs, Mappers
├─ ClinifyBackend.Domain # Entidades de negocio
├─ ClinifyBackend.Infrastructure # Repositorios y Adapters

---

## 🔹 Contacto / Información adicional

- API diseñada para práctica de Clean Architecture, SOLID y patrones de diseño.  
- Extensible para bases de datos reales, validaciones, autenticación y más.
