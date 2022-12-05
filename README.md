Doctor CRUD
===============
[![MIT License](https://img.shields.io/badge/License-MIT-green.svg)](https://choosealicense.com/licenses/mit/)
[![en](https://img.shields.io/badge/lang-en-red.svg)](https://github.com/alejandroMAD/doctor-CRUD/blob/master/README.md)
[![es](https://img.shields.io/badge/lang-es-yellow.svg)](https://github.com/alejandroMAD/doctor-CRUD/blob/master/README.es.md)

User interface
----------
![Demo screenshot](/screenshot.png)

A VB.Net Windows Forms application to create-read-delete-update + search doctor appointments, keeping the records in a SQLite database and displaying them on a ListView control.

Features
-------------------
* The registration form allows to collect personal information from the patient, the name and specialty of the physician, and date and time of the appointment.
* Two DateTimePicker controls enable the user to select the date and time in a proper format.
* A local single-table SQLite database keeps the records of the medical appointments.
* The application allows for the basic CRUD operations on the database records.
* The form allows to search the database by ID/patient's last name/doctor's name/appointment date criteria.
* Pattern searching is enabled by means of the SQLite LIKE operator and '%' wildcard, e.g., finding patients and doctors names including "mac" or "man".
* The index of existing records and the index of the next record to be added is shown in the form, but the user isn't allowed to edit the value to conform to the implicit autoincrement of the SQLite ROWID column. 
* A ListView control is dinamically updated on the user interface to show the records of the medical appointments.

Credits
-------------------

* Doctor picture: [Picture created by Mohamed Hassan - Pixabay](https://pixabay.com/images/id-2988137)
* Hospital icon: [Hospital icons created by Freepik - Flaticon](https://www.flaticon.com/free-icons/hospital)

License
--------
    Copyright (C) 2022  Alejandro M. González
    
    Permission is hereby granted, free of charge, to any person obtaining a copy
    of this software and associated documentation files (the "Software"), to deal
    in the Software without restriction, including without limitation the rights
    to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
    copies of the Software, and to permit persons to whom the Software is
    furnished to do so, subject to the following conditions:
    
    The above copyright notice and this permission notice shall be included in all
    copies or substantial portions of the Software.
    
    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
    AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
    OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
    SOFTWARE.
    
    MIT License: http://opensource.org/licenses/MIT
