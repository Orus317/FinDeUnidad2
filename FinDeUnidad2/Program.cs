using System;
using AppBiblioteca;


CListaTesis Tesis = new();
Tesis.Agregar("1001", "Aplicación del problema del agente viajero a la recolección de residuos sólidos de la Municipalidad Distrital de San Jerónimo", "BR. PAUCCARA PINARES, DANIEL", 2019, "Distancia recorrida", "MGT. JULIO CESAR CARBAJAL LUNA");
Tesis.Agregar("1002", "Algoritmo para el problema data streaming clustering para conjuntos amorfos y con outliers", "BR. ISAAC CAMPOS ARDILES", 2021, "Data streaming", "");
Tesis.Agregar("1003", "Implementación de técnicas de minería de texto para la clasificación de tickets de soporte en la oficina de Tecnologías de la Información de EGEMSA", "INGENIERO INFORMÁTICO Y DE SISTEMAS", 2022, "Datos no estructurados", "DR. PALOMINO OLIVERA, EMILIO");
Tesis.Agregar("1004", "Identificación de establecimientos comerciales no registrados en mapas digitales", "Br. ACHAHUI VILCA CESAR ERNESTO", 2021, "Deep learning", "Dr. LAURO ENCISO RODAS");
Tesis.Agregar("1005", "Diseño y evaluación de un modelo basado en una red de cápsulas de matrices con em routing utilizando una red convolucional densa", "Br. BERNAL RIOS PAUL THEO", 2020, "Dense-Net", "M.Sc. ORMENO AYALA YESHICA ISELA ");
Tesis.Agregar("1006", "Implementación de la red de acceso a internet por fibra óptica para el desarrollo de las clases virtuales de la Institución Educativa Wiñaypaq de la comunidad campesina de Huandar del distrito de Pisac", "BR. GUIDO HUAMAN LOAYZA", 2022, "Centro de computo", "Dr. RONY VILLAFUERTE SERNA");
Tesis.Agregar("1007", "Evaluación de técnicas de Change detection utilizando imágenes satelitales Landsat 8 para identificar cambios en la superficie causados por la minería", "Br. Josmar Rolando Bola˜nos Huaman", 2021, "Change Detection", "Dr. Rony Villafuerte Serna");
Tesis.Agregar("1008", "Algoritmo para el problema data streaming clustering para conjuntos amorfos y con outliers", "Dr. Rony Villafuerte Serna", 2021, "Clustering", "DR. RONY VILLAFUERTE SERNA");
Tesis.Agregar("1009", "Identificación de métodos de procesamiento digital de imágenes bacteriológicas microscópicas para el diagnóstico de tuberculosis", "Br. HERLY LAROTA MAMANI", 2020, "Confiabilidad", "MG. ARTURO J. ROZAS HUACHO");
Tesis.Agregar("1010", "Análisis masivo de datos en twitter para identificación de opinión ", "Br. Albhert Edison Olarte Chullo", 2020, "Aprendizaje Automático", "Mg. Julio Cesar Carbajal Luna");
Tesis.Agregar("1011", "Aplicación de visión artificial en la estimación del peso corporal del cuy", "Br. ZAPATA TTITO, ABEL GABRIEL", 2022, "Cuy", "M. Sc. ORMENO AYALA, YESHICA ISELA");
Tesis.Agregar("1012", "Construcción de un prototipo de sistema para clasificar enfermedades en las hojas de cafeto basado en visión computacional", "Br. ERWIN JHARIN PUCLLA ZEGARRA", 2020, "Hemileia Vastatrix", "Dr. LAURO ENCISO RODAS");
Tesis.Agregar("1013", "Construcción de un extractor de características basado en modelos pre-entrenados de redes neuronales convolucionales, para la identificación de imágenes de pinturas coloniales de la ciudad del Cusco", "Br. Castilla Condori, Yesenia Erika", 2021, "Modelo pre-entrenado", "Mgt. Julio Cesar Carbajal Luna");
Tesis.Agregar("1014", "Prototipo de un sistema portátil para el tratamiento preventivo de ulceraciones por presión del pie diabético", "BR. RODAS VELASQUEZ, GRISLIN CLARA", 2021, "Ulceraciones", "Dr. RONY VILLAFUERTE SERNA");
Tesis.Agregar("1015", "Software multiplataforma para restaurantes utilizando tecnologías híbridas Node.Js, Electron.Js y React Native ", "Br. FARFÁN LAZO, JOSUE", 2019, "Electron.js", "Mgt. RONY VILLAFUERTE SERNA");

CListaPrestamo Prestamos = new();
Prestamos.Agregar("2001", "01/01/2020", "1001", "111");
Prestamos.Agregar("2002", "02/01/2020", "1002", "112");
Prestamos.Agregar("2003", "12/02/2020", "1003", "113");
Prestamos.Agregar("2004", "01/05/2020", "1004", "114");
Prestamos.Agregar("2005", "14/06/2020", "1005", "115");
Prestamos.Agregar("2006", "19/02/2021", "1006", "116");
Prestamos.Agregar("2007", "01/09/2021", "1007", "117");
Prestamos.Agregar("2008", "11/07/2021", "1008", "118");
Prestamos.Agregar("2009", "01/12/2021", "1009", "118");
Prestamos.Agregar("2010", "01/06/2021", "1010", "111");
Prestamos.Agregar("2011", "11/07/2021", "1011", "111");
Prestamos.Agregar("2012", "01/07/2021", "1012", "112");
Prestamos.Agregar("2013", "13/07/2021", "1013", "113");
Prestamos.Agregar("2014", "27/07/2021", "1014", "114");
Prestamos.Agregar("2015", "15/05/2021", "1015", "115");
Prestamos.Agregar("2016", "13/03/2021", "1006", "116");
Prestamos.Agregar("2017", "10/03/2021", "1007", "117");
Prestamos.Agregar("2018", "04/06/2022", "1008", "118");
Prestamos.Agregar("2019", "04/04/2022", "1009", "118");
Prestamos.Agregar("2020", "05/12/2022", "1010", "111");
Prestamos.Agregar("2021", "05/03/2022", "1011", "112");
Prestamos.Agregar("2022", "19/01/2022", "1013", "113");
Prestamos.Agregar("2023", "23/11/2022", "1014", "114");
Prestamos.Agregar("2024", "23/01/2022", "1015", "115");
Prestamos.Agregar("2025", "05/09/2022", "1016", "116");
Prestamos.Agregar("2026", "05/07/2022", "1017", "117");
Prestamos.Agregar("2027", "04/09/2022", "1018", "118");
Prestamos.Agregar("2028", "04/05/2022", "1019", "118");
Prestamos.Agregar("2029", "04/07/2022", "1010", "111");
Prestamos.Agregar("2030", "12/06/2022", "1011", "111");
Prestamos.Agregar("2031", "06/06/2022", "1012", "112");
Prestamos.Agregar("2032", "02/07/2022", "1013", "113");
Prestamos.Agregar("2033", "04/06/2022", "1014", "114");
Prestamos.Agregar("2034", "02/08/2022", "1015", "115");
Prestamos.Agregar("2035", "03/07/2022", "1006", "116");
Prestamos.Agregar("2036", "01/08/2022", "1007", "117");
Prestamos.Agregar("2037", "28/10/2022", "1008", "118");
Prestamos.Agregar("2038", "21/11/2022", "1009", "118");
Prestamos.Agregar("2039", "11/12/2022", "1010", "111");
Prestamos.Agregar("2040", "01/12/2022", "1011", "111");

CListaLectores Lectores = new();
Lectores.Agregar("111", "Ramirez", "Alberto", "Av. Brasil", "M", 18);
Lectores.Agregar("112", "Palacios", "Maria", "Av. Brasil", "F", 19);
Lectores.Agregar("113", "Durand", "Jose", "Av. Brasil", "M", 20);
Lectores.Agregar("114", "De los Rios", "Andric", "Av. Brasil", "F", 21);
Lectores.Agregar("115", "Quispe", "Fernando", "Av. Brasil", "M", 22);
Lectores.Agregar("116", "Puma", "Lia", "Av. Brasil", "F", 23);
Lectores.Agregar("117", "Espinoza", "Ian", "Av. Brasil", "M", 24);
Lectores.Agregar("118", "Mamamni", "Wilse", "Av. Brasil", "F", 25);

CListaDevoluciones Devoluciones = new();
Devoluciones.Agregar("3001", "01/10/2022", "2001");
Devoluciones.Agregar("3002", "10/12/2022", "2002");
Devoluciones.Agregar("3003", "02/03/2022", "2003");
Devoluciones.Agregar("3004", "12/04/2022", "2004");
Devoluciones.Agregar("3005", "17/05/2022", "2005");
Devoluciones.Agregar("3006", "03/08/2022", "2006");
Devoluciones.Agregar("3007", "20/04/2022", "2007");
Devoluciones.Agregar("3008", "01/07/2022", "2008");
Devoluciones.Agregar("3009", "05/06/2022", "2009");
Devoluciones.Agregar("3010", "27/08/2022", "2010");


CControlLectores nuevoControl_Lectores = new(Lectores);
CControlTesis nuevoControl_Tesis = new(Tesis);
CControlPrestamo nuevoControl_Prestamo = new(Prestamos);
CControlDevoluciones nuevoControl_Devoluciones = new(Devoluciones);

while (true)
{
CMenu.MostrarMenu(nuevoControl_Tesis, nuevoControl_Lectores, nuevoControl_Prestamo, nuevoControl_Devoluciones);
}


// nuevoControl.Ejecutar();
// ----------------------------------------------------------------------
