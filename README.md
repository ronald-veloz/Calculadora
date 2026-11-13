 Calculadora de Escritorio – Windows Forms

Aplicación de escritorio que simula una calculadora convencional, desarrollada con C# y Windows Forms como parte de la asignatura **Diseño y Programación de Software** (actividad PPE09).

## Descripción general

La aplicación permite ingresar números mediante botones, seleccionar una operación aritmética y visualizar el resultado en una pantalla de solo lectura. Está pensada para ser intuitiva y estable ante entradas inválidas.

## Objetivos

- Aplicar programación orientada a eventos en una aplicación de escritorio.
- Diseñar una interfaz gráfica clara y consistente con controles de Windows Forms.
- Implementar las cuatro operaciones aritméticas básicas.
- Validar entradas y controlar situaciones excepcionales, como la división para cero.
- Organizar y documentar un proyecto de software en GitHub.

## Características principales

- Botones numéricos del 0 al 9.
- Operaciones: suma (+), resta (-), multiplicación (×) y división (÷).
- Botón igual (=) para ejecutar la operación.
- Botón limpiar (C) para reiniciar la calculadora.
- Pantalla `TextBox` en modo solo lectura (`ReadOnly = true`).
- Control de la división para cero con mensaje de error.
- Validación de entradas con `double.TryParse()`.
- Operaciones consecutivas sin necesidad de cerrar la aplicación.

## Tecnologías utilizadas

- Lenguaje: C#
- Plataforma: .NET (`net10.0-windows`)
- Interfaz: Windows Forms
- IDE: Visual Studio
- Control de versiones: Git y GitHub

## Requisitos de instalación

- Windows 10 u 11.
- Visual Studio 2022 o superior con la carga de trabajo **Desarrollo de escritorio de .NET**.
- SDK de .NET 10.
- Git.

## Instrucciones de ejecución

1. Clonar el repositorio:
   ```
   git clone https://github.com/TU_USUARIO/PPE03_Veloz_Ronald_Calculadora.git
   ```
2. Abrir el archivo `Calculadora/Calculadora.slnx` con Visual Studio.
3. Restaurar los paquetes si Visual Studio lo solicita.
4. Presionar **F5** (o el botón **Iniciar**) para compilar y ejecutar.

También se puede ejecutar desde la terminal:
```
cd Calculadora
dotnet run
```

## Estructura del proyecto

```
PPE03_Veloz_Ronald_Calculadora/
├── Calculadora/
│   ├── Calculadora.csproj   # Configuración del proyecto
│   ├── Calculadora.slnx     # Solución de Visual Studio
│   ├── Form1.cs             # Lógica de la calculadora y eventos
│   ├── Form1.Designer.cs    # Código generado del diseño visual
│   ├── Form1.resx           # Recursos del formulario
│   └── Program.cs           # Punto de entrada de la aplicación
├── README.md
└── .gitignore
```

## Capturas de pantalla

### Interfaz principal
![Interfaz principal](capturas/interfaz.png)

### Operación realizada
![Suma](capturas/suma.png)

### Mensaje de error por división para cero
![División para cero](capturas/division-cero.png)

## Pruebas realizadas

| Prueba | Operación | Resultado esperado | Resultado |
| --- | --- | --- | --- |
| 1 | 10 + 5 | 15 | Correcto |
| 2 | 20 - 8 | 12 | Correcto |
| 3 | 7 × 6 | 42 | Correcto |
| 4 | 100 ÷ 4 | 25 | Correcto |
| 5 | 10 ÷ 0 | Mensaje de error | Correcto |
| 6 | Limpiar después de una operación | Pantalla vacía | Correcto |
| 7 | 15 + 25 | 40 | Correcto |
| 8 | 3 × 3 y luego 8 + 2 | 9 y 10 | Correcto |

## Autor
**Ronald Veloz**
Asignatura: Diseño y Programación de Software
