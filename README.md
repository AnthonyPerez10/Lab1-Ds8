# Lab1-Ds8 - Estructuras de Iteración en Visual Basic .NET

Proyecto estructurado bajo **Arquitectura por Capas Módulares** en Visual Basic .NET (Windows Forms) con subcarpetas dedicadas por cada módulo del programa.

---

## 🏛️ Organización del Proyecto por Capas y Módulos

```text
Lab1-Ds8/
│
├── 📂 Formularios/                          # Capa de Presentación (Vistas / Windows Forms)
│   ├── frmMenuPrincipal.vb / .Designer.vb
│   ├── frmAnalisisRectangulos.vb / .Designer.vb
│   ├── frmTablasMultiplicar.vb / .Designer.vb
│   ├── frmCalificacionFinal.vb / .Designer.vb
│   └── frmNumeroPositivo.vb / .Designer.vb
│
├── 📂 Logica/                               # Capa de Negocio (Dividida por Módulos)
│   ├── 📂 AnalisisRectangulos/
│   │   └── clsAnalisisRectangulosLogica.vb
│   ├── 📂 TablasMultiplicar/
│   │   └── clsTablasMultiplicarLogica.vb
│   ├── 📂 CalificacionFinal/
│   │   └── clsCalificacionFinalLogica.vb
│   └── 📂 NumeroPositivo/
│       └── clsNumeroPositivoLogica.vb
│
├── 📂 Modelos/                              # Capa de Datos / Entidades (Dividida por Módulos)
│   ├── 📂 AnalisisRectangulos/
│   │   ├── clsRectanguloModelo.vb
│   │   └── clsResumenConjuntosModelo.vb
│   └── 📂 CalificacionFinal/
│       └── clsEstudianteModelo.vb
│
├── 📄 Program.vb                            # Punto de entrada principal (.NET)
├── 📄 Lab1-Ds8.vbproj                       # Configuración de proyecto Visual Basic
├── 📄 .gitignore                            # Filtros de Git para Visual Studio / .NET
└── 📄 README.md                             # Documentación del proyecto
```

---

## 🏷️ Convención de Prefijos de Nomenclatura Empleados

- **Formularios (`frm`)**: `frmMenuPrincipal`, `frmAnalisisRectangulos`, `frmTablasMultiplicar`, `frmCalificacionFinal`, `frmNumeroPositivo`.
- **Clases (`cls`)**: `clsAnalisisRectangulosLogica`, `clsRectanguloModelo`, `clsResumenConjuntosModelo`.
- **Funciones (`fun`)**: `funValidarCantidad()`, `funValidarDimensiones()`, `funAnalizarConjunto()`.
- **Subrutinas (`sub`)**: `subReiniciarFormulario()`, `subActualizarResumenAnalisis()`.
- **Variables / Propiedades**:
  - `str` -> String (`strNombre`)
  - `int` -> Integer (`intId`, `intCantidad`)
  - `dbl` -> Double (`dblBase`, `dblAltura`, `dblArea`)
  - `lst` -> List / Colección (`lstRectangulos`)
  - `btn` -> Button (`btnAgregarRectangulo`, `btnVolver`)
  - `lbl` -> Label (`lblLiveSuperficie`, `lblProgreso`)
  - `txt` -> TextBox (`txtCantidad`, `txtBase`, `txtAltura`)
  - `dgv` -> DataGridView (`dgvRectangulos`)

---

## 🚀 Compilación y Ejecución

```bash
dotnet run
```
