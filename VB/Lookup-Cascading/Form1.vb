Imports DevExpress.XtraEditors
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace Lookup_Cascading
    Partial Public Class Form1
        Inherits Form

        Public Sub New()

            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Dim categories As New List(Of Category)() From { _
                New Category() With {.Key = 0, .CategoryName = "Beverages"}, _
                New Category() With {.Key = 1, .CategoryName = "Grains"}, _
                New Category() With {.Key = 2, .CategoryName = "Seafood"} _
            }
            lookUpEdit1.Properties.DataSource = categories
            lookUpEdit1.Properties.DisplayMember = "CategoryName"
            lookUpEdit1.Properties.KeyMember = "Key"


            Dim products As New List(Of Product)() From { _
                New Product() With {.ID=0, .ProductName="Chang", .CategoryID = 0}, _
                New Product() With {.ID=1, .ProductName="Ipoh Coffee", .CategoryID = 0}, _
                New Product() With {.ID=2, .ProductName="Ravioli Angelo", .CategoryID = 1}, _
                New Product() With {.ID=3, .ProductName="Filo Mix", .CategoryID = 1}, _
                New Product() With {.ID=4, .ProductName="Tunnbröd", .CategoryID = 1}, _
                New Product() With {.ID=5, .ProductName="Konbu", .CategoryID = 2}, _
                New Product() With {.ID=6, .ProductName="Boston Crab Meat", .CategoryID = 2} _
            }
            lookUpEdit2.Properties.DataSource = products
            lookUpEdit2.Properties.KeyMember = "ID"
            lookUpEdit2.Properties.DisplayMember = "ProductName"
            lookUpEdit2.CascadingOwner = lookUpEdit1
            ' The following line is not required, as lookUpEdit2 automatically identifies a foreign key ("CategoryID") in its data source
            ' by appending the "ID" suffix to primary object's class name ("Category")
            'lookUpEdit2.Properties.CascadingMember = "CategoryID";


        End Sub

        Private Function getObjectString(ByVal obj As Object) As String
            If obj Is Nothing Then
                Return "EditValue: null"
            End If
            Return obj.ToString()
        End Function
        Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles timer1.Tick
            labelControl1.Text = getObjectString(lookUpEdit1.EditValue)
            labelControl2.Text = getObjectString(lookUpEdit2.EditValue)
        End Sub

        Private Sub lookUpEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles lookUpEdit1.EditValueChanged
            lookUpEdit2.EditValue = Nothing

        End Sub
    End Class

    Public Class Category
        Public Property Key() As Integer
        Public Property CategoryName() As String
        Public Overrides Function ToString() As String
            Return "Category object" & " { Key:" & Key & ", CategoryName:" & CategoryName & "}"
        End Function
    End Class

    Public Class Product
        Public Property ID() As Integer
        Public Property CategoryID() As Integer
        Public Property ProductName() As String
        Public Overrides Function ToString() As String
            Return "Product object" & " { CategoryID:" & CategoryID & ", ProductName:" & ProductName & "}"
        End Function
    End Class


End Namespace
