﻿Public Class Form1

    Private Sub btnGenerateThumbnails_Click(sender As Object, e As EventArgs) Handles btnGenerateThumbnails.Click
        GenerateThumbnailsForFolder.Show()
    End Sub

    Private Sub btnWebcamFeed_Click(sender As Object, e As EventArgs) Handles btnWebcamFeed.Click
        WebcamFeed.Show()
    End Sub

    Private Sub btnJSONEditor_Click(sender As Object, e As EventArgs) Handles btnJSONEditor.Click
        JSONEditor.Show()
    End Sub

    Private Sub btnLoadWebContent_Click(sender As Object, e As EventArgs) Handles btnLoadWebContent.Click
        WebContent.Show()
    End Sub

    Private Sub btnLoadWebContentText_Click(sender As Object, e As EventArgs) Handles btnLoadWebContentText.Click
        WebContentText.Show()
    End Sub

    Private Sub btnPlotEquation_Click(sender As Object, e As EventArgs) Handles btnPlotEquation.Click
        PlotEquation.Show()
    End Sub

    Private Sub btnDBAccess_Click(sender As Object, e As EventArgs) Handles btnDBAccess.Click
        DBAccess.Show()
    End Sub

    Private Sub btnRichTextBox_Click(sender As Object, e As EventArgs) Handles btnRichTextBox.Click
        RichTextBoxSamples.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GetPixelExamples.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ScreenCapture.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ChatForm.Show()
    End Sub

    Private Sub btnTrayIcon_Click(sender As Object, e As EventArgs) Handles btnTrayIcon.Click
        TrayIconForm.Show()
    End Sub

    Private Sub btnNetVersion_Click(sender As Object, e As EventArgs) Handles btnNetVersion.Click
        NetVersion.Show()
    End Sub

    Private Sub btnAutocorrectText_Click(sender As Object, e As EventArgs) Handles btnAutocorrectText.Click
        AutocorrectForm.Show()
    End Sub

    Private Sub btnAdvancedTextBox_Click(sender As Object, e As EventArgs) Handles btnAdvancedTextBox.Click
        AdvancedTextBoxTest.Show()
    End Sub

    Private Sub ButtonTextBoxWithSymbols_Click(sender As Object, e As EventArgs) Handles ButtonTextBoxWithSymbols.Click
        FormTextBoxWithSymbols.Show()
    End Sub
End Class
