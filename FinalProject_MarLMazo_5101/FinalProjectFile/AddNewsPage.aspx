<%@ Page Title="" Language="C#" MasterPageFile="~/MasterFile/LayOut.Master" AutoEventWireup="true" CodeBehind="AddNewsPage.aspx.cs" Inherits="FinalProject_MarLMazo_5101.FinalProjectFile.AddNewsPage" %>

<asp:Content ID="AddNewsPage" ContentPlaceHolderID="body" runat="server">
    
    <div class="addNews">
        <h1>Add Recent News </h1>
        <div>
            <div>
                <label for="NewsTitle">Title:</label>
                <asp:RequiredFieldValidator runat="server" EnableClientScript="true" ControlToValidate="NewsTitle" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator runat="server" EnableClientScript="true" ControlToValidate="NewsTitle" ValidationExpression="^[\w'\s?]+" ErrorMessage="Please enter a valid Title" ForeColor="Red"/>                
            </div>
            <div>
                <asp:TextBox runat="server"  ID="NewsTitle" Columns="100"></asp:TextBox>            
            </div>  
        </div>
        <div>
            <div>
                <label for="NewsDate">Date:</label>
                <asp:RequiredFieldValidator runat="server" EnableClientScript="true" ControlToValidate="NewsDate" ErrorMessage="*" ForeColor="Red" ></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator runat="server" EnableClientScript="true" ControlToValidate="NewsDate" ValidationExpression="^\d{4}\-(0[1-9]|1[012])\-(0[1-9]|[12][0-9]|3[01])$" ErrorMessage="Enter a valid Date" ForeColor="Red"></asp:RegularExpressionValidator>  
                <%-- student-enrolment date with format yyyy-mm-dd by Vinod February 27, 2014 https://stackoverflow.com/questions/22061723/regex-date-validation-for-yyyy-mm-dd--%>
            </div>
            <div>
                <asp:TextBox runat="server" ID="NewsDate" Columns="100"></asp:TextBox>            
            </div>          
        </div>
        <div>
            <div>
                <label for="NewsContent">Main Content:</label>
                <asp:RequiredFieldValidator runat="server" EnableClientScript="true" ControlToValidate="NewsContent" ErrorMessage="*" ForeColor="Red" ></asp:RequiredFieldValidator>
                 <%-- NO VALIDATION SINCE IT CAN HAVE ANYTHING --%>
            </div>
            <div>
                <asp:TextBox runat="server" ID="NewsContent" TextMode="MultiLine" Rows="10" Columns="100"></asp:TextBox>
            </div>     
        </div>
        <asp:Button runat="server" ID="BtnAdd" onClick="BtnAdd_Click" Text="Submit" />
    </div>

    <asp:Button runat="server" ID="BtnGoBack" OnClick="BtnGoBack_Click"  CausesValidation="false" Text="Go Back"  />
    <%-- CausesValidation reference on Rakeshkr on Dec 09, 2009 https://forums.asp.net/t/1502083.aspx?Back+Button+with+Validation --%>

</asp:Content>
