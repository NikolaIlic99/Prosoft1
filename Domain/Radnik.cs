namespace Domain
{
    public class Radnik
    {
        public int Radnikid { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }


        public override string ToString()
        {
            return Ime + " " + Prezime;
        }

    }
}