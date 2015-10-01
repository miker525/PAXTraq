<%@ Page Title="PAX Traq - Home" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="PAXTraq._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div id="content1">
        <br />
        Date & Bootstrap Button Example:<br />
        <asp:Label ID="lToday" Text="" runat="server"/><br /><br />
        <asp:Label ID="llToday" Text="" runat="server" /><br /><br />
        <asp:Label ID="lTomorrow" Text="" runat="server" /><br /><br />
        <button id="bRefresh" class="btn btn-primary" runat="server" onclick="refresh" >
            <span aria-hidden=true class="glyphicon glyphicon-refresh"></span> Refresh
        </button><br /><hr /><br />
        Calendar Clicky example<br />
        <asp:Label ID="callbl" Text="Calendar" runat="server" /><br />
        <center><asp:Calendar ID="Calendar" runat="server" OnSelectionChanged="calfunc" /></center><br /><hr /><br />
        Checkbox Example:<br />
        <center><asp:RadioButtonList ID="rdiolst" runat="server" OnSelectedIndexChanged="radiofunc" AutoPostBack="true" >
            <asp:ListItem Text="One" Value="One"></asp:ListItem>
            <asp:ListItem Text="Two" Value="Two"></asp:ListItem>
        </asp:RadioButtonList></center>
        <asp:Label ID="rdiolbl" Text="You Selected None" runat="server" /><br /><hr /><br />
        Panel/Image/Button<br />
        <asp:Panel ID="pane" runat="server" ScrollBars="Auto" Direction="LeftToRight">
            <img src="http://mikerosenberger.com/me.jpg" alt="Mike" />
        </asp:Panel><br />
        <asp:Button ID="panebutton" runat="server" OnClick="paneclk" Text="Show" />
        <br /><br />
        <asp:ScriptManagerProxy ID="ScriptManagerProxy1" runat="server">
            <Services>
                <asp:ServiceReference Path="~/WebServices/ptraq.svc" />
            </Services>
        </asp:ScriptManagerProxy>
         <input id="rNumb" type="button" value="Get Tow Random Numbers added together Into One Random Number" onclick="rNumber();" /><br /><br />
         <input id="Name" type="text"/>
         <input id="SayHello" type="button" value="Say Hello" onclick="helloWorld();" />
        <!-- Tried to hook it up to SQL db but having issues adding items. Not sure why. Getting error messages. -->
        <br />
        <br />
        <br />
        <br />
        I do not claim to own any rights to any of the PAX logos used.<br />
        Penny Arcade, Penny Arcade Expo, PAX and all associated images are all &copy; Copyright 1998 - 2014 PENNY ARCADE, INC.
        <script>
            function helloWorld() {
                var yourName = document.getElementById("Name").value;
                ptraq.HelloWorld(yourName, genericCallback);
            }
            function rNumber() {
                ptraq.DoWork(genericCallback)
            }
            function genericCallback(result) {
                alert(result);
            }
        </script>
    </div>
</asp:Content>
