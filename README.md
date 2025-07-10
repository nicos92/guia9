# Proyecto: Guia 9 - ABM de entidad

## Profesor: Ezequiel Pacífico

## Alumno: Nicolás Salomón Sandoval

---

### Instituto Instituto superior de formación técnica Nº93

### Presidente Arturo Umberto Illia

### Materia: Seminario de Programaciñon

### Curso: 2º B

---

### Imágenes

#### Logo del Instituto

![Logo del Instituto](/recursos/insti.png)

#### Imagenes del Proyecto

![Imagen del Proyecto](/recursos/inicio.png)

![ingreso](/recursos/ingreso.png)

![](/recursos/busqueda.png)

![edicion](/recursos/edicion.png)

---

## Descripción

### Sistema de Gestión de Personas

Se presenta una aplicación de escritorio robusta y eficiente, desarrollada sobre la plataforma **.NET con Windows Forms**, diseñada para la administración integral de registros de personas. La aplicación ofrece una interfaz de usuario limpia, intuitiva y funcional, que centraliza las operaciones clave de gestión de datos como Crear, Leer, Actualizar y Eliminar.

El sistema está estructurado en módulos claros y diferenciados para optimizar la experiencia del usuario y la productividad.

#### **Características Principales:**

1. **Dashboard Principal:**
   
   - Al iniciar la aplicación, el usuario es recibido con una pantalla principal que ofrece una métrica clave de un vistazo: el **conteo total de "Personas Activas"**. Este indicador proporciona información inmediata sobre el estado actual de la base de datos.

2. **Módulo de Ingreso:**
   
   - Un formulario de ingreso de datos dedicado y estructurado para registrar nuevas personas en el sistema.
   
   - Los campos incluyen información esencial como Nombre, Apellido, DNI, Dirección, Teléfonos (principal y secundario) y una opción de **Modalidad de Pago** que es Mensual o Quincenal mediante radio buttons, asegurando la integridad de los datos desde el inicio.

3. **Módulo de Consulta y Gestión:**
   
   - **Filtro de Búsqueda Dinámico:** Permite a los usuarios localizar rápidamente a una persona específica mediante su DNI, Apellido o Nombre.
   
   - **Botones de Acción:**
     
     - **BUSCAR**: Ejecuta la búsqueda aplicando el filtro ingresado y actualiza la tabla con los resultados correspondientes.
     
     - **TODOS**: Restablece el filtro y muestra la totalidad de los registros de personas en la base de datos.
   
   - **Tabla de Resultados:** Una grilla de datos (DataGridView) presenta la información de forma clara y ordenada, con columnas para ID, Legajo, DNI, Apellido, Nombres, y más.
   
   - **Gestión de Registros:** Los botones **EDITAR** y **ELIMINAR** se activan al seleccionar una fila de la tabla, garantizando que las acciones se realicen sobre el registro correcto y evitando errores de usuario.

4. **Ventana de Edición:**
   
   - Al seleccionar un registro y hacer clic en EDITAR, se abre una ventana modal que carga automáticamente todos los datos de la persona seleccionada.
   
   - Permite la modificación de cualquier campo, incluyendo la **Modalidad de Pago**.
   
   - Incorpora una funcionalidad clave: una casilla de verificación **Baja**. Al marcar esta opción, la persona es registrada como inactiva, lo que se refleja directamente en el contador del dashboard principal.
   
   - Un botón de **EDITAR** confirma y guarda los cambios en la base de datos, cerrando la ventana modal y actualizando la vista en la tabla de consulta.

---

## **Tecnologías Utilizadas:**

- **Framework:** .NET

- **Lenguaje de Programación:** C#

- **Interfaz Gráfica:** Windows Forms (WinForms)

- **Gestión de Datos:** Conectividad a una base de datos MS Access para la persistencia y manipulación de la información.

Esta aplicación es una solución de software de escritorio completa y escalable, perfecta para cualquier entorno que requiera una gestión de personal o clientes de manera organizada, rápida y segura.

---

## **Manual de Usuario**

A continuación, se detallan las instrucciones de uso para cada una de las funciones principales de la aplicación.

#### **1. Módulo de Inicio**

Esta es la pantalla principal que ves al abrir la aplicación.

- **Para ver el estado general:** El número grande que se muestra (ej. 2) representa el total de **Personas Activas** actualmente en el sistema. No requiere ninguna acción, es solo informativo.

- **Para navegar a otras secciones:** Haga clic en las pestañas INGRESO o CONSULTA en la barra de navegación superior.

#### 2. Módulo de Ingreso de Personas

Utilice esta sección para añadir nuevas personas al sistema.

1. Haga clic en la pestaña **INGRESO**.

2. Complete todos los campos del formulario con la información de la nueva persona:
   
   - **Nombre**
   
   - **Apellido**
   
   - **DNI**
   
   - **Dirección**
   
   - **Teléfono**
   
   - **Teléfono 2**

3. Seleccione la **Modalidad de pago** adecuada, eligiendo entre Mensual o Quincenal.

4. Una vez que todos los datos estén correctos, haga clic en el botón **+ INGRESAR** para guardar el nuevo registro.

#### **3. Módulo de Consulta**

Esta es la sección principal para buscar, visualizar, editar y eliminar registros.

1. Diríjase a la pestaña **CONSULTA**.

2. En el campo de texto DNI, Apellido ó Nombre, escriba el dato de la persona que desea encontrar.

3. Haga clic en el botón azul **BUSCAR**.

4. La tabla se actualizará y mostrará únicamente los registros que coincidan con su búsqueda.

5. Haga clic en el botón azul **TODOS**.

6. La tabla se cargará con la lista completa de todas las personas registradas en el sistema.

#### **4. Módulo de Edición de Personas**

Siga estos pasos para modificar los datos de una persona ya existente.

1. Primero, asegúrese de estar en la pestaña **CONSULTA**.

2. Busque y encuentre a la persona que desea editar (usando los métodos de búsqueda anteriores).

3. **Haga clic una sola vez sobre la fila** de la persona en la tabla para seleccionarla. La fila seleccionada cambiará de color para indicar que está activa.

4. Con la fila ya seleccionada, haga clic en el botón naranja **EDITAR**.

5. Se abrirá una nueva ventana llamada EDICION con todos los datos de esa persona ya cargados en los campos.

6. Modifique la información que necesite cambiar.

7. **Para dar de baja:** Si desea marcar a la persona como inactiva, marque la casilla de verificación **Baja**. Esto la excluirá del conteo de "Personas Activas".

8. Para guardar todos los cambios, haga clic en el botón naranja **EDITAR** que se encuentra dentro de esta ventana de edición. La ventana se cerrará y los datos se actualizarán en la tabla principal.

#### **5. Eliminación de Personas**

**¡Atención!** Esta acción borrará permanentemente el registro de la persona del sistema. Úsela con precaución.

1. En la pestaña **CONSULTA**, busque y encuentre a la persona que desea eliminar.

2. **Haga clic una sola vez sobre la fila** de la persona en la tabla para seleccionarla.

3. Con la fila seleccionada, haga clic en el botón rojo **ELIMINAR**.

4. El sistema le pedirá confirmación para evitar borrados accidentales. Acepte para continuar.

5. El registro de la persona será eliminado de la base de datos y desaparecerá de la tabla.

---

## Licencia

Copyright © 2025 Sandoval Nicolás Salomón

Todos los derechos reservados.

Este proyecto se proporciona sin una licencia explícita, lo que significa que el autor retiene el control total sobre el software. No se concede ningún permiso para usar, copiar, modificar, distribuir o sublicenciar este proyecto o sus partes sin el consentimiento previo y por escrito del autor.

**Su propósito es estrictamente para demostración y evaluación de portafolio.**
