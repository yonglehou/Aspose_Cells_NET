//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Cells. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Cells;

namespace UsePresentationPreferenceOptionExample
{
    public class Program
    {
        public static void Main()
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");
            //Instantiate the Workbook
            //Load an Excel file
            Workbook workbook = new Workbook(dataDir+ "sample.xlsx");

            //Create HtmlSaveOptions object
            HtmlSaveOptions options = new HtmlSaveOptions();
            //Set the Presenation preference option
            options.PresentationPreference = true;

            //Save the Excel file to HTML with specified option
            workbook.Save(dataDir+ "outPresentationlayout1.html", options);
            
            
        }
    }
}