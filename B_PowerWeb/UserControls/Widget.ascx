<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Widget.ascx.cs" Inherits="B_PowerWeb.Widget" %>

<div class="col <%=CssClass%> demo-tab-<%=(Index+1) %>">
    <div class="demo-widget-area demo-tab-card card <%=ContentCssClass %>">
        <asp:PlaceHolder ID="WidgetContentControl" runat="server"></asp:PlaceHolder>
    </div>
</div>