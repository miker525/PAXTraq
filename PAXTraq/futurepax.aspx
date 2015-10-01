<%@ Page Title="Upcoming Events" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="futurepax.aspx.vb" Inherits="PAXTraq.futurepax" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div id="futurepaxleft">
        <br />
        <a href="http://prime.paxsite.com"><img src="images/content/palogos/paxprimelogo.png" alt="PAX Prime" /></a><br /><br />
        <asp:Label ID="Primed" Text="" runat="server" /><br /><br /><br /><br />
        <a href="http://south.paxsite.com"><img src="images/content/palogos/paxsouthlogo.png" alt="PAX South" /></a><br /><br /><br />
        <asp:Label ID="Southd" Text="" runat="server" /><br /><br /><br /><br />
    </div>
    <div id="futurepaxright">
        <br />
        <a href="http://east.paxsite.com"><img src="images/content/palogos/paxeastlogo.png" alt="PAX East" /></a><br /><br />
        <asp:Label ID="Eastd" Text="" runat="server" /><br /><br /><br />
        <a href="http://aus.paxsite.com"><img src="images/content/palogos/paxauslogo.png" alt="PAX Aus" /></a><br /><br />
        <asp:Label ID="Ausd" Text="" runat="server" /><br /><br /><br /><br />
    </div>

</asp:Content>
