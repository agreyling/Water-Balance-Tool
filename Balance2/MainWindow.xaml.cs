using DevExpress.Spreadsheet;
using DevExpress.Xpf.Core;
using System;
using System.Windows;

namespace Balance2;

public partial class MainWindow : ThemedWindow
{
    //--- window, constructor & loaded
    public MainWindow()
    {
        InitializeComponent();
        SpreadsheetPath = "..\\..\\..\\Resources\\WBT data.xlsx";
    }

    private void MainWindow1_Loaded(object sender, System.Windows.RoutedEventArgs e)
    {
        LoadSpreadsheet(SpreadsheetPath);
        SetActiveSheet("Model");
    }

    //--- fields
    private string SpreadsheetPath;

    //--- TreeView
    private void OnMouseDown(object sender, RoutedEventArgs e)
    {
        Type tp = MainTree.CurrentItem.GetType();
        if (tp.Equals(typeof(Page)))
        {
            var s = (MainTree.CurrentItem as Page).Name;
            SetActiveSheet(s);
        }
    }

    //--- Spreadsheet
    private void LoadSpreadsheet(string path)
    {
        MainBook.LoadDocument(path);
        var book = MainBook;
        book.Options.View.ShowColumnHeaders = false;
        book.Options.View.ShowRowHeaders = false;
        book.Options.View.ShowPrintArea = false;
        book.Options.View.ShowPlaceholders = false;
        book.Options.View.ShowPrintArea = false;
        book.ShowFormulaBar = false;
        book.ShowTabSelector = false;
        book.ShowStatusBar = false;
    }

    private void SetActiveSheet(string s)
    {
        try { 
            IWorkbook book = MainBook.Document;
            book.Worksheets.ActiveWorksheet = book.Worksheets[s];
        } 
        catch { MessageBox.Show($"Page not found: {s}"); }
    }
}
