﻿Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'UWIEFFSU
        If My.Settings.SerialKey = TextBox1.Text Then
            My.Settings.AppStat = "Full Version"
            My.Settings.Save()
            Me.Close()
        Else
            MsgBox("Invalid Serial Key")
        End If
    End Sub
End Class