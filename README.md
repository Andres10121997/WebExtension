# Web Extension
## Instrucciones
Agregar en el proyecto web el siguiente código:

```csharp
services.AddControllersWithViews()
        .AddRazorRuntimeCompilation()
        .AddApplicationPart(typeof(InputModelAttribute).Assembly); // para cargar vistas embebidas
```

## ¿Cómo se usa?
A continuación se muestra un ejemplo de implementación:

### Modelo
```csharp
public class PersonModel
{
    [
        InputMode(
            InputMode: InputModeAttribute.InputModeEnum.text
        )
    ]
    public string Name { get; set; }

    [
        InputMode(
            InputMode: InputModeAttribute.InputModeEnum.text
        )
    ]
    public string LastName { get; set; }

    [
        InputMode(
            InputMode: InputModeAttribute.InputModeEnum.numeric
        )
    ]
    public byte Age { get; set; }
}
```

### cshtml
```cshtml
@model PersonModel

<input asp-for="Name" />
<input asp-for="LastName" />
<input asp-for="Age" />
```

### html
¿Cómo debiese quedar el ``html``?
```html
<input inputmode="text" />
<input inputmode="text" />
<input inputmode="numeric" />
```