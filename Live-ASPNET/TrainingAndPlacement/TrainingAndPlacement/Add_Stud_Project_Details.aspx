<%@ Page Title="" Language="C#" MasterPageFile="~/Student.Master" AutoEventWireup="true" CodeBehind="Add_Stud_Project_Details.aspx.cs" Inherits="TrainingAndPlacement.Add_Stud_Project_Details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <ajaxToolkit:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></ajaxToolkit:ToolkitScriptManager>
    <!-- Content Header (Page header) -->
    <section class="content-header">
        <h1>Add Project Details
        </h1>
        <ol class="breadcrumb">
            <li><a href="Staff_Home.aspx"><i class="fa fa-home"></i>Home</a></li>
            <li><a href="#">Add Project Details
            </a></li>
        </ol>
    </section>
    <!-- Main content -->
    <section class="content">
        <div class="row">
            <div class="col-md-12">
                <div class="box box-info">
                    <div class="box-header with-border">
                        <div class="col-md-4">
                            <div class="form-group">
                                <div class="input-group">
                                    <div class="input-group-btn">
                                        <button type="button" class="btn btn-danger">Student ID: </button>
                                    </div>
                                    <asp:Label class="form-control" ID="txtStud_id" runat="server" ></asp:Label>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-5">
                            <div class="form-group">
                                <div class="input-group">
                                    <div class="input-group-btn">
                                        <button type="button" class="btn btn-danger">Project Title: </button>
                                    </div>
                                    <asp:DropDownList ID="ddlProjectTitle" runat="server" class="form-control">
                                    </asp:DropDownList>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-3">
                            <asp:LinkButton ID="btnsearch" class="btn btn-primary" runat="server" ValidationGroup="staff1" AutoPostBack="true" OnClick="btnsearch_Click"><i class="fa fa-search"></i> Search</asp:LinkButton>
                        </div>
                    </div>
                    <!-- /.box-body -->
                </div>
                <div class="box box-info">
                    <div class="box-body">
                        <div class="form-group">
                            <div class="col-md-2 ser-fet">
                                <label>Project Type:</label>
                            </div>
                            <div class="col-md-4 ser-fet">
                                <asp:TextBox class="form-control" ID="txtProject_Type" runat="server" placeholder="Eneter Project Type*" />
                            </div>
                            <div class="col-md-2 ser-fet">
                                <label>Project Title</label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtProject_Title" runat="server" placeholder="Eneter Project Title *" />
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-md-2 ser-fet">
                                <label>Project Domain:</label>
                            </div>
                            <div class="col-md-4 ser-fet">
                                <asp:TextBox class="form-control" ID="txtProject_Domain" runat="server" placeholder="Eneter Project Domain *" />
                            </div>
                            <div class="col-md-2 ser-fet">
                                <label>Project Duration </label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtProject_Duration" runat="server" placeholder="Eneter Project Duration *" />
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-md-2 ser-fet">
                                <label>Technologies</label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtTechnologies" runat="server" placeholder="Eneter Technologies *" />
                            </div>
                            <div class="col-md-2 ser-fet">
                                <label>Team Size:</label>
                            </div>
                            <div class="col-md-4 ser-fet">
                                <asp:TextBox class="form-control" ID="txtTeam_Size" runat="server" placeholder="Eneter Team Size *" />
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-md-2 ser-fet">
                                <label>Guide Name: </label>
                            </div>
                            <div class="col-md-4 ser-fet">
                                <asp:TextBox class="form-control" ID="txtGuide_Name" runat="server" placeholder="Eneter Guide Name *" />
                            </div>
                            <div class="col-md-2 ser-fet">
                                <label>Description: </label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtDescription" runat="server" placeholder="Eneter Description *" />
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-md-6 ser-fet">
                            </div>
                            <div class="col-md-3">
                                <asp:Button ID="btnsave" runat="server" Text="Save / Update" class="btn btn-primary" ValidationGroup="id" OnClick="btnsave_Click" />
                            </div>
                            <div class="col-md-3" aria-disabled="True">
                                <asp:Button ID="btnclear" runat="server" Text="Clear All" class="btn btn-primary" OnClick="btnclear_Click" />
                            </div>
                        </div>
                    </div>
                </div>
                <div class="box box-danger">
                    <div class="box-header with-border">
                        <h3 class="box-title">Project Details List</h3>
                    </div>
                    <div class="box-body" align="center" style="font-family: Source Sans Pro; overflow-x: scroll; height: 550px; width: 100%">
                        <asp:GridView ID="gvProject_Details" CssClass="table table-striped table-bordered table-hover" runat="server"
                            AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" DataKeyNames="Student_ID"
                            BorderWidth="1px" CellPadding="3" PageIndex="10">
                            <Columns>
                                <asp:BoundField HeaderText="Student ID" DataField="Student_ID" />
                                <asp:BoundField HeaderText="Project Type" DataField="Project_Type" />
                                <asp:BoundField HeaderText="Project Title" DataField="Project_Title" />
                                <asp:BoundField HeaderText="Project Domain" DataField="Project_Domain" />
                                <asp:BoundField HeaderText="Project Duration" DataField="Project_Duration" />
                                <asp:BoundField HeaderText="Technologies" DataField="Technologies" />
                                <asp:BoundField HeaderText="Team Size" DataField="Team_Size" />
                                <asp:BoundField HeaderText="Guide Name" DataField="Guide_Name" />
                                <asp:BoundField HeaderText="Description" DataField="Description" />
                            </Columns>
                        </asp:GridView>
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
