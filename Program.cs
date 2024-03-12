public class Program
{
    public enum Kelurahan { Batununggal, Kujangsari, Mengger, Wates, Cijaura, Jatisari, Margasari, Sekejati, Kebonwaru, Maleer, Samoja };
    public class KodePos
    {
        

        public int getKodePos(Kelurahan kelurahan)
        {
            int[] KodePos = { 40266, 40287, 40267, 40256, 40287, 40286, 40286, 40286, 40272, 40274, 40273 };
            return KodePos[(int)kelurahan];
        }
    }

    public static void Main(string[] args)

    {
        KodePos kodepos = new KodePos();
        Console.WriteLine(kodepos.getKodePos(Kelurahan.Samoja));
    }
}



