internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("File and FileInfo!\n");

        Console.WriteLine("File provides Static Methods\n");

        var path = @"C:\Users\DevPC\Documents\GITHUB\gitReadMe.md";

        //Three parameter; boolean means if the file exists then overwrite it.
        File.Copy(@"C:\Users\DevPC\Documents\GITHUB\Codecademy\gitReadMe.md", @"C:\Users\DevPC\Documents\GITHUB\gitReadMe.md",true);
        //Deleting a file
        File.Delete(path);
        if(File.Exists(path))
        {
            //
        }
        var content = File.ReadAllText(path);   

        Console.WriteLine("FileInfo provides Instance Methods\n");

        var fileInfo = new FileInfo(path);
        fileInfo.CopyTo(content);
        fileInfo.Delete();
        if(fileInfo.Exists) { }





        Console.WriteLine("FileInfo provides Instace Methods\n");
    }
}