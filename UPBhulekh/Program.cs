// See https://aka.ms/new-console-template for more information
using UPBhulekh.Common;
using UPBhulekh.CSV;
using UPBhulekh.Data_Contract;
using UPBhulekh.Data_Request;

Console.WriteLine("Starting now .. ");

FileWriter outputFile = new FileWriter(@"C:\Users\Nikhil\Downloads\UPBhulekh.csv");
List<KhataDetails> allKhataDetails = new List<KhataDetails>();

Console.Write("D");
FillTehsilRequest tehsilRequest = new FillTehsilRequest(Constants.DC_MAHARAJGANJ);
foreach (Tehsil tehsil in tehsilRequest.Execute())
{
    Console.Write("T");
    FillVillageRequest villageRequest = new FillVillageRequest(Constants.DC_DEORIA, tehsil.Code);
    foreach (Village village in villageRequest.Execute())
    {
        Console.Write("V");
        SBNameRequest sbNameRequest = new SBNameRequest(village.Code, Constants.OWNER_ASHOK);
        foreach (Khata khata in sbNameRequest.Execute())
        {
            Console.Write("K");
            allKhataDetails.Add(new KhataDetails
            {
                Number = khata.Number,
                Owner = khata.Owner,
                FatherName = khata.FatherName,
                VillageName = village.Name,
                VillageCode = village.Code,
                ParganaName = village.ParganaName,
                ParganaCode = village.ParganaCode,
                TehsilName = tehsil.Name,
                TehsilCode = tehsil.Code
            });
        }
        Console.WriteLine();
    }
}

outputFile.Write(allKhataDetails);


Console.WriteLine("Completed !!");
