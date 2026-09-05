# Lab1-Ds8 - Estructuras de Iteración en Visual Basic .NET

Proyecto estructurado bajo **Arquitectura por Capas (N-Tier Architecture)** en Visual Basic .NET (Windows Forms) con uso estricto de prefijos de nomenclatura.

---

## 🏛️ Organización del Proyecto por Capas (Carpetas)

```
Lab1-Ds8/
│
├── 📂 Formularios/               # Capa de Presentación (Vistas / Windows Forms)
│   ├── frmMenuPrincipal.vb / .Designer.vb
│   ├── frmAnalisisRectangulos.vb / .Designer.vb
│   ├── frmTablasMultiplicar.vb / .Designer.vb
│   ├── frmCalificacionFinal.vb / .Designer.vb
│   └── frmNumeroPositivo.vb / .Designer.vb
│
├── 📂 Logica/                    # Capa de Negocio / Controladores (Reglas de cálculo y validaciones)
│   ├── clsAnalisisRectangulosLogica.vb
│   ├── clsTablasMultiplicarLogica.vb
│   ├── clsCalificacionFinalLogica.vb
│   └── clsNumeroPositivoLogica.vb
│
├── 📂 Modelos/                   # Capa de Datos / Entidades (Estructuras de datos)
│   ├── clsRectanguloModelo.vb
│   └── clsEstudianteModelo.vb
│
├── 📄 Program.vb                 # Punto de entrada principal de la aplicación
├── 📄 Lab1-Ds8.vbproj            # Configuración del proyecto .NET / VB
├── 📄 .gitignore                 # Configuración de exclusión para Git
└── 📄 README.md                  # Documentación oficial del laboratorio
```

---

## 🏷️ Convención de Prefijos de Nomenclatura Empleados

- **Formularios (`frm`)**: `frmMenuPrincipal`, `frmAnalisisRectangulos`, `frmTablasMultiplicar`, `frmCalificacionFinal`, `frmNumeroPositivo`.
- **Clases (`cls`)**: `clsAnalisisRectangulosLogica`, `clsTablasMultiplicarLogica`, `clsRectanguloModelo`, `clsEstudianteModelo`.
- **Funciones (`fun`)**: `funCalcularArea()`, `funGenerarTabla()`, `funCalcularPromedio()`, `funEsNumeroPositivo()`.
- **Subrutinas / Métodos (`sub`)**: `subLimpiarFormulario()`, `subCargarDatos()`.
- **Variables / Propiedades**:
  - `str` -> String (`strNombre`)
  - `int` -> Integer (`intNumero`, `intLimite`)
  - `dbl` -> Double (`dblBase`, `dblAltura`, `dblPromedio`)
  - `lst` -> List / Collection (`lstNotas`, `lstResultados`)
  - `btn` -> Button (`btnVolver`, `btnSalir`)
  - `lbl` -> Label (`lblMenuAccedido`, `lblTituloHeader`)
  - `grp` -> GroupBox (`grpOpcionesMenu`)

---

## 🚀 Compilación y Ejecución

Para compilar y ejecutar el proyecto desde la terminal:

```bash
dotnet run
```
