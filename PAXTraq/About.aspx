<%@ Page Title="About" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.vb" Inherits="PAXTraq.About"  ViewStateMode="Enabled" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <div id="about">
        <div id="header">
            About
        </div><br />
            PAX Traq is run by attendees for attendees. It is a fan effort to collect and share as much information about the Penny Arcade Expo's as possible all from one convenient location. If you have content to add, issues with what we are doing, or just simply want to say hello, please use the contact form below. We are not directly associated with other PAX community websites, but they are great resources built of great communities and we highly recommend them. <br /><a href="http://paxcommunity.net">The Official Unofficial PAX Community</a> || <a href="http://http://forums.penny-arcade.com/categories/pax-general-discussion">The Official PAX Community Forums</a><br /><br /><br />
        <div id="header">
            Donations
        </div><br />
            Paying for hosting isn't cheap and developing PAX Traq brings in no money. PAX Traq is my gift to you PAXers and I'm proud of that. If you would however like to donate money all of your cash will flow directly into the webhosting, or to buy myself taco's so I don't starve while working on the site. You may donate via the methods below, or by submitting content to help the site grow. Or you don't have to do anything. Either way I sincerly thank you for being a visitor and for being an awesome PAXer. <br /><br /><br />
        <div id="header">
            Contact
        </div><br />
        <asp:Panel ID="paner" runat="server">
        Please fill out the form below to send us your message<br /><br />
        <div class="contact" align="center">
                <label for="Name" class="control-label" role="navigation">Name: </label>
                <input class="form-control" name="Name" id="Fname" type="text" placeholder="Your name" required runat="server"><br />
                <label for="Email" class="control-label" role="navigation">Email: </label>
                <input class="form-control" name="Email" id="Email" type="email" placeholder="Your email" required runat="server"><br />
                <label for="regards" class="control-label" role="navigation">Regarding: </label>
                <select class="form-control" name="regards" id="regards" placeholder="Regarding" runat="server" optional="True">
                    <option value="one">Site Content</option>
                    <option value="two">Donation</option>
                    <option value="three">Legal</option>
                </select><br />
                <label for="Subject" class="control-label" role="navigation">Subject: </label>
                <input class="form-control" name="Subject" id="Subject" type="text" placeholder="The Subject" optional="true" runat="server"><br />
                <label for="Message" class="control-label" role="navigation">Message: </label>
                <textarea class="form-control col-md-3" name="Message" id="Message" rows="5" align="center" placeholder="Tell us how it is" required runat="server"></textarea><br>
                <br>
                <label for="Human" id="Humanlbl" class="control-label" role="navigation" runat="server">Human Verification: </label>
                <input class="form-control" name="Human" id="Human" type="text" placeholder="Human Verification" required runat="server"><br />
        </div>
        </asp:Panel>
        <asp:Panel ID="sent" runat="server">
            <div class="contact" align="center">
                <asp:Label ID="sentlbl" Text ="Your Message Has Been Sent!" runat="server"  />
            </div>

        </asp:Panel>
<br />  
        <asp:Button ID="subbutt" class="btn btn-primary" runat="server" Text="Submit" />
        
    </div><br />
      

</asp:Content>
