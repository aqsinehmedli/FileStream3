
void Show()
{
    Console.WriteLine("1.Create Folder");
    Console.WriteLine("2.Show Directory");
    Console.WriteLine("3.Delete Folder");
    Console.WriteLine("4.Create File");
    Console.WriteLine("5.Delete File");
    Console.WriteLine("6.Move Folder");
    Console.WriteLine("7.Search File");
    Console.WriteLine("8.Show File");
}
void CreateFolder(string FolderName)
{
    Directory.CreateDirectory("C:\\Users\\Ahmed_hb29\\Desktop\\" + FolderName);
}

void showDirectory()
{
    DirectoryInfo directoryInfo = new($"C:\\Users\\Ahmed_hb29\\Desktop");

    foreach (DirectoryInfo dir in directoryInfo.GetDirectories())
    {
        Console.WriteLine("Folder: " + dir.Name);
    }
}
void deleteFolder()
{
    Directory.Delete("C:\\Users\\Ahmed_hb29\\Desktop\\Folder5");
}
void createFile()
{
    File.WriteAllText("demo.txt", "Hello World");
}
void deleteFile()
{
    File.Delete("demo.txt");
}
void moveFolder()
{
    File.WriteAllText("C:\\Users\\Ahmed_hb29\\Desktop\\Folder5\\demo.txt", "Hello World");
    File.Delete("C:\\Users\\Ahmed_hb29\\Desktop\\Folder5\\demo.txt");
    CreateFolder("Folder6");
    File.WriteAllText("C:\\Users\\Ahmed_hb29\\Desktop\\Folder6\\demo.txt", "Saaalaaam");

}
void SearchFile(string FolderName)
{
    string[] files = Directory.GetFiles(FolderName);

    foreach (string file in files)
    {
        Console.WriteLine(file);
    }

    string[] altFolder = Directory.GetDirectories(FolderName);
    foreach (string altFolder1 in altFolder)
    {
        SearchFile(altFolder1); 
    }
}
//CreateFolder();
//showDirectory();
//deleteFolder();
//createFile();
//deleteFile();
moveFolder();