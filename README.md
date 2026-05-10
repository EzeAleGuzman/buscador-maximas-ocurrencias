# Buscador de Máximas Ocurrencias

Trabajo Práctico Final de la materia **Algoritmos y Estructuras de Datos**.

---

## 📌 Descripción

Este proyecto implementa un sistema capaz de analizar datasets almacenados en archivos `.csv` para determinar cuáles son los elementos con mayor cantidad de ocurrencias.

El sistema permite comparar dos enfoques distintos:

- Uso de una **Heap** como estructura principal.
- Uso de un método de **ordenamiento** tradicional.

Además, incluye consultas adicionales relacionadas con la estructura de la Heap y el análisis de rendimiento.

---

## ⚙️ Funcionalidades

- Carga de archivos CSV.
- Búsqueda de elementos más frecuentes.
- Comparación de rendimiento entre algoritmos.
- Visualización de información de la Heap.
- Interfaz gráfica realizada con Windows Forms.

---

## 🧠 Métodos implementados

### `BuscarConHeap()`

Obtiene los elementos con mayor cantidad de ocurrencias utilizando una Heap.

### `BuscarConOrden()`

Obtiene los elementos con mayor cantidad de ocurrencias utilizando un algoritmo de ordenamiento.

### `Consulta1()`

Compara los tiempos de ejecución entre ambos métodos.

### `Consulta2()`

Muestra el camino hacia la hoja más izquierda de la Heap.

### `Consulta3()`

Muestra los niveles de los nodos dentro de la Heap.

---

## 🛠️ Tecnologías utilizadas

- `C#`
- `.NET 6`
- `Windows Forms`
- Archivos `.csv`

---

## 📂 Estructura del proyecto

```bash
tpfinal/
├── Backend.cs
├── Dato.cs
├── Form1.resx
├── Form3.cs
├── Inicio.Designer.c
├── ListItem.resx
├── Resources/
├── Utils.cs
├── bin/
├── Estrategia.cs
├── Form2.cs
├── Form3.Designer.cs
├── Inicio.resx
├── obj/
├── tpfinal.csproj
├── Cola.cs
├── Form1.cs
├── Form2.Designer.cs
├── Form3.resx
├── ListItem.cs
├── Program.cs
├── tpfinal.csproj.user
├── datasets/
├── Form1.Designer.cs
├── Form2.resx
├── Inicio.cs
├── ListItem.Designer.cs
├── Properties/
└── tpfinal.sln
```

---

## 📄 Descripción de archivos principales

| Archivo | Descripción |
|---|---|
| `Heap.cs` | Implementación de la estructura Heap |
| `Cola.cs` | Manejo de cola utilizada por el sistema |
| `Dato.cs` | Modelo para almacenar datos y ocurrencias |
| `Estrategia.cs` | Implementación de algoritmos principales |
| `Backend.cs` | Lógica general del sistema |
| `Form1.cs` | Pantalla principal |
| `Form2.cs` | Pantallas auxiliares |
| `Form3.cs` | Consultas y resultados |

---

## 🚀 Ejecución

### Requisitos

- .NET SDK
- Visual Studio

### Compilar y ejecutar

```bash
dotnet build
dotnet run
```

O abrir directamente la solución:

```bash
tpfinal.sln
```

---

## 📚 Conceptos aplicados

- Estructuras de datos
- Heaps
- Algoritmos de ordenamiento
- Complejidad temporal
- Manejo de archivos
- Programación orientada a objetos

---

## 👨‍💻 Integrantes

- Apellido, Nombre
- Apellido, Nombre
- Corach, Walter

---

## 📄 Licencia

Proyecto realizado únicamente con fines académicos.
