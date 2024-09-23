using Assimp;
using Assimp.Configs;
using static System.Formats.Asn1.AsnWriter;

class Program
{
    static void Main(string[] args)
    {
        string path = "D:\\PROGA\\C-Mehatronics\\Cube1x1x1.STEP";
        AssimpContext importer = new AssimpContext();

        Scene scene = importer.ImportFile(path, PostProcessPreset.TargetRealTimeMaximumQuality);

        // Проверка поддержки формата
        if (importer.IsImportFormatSupported(".STEP"))
        {
            //Scene scene = importer.ImportFile(path, PostProcessPreset.TargetRealTimeMaximumQuality);
            Console.WriteLine("STEP file loaded successfully.");
        }
        else
        {
            Console.WriteLine("STEP format is not supported.");
        }
    }
}

