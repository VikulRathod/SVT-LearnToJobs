<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Index.aspx.cs" Inherits="TrainingAndPlacement.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <!-- Content Header (Page header) -->
    <section class="content-header">
        <h1> Training And Placement </h1>
    </section>

    <section class="content">
        <div class="row">
            <div class="col-md-12">
                <asp:Image ID="Image1" runat="server" ImageUrl="~/img/slider01.jpg" Width="100%" />
            </div>
        </div>
    </section>
</asp:Content>
