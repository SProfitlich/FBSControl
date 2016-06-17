
Public Class FrmFBS

    Public Sub New()
        MyBase.New()
    End Sub

    Public Function EineZeichenkette() As String
        EineZeichenkette = "http://www.stuertz.com"
    End Function

    Private Sub Anzeige()
        If (Opt0.Checked) Then
            FBSControl.RotateFlipSize(FBS_Element.FBSControl.enumRotate.rotate0, chkGespiegelt.Checked, Val(txtSize.Text))
        End If
        If (Opt90.Checked) Then
            FBSControl.RotateFlipSize(FBS_Element.FBSControl.enumRotate.rotate90, chkGespiegelt.Checked, Val(txtSize.Text))
        End If
        If (Opt180.Checked) Then
            FBSControl.RotateFlipSize(FBS_Element.FBSControl.enumRotate.rotate180, chkGespiegelt.Checked, Val(txtSize.Text))
        End If
        If (Opt270.Checked) Then
            FBSControl.RotateFlipSize(FBS_Element.FBSControl.enumRotate.rotate270, chkGespiegelt.Checked, Val(txtSize.Text))
        End If
    End Sub

    Private Sub chkGespiegelt_Click(sender As System.Object, e As System.EventArgs) Handles chkGespiegelt.Click
        Call Anzeige()
    End Sub

    Private Sub Opt0_Click(sender As System.Object, e As System.EventArgs) Handles Opt0.Click
        Call Anzeige()
    End Sub

    Private Sub Opt90_Click(sender As System.Object, e As System.EventArgs) Handles Opt90.Click
        Call Anzeige()
    End Sub

    Private Sub Opt180_Click(sender As System.Object, e As System.EventArgs) Handles Opt180.Click
        Call Anzeige()
    End Sub

    Private Sub Opt270_Click(sender As System.Object, e As System.EventArgs) Handles Opt270.Click
        Call Anzeige()
    End Sub

    Private Sub FrmFBS_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        FBSControl.LoadBitmap("d:\Daten\0FalzGetriebe_K1.bmp")
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Call FBSControl.SaveBitmap(txtFileName.Text)
    End Sub

    Private Sub btnLoad_Click(sender As System.Object, e As System.EventArgs) Handles btnLoad.Click
        FBSControl.LoadBitmap(txtFileName.Text)
    End Sub
End Class
