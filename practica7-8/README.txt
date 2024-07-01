Entiendo que pueda no estar funcionando la migración.

Creo que es debido a la forma en que creo el contexto de bd a partir del que se ejecutan los metodos.

Lo hice de esa forma para poder crear una bd en memoria con el paquete Microsoft.EntityFrameworkCore.InMemory, y usarla como context para los Unit Test, de forma que no se vaya usando la misma bd cada vez que ejecuto un Test.

Espero poder solucionarlo en un futuro. De cualquier forma, si lo desea, dejo un archivo pacpak que sirve de reemplazo a la migración, permitiendo conectarse a la bd verdadera y ver la logica del front sin problemas.