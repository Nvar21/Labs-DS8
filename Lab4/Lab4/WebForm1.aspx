<%@ Page Language="VB" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="Lab4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" />
    <title>Laboratorio 4</title>

    <style>
        body {
            font-family: 'Arial', sans-serif;
            line-height: 1.6;
            margin: 20px;
        }

        .container {
            top: 50%;
        }

        .txt {
            border: 2px dashed #ccc;
            padding: 20px;
            margin: 20px;
            max-width: 600px;
            margin-left: auto;
            margin-right: auto;
            display: flex;
            align-items: center;
        }

        .txt h5 {
            writing-mode: vertical-lr;
            background-color: aquamarine;
            padding: 15px;
            word-spacing: 2px;
            letter-spacing: 1.2px;
            transform: rotate(180deg);
        }

        .txt p {
            text-align: justify;
            letter-spacing: 0.6px;
            padding-left: 10px;
            box-sizing: border-box;
            flex-grow: 1;
        }
    </style>
</head>

<body>
    <form id="form1" runat="server">
        <div>
            <!-- navbar -->
            <nav class="navbar navbar-expand-lg navbar-light bg-light">
                <a class="navbar-brand" href="#">Laboratorio 4</a>
                <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
                <div class="collapse navbar-collapse" id="navbarNav">
                    <ul class="navbar-nav">
                        <li class="nav-item active">
                            <a class="nav-link" href="WebForm1.aspx">Enunciado 1 <span class="sr-only">(current)</span></a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="WebForm2.aspx">Enunciado 2</a>
                        </li>
                    </ul>
                </div>
            </nav>

            <!-- elementos del frm -->
            <div class="container text-center">
                <br />
                <asp:Label ID="Label1" runat="server" Text="Ingrese el costo inicial:   "></asp:Label>
                <asp:TextBox ID="txtCosto" runat="server" CssClass="form-control"></asp:TextBox> 
                <br /> 
                <asp:Button ID="btnCalcular" runat="server" Text="Calcular" OnClick="btnCalcular_Click" CssClass="btn btn-primary"/>
                <br />
                <br />
                <asp:Label ID="txtResult" runat="server" Text="" CssClass="text-info"></asp:Label>
            </div>

            <!-- texto enunciado -->
            <div class="txt">
                <h5>Enunciado 1</h5>
                <p>
                   El costo de un automóvil nuevo para el consumidor es la suma total del costo del vehículo, del porcentaje de ganancia del vendedor y de los impuestos locales o estatales aplicables (sobre el precio de venta). Supóngase una ganancia del vendedor del 12% en todas las unidades y un impuesto del 6%. Diséñese un sistema para leer el costo del automóvil e imprimir el costo final para el consumidor.
                </p>
            </div> 
        </div>
    </form>

    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.9.3/dist/umd/popper.min.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
</body>
</html>

