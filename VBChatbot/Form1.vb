Public Class Form1
    ' VBChatManクラスをインスタンス化
    Private _bot As New VBMan("bot")

    ' ログろテキストボックスに追加するメソッド
    ' strは入力文字列又は返答メッセージ
    Private Sub PutLog(str As String)
        TextBox2.AppendText(str + vbCrLf)
    End Sub

    ' botのプロンプトを作る関数
    ' 戻り値：プロンプト用の文字列(どのサブクラスかを返す)
    Private Function Prompt() As String
        Return _bot.Name + ":" + _bot.GetName() + ">"
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' TextBoxに入力された文字列を取得
        Dim value As String = TextBox1.Text

        If value = String.Empty Then
            Label1.Text = "なんすか？"
        Else
            ' 入力されていたら、対話処理を実行
            ' 入力文字列を引数としてDialogue()メソッドを実行
            Dim response As String = _bot.Dialogue(value)
            Label1.Text = response
            '入力文字列を引数としてPutLog()メソッドを実行
            PutLog(">" + value)
            PutLog(Prompt() + response)
            TextBox1.Clear()
        End If

    End Sub
End Class
