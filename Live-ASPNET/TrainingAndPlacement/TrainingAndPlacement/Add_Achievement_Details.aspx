<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Student.Master" CodeBehind="Add_Achievement_Details.aspx.cs" Inherits="TrainingAndPlacement.Add_Achievement_Details" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <!-- Content Header (Page header) -->
    <section class="content-header">
        <h1>Add Achievement Details
        <small>Information</small>
        </h1>
        <ol class="breadcrumb">
            <li><a href="Staff_Home.aspx"><i class="fa fa-home"></i>Home</a></li>
            <li>Add_Achievement_Details</li>
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
                                    <asp:Label class="form-control" ID="txtstudentID" runat="server" ></asp:Label>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-5">
                            <div class="form-group">
                                <div class="input-group">
                                    <div class="input-group-btn">
                                        <button type="button" class="btn btn-danger">Achievement Title: </button>
                                    </div>
                                    <asp:DropDownList ID="ddlAchievementTitle" runat="server" class="form-control">
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
                        <div class="col-md-6 ser-fet">
                            <div class="input-group">
                                <div class="input-group-addon">
                                    Achievement Title
                                </div>
                                <asp:TextBox class="form-control" ID="txtAchievement_Title" runat="server" placeholder="Enter Achievement_Title" ></asp:TextBox>
                            </div>
                            <br />
                        </div>
                        <div class="col-md-6 ser-fet">
                            <div class="input-group">
                                <div class="input-group-addon">
                                    Achievement Details
                                </div>
                                <asp:TextBox class="form-control" ID="txtAchievement_Details" runat="server" placeholder="Enter Achievement_Details" ></asp:TextBox>
                            </div>
                            <br />
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-md-12 ser-fet">
                            <div class="input-group">
                                <div class="input-group-addon">
                                    Description
                                </div>
                                <asp:TextBox class="form-control" ID="txtDescription" runat="server" placeholder="Enter Description" TextMode="MultiLine"></asp:TextBox>
                            </div>
                            <br />
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
            </div>

       <div class="col-md-12">
            <div class="box box-danger">
                <div class="box-header with-border">
                    <h3 class="box-title">Add Achievement Details </h3>

                    <%-- <div class="box-tools pull-right">
                        <div class="input-group">
                            <asp:LinkButton ID="btnexcel" class="btn btn-primary" runat="server" OnClick="btnexcel_Click" ><i class="fa fa-download"></i> Download Excel</asp:LinkButton>
                       </div>         
                    </div>--%>
                </div>

                <div class="box-body" align="center" style="font-family: Source Sans Pro; overflow-x: scroll; height: 550px; width: 100%">
                    <asp:GridView ID="gvAchievementDetails" CssClass="table table-striped table-bordered table-hover" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" PageIndex="10">
                        <Columns>
                            <asp:BoundField HeaderText="studentID" DataField="studentID" InsertVisible="False" ReadOnly="True" SortExpression="studentID" />
                            <asp:BoundField HeaderText="Achievement_Title" DataField="Achievement_Title" SortExpression="Achievement_Title" />
                            <asp:BoundField HeaderText="Achievement_Details" DataField="Achievement_Details" SortExpression="Achievement_Details" />
                            <asp:BoundField HeaderText="Description" DataField="Description" SortExpression="Description" />

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

