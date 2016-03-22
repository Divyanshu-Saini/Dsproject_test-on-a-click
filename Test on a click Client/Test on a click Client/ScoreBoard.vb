Public Class ScoreBoard

    Private Sub ScoreBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSProjectDataSet.Test_Result_tbl' table. You can move, or remove it, as needed.
        Me.Test_Result_tblTableAdapter.Fill(Me.DSProjectDataSet.Test_Result_tbl)

    End Sub
End Class