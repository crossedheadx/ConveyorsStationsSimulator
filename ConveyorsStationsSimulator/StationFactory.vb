Public Class StationFactory
  Shared Function GetStation(ByVal stationType As String) As Station
    Select Case stationType
      Case "A"
        Return New StationTypeA
      Case "B"
        Return New StationTypeB
      Case Else
        Throw New Exception
    End Select
  End Function
End Class
