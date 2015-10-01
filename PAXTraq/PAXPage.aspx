<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="PAXPage.aspx.vb" Inherits="PAXTraq.PAXPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <center><br />
        <img src="<%=iurl()%>"
        <br /><br />

       <div style="font-size: 20px;"> Maps: <br /><br /></div>
        <asp:Repeater ID="RepeaterImages" runat="server">
            <ItemTemplate>
                 <a href='<%# Container.DataItem%>' rel="lightbox" runat="server"><asp:Image ID="Image" runat="server" class="top_up" ImageUrl='<%# Container.DataItem%>' Width="150" Height="150" /></a>
            </ItemTemplate>
        </asp:Repeater>
        <br /><br />

        <div style="font-size: 20px;">Exhibitors: <br /><br /></div>
        <div style="color:red; font-size: 14px;">
            <asp:Repeater ID="RepeaterExhibitors" runat="server">
            <ItemTemplate>
                <%# Container.DataItem%><br /><br />
            </ItemTemplate>
        </asp:Repeater>
        </div>
        <br /><br />

        <div style="font-size: 20px;">Concerts: <br /><br /></div>
        <div style="color:red; font-size: 14px;">
            <asp:Repeater ID="RepeaterConcerts" runat="server">
            <ItemTemplate>
                <%# Container.DataItem%><br /><br />
            </ItemTemplate>
        </asp:Repeater>
        </div>
        <br />

        <div style="font-size: 20px;">Swag:</div> <br /><br />
         <asp:DropDownList ID="DropDownListSwag" runat="server"></asp:DropDownList> <br /><br />

    </center>
</asp:Content>
