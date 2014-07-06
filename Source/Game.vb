Imports System.Text.RegularExpressions

Public Class Game
    Dim Rand As New Random
    Dim Random As Integer
    Dim Word As String
    Dim Wordlen As Integer
    Dim Dead As Integer = 0
    Dim k As Integer = 1
    Dim Words() As String = {"WINDOW", "BOOK", "EXORCIST", "WINDOWS", "LOAD", "CLOCK", "SPACE", "TOOL", "POWER", "SPIRIT", "DRAGON", "WORLD", "THUNDER", "PROGRAM", "FORCE", "METALLICA", "EMINEM", "WORD", "SPLASH", "HANGMAN", "BLEH", "MEMORY", "HELP", "DIRECTOR", "COMPUTER"}
    Private Sub Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (k = 1) Then
            Block_Butttons()
            k = 0
        End If
    End Sub
    Private Sub Block_Butttons()
        Word_Button1.Enabled = False
        Word_Button2.Enabled = False
        Word_Button3.Enabled = False
        Word_Button4.Enabled = False
        Word_Button5.Enabled = False
        Word_Button6.Enabled = False
        Word_Button7.Enabled = False
        Word_Button8.Enabled = False
        Word_Button9.Enabled = False
        Word_Button10.Enabled = False
        Word_Button11.Enabled = False
        Word_Button12.Enabled = False
        Word_Button13.Enabled = False
        Word_Button14.Enabled = False
        Word_Button15.Enabled = False
        Word_Button16.Enabled = False
        Word_Button17.Enabled = False
        Word_Button18.Enabled = False
        Word_Button19.Enabled = False
        Word_Button20.Enabled = False
        Word_Button21.Enabled = False
        Word_Button22.Enabled = False
        Word_Button23.Enabled = False
        Word_Button24.Enabled = False
        Word_Button25.Enabled = False
        Word_Button26.Enabled = False
        Accept_btn.Enabled = False
    End Sub

    Private Sub Enable_Buttons()
        Word_Button1.Enabled = True
        Word_Button2.Enabled = True
        Word_Button3.Enabled = True
        Word_Button4.Enabled = True
        Word_Button5.Enabled = True
        Word_Button6.Enabled = True
        Word_Button7.Enabled = True
        Word_Button8.Enabled = True
        Word_Button9.Enabled = True
        Word_Button10.Enabled = True
        Word_Button11.Enabled = True
        Word_Button12.Enabled = True
        Word_Button13.Enabled = True
        Word_Button14.Enabled = True
        Word_Button15.Enabled = True
        Word_Button16.Enabled = True
        Word_Button17.Enabled = True
        Word_Button18.Enabled = True
        Word_Button19.Enabled = True
        Word_Button20.Enabled = True
        Word_Button21.Enabled = True
        Word_Button22.Enabled = True
        Word_Button23.Enabled = True
        Word_Button24.Enabled = True
        Word_Button25.Enabled = True
        Word_Button26.Enabled = True

        Word_Button1.BackColor = Control.DefaultBackColor
        Word_Button2.BackColor = Control.DefaultBackColor
        Word_Button3.BackColor = Control.DefaultBackColor
        Word_Button4.BackColor = Control.DefaultBackColor
        Word_Button5.BackColor = Control.DefaultBackColor
        Word_Button6.BackColor = Control.DefaultBackColor
        Word_Button7.BackColor = Control.DefaultBackColor
        Word_Button8.BackColor = Control.DefaultBackColor
        Word_Button9.BackColor = Control.DefaultBackColor
        Word_Button10.BackColor = Control.DefaultBackColor
        Word_Button11.BackColor = Control.DefaultBackColor
        Word_Button12.BackColor = Control.DefaultBackColor
        Word_Button13.BackColor = Control.DefaultBackColor
        Word_Button14.BackColor = Control.DefaultBackColor
        Word_Button15.BackColor = Control.DefaultBackColor
        Word_Button16.BackColor = Control.DefaultBackColor
        Word_Button17.BackColor = Control.DefaultBackColor
        Word_Button18.BackColor = Control.DefaultBackColor
        Word_Button19.BackColor = Control.DefaultBackColor
        Word_Button20.BackColor = Control.DefaultBackColor
        Word_Button21.BackColor = Control.DefaultBackColor
        Word_Button22.BackColor = Control.DefaultBackColor
        Word_Button23.BackColor = Control.DefaultBackColor
        Word_Button24.BackColor = Control.DefaultBackColor
        Word_Button25.BackColor = Control.DefaultBackColor
        Word_Button26.BackColor = Control.DefaultBackColor
    End Sub
    Private Sub Change_Picture()
        If (Dead = 1) Then
            PictureBox1.Image = My.Resources._22
        End If
        If (Dead = 2) Then
            PictureBox1.Image = My.Resources._3
        End If
        If (Dead = 3) Then
            PictureBox1.Image = My.Resources._4
        End If
        If (Dead = 4) Then
            PictureBox1.Image = My.Resources._5
        End If
        If (Dead = 5) Then
            PictureBox1.Image = My.Resources._6
        End If
        If (Dead = 6) Then
            PictureBox1.Image = My.Resources._7
        End If
        If (Dead = 7) Then
            PictureBox1.Image = My.Resources._8
        End If
        If (Dead = 8) Then
            PictureBox1.Image = My.Resources.game_over
            MessageBox.Show("The Word WAS: " + Word, "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Block_Butttons()
        End If
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Word_Button8.Click
        Dim Found As Boolean = False
        For i As Integer = 0 To Wordlen - 1
            If (Word_Button8.Text = Word(i)) Then
                Found = True
                If (Label1.Text = (i + 1).ToString) Then
                    Label1.Text = Word_Button8.Text
                End If
                If (Label2.Text = (i + 1).ToString) Then
                    Label2.Text = Word_Button8.Text
                End If
                If (Label3.Text = (i + 1).ToString) Then
                    Label3.Text = Word_Button8.Text
                End If
                If (Label4.Text = (i + 1).ToString) Then
                    Label4.Text = Word_Button8.Text
                End If
                If (Label5.Text = (i + 1).ToString) Then
                    Label5.Text = Word_Button8.Text
                End If
                If (Label6.Text = (i + 1).ToString) Then
                    Label6.Text = Word_Button8.Text
                End If
                If (Label7.Text = (i + 1).ToString) Then
                    Label7.Text = Word_Button8.Text
                End If
                If (Label8.Text = (i + 1).ToString) Then
                    Label8.Text = Word_Button8.Text
                End If
                If (Label9.Text = (i + 1).ToString) Then
                    Label9.Text = Word_Button8.Text
                End If
            End If
        Next
        If Found = False Then
            Word_Button8.BackColor = Color.Red
            Word_Button8.Enabled = False
            Dead += 1
            Change_Picture()
        End If
        If Found = True Then
            Word_Button8.Enabled = False
        End If
    End Sub
    Private Sub Back_btn_Click(sender As Object, e As EventArgs) Handles Back_btn.Click
        HangMan_By_Vahe.Menu.Show()
        Me.Close()
    End Sub
    Private Sub Check_For_Win()
        If (Wordlen = 1 And Label1.Text <> "1") Then
            PictureBox1.Image = My.Resources.WIN
            MessageBox.Show("You Won!", "Victory", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Block_Butttons()
        End If
        If Wordlen = 2 And Label1.Text <> "1" And Label2.Text <> "2" Then
            PictureBox1.Image = My.Resources.WIN
            MessageBox.Show("You Won!", "Victory", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Block_Butttons()
        End If
        If (Wordlen = 3 And Label1.Text <> "1" And Label2.Text <> "2" And Label3.Text <> "3") Then
            PictureBox1.Image = My.Resources.WIN
            MessageBox.Show("You Won!", "Victory", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Block_Butttons()
        End If
        If (Wordlen = 4 And Label1.Text <> "1" And Label2.Text <> "2" And Label3.Text <> "3" And Label4.Text <> "4") Then
            PictureBox1.Image = My.Resources.WIN
            MessageBox.Show("You Won!", "Victory", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Block_Butttons()
        End If
        If (Wordlen = 5 And Label1.Text <> "1" And Label2.Text <> "2" And Label3.Text <> "3" And Label4.Text <> "4" And Label5.Text <> "5") Then
            PictureBox1.Image = My.Resources.WIN
            MessageBox.Show("You Won!", "Victory", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Block_Butttons()
        End If
        If (Wordlen = 6 And Label1.Text <> "1" And Label2.Text <> "2" And Label3.Text <> "3" And Label4.Text <> "4" And Label5.Text <> "5" And Label6.Text <> "6") Then
            PictureBox1.Image = My.Resources.WIN
            MessageBox.Show("You Won!", "Victory", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Block_Butttons()
        End If
        If (Wordlen = 7 And Label1.Text <> "1" And Label2.Text <> "2" And Label3.Text <> "3" And Label4.Text <> "4" And Label5.Text <> "5" And Label6.Text <> "6" And Label7.Text <> "7") Then
            PictureBox1.Image = My.Resources.WIN
            MessageBox.Show("You Won!", "Victory", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Block_Butttons()
        End If
        If (Wordlen = 8 And Label1.Text <> "1" And Label2.Text <> "2" And Label3.Text <> "3" And Label4.Text <> "4" And Label5.Text <> "5" And Label6.Text <> "6" And Label7.Text <> "7" And Label8.Text <> "8") Then
            PictureBox1.Image = My.Resources.WIN
            MessageBox.Show("You Won!", "Victory", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Block_Butttons()
        End If
        If (Wordlen = 9 And Label1.Text <> "1" And Label2.Text <> "2" And Label3.Text <> "3" And Label4.Text <> "4" And Label5.Text <> "5" And Label6.Text <> "6" And Label7.Text <> "7" And Label8.Text <> "8" And Label9.Text <> "9") Then
            PictureBox1.Image = My.Resources.WIN
            MessageBox.Show("You Won!", "Victory", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Block_Butttons()
        End If
    End Sub

    Private Sub Start_btn_Click(sender As Object, e As EventArgs) Handles Start_btn.Click
        Random = Rand.Next(0, 24)
        Word = Words(Random)
        Wordlen = Word.Length()
        Label1.Text = ""
        Label2.Text = ""
        Label3.Text = ""
        Label4.Text = ""
        Label5.Text = ""
        Label6.Text = ""
        Label7.Text = ""
        Label8.Text = ""
        Label9.Text = ""
        For i As Integer = 0 To Wordlen - 1
            If i = 0 Then
                Label1.Text = "1"
            End If
            If i = 1 Then
                Label2.Text = "2"
            End If
            If i = 2 Then
                Label3.Text = "3"
            End If
            If i = 3 Then
                Label4.Text = "4"
            End If
            If i = 4 Then
                Label5.Text = "5"
            End If
            If i = 5 Then
                Label6.Text = "6"
            End If
            If i = 6 Then
                Label7.Text = "7"
            End If
            If i = 7 Then
                Label8.Text = "8"
            End If
            If i = 8 Then
                Label9.Text = "9"
            End If
        Next
        Enable_Buttons()
        Accept_btn.Enabled = True
        Dead = 0
        PictureBox1.Image = My.Resources._12
        Accept_tb.Text = ""
    End Sub

    Private Sub Accept_btn_Click(sender As Object, e As EventArgs) Handles Accept_btn.Click
        Dim Wordch As String
        Wordch = Word.ToUpper()
        If Wordch = Word Then
            PictureBox1.Image = My.Resources.WIN
            MessageBox.Show("You Won!", "Victory", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Block_Butttons()
        End If
    End Sub

    Private Sub Word_Button1_Click(sender As Object, e As EventArgs) Handles Word_Button1.Click
        Dim Found As Boolean = False
        For i As Integer = 0 To Wordlen - 1
            If (Word_Button1.Text = Word(i)) Then
                Found = True
                If (Label1.Text = (i + 1).ToString) Then
                    Label1.Text = Word_Button1.Text
                End If
                If (Label2.Text = (i + 1).ToString) Then
                    Label2.Text = Word_Button1.Text
                End If
                If (Label3.Text = (i + 1).ToString) Then
                    Label3.Text = Word_Button1.Text
                End If
                If (Label4.Text = (i + 1).ToString) Then
                    Label4.Text = Word_Button1.Text
                End If
                If (Label5.Text = (i + 1).ToString) Then
                    Label5.Text = Word_Button1.Text
                End If
                If (Label6.Text = (i + 1).ToString) Then
                    Label6.Text = Word_Button1.Text
                End If
                If (Label7.Text = (i + 1).ToString) Then
                    Label7.Text = Word_Button1.Text
                End If
                If (Label8.Text = (i + 1).ToString) Then
                    Label8.Text = Word_Button1.Text
                End If
                If (Label9.Text = (i + 1).ToString) Then
                    Label9.Text = Word_Button1.Text
                End If
            End If
        Next
        If Found = False Then
            Word_Button1.BackColor = Color.Red
            Word_Button1.Enabled = False
            Dead += 1
            Change_Picture()
        End If
        If Found = True Then
            Word_Button1.Enabled = False
        End If
        Check_For_Win()
    End Sub

    Private Sub Word_Button2_Click(sender As Object, e As EventArgs) Handles Word_Button2.Click
        Dim Found As Boolean = False
        For i As Integer = 0 To Wordlen - 1
            If (Word_Button2.Text = Word(i)) Then
                Found = True
                If (Label1.Text = (i + 1).ToString) Then
                    Label1.Text = Word_Button2.Text
                End If
                If (Label2.Text = (i + 1).ToString) Then
                    Label2.Text = Word_Button2.Text
                End If
                If (Label3.Text = (i + 1).ToString) Then
                    Label3.Text = Word_Button2.Text
                End If
                If (Label4.Text = (i + 1).ToString) Then
                    Label4.Text = Word_Button2.Text
                End If
                If (Label5.Text = (i + 1).ToString) Then
                    Label5.Text = Word_Button2.Text
                End If
                If (Label6.Text = (i + 1).ToString) Then
                    Label6.Text = Word_Button2.Text
                End If
                If (Label7.Text = (i + 1).ToString) Then
                    Label7.Text = Word_Button2.Text
                End If
                If (Label8.Text = (i + 1).ToString) Then
                    Label8.Text = Word_Button2.Text
                End If
                If (Label9.Text = (i + 1).ToString) Then
                    Label9.Text = Word_Button2.Text
                End If
            End If
        Next
        If Found = False Then
            Word_Button2.BackColor = Color.Red
            Word_Button2.Enabled = False
            Dead += 1
            Change_Picture()
        End If
        If Found = True Then
            Word_Button2.Enabled = False
        End If
        Check_For_Win()
    End Sub

    Private Sub Word_Button3_Click(sender As Object, e As EventArgs) Handles Word_Button3.Click
        Dim Found As Boolean = False
        For i As Integer = 0 To Wordlen - 1
            If (Word_Button3.Text = Word(i)) Then
                Found = True
                If (Label1.Text = (i + 1).ToString) Then
                    Label1.Text = Word_Button3.Text
                End If
                If (Label2.Text = (i + 1).ToString) Then
                    Label2.Text = Word_Button3.Text
                End If
                If (Label3.Text = (i + 1).ToString) Then
                    Label3.Text = Word_Button3.Text
                End If
                If (Label4.Text = (i + 1).ToString) Then
                    Label4.Text = Word_Button3.Text
                End If
                If (Label5.Text = (i + 1).ToString) Then
                    Label5.Text = Word_Button3.Text
                End If
                If (Label6.Text = (i + 1).ToString) Then
                    Label6.Text = Word_Button3.Text
                End If
                If (Label7.Text = (i + 1).ToString) Then
                    Label7.Text = Word_Button3.Text
                End If
                If (Label8.Text = (i + 1).ToString) Then
                    Label8.Text = Word_Button3.Text
                End If
                If (Label9.Text = (i + 1).ToString) Then
                    Label9.Text = Word_Button3.Text
                End If
            End If
        Next
        If Found = False Then
            Word_Button3.BackColor = Color.Red
            Word_Button3.Enabled = False
            Dead += 1
            Change_Picture()
        End If
        If Found = True Then
            Word_Button3.Enabled = False
        End If
        Check_For_Win()
    End Sub

    Private Sub Word_Button4_Click(sender As Object, e As EventArgs) Handles Word_Button4.Click
        Dim Found As Boolean = False
        For i As Integer = 0 To Wordlen - 1
            If (Word_Button4.Text = Word(i)) Then
                Found = True
                If (Label1.Text = (i + 1).ToString) Then
                    Label1.Text = Word_Button4.Text
                End If
                If (Label2.Text = (i + 1).ToString) Then
                    Label2.Text = Word_Button4.Text
                End If
                If (Label3.Text = (i + 1).ToString) Then
                    Label3.Text = Word_Button4.Text
                End If
                If (Label4.Text = (i + 1).ToString) Then
                    Label4.Text = Word_Button4.Text
                End If
                If (Label5.Text = (i + 1).ToString) Then
                    Label5.Text = Word_Button4.Text
                End If
                If (Label6.Text = (i + 1).ToString) Then
                    Label6.Text = Word_Button4.Text
                End If
                If (Label7.Text = (i + 1).ToString) Then
                    Label7.Text = Word_Button4.Text
                End If
                If (Label8.Text = (i + 1).ToString) Then
                    Label8.Text = Word_Button4.Text
                End If
                If (Label9.Text = (i + 1).ToString) Then
                    Label9.Text = Word_Button4.Text
                End If
            End If
        Next
        If Found = False Then
            Word_Button4.BackColor = Color.Red
            Word_Button4.Enabled = False
            Dead += 1
            Change_Picture()
        End If
        If Found = True Then
            Word_Button4.Enabled = False
        End If
        Check_For_Win()
    End Sub

    Private Sub Word_Button5_Click(sender As Object, e As EventArgs) Handles Word_Button5.Click
        Dim Found As Boolean = False
        For i As Integer = 0 To Wordlen - 1
            If (Word_Button5.Text = Word(i)) Then
                Found = True
                If (Label1.Text = (i + 1).ToString) Then
                    Label1.Text = Word_Button5.Text
                End If
                If (Label2.Text = (i + 1).ToString) Then
                    Label2.Text = Word_Button5.Text
                End If
                If (Label3.Text = (i + 1).ToString) Then
                    Label3.Text = Word_Button5.Text
                End If
                If (Label4.Text = (i + 1).ToString) Then
                    Label4.Text = Word_Button5.Text
                End If
                If (Label5.Text = (i + 1).ToString) Then
                    Label5.Text = Word_Button5.Text
                End If
                If (Label6.Text = (i + 1).ToString) Then
                    Label6.Text = Word_Button5.Text
                End If
                If (Label7.Text = (i + 1).ToString) Then
                    Label7.Text = Word_Button5.Text
                End If
                If (Label8.Text = (i + 1).ToString) Then
                    Label8.Text = Word_Button5.Text
                End If
                If (Label9.Text = (i + 1).ToString) Then
                    Label9.Text = Word_Button5.Text
                End If
            End If
        Next
        If Found = False Then
            Word_Button5.BackColor = Color.Red
            Word_Button5.Enabled = False
            Dead += 1
            Change_Picture()
        End If
        If Found = True Then
            Word_Button5.Enabled = False
        End If
        Check_For_Win()
    End Sub

    Private Sub Word_Button6_Click(sender As Object, e As EventArgs) Handles Word_Button6.Click
        Dim Found As Boolean = False
        For i As Integer = 0 To Wordlen - 1
            If (Word_Button6.Text = Word(i)) Then
                Found = True
                If (Label1.Text = (i + 1).ToString) Then
                    Label1.Text = Word_Button6.Text
                End If
                If (Label2.Text = (i + 1).ToString) Then
                    Label2.Text = Word_Button6.Text
                End If
                If (Label3.Text = (i + 1).ToString) Then
                    Label3.Text = Word_Button6.Text
                End If
                If (Label4.Text = (i + 1).ToString) Then
                    Label4.Text = Word_Button6.Text
                End If
                If (Label5.Text = (i + 1).ToString) Then
                    Label5.Text = Word_Button6.Text
                End If
                If (Label6.Text = (i + 1).ToString) Then
                    Label6.Text = Word_Button6.Text
                End If
                If (Label7.Text = (i + 1).ToString) Then
                    Label7.Text = Word_Button6.Text
                End If
                If (Label8.Text = (i + 1).ToString) Then
                    Label8.Text = Word_Button6.Text
                End If
                If (Label9.Text = (i + 1).ToString) Then
                    Label9.Text = Word_Button6.Text
                End If
            End If
        Next
        If Found = False Then
            Word_Button6.BackColor = Color.Red
            Word_Button6.Enabled = False
            Dead += 1
            Change_Picture()
        End If
        If Found = True Then
            Word_Button6.Enabled = False
        End If
        Check_For_Win()
    End Sub

    Private Sub Word_Button7_Click(sender As Object, e As EventArgs) Handles Word_Button7.Click
        Dim Found As Boolean = False
        For i As Integer = 0 To Wordlen - 1
            If (Word_Button7.Text = Word(i)) Then
                Found = True
                If (Label1.Text = (i + 1).ToString) Then
                    Label1.Text = Word_Button7.Text
                End If
                If (Label2.Text = (i + 1).ToString) Then
                    Label2.Text = Word_Button7.Text
                End If
                If (Label3.Text = (i + 1).ToString) Then
                    Label3.Text = Word_Button7.Text
                End If
                If (Label4.Text = (i + 1).ToString) Then
                    Label4.Text = Word_Button7.Text
                End If
                If (Label5.Text = (i + 1).ToString) Then
                    Label5.Text = Word_Button7.Text
                End If
                If (Label6.Text = (i + 1).ToString) Then
                    Label6.Text = Word_Button7.Text
                End If
                If (Label7.Text = (i + 1).ToString) Then
                    Label7.Text = Word_Button7.Text
                End If
                If (Label8.Text = (i + 1).ToString) Then
                    Label8.Text = Word_Button7.Text
                End If
                If (Label9.Text = (i + 1).ToString) Then
                    Label9.Text = Word_Button7.Text
                End If
            End If
        Next
        If Found = False Then
            Word_Button7.BackColor = Color.Red
            Word_Button7.Enabled = False
            Dead += 1
            Change_Picture()
        End If
        If Found = True Then
            Word_Button7.Enabled = False
        End If
        Check_For_Win()
    End Sub

    Private Sub Word_Button9_Click(sender As Object, e As EventArgs) Handles Word_Button9.Click
        Dim Found As Boolean = False
        For i As Integer = 0 To Wordlen - 1
            If (Word_Button9.Text = Word(i)) Then
                Found = True
                If (Label1.Text = (i + 1).ToString) Then
                    Label1.Text = Word_Button9.Text
                End If
                If (Label2.Text = (i + 1).ToString) Then
                    Label2.Text = Word_Button9.Text
                End If
                If (Label3.Text = (i + 1).ToString) Then
                    Label3.Text = Word_Button9.Text
                End If
                If (Label4.Text = (i + 1).ToString) Then
                    Label4.Text = Word_Button9.Text
                End If
                If (Label5.Text = (i + 1).ToString) Then
                    Label5.Text = Word_Button9.Text
                End If
                If (Label6.Text = (i + 1).ToString) Then
                    Label6.Text = Word_Button9.Text
                End If
                If (Label7.Text = (i + 1).ToString) Then
                    Label7.Text = Word_Button9.Text
                End If
                If (Label8.Text = (i + 1).ToString) Then
                    Label8.Text = Word_Button9.Text
                End If
                If (Label9.Text = (i + 1).ToString) Then
                    Label9.Text = Word_Button9.Text
                End If
            End If
        Next
        If Found = False Then
            Word_Button9.BackColor = Color.Red
            Word_Button9.Enabled = False
            Dead += 1
            Change_Picture()
        End If
        If Found = True Then
            Word_Button9.Enabled = False
        End If
        Check_For_Win()
    End Sub

    Private Sub Word_Button10_Click(sender As Object, e As EventArgs) Handles Word_Button10.Click
        Dim Found As Boolean = False
        For i As Integer = 0 To Wordlen - 1
            If (Word_Button10.Text = Word(i)) Then
                Found = True
                If (Label1.Text = (i + 1).ToString) Then
                    Label1.Text = Word_Button10.Text
                End If
                If (Label2.Text = (i + 1).ToString) Then
                    Label2.Text = Word_Button10.Text
                End If
                If (Label3.Text = (i + 1).ToString) Then
                    Label3.Text = Word_Button10.Text
                End If
                If (Label4.Text = (i + 1).ToString) Then
                    Label4.Text = Word_Button10.Text
                End If
                If (Label5.Text = (i + 1).ToString) Then
                    Label5.Text = Word_Button10.Text
                End If
                If (Label6.Text = (i + 1).ToString) Then
                    Label6.Text = Word_Button10.Text
                End If
                If (Label7.Text = (i + 1).ToString) Then
                    Label7.Text = Word_Button10.Text
                End If
                If (Label8.Text = (i + 1).ToString) Then
                    Label8.Text = Word_Button10.Text
                End If
                If (Label9.Text = (i + 1).ToString) Then
                    Label9.Text = Word_Button10.Text
                End If
            End If
        Next
        If Found = False Then
            Word_Button10.BackColor = Color.Red
            Word_Button10.Enabled = False
            Dead += 1
            Change_Picture()
        End If
        If Found = True Then
            Word_Button10.Enabled = False
        End If
        Check_For_Win()
    End Sub

    Private Sub Word_Button11_Click(sender As Object, e As EventArgs) Handles Word_Button11.Click
        Dim Found As Boolean = False
        For i As Integer = 0 To Wordlen - 1
            If (Word_Button11.Text = Word(i)) Then
                Found = True
                If (Label1.Text = (i + 1).ToString) Then
                    Label1.Text = Word_Button11.Text
                End If
                If (Label2.Text = (i + 1).ToString) Then
                    Label2.Text = Word_Button11.Text
                End If
                If (Label3.Text = (i + 1).ToString) Then
                    Label3.Text = Word_Button11.Text
                End If
                If (Label4.Text = (i + 1).ToString) Then
                    Label4.Text = Word_Button11.Text
                End If
                If (Label5.Text = (i + 1).ToString) Then
                    Label5.Text = Word_Button11.Text
                End If
                If (Label6.Text = (i + 1).ToString) Then
                    Label6.Text = Word_Button11.Text
                End If
                If (Label7.Text = (i + 1).ToString) Then
                    Label7.Text = Word_Button11.Text
                End If
                If (Label8.Text = (i + 1).ToString) Then
                    Label8.Text = Word_Button11.Text
                End If
                If (Label9.Text = (i + 1).ToString) Then
                    Label9.Text = Word_Button11.Text
                End If
            End If
        Next
        If Found = False Then
            Word_Button11.BackColor = Color.Red
            Word_Button11.Enabled = False
            Dead += 1
            Change_Picture()
        End If
        If Found = True Then
            Word_Button11.Enabled = False
        End If
        Check_For_Win()
    End Sub

    Private Sub Word_Button12_Click(sender As Object, e As EventArgs) Handles Word_Button12.Click
        Dim Found As Boolean = False
        For i As Integer = 0 To Wordlen - 1
            If (Word_Button12.Text = Word(i)) Then
                Found = True
                If (Label1.Text = (i + 1).ToString) Then
                    Label1.Text = Word_Button12.Text
                End If
                If (Label2.Text = (i + 1).ToString) Then
                    Label2.Text = Word_Button12.Text
                End If
                If (Label3.Text = (i + 1).ToString) Then
                    Label3.Text = Word_Button12.Text
                End If
                If (Label4.Text = (i + 1).ToString) Then
                    Label4.Text = Word_Button12.Text
                End If
                If (Label5.Text = (i + 1).ToString) Then
                    Label5.Text = Word_Button12.Text
                End If
                If (Label6.Text = (i + 1).ToString) Then
                    Label6.Text = Word_Button12.Text
                End If
                If (Label7.Text = (i + 1).ToString) Then
                    Label7.Text = Word_Button12.Text
                End If
                If (Label8.Text = (i + 1).ToString) Then
                    Label8.Text = Word_Button12.Text
                End If
                If (Label9.Text = (i + 1).ToString) Then
                    Label9.Text = Word_Button12.Text
                End If
            End If
        Next
        If Found = False Then
            Word_Button12.BackColor = Color.Red
            Word_Button12.Enabled = False
            Dead += 1
            Change_Picture()
        End If
        If Found = True Then
            Word_Button12.Enabled = False
        End If
        Check_For_Win()
    End Sub

    Private Sub Word_Button13_Click(sender As Object, e As EventArgs) Handles Word_Button13.Click
        Dim Found As Boolean = False
        For i As Integer = 0 To Wordlen - 1
            If (Word_Button13.Text = Word(i)) Then
                Found = True
                If (Label1.Text = (i + 1).ToString) Then
                    Label1.Text = Word_Button13.Text
                End If
                If (Label2.Text = (i + 1).ToString) Then
                    Label2.Text = Word_Button13.Text
                End If
                If (Label3.Text = (i + 1).ToString) Then
                    Label3.Text = Word_Button13.Text
                End If
                If (Label4.Text = (i + 1).ToString) Then
                    Label4.Text = Word_Button13.Text
                End If
                If (Label5.Text = (i + 1).ToString) Then
                    Label5.Text = Word_Button13.Text
                End If
                If (Label6.Text = (i + 1).ToString) Then
                    Label6.Text = Word_Button13.Text
                End If
                If (Label7.Text = (i + 1).ToString) Then
                    Label7.Text = Word_Button13.Text
                End If
                If (Label8.Text = (i + 1).ToString) Then
                    Label8.Text = Word_Button13.Text
                End If
                If (Label9.Text = (i + 1).ToString) Then
                    Label9.Text = Word_Button13.Text
                End If
            End If
        Next
        If Found = False Then
            Word_Button13.BackColor = Color.Red
            Word_Button13.Enabled = False
            Dead += 1
            Change_Picture()
        End If
        If Found = True Then
            Word_Button13.Enabled = False
        End If
        Check_For_Win()
    End Sub

    Private Sub Word_Button14_Click(sender As Object, e As EventArgs) Handles Word_Button14.Click
        Dim Found As Boolean = False
        For i As Integer = 0 To Wordlen - 1
            If (Word_Button14.Text = Word(i)) Then
                Found = True
                If (Label1.Text = (i + 1).ToString) Then
                    Label1.Text = Word_Button14.Text
                End If
                If (Label2.Text = (i + 1).ToString) Then
                    Label2.Text = Word_Button14.Text
                End If
                If (Label3.Text = (i + 1).ToString) Then
                    Label3.Text = Word_Button14.Text
                End If
                If (Label4.Text = (i + 1).ToString) Then
                    Label4.Text = Word_Button14.Text
                End If
                If (Label5.Text = (i + 1).ToString) Then
                    Label5.Text = Word_Button14.Text
                End If
                If (Label6.Text = (i + 1).ToString) Then
                    Label6.Text = Word_Button14.Text
                End If
                If (Label7.Text = (i + 1).ToString) Then
                    Label7.Text = Word_Button14.Text
                End If
                If (Label8.Text = (i + 1).ToString) Then
                    Label8.Text = Word_Button14.Text
                End If
                If (Label9.Text = (i + 1).ToString) Then
                    Label9.Text = Word_Button14.Text
                End If
            End If
        Next
        If Found = False Then
            Word_Button14.BackColor = Color.Red
            Word_Button14.Enabled = False
            Dead += 1
            Change_Picture()
        End If
        If Found = True Then
            Word_Button14.Enabled = False
        End If
        Check_For_Win()
    End Sub

    Private Sub Word_Button15_Click(sender As Object, e As EventArgs) Handles Word_Button15.Click
        Dim Found As Boolean = False
        For i As Integer = 0 To Wordlen - 1
            If (Word_Button15.Text = Word(i)) Then
                Found = True
                If (Label1.Text = (i + 1).ToString) Then
                    Label1.Text = Word_Button15.Text
                End If
                If (Label2.Text = (i + 1).ToString) Then
                    Label2.Text = Word_Button15.Text
                End If
                If (Label3.Text = (i + 1).ToString) Then
                    Label3.Text = Word_Button15.Text
                End If
                If (Label4.Text = (i + 1).ToString) Then
                    Label4.Text = Word_Button15.Text
                End If
                If (Label5.Text = (i + 1).ToString) Then
                    Label5.Text = Word_Button15.Text
                End If
                If (Label6.Text = (i + 1).ToString) Then
                    Label6.Text = Word_Button15.Text
                End If
                If (Label7.Text = (i + 1).ToString) Then
                    Label7.Text = Word_Button15.Text
                End If
                If (Label8.Text = (i + 1).ToString) Then
                    Label8.Text = Word_Button15.Text
                End If
                If (Label9.Text = (i + 1).ToString) Then
                    Label9.Text = Word_Button15.Text
                End If
            End If
        Next
        If Found = False Then
            Word_Button15.BackColor = Color.Red
            Word_Button15.Enabled = False
            Dead += 1
            Change_Picture()
        End If
        If Found = True Then
            Word_Button15.Enabled = False
        End If
        Check_For_Win()
    End Sub

    Private Sub Word_Button16_Click(sender As Object, e As EventArgs) Handles Word_Button16.Click
        Dim Found As Boolean = False
        For i As Integer = 0 To Wordlen - 1
            If (Word_Button16.Text = Word(i)) Then
                Found = True
                If (Label1.Text = (i + 1).ToString) Then
                    Label1.Text = Word_Button16.Text
                End If
                If (Label2.Text = (i + 1).ToString) Then
                    Label2.Text = Word_Button16.Text
                End If
                If (Label3.Text = (i + 1).ToString) Then
                    Label3.Text = Word_Button16.Text
                End If
                If (Label4.Text = (i + 1).ToString) Then
                    Label4.Text = Word_Button16.Text
                End If
                If (Label5.Text = (i + 1).ToString) Then
                    Label5.Text = Word_Button16.Text
                End If
                If (Label6.Text = (i + 1).ToString) Then
                    Label6.Text = Word_Button16.Text
                End If
                If (Label7.Text = (i + 1).ToString) Then
                    Label7.Text = Word_Button16.Text
                End If
                If (Label8.Text = (i + 1).ToString) Then
                    Label8.Text = Word_Button16.Text
                End If
                If (Label9.Text = (i + 1).ToString) Then
                    Label9.Text = Word_Button16.Text
                End If
            End If
        Next
        If Found = False Then
            Word_Button16.BackColor = Color.Red
            Word_Button16.Enabled = False
            Dead += 1
            Change_Picture()
        End If
        If Found = True Then
            Word_Button16.Enabled = False
        End If
        Check_For_Win()
    End Sub

    Private Sub Word_Button17_Click(sender As Object, e As EventArgs) Handles Word_Button17.Click
        Dim Found As Boolean = False
        For i As Integer = 0 To Wordlen - 1
            If (Word_Button17.Text = Word(i)) Then
                Found = True
                If (Label1.Text = (i + 1).ToString) Then
                    Label1.Text = Word_Button17.Text
                End If
                If (Label2.Text = (i + 1).ToString) Then
                    Label2.Text = Word_Button17.Text
                End If
                If (Label3.Text = (i + 1).ToString) Then
                    Label3.Text = Word_Button17.Text
                End If
                If (Label4.Text = (i + 1).ToString) Then
                    Label4.Text = Word_Button17.Text
                End If
                If (Label5.Text = (i + 1).ToString) Then
                    Label5.Text = Word_Button17.Text
                End If
                If (Label6.Text = (i + 1).ToString) Then
                    Label6.Text = Word_Button17.Text
                End If
                If (Label7.Text = (i + 1).ToString) Then
                    Label7.Text = Word_Button17.Text
                End If
                If (Label8.Text = (i + 1).ToString) Then
                    Label8.Text = Word_Button17.Text
                End If
                If (Label9.Text = (i + 1).ToString) Then
                    Label9.Text = Word_Button17.Text
                End If
            End If
        Next
        If Found = False Then
            Word_Button17.BackColor = Color.Red
            Word_Button17.Enabled = False
            Dead += 1
            Change_Picture()
        End If
        If Found = True Then
            Word_Button17.Enabled = False
        End If
        Check_For_Win()
    End Sub

    Private Sub Word_Button18_Click(sender As Object, e As EventArgs) Handles Word_Button18.Click
        Dim Found As Boolean = False
        For i As Integer = 0 To Wordlen - 1
            If (Word_Button18.Text = Word(i)) Then
                Found = True
                If (Label1.Text = (i + 1).ToString) Then
                    Label1.Text = Word_Button18.Text
                End If
                If (Label2.Text = (i + 1).ToString) Then
                    Label2.Text = Word_Button18.Text
                End If
                If (Label3.Text = (i + 1).ToString) Then
                    Label3.Text = Word_Button18.Text
                End If
                If (Label4.Text = (i + 1).ToString) Then
                    Label4.Text = Word_Button18.Text
                End If
                If (Label5.Text = (i + 1).ToString) Then
                    Label5.Text = Word_Button18.Text
                End If
                If (Label6.Text = (i + 1).ToString) Then
                    Label6.Text = Word_Button18.Text
                End If
                If (Label7.Text = (i + 1).ToString) Then
                    Label7.Text = Word_Button18.Text
                End If
                If (Label8.Text = (i + 1).ToString) Then
                    Label8.Text = Word_Button18.Text
                End If
                If (Label9.Text = (i + 1).ToString) Then
                    Label9.Text = Word_Button18.Text
                End If
            End If
        Next
        If Found = False Then
            Word_Button18.BackColor = Color.Red
            Word_Button18.Enabled = False
            Dead += 1
            Change_Picture()
        End If
        If Found = True Then
            Word_Button18.Enabled = False
        End If
        Check_For_Win()
    End Sub

    Private Sub Word_Button19_Click(sender As Object, e As EventArgs) Handles Word_Button19.Click
        Dim Found As Boolean = False
        For i As Integer = 0 To Wordlen - 1
            If (Word_Button19.Text = Word(i)) Then
                Found = True
                If (Label1.Text = (i + 1).ToString) Then
                    Label1.Text = Word_Button19.Text
                End If
                If (Label2.Text = (i + 1).ToString) Then
                    Label2.Text = Word_Button19.Text
                End If
                If (Label3.Text = (i + 1).ToString) Then
                    Label3.Text = Word_Button19.Text
                End If
                If (Label4.Text = (i + 1).ToString) Then
                    Label4.Text = Word_Button19.Text
                End If
                If (Label5.Text = (i + 1).ToString) Then
                    Label5.Text = Word_Button19.Text
                End If
                If (Label6.Text = (i + 1).ToString) Then
                    Label6.Text = Word_Button19.Text
                End If
                If (Label7.Text = (i + 1).ToString) Then
                    Label7.Text = Word_Button19.Text
                End If
                If (Label8.Text = (i + 1).ToString) Then
                    Label8.Text = Word_Button19.Text
                End If
                If (Label9.Text = (i + 1).ToString) Then
                    Label9.Text = Word_Button19.Text
                End If
            End If
        Next
        If Found = False Then
            Word_Button19.BackColor = Color.Red
            Word_Button19.Enabled = False
            Dead += 1
            Change_Picture()
        End If
        If Found = True Then
            Word_Button19.Enabled = False
        End If
        Check_For_Win()
    End Sub

    Private Sub Word_Button20_Click(sender As Object, e As EventArgs) Handles Word_Button20.Click
        Dim Found As Boolean = False
        For i As Integer = 0 To Wordlen - 1
            If (Word_Button20.Text = Word(i)) Then
                Found = True
                If (Label1.Text = (i + 1).ToString) Then
                    Label1.Text = Word_Button20.Text
                End If
                If (Label2.Text = (i + 1).ToString) Then
                    Label2.Text = Word_Button20.Text
                End If
                If (Label3.Text = (i + 1).ToString) Then
                    Label3.Text = Word_Button20.Text
                End If
                If (Label4.Text = (i + 1).ToString) Then
                    Label4.Text = Word_Button20.Text
                End If
                If (Label5.Text = (i + 1).ToString) Then
                    Label5.Text = Word_Button20.Text
                End If
                If (Label6.Text = (i + 1).ToString) Then
                    Label6.Text = Word_Button20.Text
                End If
                If (Label7.Text = (i + 1).ToString) Then
                    Label7.Text = Word_Button20.Text
                End If
                If (Label8.Text = (i + 1).ToString) Then
                    Label8.Text = Word_Button20.Text
                End If
                If (Label9.Text = (i + 1).ToString) Then
                    Label9.Text = Word_Button20.Text
                End If
            End If
        Next
        If Found = False Then
            Word_Button20.BackColor = Color.Red
            Word_Button20.Enabled = False
            Dead += 1
            Change_Picture()
        End If
        If Found = True Then
            Word_Button20.Enabled = False
        End If
        Check_For_Win()
    End Sub

    Private Sub Word_Button21_Click(sender As Object, e As EventArgs) Handles Word_Button21.Click
        Dim Found As Boolean = False
        For i As Integer = 0 To Wordlen - 1
            If (Word_Button21.Text = Word(i)) Then
                Found = True
                If (Label1.Text = (i + 1).ToString) Then
                    Label1.Text = Word_Button21.Text
                End If
                If (Label2.Text = (i + 1).ToString) Then
                    Label2.Text = Word_Button21.Text
                End If
                If (Label3.Text = (i + 1).ToString) Then
                    Label3.Text = Word_Button21.Text
                End If
                If (Label4.Text = (i + 1).ToString) Then
                    Label4.Text = Word_Button21.Text
                End If
                If (Label5.Text = (i + 1).ToString) Then
                    Label5.Text = Word_Button21.Text
                End If
                If (Label6.Text = (i + 1).ToString) Then
                    Label6.Text = Word_Button21.Text
                End If
                If (Label7.Text = (i + 1).ToString) Then
                    Label7.Text = Word_Button21.Text
                End If
                If (Label8.Text = (i + 1).ToString) Then
                    Label8.Text = Word_Button21.Text
                End If
                If (Label9.Text = (i + 1).ToString) Then
                    Label9.Text = Word_Button21.Text
                End If
            End If
        Next
        If Found = False Then
            Word_Button21.BackColor = Color.Red
            Word_Button21.Enabled = False
            Dead += 1
            Change_Picture()
        End If
        If Found = True Then
            Word_Button21.Enabled = False
        End If
        Check_For_Win()
    End Sub

    Private Sub Word_Button22_Click(sender As Object, e As EventArgs) Handles Word_Button22.Click
        Dim Found As Boolean = False
        For i As Integer = 0 To Wordlen - 1
            If (Word_Button22.Text = Word(i)) Then
                Found = True
                If (Label1.Text = (i + 1).ToString) Then
                    Label1.Text = Word_Button22.Text
                End If
                If (Label2.Text = (i + 1).ToString) Then
                    Label2.Text = Word_Button22.Text
                End If
                If (Label3.Text = (i + 1).ToString) Then
                    Label3.Text = Word_Button22.Text
                End If
                If (Label4.Text = (i + 1).ToString) Then
                    Label4.Text = Word_Button22.Text
                End If
                If (Label5.Text = (i + 1).ToString) Then
                    Label5.Text = Word_Button22.Text
                End If
                If (Label6.Text = (i + 1).ToString) Then
                    Label6.Text = Word_Button22.Text
                End If
                If (Label7.Text = (i + 1).ToString) Then
                    Label7.Text = Word_Button22.Text
                End If
                If (Label8.Text = (i + 1).ToString) Then
                    Label8.Text = Word_Button22.Text
                End If
                If (Label9.Text = (i + 1).ToString) Then
                    Label9.Text = Word_Button22.Text
                End If
            End If
        Next
        If Found = False Then
            Word_Button22.BackColor = Color.Red
            Word_Button22.Enabled = False
            Dead += 1
            Change_Picture()
        End If
        If Found = True Then
            Word_Button22.Enabled = False
        End If
        Check_For_Win()
    End Sub

    Private Sub Word_Button23_Click(sender As Object, e As EventArgs) Handles Word_Button23.Click
        Dim Found As Boolean = False
        For i As Integer = 0 To Wordlen - 1
            If (Word_Button23.Text = Word(i)) Then
                Found = True
                If (Label1.Text = (i + 1).ToString) Then
                    Label1.Text = Word_Button23.Text
                End If
                If (Label2.Text = (i + 1).ToString) Then
                    Label2.Text = Word_Button23.Text
                End If
                If (Label3.Text = (i + 1).ToString) Then
                    Label3.Text = Word_Button23.Text
                End If
                If (Label4.Text = (i + 1).ToString) Then
                    Label4.Text = Word_Button23.Text
                End If
                If (Label5.Text = (i + 1).ToString) Then
                    Label5.Text = Word_Button23.Text
                End If
                If (Label6.Text = (i + 1).ToString) Then
                    Label6.Text = Word_Button23.Text
                End If
                If (Label7.Text = (i + 1).ToString) Then
                    Label7.Text = Word_Button23.Text
                End If
                If (Label8.Text = (i + 1).ToString) Then
                    Label8.Text = Word_Button23.Text
                End If
                If (Label9.Text = (i + 1).ToString) Then
                    Label9.Text = Word_Button23.Text
                End If
            End If
        Next
        If Found = False Then
            Word_Button23.BackColor = Color.Red
            Word_Button23.Enabled = False
            Dead += 1
            Change_Picture()
        End If
        If Found = True Then
            Word_Button23.Enabled = False
        End If
        Check_For_Win()
    End Sub

    Private Sub Word_Button24_Click(sender As Object, e As EventArgs) Handles Word_Button24.Click
        Dim Found As Boolean = False
        For i As Integer = 0 To Wordlen - 1
            If (Word_Button24.Text = Word(i)) Then
                Found = True
                If (Label1.Text = (i + 1).ToString) Then
                    Label1.Text = Word_Button24.Text
                End If
                If (Label2.Text = (i + 1).ToString) Then
                    Label2.Text = Word_Button24.Text
                End If
                If (Label3.Text = (i + 1).ToString) Then
                    Label3.Text = Word_Button24.Text
                End If
                If (Label4.Text = (i + 1).ToString) Then
                    Label4.Text = Word_Button24.Text
                End If
                If (Label5.Text = (i + 1).ToString) Then
                    Label5.Text = Word_Button24.Text
                End If
                If (Label6.Text = (i + 1).ToString) Then
                    Label6.Text = Word_Button24.Text
                End If
                If (Label7.Text = (i + 1).ToString) Then
                    Label7.Text = Word_Button24.Text
                End If
                If (Label8.Text = (i + 1).ToString) Then
                    Label8.Text = Word_Button24.Text
                End If
                If (Label9.Text = (i + 1).ToString) Then
                    Label9.Text = Word_Button24.Text
                End If
            End If
        Next
        If Found = False Then
            Word_Button24.BackColor = Color.Red
            Word_Button24.Enabled = False
            Dead += 1
            Change_Picture()
        End If
        If Found = True Then
            Word_Button24.Enabled = False
        End If
        Check_For_Win()
    End Sub

    Private Sub Word_Button25_Click(sender As Object, e As EventArgs) Handles Word_Button25.Click
        Dim Found As Boolean = False
        For i As Integer = 0 To Wordlen - 1
            If (Word_Button25.Text = Word(i)) Then
                Found = True
                If (Label1.Text = (i + 1).ToString) Then
                    Label1.Text = Word_Button25.Text
                End If
                If (Label2.Text = (i + 1).ToString) Then
                    Label2.Text = Word_Button25.Text
                End If
                If (Label3.Text = (i + 1).ToString) Then
                    Label3.Text = Word_Button25.Text
                End If
                If (Label4.Text = (i + 1).ToString) Then
                    Label4.Text = Word_Button25.Text
                End If
                If (Label5.Text = (i + 1).ToString) Then
                    Label5.Text = Word_Button25.Text
                End If
                If (Label6.Text = (i + 1).ToString) Then
                    Label6.Text = Word_Button25.Text
                End If
                If (Label7.Text = (i + 1).ToString) Then
                    Label7.Text = Word_Button25.Text
                End If
                If (Label8.Text = (i + 1).ToString) Then
                    Label8.Text = Word_Button25.Text
                End If
                If (Label9.Text = (i + 1).ToString) Then
                    Label9.Text = Word_Button25.Text
                End If
            End If
        Next
        If Found = False Then
            Word_Button25.BackColor = Color.Red
            Word_Button25.Enabled = False
            Dead += 1
            Change_Picture()
        End If
        If Found = True Then
            Word_Button25.Enabled = False
        End If
        Check_For_Win()
    End Sub

    Private Sub Word_Button26_Click(sender As Object, e As EventArgs) Handles Word_Button26.Click
        Dim Found As Boolean = False
        For i As Integer = 0 To Wordlen - 1
            If (Word_Button26.Text = Word(i)) Then
                Found = True
                If (Label1.Text = (i + 1).ToString) Then
                    Label1.Text = Word_Button26.Text
                End If
                If (Label2.Text = (i + 1).ToString) Then
                    Label2.Text = Word_Button26.Text
                End If
                If (Label3.Text = (i + 1).ToString) Then
                    Label3.Text = Word_Button26.Text
                End If
                If (Label4.Text = (i + 1).ToString) Then
                    Label4.Text = Word_Button26.Text
                End If
                If (Label5.Text = (i + 1).ToString) Then
                    Label5.Text = Word_Button26.Text
                End If
                If (Label6.Text = (i + 1).ToString) Then
                    Label6.Text = Word_Button26.Text
                End If
                If (Label7.Text = (i + 1).ToString) Then
                    Label7.Text = Word_Button26.Text
                End If
                If (Label8.Text = (i + 1).ToString) Then
                    Label8.Text = Word_Button26.Text
                End If
                If (Label9.Text = (i + 1).ToString) Then
                    Label9.Text = Word_Button26.Text
                End If
            End If
        Next
        If Found = False Then
            Word_Button26.BackColor = Color.Red
            Word_Button26.Enabled = False
            Dead += 1
            Change_Picture()
        End If
        If Found = True Then
            Word_Button26.Enabled = False
        End If
        Check_For_Win()
    End Sub

    Private Sub Exit_btn_Click(sender As Object, e As EventArgs) Handles Exit_btn.Click
        If MessageBox.Show("Are You Sure You Want to close application", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            HangMan_By_Vahe.Menu.Close()
            Help.Close()
            Me.Close()
        End If
    End Sub
End Class