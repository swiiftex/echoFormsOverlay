Imports System.IO
Imports System.Net
Imports System.Web.Script.Serialization
Imports System.Xml
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class Form1

    Dim rawresp As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        BackgroundWorker1.RunWorkerAsync()
        Me.Size = New Size(510, 207)


    End Sub




    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        Do

            Dim request As HttpWebRequest
            Dim response As HttpWebResponse = Nothing
            Dim reader As StreamReader

            request = DirectCast(WebRequest.Create("http://127.0.0.1:6721/session"), HttpWebRequest)

            Try
                response = DirectCast(request.GetResponse(), HttpWebResponse)
                reader = New StreamReader(response.GetResponseStream())
                Me.Invoke(Sub() Me.Text = "Echo Overlay (reading)")
            Catch ex As Exception
                Me.Invoke(Sub() Me.Text = "Echo Overlay (waiting...)")
            End Try



            rawresp = reader.ReadToEnd()


            changeLbl(lblBlueScore, apiRead("blue_points"))
            changeLbl(lblOrangeScore, apiRead("orange_points"))
            changeLbl(lblTimer, apiRead("game_clock_display"))

            If apiRead("game_status") = "score" Then
                Dim index As JObject
                index = apiRead("last_score")
                Dim person As String = index.Item("person_scored")
                Dim distance As Integer = Math.Round(Convert.ToDouble(index.Item("distance_thrown")))
                Dim speed As Integer = Math.Round(Convert.ToDouble(index.Item("disc_speed")))

                Dim s As String
                s = person & " scored from " & distance & "m at " & speed & "m/s"
                writeToFile("ScoreText.txt", s)

            End If

        Loop
    End Sub

    Private Sub changeLbl(labelname As Label, item As String)

        If lblBlueScore.InvokeRequired Then
            labelname.Invoke(Sub() labelname.Text = item)
        Else
            labelname.Text = item
        End If

    End Sub

    Private Function apiRead(item As String)
        Dim jsonResulttodict = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(rawresp)
        Dim firstItem = jsonResulttodict.Item(item)
        Return firstItem
    End Function

    Private Sub writeToFile(filename As String, content As String)
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(filename, False)
        file.WriteLine(content)
        file.Close()
    End Sub

    Private Sub GreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreenToolStripMenuItem.Click
        Me.BackColor = Color.Lime
    End Sub

    Private Sub BlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlueToolStripMenuItem.Click
        Me.BackColor = Color.DarkBlue
    End Sub

    Private Sub PurpleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurpleToolStripMenuItem.Click
        Me.BackColor = Color.HotPink
    End Sub

    Private Sub lblOrangeScore_Click(sender As Object, e As EventArgs) Handles lblOrangeScore.Click
        ColorDialog1.ShowDialog()
        lblOrangeScore.ForeColor = ColorDialog1.Color
    End Sub
    Private Sub lblBlueScore_Click(sender As Object, e As EventArgs) Handles lblBlueScore.Click
        ColorDialog1.ShowDialog()
        lblBlueScore.ForeColor = ColorDialog1.Color
    End Sub

    Private Sub lblTimer_Click(sender As Object, e As EventArgs) Handles lblTimer.Click
        ColorDialog1.ShowDialog()
        lblTimer.ForeColor = ColorDialog1.Color
    End Sub
End Class
