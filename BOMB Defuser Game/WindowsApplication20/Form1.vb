Public Class Form1
    Dim pass1 As Integer
    Dim pass2 As Integer
    Dim pass3 As Integer
    Dim time = 0

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Space Then
            Timer1.Enabled = True
        End If
    End Sub

    
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True

        pass1 = Math.Round(CInt(Math.Floor((9 - 1 + 1) * Rnd())) + 1)
        pass2 = Math.Round(CInt(Math.Floor((9 - 1 + 1) * Rnd())) + 1)
        pass3 = Math.Round(CInt(Math.Floor((9 - 1 + 1) * Rnd())) + 1)
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        
        If TextBox1.Text = pass1 Then
            TextBox1.BackColor = Color.Lime
        Else
            TextBox1.BackColor = Color.White
        End If

        If TextBox2.Text = pass2 Then
            TextBox2.BackColor = Color.Lime
        Else
            TextBox2.BackColor = Color.White
        End If

        If TextBox3.Text = pass3 Then
            TextBox3.BackColor = Color.Lime
        Else
            TextBox3.BackColor = Color.White
        End If
        If TextBox1.Text = pass1 And TextBox2.Text = pass2 And TextBox3.Text = pass3 Then
            Timer1.Enabled = False
            MessageBox.Show("You have defused the bomb", "Winner")
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            Label4.Text = "60"
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label4.Text = Label4.Text - 1
        If Label4.Text = 0 Then
            Timer1.Enabled = False
            MessageBox.Show("The bomb has exploded you have lost", "Loser")
        End If


       

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        Label4.Text = "60"
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        Timer1.Enabled = True
        Me.TextBox1.Select()
        Label7.ForeColor = Color.White
        TextBox1.BackColor = Color.White
        TextBox2.BackColor = Color.White
        TextBox3.BackColor = Color.White
        Form1_Load(sender, e)
        Me.Show()
        pass1 = Math.Round(CInt(Math.Floor((9 - 0 + 1) * Rnd())) + 0)
        pass2 = Math.Round(CInt(Math.Floor((9 - 0 + 1) * Rnd())) + 0)
        pass3 = Math.Round(CInt(Math.Floor((9 - 0 + 1) * Rnd())) + 0)
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If Label7.ForeColor = Color.Lime Then
            Label7.ForeColor = Color.Silver
        End If
        If Label7.ForeColor = Color.Lime Then
            Label7.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub Label6_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label6.MouseHover
        Label6.ForeColor = Color.Lime
    End Sub

    Private Sub Label7_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label7.MouseHover
        Label7.ForeColor = Color.Lime
    End Sub

    Private Sub Form1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        Timer1.Enabled = True
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If Label6.ForeColor = Color.Lime Then
            Label6.ForeColor = Color.Silver
        End If
        If Label7.ForeColor = Color.Lime Then
            Label7.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        TextBox1.SelectAll()
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        TextBox2.SelectAll()
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        TextBox3.SelectAll()
    End Sub
End Class
