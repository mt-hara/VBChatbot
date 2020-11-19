'独自の応答をランダムに返すサブクラス

Public Class RandomResponder
    Inherits Responder

    Private responses = {
        "本日は晴天なり",
        "で、あるか",
        "本日転記晴朗なれえど波高し",
        "それはいい",
        "じゃぁ、これ知ってる？",
        "単純明快であれ"
        }

    ' コンストラクター
    Public Sub New(name As String)
        MyBase.New(name)
    End Sub

    ' Response()メソッドのオーバーライド
    Public Overrides Function Response(input As String) As String
        Dim rnd As New Random()
        ' 配列から文書を抽出して返す。
        'Dim n As Integer = responses.Length
        'MessageBox.Show(n)
        Return responses(rnd.Next(0, responses.Length))
    End Function

End Class
