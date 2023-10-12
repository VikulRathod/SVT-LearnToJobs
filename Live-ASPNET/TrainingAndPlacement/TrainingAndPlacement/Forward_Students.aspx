<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Admin_Placement.Master" CodeBehind="Forward_Students.aspx.cs" Inherits="TrainingAndPlacement.Forward_Students" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <ajaxToolkit:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></ajaxToolkit:ToolkitScriptManager>
    <script type="text/javascript">
        var TotalChkBx;
        var Counter;

        window.onload = function () {
            //Get total no. of CheckBoxes in side the GridView.
            TotalChkBx = parseInt('<%= this.gvStudent.Rows.Count %>');

            //Get total no. of checked CheckBoxes in side the GridView.
            Counter = 0;
        }

        function HeaderClick(CheckBox) {
            //Get target base & child control.
            var TargetBaseControl = document.getElementById('<%= this.gvStudent.ClientID %>');
            var TargetChildControl = "chkBxSelect";

            //Get all the control of the type INPUT in the base control.
            var Inputs = TargetBaseControl.getElementsByTagName("input");

            //Checked/Unchecked all the checkBoxes in side the GridView.
            for (var n = 0; n < Inputs.length; ++n)
                if (Inputs[n].type == 'checkbox' && Inputs[n].id.indexOf(TargetChildControl, 0) >= 0)

                    Inputs[n].checked = CheckBox.checked;

            //Reset Counter
            Counter = CheckBox.checked ? TotalChkBx : 0;
        }

        function ChildClick(CheckBox, HCheckBox) {
            //get target control.
            var HeaderCheckBox = document.getElementById(HCheckBox);

            //Modifiy Counter; 
            if (CheckBox.checked && Counter < TotalChkBx)
                Counter++;
            else if (Counter > 0)
                Counter--;

            //Change state of the header CheckBox.
            if (Counter < TotalChkBx)
                HeaderCheckBox.checked = false;
            else if (Counter == TotalChkBx)
                HeaderCheckBox.checked = true;
        }
        $(document).ready(function () {
            $('[data-toggle="tooltip"]').tooltip();
        });
    </script>
    <!-- Content Header (Page header) -->
    <section class="content-header">
        <h1>Forward Students 
        <small>Next Round</small>
        </h1>
        <ol class="breadcrumb">
            <li><a href="Staff_Home.aspx"><i class="fa fa-home"></i>Home</a></li>
            <li><a href="#">Forward Students Next Round</a></li>
        </ol>
    </section>

    <!-- Main content -->
    <section class="content">
        <div class="row">
            <div class="col-md-12">
                <div class="box box-danger">
                    <div class="box-header  with-border">
                        <h3 class="box-title">Basic Information</h3>
                    </div>
                    <div class="box-body">
                        <div class="form-group">
                            <div class="col-md-4">
                                <div class="input-group">
                                    <div class="input-group-btn">
                                        <button type="button" class="btn btn-danger">Academic Year: </button>
                                    </div>
                                    <asp:DropDownList ID="ddlAcademicYear" runat="server" class="form-control">
                                        <asp:ListItem>Select Academic Year</asp:ListItem>
                                        <asp:ListItem Value="2011-2012">2011-2012</asp:ListItem>
                                        <asp:ListItem Value="2012-2013">2012-2013</asp:ListItem>
                                        <asp:ListItem Value="2013-2014">2013-2014</asp:ListItem>
                                        <asp:ListItem Value="2013-2014">2014-2015</asp:ListItem>
                                        <asp:ListItem Value="2015-2016">2015-2016</asp:ListItem>
                                        <asp:ListItem Value="2016-2017">2016-2017</asp:ListItem>
                                        <asp:ListItem Value="2017-2018">2017-2018</asp:ListItem>
                                        <asp:ListItem Value="2018-2019">2018-2019</asp:ListItem>
                                        <asp:ListItem Value="2019-2020">2019-2020</asp:ListItem>
                                        <asp:ListItem Value="2020-2021">2020-2021</asp:ListItem>
                                        <asp:ListItem Value="2021-2022">2021-2022</asp:ListItem>
                                        <asp:ListItem Value="2022-2023">2022-2023</asp:ListItem>
                                        <asp:ListItem Value="2023-2024">2023-2024</asp:ListItem>
                                        <asp:ListItem Value="2024-2025">2024-2025</asp:ListItem>
                                        <asp:ListItem Value="2025-2026">2025-2026</asp:ListItem>
                                        <asp:ListItem Value="2026-2027">2026-2027</asp:ListItem>
                                        <asp:ListItem Value="2027-2028">2027-2028</asp:ListItem>
                                        <asp:ListItem Value="2028-2029">2028-2029</asp:ListItem>
                                        <asp:ListItem Value="2029-2030">2029-2030</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <br />
                            </div>
                            <div class="col-md-4">
                                <div class="input-group">
                                    <div class="input-group-btn">
                                        <button type="button" class="btn btn-danger">Company Id:</button>
                                    </div>
                                    <asp:DropDownList ID="ddlCompany_ID" runat="server" class="form-control" OnSelectedIndexChanged="ddlCompany_ID_SelectedIndexChanged" AutoPostBack="True">
                                    </asp:DropDownList>
                                </div>
                                <br />
                            </div>
                            <div class="col-md-4">
                                <div class="input-group">
                                    <div class="input-group-btn">
                                        <button type="button" class="btn btn-danger">Drive Title: </button>
                                    </div>
                                    <asp:DropDownList ID="ddlDrive" runat="server" class="form-control">
                                    </asp:DropDownList>
                                </div>
                                <br />
                            </div>
                            <div class="col-md-4"></div>
                            <div class="col-md-4">
                                <div class="input-group">
                                    <div class="input-group-btn">
                                        <button type="button" class="btn btn-danger">Round No.: </button>
                                    </div>
                                    <asp:DropDownList ID="ddlround" runat="server" class="form-control">
                                        <asp:ListItem>Select Round</asp:ListItem>
                                        <asp:ListItem Value="Round1">Round1</asp:ListItem>
                                        <asp:ListItem Value="Round2">Round2</asp:ListItem>
                                        <asp:ListItem Value="Round3">Round3</asp:ListItem>
                                        <asp:ListItem Value="Round4">Round4</asp:ListItem>
                                        <asp:ListItem Value="Round5">Round5</asp:ListItem>
                                        <asp:ListItem Value="Round6">Round6</asp:ListItem>
                                        <asp:ListItem Value="Round7">Round7</asp:ListItem>
                                        <asp:ListItem Value="Round8">Round8</asp:ListItem>
                                        <asp:ListItem Value="Round9">Round9</asp:ListItem>
                                        <asp:ListItem Value="Round10">Round10</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <br />
                            </div>
                            <div class="col-md-4">
                                <asp:LinkButton ID="Search" class="btn btn-primary" runat="server" ValidationGroup="staff" OnClick="Search_Click"><i class="fa fa-search"></i> Show Students  List</asp:LinkButton>
                            </div>
                            <%--</div>--%>
                        </div>
                    </div>
                </div>
                <div class="box box-info ">

                    <div class="box-header with-border">
                        <div class="col-md-5">
                            <h3 class="box-title">List of Forward Students </h3>
                        </div>
                        <div class="col-md-4">
                            <div class="input-group">
                                <div class="input-group-btn">
                                    <button type="button" class="btn btn-danger">Round No.: </button>
                                </div>
                                <asp:DropDownList ID="ddlrountsave" runat="server" class="form-control">
                                    <asp:ListItem Value="Round1">Round1</asp:ListItem>
                                    <asp:ListItem Value="Round2">Round2</asp:ListItem>
                                    <asp:ListItem Value="Round3">Round3</asp:ListItem>
                                    <asp:ListItem Value="Round4">Round4</asp:ListItem>
                                    <asp:ListItem Value="Round5">Round5</asp:ListItem>
                                    <asp:ListItem Value="Round6">Round6</asp:ListItem>
                                    <asp:ListItem Value="Round7">Round7</asp:ListItem>
                                    <asp:ListItem Value="Round8">Round8</asp:ListItem>
                                    <asp:ListItem Value="Round9">Round9</asp:ListItem>
                                    <asp:ListItem Value="Round10">Round10</asp:ListItem>
                                    <asp:ListItem Value="Placed">Placed</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="col-md-3">
                            <asp:LinkButton ID="btnSave" class="btn btn-primary" runat="server" OnClick="btnSave_Click"> Forward Students</asp:LinkButton>
                        </div>
                    </div>
                    <!-- /.box-header -->
                    <div class="box-body" align="center" style="font-family: Source Sans Pro; overflow-x: scroll; height: 600px; width: 100%">
                        <div class="form-group">
                            <asp:GridView ID="gvStudent" CssClass="table table-striped table-bordered table-hover"
                                runat="server" CellPadding="3" AutoGenerateColumns="False" BackColor="White"
                                BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" DataKeyNames="Student_ID"
                                EnableModelValidation="True" OnRowCreated="gvStudent_RowCreated">
                                <Columns>
                                    <asp:TemplateField HeaderText="select">
                                        <ItemTemplate>
                                            <asp:CheckBox ID="chkBxSelect" runat="server" />
                                        </ItemTemplate>
                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="50px" />
                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="50px" />
                                        <HeaderTemplate>
                                            <asp:CheckBox ID="chkBxHeader" onclick="javascript:HeaderClick(this);" runat="server" />
                                        </HeaderTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField HeaderText="Student_ID" DataField="Student_ID" />
                                    <asp:BoundField HeaderText="Academic_Year" DataField="Academic_Year" />
                                    <asp:BoundField HeaderText="Student_Name" DataField="Student_Name" />
                                    <asp:BoundField HeaderText="Email" DataField="Email" />
                                    <asp:BoundField HeaderText="Contact_No" DataField="Contact_No" />
                                    <asp:BoundField HeaderText="Company_Name" DataField="Company_Name" />
                                    <asp:BoundField HeaderText="Drive_Title" DataField="Drive_Title" />



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
        </div>
    </section>
</asp:Content>
