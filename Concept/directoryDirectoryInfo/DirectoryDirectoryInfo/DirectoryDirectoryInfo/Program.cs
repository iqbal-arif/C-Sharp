internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Directory and DirectoryInfo!\n");

        Directory.CreateDirectory(@"C:\Users\DevPC\Documents\GITHUB\FolderUdemy");

        //Get ALL FILES with extension Pattern stated
        var files = Directory.GetFiles(@"C:\Users\DevPC\Documents\GITHUB\C-Sharp", "*.sln",SearchOption.AllDirectories);
        foreach (var file in files)
        {
            //Console.WriteLine(file);
        }

        var directories = Directory.GetDirectories(@"C:\Users\DevPC\Documents\GITHUB","*.*",searchOption: SearchOption.AllDirectories);
        foreach (var directory in directories)
        {
            //Console.WriteLine(directory);
        }
        /*
        var directoryInfo = new DirectoryInfo("");
        directoryInfo.GetFiles();
        directoryInfo.GetDirectories();
        */
        //PATH Class
        var path = @"C:\Users\DevPC\Documents\GITHUB\gitReadMe.md";

        var dotIndex = path.IndexOf('.');
        var extension = path.Substring(dotIndex + 1);


        Console.WriteLine("DirectoryName: "+ Path.GetDirectoryName(path));
        Console.WriteLine("Extension: "+ Path.GetExtension(path));
        Console.WriteLine("FileName: "+ Path.GetFileName(path));
        Console.WriteLine("FileName without Extension: "+ Path.GetFileNameWithoutExtension(path));

    }
}