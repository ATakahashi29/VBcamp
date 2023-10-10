Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Hello! World")

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ''宣言 Dim 変数名　As データ型
        'Dim message As String
        'message = "Hi!Hello!"

        'MsgBox(message)

        Dim intLessonNo As Integer = 0
        If Integer.TryParse(txtLessonNo.Text, intLessonNo) = False Then

            intLessonNo = 999

        End If

        Select Case intLessonNo
            Case 2
                Dim lclsLesson As itfLesson = New Lesson2()
                lclsLesson.Run()
            Case Else
                MsgBox("番号を指定してください。")
        End Select


    End Sub
End Class
