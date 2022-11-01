Imports System.Windows.Forms.Application
Imports YANF.Script
Imports YANF.Script.YANEvent

Public Class FrmMain
    ' Load frm
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    Private Sub NudH_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nudH.KeyPress
        Select Case Asc(e.KeyChar)
            Case 13 ' Enter
                MessageBox.Show("cc")
                'https://www.cs.cmu.edu/~pattis/15-1XX/common/handouts/ascii.html
        End Select
    End Sub
End Class