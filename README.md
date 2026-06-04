# Trabajo Práctico: Tipo `string` en C#

## Índice

- [¿String es un tipo por valor o por referencia?](#string-tipo-por-valor-o-referencia)
- [Secuencias de escape](#secuencias-de-escape)
- [Uso de `@` y `$` antes de una cadena](#uso-de--y--antes-de-una-cadena)

---

## String: ¿tipo por valor o por referencia?

`string` es un **tipo por referencia** en C#, ya que deriva de la clase `System.String`.

Sin embargo, tiene un comportamiento especial: es **inmutable**. Esto significa que una vez creada una cadena, su contenido no puede modificarse. Cuando aparenta modificarse, en realidad se crea una nueva cadena en memoria.

**Ejemplo:**

```csharp
string texto = "Hola";
texto = texto + " Mundo";
```

> Aquí no se modifica la cadena original, sino que se crea una **nueva cadena** en memoria.

---

## Secuencias de escape

El tipo `string` soporta las siguientes secuencias de escape:

| Secuencia | Descripción       |
|-----------|-------------------|
| `\n`      | Salto de línea    |
| `\t`      | Tabulación        |
| `\\`      | Barra invertida   |
| `\"`      | Comillas dobles   |
| `\'`      | Comilla simple    |
| `\r`      | Retorno de carro  |
| `\b`      | Retroceso         |
| `\0`      | Carácter nulo     |

**Ejemplo:**

```csharp
Console.WriteLine("Hola\nMundo");
```

**Salida:**

```
Hola
Mundo
```

---

## Uso de `@` y `$` antes de una cadena

### `@` — Verbatim String

Permite escribir cadenas **sin escapar caracteres especiales**.

```csharp
// Con @
string ruta = @"C:\Users\Benjamin\Documentos";

// Sin @
string ruta = "C:\\Users\\Benjamin\\Documentos";
```

Ambas producen el mismo resultado, pero `@` mejora la legibilidad.

---

### `$` — Interpolación de cadenas

Permite **insertar variables** directamente dentro de una cadena usando `{}`.

```csharp
string nombre = "Benjamin";
Console.WriteLine($"Hola {nombre}");
```

**Salida:**

```
Hola Benjamin
```

---

### `@$` — Combinación de ambos

Se pueden usar juntos para tener interpolación y sin necesidad de escapar caracteres:

```csharp
string nombre = "Benjamin";
string texto = $@"Usuario: {nombre}
Ruta: C:\Archivos";
```