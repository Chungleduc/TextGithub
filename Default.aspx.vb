Imports System.Data
Imports System.Data.SqlClient
Partial Class _Default
    Inherits System.Web.UI.Page
    Dim objConn As SqlConnection
    Dim objCmd As SqlCommand
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
       
        Dim strConnString As String
        strConnString = "Data Source=.\SQLEXPRESS;AttachDbFilename=D:\project\WebSite3\App_Data\NORTHWND.MDF;Integrated Security=True;Connect Timeout=30;User Instance=True"
        objConn = New SqlConnection(strConnString)
        objConn.Open()
        BindData()
    End Sub
    Sub BindData()
        Dim strSQL As String
        strSQL = "SELECT * FROM Customers"

        Dim dtReader As SqlDataReader
        objCmd = New SqlCommand(strSQL, objConn)
        dtReader = objCmd.ExecuteReader()
        GridView1.DataSource = dtReader
        GridView1.DataBind()

        dtReader.Close()
        dtReader = Nothing


    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Ci As String = CustomerID.Text
        Dim Cn As String = CompanyName.Text
        Dim Ct As String = ContactName.Text
        Dim Ctt As String = ContactTitle.Text
        Dim Ad As String = Address.Text
        Dim Cty As String = City.Text
        Dim Rg As String = Region.Text
        Dim Pc As String = PostalCode.Text
        Dim Ctry As String = Country.Text
        Dim Ph As String = Phone.Text
        Dim Fa As String = Fax.Text
        Dim sql As String = "insert into Customers values('" & Ci & "','" & Cn & "','" & Ct & "','" & Ctt & "','" & Ad & "','" & Cty & "','" & Rg & "','" & Pc & "','" & Ctry & "','" & Ph & "','" & Fa & "')"
        objCmd = New SqlCommand(sql, objConn)
        Try
            objCmd.ExecuteNonQuery()
        Catch ex As Exception
            Response.Write("<H2>Thêm không thành công</H2>")
        End Try
        Page_Load(sender, e)
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim Ci As String = CustomerID.Text
        Dim Cn As String = CompanyName.Text
        Dim Ct As String = ContactName.Text
        Dim Ctt As String = ContactTitle.Text
        Dim Ad As String = Address.Text
        Dim Cty As String = City.Text
        Dim Rg As String = Region.Text
        Dim Pc As String = PostalCode.Text
        Dim Ctry As String = Country.Text
        Dim Ph As String = Phone.Text
        Dim Fa As String = Fax.Text
        Dim sql As String = "update Customers set CompanyName='" & Cn & "',ContactName='" & Ct & "',ContactTitle='" & Ctt & "',Address='" & Ad & "',City='" & Cty & "',Region='" & Rg & "',PostalCode='" & Pc & "',Country='" & Ctry & "',Phone='" & Ph & "',Fax='" & Fa & "' where CustomerID='" & Ci & "'"
        objCmd = New SqlCommand(sql, objConn)
        Try
            objCmd.ExecuteNonQuery()
        Catch ex As Exception
            Response.Write("<H2>Sửa không thành công</H2>")
        End Try
        Page_Load(sender, e)
    End Sub

    Protected Sub GridView1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.SelectedIndexChanged
        Dim Ci As String = GridView1.SelectedRow.Cells(1).Text
        Dim Cn As String = GridView1.SelectedRow.Cells(2).Text
        Dim Ct As String = GridView1.SelectedRow.Cells(3).Text
        Dim Ctt As String = GridView1.SelectedRow.Cells(4).Text
        Dim Ad As String = GridView1.SelectedRow.Cells(5).Text
        Dim Cty As String = GridView1.SelectedRow.Cells(6).Text
        Dim Rg As String = GridView1.SelectedRow.Cells(7).Text
        Dim Pc As String = GridView1.SelectedRow.Cells(8).Text
        Dim Ctry As String = GridView1.SelectedRow.Cells(9).Text
        Dim Ph As String = GridView1.SelectedRow.Cells(10).Text
        Dim Fa As String = GridView1.SelectedRow.Cells(11).Text
        CustomerID.Text = Ci
        CompanyName.Text = Cn
        ContactName.Text = Ct
        ContactTitle.Text = Ctt
        Address.Text = Ad
        City.Text = Cty
        Region.Text = Rg
        PostalCode.Text = Pc
        Country.Text = Ctry
        Phone.Text = Ph
        Fax.Text = Fa
    End Sub

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim sql As String = "delete from Customers where CustomerID='" & CustomerID.Text & "'"
        objCmd = New SqlCommand(sql, objConn)
        Try
            objCmd.ExecuteNonQuery()
        Catch ex As Exception
            Response.Write("<H2>Xóa không thành công</H2>")
        End Try
        Page_Load(sender, e)
    End Sub
End Class
