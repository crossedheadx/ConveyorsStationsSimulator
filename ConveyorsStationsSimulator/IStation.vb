'' define interface for every station in the plant
Public Interface IStation
  Property State As Boolean
  Property Movement As Boolean
  Property StationName As String
  Function GetBetterDestination() As [Enum]
End Interface
