﻿Imports Corel.Interop.VGCore

Public Class ControlUI
    Private corelApp As Corel.Interop.VGCore.Application

    Sub New(ByVal corelApp As Corel.Interop.VGCore.Application)
        InitializeComponent()
        Me.corelApp = corelApp
    End Sub
End Class
