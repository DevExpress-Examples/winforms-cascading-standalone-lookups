Namespace Lookup_Cascading
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.lookUpEdit1 = New DevExpress.XtraEditors.LookUpEdit()
            Me.lookUpEdit2 = New DevExpress.XtraEditors.LookUpEdit()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
            CType(Me.lookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'lookUpEdit1
            '
            Me.lookUpEdit1.Location = New System.Drawing.Point(10, 38)
            Me.lookUpEdit1.Name = "lookUpEdit1"
            Me.lookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.lookUpEdit1.Size = New System.Drawing.Size(153, 20)
            Me.lookUpEdit1.TabIndex = 0
            '
            'lookUpEdit2
            '
            Me.lookUpEdit2.Location = New System.Drawing.Point(299, 38)
            Me.lookUpEdit2.Name = "lookUpEdit2"
            Me.lookUpEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.lookUpEdit2.Size = New System.Drawing.Size(157, 20)
            Me.lookUpEdit2.TabIndex = 1
            '
            'labelControl1
            '
            Me.labelControl1.Location = New System.Drawing.Point(10, 19)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(63, 13)
            Me.labelControl1.TabIndex = 2
            Me.labelControl1.Text = "labelControl1"
            '
            'timer1
            '
            Me.timer1.Enabled = True
            '
            'labelControl2
            '
            Me.labelControl2.Location = New System.Drawing.Point(299, 19)
            Me.labelControl2.Name = "labelControl2"
            Me.labelControl2.Size = New System.Drawing.Size(63, 13)
            Me.labelControl2.TabIndex = 3
            Me.labelControl2.Text = "labelControl2"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(621, 264)
            Me.Controls.Add(Me.labelControl2)
            Me.Controls.Add(Me.labelControl1)
            Me.Controls.Add(Me.lookUpEdit2)
            Me.Controls.Add(Me.lookUpEdit1)
            Me.Name = "Form1"
            Me.Text = "Cascading Lookups"
            CType(Me.lookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private WithEvents lookUpEdit1 As DevExpress.XtraEditors.LookUpEdit
        Private lookUpEdit2 As DevExpress.XtraEditors.LookUpEdit
        Private labelControl1 As DevExpress.XtraEditors.LabelControl
        Private WithEvents timer1 As System.Windows.Forms.Timer
        Private labelControl2 As DevExpress.XtraEditors.LabelControl
    End Class
End Namespace

