<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ElementsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.settingColor = New System.Windows.Forms.ToolStripMenuItem()
        Me.GreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurpleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblBlueScore = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblOrangeScore = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'BackgroundWorker1
        '
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ElementsToolStripMenuItem, Me.settingColor})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(497, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ElementsToolStripMenuItem
        '
        Me.ElementsToolStripMenuItem.Name = "ElementsToolStripMenuItem"
        Me.ElementsToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.ElementsToolStripMenuItem.Text = "Elements"
        '
        'settingColor
        '
        Me.settingColor.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GreenToolStripMenuItem, Me.BlueToolStripMenuItem, Me.PurpleToolStripMenuItem})
        Me.settingColor.Name = "settingColor"
        Me.settingColor.Size = New System.Drawing.Size(116, 20)
        Me.settingColor.Text = "Chroma Key Color"
        '
        'GreenToolStripMenuItem
        '
        Me.GreenToolStripMenuItem.Name = "GreenToolStripMenuItem"
        Me.GreenToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.GreenToolStripMenuItem.Text = "Green"
        '
        'BlueToolStripMenuItem
        '
        Me.BlueToolStripMenuItem.Name = "BlueToolStripMenuItem"
        Me.BlueToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.BlueToolStripMenuItem.Text = "Blue"
        '
        'PurpleToolStripMenuItem
        '
        Me.PurpleToolStripMenuItem.Name = "PurpleToolStripMenuItem"
        Me.PurpleToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.PurpleToolStripMenuItem.Text = "Pink"
        '
        'lblBlueScore
        '
        Me.lblBlueScore.AutoSize = True
        Me.lblBlueScore.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblBlueScore.Font = New System.Drawing.Font("BigNoodleTitling", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBlueScore.Location = New System.Drawing.Point(0, 0)
        Me.lblBlueScore.Name = "lblBlueScore"
        Me.lblBlueScore.Size = New System.Drawing.Size(54, 70)
        Me.lblBlueScore.TabIndex = 2
        Me.lblBlueScore.Text = "4"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(379, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Blue Score:"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblBlueScore)
        Me.Panel1.Location = New System.Drawing.Point(365, 51)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(98, 98)
        Me.Panel1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Orange Score:"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblOrangeScore)
        Me.Panel2.Location = New System.Drawing.Point(27, 51)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(98, 98)
        Me.Panel2.TabIndex = 4
        '
        'lblOrangeScore
        '
        Me.lblOrangeScore.AutoSize = True
        Me.lblOrangeScore.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblOrangeScore.Font = New System.Drawing.Font("BigNoodleTitling", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrangeScore.Location = New System.Drawing.Point(40, 0)
        Me.lblOrangeScore.Name = "lblOrangeScore"
        Me.lblOrangeScore.Size = New System.Drawing.Size(56, 70)
        Me.lblOrangeScore.TabIndex = 2
        Me.lblOrangeScore.Text = "0"
        Me.lblOrangeScore.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(203, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Timer:"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lblTimer)
        Me.Panel3.Location = New System.Drawing.Point(141, 52)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(208, 98)
        Me.Panel3.TabIndex = 5
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTimer.Font = New System.Drawing.Font("BigNoodleTitling", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.Location = New System.Drawing.Point(0, 0)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(204, 70)
        Me.lblTimer.TabIndex = 2
        Me.lblTimer.Text = "04:33.00"
        Me.lblTimer.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ColorDialog1
        '
        Me.ColorDialog1.AnyColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.ClientSize = New System.Drawing.Size(497, 170)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Echo Overlay"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents settingColor As ToolStripMenuItem
    Friend WithEvents GreenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BlueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PurpleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblBlueScore As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblOrangeScore As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblTimer As Label
    Friend WithEvents ElementsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColorDialog1 As ColorDialog
End Class
