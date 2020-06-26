Imports System.Data
Imports System.Configuration
Imports MySql.Data.MySqlClient
Imports System.Collections.Generic
Partial Class Default5
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





        con.Open()
        Dim cmd5 As New MySqlCommand("select * from table1", con)
        Dim da5 As New MySqlDataAdapter(cmd5)
        Dim ds5 As New DataSet
        da5.Fill(ds5)
        GridView1.DataSource = ds5
        GridView1.DataBind()
        con.Close()


    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Response.Redirect(Request.Url.AbsoluteUri)
    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'On Error Resume Next

        con = New MySqlConnection
        con.ConnectionString = ConfigurationManager.ConnectionStrings("sqlconn").ToString



        con.Open()
        Dim cmd2 As New MySqlCommand
        cmd2.Connection = con
        cmd2.CommandText = "update table1 set studentname='" & TextBox2.Text & "',gender='" & DropDownList1.Text & "',address='" & TextBox3.Text & "',pincode='" & TextBox4.Text & "' where studentid like '" & TextBox1.Text & "'"
        cmd2.ExecuteNonQuery()
        con.Close()

        con.Open()
        Dim cmd5 As New MySqlCommand("select * from table1", con)
        Dim da5 As New MySqlDataAdapter(cmd5)
        Dim ds5 As New DataSet
        da5.Fill(ds5)
        GridView1.DataSource = ds5
        GridView1.DataBind()
        con.Close()

    End Sub

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        con = New MySqlConnection
        con.ConnectionString = ConfigurationManager.ConnectionStrings("sqlconn").ToString



        con.Open()
        Dim cmd2 As New MySqlCommand
        cmd2.Connection = con
        cmd2.CommandText = "delete from table1 where studentid like '" & TextBox1.Text & "'"
        cmd2.ExecuteNonQuery()
        con.Close()


        con.Open()
        Dim cmd5 As New MySqlCommand("select * from table1", con)
        Dim da5 As New MySqlDataAdapter(cmd5)
        Dim ds5 As New DataSet
        da5.Fill(ds5)
        GridView1.DataSource = ds5
        GridView1.DataBind()
        con.Close()

    End Sub
End Class
