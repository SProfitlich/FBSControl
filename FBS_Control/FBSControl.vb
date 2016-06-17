Public Class FBSControl

    Public Enum enumRotate
        rotate0
        rotate90
        rotate180
        rotate270
    End Enum

    Dim OrgBitmap As Bitmap

    Public Sub LoadBitmap(aFileName As String)
        Try
            OrgBitmap = CType(Bitmap.FromFile(aFileName), Bitmap)
            PictureBox1.Height = OrgBitmap.Height
            PictureBox1.Width = OrgBitmap.Width
            ''PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
            PictureBox1.Image = OrgBitmap
        Catch ex As System.IO.FileNotFoundException
            MessageBox.Show(aFileName & " nicht gefunden !")
        End Try
    End Sub

    Public Sub SaveBitmap(aFileName As String)
        PictureBox1.Image.Save(aFileName, System.Drawing.Imaging.ImageFormat.Bmp)
    End Sub

    Public Sub RotateFlipSize(aRotate As enumRotate, aFlip As Boolean, Optional ByVal aSize As Double = 1.0)
        Dim rotateFlipType As RotateFlipType

        ' Init 
        rotateFlipType = rotateFlipType.RotateNoneFlipNone

        If aFlip Then
            If aRotate = enumRotate.rotate0 Then
                rotateFlipType = rotateFlipType.RotateNoneFlipX
            End If
            If aRotate = enumRotate.rotate90 Then
                rotateFlipType = rotateFlipType.Rotate90FlipY
            End If
            If aRotate = enumRotate.rotate180 Then
                rotateFlipType = rotateFlipType.Rotate180FlipX
            End If
            If aRotate = enumRotate.rotate270 Then
                rotateFlipType = rotateFlipType.Rotate270FlipY
            End If
        Else
            If aRotate = enumRotate.rotate0 Then
                rotateFlipType = rotateFlipType.RotateNoneFlipNone
            End If
            If aRotate = enumRotate.rotate90 Then
                rotateFlipType = rotateFlipType.Rotate90FlipNone
            End If
            If aRotate = enumRotate.rotate180 Then
                rotateFlipType = rotateFlipType.Rotate180FlipNone
            End If
            If aRotate = enumRotate.rotate270 Then
                rotateFlipType = rotateFlipType.Rotate270FlipNone
            End If
        End If
        Anzeige(rotateFlipType, aSize)
    End Sub

    Private Sub Anzeige(aRotateFlipType As RotateFlipType, aSize As Double)
        Dim RotaryBitmap As Bitmap

        If OrgBitmap IsNot Nothing Then
            RotaryBitmap = OrgBitmap.Clone
            RotaryBitmap.RotateFlip(aRotateFlipType)
            If aRotateFlipType = RotateFlipType.RotateNoneFlipNone Or
                aRotateFlipType = RotateFlipType.Rotate180FlipNone Or
                aRotateFlipType = RotateFlipType.RotateNoneFlipX Or
                aRotateFlipType = RotateFlipType.Rotate180FlipX Then

                PictureBox1.Height = OrgBitmap.Height
                PictureBox1.Width = OrgBitmap.Width * aSize
            End If
            If aRotateFlipType = RotateFlipType.Rotate90FlipNone Or
                aRotateFlipType = RotateFlipType.Rotate270FlipNone Or
                aRotateFlipType = RotateFlipType.Rotate90FlipY Or
                aRotateFlipType = RotateFlipType.Rotate270FlipY Then

                PictureBox1.Height = OrgBitmap.Width * aSize
                PictureBox1.Width = OrgBitmap.Height
            End If
            PictureBox1.Image = RotaryBitmap
            PictureBox1.Refresh()
        End If
    End Sub
End Class

