<%@ Page Title="" Language="C#" MasterPageFile="~/Admin_Placement.Master" AutoEventWireup="true" CodeBehind="Add_Dept.aspx.cs" Inherits="TrainingAndPlacement.Add_Dept" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
  
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <ajaxToolkit:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></ajaxToolkit:ToolkitScriptManager>
    <!-- Content Header (Page header) -->
    <section class="content-header">
        <h1>Department Details</h1>
        <ol class="breadcrumb">
            <li><a href="Staff_Home.aspx"><i class="fa fa-home"></i>Home</a></li>
            <li><a href="#">Add Department</a></li>
            <%--  <li><a href="Deactiveted.aspx">Deactiveted Edit</a></li>--%>
        </ol>
    </section>
    <!-- Main content -->
    <section class="content">
        <div class="row">
            <div class="col-md-1"></div>
            <div class="col-md-12">
                <!-- SELECT2 EXAMPLE -->
                <div class="box box-default">
                    <div class="box-header with-border">
                        <div class="col-md-12 ser-fet">
                            <div class="col-md-2 ser-fet">
                                Department Name *:
                            </div>
                            <div class="col-md-7 ser-fet">
                               <asp:TextBox class="form-control" ID="txtDept_Name" runat="server" placeholder="Eneter Department Name *" />
                            </div>
                            <div class="col-md-3">
                                <asp:Button ID="btnsave" runat="server" Text="Save" class="btn btn-primary" ValidationGroup="Teacher" OnClick="btnsave_Click" />
                            </div>
                        </div>
                    </div>
                    <!-- /.box-body -->
                </div>
                <!-- /.box -->
            </div>
            <div class="col-md-1"></div>
        </div>

        <div class="box box-info ">
            <div class="box-header with-border">
                <h3 class="box-title">Department List</h3>
            </div>
            <!-- /.box-header -->
            <div class="box-body" align="center" style="font-family: Source Sans Pro; overflow-x: scroll; height: 600px; width: 100%">
                

                <asp:GridView ID="gvDepartment" CssClass="table table-striped table-bordered table-hover" runat="server" CellPadding="3" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px"  DataKeyNames="id" AutoPostBack="true"  OnRowEditing="gvDepartment_RowEditing" OnRowUpdating="gvDepartment_RowUpdating" OnRowCancelingEdit="gvDepartment_RowCancelingEdit" OnRowDeleting="gvDepartment_RowDeleting">
              <Columns>         
                   <asp:TemplateField ShowHeader="False">
                       <EditItemTemplate>
                           <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="True" CommandName="Update" Text="Update"></asp:LinkButton>
                           &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel"></asp:LinkButton>
                       </EditItemTemplate>
                       <ItemTemplate>
                           <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Edit" Text="Edit"></asp:LinkButton>
                       </ItemTemplate>
                   </asp:TemplateField>
                  <asp:TemplateField ShowHeader="false">
                      <EditItemTemplate>
                          <asp:LinkButton ID="LinkButton3" runat="server" Text="Delete"></asp:LinkButton>
                      </EditItemTemplate>
                      <ItemTemplate>
                          <asp:LinkButton ID="LinkButton4" runat="server" Text="Delete" CommandName="Delete"></asp:LinkButton>
                      </ItemTemplate>
                  </asp:TemplateField>



                   <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" />
                   <asp:TemplateField HeaderText="Department" SortExpression="Department">
                       <EditItemTemplate>
                           <asp:TextBox ID="txtDepartment" runat="server" Text='<%# Bind("Department") %>'></asp:TextBox>
                       </EditItemTemplate>
                       <ItemTemplate>
                           <asp:Label ID="Label2" runat="server" Text='<%# Bind("Department") %>'></asp:Label>
                       </ItemTemplate>
                   </asp:TemplateField>
                  
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
    </section>
</asp:Content>
