using System;

public class PosisiKarakterGame
{
	public enum State { Berdiri, Tengkurap };
	
	public void Posisi(State InputPosisi)
	{
		switch (InputPosisi)
		{
			case State.Berdiri:
				if (InputPosisi == State.Berdiri)
					Console.WriteLine("Posisi Standby");
				else
                    Console.WriteLine("Berikan Perintah Lagi");
                break;

            case State.Tengkurap:
                if (InputPosisi == State.Tengkurap)
                    Console.WriteLine("Posisi Istirahat");
                else 
					Console.WriteLine("Berikan Perintah Lagi");
                break;

        }
	}
}
