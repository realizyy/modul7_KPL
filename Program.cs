// See https://aka.ms/new-console-template for more information

using modul7_1302204035;

Console.WriteLine("Hello, World!");
BankTransferConfig cfg = new BankTransferConfig();
//bahasa en/id
if (cfg.getCONFIG1() == "en")
{
    Console.WriteLine("Please insert the amount of money to transfer: ");
}
else
{
    Console.WriteLine("Masukkan jumlah uang yang akan di-transfer: ");
}
//input amount of money
int uang = Convert.ToInt32(Console.ReadLine());

//calculate fee
if (uang <= cfg.getCONFIG2())
{
    int biaya_transfer = cfg.getCONFIG3();
    int total = (uang + biaya_transfer);
        if (cfg.getCONFIG1() == "en")
        {
            Console.WriteLine("Transfer fee = " + biaya_transfer + " and total amount = " + total);
        }
        else
        {
            Console.WriteLine("Biaya transfer = " + biaya_transfer + " dan total biaya = " + total);
        }
} else
{
    int biaya_transfer = cfg.getCONFIG4();
    int total = (uang + biaya_transfer);
    if (cfg.getCONFIG1() == "en")
    {
        Console.WriteLine("Transfer fee = " + biaya_transfer + " and total amount = " + total);
    }
    else
    {
        Console.WriteLine("Biaya transfer = " + biaya_transfer + " dan total biaya = " + total);
    }
}
//method
if (cfg.getCONFIG1() == "en")
{
    Console.WriteLine("Select transfer method 1 - 4 : ");
    cfg.printCONFIG5();
    int inputMethod = Convert.ToInt32(Console.ReadLine());
    if (inputMethod == 1)
    {
        Console.WriteLine("Method : "+cfg.selectMethods(0));
    }
    else if (inputMethod == 2)
    {
        Console.WriteLine("Method : " + cfg.selectMethods(1));
    }
    else if (inputMethod == 3)
    {
        Console.WriteLine("Method : " + cfg.selectMethods(2));
    }
    else if (inputMethod == 4)
    {
        Console.WriteLine("Method : " + cfg.selectMethods(3));
    }
    else
    {
        Console.WriteLine("Invalid input");
    }
}
else
{
    Console.WriteLine("Pilih metode transfer 1 - 4 : ");
    cfg.printCONFIG5();
    int inputMethod = Convert.ToInt32(Console.ReadLine());
    if (inputMethod == 1)
    {
        Console.WriteLine("Metode : "+cfg.selectMethods(0));
    }
    else if (inputMethod == 2)
    {
        Console.WriteLine("Metode : " + cfg.selectMethods(1));
    }
    else if (inputMethod == 3)
    {
        Console.WriteLine("Metode : " + cfg.selectMethods(2));
    }
    else if (inputMethod == 4)
    {
        Console.WriteLine("Metode : " + cfg.selectMethods(3));
    }
    else
    {
        Console.WriteLine("Input tidak valid");
    }
}
//confrimasi transaksi
if (cfg.getCONFIG1() == "en")
{
    Console.WriteLine("Please type " + cfg.getCONFIG6() + " to confirm transaction");
    //konfrimasi
    String confrimasi = Console.ReadLine();
    if (confrimasi == cfg.getCONFIG6())
    {
        Console.WriteLine("The transfer is complete");
    }
    else
    {
        Console.WriteLine("Transfer is canceled");
    }
}
else
{
    Console.WriteLine("Ketik " + cfg.getCONFIG7() + " untuk konfirmasi transaksi");
    //konfirmasi
    String confrimasi = Console.ReadLine();
    if (confrimasi == cfg.getCONFIG7())
    {
        Console.WriteLine("Transaksi berhasil");
    }
    else
    {
        Console.WriteLine("Transaksi dibatalkan");
    }
}
//select bahasa
Console.WriteLine("Pilih Bahasa/Select Language : \n1. Bahasa Indonesia\n2. English");
int lang = Convert.ToInt32(Console.ReadLine());
if (lang == 1)
{
    cfg.setLanguage("id");
}
else
{
    cfg.setLanguage("en");
}