'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Cells. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Cells
Imports Aspose.Cells.Rendering

Namespace ExtractImagesFromWorksheetsExample
	Public Class Program
		Public Shared Sub Main()
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'Open a template Excel file
			Dim workbook As New Workbook(dataDir & "book1.xls")
			'Get the first worksheet
			Dim worksheet As Worksheet = workbook.Worksheets(0)
			'Get the first Picture in the first worksheet
			Dim pic As Aspose.Cells.Drawing.Picture = worksheet.Pictures(0)
			'Set the output image file path
			Dim fileName As String = dataDir & "aspose-logo.Jpg"
			Dim picformat As String = pic.ImageFormat.ToString()
			'Note: you may evaluate the image format before specifying the image path

			'Define ImageOrPrintOptions
			Dim printoption As New ImageOrPrintOptions()
			'Specify the image format
			printoption.ImageFormat = System.Drawing.Imaging.ImageFormat.Jpeg
			'Save the image
			pic.ToImage(fileName, printoption)


		End Sub
	End Class
End Namespace