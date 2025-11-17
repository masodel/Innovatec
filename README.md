# Innovatec — Árbol y Grafo en C# (Windows Forms)

## Descripción
Este proyecto es una aplicación de escritorio en **C# con Windows Forms** que permite:

- Administrar la **jerarquía organizativa** del Parque Tecnológico Innovatec mediante un árbol (TreeView).
- Modelar las **rutas internas entre edificios** mediante un grafo ponderado, con cálculo de rutas óptimas usando **BFS** y **Dijkstra**.

La interfaz es intuitiva y permite agregar, eliminar, buscar y recorrer nodos y conexiones de forma visual.

---

## Funcionalidades

### Árbol (TreeView)
- Agregar y eliminar ramas.
- Buscar nodos por nombre y resaltarlos.
- Recorridos: preorden, postorden y por niveles.
- Contar ramas en la jerarquía.

### Grafo
- Agregar y eliminar nodos (edificios).
- Agregar y eliminar conexiones con distancias.
- Mostrar todas las conexiones y distancias.
- Calcular rutas óptimas con **BFS** (menor cantidad de nodos) y **Dijkstra** (menor distancia).

---

## Tecnologías
- C# (.NET Framework 4.x)
- Windows Forms
- Estructuras: TreeView, List, Dictionary

---

## Uso
1. Abrir el proyecto en Visual Studio.
2. Ejecutar la aplicación.
3. Para el árbol: seleccionar un nodo y usar los botones de agregar, eliminar, buscar y recorrer.
4. Para el grafo: agregar nodos y conexiones, luego buscar rutas usando BFS o Dijkstra.

---

## Notas
- La aplicación valida entradas para evitar errores de ejecución.
- Los recorridos y rutas se muestran en **ListBox** y **Label**.
- Diseñado para demostración y defensa técnica.
