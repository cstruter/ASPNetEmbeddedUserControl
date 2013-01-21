<table>
    <tr>
        <td>
            <asp:TextBox ID="txtUrl" runat="server" Width="470px" Text="http://"></asp:TextBox>
        </td>
        <td>
            <asp:Button ID="btnDisplay" runat="server" Text="Go" />
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <iframe id="ifBrowser" width="500px" height="500px" runat="server"></iframe>
        </td>
    </tr>
</table>
