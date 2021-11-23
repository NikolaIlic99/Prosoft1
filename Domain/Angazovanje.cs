namespace Domain
{
    public class Angazovanje
    {

        public int EmisijaId { get; set; }
        public int RedniBroj { get; set; }
        public VrstaAngazovanja VrstaAngazovanja { get; set; }
        public string OpisPosla { get; set; }
        public int Trajanje { get; set; }
        public Radnik Radnik { get; set; }


        public override string ToString()
        {
            return VrstaAngazovanja.GetName(typeof(VrstaAngazovanja), this.VrstaAngazovanja);
        }
    }

    public enum VrstaAngazovanja
    {
        Rezija,
        Administracija,
        Tehnika

    }

}