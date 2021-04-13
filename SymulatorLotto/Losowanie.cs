using System.Collections.Generic;

namespace SymulatorLotto
{
    public class Losowanie
    {
        public int LiczbaLosowan { get; set; }
        public int NicNieTrafione { get; set; }
        public int TrafionychJedynek { get; set; }
        public int TrafionychDwojek { get; set; }
        public int TrafionychTrojek { get; set; }
        public int TrafionychCzworek { get; set; }
        public int TrafionychPiatek { get; set; }
        public List<int> TrafioneKule { get; set; }
    }
}
