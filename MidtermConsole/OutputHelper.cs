﻿using CsvHelper;
using Midterm.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using Midterm;

namespace MidtermConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var b = MidtermFunctions.GetAllBooks();
            var oh = new OutputHelper();
            //oh.WriteToCSV(b);
            oh.WriteToConsole(b);

        }
    }
    class OutputHelper
    {
        public void WriteToConsole(List<Books> books)
        {
            Console.WriteLine("List of Books");
            foreach(var b in books)
            {
                Console.WriteLine($"BookID: {b.BookId}      Title:{b.BookTitle}     Release:Year:{b.YearOfRelease}");
            }
        }

        public void WriteToCSV(List<Books> books)
        {
            using (var writer = new StreamWriter("path\\to\\file.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(books);
            }
        }
        

    }
}
