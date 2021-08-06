using DevExpress.XtraEditors;
using System;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ReadyCarCalculate.Backend
{

    class CustomUtil
        {
        /** 
         * This function takes filename as the path of the CSV file and load its context into a data table.
         * The second parameter is the list of numeric columns in each file
         * The first row of the CSV file is treated as headers.
         **/

        public static DataTable ConvertCSVtoDataTable(string strFilePath)
        {
            //reading all the lines(rows) from the file.
            string[] rows = File.ReadAllLines(strFilePath);

            DataTable dtData = new DataTable();
            string[] rowValues = null;
            DataRow dr = dtData.NewRow();

            //Creating columns
            if (rows.Length > 0)
            {
                foreach (string columnName in rows[0].Split(','))
                    dtData.Columns.Add(columnName);
            }

            //Creating row for each line.(except the first line, which contain column names)
            for (int row = 1; row < rows.Length; row++)
            {
                rowValues = rows[row].Split(',');
                dr = dtData.NewRow();
                dr.ItemArray = rowValues;
                dtData.Rows.Add(dr);
            }

            return dtData;
        }
        public static DataTable LoadCsvToDataTable(String filename, int[] numericlist = null)
            {
                DataTable dataDable = new DataTable();
                if (File.Exists(filename))
                {
                    try
                    {
                        StreamReader tmpstream = File.OpenText(filename);

                        string[] strlines;
                        var columnsSet = 0;
                        var dc = new DataColumn();
                        var invalid_dc = new DataColumn();

                        while (!tmpstream.EndOfStream)
                        {
                            var strIndex = 0;
                            strlines = Regex.Split(tmpstream.ReadLine(), ",(?=(?:[^\"]* \"[^\"]*\")*[^\"]*$)");

                            DataRow aRow = dataDable.NewRow();

                            // Init column headers
                            if (columnsSet == 0)
                            {
                                while (strIndex != strlines.Length)
                                {
                                    dc = new DataColumn(strlines[strIndex]);
                                    invalid_dc = new DataColumn(strlines[strIndex]);

                                    // prevent duplicate columns
                                    try
                                    {
                                        dataDable.Columns.Add(dc);
                                    }
                                    catch (System.Data.DuplicateNameException)
                                    {
                                        XtraMessageBox.Show("The file contains duplicate columns.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                        return dataDable;
                                    }


                                    strIndex++;
                                }

                                if (numericlist != null)
                                {
                                    foreach (int i in numericlist)
                                    {
                                        dataDable.Columns.Remove(dataDable.Columns[i]);
                                        dataDable.Columns.Add(strlines[i], typeof(int)).SetOrdinal(i);

                                    }
                                }

                                columnsSet = 1;
                            }
                            else
                            {
                                // Append records
                                int x = 0;
                                while (strIndex != strlines.Length)
                                {
                                    if ((numericlist != null) && (x < numericlist.Length) && (strIndex == numericlist[x]))
                                    {
                                        if ((strlines[strIndex] != ""))
                                        {
                                            aRow[strIndex] = float.Parse(strlines[strIndex].Substring(1));
                                        }
                                        x++;
                                    }
                                    else
                                    {
                                        aRow[strIndex] = strlines[strIndex];
                                    }
                                    strIndex++;
                                }

                                dataDable.Rows.Add(aRow);
                            }
                        }
                        tmpstream.Close();
                        return dataDable;
                    }
                    catch (System.IO.IOException)
                    {
                        XtraMessageBox.Show("The file is opened. Please close it.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return dataDable;
                    }
                }
                else
                {
                    XtraMessageBox.Show("File path not valid.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return dataDable;
                }
            }

            /// <summary>
            /// Function to append CSV files together.
            /// </summary>
            /// <remarks>
            /// Total file size of any individual file (including output) is limited by host file system, around 4GB is a standard
            /// maximum. All paths must point to lettered drives.
            /// </remarks>
            /// <param name="inFiles">An array of strings representing the full paths to the CSV files to be combined.</param>
            /// <param name="outFile">A string representing the full path the the destination for the combined CSV.</param>
            public static void CombineCSVs(string[] inFiles, string outFile)
            {
                using (FileStream dest = new FileStream(outFile, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    foreach (string file in inFiles)
                    {
                        using (FileStream src = new FileStream(file, FileMode.Open, FileAccess.Read))
                        {
                            src.CopyTo(dest);
                        }
                    }
                }
            }

        }
    
}
