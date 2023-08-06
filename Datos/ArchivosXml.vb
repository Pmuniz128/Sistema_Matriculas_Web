Imports System.IO
Imports System.Xml
Imports System.Data
Imports System.Configuration
Imports Negocios
Imports System.Xml.Serialization

Public Class ArchivoXml
    Private Shared Function RutaArchivoXml() As String
        Return ConfigurationManager.AppSettings("Ruta archivo Funcionarios")
    End Function

    Public Shared Sub GrabarXml(funcionarios As List(Of Funcionario))
        Dim rutaXml As String = RutaArchivoXml()

        Dim xmlArchivo As XmlDocument = New XmlDocument()
        xmlArchivo.Load(rutaXml)

        Dim rootNode As XmlNode = xmlArchivo.SelectSingleNode("Funcionarios")

        For Each funcionario As Funcionario In funcionarios
            Dim funcionarioNode As XmlNode = xmlArchivo.CreateElement("Funcionario")

            Dim idNode As XmlNode = xmlArchivo.CreateElement("ID")
            idNode.InnerText = funcionario.Identificacion.ToString()
            funcionarioNode.AppendChild(idNode)

            Dim nombreNode As XmlNode = xmlArchivo.CreateElement("Nombre")
            nombreNode.InnerText = funcionario.Nombre
            funcionarioNode.AppendChild(nombreNode)

            Dim primerApellidoNode As XmlNode = xmlArchivo.CreateElement("Primer_Apellido")
            primerApellidoNode.InnerText = funcionario.primerApellido
            funcionarioNode.AppendChild(primerApellidoNode)

            Dim segundoApellidoNode As XmlNode = xmlArchivo.CreateElement("Segundo_Apellido")
            segundoApellidoNode.InnerText = funcionario.segundoApellido
            funcionarioNode.AppendChild(segundoApellidoNode)

            Dim fechaNacimientoNode As XmlNode = xmlArchivo.CreateElement("FechaNacimiento")
            fechaNacimientoNode.InnerText = funcionario.FechaNacimiento.ToString()
            funcionarioNode.AppendChild(fechaNacimientoNode)

            Dim emailNode As XmlNode = xmlArchivo.CreateElement("Email")
            emailNode.InnerText = funcionario.email
            funcionarioNode.AppendChild(emailNode)

            Dim contraseñaNode As XmlNode = xmlArchivo.CreateElement("Contraseña")
            contraseñaNode.InnerText = funcionario.contraseña
            funcionarioNode.AppendChild(contraseñaNode)

            rootNode.AppendChild(funcionarioNode)
        Next


        xmlArchivo.Save(rutaXml)
    End Sub
    Public Shared Function Leer() As List(Of Funcionario)
        Dim ObtenerRutaXml As String = rutaArchivoXml()
        Dim xmlArchivo As New DataTable
        xmlArchivo.ReadXml(ObtenerRutaXml)

        Dim funcionarios As List(Of Funcionario)

        For Each filaArchivo As DataRow In xmlArchivo.Rows
            Dim funcionario As New Funcionario With {
                .Identificacion = Integer.Parse(filaArchivo("ID").ToString()),
                .Nombre = filaArchivo("Nombre").ToString,
                .primerApellido = filaArchivo("Primer_Apellido").ToString,
                .segundoApellido = filaArchivo("Segundo_Apellido").ToString,
                .fechaNacimiento = DateTime.Parse(filaArchivo("Fecha_Nacimiento").ToString),
                .contraseña = filaArchivo("Contraseña").ToString
            }
            funcionarios.Add(funcionario)
        Next

        Return funcionarios

    End Function
    Public Shared Function CargarXml_fun() As List(Of Funcionario)
        Dim funcionarios As New List(Of Funcionario)()

        Dim serializer As New XmlSerializer(GetType(List(Of Funcionario)))

        Using reader As New StreamReader(obtenerFuncionarioXml.ToString)
            funcionarios = DirectCast(serializer.Deserialize(reader), List(Of Funcionario))
        End Using


        Return funcionarios
    End Function

    Private Shared funcionariosXml As New List(Of Funcionario)()

    Public Shared Sub AgregarFuncionario(funcinario As Funcionario)
        funcionariosXml.Add(funcinario)
    End Sub
    Public Shared Function obtenerFuncionarioXml() As List(Of Funcionario)

        Return funcionariosXml
    End Function

    ''estudiantes
    Private Shared Function rutaArchivoXml_Est() As String
        Return ConfigurationManager.AppSettings("Ruta archivo Estudiantes")
    End Function
    Private Shared Function Creartabla_Estu() As DataTable
        Dim xmlArchivo As New DataTable("Estudiantes")
        xmlArchivo.Columns.Add("ID", GetType(Integer))
        xmlArchivo.Columns.Add("Nombre", GetType(String))
        xmlArchivo.Columns.Add("Primer_Apellido", GetType(String))
        xmlArchivo.Columns.Add("Segundo_Apellido", GetType(String))
        xmlArchivo.Columns.Add("Fecha_Nacimiento", GetType(DateTime))
        xmlArchivo.Columns.Add("Email", GetType(String))
        xmlArchivo.Columns.Add("Direccion_Exacta", GetType(String))
        xmlArchivo.Columns.Add("Carrera", GetType(String))
        xmlArchivo.Columns.Add("Telefono", GetType(Integer))
        xmlArchivo.Columns.Add("Beca", GetType(Boolean))
        xmlArchivo.Columns.Add("Porcentaje", GetType(String))

        Return xmlArchivo
    End Function
    Public Shared Sub GrabarXml_Est(Estudiantes As List(Of Estudiante))
        Dim rutaXml As String = rutaArchivoXml_Est()


        If Not File.Exists(rutaXml) Then

            Dim xmlDocumento As New XmlDocument()
            Dim rootNode1 As XmlNode = xmlDocumento.CreateElement("Estudiantes")
            xmlDocumento.AppendChild(rootNode1)
            xmlDocumento.Save(rutaXml)
        End If

        Dim xmlArchivo As XmlDocument = New XmlDocument()
        xmlArchivo.Load(rutaXml)

        Dim rootNode As XmlNode = xmlArchivo.SelectSingleNode("/Estudiantes")
        If rootNode Is Nothing Then
            rootNode = xmlArchivo.CreateElement("Estudiantes")
            xmlArchivo.AppendChild(rootNode)
        End If

        For Each estudiante As Estudiante In Estudiantes
            Dim estudianteNode As XmlNode = xmlArchivo.CreateElement("Estudiante")

            Dim nombreNode As XmlNode = xmlArchivo.CreateElement("Nombre")
            nombreNode.InnerText = estudiante.Nombre
            estudianteNode.AppendChild(nombreNode)

            Dim primerApellidoNode As XmlNode = xmlArchivo.CreateElement("Primer_Apellido")
            primerApellidoNode.InnerText = estudiante.primerApellido
            estudianteNode.AppendChild(primerApellidoNode)

            Dim segundoApellidoNode As XmlNode = xmlArchivo.CreateElement("Segundo_Apellido")
            segundoApellidoNode.InnerText = estudiante.segundoApellido
            estudianteNode.AppendChild(segundoApellidoNode)

            Dim fechaNacimientoNode As XmlNode = xmlArchivo.CreateElement("FechaNacimiento")
            fechaNacimientoNode.InnerText = estudiante.FechaNacimiento.ToString()
            estudianteNode.AppendChild(fechaNacimientoNode)

            Dim idNode As XmlNode = xmlArchivo.CreateElement("ID")
            idNode.InnerText = estudiante.Identificacion.ToString()
            estudianteNode.AppendChild(idNode)

            Dim direccionExactaNode As XmlNode = xmlArchivo.CreateElement("Direccion_Exacta")
            direccionExactaNode.InnerText = estudiante.direccionExacta
            estudianteNode.AppendChild(direccionExactaNode)

            Dim carreraNode As XmlNode = xmlArchivo.CreateElement("Carrera")
            carreraNode.InnerText = estudiante.CarreraMatriculada
            estudianteNode.AppendChild(carreraNode)

            Dim emailNode As XmlNode = xmlArchivo.CreateElement("Email")
            emailNode.InnerText = estudiante.email
            estudianteNode.AppendChild(emailNode)

            Dim telefonoNode As XmlNode = xmlArchivo.CreateElement("Telefono")
            telefonoNode.InnerText = estudiante.telefono
            estudianteNode.AppendChild(telefonoNode)

            Dim tieneBecaNode As XmlNode = xmlArchivo.CreateElement("Beca")
            tieneBecaNode.InnerText = estudiante.TieneBeca
            estudianteNode.AppendChild(tieneBecaNode)

            Dim porcentajeBecaNode As XmlNode = xmlArchivo.CreateElement("Porcentaje_Beca")
            porcentajeBecaNode.InnerText = estudiante.porcentaje_Beca.ToString()
            estudianteNode.AppendChild(porcentajeBecaNode)

            Dim curso_MatriculadoNode As XmlNode = xmlArchivo.CreateElement("Cursos_Matriculados")
            curso_MatriculadoNode.InnerText = estudiante.Curso_Matriculado.ToString()
            estudianteNode.AppendChild(curso_MatriculadoNode)

            rootNode.AppendChild(curso_MatriculadoNode)
        Next

        xmlArchivo.Save(rutaXml)
    End Sub
    Public Shared Function Leer_Est() As List(Of Estudiante)
        Dim ObtenerRutaXml_Estu As String = rutaArchivoXml_Est()
        Dim xmlArchivo As New DataTable
        xmlArchivo.ReadXml(ObtenerRutaXml_Estu)

        Dim estudiantes As List(Of Estudiante)

        For Each filaArchivo As DataRow In xmlArchivo.Rows
            Dim Estudiante As New Estudiante()


            Estudiante.Nombre = filaArchivo("Nombre").ToString
            Estudiante.primerApellido = filaArchivo("Primer_Apellido").ToString
            Estudiante.segundoApellido = filaArchivo("Segundo_Apellido").ToString
            Estudiante.fechaNacimiento = DateTime.Parse(filaArchivo("Fecha_Nacimiento").ToString)
            Estudiante.Identificacion = Integer.Parse(filaArchivo("ID").ToString())
            Estudiante.direccionExacta = filaArchivo("Direccion_exacta").ToString
            Estudiante.CarreraMatriculada = filaArchivo("Carrera").ToString
            Estudiante.email = filaArchivo("Email").ToString
            Estudiante.telefono = Integer.Parse(filaArchivo("Telefono").ToString())
            Estudiante.TieneBeca = filaArchivo("Beca").ToString()
            Estudiante.porcentaje_Beca = filaArchivo("Porcentaje").ToString()
            estudiantes.Add(Estudiante)
        Next

        Return estudiantes

    End Function

    Public Shared Sub Modificar_Estu(Estudiantes As List(Of Estudiante))
        Dim ObtenerRutaXml As String = rutaArchivoXml_Est()
        Dim dataSet As New DataSet()

        dataSet.ReadXml(ObtenerRutaXml)

        If dataSet.Tables.Count > 0 Then
            Dim xmlArchivo As DataTable = dataSet.Tables(0)

            For Each estudiante In Estudiantes
                Dim rows() As DataRow = xmlArchivo.Select("ID = '" & estudiante.Identificacion & "'")

                If rows.Length > 0 Then
                    Dim row As DataRow = rows(0)

                    row("Nombre") = estudiante.Nombre
                    row("Primer_Apellido") = estudiante.primerApellido
                    row("Segundo_Apellido") = estudiante.segundoApellido
                    row("FechaNacimiento") = estudiante.FechaNacimiento.ToString()
                    row("Email") = estudiante.email
                    row("Direccion_Exacta") = estudiante.direccionExacta
                    row("Carrera") = estudiante.CarreraMatriculada
                    row("Telefono") = estudiante.telefono
                    row("Beca") = estudiante.TieneBeca
                    row("Porcentaje_Beca") = estudiante.porcentaje_Beca.ToString()
                End If
            Next

            dataSet.WriteXml(ObtenerRutaXml)
        End If
    End Sub

    Private Shared estudiantesXml As New List(Of Estudiante)()

    Public Shared Sub AgregarEstudiante(estudiante As Estudiante)
        estudiantesXml.Add(estudiante)
    End Sub
    Public Shared Function obtenerEstudianteXml() As List(Of Estudiante)

        Return estudiantesXml
    End Function

    ''carreras

    Private Shared Function rutaArchivoXml_Carreras() As String
        Return ConfigurationManager.AppSettings("Ruta archivo Carreras")
    End Function
    Private Shared Function CrearTabla_Carreras() As DataTable
        Dim dtCarreras As New DataTable("Carreras")
        dtCarreras.Columns.Add("Carrera", GetType(String))
        dtCarreras.Columns.Add("Codigo", GetType(String))
        dtCarreras.Columns.Add("Grado", GetType(String))
        dtCarreras.Columns.Add("Estado", GetType(String))
        dtCarreras.Columns.Add("Periodo", GetType(DataTable))


        Return dtCarreras
    End Function
    Private Shared Function CrearTabla_Cursos() As DataTable
        Dim dtCursos As New DataTable("Cursos")
        dtCursos.Columns.Add("Nombre", GetType(String))
        dtCursos.Columns.Add("Codigo", GetType(String))
        dtCursos.Columns.Add("Creditos", GetType(Integer))
        dtCursos.Columns.Add("Cupos_Maximos", GetType(Integer))
        dtCursos.Columns.Add("Cupos_Minimos", GetType(Integer))
        dtCursos.Columns.Add("Grado", GetType(String))
        dtCursos.Columns.Add("Estado", GetType(String))
        dtCursos.Columns.Add("Costo", GetType(Decimal))



        Return dtCursos
    End Function

    Private Shared Sub AgregarCarrera(xmlArchivo As DataSet, carrera As String, codigo As String, grado As String, estado As String, dtCursos As DataTable)
        Dim drCarrera As DataRow = xmlArchivo.Tables("Carreras").NewRow()
        drCarrera("Carrera") = carrera
        drCarrera("Codigo") = codigo
        drCarrera("Grado") = grado
        drCarrera("Estado") = estado
        drCarrera("Periodo") = dtCursos

        xmlArchivo.Tables("Carreras").Rows.Add(drCarrera)
    End Sub


    Public Shared Sub GrabarXml_Carreras(Carreras As List(Of Carrera))
        Dim ObtenerRutaXml As String = rutaArchivoXml_Carreras()
        Dim xmlArchivo As New DataSet()
        Dim dtCarreras As DataTable = CrearTabla_Carreras()
        xmlArchivo.Tables.Add(dtCarreras)


        AgregarCarrera(xmlArchivo, "Tecnologias de informacion con enfasis en desarrollo, ciberseguridad o bigdata", "TI-000", "Bachillerado", "Activo", CrearTabla_Cursos())
        AgregarCarrera(xmlArchivo, "Enfermeria", "EF-000", "Bachillerado", "Activo", CrearTabla_Cursos())
        AgregarCarrera(xmlArchivo, "Medicina general", "MG-000", "Bachillerado", "Activo", CrearTabla_Cursos())
        AgregarCarrera(xmlArchivo, "Administracion de empresas con Enfasis en Administracion Publica o Finanzas", "AD-000", "Bachillerado", "Activo", CrearTabla_Cursos())
        AgregarCarrera(xmlArchivo, "Derecho", "DE-000", "Bachillerado", "Activo", CrearTabla_Cursos())

        xmlArchivo.WriteXml(ObtenerRutaXml)

    End Sub
    Public Shared Function Leer_Carreras() As List(Of Carrera)


    End Function

    Public Shared Sub Modificar_Cursos(cursos As List(Of Carrera))

        Dim ObtenerRutaXml As String = rutaArchivoXml_Carreras()
        Dim dataSet As New DataSet()

        dataSet.ReadXml(ObtenerRutaXml)

        If dataSet.Tables.Count > 0 Then
            Dim xmlArchivo As DataTable = dataSet.Tables(0)

            For Each curso In cursos
                Dim rows() As DataRow = xmlArchivo.Select("Codigo = '" & curso.Codigo_Curso & "'")

                If rows.Length > 0 Then
                    Dim row As DataRow = rows(0)

                    row("Nombre") = curso.Nombre_Curso
                    row("Codigo") = curso.Codigo_Curso
                    row("Credito") = curso.creditos_Curso
                    row("Cupos_Maximos") = curso.Cupos_maximo
                    row("Cupos_Minimos") = curso.Cupos_minimo
                    row("Grado") = curso.grado_Carrera
                    row("Estado") = curso.estado_De_Curso
                    row("Costo") = curso.costo_Matricula
                End If
            Next

            dataSet.WriteXml(ObtenerRutaXml)
        End If

    End Sub

    Private Shared CarrerasXml As New List(Of Carrera)()

    Public Shared Sub AgregarCursos(carreras As Carrera)
        CarrerasXml.Add(carreras)
    End Sub
    Public Shared Function obtenerCarrerasXml() As List(Of Carrera)

        Return CarrerasXml
    End Function

End Class
