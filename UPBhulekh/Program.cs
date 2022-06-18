// See https://aka.ms/new-console-template for more information
using UPBhulekh.CSV;
using UPBhulekh.Data_Contract;
using UPBhulekh.Data_Request;

Console.WriteLine("Starting now .. ");

FileWriter outputFile = new FileWriter(@"C:\Users\Nikhil\Downloads\UPBhulekh.csv");
FillVillageRequest request = new FillVillageRequest("190", "00962");
List<Village> villages = request.Execute();
List<KhataDetails> khataDetails = new List<KhataDetails>();

foreach (Village village in villages)
{
    SBNameRequest sbRequest = new SBNameRequest(village.Code, "अशोक");
    List<Khata> khatas = sbRequest.Execute();

    foreach (Khata khata in khatas)
    {
        khataDetails.Add(new KhataDetails { 
            Number = khata.Number,
            Owner = khata.Owner,
            FatherName = khata.FatherName,
            VillageName = village.Name,
            VillageCode = village.Code,
            ParganaName = village.ParganaName,
            ParganaCode = village.ParganaCode
        });
    }
}

outputFile.Write(khataDetails);


Console.WriteLine("Completed !!");
