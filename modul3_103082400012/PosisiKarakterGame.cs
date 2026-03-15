using System;
using System.Collections.Generic;
using System.Text;

namespace modul3_103082400012
{
    public class PosisiKarakterGame
    {
        public enum Posisi { Berdiri, Jongkok, Tengkurap, Terbang }
        public Posisi CurrentState { get; private set; }

        public PosisiKarakterGame()
        {
            CurrentState = Posisi.Berdiri;
        }

        public void command(String command)
        {
            if(CurrentState == Posisi.Jongkok)
            {
                if (command == "w")
                {
                    CurrentState = Posisi.Berdiri;
                    Console.WriteLine(CurrentState);
                }
                if(command == "s")
                {
                    CurrentState = Posisi.Tengkurap;
                    Console.WriteLine(CurrentState);
                }
            }

            if (CurrentState == Posisi.Berdiri)
            {
                if (command == "w")
                {
                    CurrentState = Posisi.Terbang;
                    Console.WriteLine(CurrentState);
                }
                if (command == "s")
                {
                    CurrentState = Posisi.Jongkok;
                    Console.WriteLine(CurrentState);
                }
            }

            if (CurrentState == Posisi.Terbang)
            {
                if (command == "x")
                {
                    CurrentState = Posisi.Jongkok;
                    Console.WriteLine(CurrentState);
                }
                if (command == "s")
                {
                    CurrentState = Posisi.Berdiri;
                    Console.WriteLine(CurrentState);
                }
            }

            if (CurrentState == Posisi.Tengkurap)
            {
                if (command == "w")
                {
                    CurrentState = Posisi.Jongkok;
                    Console.WriteLine(CurrentState);
                }
            }

        }
    }
}
