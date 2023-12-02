﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="FarmerPurchaseSlipWebFinal.aspx.cs" Inherits="GPILWebApp.FarmerPurchaseSlipWebFinal" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" Namespace="CrystalDecisions.Web" TagPrefix="CR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="page-content" style="background-color: white">

        <div class="row mb-0">
            <div class="col-sm-3">
                <div class="form-sm-3">
                    <label class="control-label">Select Orgn Name </label>
                    <div>
                        <asp:DropDownList runat="server" CssClass="form-control" ID="ddlOrgnCode" AutoPostBack="True" OnSelectedIndexChanged="ddlOrgnCode_SelectedIndexChanged"></asp:DropDownList>
                    </div>
                </div>
            </div>
            <div class="col-sm-3">
                <div class="form-sm-3">
                    <label class="control-label">Farmer Code</label>
                    <div class="form-control-sm">
                        <asp:DropDownList runat="server" CssClass="form-control" ID="ddlFarmerCode" AutoPostBack="True" OnSelectedIndexChanged="ddlFarmerCode_SelectedIndexChanged">
                            <asp:ListItem Value="0">SELECT FAMER CODE</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
            </div>


            <div class="col-sm-3">
                <div class="form-sm-3">
                    
                    <div>
                        <%--  <asp:DropDownList runat="server" CssClass="form-control" ID="DropDownList1" AutoPostBack="True" OnSelectedIndexChanged="ddlOrgnCode_SelectedIndexChanged"></asp:DropDownList>--%>
                       <label class="control-label">Total Number of Lots :  </label>  <asp:Label ID="lblTotalLot" Font-Bold="true" Font-Size="18px" ForeColor="Green"  runat="server" CssClass="control-label" /> 
                    </div>
                </div>
            </div>
            <div class="col-sm-3">
                <div class="form-sm-3">
                   
                    <div class="form-control-sm">
                        <%-- <asp:DropDownList runat="server" CssClass="form-control" ID="DropDownList2" AutoPostBack="True" OnSelectedIndexChanged="ddlFarmerCode_SelectedIndexChanged">
                            <asp:ListItem Value="0">SELECT FAMER CODE</asp:ListItem>
                        </asp:DropDownList>--%>
                        <%--  <asp:TextBox ID="txtTotalBales" runat="server" CssClass="form-control" />--%>
                       <label class="control-label">Farmer Code :</label>  <asp:Label ID="lblTotalBales" runat="server" Font-Bold="true" Font-Size="18px" ForeColor="Green"  CssClass="control-label" />
                    </div>
                </div>
            </div>
        </div>

    <h4 class="header green">Farmer Purchase Slip</h4>

    <div class="col-sm-12" style="width:100%">
        <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" AutoDataBind="true" ToolPanelView="None" HasCrystalLogo="False" HasExportButton="True"  />
        <CR:CrystalReportSource ID="CrystalReportSource1" runat="server">
        </CR:CrystalReportSource>
    </div>
    </div>




</asp:Content>
