public class Program
{
    public enum Kelurahan { Batununggal, Kujangsari, Mengger, Wates, Cijaura, Jatisari, Margasari, Sekejati, Kebonwaru, Maleer, Samoja };

    public enum DoorState { Terkunci, Terbuka};

    public enum Action { KunciPintu, BukaPintu };
    public class KodePos
    {
        

        public int getKodePos(Kelurahan kelurahan)
        {
            int[] KodePos = { 40266, 40287, 40267, 40256, 40287, 40286, 40286, 40286, 40272, 40274, 40273 };
            return KodePos[(int)kelurahan];
        }
    }



    public class DoorMachine
    {
        public DoorState stateSekarang = DoorState.Terkunci;
        public class Transition
        {
            public DoorState stateAwal;
            public DoorState stateAkhir;
            public Action aksi;

            public Transition(DoorState stateAwal, DoorState stateAkhir, Action aksi)
            {
                this.stateAwal = stateAwal;
                this.stateAkhir = stateAkhir;
                this.aksi = aksi;
            }
        }

        public Transition[] transisi =
        {
        new Transition(DoorState.Terkunci, DoorState.Terbuka, Action.BukaPintu),
        new Transition(DoorState.Terbuka, DoorState.Terkunci, Action.KunciPintu)
        };

        public DoorState getNextDoorState(DoorState stateAwal , Action aksi) {
            DoorState stateAkhir = stateAwal;
            Transition current;
            for (int i = 0; i < transisi.Length; i++)
            {   
                current = transisi[i];
                if (current.stateAwal == stateAwal && current.aksi == aksi)
                {
                    stateAkhir = current.stateAkhir; break; 
                }
            }
            return stateAkhir;
        }

        public void menjalankanAksi(Action aksi)
        {
            stateSekarang = getNextDoorState(stateSekarang, aksi);

            if (stateSekarang == DoorState.Terkunci)
            {
                Console.WriteLine("Pintu Terkunci");
            }

            if (stateSekarang == DoorState.Terbuka)
            {
                Console.WriteLine("Pintu Tidak Terkunci");
            }
        }
    }

    public static void Main(string[] args)
    {
        DoorMachine door1 = new DoorMachine();
        door1.menjalankanAksi(Action.KunciPintu);
        door1.menjalankanAksi(Action.KunciPintu);
        door1.menjalankanAksi(Action.BukaPintu);
        door1.menjalankanAksi(Action.KunciPintu);
        door1.menjalankanAksi(Action.BukaPintu);
        door1.menjalankanAksi(Action.BukaPintu);
    }
}



