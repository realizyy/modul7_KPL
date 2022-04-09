using Newtonsoft.Json;

namespace modul7_1302204035;

public class BankTransferConfig
{
    private String CONFIG1;
    private int CONFIG2;
    private int CONFIG3;
    private int CONFIG4;
    private List<String> CONFIG5 = new()
    {
        "RTO (real-time)","SKN","RTGS","BI FAST"
    };
    private String CONFIG6;
    private String CONFIG7;

    public BankTransferConfig()
    {
        //get path
        string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
        //get file
        string file = File.ReadAllText(path + "\\bank_transfer_config.json");
        //convert json
        dynamic data = JsonConvert.DeserializeObject(file);
        //set config value
        CONFIG1 = data.lang;
        CONFIG2 = data.transfer.threshold;
        CONFIG3 = data.transfer.low_fee;
        CONFIG4 = data.transfer.high_fee;
        //CONFIG5 = data.method;
        CONFIG6 = data.confirmation.en;
        CONFIG7 = data.confirmation.id;
    }
    
    //getter
    public String getCONFIG1()
    {
        return CONFIG1;
    }
    
    public int getCONFIG2()
    {
        return CONFIG2;
    }
    
    public int getCONFIG3()
    {
        return CONFIG3;
    }
    
    public int getCONFIG4()
    {
        return CONFIG4;
    }
    
    public void printCONFIG5()
    {
        foreach (string item in CONFIG5)
        {
            Console.WriteLine(item);
        }
    }
    
    public String selectMethods(int index)
    {
        return CONFIG5[index];
    }

    public String getCONFIG6()
    {
        return CONFIG6;
    }
    
    public String getCONFIG7()
    {
        return CONFIG7;
    }
    
    public void setLanguage(String lang)
    {
        string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
        string file = File.ReadAllText(path + "\\bank_transfer_config.json");
        dynamic data = JsonConvert.DeserializeObject(file);
        data.lang = lang;
        String output = JsonConvert.SerializeObject(data, Formatting.Indented);
        File.WriteAllText(path + "\\bank_transfer_config.json", output);
    }
    
}