Public Class Responder
    Private _name As String

    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    ' コンストラクター
    Public Sub New(name As String)
        _name = name
    End Sub

    ' 応答メッセージを作成して戻り値として返す。
    Public Overridable Function Response(input As String) As String
        Return ""
    End Function

End Class
