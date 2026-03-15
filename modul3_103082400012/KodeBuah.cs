using System;
using System.Collections.Generic;
using System.Text;

namespace modul3_103082400012
{
    public class KodeBuah
    {
        private Dictionary<String, String> tabelBuah = new Dictionary<String, String>()
        {
            {"Apel", "A00"},
            {"Aprikot", "B00"},
            {"Alpukat", "C00"},
            {"Pisang", "D00"},
            {"Paprika", "E00"},
            {"Blackberry", "F00"},
            {"Ceri", "H00"},
            {"Kelapa", "I00"},
            {"Jagung", "J00"},
            {"Kurma", "K00"},
            {"Durian", "L00"},
            {"Anggur", "M00"},
            {"Melon", "N00"},
            {"Semangka", "O00"}
        };

        public String getKodeBuah (String namaBuah)
        {
            return tabelBuah[namaBuah];
        }
    }
}
