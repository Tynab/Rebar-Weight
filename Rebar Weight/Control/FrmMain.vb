Imports System.AppDomain
Imports System.Drawing.Text
Imports System.IO.File
Imports System.Windows.Forms.Application
Imports System.Windows.Forms.Keys
Imports YANF.Control
Imports YANF.Script
Imports YANF.Script.YANEvent

Public Class FrmMain
#Region "Fields"
    Private _lock As Boolean = False
    Private _bending As Boolean = False
    Private _l As Integer = 0
    Private _sL As String = ""
#End Region

#Region "Events"
    ' Load frm
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChkLic()
        ' event handle
        For Each pnl In GetAllObjs(GetType(Panel))
            AddHandler pnl.MouseDown, AddressOf MoveFrm_MouseDown
            AddHandler pnl.MouseMove, AddressOf MoveFrm_MouseMove
            AddHandler pnl.MouseUp, AddressOf MoveFrm_MouseUp
        Next
        For Each grp In GetAllObjs(GetType(GroupBox))
            AddHandler grp.MouseDown, AddressOf MoveFrm_MouseDown
            AddHandler grp.MouseMove, AddressOf MoveFrm_MouseMove
            AddHandler grp.MouseUp, AddressOf MoveFrm_MouseUp
        Next
        For Each lbl In GetAllObjs(GetType(Label))
            AddHandler lbl.MouseDown, AddressOf MoveFrm_MouseDown
            AddHandler lbl.MouseMove, AddressOf MoveFrm_MouseMove
            AddHandler lbl.MouseUp, AddressOf MoveFrm_MouseUp
        Next
        For Each nud In GetAllObjs(GetType(NumericUpDown))
            AddHandler nud.KeyDown, AddressOf Ctrl_KeyDown
            AddHandler nud.Enter, AddressOf Nud_Enter
            AddHandler nud.Leave, AddressOf Nud_Leave
        Next
        For Each tg In GetAllObjs(GetType(YANTg))
            AddHandler tg.KeyDown, AddressOf Ctrl_KeyDown
        Next
        AddHandler nudH.KeyDown, AddressOf NudHaunch_KeyDown
        AddHandler nudDeg.KeyDown, AddressOf NudHaunch_KeyDown
        ' option

    End Sub

    ' Shown frm
    Private Sub FrmMain_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dim waitScrServ = New Service.YANWaitScrService With {
            .IsTop = True
        }
        waitScrServ.OnLoader(Me)
        ChkUpd()
        Opacity = 1
        DigiFont()
        nudL.ResetText()
        nudL.Select()
        waitScrServ.OffLoader()
    End Sub

    ' Closing frm
    Private Sub FrmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        FadeOut()
    End Sub

    ' On/Off TopMost
    Private Sub TgPin_CheckedChanged(sender As Object, e As EventArgs) Handles tgPin.CheckedChanged
        TopMost = tgPin.Checked
    End Sub

    ' Exit
    Private Sub TgClose_CheckedChanged(sender As Object, e As EventArgs) Handles tgClose.CheckedChanged
        If Not tgClose.Checked Then
            [Exit]()
        End If
    End Sub

    ' Nud keydown
    Private Sub Ctrl_KeyDown(sender As Object, e As KeyEventArgs)
        Select Case e.KeyCode
            Case H
                e.SuppressKeyPress = True
                nudH.Select()
            Case R
                e.SuppressKeyPress = True
                nudDeg.Select()
            Case D
                e.SuppressKeyPress = True
                nudD.Select()
            Case L
                e.SuppressKeyPress = True
                nudL.Select()
        End Select
    End Sub

    ' Nud haunch keydown
    Private Sub NudHaunch_KeyDown(sender As Object, e As KeyEventArgs)
        Dim nud = CType(sender, NumericUpDown)
        Select Case e.KeyCode
            Case Keys.Enter
                e.SuppressKeyPress = True
                Dim h = nudH.Value
                Dim deg = nudDeg.Value
                lblHaunchL.Text = $"L = {LHaunch(h, deg)}"
                lblHaunchW.Text = $"W = {WHaunch(h, deg)}"
            Case Space
                e.SuppressKeyPress = True
                nud.ResetText()
        End Select
    End Sub

    ' Nud D keydown
    Private Sub NudD_KeyDown(sender As Object, e As KeyEventArgs) Handles nudD.KeyDown
        Select Case e.KeyCode
            Case Space
                e.SuppressKeyPress = True
                nudD.ResetText()
            Case Keys.Enter
                e.SuppressKeyPress = True
                Dim d = nudD.Value
                Dim l = nudL.Value
                Dim bending = False
                lblRsltL.Text = String.Format("{0:n0}", l)
                lblRsltM.Text = "m = " + String.Format("{0:n1}", MRebar(d, l, bending))
                lblRsltY.Text = $"￥ = {RebarPr(d, bending)}"
        End Select
    End Sub

    ' Nud L keydown
    Private Sub NudL_KeyDown(sender As Object, e As KeyEventArgs) Handles nudL.KeyDown
        ' reset lock
        Select Case e.KeyCode
            Case Space
                e.SuppressKeyPress = True
                ResetL()
            Case D0 To D9, NumPad0 To NumPad9
                _lock = False
        End Select
        ' check lock
        If Not _lock Then
            ' incremental
            If Not String.IsNullOrWhiteSpace(nudL.Text) And _l < L_MAX Then
                If e.KeyCode = Keys.Add Then
                    _bending = True
                    Dim str = nudL.Text
                    str = str.Replace(",", String.Empty)
                    str = str.Replace(".", String.Empty)
                    Dim l = Integer.Parse(str)
                    _l += l
                    If _l > L_MAX Then
                        LimitL()
                    Else
                        e.SuppressKeyPress = True
                        DispRsltL(l)
                        nudL.Select(0, nudL.Text.Length)

                    End If
                End If
            End If
            ' process
            If e.KeyCode = Keys.Enter Then
                _lock = True
                Dim l = nudL.Value
                _l += l
                If _l > L_MAX Then
                    LimitL()
                Else
                    e.SuppressKeyPress = True
                    DispRsltL(l)
                    Dim d = nudD.Value
                    lblRsltM.Text = "m = " + String.Format("{0:n1}", MRebar(d, _l, _bending))
                    lblRsltY.Text = $"￥ = {RebarPr(d, _bending)}"
                    nudL.Value = _l
                    nudL.Text = String.Format("{0:n0}", _l)
                    nudL.Select(0, nudL.Text.Length)
                    SemiResetL()
                End If
            End If
        End If
    End Sub

    ' Nud enter
    Private Sub Nud_Enter(sender As Object, e As EventArgs)
        Dim nud = CType(sender, NumericUpDown)
        nud.Select(0, nud.Text.Length)
    End Sub

    ' Nud enter
    Private Sub Nud_Leave(sender As Object, e As EventArgs)
        Dim nud = CType(sender, NumericUpDown)
        nud.Text = nud.Value.ToString()
    End Sub
#End Region

#Region "Methods"
    ' Display font digital
    Private Sub DigiFont()
        Dim path = $"{CurrentDomain.BaseDirectory}\DS_DIGI.ttf"
        If Not Exists(path) Then
            My.Computer.FileSystem.WriteAllBytes(path, My.Resources.DS_DIGI, True)
        End If
        Dim font = New PrivateFontCollection
        font.AddFontFile(path)
        lblRsltL.Font = New Font(font.Families(0), 15)
        lblRsltM.Font = New Font(font.Families(0), 15)
        lblRsltY.Font = New Font(font.Families(0), 15)
        lblHaunchL.Font = New Font(font.Families(0), 15)
        lblHaunchW.Font = New Font(font.Families(0), 15)
    End Sub

    ' Display result L
    Private Sub DispRsltL(l As Integer)
        If String.IsNullOrWhiteSpace(_sL) Then
            _sL += String.Format("{0:n0}", l)
        Else
            _sL += " + " + String.Format("{0:n0}", l)
        End If
        lblRsltL.Text = _sL
    End Sub

    ' Semi reset L
    Private Sub SemiResetL()
        _bending = False
        _l = 0
        _sL = ""
    End Sub

    ' Reset L
    Private Sub ResetL()
        _lock = False
        SemiResetL()
        nudL.ResetText()
    End Sub

    ' Limit L
    Private Sub LimitL()
        lblRsltL.Text = "LIMIT"
        lblRsltM.Text = "-----"
        lblRsltY.Text = "-----"
        ResetL()
    End Sub
#End Region
End Class