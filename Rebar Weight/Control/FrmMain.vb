Imports System.Drawing.Text
Imports System.Windows.Forms.Application
Imports YANF.Script
Imports YANF.Script.YANEvent
Imports System.AppDomain
Imports System.IO.File

Public Class FrmMain
#Region "Events"
    ' Load frm
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            AddHandler nud.KeyPress, AddressOf Nud_KeyPress
            AddHandler nud.Enter, AddressOf Nud_Enter
            AddHandler nud.Leave, AddressOf Nud_Leave
        Next
        AddHandler nudH.KeyPress, AddressOf NudHaunch_KeyPress
        AddHandler nudDeg.KeyPress, AddressOf NudHaunch_KeyPress
        ' option
        DigiFont()
    End Sub

    ' Shown frm
    Private Sub FrmMain_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        FadeIn()
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

    ' Nud press
    Private Sub Nud_KeyPress(sender As Object, e As KeyPressEventArgs)
        Dim nud = CType(sender, NumericUpDown)
        Select Case Asc(e.KeyChar)
            Case 72, 104 ' H or h
                nudH.Select()
            Case 82, 114 ' R or r
                nudDeg.Select()
            Case 68, 100 ' D or d
                nudD.Select()
            Case 76, 108 ' L or l
                nudL.Select()
            Case 32 ' space
                nud.ResetText()
        End Select
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

    ' Nud main press
    Private Sub NudMain_KeyPress(sender As Object, e As KeyPressEventArgs)
        ' TODO
    End Sub

    ' Nud haunch press
    Private Sub NudHaunch_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then ' enter
            Dim h = nudH.Value
            Dim deg = nudDeg.Value
            lblHaunchL.Text = $"L = {LHaunch(h, deg)}"
            lblHaunchW.Text = $"W = {WHaunch(h, deg)}"
        End If
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
#End Region
End Class