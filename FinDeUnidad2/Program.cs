using System;
using AppBiblioteca;
// Programa principal
// Pruebas de funcionamiento para lista recursiva (se tiene que borrar)

using ClasesGenerales;
using EstDatos;

CControlTesis Tesis = new();
CControlLectores Lectores = new();
CControlPrestamo Prestamos = new();

while (true)
{
	CMenu.MostrarMenu(Tesis, Lectores, Prestamos);
}


// ----------------------------------------------------------------------
