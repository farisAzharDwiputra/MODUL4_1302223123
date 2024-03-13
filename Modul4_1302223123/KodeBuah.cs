using System;

public class KodeBuah
{
    private Dictionary<string, string> DataBuah = new Dictionary<string, string>()
    {
        {"Apel","A00"},
        {"Aprikot", "B00" },
        {"Alpukat", "C00" },
        {"Pisang", "D00" },
        { "Paprika","E00"},
        {"Kurma","K00" },
       

    };
    
    public string GetKodeBuah(string NamaBuah)
    {
        return DataBuah.ContainsKey(NamaBuah) ? DataBuah[NamaBuah] : "Data Buah Tidak Ditemukan";
    }
}
