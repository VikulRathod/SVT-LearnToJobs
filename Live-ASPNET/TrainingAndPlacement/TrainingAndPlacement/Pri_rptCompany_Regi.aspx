<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Pri_rptCompany_Regi.aspx.cs" Inherits="TrainingAndPlacement.Pri_rptCompany_Regi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <ajaxToolkit:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></ajaxToolkit:ToolkitScriptManager>
    <!-- Content Header (Page header) -->
    <section class="content-header">
      <h1>
       Company Registration
        <small>Reports</small>
      </h1>
      <ol class="breadcrumb">
        <li><a href="Staff_Home.aspx"><i class="fa fa-home"></i> Home</a></li>
          <li><a href="#"> All Reports</a></li>
        <li><a href="#"> Company Reports</a></li>
        <li><a href="#">Company Registration</a></li>
      </ol>
    </section>

    <!-- Main content -->
    <section class="content">
        <div class="row">
           <div class="col-md-12">
          <!-- SELECT2 EXAMPLE -->
         <div class="box box-default">
            <div class="box-header with-border">
                <div class="col-md-4 ser-fet"></div>
                <div class="col-md-3 ser-fet" >
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        From
                                    </div>
                                     <ajaxToolkit:CalendarExtender ID="CalendarExtender1" CssClass="Calendar" format="dd/MM/yyyy" runat="server" Enabled="True" TargetControlID="txtstart_date" />
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" Display="Dynamic" ValidationGroup="staff" ValidationExpression="^(0?[1-9]|[12][0-9]|3[01])[\/\-](0?[1-9]|1[012])[\/\-]\d{4}$" ControlToValidate="txtstart_date" ForeColor="Red" ErrorMessage="Invalid Date Format." />
                        
                                       <asp:RequiredFieldValidator ID="RequiredFieldValidator2" CssClass="Validators" Display="Dynamic" ValidationGroup="staff" ControlToValidate="txtstart_date" runat="server"    ErrorMessage="Please select start date." ForeColor="#0066ff"></asp:RequiredFieldValidator>
                                    <asp:TextBox ID="txtstart_date" runat="server" class="form-control" format="dd/mm/yyyy" placeholder="Start Date *" />
                                   
                                </div>
                            </div>
                            <div class="col-md-3 ser-fet" >
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        TO
                                    </div>
                                         <ajaxToolkit:CalendarExtender ID="CalendarExtender3" CssClass="Calendar" format="dd/MM/yyyy" runat="server" Enabled="True" TargetControlID="txtend_date" />
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" Display="Dynamic" ValidationGroup="staff" ValidationExpression="^(0?[1-9]|[12][0-9]|3[01])[\/\-](0?[1-9]|1[012])[\/\-]\d{4}$" ControlToValidate="txtend_date" ForeColor="Red" ErrorMessage="Invalid Date Format." />
                              
                                       <asp:RequiredFieldValidator ID="RequiredFieldValidator4" CssClass="Validators" Display="Dynamic" ValidationGroup="staff" ControlToValidate="txtend_date" runat="server"    ErrorMessage="Please select end date." ForeColor="#0066ff"></asp:RequiredFieldValidator>
                                    <asp:TextBox ID="txtend_date" runat="server" class="form-control" format="dd/mm/yyyy" placeholder="End Date *" />
                                 </div>
                            </div>
                            <div class="col-md-2 ser-fet" >
                                <asp:LinkButton ID="LinkButton1" class="btn btn-primary" runat="server" ValidationGroup="staff" OnClick="Search_Click"><i class="fa fa-search"></i> Search</asp:LinkButton>
                            </div>
                
            </div>
        </div>
        <!-- /.box-body -->
       </div>
        </div>
    
        <div class="box box-info ">
            
                <div class="box-header with-border">
                      <h3 class="box-title">Company Registration Reports View</h3>
                    <div class="box-tools pull-right">
                        <asp:LinkButton ID="btnexcel" class="btn btn-primary" runat="server" OnClick="btnexcel_Click" ><i class="fa fa-download"></i> Download Excel</asp:LinkButton>        
                    </div>
               </div>
                <!-- /.box-header -->
                <div class="box-body" align="center" style="font-family: Source Sans Pro; overflow-x: scroll; height:600px; width:100%">
                    <div class="form-group" >
                             <asp:GridView ID="gvCompany" CssClass="table table-striped table-bordered table-hover" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" >
                                        <RowStyle HorizontalAlign="Center" />
                                        <Columns>
                                            <asp:BoundField HeaderText="Company_id" DataField="Company_id" />
                                            <asp:BoundField HeaderText="Company_name" DataField="Company_name" />
                                            <asp:BoundField HeaderText="Contact_person" DataField="Contact_person" />
                                            <asp:BoundField HeaderText="Designation" DataField="Designation" />
                                            <asp:BoundField HeaderText="Mobile_no" DataField="Mobile_no" />
                                            <asp:BoundField HeaderText="office_no" DataField="office_no" />
                                            <asp:BoundField HeaderText="email_id" DataField="email_id" />
                                            <asp:BoundField HeaderText="website" DataField="website" />
                                            <asp:BoundField HeaderText="addressline" DataField="addressline" />
                                            <asp:BoundField HeaderText="company_type" DataField="company_type" />
                                            <asp:BoundField HeaderText="service_type" DataField="service_type" />
                                            <asp:BoundField HeaderText="service_domain" DataField="service_domain" />
                                            <asp:BoundField HeaderText="Description" DataField="Description" />
                                            <asp:BoundField HeaderText="Registration_date" DataField="Registration_date" />
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
    </section>

</asp:Content>
