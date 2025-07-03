# Web Extension
## Instrucciones
Agregar en el proyecto web el siguiente código:

```csharp
services.AddControllersWithViews()
        .AddRazorRuntimeCompilation()
        .AddApplicationPart(typeof(InputModelAttribute).Assembly); // para cargar vistas embebidas
```

## ¿Cómo se usa?
A continuación se muestra una clase (Model) de C# de ejemplo:
```csharp
public class PersonModel
{
    [
        DataType(
            dataType: DataType.Text
        ),
        InputMode(
            InputMode: InputModeAttribute.InputModeEnum.text
        ),
        Required
    ]
    public required string Name { get; set; }

    [
        DataType(
            dataType: DataType.Text
        ),
        InputMode(
            InputMode: InputModeAttribute.InputModeEnum.text
        ),
        Required
    ]
    public required string LastName { get; set; }

    [
        DataType(
            dataType: DataType.Date
        ),
        InputMode(
            InputMode: InputModeAttribute.InputModeEnum.numeric
        ),
        Required
    ]
    public byte Age { get; set; }
}
```

En el documento cshtml
```cshtml
<input asp-for="Your-ID" />
```