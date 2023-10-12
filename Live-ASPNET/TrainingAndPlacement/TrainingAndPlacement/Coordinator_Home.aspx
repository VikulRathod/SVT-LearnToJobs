<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Coordinator.Master"  CodeBehind="Coordinator_Home.aspx.cs" Inherits="TrainingAndPlacement.Coordinator_Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <!-- Content Header (Page header) -->
    <section class="content-header">
      <h1>
       Student Home
        <small>Information</small>
      </h1>
      <ol class="breadcrumb">
        <li><a href="Student_Profile.aspx"><i class="fa fa-home"></i> Home</a></li>
        <li><a href="#">Student Home</a></li>
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