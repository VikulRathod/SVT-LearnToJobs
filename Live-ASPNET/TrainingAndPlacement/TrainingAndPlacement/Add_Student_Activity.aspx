<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Student.Master" CodeBehind="Add_Student_Activity.aspx.cs" Inherits="TrainingAndPlacement.Add_Student_Activity" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <ajaxToolkit:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></ajaxToolkit:ToolkitScriptManager>
    <!-- Content Header (Page header) -->
    <section class="content-header">
        <h1>Add Student Activity
        <small>Information</small>
        </h1>
        <ol class="breadcrumb">
            <li><a href=""><i class="fa fa-home"></i>Home</a></li>
            <li>Add_Student_Activity</li>
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
                                    <asp:Label class="form-control" ID="txtstuID" runat="server" ></asp:Label>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-5">
                            <div class="form-group">
                                <div class="input-group">
                                    <div class="input-group-btn">
                                        <button type="button" class="btn btn-danger">Activity Title: </button>
                                    </div>
                                    <asp:DropDownList ID="ddlActivityTitle" runat="server" class="form-control">
                                    </asp:DropDownList>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-3">
                            <asp:LinkButton ID="btnsearch" class="btn btn-primary" runat="server" ValidationGroup="staff1"  OnClick="btnsearch_Click"><i class="fa fa-search"></i> Search</asp:LinkButton>
                        </div>
                    </div>
                </div>
                 <div class="box box-info">
                    <div class="box-body">
                      <div class="form-group">
                        <div class="col-md-2 ser-fet">
                            <label>Activity Title</label>
                        </div>
                        <div class="col-md-4 ser-fet">

                            <asp:TextBox class="form-control" ID="txtActivityTitle" runat="server" placeholder="Enter Activity Title" MaxLength="40"></asp:TextBox>
                        </div>
                        <div class="col-md-2 ser-fet">
                            <label>Activity Details</label>
                        </div>
                        <div class="col-md-4 ser-fet">

                            <asp:TextBox class="form-control" ID="txtActivity_Details" runat="server" placeholder="Enter Activity Details" MaxLength="40"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-md-2 ser-fet">
                            <label>Description</label>
                        </div>
                        <div class="col-md-10 ser-fet">

                            <asp:TextBox class="form-control" ID="txtDescription" runat="server" placeholder="Enter Description" MaxLength="40" TextMode="MultiLine"></asp:TextBox>
                        </div>

                    </div>
                    <!-- /.input group -->
                    <div class="form-group">
                        <div class="col-md-4"></div>
                        <div class="col-md-4">
                            <asp:Button ID="btnsave" runat="server" Text="Submit Now!" class="btn btn-primary" ValidationGroup="id" OnClick="btnsave_Click" />
                        </div>
                        <div class="col-md-4">
                            <asp:Button ID="btnclear" runat="server" Text="Reset" class="btn btn-primary" OnClick="btnclear_Click" />
                        </div>
                        <!-- /.input group -->
                    </div>
                    <!-- /.form group -->
                   </div>
               
            </div>
            <div class="box box-info ">
            
                <div class="box-header with-border">
                      <h3 class="box-title">Student Activities Details </h3>
                </div>
                <!-- /.box-header -->
                <div class="box-body" align="center" style="font-family: Source Sans Pro; overflow-x: scroll; height:600px; width:100%">
                    <div class="form-group" >
                        <asp:GridView ID="gvstudent_extraActivity" CssClass="table table-striped table-bordered table-hover" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
                            <Columns>
                                <asp:BoundField HeaderText="Student Id" DataField="Student_id" />
                                <asp:BoundField HeaderText="Activity Title" DataField="Activity_Title" />
                                <asp:BoundField HeaderText="Activity Details" DataField="Activity_Details" />
                                <asp:BoundField HeaderText="Description" DataField="Description" />
                                
                            </Columns>
                        <FooterStyle BackColor="White" ForeColor="#000066" />
                        <HeaderStyle BackColor="#e1e7ea" Font-Bold="True" ForeColor="#000" />
                        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                        <RowStyle ForeColor="#000" />
                        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#007DBB" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#00547E" />
                    </asp:GridView>
                    </div>
                </div>
              </div>
     
        </div>
        
            

    </section>
</asp:Content>
