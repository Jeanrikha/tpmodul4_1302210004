using System;
using System.Collections.Generic;
using static KodePos;

class KodePos
{
    private Dictionary<string, string> kodepos = new Dictionary<string, string>()
    {
        { "Batununggal", "40266" },
        { "Kujangsari", "40287" },
        { "Mengger", "40267" },
        { "Wates", "40256" },
        { "Cijaura", "40287" },
        { "Jatisari", "40286" },
        { "Margasari", "40286" },
        { "Sekejati", "40286" },
        { "Kebonwaru", "40272" },
        { "Maleer", "40274" },
        { "Samoja", "40273" },
    };

    public string getKodePos(string kelurahan)
    {
        if (kodepos.ContainsKey(kelurahan))
        {
            return kodepos[kelurahan];
        }
        else
        {
            return "Kode pos tidak ditemukan.";
        }
    }

    public class DoorMachine
    {
        private State state;

        public DoorMachine()
        {
            state = State.Locked;
            Console.WriteLine("Pintu terkunci");
        }

        public void Lock()
        {
            if (state == State.Unlocked)
            {
                state = State.Locked;
                Console.WriteLine("Pintu terkunci");
            }
        }

        public void Unlock()
        {
            if (state == State.Locked)
            {
                state = State.Unlocked;
                Console.WriteLine("Pintu tidak terkunci");
            }
        }

        private enum State
        {
            Locked,
            Unlocked
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("================TABLE-DRIVEN================\t");
        KodePos kodepos = new KodePos();
        Console.WriteLine("Kode Pos Batununggal adalah: \n" + kodepos.getKodePos("Batununggal") + "\n"); // output: Kode Pos Batununggal adalah: 40266
        Console.WriteLine("==========STATE-BASED CONSTRUCTION==========");
        DoorMachine pintu = new DoorMachine();
        pintu.Lock();
        pintu.Unlock();
        Console.ReadLine();
    }
}