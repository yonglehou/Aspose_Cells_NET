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

Namespace SettingStrongEncryptionTypeExample
	Public Class Program
		Public Shared Sub Main()
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'Instantiate a Workbook object.
			'Open an excel file.
			Dim workbook As New Workbook(dataDir & "Book1.xlsx")

			'Specify Strong Encryption type (RC4,Microsoft Strong Cryptographic Provider).
			workbook.SetEncryptionOptions(EncryptionType.StrongCryptographicProvider, 128)

			'Password protect the file.
			workbook.Settings.Password = "1234"

			'Save the Excel file.
			workbook.Save(dataDir & "encryptedBook1.xls")
		End Sub
	End Class
End Namespace