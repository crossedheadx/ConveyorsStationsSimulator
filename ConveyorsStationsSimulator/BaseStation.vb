MustInherit Class BaseStation
  Implements IStation

  Public Property State As Boolean Implements IStation.State
    Get
      Return State
    End Get
    Set(value As Boolean)
      State = value
    End Set
  End Property

  Public Property Movement As Boolean Implements IStation.Movement
    Get
      Return Movement
    End Get
    Set(value As Boolean)
      Movement = value
    End Set
  End Property

  Public Property StationName As String Implements IStation.StationName
    Get
      Return StationName
    End Get
    Set(value As String)
      If (value.Length > 0) Then
        StationName = value
      End If
    End Set
  End Property

  Public Function LoadStation() As Object
    '' return the istance of the station
  End Function

  Public Function GetBetterDestination() As [Enum] Implements IStation.GetBetterDestination
    '' define best next destination on the track
  End Function
End Class
