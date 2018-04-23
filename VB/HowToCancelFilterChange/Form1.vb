Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraPivotGrid

Namespace EmptyWinApp
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Me.productReportsTableAdapter.Fill(Me.productReports._ProductReports)
        End Sub
        Private Sub pivotGridControl1_FieldFilterChanging(ByVal sender As Object, _
                                                          ByVal e As PivotFieldFilterChangingEventArgs) _
                                                      Handles pivotGridControl1.FieldFilterChanging
            If Object.ReferenceEquals(e.Field, fieldCategoryName) Then
                If (e.Field.FilterValues.FilterType = PivotFilterType.Excluded _
                    AndAlso e.Values.Contains("Beverages")) _
                OrElse (e.Field.FilterValues.FilterType = PivotFilterType.Included _
                        AndAlso (Not e.Values.Contains("Beverages"))) Then
                    MessageBox.Show("You are not allowed to hide the 'Beverages' value.")
                    e.Cancel = True
                End If
            End If
        End Sub
    End Class
End Namespace