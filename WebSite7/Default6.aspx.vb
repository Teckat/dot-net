Imports System.Data
Imports System.Configuration
Imports MySql.Data.MySqlClient
Imports System.Collections.Generic
Partial Class Default6
    Inherits System.Web.UI.Page
    Dim con As MySqlConnection

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con = New MySqlConnection
        con.ConnectionString = ConfigurationManager.ConnectionStrings("sqlconn").ToString


        con.Open()
        Dim cmd2 As New MySqlCommand
        cmd2.Connection = con
        cmd2.CommandText = "insert into table1 (studentid,studentname,gender,address,pincode) values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & DropDownList1.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "')"
        cmd2.ExecuteNonQuery()
        con.Close()


    End Sub
End Class
