<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BMW_AppService._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Employees</h1>
  <%--      <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>--%>
    </div>

    <form id="form1">
        <table class="auto-style1" style="position:center;">
           
            <tr>
                <td class="auto-style2">&nbsp;</td>
                
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Label ID="Label3" runat="server" Text="EmployeeCode"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TxtEmployeeCode" runat="server"></asp:TextBox>
                     <td><asp:Button ID="Button4" runat="server" OnClick="DetailsBtn_Click" Text="GetEmpDetails" Width="87px" /></td>
                </td>
               
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Label ID="Label4" runat="server" Text="Title"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="DrpTitle" runat="server">
                        <asp:ListItem>Select a value</asp:ListItem>
                        <asp:ListItem>Miss</asp:ListItem>
                        <asp:ListItem>Mr</asp:ListItem>
                        <asp:ListItem>Mrs</asp:ListItem>
                    </asp:DropDownList>
                </td>
               
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TxtName" runat="server"></asp:TextBox>
                </td>
               
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Label ID="Label2" runat="server" Text="SurName"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TxtSurName" runat="server" ></asp:TextBox>
                </td>
                
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Label ID="Label5" runat="server" Text="Gender"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="DrpGender" runat="server">
                        <asp:ListItem>Select a value</asp:ListItem>
                        <asp:ListItem>M</asp:ListItem>
                        <asp:ListItem>F</asp:ListItem>
                    </asp:DropDownList>
                </td>
               
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Label ID="Label6" runat="server" Text=" Date Of Birth"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TxtDOB" runat="server" TextMode="Date" ></asp:TextBox>
                </td>
            </tr>
             <tr>
                 <td class="auto-style2">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Label ID="Label7" runat="server" Text=" Date Of Join"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TxtDOJ" runat="server" TextMode="Date" ></asp:TextBox>
                </td>
               
            </tr>
             <tr>
                 <td class="auto-style2">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Label ID="Label8" runat="server" Text=" Position"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TxtPosition" runat="server"></asp:TextBox>
                </td>
               
            </tr>
             <tr>
                 <td class="auto-style2">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Label ID="Label9" runat="server" Text=" Salary"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TxtSalary" runat="server"></asp:TextBox>
                </td>
               
            </tr>
             <tr>
                 <td class="auto-style2">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Label ID="Label11" runat="server" Text=" Department"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="DrpDepartmentName" runat="server">
                        <asp:ListItem>Select a value</asp:ListItem>
                        <asp:ListItem Value="10001">Human Resource</asp:ListItem>
                        <asp:ListItem Value="10002">Information Technology</asp:ListItem>
                        <asp:ListItem Value="10003">Production</asp:ListItem>
                        <asp:ListItem Value="10004">Purchasing</asp:ListItem>
                    </asp:DropDownList>
                </td>
               
            </tr>
             <tr>
                 <td class="auto-style2">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Label ID="Label12" runat="server" Text=" Telephone Number"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TxtTelephoneNo" runat="server" MaxLength="12"></asp:TextBox>
                </td>
               
            </tr>
            <tr>
                 <td class="auto-style2">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Label ID="Label10" runat="server" Text=" LastUpdateBy"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TxtLastUpdateBy" runat="server"></asp:TextBox>
                </td>
               
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td><asp:Button ID="Button1" runat="server" OnClick="InsertBtn_Click" Text="AddNew" Width="115px" /></td>
                <td><asp:Button ID="Button2" runat="server" OnClick="UpdateBtn_Click" Text="Edit" Width="68px" /> <asp:Button ID="Button3" runat="server" OnClick="DeleteBtn_Click" Text="Delete" Width="83px" /></td>
                <td> &nbsp;</td>
            </tr>
          
            
        </table>
 
    </form>
    
     
       
    

</asp:Content>
