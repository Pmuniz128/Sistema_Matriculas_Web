Imports System.IO
Imports System.Xml
Imports System.Data
Imports System.Configuration

Imports System.Xml.Serialization

Public Class ArchivoXml
    Private Shared Function RutaArchivoXml() As String
        Return ConfigurationManager.AppSettings("Ruta archivo Funcionarios")
    End Function

    Public Sub Grabar(archivo As MemoryStream, rutaArchivo As String)

        Dim fileXML As FileStream = New FileStream(rutaArchivo, FileMode.Create, FileAccess.Write)
        archivo.WriteTo(fileXML)
        fileXML.Close()
        archivo.Close()

    End Sub

    Public Function Leer(rutaArchivo As String) As XmlDocument
        Dim xmlArchivo As New XmlDocument
        xmlArchivo.Load(rutaArchivo)

        Return xmlArchivo
    End Function

End Class
