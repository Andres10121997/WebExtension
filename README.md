# Web Extension
## Instrucciones
Agregar en el proyecto web el siguiente código:

```csharp
services.AddControllersWithViews()
        .AddRazorRuntimeCompilation()
        .AddApplicationPart(typeof(InputModelAttribute).Assembly); // para cargar vistas embebidas
```