namespace MusicalInstruments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<MusicalInstrument> orchestra = new List<MusicalInstrument>()
            {
                new Violin(),
                new Trombone(),
                new Ukulele(),
                new Cello()
            };
            foreach (var instrument in orchestra)
            {
                instrument.Show();
                instrument.Description();
                instrument.HistoryInfo();
                Console.WriteLine(instrument);
            }

            Console.WriteLine();
        }
    }
    internal class MusicalInstrument
    {
        private string Name { get; set; }
        private string Desc { get; set; }
        private string History { get; set; }

        public MusicalInstrument(string name, string desc, string history)
        {
            Name = name;
            Desc = desc;
            History = history;
        }
        public virtual void Show()
        {
            Console.WriteLine($"Instrument: {Name}");
        }
        public virtual void Description()
        {
            Console.WriteLine($"Description: {Desc}");
        }
        public virtual void HistoryInfo()
        {
            Console.WriteLine($"History info: {History}");
        }
    }
    class Violin : MusicalInstrument
    {
        public Violin() : base(
            "Violin",
            "The violin, sometimes referred to as a fiddle,[a] is a wooden chordophone, and is the smallest, and thus highest-pitched instrument",
            "The violin was first created in 16th-century Italy, with some further modifications occurring in the 18th and 19th centuries to give the instrument a more powerful sound and projection"
            )
        { }
        public override void Show()
        {
            Console.WriteLine("Violin overrided");
        }
    }
    class Trombone : MusicalInstrument
    {
        public Trombone() : base(
            "Trombone",
            "The trombone is a musical instrument in the brass family",
            "The sackbut appeared in the 15th century and was used extensively")
        {
        }
        public override void Show()
        {
            Console.WriteLine("Trombone overrided");
        }
    }
    class Ukulele : MusicalInstrument
    {
        public Ukulele() : base(
            "Ukulele",
            "also called a uke (informally), is a member of the lute (ancient guitar) family of instruments.",
            "Developed in the 1880s, the ukulele is based on several small")
        {
        }
        public override void Show()
        {
            Console.WriteLine("Ukulele overrided");
        }
    }
    class Cello : MusicalInstrument
    {
        public Cello() : base(
            "Cello",
            "is a medium-low pitched bowed (sometimes plucked and occasionally hit) string instrument",
            "including cello-sized instruments, emerged c. 1500 as a family of instruments distinct")
        {
        }
        public override void Show()
        {
            Console.WriteLine("Cello overrided");
        }
    }

}
