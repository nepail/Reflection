// See https://aka.ms/new-console-template for more information
using SqlServerDB;
using System.Reflection;

// method 1 在執行目錄下(not working)
//Assembly assembly1 = Assembly.Load("SqlServerDB");

// method 2 專案加入引用

// method 3 完整路徑
//Assembly assembly2 = Assembly.LoadFile(@"C:\Users\jim\source\repos\Reflection\SqlServerDB\bin\Debug\net6.0\SqlServerDB.dll");

// method 4 建議
//Assembly assembly3 = Assembly.LoadFrom(@"C:\Users\jim\source\repos\Reflection\SqlServerDB\bin\Debug\net6.0\SqlServerDB.dll");
Assembly assembly3 = Assembly.LoadFrom(@"SqlServerDB.dll");

//-----------------------------------------------------------------------------------------------------------------------------------//

// 取得類型
Type type = assembly3.GetType("SqlServerDB.ReflectionTest");

// 靜態實例化
//ReflectionTest reflectionTest = new ReflectionTest();
// 動態實例化
// method 1 無參數方法呼叫
//object objTest1 = Activator.CreateInstance(type);

// method 2 有參數方法呼叫
//object objTest1 = Activator.CreateInstance(type, new object[] {"123"});

// method 3 私有呼叫
object objTest2 = Activator.CreateInstance(type, true);

Console.Read();


