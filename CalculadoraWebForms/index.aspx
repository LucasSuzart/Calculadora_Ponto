<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="CalculadoraWebForms.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script language="JavaScript">
        function keyPressed(evt) {
            evt = evt || window.event;
            var key = evt.keyCode || evt.which;
            return String.fromCharCode(key);
        }

        document.onkeypress = function (evt) {
            var str = keyPressed(evt);
            if (str == "+") {
                //$("#historico").val();
                document.getElementById("historico").innerText = document.getElementById("txtResultado").value;
                document.getElementById("numeroAnterior").value = document.getElementById("txtResultado").value;
                document.getElementById("txtResultado").value = "";
                document.getElementById("lblOperacao").value = "+";
               
              
            }
            
           
        };
    </script>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <h1>Calculadora</h1>
    <form id="form1" runat="server">
        <div>
           
            <br/>
            <asp:Label ID="Informacoes" runat="server">Calculadora só está funcionando pelo teclado virtual</asp:Label> <br />
            <asp:Label ID="historico" runat="server"></asp:Label> <br />
            <asp:TextBox ID="txtResultado" runat="server"></asp:TextBox>
            <asp:HiddenField ID="lblOperacao" runat="server" ></asp:HiddenField>
            <asp:HiddenField ID="numeroAnterior" runat="server" ></asp:HiddenField>
            <br />
          
            <br/>
                  
         
           
            <br />
           
            
             <asp:Button ID="btnSete" runat="server" Text="7"  Width="57px" OnClick="btnSete_Click" />
            <asp:Button ID="btnOito" runat="server" Text="8"  Width="57px" OnClick="btnOito_Click" />           
            <asp:Button ID="btnNove" runat="server" Text="9"  Width="57px" OnClick="btnNove_Click" />
            <asp:Button ID="btnMultiplicar" runat="server" Text="X"  OnClick="btnMultiplicar_Click"  Width="57px"  /><br />
            
           
            <asp:Button ID="btnQuatro" runat="server" Text="4"  Width="57px" OnClick="btnQuatro_Click" />
             <asp:Button ID="btnCinco" runat="server" Text="5"  Width="57px" OnClick="btnCinco_Click" />
            <asp:Button ID="btnSeis" runat="server" Text="6"  Width="57px" OnClick="btnSeis_Click" />
             <asp:Button ID="btnSubtrair" runat="server" Text="-" Width="57px" OnClick="btnSubtrair_Click" /><br />
            <asp:Button ID="btnUm" runat="server" Text="1" Width="57px" OnClick="btnUm_Click" />
            <asp:Button ID="btnDois" runat="server" Text="2"  Width="57px" OnClick="btnDois_Click" />
            <asp:Button ID="btnTres" runat="server" Text="3"  Width="57px" OnClick="btnTres_Click" />
             <asp:Button ID="btnSomar" runat="server" Text="+" OnClick="btnSomar_Click" Width="57px" /><br />
             <asp:Button ID="btnDividir" runat="server" Text="/" OnClick="btnDividir_Click"  Width="57px"  />
           
             <asp:Button ID="btnZero" runat="server" Text="0" Width="57px" OnClick="btnZero_Click" />
             <asp:Button ID="btnIgual" runat="server" Text="=" Width="57px" OnClick="btnIgual_Click"  />
            
          
            <br />&nbsp;</div>
        
  

            </form>

          
</body>
</html>
