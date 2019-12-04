<%@ Page Title="" Language="C#" MasterPageFile="~/MasterFile/LayOut.Master" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="FinalProject_MarLMazo_5101.AdminPage" %>

<asp:Content id="AdminPage" ContentPlaceHolderID="body" runat="server">
    <nav id="main-nav">
        <ul id="nav" runat="server">
        </ul>
    </nav>
    <div id="searchBar">
        <asp:label for="newsSearch" runat="server">Search:</asp:label>
        <asp:TextBox ID="newsSearch" runat="server"></asp:TextBox>
        <asp:Button runat="server" text="Search" OnClick="Search_Click" />
    </div>
    <div id="search_result">
        <p>No spaces should be put in the Search bar</p>
    </div>
    <asp:ImageButton id="BtnAddPage" runat="server"
           AlternateText="Add Page Icon"
           ImageUrl="~/images/addnew.png"
           OnClick="ShowAddPage_Click"
           height="50"
           width="50"/>

    <div id="newsList" runat="server">
         <div class="pageList">
             <div>Publish</div>
             <div>News Title</div>
             <div>Publish Date</div>
             <div>Action</div>
         </div>
    </div>
    <asp:Button runat="server" ID="ShowAddPage" OnClick="ShowAddPage_Click"  Text="ADD"/>
</asp:Content>
