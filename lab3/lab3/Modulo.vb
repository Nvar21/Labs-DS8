Imports MySql.Data.MySqlClient
Module Modulo

    'funcion para poner datos a combobox de frmTransacciones.
    Function obtener_clientes()
        conexionDB()
        myConn.Open()
        Dim glCommand As New MySqlCommand

        glCommand.Connection = myConn
        glCommand.CommandText = "SP_obtener_clientes"
        glCommand.CommandTimeout = 0
        glCommand.CommandType = CommandType.StoredProcedure
        Try
            glCommand.ExecuteNonQuery()
            ' Crear una lista para almacenar instancias de Cliente
            Dim listaClientes As New List(Of Cliente)
            Using sqlReader As MySqlDataReader = glCommand.ExecuteReader()

                ' Leer los datos y crear instancias de la clase Cliente
                While sqlReader.Read()
                    Dim cliente As New Cliente With {
                            .id_cliente = Convert.ToInt32(sqlReader("id_cliente")),
                            .nombre = sqlReader("nombre").ToString(),
                            .apellido = sqlReader("apellido").ToString(),
                            .IdNombreApellido = sqlReader("idNombreCompleto").ToString(),
                            .telefono_movil = sqlReader("telefono_movil").ToString(),
                            .direccion = sqlReader("direccion").ToString()
                        }
                    ' Agregar la instancia de Cliente a la lista
                    listaClientes.Add(cliente)
                End While
            End Using
            Return listaClientes

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            If myConn.State <> ConnectionState.Closed Then myConn.Close()
        End Try
    End Function

    Function obtener_cuentas(ByVal p_id_cliente As Integer)
        conexionDB()
        myConn.Open()
        Dim glCommand As New MySqlCommand

        glCommand.Connection = myConn
        glCommand.CommandText = "SP_obtener_cuentas_cliente"
        glCommand.Parameters.AddWithValue("p_id_cliente", p_id_cliente)
        glCommand.CommandTimeout = 0
        glCommand.CommandType = CommandType.StoredProcedure
        Try
            glCommand.ExecuteNonQuery()
            ' Crear una lista para almacenar instancias de Cliente
            Dim listaCuenta As New List(Of Cuenta)
            Using sqlReader As MySqlDataReader = glCommand.ExecuteReader()

                ' Leer los datos y crear instancias de la clase Cliente
                While sqlReader.Read()
                    Dim cuenta As New Cuenta With {
                            .id_cuenta = Convert.ToInt32(sqlReader("id_cuenta")),
                            .id_cliente = Convert.ToInt32(sqlReader("id_cliente")),
                            .IdTipoSaldo = sqlReader("IdTipoSaldo").ToString(),
                            .tipo = sqlReader("tipo").ToString(),
                            .saldo = Convert.ToDouble(sqlReader("saldo"))
                        }
                    ' Agregar la instancia de Cliente a la lista
                    listaCuenta.Add(cuenta)
                End While
            End Using
            Return listaCuenta

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            If myConn.State <> ConnectionState.Closed Then myConn.Close()
        End Try
    End Function

    Function realizar_deposito(ByVal p_id_cuenta As Integer, ByVal p_saldo As Double)
        conexionDB()
        myConn.Open()
        Dim glCommand As New MySqlCommand

        glCommand.Connection = myConn
        glCommand.CommandText = "SP_realizar_deposito"
        glCommand.Parameters.AddWithValue("p_id_cuenta", p_id_cuenta)
        glCommand.Parameters.AddWithValue("p_saldo", p_saldo)
        glCommand.CommandTimeout = 0
        glCommand.CommandType = CommandType.StoredProcedure
        Try
            glCommand.ExecuteNonQuery()
            MsgBox("Depósito procesado exitosamente")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            If myConn.State <> ConnectionState.Closed Then myConn.Close()
        End Try
    End Function

    Function realizar_retiro(ByVal p_id_cuenta As Integer, ByVal p_saldo As Double)
        conexionDB()
        myConn.Open()
        Dim glCommand As New MySqlCommand

        glCommand.Connection = myConn
        glCommand.CommandText = "SP_realizar_retiro"
        glCommand.Parameters.AddWithValue("p_id_cuenta", p_id_cuenta)
        glCommand.Parameters.AddWithValue("p_saldo", p_saldo)
        glCommand.CommandTimeout = 0
        glCommand.CommandType = CommandType.StoredProcedure
        Try
            glCommand.ExecuteNonQuery()
            MsgBox("Retiro procesado exitosamente")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            If myConn.State <> ConnectionState.Closed Then myConn.Close()
        End Try
    End Function

    Function crear_cuenta(ByVal p_id_cliente As Integer, ByVal p_tipo As String, ByVal p_saldo As Double)
        conexionDB()
        myConn.Open()
        Dim glCommand As New MySqlCommand
        glCommand.Connection = myConn
        glCommand.CommandText = "SP_crear_cuenta"
        glCommand.Parameters.AddWithValue("p_id_cliente", p_id_cliente)
        glCommand.Parameters.AddWithValue("p_tipo", p_tipo)
        glCommand.Parameters.AddWithValue("p_saldo", p_saldo)
        glCommand.CommandTimeout = 0
        glCommand.CommandType = CommandType.StoredProcedure
        Try
            glCommand.ExecuteNonQuery()
            MsgBox("Cuenta creada exitosamente")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            If myConn.State <> ConnectionState.Closed Then myConn.Close()
        End Try
    End Function

    Function crear_cliente(ByVal p_nombre As String, ByVal p_apellido As String, ByVal p_telefono As String, ByVal p_direccion As String)
        conexionDB()
        myConn.Open()
        Dim glCommand As New MySqlCommand
        glCommand.Connection = myConn
        glCommand.CommandText = "SP_crear_cliente"
        glCommand.Parameters.AddWithValue("p_nombre", p_nombre)
        glCommand.Parameters.AddWithValue("p_apellido", p_apellido)
        glCommand.Parameters.AddWithValue("p_telefono", p_telefono)
        glCommand.Parameters.AddWithValue("p_direccion", p_direccion)
        glCommand.CommandTimeout = 0
        glCommand.CommandType = CommandType.StoredProcedure
        Try
            glCommand.ExecuteNonQuery()
            MsgBox("Cliente creado exitosamente")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            If myConn.State <> ConnectionState.Closed Then myConn.Close()
        End Try
    End Function


    Function obtener_movimientos_cliente(ByVal p_id_cliente As Integer)
        conexionDB()
        myConn.Open()
        Dim glCommand As New MySqlCommand

        glCommand.Connection = myConn
        glCommand.CommandText = "SP_obtener_movimientos_cliente"
        glCommand.Parameters.AddWithValue("p_id_cliente", p_id_cliente)
        glCommand.CommandTimeout = 0
        glCommand.CommandType = CommandType.StoredProcedure
        Try
            glCommand.ExecuteNonQuery()
            ' Crear una lista para almacenar instancias de Cliente
            Dim listaMovimientos As New List(Of Movimiento)
            Using sqlReader As MySqlDataReader = glCommand.ExecuteReader()

                ' Leer los datos y crear instancias de la clase Cliente
                While sqlReader.Read()
                    Dim movimiento As New Movimiento With {
                            .id_movimiento = Convert.ToInt32(sqlReader("id_movimiento")),
                            .id_cuenta = Convert.ToInt32(sqlReader("id_cuenta")),
                            .deposito = Convert.ToDouble(sqlReader("deposito")),
                            .retiro = Convert.ToDouble(sqlReader("retiro")),
                            .fecha = sqlReader("fecha").ToString()
                        }
                    ' Agregar la instancia de Cliente a la lista
                    listaMovimientos.Add(movimiento)
                End While
            End Using
            Return listaMovimientos

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            If myConn.State <> ConnectionState.Closed Then myConn.Close()
        End Try
    End Function

End Module