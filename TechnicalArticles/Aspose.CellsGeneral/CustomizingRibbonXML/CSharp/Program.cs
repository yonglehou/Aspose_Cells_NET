//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Cells. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Cells;

namespace CustomizingRibbonXML
{
    public class Program
    {
        public static void Main()
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            Workbook wb = new Workbook(dataDir+ "aspose-sample.xlsx");
            FileInfo fi = new FileInfo(dataDir+ "CustomUI.xml");
            StreamReader sr = fi.OpenText();
            wb.RibbonXml = sr.ReadToEnd();
            sr.Close();
            
            
        }
    }
}