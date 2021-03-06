Imports System.Deployment.Application
Imports System.Net
Imports System.Net.NetworkInformation
Imports System.IO

Public Module Terminal
    Public Function fn_ip_address() As String
        Return Dns.GetHostEntry(My.Computer.Name).AddressList.FirstOrDefault(Function(i) i.AddressFamily = Sockets.AddressFamily.InterNetwork).ToString()
    End Function

    Public Function fn_pc_name() As String
        Return My.Computer.Name.ToString
    End Function

    Public Function fn_pc_mac() As String
        Dim nics() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces
        Dim mac As String = nics(0).GetPhysicalAddress.ToString
        Return mac
    End Function

    Public Function fn_ethernet_status() As Boolean
        Return My.Computer.Network.IsAvailable
    End Function

    Public Function fn_trace_number(Optional digit_lengt As String = "D10") As String
        Dim rng As New Random
        Dim number As Integer = rng.Next(1, 2000000000)
        Dim digits As String = number.ToString(digit_lengt)

        Return digits
    End Function

    Public Function fn_generate_password(longitude As Integer) As String
        Dim caracteres As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890"
        Dim res As New System.Text.StringBuilder()
        Dim rnd As New Random()

        While 0 < Math.Max(System.Threading.Interlocked.Decrement(longitude), longitude + 1)
            res.Append(caracteres(rnd.[Next](caracteres.Length)))
        End While

        Return res.ToString()
    End Function

    Public Function fn_text_spaces(text_search As String) As String
        Return text_search.Substring(0, text_search.IndexOf(" "))
    End Function

    Public Function fn_version_number(Optional use_tag As Boolean = True) As String
        Dim version_number As String = Nothing

        Try
            If ApplicationDeployment.IsNetworkDeployed Then
                With ApplicationDeployment.CurrentDeployment.CurrentVersion
                    version_number = If(use_tag = True, "Versión: ", "") & .Major & "." & .Minor & "." & .Build & "." & .Revision
                End With
            Else
                version_number = If(use_tag = True, "Versión: ", "") & My.Application.Info.Version.ToString
            End If

        Catch ex As Exception
        Finally
        End Try

        Return version_number
    End Function

    Public Function fn_date_oracle() As String
        Return Year(Now) & Format(Month(Now), "D2") & Format(Now.Day, "D2")
    End Function

    Public Function fn_date_oracle(event_date As Date) As String
        Return Year(event_date) & Format(Month(event_date), "D2")
    End Function

    Public Function fn_text_extension(file_name As String) As String
        Return New IO.FileInfo(file_name).Extension
    End Function

    Public Function fn_text_filename(file_name As String) As String
        Return New IO.FileInfo(file_name).Name
    End Function

    Public Function fn_generate_copy(source_path As String, destiny_path As String) As Boolean
        My.Computer.FileSystem.CopyFile(source_path, destiny_path, FileIO.UIOption.OnlyErrorDialogs, FileIO.UICancelOption.DoNothing)
        Return My.Computer.FileSystem.FileExists(destiny_path)
    End Function

    Public Function fn_process_closed(process_name As String) As Process
        Dim process_ As Process

        For Each process_ In Process.GetProcesses
            If process_.MainWindowTitle = process_name Then
                Return process_
            End If
        Next

        Return Nothing
    End Function

    Public Sub fn_process_created(process_name As String)
        Dim object_process As Process = New System.Diagnostics.Process
        object_process.StartInfo.FileName = process_name
        object_process.Start()
    End Sub

    Public Function fn_system_version() As String
        Return My.Computer.Info.OSFullName.ToString
    End Function
End Module
