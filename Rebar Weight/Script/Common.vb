Imports System.Diagnostics.Process
Imports System.IO
Imports System.IO.Directory
Imports System.Math
Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms.Application
Imports System.Windows.Forms.MessageBox
Imports System.Windows.Forms.MessageBoxButtons
Imports System.Windows.Forms.MessageBoxIcon

Friend Module Common
#Region "Helper"
    ''' <summary>
    ''' Check internet connection.
    ''' </summary>
    ''' <returns>Connection state.</returns>
    Private Function IsNetAvail()
        Dim objResp As WebResponse
        Try
            objResp = WebRequest.Create(New Uri(My.Resources.link_base)).GetResponse
            objResp.Close()
            objResp = Nothing
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Check update.
    ''' </summary>
    Private Sub ChkUpd()
        If IsNetAvail() AndAlso Not (New WebClient).DownloadString(My.Resources.link_ver).Contains(My.Resources.app_ver) Then
            Show($"「{My.Resources.app_true_name}」新しいバージョンが利用可能！", "更新", OK, Information)
            Run(New FrmUpdate)
        End If
    End Sub

    ''' <summary>
    ''' Update valid license
    ''' </summary>
    Friend Sub UpdVldLic()
        My.Settings.Chk_Key = True
        My.Settings.Save()
    End Sub
#End Region

#Region "Master"
    ''' <summary>
    ''' End process.
    ''' </summary>
    ''' <param name="name">Process name.</param>
    Friend Sub KillPrcs(name As String)
        If GetProcessesByName(name).Count > 0 Then
            For Each item In GetProcessesByName(name)
                item.Kill()
            Next
        End If
    End Sub
#End Region

#Region "Main"
    ''' <summary>
    ''' Create directory advanced.
    ''' </summary>
    ''' <param name="path">Folder path.</param>
    Friend Sub CrtDirAdv(path As String)
        If Not Exists(path) Then
            CreateDirectory(path)
        End If
    End Sub

    ''' <summary>
    ''' Delete file advanced.
    ''' </summary>
    ''' <param name="path">File path.</param>
    Friend Sub DelFileAdv(path As String)
        If File.Exists(path) Then
            File.Delete(path)
        End If
    End Sub
#End Region

#Region "Timer"
    ''' <summary>
    ''' Start timer advanced.
    ''' </summary>
    <Extension()>
    Friend Sub StrtAdv(tmr As Timer)
        If Not tmr.Enabled Then
            tmr.Start()
        End If
    End Sub

    ''' <summary>
    ''' Stop timer advanced.
    ''' </summary>
    <Extension()>
    Friend Sub StopAdv(tmr As Timer)
        If tmr.Enabled Then
            tmr.Stop()
        End If
    End Sub
#End Region

#Region "Actor"
    ''' <summary>
    ''' Round end 0-5.
    ''' </summary>
    ''' <param name="num">Number.</param>
    ''' <returns>Rounded number.</returns>
    Friend Function Rnd5(num As Double)
        Return Ceiling(num / 5) * 5
    End Function

    ''' <summary>
    ''' Raw wood check.
    ''' </summary>
    ''' <param name="l">Rebar length.</param>
    ''' <returns>Is raw wood.</returns>
    Friend Function IsRawWood(l As Integer)
        Return ARR_RAW_WOOD.Contains(l)
    End Function

    ''' <summary>
    ''' D lock check.
    ''' </summary>
    ''' <param name="d">Rebar diameter.</param>
    ''' <returns>Is D lock.</returns>
    Friend Function IsDLock(d As Integer)
        Return ARR_D_LOCK.Contains(d)
    End Function

    ''' <summary>
    ''' Rate change mass.
    ''' </summary>
    ''' <param name="d">Rebar diameter (mm).</param>
    ''' <param name="l">Rebar length (mm).</param>
    ''' <param name="bending">Is bending.</param>
    ''' <returns>Mass (Kg).</returns>
    Friend Function MRateChg(d As Integer, l As Integer, bending As Boolean)
        Return If(IsDLock(d), If(IsRawWood(l), If(bending, M_BNDG_RATE, 1), M_BNDG_RATE), 1 + d * (5 * PI / 4 - 1) / l)
    End Function

    ''' <summary>
    ''' Surface mass.
    ''' </summary>
    ''' <param name="d">Rebar diameter (mm).</param>
    ''' <returns>Mass (Kg).</returns>
    Friend Function MSfc(d As Integer)
        Return If(IsDLock(d), M_SFC_D_LOCK(d), (d / 2) ^ 2 * PI * DEN_IRON / 10 ^ 3)
    End Function

    ''' <summary>
    ''' Rebar price.
    ''' </summary>
    ''' <param name="d">Rebar diameter (mm).</param>
    ''' <param name="bending">Is bending.</param>
    ''' <returns>Price (Yen).</returns>
    Friend Function RebarPr(d As Integer, bending As Boolean)
        If bending Then
            Return My.Settings.Pr_Proc
        Else
            Select Case d
                Case 10
                    Return My.Settings.Pr_D10
                Case 13
                    Return My.Settings.Pr_D13
                Case 16
                    Return My.Settings.Pr_D16
                Case 19
                    Return My.Settings.Pr_D19
                Case 22
                    Return My.Settings.Pr_D22
                Case Else
                    Return My.Settings.Pr_Proc
            End Select
        End If
    End Function

    ''' <summary>
    ''' L haunch.
    ''' </summary>
    ''' <param name="h">Haunch height (mm).</param>
    ''' <param name="deg">Haunch degree (°).</param>
    ''' <returns>Length (mm).</returns>
    Friend Function LHaunch(h As Integer, deg As Integer)
        Return Rnd5(h / Sin(deg / (180 / PI)))
    End Function

    ''' <summary>
    ''' W haunch.
    ''' </summary>
    ''' <param name="h">Haunch height (mm).</param>
    ''' <param name="deg">Haunch degree (°).</param>
    ''' <returns>Width (mm).</returns>
    Friend Function WHaunch(h As Integer, deg As Integer)
        Return Rnd5(h / Tan(deg / (180 / PI)))
    End Function
#End Region
End Module
