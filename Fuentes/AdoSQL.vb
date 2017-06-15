Imports System.Data.SqlClient

Public Class AdoSQL

    Private m_Nombre As String
    Private Cont As Long
    Private Filas() As DataRow
    Private Adaptador As SqlDataAdapter
    Private CBuiler As SqlCommandBuilder
    Private Datatabla As DataTable
    Private Reg As DataRow
    Private NewReg As String = ""
    Private Conexion As String
    Public RecordSet As DataRow
    Private UltimaConsulta As String
    Private Ds As DataSet

    Public Sub New(ByVal elnombre As String, ByVal RutaConn As String)
        MyBase.New()
        m_Nombre = elnombre
        If String.IsNullOrEmpty(elnombre) Then
            Throw New ArgumentException( _
                        "El nombre del control no puede ser una cadena vacía")
        End If
    End Sub
    Public Sub New(ByVal elnombre As String)
        MyBase.New()
        m_Nombre = elnombre
        Conexion = RutaDB
    End Sub

    Public Sub Open(ByVal Consulta As String)
        Try
            If String.IsNullOrEmpty(Consulta) Then
                Throw New ArgumentException( _
                            "La Consulta no puede ser una cadena vacía")
            End If
            Adaptador = New SqlDataAdapter(Consulta, Conexion)
            CBuiler = New SqlCommandBuilder(Adaptador)
            Ds = New DataSet
            Datatabla = New DataTable
            Adaptador.Fill(Datatabla)
            Adaptador.Fill(Ds, "Tabla")
            NewReg = ""
            RecordSet = Nothing
            If Datatabla.Rows.Count > 0 Then RecordSet = Datatabla.Rows(0)
            UltimaConsulta = Consulta

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub
    Public Sub Update()
        Try
            If NewReg = "NEW" Then Datatabla.Rows.Add(Me.RecordSet)
            Adaptador.Update(Datatabla)
            Datatabla.AcceptChanges()
            NewReg = ""
            RecordSet = Nothing
            If Datatabla.Rows.Count > 0 Then RecordSet = Datatabla.Rows(0)

            'Evento("Crea o actualiza registro en tabla " + Me.m_Nombre + DataTable.Rows(0).ItemArray.ToString)

        Catch DBexep As DBConcurrencyException

            If Datatabla.GetChanges Is Nothing Then
                RecordSet = Nothing
                NewReg = ""
                Dim MessageError As String
                MessageError = "Concurrency violation" & vbCrLf
                MessageError &= CType(DBexep.Row.Item(0), String) + MessageError + " " + CType(DBexep.Row.Item(1), String)
                'MsgError("Ninguna fila disponible para actualizar " + Me.m_Nombre + " " + MessageError)
                Evento("Ninguna fila disponible para actualizar " + Me.m_Nombre + " " + MessageError)
            Else
                Dim Index As Int16 = Datatabla.Rows.IndexOf(DBexep.Row)
                Datatabla = New DataTable
                Adaptador.Fill(Datatabla)
                NewReg = ""
                RecordSet = Datatabla.Rows(Index)
                For i = 0 To RecordSet.ItemArray.Count - 1
                    RecordSet(i) = DBexep.Row(i)
                Next
                'Actualizamos nuevamente el registro con los datos enviados inicialmente
                Adaptador.Update(Datatabla)
                Datatabla.AcceptChanges()
                NewReg = ""
                RecordSet = Nothing
                If Datatabla.Rows.Count > 0 Then RecordSet = Datatabla.Rows(0)
            End If

        Catch ex As Exception
            MsgError(ex.ToString + "  " + Me.m_Nombre)
            RecordSet = Nothing
            NewReg = ""
        End Try
    End Sub


    Public Sub Refresh()
        Try
            If String.IsNullOrEmpty(UltimaConsulta) Then
                Throw New ArgumentException( _
                            "La Consulta no puede ser una cadena vacía")
            End If
            Ds = New DataSet
            Datatabla = New DataTable
            Adaptador.Fill(Datatabla)
            Adaptador.Fill(Ds, "Tabla")
            NewReg = ""
            RecordSet = Nothing
            If Datatabla.Rows.Count > 0 Then RecordSet = Datatabla.Rows(0)

        Catch ex As Exception
            RecordSet = Nothing
            MsgError(ex.ToString)
        End Try
    End Sub

    Public Sub Delete(ByVal Consulta As String)
        Try

            If String.IsNullOrEmpty(Consulta) Then
                Throw New ArgumentException( _
                            "La Consulta no puede ser una cadena vacía")
            End If

            Consulta = Replace(Consulta.ToUpper, "DELETE", "Select * ")

            Adaptador = New SqlDataAdapter(Consulta, Conexion)
            CBuiler = New SqlCommandBuilder(Adaptador)

            Datatabla = New DataTable
            Adaptador.Fill(Datatabla)

            If Me.RecordCount = 0 Then Return

            For Each R As DataRow In Datatabla.Rows
                R.Delete()
            Next
            Update()

            'Opcional por si se necesita
            'If m_Conexion.State <> ConnectionState.Open Then m_Conexion.Open()
            'm_Conexion.CreateCommand.CommandText = Consulta
            'm_Conexion.CreateCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub
    Public Function Find(ByVal Filtro As String) As DataRow

        If String.IsNullOrEmpty(Filtro) Then
            Throw New ArgumentException( _
                        "El Filtro no puede ser una cadena vacía")
        End If

        If Me.RecordCount = 0 Then
            Find = Nothing
            NewReg = "EDIT"
            RecordSet = Nothing
            Exit Function
        End If

        Filas = Me.DataTable.Select(Filtro)
        If Filas.Length = 0 Then
            Find = Nothing
            NewReg = "EDIT"
            RecordSet = Nothing
        Else
            Find = Filas(0)
            NewReg = "EDIT"
            RecordSet = Filas(0)
        End If

    End Function

    Public Sub AddNew()
        If (Me.UltimaConsulta = "") Then
            Throw New ArgumentException( _
                        "No se puede crear el registro actual")
        End If
        NewReg = "NEW"
        RecordSet = Datatabla.NewRow
    End Sub
#Region "Propiedades de la Clase AdoSql"
    Public ReadOnly Property RecordCount() As Long

        Get
            If Not IsNothing(Datatabla) AndAlso Datatabla.Rows.Count > 0 Then
                Cont = Datatabla.Rows.Count
            Else
                Cont = 0
            End If
            RecordCount = Cont
        End Get

    End Property

    Public ReadOnly Property EOF() As Boolean
        Get
            If Not IsNothing(Me.RecordSet) Then
                EOF = False
            Else
                EOF = True
            End If
        End Get
    End Property
    Public ReadOnly Property DataTable() As DataTable
        Get
            DataTable = Me.Datatabla
        End Get
    End Property
    Public ReadOnly Property DataSet() As DataSet
        Get
            DataSet = Me.Ds
        End Get
    End Property
    Public ReadOnly Property DataAdapter() As SqlDataAdapter
        Get
            DataAdapter = Me.Adaptador
        End Get
    End Property
    Public ReadOnly Property Rows() As DataRowCollection
        Get
            Rows = Me.Datatabla.Rows
        End Get
    End Property
    Private Property Record() As DataRow
        Get
            Record = Reg
        End Get
        Set(ByVal value As DataRow)
            Reg = value
        End Set
    End Property

#End Region

End Class
