// Programa principal
// Pruebas de funcionamiento para lista recursiva (se tiene que borrar)

using AppBiblioteca;

// PRUEBA DE LECTORES

CListaLectores Lectores = new();
Lectores.Agregar("111", "Ramirez", "Alberto", "Av. Brasil", "M", 18);
Lectores.Agregar("112", "Palacios", "Maria", "Av. Brasil", "F", 19);
Lectores.Agregar("113", "Durand", "Jose", "Av. Brasil", "M", 20);
Lectores.Agregar("114", "De los Rios", "Andric", "Av. Brasil", "F", 21);
Lectores.Agregar("115", "Quispe", "Fernando", "Av. Brasil", "M", 22);
Lectores.Agregar("116", "Puma", "Lia", "Av. Brasil", "F", 23);
Lectores.Agregar("117", "Espinoza", "Ian", "Av. Brasil", "M", 24);
Lectores.Agregar("118", "Mamamni", "Wilse", "Av. Brasil", "F", 25);

CControlLectores nuevoControl = new(Lectores);
nuevoControl.Ejecutar();
// ----------------------------------------------------------------------