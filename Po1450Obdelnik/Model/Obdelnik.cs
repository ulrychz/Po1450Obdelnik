namespace Po1450Obdelnik.Model
{
    public class Obdelnik
    {
        public int StranaA { get; set; }
        public int StranaB { get; set; }
        public int Obvod { get; set; }
        public int Obsah { get; set; }
        public double Uhlopricka { get; set; }
        private void SpoctiObvod()
        {
            Obvod = 2*(StranaA + StranaB);
        }

        private void SpoctiObsah()
        {
            Obsah = (StranaA * StranaB);
        }
        private void SpoctiUhlopricku ()
        {
            Uhlopricka = Math.Sqrt(StranaA * StranaA + Math.Pow(StranaB,2));
        }
        public void Vypocet()
        {
            SpoctiObvod();
            SpoctiObsah();
            SpoctiUhlopricku();
        }
    }
}
