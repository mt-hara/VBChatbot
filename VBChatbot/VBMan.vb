'VBChatbot本体クラス(コントローラ)

Public Class VBMan

    Private _name As String                 ' オブジェクト名格納変数
    Private _res_random As RandomResponder  ' RandomResponderインスタンス格納変数
    Private _res_repeat As RepeatResponder  ' RepeatResponderインスタンス格納変数
    Private _responder As Responder         ' Responder型フィールド定義

    ' VBManクラスのオブジェクト名にアクセスするためのプロパティ
    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    ' コンストラクター
    ' RandomResponderRepeatResponderのインスタンスを生成
    Public Sub New(name As String)
        Me._name = name

        _res_random = New RandomResponder("Random")

        _res_repeat = New RepeatResponder("Repeat")
    End Sub


    ' 応答メッセージを返すメソッド
    ' 0～9までの範囲で値を生成、0～5の場合はRandomResponderインスタンスを変数に格納
    ' 6～9の場合はRepeatResponderインスタンスを変数に格納
    Public Function Dialogue(input As String) As String
        Dim rnd As New Random()
        Dim num As Integer = rnd.Next(0, 10)

        If num < 6 Then
            _responder = _res_random
        Else
            _responder = _res_repeat
        End If
        Return _responder.Response(input)   'ここでポリモーフィズムが動作
    End Function

    ' サブクラスのオブジェクト名を返す。最終的にこのVBManクラスはフォームのイベントハンドラー
    ' からコールされるがイベントハンドラーからサブクラスに直接アクセスできないため、中継として
    ' このメソッドを設置
    Public Function GetName() As String
        Return _responder.Name
    End Function

End Class
