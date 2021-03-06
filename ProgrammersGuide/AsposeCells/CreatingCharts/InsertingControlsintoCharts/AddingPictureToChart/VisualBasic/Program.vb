'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Cells. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Cells
Imports System.Drawing

Namespace AddingPictureToChart
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'Create a new Workbook.
			'Open the existing file.
			Dim workbook As New Workbook(dataDir & "chart.xls")

			'Get an image file to the stream.
			Dim stream As New FileStream(dataDir & "logo.jpg", FileMode.Open, FileAccess.Read)

			'Get the designer chart in the second sheet.
			Dim sheet As Worksheet = workbook.Worksheets(1)
			Dim chart As Aspose.Cells.Charts.Chart = sheet.Charts(0)

			'Add a new picture to the chart.
			Dim pic0 As Aspose.Cells.Drawing.Picture = chart.Shapes.AddPictureInChart(50, 50, stream, 40, 40)

			'Get the lineformat type of the picture.
			Dim lineformat As Aspose.Cells.Drawing.MsoLineFormat = pic0.LineFormat

			'Set the line color.
			lineformat.ForeColor = Color.Red

			'Set the dash style.
			lineformat.DashStyle = Aspose.Cells.Drawing.MsoLineDashStyle.Solid

			'set the line weight.
			lineformat.Weight = 4

			'Set the line style.
			lineformat.Style = Aspose.Cells.Drawing.MsoLineStyle.ThickThin

			'Save the excel file.
			workbook.Save(dataDir & "chart_out.xls")

		End Sub
	End Class
End Namespace