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
Imports Aspose.Cells.Drawing

Namespace AddingLineControl
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			' Create directory if it is not already present.
			Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
			If (Not IsExists) Then
				System.IO.Directory.CreateDirectory(dataDir)
			End If

			'Instantiate a new Workbook.
			Dim workbook As New Workbook()

			'Get the first worksheet in the book.
			Dim worksheet As Worksheet = workbook.Worksheets(0)

			'Add a new line to the worksheet.
			Dim line1 As Aspose.Cells.Drawing.LineShape = worksheet.Shapes.AddLine(5, 0, 1, 0, 0, 250)

			'Set the line dash style
			line1.LineFormat.DashStyle = MsoLineDashStyle.Solid

			'Set the placement.
			line1.Placement = PlacementType.FreeFloating

			'Add another line to the worksheet.
			Dim line2 As Aspose.Cells.Drawing.LineShape = worksheet.Shapes.AddLine(7, 0, 1, 0, 85, 250)

			'Set the line dash style.
			line2.LineFormat.DashStyle = MsoLineDashStyle.DashLongDash

			'Set the weight of the line.
			line2.LineFormat.Weight = 4

			'Set the placement.
			line2.Placement = PlacementType.FreeFloating

			'Add the third line to the worksheet.
			Dim line3 As Aspose.Cells.Drawing.LineShape = worksheet.Shapes.AddLine(13, 0, 1, 0, 0, 250)

			'Set the line dash style
			line3.LineFormat.DashStyle = MsoLineDashStyle.Solid

			'Set the placement.
			line3.Placement = PlacementType.FreeFloating

			'Make the gridlines invisible in the first worksheet.
			workbook.Worksheets(0).IsGridlinesVisible = False

			'Save the excel file.
			workbook.Save(dataDir & "book1.xls")

		End Sub
	End Class
End Namespace