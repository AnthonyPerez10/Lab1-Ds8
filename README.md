# Lab1-Ds8 - Primer Hola Mundo en Visual Basic .NET (GUI)

Este repositorio contiene la configuración inicial para una aplicación de **Visual Basic .NET** con **Interfaz Gráfica (Windows Forms)** e integración con estructuras de iteración.

---

## 📁 Estructura del Proyecto

- `Form1.vb`: Código fuente del formulario principal con la lógica de saludo y bucles.
- `Form1.Designer.vb`: Definición visual de los componentes de la interfaz (botones, cajas de texto, etiquetas, listbox).
- `Program.vb`: Punto de entrada principal de la aplicación.
- `Lab1-Ds8.vbproj`: Archivo de proyecto de .NET / Visual Basic.
- `.gitignore`: Configuración de Git para ignorar archivos temporales y binarios generados (`bin/`, `obj/`, `.vs/`, etc.).

---

## 🚀 Cómo Ejecutar la Aplicación

### Opción 1: Desde la Consola (Terminal / PowerShell)

Ejecuta el siguiente comando en la raíz de esta carpeta:

```bash
dotnet run
```

### Opción 2: Desde Visual Studio

1. Abre **Visual Studio 2022** (o superior).
2. Selecciona **Abrir un proyecto o una solución** (`File > Open > Project/Solution`).
3. Selecciona el archivo `Lab1-Ds8.vbproj`.
4. Presiona `F5` o el botón **Iniciar** para compilar y ejecutar la interfaz gráfica.

---

## 🛠️ Contenido de la Aplicación

1. **Hola Mundo Interactivo**: Permite ingresar un nombre y muestra un mensaje personalizado tanto en pantalla como en un cuadro de diálogo (`MessageBox`).
2. **Estructuras de Iteración**: Demostración práctica de bucles `For...Next` y `Do While` mostrando los resultados ordenados en un `ListBox`.
