Doctor CRUD
===============
[![MIT License](https://img.shields.io/badge/License-MIT-green.svg)](https://choosealicense.com/licenses/mit/)
[![en](https://img.shields.io/badge/lang-en-red.svg)](https://github.com/alejandroMAD/doctor-CRUD/blob/master/README.md)
[![es](https://img.shields.io/badge/lang-es-yellow.svg)](https://github.com/alejandroMAD/doctor-CRUD/blob/master/README.es.md)

Interfaz de usuario
----------
![Demo screenshot](/screenshot.png)

Una aplicación de Windows Forms-VB.Net que permite crear, leer, modificar y eliminar además de realizar búsquedas de citas médicas, guardando los registros en una base de datos SQLite y mostrándolos en un control ListView.

Características
-------------------
* El formulario de registro permite recolectar información personal del paciente, el nombre y especialidad del médico y fecha y hora de la cita.
* Dos controles DateTimePicker permiten al usuario seleccionar la fecha y hora en el formato apropiado.
* Una base de datos local SQLite compuesta de una tabla única almacena los registros de citas médicas.
* La aplicación permite realizar las operaciones básicas de tipo CRUD sobre los registros de la base de datos.
* El formulario permite búsquedas en la base de datos por los criterios de: ID de la cita, apellido del paciente, nombre del médico y fecha de la cita.
* La búsqueda por patrones es posible mediante el operador de SQLite LIKE y el cómodín "%"; por ejemplo, es posible buscar pacientes y médicos cuyo nombre incluya "mac" o "man".
* El índice de los registros ya existentes en la base de datos y el del próximo registro pendiente de incorporación se muestran en el formulario, pero el usuario no tiene permitido modificar su valor en consonancia con la propiedad implícita "AUTOINCREMENT" de la columna ROWID de SQLite. 
* Una control ListView es actualizado de manera dinámica en la interfaz de usuario mostrando las entradas almacenadas en la base de datos de citas médicas.

Reconocimiento
-------------------

* Ilustración de un médico: [Ilustración creada por Mohamed Hassan - Pixabay](https://pixabay.com/images/id-2988137)
* Icono de hospital: [Iconos de Hospital creados por Freepik - Flaticon](https://www.flaticon.com/free-icons/hospital)

Licencia
--------
    Copyright (C) 2022  Alejandro M. González
    
    MIT License: http://opensource.org/licenses/MIT
