// See https://aka.ms/new-console-template for more information
using System.Reflection;

Console.WriteLine("Hello, World!");

// method 1 在執行目錄下(not working)
Assembly assembly1 = Assembly.Load("SqlServerDB");

// method 2 專案加入引用

// method 3 完整路徑
Assembly assembly2 = Assembly.LoadFile(@"C:\Users\jim\source\repos\Reflection\SqlServerDB\bin\Debug\net6.0\SqlServerDB.dll");

// method 4 建議
//Assembly assembly3 = Assembly.LoadFrom(@"C:\Users\jim\source\repos\Reflection\SqlServerDB\bin\Debug\net6.0\SqlServerDB.dll");
Assembly assembly3 = Assembly.LoadFrom(@"SqlServerDB.dll");