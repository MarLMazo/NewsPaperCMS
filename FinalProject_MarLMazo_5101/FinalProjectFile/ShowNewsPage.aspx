<%@ Page Title="" Language="C#" MasterPageFile="~/MasterFile/LayOut.Master" AutoEventWireup="true" CodeBehind="ShowNewsPage.aspx.cs" Inherits="FinalProject_MarLMazo_5101.FinalProjectFile.ShowNewsPage" %>

<asp:Content ID="ShowNewsPage" ContentPlaceHolderID="body" runat="server">
    <div id="PageView" runat="server">
    </div>
   
    <div class="movePage">
        <asp:Button runat="server" ID="BtnPrev" OnClick="BtnPrev_Click" Text="Prev" />
        <asp:Button runat="server" ID="BtnNext" OnClick="BtnNext_Click" Text="Next" />   
    </div>
    <asp:Button runat="server" ID="BtnGoBack" OnClick="BtnGoBack_Click" Text="Go Back" />
    <asp:Button runat="server" ID="BtnUpdate" OnClick="BtnUpdate_Click" Text="Update" />
    <asp:Button runat="server" ID="BtnDelete" OnClick="BtnDelete_Click" OnClientClick = " return confirm('Are you sure you want to Delete?')" Text="Delete"/>

</asp:Content>
