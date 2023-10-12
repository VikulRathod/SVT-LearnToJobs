<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Student.Master" CodeBehind="Student_Apply_Drive.aspx.cs" Inherits="TrainingAndPlacement.Student_Apply_Drive" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section class="content-header">
        <h1>Placement Drives
        <small>Information</small>
        </h1>
        <ol class="breadcrumb">
            <li><a href="#"><i class="fa fa-home"></i>Student Home</a></li>
            <li><a href="#"><i class="fa fa-user"></i>Placement Drives</a></li>
        </ol>
    </section>

    <!-- Main content -->
    <section class="content">
        <div class="row">
            <!-- /.col -->
            <div class="col-md-12">
                <div class="box box-primary">
                                <div class="box-header with-border">
                                    <div class="col-md-4">
                                        <h3 class="box-title">Evaluate Criteria</h3>
                                    </div>
                                    <div class="col-md-5">
                                        <b>Eligible Count :
                                            <asp:Label ID="txteligible" runat="server" Text="0" ForeColor="Green" Font-Size="Larger" />
                                            | 
                                         Ineligible Count:
                                            <asp:Label ID="txtineligible" runat="server" Text="0" ForeColor="Red" Font-Size="Larger" /></b>
                                    </div>
                                    <div class="col-md-3">
                                        <asp:LinkButton ID="btnApply" class="btn btn-primary" runat="server" OnClick="btnApply_Click"><i class="fa fa-send"></i> Apply Now!</asp:LinkButton>
                                    </div>
                                </div>
                                <!-- /.box-header -->
                                <div class="box-body" align="center">
                                    <div class="form-group">
                                        <asp:Label ID="txtmsg" runat="server" ForeColor="Green" Font-Size="Larger" Font-Bold="True" /><br />
                                    </div>
                                    <div class="form-group">

                                        <asp:GridView ID="gvPlace_Drive" CssClass="table table-striped table-bordered table-hover" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" PageIndex="10">
                                            <Columns>
                                                <asp:BoundField HeaderText="Criteria" DataField="Header" />
                                                <asp:BoundField HeaderText="Drive Criteria" DataField="rcriteria" ItemStyle-HorizontalAlign="Center" />
                                                <asp:BoundField HeaderText="Student Criteria" DataField="scriteria" ItemStyle-HorizontalAlign="center" />
                                                <asp:BoundField HeaderText="Eligibility" ItemStyle-HorizontalAlign="center" />
                                            </Columns>
                                        </asp:GridView>
                                    </div>
                                </div>
                            </div>
            </div>
        </div>
    </section>
</asp:Content>
