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
Imports System.Drawing

Namespace AddingButtonControl
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			' Create directory if it is not already present.
			Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
			If (Not IsExists) Then
				System.IO.Directory.CreateDirectory(dataDir)
			End If

			'Create a new Workbook.
			Dim workbook As New Workbook()

			'Get the first worksheet in the workbook.
			Dim sheet As Worksheet = workbook.Worksheets(0)

			'Add a new button to the worksheet.
			Dim button As Aspose.Cells.Drawing.Button = sheet.Shapes.AddButton(2, 0, 2, 0, 28, 80)

			'Set the caption of the button.
			button.Text = "Aspose"

			'Set the Placement Type, the way the
			'button is attached to the cells.
			button.Placement = PlacementType.FreeFloating

			'Set the font name.
			button.Font.Name = "Tahoma"

			'Set the caption string bold.
			button.Font.IsBold = True

			'Set the color to blue.
			button.Font.Color = Color.Blue

			'Set the hyperlink for the button.
			button.AddHyperlink("http://www.aspose.com/")

			'Saves the file.
			workbook.Save(dataDir & "book1.xls")

		End Sub
	End Class
End Namespace