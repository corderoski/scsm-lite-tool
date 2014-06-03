# README #

Pequeña herramienta Windows Forms sobre C# que permite ciertas operaciones básicas sobre los ManagementPack y EnumerationValues de System Center Service Manager.

### Motivo del Repositorio ###

Ehm, la idea del repositorio es compartir las porciones de código de una manera más técnica y provechosa que mediante almacenamiento en línea. Así, quien los use, pueda contribuir de igual forma a los siguientes técnicos.

Actualmente no se indica la distribución de un ejecutable ya que se requiere personalizar una clase para la carga de los excel.



## Cómo utilizar? ##

### Resumen ###

Básicamente es descargar los fuentes y compilar/ejecutar el proyecto. De presentar incidencias, revisar las referencias de las Dll de System Center (también incluidas).


* .NET Framework 3.5
* Lenguaje de Programación C#
* Uso de librerías FileHelpers para manipulación de Excel
* La aplicación sólo busca archivos de extensión ‘.xlsx’ debido al FileFilter, se puede modificar para leer los de Microsoft Excel 2007 ‘.xls’
* Librerías adicionales para conexión a SCSM
* Actualmente cuenta con muy pocas validaciones y manejo de excepciones por lo que… ¡estáis avisados!


* Configuración

No requiere configuración adicional de ningún tipo.


### Dependencias ###

* Filehelper para carga de archivos.
* JSON para una funcionalidad extra añadida para beneficio del Portal.


### Notas ###

A excepción de las políticias de Microsoft sobre sus productos y sistemas, todo lo demás son artefactos Freeware u Open Source.

Los paquetes/librerías de las que hace uso la herramienta, disponen de sus propias licencias.