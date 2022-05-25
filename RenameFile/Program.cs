// See https://aka.ms/new-console-template for more information


internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("请输入文件夹路径");
        String dirPath = Console.ReadLine();

        DirectoryInfo dir = new DirectoryInfo(dirPath);
        foreach(FileInfo file in dir.GetFiles())
        {
            String fileName0 = file.Name;
            
            if (fileName0.Contains("_"))
            {
               String  fileName1 = fileName0.Remove(fileName0.IndexOf("_")) + "." + fileName0.Substring(fileName0.IndexOf("_")+1);
 //            Console.WriteLine(fileName1);

               file.MoveTo(dirPath + "//" + fileName1);
                Console.WriteLine(fileName0 + "已完成");
            }

            

        }
    }
}

