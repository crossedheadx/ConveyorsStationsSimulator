Imports System.Threading

Module Program
  Sub Main(args As String())
    Dim CheckInterval As Integer = 1000
    Log("Plant boot, check station every " & (CheckInterval / 1000) & " seconds.")
    Try
      '' stations lists loading
      Dim Stations As List(Of Object) = LoadStations()

      While True
        '' exec main code for the simulator

        '' consider only busy stations and not on movement
        '' check better destination for the package

        '' command destination for all stations which are busy
        Thread.Sleep(CheckInterval)
      End While
    Catch ex As Exception
      Log("An exception occours: ")
    End Try
  End Sub

  '' init all stations of the plant
  Private Function LoadStations() As List(Of Object)
    Log("I'm loading all stations")

  End Function

  '' Private Function GetBetterDestination() As [Enum]
  '' 
  '' End Function

  '' logging method
  Private Sub Log(message As String)
    Console.WriteLine(message)
  End Sub

End Module
