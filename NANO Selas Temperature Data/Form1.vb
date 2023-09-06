Imports System.Data.OleDb
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports NANO_Selas_Temperature_Data.USBTC08Imports
Imports Excel = Microsoft.Office.Interop.Excel
Public Class Form1
    Public Sub cboPro()

        Dim con As OleDbConnection = New OleDbConnection
        con.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\LF Database\Selas_db.accdb")
        con.Open()
        Dim df As String = "select process from Process_tb"
        Dim cmd As New OleDbCommand(df, con)
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader
        Try

            While dr.Read
                cboProcess.Items.Add(dr("process").ToString)
            End While
            con.Close()


        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)

        End Try
    End Sub

    Private Sub cboProcess_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProcess.SelectedIndexChanged
        cboPro()
    End Sub

    Private Sub cboProcess_MouseClick(sender As Object, e As MouseEventArgs) Handles cboProcess.MouseClick
        cboProcess.Items.Clear()
        cboPro()
    End Sub

    Public Sub cboPart()

        Dim con As OleDbConnection = New OleDbConnection
        con.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\LF Database\Selas_db.accdb")
        con.Open()
        Dim df As String = "select part_no from PartNo_tb"
        Dim cmd As New OleDbCommand(df, con)
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader
        Try

            While dr.Read
                cboPartNo.Items.Add(dr("part_no").ToString)
            End While
            con.Close()


        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)

        End Try
    End Sub

    Private Sub cboPartNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPartNo.SelectedIndexChanged

        cboPart()

    End Sub

    Private Sub cboPartNo_MouseClick(sender As Object, e As MouseEventArgs) Handles cboPartNo.MouseClick
        cboPartNo.Items.Clear()
        cboPart()
    End Sub

    Public Sub cboAs()
        Dim con As OleDbConnection = New OleDbConnection
        con.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\LF Database\Selas_db.accdb")
        con.Open()
        Dim df As String = "select associate from Associate_tb ORDER BY associate"
        Dim cmd As New OleDbCommand(df, con)
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader
        Try

            While dr.Read
                cboAssociate.Items.Add(dr("associate").ToString)
            End While
            con.Close()


        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)

        End Try
    End Sub

    Private Sub cboAssociate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAssociate.SelectedIndexChanged
        cboAs()
    End Sub

    Private Sub cboAssociate_MouseClick(sender As Object, e As MouseEventArgs) Handles cboAssociate.MouseClick
        cboAssociate.Items.Clear()
        cboAs()
    End Sub

    Public qwerty As Object
    Public chnl1 As Object
    Public chnl2 As Object
    Public chnl3 As Object
    Public chnl4 As Object
    Public chnl5 As Object
    Public chnl6 As Object
    Public chnl7 As Object
    Public chnl8 As Object
    Public chnl9 As Object
    Public chnl10 As Object
    Public temp(1000000) As String
    Public x As Integer
    Public i As Integer
    Public eror As String

    Public status As Short
    Public usbtc08Handle As Short
    Public info As String
    Public minimumIntervalMS As Integer
    Public tempBuffer(8) As Single
    Public count As Integer
    Public overflowFlag As Short
    'Public keypress As Boolean

    Public Sub Main()



        usbtc08Handle = 0
        'keypress = False

        If (usbtc08Handle < 1) Then

            Console.WriteLine("USB TC-08 VB.NET Console application" & vbNewLine)

            Console.WriteLine("Opening connection to USB TC-08..." & vbNewLine)

            usbtc08Handle = usb_tc08_open_unit()

            If (usbtc08Handle > 0) Then

                Console.WriteLine("USB TC-08 connected." & vbNewLine)

                info = "              "

                'Output info
                Call usb_tc08_get_unit_info2(usbtc08Handle, info, 80, 0)
                Console.WriteLine("Driver Version " & info)

                Call usb_tc08_get_unit_info2(usbtc08Handle, info, 80, 1)
                Console.WriteLine("Kernel Driver Version " & info)

                Call usb_tc08_get_unit_info2(usbtc08Handle, info, 80, 4)
                Console.WriteLine("Serial Number " & info)

                Call usb_tc08_get_unit_info2(usbtc08Handle, info, 80, 5)
                Console.WriteLine("Cal Date " & info & vbNewLine)

                ' Set noise rejection to 50 or 60Hz
                Call usb_tc08_set_mains(usbtc08Handle, USBTC08MainsFrequency.USBTC08_REJECT_50HZ)

                ' Set Channels - Cold Junction, Ch 1 and Ch 2
                status = usb_tc08_set_channel(usbtc08Handle, USBTC08Channels.USBTC08_CHANNEL_1, "K")
                status = usb_tc08_set_channel(usbtc08Handle, USBTC08Channels.USBTC08_CHANNEL_2, "K")
                status = usb_tc08_set_channel(usbtc08Handle, USBTC08Channels.USBTC08_CHANNEL_3, "K")
                status = usb_tc08_set_channel(usbtc08Handle, USBTC08Channels.USBTC08_CHANNEL_4, "K")
                status = usb_tc08_set_channel(usbtc08Handle, USBTC08Channels.USBTC08_CHANNEL_5, "K")

                ' Minimum Sampling Interval
                minimumIntervalMS = usb_tc08_get_minimum_interval_ms(usbtc08Handle)

                'Obtain 10 sets of temperature readings with 1 second between requests

                Console.WriteLine("Collecting 10 sets of readings..." & vbNewLine)
                Console.WriteLine("Ch1" & vbTab & vbTab & "Ch2" & vbTab & vbTab & "Ch3" & vbTab & vbTab & "Ch4" & vbTab & vbTab & "Ch5")
                Array.Clear(temp, 0, temp.Length)




            Else

                Console.WriteLine("Unable to open USB TC-08")

            End If

        End If
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        If Not cboProcess.Items.Contains(cboProcess.Text) Then
            Timer1.Enabled = False
            Timer2.Enabled = False
            ProgressBar1.Visible = False
            ProgressBar2.Visible = False
            MessageBox.Show("Please fill the required fields.")
        ElseIf Not cboPartNo.Items.Contains(cboPartNo.Text) Then
            Timer1.Enabled = False
            Timer2.Enabled = False
            ProgressBar1.Visible = False
            ProgressBar2.Visible = False
            MessageBox.Show("Please input the proper part number.")
        ElseIf tbLotNum.Text = "" Then
            Timer1.Enabled = False
            Timer2.Enabled = False
            ProgressBar1.Visible = False
            ProgressBar2.Visible = False
            MessageBox.Show("Please input the lot number.")
        ElseIf Not cboAssociate.Items.Contains(cboAssociate.Text) Then
            Timer1.Enabled = False
            Timer2.Enabled = False
            ProgressBar1.Visible = False
            ProgressBar2.Visible = False
            MessageBox.Show("Please fill in the proper name of the associate.")
        Else

            Dim processname As String

            processname = cboProcess.Text

            Select Case processname

                Case "Sq Nano Selas 21"
                    get_message = """Process,""" & "," & """Part number,""" & "," & """Lot number,""" & "," & """Associate,""" & "," & """Selas Temperature1,""" & "," & """Selas Temperature2,""" & "," & """Delta Result,""" & "," & """Delta2 Result,""" & vbCrLf

                    Getparam() 'Get the parameter of timer


                    ProgressBar1.Maximum = First_param
                    If i < First_param Then
                        i = 1
                    End If

                    Timer1.Enabled = True
                    'Timer2.Enabled = True
                    Timer4.Enabled = False
                    ProgressBar1.Visible = True
                    ProgressBar2.Visible = True
                    lblSec.Visible = True
                    lblSec2.Visible = True
                    btnStart.Enabled = False
                    btnExport.Enabled = False
                    cboProcess.Enabled = False
                    cboPartNo.Enabled = False
                    tbLotNum.Enabled = False
                    cboAssociate.Enabled = False

                Case "Sq Nano Selas 22"
                    get_message = """Process,""" & "," & """Part number,""" & "," & """Lot number,""" & "," & """Associate,""" & "," & """Selas Temperature1,""" & "," & """Selas Temperature2,""" & "," & """Delta Result,""" & "," & """Delta2 Result,""" & vbCrLf

                    Getparam() 'Get the parameter of timer

                    ProgressBar1.Maximum = First_param
                    If i < First_param Then
                        i = 1
                    End If

                    Timer1.Enabled = True
                    'Timer2.Enabled = True
                    Timer4.Enabled = False
                    ProgressBar1.Visible = True
                    ProgressBar2.Visible = True
                    lblSec.Visible = True
                    lblSec2.Visible = True
                    btnStart.Enabled = False
                    btnExport.Enabled = False
                    cboProcess.Enabled = False
                    cboPartNo.Enabled = False
                    tbLotNum.Enabled = False
                    cboAssociate.Enabled = False

                Case "Sq Nano Selas 23"
                    get_message = """Process,""" & "," & """Part number,""" & "," & """Lot number,""" & "," & """Associate,""" & "," & """Selas Temperature1,""" & "," & """Selas Temperature2,""" & "," & """Delta Result,""" & "," & """Delta2 Result,""" & vbCrLf

                    Getparam() 'Get the parameter of timer

                    ProgressBar1.Maximum = First_param
                    If i < First_param Then
                        i = 1
                    End If


                    Timer1.Enabled = True
                    'Timer2.Enabled = True
                    Timer4.Enabled = False
                    ProgressBar1.Visible = True
                    ProgressBar2.Visible = True
                    lblSec.Visible = True
                    lblSec2.Visible = True
                    btnStart.Enabled = False
                    btnExport.Enabled = False
                    cboProcess.Enabled = False
                    cboPartNo.Enabled = False
                    tbLotNum.Enabled = False
                    cboAssociate.Enabled = False

                Case "Sq Nano Selas 24"
                    get_message = """Process,""" & "," & """Part number,""" & "," & """Lot number,""" & "," & """Associate,""" & "," & """Selas Temperature1,""" & "," & """Selas Temperature2,""" & "," & """Delta Result,""" & "," & """Delta2 Result,""" & vbCrLf

                    Getparam() 'Get the parameter of timer

                    ProgressBar1.Maximum = First_param
                    If i < First_param Then
                        i = 1
                    End If


                    Timer1.Enabled = True
                    'Timer2.Enabled = True
                    Timer4.Enabled = False
                    ProgressBar1.Visible = True
                    ProgressBar2.Visible = True
                    lblSec.Visible = True
                    lblSec2.Visible = True
                    btnStart.Enabled = False
                    btnExport.Enabled = False
                    cboProcess.Enabled = False
                    cboPartNo.Enabled = False
                    tbLotNum.Enabled = False
                    cboAssociate.Enabled = False

                Case "Sq Nano Selas 25"
                    get_message = """Process,""" & "," & """Part number,""" & "," & """Lot number,""" & "," & """Associate,""" & "," & """Selas Temperature1,""" & "," & """Selas Temperature2,""" & "," & """Delta Result,""" & "," & """Delta2 Result,""" & vbCrLf

                    Getparam() 'Get the parameter of timer

                    ProgressBar1.Maximum = First_param
                    If i < First_param Then
                        i = 1
                    End If

                    Timer1.Enabled = True
                    'Timer2.Enabled = True
                    Timer4.Enabled = False
                    ProgressBar1.Visible = True
                    ProgressBar2.Visible = True
                    lblSec.Visible = True
                    lblSec2.Visible = True
                    btnStart.Enabled = False
                    btnExport.Enabled = False
                    cboProcess.Enabled = False
                    cboPartNo.Enabled = False
                    tbLotNum.Enabled = False
                    cboAssociate.Enabled = False

                Case "Sq Nano Selas 26 - FA"
                    get_message = """Process,""" & "," & """Part number,""" & "," & """Lot number,""" & "," & """Associate,""" & "," & """Selas Temperature1,""" & "," & """Selas Temperature2,""" & "," & """Delta Result,""" & "," & """Delta2 Result,""" & vbCrLf

                    Getparam() 'Get the parameter of timer

                    ProgressBar1.Maximum = First_param
                    If i < First_param Then
                        i = 1
                    End If

                    Timer1.Enabled = True
                    'Timer2.Enabled = True
                    Timer4.Enabled = False
                    ProgressBar1.Visible = True
                    ProgressBar2.Visible = True
                    lblSec.Visible = True
                    lblSec2.Visible = True
                    btnStart.Enabled = False
                    btnExport.Enabled = False
                    cboProcess.Enabled = False
                    cboPartNo.Enabled = False
                    tbLotNum.Enabled = False
                    cboAssociate.Enabled = False

                Case "Sq Nano Selas 26 - Hitachi"
                    get_message = """Process,""" & "," & """Part number,""" & "," & """Lot number,""" & "," & """Associate,""" & "," & """Selas Temperature1,""" & "," & """Selas Temperature2,""" & "," & """Delta Result,""" & "," & """Delta2 Result,""" & vbCrLf

                    Getparam() 'Get the parameter of timer

                    ProgressBar1.Maximum = First_param
                    If i < First_param Then
                        i = 1
                    End If

                    Timer1.Enabled = True
                    'Timer2.Enabled = True
                    Timer4.Enabled = False
                    ProgressBar1.Visible = True
                    ProgressBar2.Visible = True
                    lblSec.Visible = True
                    lblSec2.Visible = True
                    btnStart.Enabled = False
                    btnExport.Enabled = False
                    cboProcess.Enabled = False
                    cboPartNo.Enabled = False
                    tbLotNum.Enabled = False
                    cboAssociate.Enabled = False

                Case "Sq Nano Selas 27"
                    get_message = """Process,""" & "," & """Part number,""" & "," & """Lot number,""" & "," & """Associate,""" & "," & """Selas Temperature1,""" & "," & """Selas Temperature2,""" & "," & """Delta Result,""" & "," & """Delta2 Result,""" & vbCrLf

                    Getparam() 'Get the parameter of timer

                    ProgressBar1.Maximum = First_param
                    If i < First_param Then
                        i = 1
                    End If

                    Timer1.Enabled = True
                    'Timer2.Enabled = True
                    Timer4.Enabled = False
                    ProgressBar1.Visible = True
                    ProgressBar2.Visible = True
                    lblSec.Visible = True
                    lblSec2.Visible = True
                    btnStart.Enabled = False
                    btnExport.Enabled = False
                    cboProcess.Enabled = False
                    cboPartNo.Enabled = False
                    tbLotNum.Enabled = False
                    cboAssociate.Enabled = False

                Case "Sq Nano Selas 28"
                    get_message = """Process,""" & "," & """Part number,""" & "," & """Lot number,""" & "," & """Associate,""" & "," & """Selas Temperature1,""" & "," & """Selas Temperature2,""" & "," & """Delta Result,""" & "," & """Delta2 Result,""" & vbCrLf

                    Getparam() 'Get the parameter of timer

                    ProgressBar1.Maximum = First_param
                    If i < First_param Then
                        i = 1
                    End If

                    Timer1.Enabled = True
                    'Timer2.Enabled = True
                    Timer4.Enabled = False
                    ProgressBar1.Visible = True
                    ProgressBar2.Visible = True
                    lblSec.Visible = True
                    lblSec2.Visible = True
                    btnStart.Enabled = False
                    btnExport.Enabled = False
                    cboProcess.Enabled = False
                    cboPartNo.Enabled = False
                    tbLotNum.Enabled = False
                    cboAssociate.Enabled = False

                Case "Sq Nano Selas 29 - 448"
                    get_message = """Process,""" & "," & """Part number,""" & "," & """Lot number,""" & "," & """Associate,""" & "," & """Selas Temperature1,""" & "," & """Selas Temperature2,""" & "," & """Delta Result,""" & "," & """Delta2 Result,""" & vbCrLf

                    Getparam() 'Get the parameter of timer

                    ProgressBar1.Maximum = First_param
                    If i < First_param Then
                        i = 1
                    End If

                    Timer1.Enabled = True
                    'Timer2.Enabled = True
                    Timer4.Enabled = False
                    ProgressBar1.Visible = True
                    ProgressBar2.Visible = True
                    lblSec.Visible = True
                    lblSec2.Visible = True
                    btnStart.Enabled = False
                    btnExport.Enabled = False
                    cboProcess.Enabled = False
                    cboPartNo.Enabled = False
                    tbLotNum.Enabled = False
                    cboAssociate.Enabled = False

                Case "Sq Nano Selas 29 - 157/154/451/453"
                    get_message = """Process,""" & "," & """Part number,""" & "," & """Lot number,""" & "," & """Associate,""" & "," & """Selas Temperature1,""" & "," & """Selas Temperature2,""" & "," & """Delta Result,""" & "," & """Delta2 Result,""" & vbCrLf

                    Getparam() 'Get the parameter of timer

                    ProgressBar1.Maximum = First_param
                    If i < First_param Then
                        i = 1
                    End If

                    Timer1.Enabled = True
                    'Timer2.Enabled = True
                    Timer4.Enabled = False
                    ProgressBar1.Visible = True
                    ProgressBar2.Visible = True
                    lblSec.Visible = True
                    lblSec2.Visible = True
                    btnStart.Enabled = False
                    btnExport.Enabled = False
                    cboProcess.Enabled = False
                    cboPartNo.Enabled = False
                    tbLotNum.Enabled = False
                    cboAssociate.Enabled = False

                Case "Sq Nano Selas 30"
                    get_message = """Process,""" & "," & """Part number,""" & "," & """Lot number,""" & "," & """Associate,""" & "," & """Selas Temperature1,""" & "," & """Selas Temperature2,""" & "," & """Delta Result,""" & "," & """Delta2 Result,""" & vbCrLf

                    Getparam() 'Get the parameter of timer

                    ProgressBar1.Maximum = First_param
                    If i < First_param Then
                        i = 1
                    End If

                    Timer1.Enabled = True
                    'Timer2.Enabled = True
                    Timer4.Enabled = False
                    ProgressBar1.Visible = True
                    ProgressBar2.Visible = True
                    lblSec.Visible = True
                    lblSec2.Visible = True
                    btnStart.Enabled = False
                    btnExport.Enabled = False
                    cboProcess.Enabled = False
                    cboPartNo.Enabled = False
                    tbLotNum.Enabled = False
                    cboAssociate.Enabled = False

                Case "Sq Nano Selas 31"
                    get_message = """Process,""" & "," & """Part number,""" & "," & """Lot number,""" & "," & """Associate,""" & "," & """Selas Temperature1,""" & "," & """Selas Temperature2,""" & "," & """Delta Result,""" & "," & """Delta2 Result,""" & vbCrLf

                    Getparam() 'Get the parameter of timer

                    ProgressBar1.Maximum = First_param
                    If i < First_param Then
                        i = 1
                    End If

                    Timer1.Enabled = True
                    'Timer2.Enabled = True
                    Timer4.Enabled = False
                    ProgressBar1.Visible = True
                    ProgressBar2.Visible = True
                    lblSec.Visible = True
                    lblSec2.Visible = True
                    btnStart.Enabled = False
                    btnExport.Enabled = False
                    cboProcess.Enabled = False
                    cboPartNo.Enabled = False
                    tbLotNum.Enabled = False
                    cboAssociate.Enabled = False

                Case "Sq Nano Selas 32"
                    get_message = """Process,""" & "," & """Part number,""" & "," & """Lot number,""" & "," & """Associate,""" & "," & """Selas Temperature1,""" & "," & """Selas Temperature2,""" & "," & """Delta Result,""" & "," & """Delta2 Result,""" & vbCrLf

                    Getparam() 'Get the parameter of timer

                    ProgressBar1.Maximum = First_param
                    If i < First_param Then
                        i = 1
                    End If

                    Timer1.Enabled = True
                    'Timer2.Enabled = True
                    Timer4.Enabled = False
                    ProgressBar1.Visible = True
                    ProgressBar2.Visible = True
                    lblSec.Visible = True
                    lblSec2.Visible = True
                    btnStart.Enabled = False
                    btnExport.Enabled = False
                    cboProcess.Enabled = False
                    cboPartNo.Enabled = False
                    tbLotNum.Enabled = False
                    cboAssociate.Enabled = False

                Case "Sq Nano Selas 33"
                    get_message = """Process,""" & "," & """Part number,""" & "," & """Lot number,""" & "," & """Associate,""" & "," & """Selas Temperature1,""" & "," & """Selas Temperature2,""" & "," & """Delta Result,""" & "," & """Delta2 Result,""" & vbCrLf

                    Getparam() 'Get the parameter of timer

                    ProgressBar1.Maximum = First_param
                    If i < First_param Then
                        i = 1
                    End If

                    Timer1.Enabled = True
                    'Timer2.Enabled = True
                    Timer4.Enabled = False
                    ProgressBar1.Visible = True
                    ProgressBar2.Visible = True
                    lblSec.Visible = True
                    lblSec2.Visible = True
                    btnStart.Enabled = False
                    btnExport.Enabled = False
                    cboProcess.Enabled = False
                    cboPartNo.Enabled = False
                    tbLotNum.Enabled = False
                    cboAssociate.Enabled = False

                Case "Sq Nano Selas 34"
                    get_message = """Process,""" & "," & """Part number,""" & "," & """Lot number,""" & "," & """Associate,""" & "," & """Selas Temperature1,""" & "," & """Selas Temperature2,""" & "," & """Delta Result,""" & "," & """Delta2 Result,""" & vbCrLf

                    Getparam() 'Get the parameter of timer

                    ProgressBar1.Maximum = First_param
                    If i < First_param Then
                        i = 1
                    End If

                    Timer1.Enabled = True
                    'Timer2.Enabled = True
                    Timer4.Enabled = False
                    ProgressBar1.Visible = True
                    ProgressBar2.Visible = True
                    lblSec.Visible = True
                    lblSec2.Visible = True
                    btnStart.Enabled = False
                    btnExport.Enabled = False
                    cboProcess.Enabled = False
                    cboPartNo.Enabled = False
                    tbLotNum.Enabled = False
                    cboAssociate.Enabled = False

                Case "Sq Nano Selas 35"
                    get_message = """Process,""" & "," & """Part number,""" & "," & """Lot number,""" & "," & """Associate,""" & "," & """Selas Temperature1,""" & "," & """Selas Temperature2,""" & "," & """Delta Result,""" & "," & """Delta2 Result,""" & vbCrLf

                    Getparam() 'Get the parameter of timer

                    ProgressBar1.Maximum = First_param
                    If i < First_param Then
                        i = 1
                    End If

                    Timer1.Enabled = True
                    'Timer2.Enabled = True
                    Timer4.Enabled = False
                    ProgressBar1.Visible = True
                    ProgressBar2.Visible = True
                    lblSec.Visible = True
                    lblSec2.Visible = True
                    btnStart.Enabled = False
                    btnExport.Enabled = False
                    cboProcess.Enabled = False
                    cboPartNo.Enabled = False
                    tbLotNum.Enabled = False
                    cboAssociate.Enabled = False

                Case "Sq Nano Selas 36"
                    get_message = """Process,""" & "," & """Part number,""" & "," & """Lot number,""" & "," & """Associate,""" & "," & """Selas Temperature1,""" & "," & """Selas Temperature2,""" & "," & """Delta Result,""" & "," & """Delta2 Result,""" & vbCrLf

                    Getparam() 'Get the parameter of timer

                    ProgressBar1.Maximum = First_param
                    If i < First_param Then
                        i = 1
                    End If

                    Timer1.Enabled = True
                    'Timer2.Enabled = True
                    Timer4.Enabled = False
                    ProgressBar1.Visible = True
                    ProgressBar2.Visible = True
                    lblSec.Visible = True
                    lblSec2.Visible = True
                    btnStart.Enabled = False
                    btnExport.Enabled = False
                    cboProcess.Enabled = False
                    cboPartNo.Enabled = False
                    tbLotNum.Enabled = False
                    cboAssociate.Enabled = False

                Case "Sq Nano Selas 37"
                    get_message = """Process,""" & "," & """Part number,""" & "," & """Lot number,""" & "," & """Associate,""" & "," & """Selas Temperature1,""" & "," & """Selas Temperature2,""" & "," & """Delta Result,""" & "," & """Delta2 Result,""" & vbCrLf

                    Getparam() 'Get the parameter of timer

                    ProgressBar1.Maximum = First_param
                    If i < First_param Then
                        i = 1
                    End If

                    Timer1.Enabled = True
                    'Timer2.Enabled = True
                    Timer4.Enabled = False
                    ProgressBar1.Visible = True
                    ProgressBar2.Visible = True
                    lblSec.Visible = True
                    lblSec2.Visible = True
                    btnStart.Enabled = False
                    btnExport.Enabled = False
                    cboProcess.Enabled = False
                    cboPartNo.Enabled = False
                    tbLotNum.Enabled = False
                    cboAssociate.Enabled = False

                Case "Sq Nano Selas 38"
                    get_message = """Process,""" & "," & """Part number,""" & "," & """Lot number,""" & "," & """Associate,""" & "," & """Selas Temperature1,""" & "," & """Selas Temperature2,""" & "," & """Delta Result,""" & "," & """Delta2 Result,""" & vbCrLf

                    Getparam() 'Get the parameter of timer

                    ProgressBar1.Maximum = First_param
                    If i < First_param Then
                        i = 1
                    End If

                    Timer1.Enabled = True
                    'Timer2.Enabled = True
                    Timer4.Enabled = False
                    ProgressBar1.Visible = True
                    ProgressBar2.Visible = True
                    lblSec.Visible = True
                    lblSec2.Visible = True
                    btnStart.Enabled = False
                    btnExport.Enabled = False
                    cboProcess.Enabled = False
                    cboPartNo.Enabled = False
                    tbLotNum.Enabled = False
                    cboAssociate.Enabled = False

                Case "Sq Nano Selas 39 - 449"
                    get_message = """Process,""" & "," & """Part number,""" & "," & """Lot number,""" & "," & """Associate,""" & "," & """Selas Temperature1,""" & "," & """Selas Temperature2,""" & "," & """Delta Result,""" & "," & """Delta2 Result,""" & vbCrLf

                    Getparam() 'Get the parameter of timer

                    ProgressBar1.Maximum = First_param
                    If i < First_param Then
                        i = 1
                    End If

                    Timer1.Enabled = True
                    'Timer2.Enabled = True
                    Timer4.Enabled = False
                    ProgressBar1.Visible = True
                    ProgressBar2.Visible = True
                    lblSec.Visible = True
                    lblSec2.Visible = True
                    btnStart.Enabled = False
                    btnExport.Enabled = False
                    cboProcess.Enabled = False
                    cboPartNo.Enabled = False
                    tbLotNum.Enabled = False
                    cboAssociate.Enabled = False

                Case "Sq Nano Selas 39 - 452/454"
                    get_message = """Process,""" & "," & """Part number,""" & "," & """Lot number,""" & "," & """Associate,""" & "," & """Selas Temperature1,""" & "," & """Selas Temperature2,""" & "," & """Delta Result,""" & "," & """Delta2 Result,""" & vbCrLf

                    Getparam() 'Get the parameter of timer

                    ProgressBar1.Maximum = First_param
                    If i < First_param Then
                        i = 1
                    End If


                    Timer1.Enabled = True
                    'Timer2.Enabled = True
                    Timer4.Enabled = False
                    ProgressBar1.Visible = True
                    ProgressBar2.Visible = True
                    lblSec.Visible = True
                    lblSec2.Visible = True
                    btnStart.Enabled = False
                    btnExport.Enabled = False
                    cboProcess.Enabled = False
                    cboPartNo.Enabled = False
                    tbLotNum.Enabled = False
                    cboAssociate.Enabled = False

                Case "Sq Nano Selas 40"
                    get_message = """Process,""" & "," & """Part number,""" & "," & """Lot number,""" & "," & """Associate,""" & "," & """Selas Temperature1,""" & "," & """Selas Temperature2,""" & "," & """Delta Result,""" & "," & """Delta2 Result,""" & vbCrLf

                    Getparam() 'Get the parameter of timer

                    ProgressBar1.Maximum = First_param
                    If i < First_param Then
                        i = 1
                    End If

                    Timer1.Enabled = True
                    'Timer2.Enabled = True
                    Timer4.Enabled = False
                    ProgressBar1.Visible = True
                    ProgressBar2.Visible = True
                    lblSec.Visible = True
                    lblSec2.Visible = True
                    btnStart.Enabled = False
                    btnExport.Enabled = False
                    cboProcess.Enabled = False
                    cboPartNo.Enabled = False
                    tbLotNum.Enabled = False
                    cboAssociate.Enabled = False

                Case "Sq Nano Selas 41"
                    get_message = """Process,""" & "," & """Part number,""" & "," & """Lot number,""" & "," & """Associate,""" & "," & """Selas Temperature1,""" & "," & """Selas Temperature2,""" & "," & """Delta Result,""" & "," & """Delta2 Result,""" & vbCrLf

                    Getparam() 'Get the parameter of timer

                    ProgressBar1.Maximum = First_param
                    If i < First_param Then
                        i = 1
                    End If

                    Timer1.Enabled = True
                    'Timer2.Enabled = True
                    Timer4.Enabled = False
                    ProgressBar1.Visible = True
                    ProgressBar2.Visible = True
                    lblSec.Visible = True
                    lblSec2.Visible = True
                    btnStart.Enabled = False
                    btnExport.Enabled = False
                    cboProcess.Enabled = False
                    cboPartNo.Enabled = False
                    tbLotNum.Enabled = False
                    cboAssociate.Enabled = False

                Case "Sq Nano Selas 42"
                    get_message = """Process,""" & "," & """Part number,""" & "," & """Lot number,""" & "," & """Associate,""" & "," & """Selas Temperature1,""" & "," & """Selas Temperature2,""" & "," & """Delta Result,""" & "," & """Delta2 Result,""" & vbCrLf

                    Getparam() 'Get the parameter of timer

                    ProgressBar1.Maximum = First_param
                    If i < First_param Then
                        i = 1
                    End If

                    Timer1.Enabled = True
                    'Timer2.Enabled = True
                    Timer4.Enabled = False
                    ProgressBar1.Visible = True
                    ProgressBar2.Visible = True
                    lblSec.Visible = True
                    lblSec2.Visible = True
                    btnStart.Enabled = False
                    btnExport.Enabled = False
                    cboProcess.Enabled = False
                    cboPartNo.Enabled = False
                    tbLotNum.Enabled = False
                    cboAssociate.Enabled = False

                Case "Sq Nano Selas 43"
                    get_message = """Process,""" & "," & """Part number,""" & "," & """Lot number,""" & "," & """Associate,""" & "," & """Selas Temperature1,""" & "," & """Selas Temperature2,""" & "," & """Delta Result,""" & "," & """Delta2 Result,""" & vbCrLf

                    Getparam() 'Get the parameter of timer

                    ProgressBar1.Maximum = First_param
                    If i < First_param Then
                        i = 1
                    End If

                    Timer1.Enabled = True
                    'Timer2.Enabled = True
                    Timer4.Enabled = False
                    ProgressBar1.Visible = True
                    ProgressBar2.Visible = True
                    lblSec.Visible = True
                    lblSec2.Visible = True
                    btnStart.Enabled = False
                    btnExport.Enabled = False
                    cboProcess.Enabled = False
                    cboPartNo.Enabled = False
                    tbLotNum.Enabled = False
                    cboAssociate.Enabled = False

                Case "Sq Nano Selas 44"
                    get_message = """Process,""" & "," & """Part number,""" & "," & """Lot number,""" & "," & """Associate,""" & "," & """Selas Temperature1,""" & "," & """Selas Temperature2,""" & "," & """Delta Result,""" & "," & """Delta2 Result,""" & vbCrLf

                    Getparam() 'Get the parameter of timer

                    ProgressBar1.Maximum = First_param
                    If i < First_param Then
                        i = 1
                    End If

                    Timer1.Enabled = True
                    'Timer2.Enabled = True
                    Timer4.Enabled = False
                    ProgressBar1.Visible = True
                    ProgressBar2.Visible = True
                    lblSec.Visible = True
                    lblSec2.Visible = True
                    btnStart.Enabled = False
                    btnExport.Enabled = False
                    cboProcess.Enabled = False
                    cboPartNo.Enabled = False
                    tbLotNum.Enabled = False
                    cboAssociate.Enabled = False

                Case "Sq Nano Selas 45"
                    get_message = """Process,""" & "," & """Part number,""" & "," & """Lot number,""" & "," & """Associate,""" & "," & """Selas Temperature1,""" & "," & """Selas Temperature2,""" & "," & """Delta Result,""" & "," & """Delta2 Result,""" & vbCrLf

                    Getparam() 'Get the parameter of timer

                    ProgressBar1.Maximum = First_param
                    If i < First_param Then
                        i = 1
                    End If

                    Timer1.Enabled = True
                    'Timer2.Enabled = True
                    Timer4.Enabled = False
                    ProgressBar1.Visible = True
                    ProgressBar2.Visible = True
                    lblSec.Visible = True
                    lblSec2.Visible = True
                    btnStart.Enabled = False
                    btnExport.Enabled = False
                    cboProcess.Enabled = False
                    cboPartNo.Enabled = False
                    tbLotNum.Enabled = False
                    cboAssociate.Enabled = False

                Case "Sq Nano Selas 46"
                    get_message = """Process,""" & "," & """Part number,""" & "," & """Lot number,""" & "," & """Associate,""" & "," & """Selas Temperature1,""" & "," & """Selas Temperature2,""" & "," & """Delta Result,""" & "," & """Delta2 Result,""" & vbCrLf

                    Getparam() 'Get the parameter of timer

                    ProgressBar1.Maximum = First_param
                    If i < First_param Then
                        i = 1
                    End If

                    Timer1.Enabled = True
                    'Timer2.Enabled = True
                    Timer4.Enabled = False
                    ProgressBar1.Visible = True
                    ProgressBar2.Visible = True
                    lblSec.Visible = True
                    lblSec2.Visible = True
                    btnStart.Enabled = False
                    btnExport.Enabled = False
                    cboProcess.Enabled = False
                    cboPartNo.Enabled = False
                    tbLotNum.Enabled = False
                    cboAssociate.Enabled = False

            End Select


        End If



    End Sub

    Public First_param As String
    Public Second_param As String

    '----------------------- GET THE PARAMETER FOR TIMER --------------------------
    Public Sub Getparam()
        Dim con As OleDbConnection = New OleDbConnection
        con.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\LF Database\Selas_db.accdb")

        '---------- SQ 21 1st parameter -------------
        Try
            Dim MyData As String
            Dim cmd As New OleDbCommand
            Dim Data As New DataTable
            Dim adap As New OleDbDataAdapter
            con.Open()

            MyData = "SELECT * From SelasTime_tb WHERE Process Like '%" & cboProcess.Text & "%'"
            cmd.Connection = con
            cmd.CommandText = MyData
            adap.SelectCommand = cmd

            adap.Fill(Data)

            If Data.Rows.Count > 0 Then
                First_param = Data.Rows(0).Item("First time").ToString
                Console.WriteLine(First_param)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            con.Close()

        End Try

    End Sub

    Public Sub Getparam2()
        Dim con As OleDbConnection = New OleDbConnection
        con.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\LF Database\Selas_db.accdb")

        '---------- SQ 21 1st parameter -------------
        Try
            Dim MyData As String
            Dim cmd As New OleDbCommand
            Dim Data As New DataTable
            Dim adap As New OleDbDataAdapter
            con.Open()

            MyData = "SELECT * From SelasTime_tb WHERE Process Like '%" & cboProcess.Text & "%'"
            cmd.Connection = con
            cmd.CommandText = MyData
            adap.SelectCommand = cmd

            adap.Fill(Data)

            If Data.Rows.Count > 0 Then
                Second_param = Data.Rows(0).Item("Second time").ToString
                Console.WriteLine(Second_param)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            con.Close()

        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Visible = False
        ProgressBar2.Visible = False
        lblReady.Visible = False
        lblSec.Visible = False
        lblSec2.Visible = False
        btnExport.Enabled = False
        lblExit.Visible = False
        btnEnable.Visible = False

        cboProcess.Select()
        Timer4.Enabled = True
        Main()



        'TODO: This line of code loads data into the 'SelasTempDataSet1.SelasTemp_db' table. You can move, or remove it, as needed.
        Me.SelasTemp_dbTableAdapter.Fill(Me.SelasTempDataSet1.SelasTemp_db)

        lblCHL1.Visible = False
        lblCHL2.Visible = False
        lblCHL3.Visible = False
        lblCHL4.Visible = False
        lblCHL5.Visible = False
        lblCHL6.Visible = False
        lblCHL7.Visible = False
        lblCHL8.Visible = False
        lblCHL9.Visible = False
        lblCHL10.Visible = False

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do you really want to exit?", "Exit Selas Temperature Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialog = DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If
    End Sub
    Public temp_data(500) As Decimal
    Public temp_data2(500) As Decimal
    Public Sub sleep()
        lblCHL1.Text = Math.Round(CDec(chnl1), 2)
        lblCHL2.Text = Math.Round(CDec(chnl2), 2)
        lblCHL3.Text = Math.Round(CDec(chnl3), 2)
        lblCHL4.Text = Math.Round(CDec(chnl4), 2)
        lblCHL5.Text = Math.Round(CDec(chnl5), 2)
        lblCHL6.Text = Math.Round(CDec(chnl6), 2)
        lblCHL7.Text = Math.Round(CDec(chnl7), 2)
        lblCHL8.Text = Math.Round(CDec(chnl8), 2)
        lblCHL9.Text = Math.Round(CDec(chnl9), 2)
        lblCHL10.Text = Math.Round(CDec(chnl10), 2)

        temp_data(0) = CDec(lblCHL1.Text)
        temp_data(1) = CDec(lblCHL2.Text)
        temp_data(2) = CDec(lblCHL3.Text)
        temp_data(3) = CDec(lblCHL4.Text)
        temp_data(4) = CDec(lblCHL5.Text)

        temp_data2(0) = CDec(lblCHL6.Text)
        temp_data2(1) = CDec(lblCHL7.Text)
        temp_data2(2) = CDec(lblCHL8.Text)
        temp_data2(3) = CDec(lblCHL9.Text)
        temp_data2(4) = CDec(lblCHL10.Text)

        lblCHL1.Visible = True
        lblCHL2.Visible = True
        lblCHL3.Visible = True
        lblCHL4.Visible = True
        lblCHL5.Visible = True
        lblCHL6.Visible = True
        lblCHL7.Visible = True
        lblCHL8.Visible = True
        lblCHL9.Visible = True
        lblCHL10.Visible = True

    End Sub
    Public maxtemp As Decimal
    Public mintemp As Decimal
    Public delta As Decimal

    Public maxtemp2 As Decimal
    Public mintemp2 As Decimal
    Public delta2 As Decimal

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If ProgressBar1.Value < First_param Then
            ProgressBar1.Value += 1
            lblSec.Text = i & " seconds"
            i += 1

            status = usb_tc08_get_single(usbtc08Handle, tempBuffer(0), overflowFlag, USBTC08TempUnits.USBTC08_UNITS_CENTIGRADE)

            Console.Write("{0:F}", tempBuffer(1).ToString() & vbTab)
            chnl1 = tempBuffer(1).ToString
            temp(x) = chnl1
            x += 1

            Console.Write("{0:F}", tempBuffer(2).ToString() & vbTab)
            chnl2 = tempBuffer(2).ToString
            temp(x) = chnl2
            x += 1


            Console.Write("{0:F}", tempBuffer(3).ToString() & vbTab)
            chnl3 = tempBuffer(3).ToString
            temp(x) = chnl3
            x += 1


            Console.Write("{0:F}", tempBuffer(4).ToString() & vbTab)
            chnl4 = tempBuffer(4).ToString
            temp(x) = chnl4
            x += 1


            Console.Write("{0:F}", tempBuffer(5).ToString() & vbTab)
            chnl5 = tempBuffer(5).ToString
            temp(x) = chnl5
            x += 1
            'Console.WriteLine()
            sleep()
            'System.Threading.Thread.Sleep(1000)

        Else
            Timer1.Enabled = False
            Timer1.Enabled = False
            ProgressBar1.Value = 0
            ProgressBar1.Visible = False
            'lblReady.Visible = True
            btnStart.Enabled = False
            lblSec.Visible = False
            'lblSec2.Visible = False
            'btnExport.Enabled = True


            Dim vals As Decimal() = {lblCHL1.Text, lblCHL2.Text, lblCHL3.Text, lblCHL4.Text, lblCHL5.Text}
            Dim largest As Decimal = Decimal.MinValue
            Dim smallest As Decimal = Decimal.MaxValue

            For Each element As Decimal In vals
                largest = Math.Max(largest, element)
                smallest = Math.Min(smallest, element)
            Next

            Console.WriteLine(largest)
            Console.WriteLine(smallest)
            delta = largest - smallest

            Getparam2()
            If Second_param = 0 Then
                lblReady.Visible = True
                btnStart.Enabled = False
                lblSec.Visible = False
                lblSec2.Visible = False
                btnExport.Enabled = True
                ProgressBar2.Visible = False
            Else
                ProgressBar2.Maximum = Second_param
                If i < Second_param Then
                    i = 1
                End If
                Timer2.Enabled = True
            End If

        End If


    End Sub


    '\\btwebdev01\Websites\WindowsAppUpdater\TSG_Shared\NANO Selas Temp

    'C:\Users\gcatapang\OneDrive - Littelfuse, Inc\Desktop\Selas
    'C:\Users\gcatapang\OneDrive - Littelfuse, Inc\Desktop\Selas Backup

    '\\lffile001\infinity\Philippines\Buffer File\Nano\Nano Selas temp.csv
    '\\lffile001\infinity\Philippines\Nano Log 

    Public dateNtime As String = DateTime.Now.ToString("yyyy_MM_dd_HHmmtt ")

    Public get_FolderPath As String = "\\lffile001\infinity\Philippines\Buffer File\Nano\Nano Selas temp.csv"
    'Public get_FolderPath2 As String = "\\lffile001\infinity\Philippines\Nano Log\" & dateNtime & "Nano Selas temp.csv"
    Public get_FolderPath2 As String = "\\lffile001\infinity\Philippines\Nano Log\Nano Selas temp.csv"
    Public get_message As String
    Public get_message2 As String
    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click

        get_message2 = """Process,""" & "," & """Part number,""" & "," & """Lot number,""" & "," & """Associate,""" & "," & """Selas Temperature1,""" & "," & """Selas Temperature2,""" & "," & """Delta Result,""" & "," & """Delta2 Result,""" & "," & """Date and Time,""" & vbCrLf

        Dim isFileEmpty As Boolean = IsCSVFileEmpty(get_FolderPath)

        Try
            If isFileEmpty Then

                For n As Integer = 0 To temp_data.Length - 1
                        If temp_data(n) > 0 Then
                            get_message = get_message & cboProcess.Text & "," & cboPartNo.Text & "," & tbLotNum.Text & "," & cboAssociate.Text & "," & temp_data(n) & "," & temp_data2(n) & "," & delta & "," & delta2 & vbCrLf
                            get_message2 = get_message2 & cboProcess.Text & "," & cboPartNo.Text & "," & tbLotNum.Text & "," & cboAssociate.Text & "," & temp_data(n) & "," & temp_data2(n) & "," & delta & "," & delta2 & "," & dateNtime & vbCrLf
                        End If
                    Next
                    My.Computer.FileSystem.WriteAllText(get_FolderPath, get_message, False)
                    My.Computer.FileSystem.WriteAllText(get_FolderPath2, get_message2, True)
                    MessageBox.Show("The data is saved in " & get_FolderPath)
                    lblExit.Visible = True
                    btnStart.Visible = False
                    btnExport.Enabled = False
                btnEnable.Visible = True

                Array.Clear(temp_data, 0, temp_data.Length)
                Array.Clear(temp_data2, 0, temp_data2.Length)

            Else

                MessageBox.Show("Cannot Proceed Saving!!! There is a file for upload at Infinity from recent Profiler. Please add the data In Infinity, then click Export.", "Selas Temperature Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MsgBox(ex, vbCritical)
        End Try


    End Sub

    Private Function IsCSVFileEmpty(filePath As String) As Boolean
        ' Check if the file exists
        If File.Exists(filePath) Then
            ' Read the entire file content as a string
            Dim fileContent As String = File.ReadAllText(filePath)
            ' Check if the file content contains any non-whitespace characters
            Return String.IsNullOrWhiteSpace(fileContent)
        Else
            ' File doesn't exist, so it's considered empty
            Return True
        End If
    End Function


    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        If ProgressBar2.Value < Second_param Then
            ProgressBar2.Value += 1
            lblSec2.Text = i & " seconds"
            i += 1

            status = usb_tc08_get_single(usbtc08Handle, tempBuffer(0), overflowFlag, USBTC08TempUnits.USBTC08_UNITS_CENTIGRADE)

            Console.Write("{0:F}", tempBuffer(1).ToString() & vbTab)
            chnl6 = tempBuffer(1).ToString
            temp(x) = chnl6
            x += 1

            Console.Write("{0:F}", tempBuffer(2).ToString() & vbTab)
            chnl7 = tempBuffer(2).ToString
            temp(x) = chnl7
            x += 1


            Console.Write("{0:F}", tempBuffer(3).ToString() & vbTab)
            chnl8 = tempBuffer(3).ToString
            temp(x) = chnl8
            x += 1


            Console.Write("{0:F}", tempBuffer(4).ToString() & vbTab)
            chnl9 = tempBuffer(4).ToString
            temp(x) = chnl9
            x += 1


            Console.Write("{0:F}", tempBuffer(5).ToString() & vbTab)
            chnl10 = tempBuffer(5).ToString
            temp(x) = chnl10
            x += 1
            Console.WriteLine()
            sleep()
            'System.Threading.Thread.Sleep(1000)

        Else
            Timer2.Enabled = False
            Timer2.Enabled = False
            ProgressBar2.Value = 0
            ProgressBar2.Visible = False
            lblReady.Visible = True
            btnStart.Enabled = False
            lblSec.Visible = False
            lblSec2.Visible = False
            btnExport.Enabled = True



            Dim vals2 As Decimal() = {lblCHL6.Text, lblCHL7.Text, lblCHL8.Text, lblCHL9.Text, lblCHL10.Text}
            Dim largest2 As Decimal = Decimal.MinValue
            Dim smallest2 As Decimal = Decimal.MaxValue

            For Each element As Decimal In vals2
                largest2 = Math.Max(largest2, element)
                smallest2 = Math.Min(smallest2, element)
            Next

            Console.WriteLine(largest2)
            Console.WriteLine(smallest2)
            delta2 = largest2 - smallest2

        End If

    End Sub


    Private Sub AddAssociateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddAssociateToolStripMenuItem.Click
        Add_Form.Show()
        Me.Hide()
    End Sub

    Private Sub AddProcessToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddProcessToolStripMenuItem.Click
        Add_Process.Show()
        Me.Hide()
    End Sub

    Private Sub AddPartNumberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddPartNumberToolStripMenuItem.Click
        Add_PartNumber.Show()
        Me.Hide()
    End Sub

    Private Sub cboPartNo_KeyUp(sender As Object, e As KeyEventArgs) Handles cboPartNo.KeyUp
        If e.KeyCode = Keys.Enter Then
            If cboPartNo.Items.Contains(cboPartNo.Text) Then
                tbLotNum.Focus()
            Else
                MsgBox("Part number doesn't exist in the database.")
                cboPartNo.Text = ""
            End If
        End If
    End Sub


    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        status = usb_tc08_get_single(usbtc08Handle, tempBuffer(0), overflowFlag, USBTC08TempUnits.USBTC08_UNITS_CENTIGRADE)

        Console.Write("{0:F}", tempBuffer(1).ToString() & vbTab)
        chnl1 = tempBuffer(1).ToString
        temp(x) = chnl1

        'chnl6 = tempBuffer(1).ToString
        'temp(x) = chnl6
        x += 1

        Console.Write("{0:F}", tempBuffer(2).ToString() & vbTab)
        chnl2 = tempBuffer(2).ToString
        temp(x) = chnl2

        'chnl7 = tempBuffer(2).ToString
        'temp(x) = chnl7
        x += 1


        Console.Write("{0:F}", tempBuffer(3).ToString() & vbTab)
        chnl3 = tempBuffer(3).ToString
        temp(x) = chnl3

        'chnl8 = tempBuffer(3).ToString
        'temp(x) = chnl8
        x += 1


        Console.Write("{0:F}", tempBuffer(4).ToString() & vbTab)
        chnl4 = tempBuffer(4).ToString
        temp(x) = chnl4

        'chnl9 = tempBuffer(4).ToString
        'temp(x) = chnl9
        x += 1


        Console.Write("{0:F}", tempBuffer(5).ToString() & vbTab)
        chnl5 = tempBuffer(5).ToString
        temp(x) = chnl5

        'chnl10 = tempBuffer(5).ToString
        'temp(x) = chnl10
        x += 1

        sleep()
    End Sub

    Private Sub tbLotNum_KeyUp(sender As Object, e As KeyEventArgs) Handles tbLotNum.KeyUp
        If e.KeyCode = Keys.Enter Then
            cboAssociate.Focus()
        End If
    End Sub

    Private Sub btnEnable_Click(sender As Object, e As EventArgs) Handles btnEnable.Click
        btnExport.Enabled = True
        btnEnable.Visible = False
    End Sub
End Class
