<%@ Page Title="" Language="C#" MasterPageFile="~/MasterFile/LayOut.Master" AutoEventWireup="true" CodeBehind="ShowNewsPage.aspx.cs" Inherits="FinalProject_MarLMazo_5101.FinalProjectFile.ShowNewsPage" %>

<asp:Content ID="ShowNewsPage" ContentPlaceHolderID="body" runat="server">
    <div id="PageView" runat="server"></div>
   
    <div class="movePage">
        <asp:Button runat="server" ID="BtnPrev" OnClick="BtnPrev_Click" Text="Prev" />
        <asp:Button runat="server" ID="BtnNext" OnClick="BtnNext_Click" Text="Next" />   
    </div>
    <asp:Button runat="server" ID="BtnGoBack" OnClick="BtnGoBack_Click" Text="Go Back" />
    <asp:ImageButton runat="server" ID="BtnUpdate" ImageUrl="~/Images/edit.png" OnClick ="BtnUpdate_Click" Height="40" Width="40" AlternateText="Image Button Update" />
    <asp:ImageButton runat="server" ID="BtnDelete" ImageUrl="~/Images/delete.png" OnClientClick = " return confirm('Are you sure you want to Delete?')" Height = "40" Width = "40" AlternateText="Image Button Delete" />
      

</asp:Content>
