Module Module2
    '---------------------INI文件读写函数声明------------------------------

    Private Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Int32, ByVal lpFileName As String) As Int32
    Private Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Int32

    Public Function GetIniStr(ByVal AppName As String, ByVal In_Key As String, ByVal IniName As String) As String
        On Error GoTo GetIniStrErr
        If Trim(In_Key) = "" Then
            GoTo GetIniStrErr
        End If
        Dim GetStr As String
        GetStr = New String(Chr(0), 128)
        GetPrivateProfileString(AppName, In_Key, "", GetStr, 256, IniName) 'App.Path & "\" &IniName
        'AppName（文件名），In_Key（文件中调用的信息名字），GetStr（获取的内容）
        GetStr = Replace(GetStr, Chr(0), "")
        If GetStr = "" Then
            GoTo GetIniStrErr
        Else
            GetIniStr = GetStr
            GetStr = ""
        End If
        Exit Function
GetIniStrErr:
        Err.Clear()
        GetIniStr = ""
        GetStr = ""
    End Function

    Public Function WriteIniStr(ByVal AppName As String, ByVal In_Key As String, ByVal In_Data As String, ByVal IniName As String) As Boolean
        On Error GoTo WriteIniStrErr
        WriteIniStr = True
        If Trim(In_Data) = "" Or Trim(In_Key) = "" Or Trim(AppName) = "" Then
            GoTo WriteIniStrErr
        Else
            WritePrivateProfileString(AppName, In_Key, In_Data, IniName)
        End If
        Exit Function
WriteIniStrErr:
        Err.Clear()
        WriteIniStr = False
    End Function

End Module

