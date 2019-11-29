# ogr2ogrGUI

A .NET-based GUI for the GDAL(R)'s ogr2ogr tool on Microsoft(R) Windows to insert Shape (SHP) files into SQL Server 2012 or higher versions.

Requirements
-Windows XP, Vista, 7, 8, 10 (x86 and x64 are supported)
-.NET Framework 4
-Windows Installer
-An installation of ogr2ogr (included with QGIS, GDAL tools, etc.)

Features:
-Allows visualizing the command sent to ogr2ogr
-Can be used to insert data into local or remote instances of SQL Server
-The database and instance names are entered manually (case insensitive)
-The errors and messages from ogr2ogr can be seen in real time

Limitations:
-The username and password for SQL Server are used in plain text
-The SRID for the source Shape file cannot be modified

TODO
-Use SQL Server credentials in a secure way
-Add option to change SRID for the source Shape file
-Add option to preview the source Shape file data
-(Eventually) Add support for more database engines

Last modified: November 28, 2019
