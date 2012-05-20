Option Strict On
Imports System.Management
Imports System
Imports MobileDevice
Public Class Form1

    Dim iPhonev As String
    Dim Name As String
    Dim Abfrage As New SelectQuery("win32_processor")
    Dim Suche As New ManagementObjectSearcher(Abfrage)
    Dim MO As ManagementObject
    Dim iphone As New MobileDevice.iPhone
    Friend Function HWID() As String
        For Each MO In Suche.Get()
            Name = CStr(MO("processorID"))
        Next
        Return Name
         BackgroundWorker1.CancelAsync()
    End Function
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        BackgroundWorker1.RunWorkerAsync()


    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Do Until iphone.IsConnected = True
            Application.DoEvents()
        Loop

        If iphone.DeviceProductType = "iPod3,1" Then
            iPhonev = "iPod Touch 3G"

        ElseIf iphone.DeviceProductType = "iPod4,1" Then
            iPhonev = "iPod Touch 4"

        ElseIf iphone.DeviceProductType = "iPod2,1" Then
            iPhonev = "iPod Touch 2G"

        ElseIf iphone.DeviceProductType = "iPod1,1" Then
            iPhonev = "iPod touch 1G"

        ElseIf iphone.DeviceProductType = "AppleTV2,1" Then
            iPhonev = "Apple TV 2G"

        ElseIf iphone.DeviceProductType = "iPad1,1" Then
            iPhonev = "iPad 1G"

        ElseIf iphone.DeviceProductType = "iPad2,1" Then
            iPhonev = "iPad 2G"

        ElseIf iphone.DeviceProductType = "iPad2,2" Then
            iPhonev = "iPad 2G"

        ElseIf iphone.DeviceProductType = "iPad2,3" Then
            iPhonev = "iPad 2G"

        ElseIf iphone.DeviceProductType = "iPhone1,1" Then
            iPhonev = "iPhone 2G"

        ElseIf iphone.DeviceProductType = "iPhone1,2" Then
            iPhonev = "iPhone 3G"

        ElseIf iphone.DeviceProductType = "iPhone2,1" Then
            iPhonev = "iPhone 3GS"

        ElseIf iphone.DeviceProductType = "iPhone3,3" Then
            iPhonev = "iPhone 4"

        ElseIf iphone.DeviceProductType = "iPhone3,1" Then
            iPhonev = "iPhone 4"

        ElseIf iphone.DeviceProductType = "iPhone4,1" Then
            iPhonev = "iPhone 4S"

        End If
    
        Label2.Text = "  " & iPhonev & " connected"
        TextBox2.Text = iphone.DeviceId
        TextBox1.Text = HWID()

    End Sub


    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Process.Start("change that")
    End Sub
End Class
