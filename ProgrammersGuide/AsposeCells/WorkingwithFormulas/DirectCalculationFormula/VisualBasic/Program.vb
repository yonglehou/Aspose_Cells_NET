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

Namespace DirectCalculationFormula
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			' Create directory if it is not already present.
			Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
			If (Not IsExists) Then
				System.IO.Directory.CreateDirectory(dataDir)
			End If

			'Create a workbook
			Dim workbook As New Workbook()

			'Access first worksheet
			Dim worksheet As Worksheet = workbook.Worksheets(0)

			'Put 20 in cell A1
			Dim cellA1 As Cell = worksheet.Cells("A1")
			cellA1.PutValue(20)

			'Put 30 in cell A2
			Dim cellA2 As Cell = worksheet.Cells("A2")
			cellA2.PutValue(30)

			'Calculate the Sum of A1 and A2
			Dim results = worksheet.CalculateFormula("=Sum(A1:A2)")

			'Print the output
			System.Console.WriteLine("Value of A1: " & cellA1.StringValue)
			System.Console.WriteLine("Value of A2: " & cellA2.StringValue)
			System.Console.WriteLine("Result of Sum(A1:A2): " & results.ToString())

		End Sub
	End Class
End Namespace