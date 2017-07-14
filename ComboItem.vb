Public Class comboItem


    Private mCode As String
    Private mName As String

    Public Sub New(ByVal name As String, ByVal code As String)

        mName = name
        mCode = code
    End Sub

    Public Property Name() As String
        Get
            Return mName
        End Get
        Set(ByVal value As String)
            mName = value
        End Set
    End Property

    Public Property Code() As String
        Get
            Return mCode
        End Get
        Set(ByVal value As String)
            mCode = value
        End Set
    End Property

    Public Overrides Function ToString() As String

        Return mName
    End Function


End Class