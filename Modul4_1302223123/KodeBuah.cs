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
        {"Durian","L00" },
        {"Anggur", "M00" },
        {"Melon", " N00" },
        {"Semangka", "O00" },
        {"Blackberry","F00" },
        {"Ceri","H00 " },
        {"Kelapa", "I00" },
        {"Jagung", " j00" }


    };
    
    public string GetKodeBuah(string NamaBuah)
    {
        return DataBuah.ContainsKey(NamaBuah) ? DataBuah[NamaBuah] : "Data Buah Tidak Ditemukan";
    }
}
