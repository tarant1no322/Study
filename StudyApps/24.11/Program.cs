using System.IO;

FileStream file;
string str, str_in, pash = @"C:\Users\UserOne\Desktop\123.txt";

try
{
    file = new FileStream(pash, FileMode.OpenOrCreate);
}
catch(IOException ex)
{
    Console.WriteLine("Возникла ошибка:" + ex.Message);
    return;
}
StreamWriter out_file = new StreamWriter(file);
try
{
    Console.WriteLine("Введи текст, а по завершению -- стоп(stop)");
    do
    {
        Console.Write(": ");
        str = Console.ReadLine();
        if ((str != "стоп") & (str != "stop"))
        {
            str = str + "\r\n"; 
            out_file.Write(str);
        }
    }
    while ((str != "стоп") & (str != "stop"));
}
catch(IOException ex)
{
    Console.WriteLine("Возникла ошибка:" + ex.Message);
}
finally
{
    out_file.Close();
}

//StreamReader fstr_in = new StreamReader(file);
//try
//{
//    while ((str_in = fstr_in.ReadLine()) != null)
//    {
//        Console.WriteLine(str_in);
//    }
//}
//catch(IOException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//finally
//{
//    fstr_in.Close(); 
//}    
    