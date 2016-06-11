<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Ksiega_gosci.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Słówka</title>
    <style type="text/css">
        .auto-style1 {
            color: #0066FF;
            font-size: 40pt;
            font-family:'Times New Roman';
        }
        .auto-style2 {
            font-size: medium;
        }
        .auto-style3 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 521px" class="auto-style3">
    
        `<span class="auto-style1">Gra w słóweczka</span><br />
        <br />
        <asp:Label ID="Label1" runat="server" Font-Size="Large">maszkara</asp:Label>
    
        <br />
        <br />
        Wpisz słowo które zaczyna sie na ostatnią literę słowa powyżej.<br />
        <asp:TextBox ID="TextBox2" runat="server" Height="100px" TextMode="MultiLine" ToolTip="KOmentarz" Width="300px" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Wyślij" OnClick="Button1_Click" />
    
        <br />
 <span class="auto-style2">ZASADY<br />
        <br />
        Gra polega na tym aby wymyślić polski rzeczownik w liczbie pojedyńczej ktory zaczyna sie na litere ostatniej litery rzeczownika podanego przez program (słowo pod napisem &quot;Gra w słóweczka&quot;). W grze nie można podawać polskich znaków, należy je zastępować literami podobnymi np: zamiast &quot;ż&quot; piszemy &quot;z&quot;. Rzeczownik piszemy z małej litery. Program nie ma wbudowanego sprawdzania czy wyraz jest faktycznie wyrazem, a nie zlepkiem przypadkowych znakow. Dlatego rzeczowniki najlepiej sprawdzać w słowniku języka polskiego. Wyjątkiem są rzeczowniki zaczynające się na litere &quot;Y&quot; - ponieważ w języku polskim jest tylko jedn rzeczownik zaczynający się na litere &quot;Y&quot;. W zamian za to można używać rzeczowników zaczynających się na litere &quot;Y&quot; z języka angielskiego.<br />
        <br />
        </span>
    
    </div>
    </form>
</body>
</html>
