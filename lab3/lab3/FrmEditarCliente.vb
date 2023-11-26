Public Class FrmEditarCliente
    Dim datosEditablesCliente As Dictionary(Of String, String)
    Dim inicializandoFormulario As Boolean = True
    ' variables de datos que vienen del formulario frmEditarCliente
    Dim nombre, apellido, telefono, direccion As String
    Dim id_cliente As Integer

    Private Sub FrmEditarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicializandoFormulario = False
    End Sub

    ' Constructor que recibe el diccionario
    Public Sub New(diccionario As Dictionary(Of String, String))
        InitializeComponent()
        ' Guardar el diccionario en una variable de clase para su uso posterior
        datosEditablesCliente = diccionario

        id_cliente = diccionario("id")
        nombre = diccionario("nombre")
        apellido = diccionario("apellido")
        telefono = diccionario("telefono_movil")
        direccion = diccionario("direccion")

        ' asignar a txboxs datos del diccionario
        txtNombre.Text = nombre
        txtApellido.Text = apellido
        txtTelefono.Text = telefono
        txtDireccion.Text = direccion
    End Sub
    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged, txtApellido.TextChanged, txtTelefono.TextChanged, txtDireccion.TextChanged
        Dim textBox As TextBox = TryCast(sender, TextBox)
        If Not inicializandoFormulario AndAlso textBox IsNot Nothing Then
            If Not datosEditablesCliente.ContainsValue(textBox.Text) Then
                textBox.BackColor = Color.FromArgb(237, 203, 81)
            End If
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        'logica pa guardar
        actualizar_cliente(id_cliente, txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtDireccion.Text)
        'cierra el form
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        'cierra el form
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub



End Class