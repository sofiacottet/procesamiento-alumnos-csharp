# Sistema de Procesamiento Académico - C#

Programa desarrollado en C# (aplicación de consola) que procesa información de alumnos y notas utilizando estructuras de datos y técnica de corte de control.

## Funcionalidades

- Carga simulada de alumnos y notas mediante listas
- Cálculo de promedio general por alumno
- Exclusión de aplazos (notas <= 4)
- Identificación del alumno con mejor promedio
- Generación de archivo secuencial (.txt) con los resultados

## Conceptos aplicados

- Programación Orientada a Objetos
- Estructuras de datos (List<T>)
- Algoritmo de corte de control
- Búsqueda y comparación
- Manejo de archivos con StreamWriter

## Resultado

Se genera un archivo `promedios.txt` con el siguiente formato:

Legajo;Nombre;Apellido;Promedio;Notas

Además se informa el legajo con mejor promedio.
