' オウム返しをするサブクラス

Public Class RepeatResponder
    Inherits Responder


    ' コンストラクター
    Public Sub New(name As String)
        MyBase.New(name)
    End Sub

    ' Responder()メソッドをオーバーライド
    Public Overrides Function Response(input As String) As String
        Return String.Format("{0}ってなに?", input)
    End Function

End Class
