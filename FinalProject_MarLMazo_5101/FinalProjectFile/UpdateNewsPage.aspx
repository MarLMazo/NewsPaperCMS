<%@ Page Title="" Language="C#" MasterPageFile="~/MasterFile/LayOut.Master" AutoEventWireup="true" CodeBehind="UpdateNewsPage.aspx.cs" Inherits="FinalProject_MarLMazo_5101.UpdateNewsPage" %>

<asp:Content ID="UpdateNewsPage" ContentPlaceHolderID="body" runat="server">
    <div id="PageContent" runat="server"></div>
    
    <div class="addNews">
        <h1>Update The News </h1>
        <div>
            <div>
                <label for="NewsTitle">Title:</label>
                <asp:RequiredFieldValidator runat="server" EnableClientScript="true" ControlToValidate="NewsTitle" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator runat="server" EnableClientScript="true" ControlToValidate="NewsTitle" ValidationExpression="^[\w\s]+" ErrorMessage="Please enter a valid Title" ForeColor="Red"/>                
            </div>
            <div>
                <asp:TextBox runat="server"  ID="NewsTitle" Columns="100"></asp:TextBox>            
            </div>  
        </div>
        <div>
            <div>
                <label for="NewsDate">Date:</label>
            </div>
            <div >        
                <p id="datePublish" runat="server"></p>          
            </div>          
        </div>
        <div>
            <div>
                <label for="NewsContent">Main Content:</label>
                <asp:RequiredFieldValidator runat="server" EnableClientScript="true" ControlToValidate="NewsContent" ErrorMessage="*" ForeColor="Red" ></asp:RequiredFieldValidator>
            </div>
            <div>
                <asp:TextBox runat="server" ID="NewsContent" TextMode="MultiLine" Rows="10" Columns="100"></asp:TextBox>           
            </div>      
        </div>
        <asp:Button ID="BtnUpdate" runat="server" OnClick="BtnUpdate_Click" Text="Update"/>
    </div>
    <asp:Button runat="server" ID="BtnGoBack" OnClick="BtnGoBack_Click"  CausesValidation="false" Text="Go Back" />

</asp:Content>
