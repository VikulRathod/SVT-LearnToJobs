<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Admin_Placement.Master" CodeBehind="Add_Update_Company.aspx.cs" Inherits="TrainingAndPlacement.Master_Panel.Add_Update_Company" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <ajaxToolkit:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></ajaxToolkit:ToolkitScriptManager>
    <!-- Content Header (Page header) -->
    <section class="content-header">
        <h1>Company Registration
        </h1>
        <ol class="breadcrumb">
            <li><a href="Staff_Home.aspx"><i class="fa fa-home"></i>Home</a></li>
            <li><a href="#">Company Registration</a></li>
        </ol>
    </section>

    <!-- Main content -->
    <section class="content">
        <div class="row">
            <div class="col-md-12">
                <div class="box box-info">
                    <div class="box-header with-border">
                        <div class="col-md-8">
                            <div class="form-group">
                                <div class="input-group">
                                    <div class="input-group-btn">
                                        <button type="button" class="btn btn-danger">Search Company Name: </button>
                                    </div>
                                    <asp:DropDownList ID="ddlCompany" runat="server" class="form-control" AutoPostBack="true" OnSelectedIndexChanged="ddlCompany_SelectedIndexChanged">
                                    </asp:DropDownList>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <div class="form-group">
                                <div class="input-group">
                                    <div class="input-group-btn">
                                        <button type="button" class="btn btn-danger">Company ID: </button>
                                    </div>
                                    <asp:TextBox class="form-control" ID="txtcompany_id" runat="server" placeholder="Enter Company ID *" />
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- /.box-body -->
                </div>

                <div class="box box-info">
                    <div class="box-header with-border">
                        <h3 class="box-title">Company Registration</h3>
                    </div>
                    <div class="box-body">
                        <div class="form-group">
                            <div class="col-md-2 ser-fet">
                                <label>Company Name *:</label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtcompany_name" runat="server" placeholder="Eneter Company Name *" />
                            </div>
                            <div class="col-md-2 ser-fet">
                                <label>Contact Person Name: </label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtperson" runat="server" placeholder="Eneter Contact Person Name " />
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-md-2 ser-fet">
                                <label>Designation:</label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtDesignation" runat="server" placeholder="Eneter Designation" />
                            </div>
                            <div class="col-md-2 ser-fet">
                                <label>Mobile No. *: </label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtContactNo" runat="server" placeholder="Enter Contact No *"></asp:TextBox>
                            </div>
                        </div>

                        <div class="form-group">
                            <div class="col-md-2 ser-fet">
                                <label>Office Contact No.:</label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtofc_no" runat="server" placeholder="Enter Office Contact No. "></asp:TextBox>
                            </div>
                            <div class="col-md-2 ser-fet">
                                <label>Email ID *: </label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtcompany_email" runat="server" placeholder="Enter Email ID *"></asp:TextBox>
                            </div>
                        </div>

                        <div class="form-group">
                            <div class="col-md-2 ser-fet">
                                <label>Website:</label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtcweb" runat="server" placeholder="Enter Web Site "></asp:TextBox>
                            </div>
                            <div class="col-md-2 ser-fet">
                                <label>Office Address : </label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtc_address" runat="server" placeholder="Eneter Registered Office Address" />
                            </div>
                        </div>

                        <div class="form-group">
                            <div class="col-md-2 ser-fet">
                                <label>Company Type:</label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtc_type" runat="server" placeholder="Eneter Company Type" />
                            </div>
                            <div class="col-md-2 ser-fet">
                                <label>Type Of Services: </label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtc_services" runat="server" placeholder="Enter Type Of Services"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-md-2 ser-fet">
                                <label>Domain Of Services:</label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtcdomain_services" runat="server" placeholder="Enter Domain Of Services"></asp:TextBox>
                            </div>
                            <div class="col-md-2 ser-fet">
                                <label>Description:  </label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtDescription" runat="server" placeholder="Eneter Description" />
                            </div>
                        </div>

                        <div class="form-group">
                            <div class="col-md-6 ser-fet">
                                Befor Completion Company Registration Please Check All Data.
                            </div>
                            <div class="col-md-3">
                                <asp:Button ID="btnsave" runat="server" Text="Save / Update" class="btn btn-primary" ValidationGroup="id" OnClick="btnsave_Click" />
                            </div>
                            <div class="col-md-3">
                                <asp:Button ID="tbnclear" runat="server" Text="Clear All" class="btn btn-primary" OnClick="tbnclear_Click" />
                            </div>
                        </div>
                    </div>
                </div>

                <div class="box box-danger">
                    <div class="box-header with-border">
                        <h3 class="box-title">List of Company Registration</h3>
                    </div>
                    <div class="box-body" align="center" style="font-family: Source Sans Pro; overflow-x: scroll; height: 550px; width: 100%">
                        <asp:GridView ID="gvCompany" CssClass="table table-striped table-bordered table-hover" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" PageIndex="10">
                            <Columns>
                                <asp:BoundField HeaderText="Company_id" DataField="Company_id" />
                                <asp:BoundField HeaderText="Company_name" DataField="Company_name" />
                                <asp:BoundField HeaderText="Contact_person" DataField="Contact_person" />
                                <asp:BoundField HeaderText="Designation" DataField="Designation" />
                                <asp:BoundField HeaderText="Mobile_no" DataField="Mobile_no" />
                                <asp:BoundField HeaderText="office_no" DataField="office_no" />
                                <asp:BoundField HeaderText="email_id" DataField="email_id" />
                                <asp:BoundField HeaderText="website" DataField="website" />
                                <asp:BoundField HeaderText="addressline." DataField="addressline" />
                                <asp:BoundField HeaderText="company_type" DataField="company_type" />
                                <asp:BoundField HeaderText="service_type" DataField="service_type" />
                                <asp:BoundField HeaderText="service_domain" DataField="service_domain" />
                                <asp:BoundField HeaderText="Description" DataField="Description" />
                                <asp:BoundField HeaderText="Registration_date" DataField="Registration_date" HtmlEncode="false" DataFormatString="{0:d}" />



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
