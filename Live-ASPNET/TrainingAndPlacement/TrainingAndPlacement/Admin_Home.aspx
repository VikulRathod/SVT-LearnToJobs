<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Admin_Placement.Master" CodeBehind="Admin_Home.aspx.cs" Inherits="TrainingAndPlacement.Admin_Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <ajaxToolkit:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></ajaxToolkit:ToolkitScriptManager>
    <!-- Content Header (Page header) -->
    <section class="content-header">
      <h1> Controller Menu</h1><h5>"Announcement to be sent to the records present in Grid Table"</h5>
      <ol class="breadcrumb">
        <li><a href="Admin_Home.aspx"><i class="fa fa-home"></i> Home</a></li>
        <li><a href="#">Controller Menu</a></li>
      </ol>
    </section>

    <!-- Main content -->
    <section class="content">
        <div class="row">
            <div class="col-md-12">
                <asp:Image ID="Image1" runat="server" ImageUrl="~/img/slider01.jpg" Width="100%" />
            </div>
        </div>
    </section>
</asp:Content>