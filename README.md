# 🧠 Ejercicios Clase 4

**Temas:** Colecciones en C#  
**Estructuras trabajadas:** Listas, Arreglos, Diccionarios, Colas, Pilas

---

## ✅ Ejercicios 1–10 (Obligatorios)

1. **Promedio de exámenes**  
   Dado que se tiene almacenado en una lista los resultados de los últimos 10 exámenes de un alumno, calcular su promedio y mostrar por pantalla las 10 notas y el promedio resultante.

2. **Mayores y menores de edad**  
   Dadas las edades de 20 personas guardadas en una lista, imprimir cuántos son mayores de edad y cuántos no.

3. **Nombre más largo y más corto**  
   Dada una lista de nombres de estudiantes, imprimir el que tenga más letras y el que tenga menos letras.

4. **Lista de supermercado interactiva**  
   Crear una lista con nombres de productos. Solicitar al usuario que ingrese productos a comprar:
   - Si el producto está en la lista, quitarlo e informar que sí estaba.
   - Si no está, agregarlo e informar que no estaba.
   - Al finalizar (cuando el usuario ingresa `"fin"`), mostrar:
     - Elementos que no compró
     - Elementos que compró pero no estaban en la lista
     - (Opcional) Todos los productos comprados

5. **Matriz 5x5 con 'I' y 'P'**  
   Crear una matriz de 5x5. Almacenar una `'I'` en lugares impares y una `'P'` en lugares pares. Imprimir la matriz.

6. **Temperaturas en cabina de pago (matriz 5x7)**  
   Simular temperaturas diarias entre 7 y 38 grados para el mes de mayo:
   - a. Temperatura más alta y más baja de la semana y qué día se produjo
   - b. Promedio de temperatura semanal
   - c. Temperatura más alta del mes y su día

7. **Tablas de multiplicar en matriz**  
   Crear una matriz que contenga las tablas del 1 al 9. La primera fila y columna deben contener los números del 0 al 9. El resto de las celdas debe calcularse como multiplicación entre fila y columna.

8. **Juego de las X ocultas (matriz 10x10)**  
   - Esconder varias `'X'` en posiciones aleatorias (no más de la mitad de la matriz).
   - El usuario debe adivinar las posiciones ingresando fila y columna.
   - Tiene 3 intentos para fallar.
   - Al finalizar, mostrar la matriz con `'X'` y `'*'` donde no haya nada.

9. **Diccionario de calificaciones**  
   Crear un `Dictionary<string, double>` donde:
   - a. Se puedan agregar alumnos y sus notas
   - b. Se calcule el promedio general del curso
   - c. Se indique el alumno con mejor y peor nota

10. **Simulador de atención en ventanilla (Queue)**  
    - a. Encolar nombres de clientes
    - b. Atender (desencolar) uno por uno
    - c. Mostrar quién está siendo atendido y cuántos quedan en la fila

---

## ⭐ Ejercicio 11 (Extra - Opcional)

**Inventario con múltiples colecciones**

Diseñar un sistema de inventario básico usando:

- `List<string>`: productos disponibles
- `Dictionary<string, int>`: stock de cada producto
- `Stack<string>`: historial de acciones (agregar, quitar, vender)

El programa debe permitir:

1. Agregar un producto y su cantidad  
2. Vender un producto (restando stock)  
3. Mostrar el inventario actual  
4. Mostrar las últimas 3 acciones registradas  

> 💡 *Hint:* combiná listas, diccionarios y pilas para manipular distintos tipos de información.

---

📁 *Este archivo forma parte del repositorio [`devlights_ejercicios`](https://github.com/JezabelCoronas/devlights_ejercicios), correspondiente al Bootcamp 4.0 de .NET.*
