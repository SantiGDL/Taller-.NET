# Actividad 2 - API de tareas

Este proyecto fue una práctica para empezar a trabajar con .NET, C# y APIs REST. La idea fue crear una API sencilla para manejar tareas, sin base de datos: por ahora se guardan en una lista en memoria.

## Qué hice

- Creé un proyecto Web API con .NET.
- Creé el modelo `Tarea`, con `Id`, `Nombre`, `Desc`, `DuracionHoras`, `Responsable` y `Fecha`.
- Agregué validaciones simples con `[Required]` y `[Range]`.
- Creé un controller con cuatro operaciones:

  - `GET /api/tareas` - consultar todas las tareas.
  - `GET /api/tareas/{id}` - consultar una tarea por id.
  - `POST /api/tareas` - insertar una tarea enviándola en formato JSON.
  - `DELETE /api/tareas/{id}` - eliminar una tarea.

- Dejé datos iniciales cargados desde el constructor del controller.
- Usé `ILogger` para registrar mensajes en la consola.
- Dejé OpenAPI preparado y aprendí cómo conectar Swagger para poder ver y probar los endpoints desde el navegador.

## Lo que aprendí

Aprendí las bases de C#: clases, propiedades, constructores, listas, tipos `string` e `int`, valores `null`, `readonly`, métodos y algunas validaciones.

También entendí mejor cómo funciona `Program.cs`: ahí se registran los servicios, se configura OpenAPI y se conectan las rutas de los controllers con `app.MapControllers()`.

Swagger no necesita que le escriba manualmente todos los endpoints. Lee los atributos del controller, como `[Route]`, `[HttpGet]`, `[HttpPost]` y `[HttpDelete]`, y con eso arma la descripción de la API para poder probarla.

## Para recordar

La información se maneja en memoria usando una `IList<Tarea>` y una `List<Tarea>`. Es una implementación sencilla para practicar el funcionamiento de una API, sus rutas y las operaciones básicas sobre los datos.
