using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metode2
{
	class Program
	{
		static void Main(string[] args)
		{
			//CaoCallStack();
			int br = 3;
			Console.WriteLine($"U main-u, broj je {br}");
			UvecajBroj(br);
			Console.WriteLine($"U main-u, broj je {br}");

			Console.WriteLine("-------------------------");

			List<int> Brojevi = new List<int>();
			Brojevi.Add(3);
			Console.WriteLine($"U main-u, broj u listi je {Brojevi[0]}");
			UvecajBrojUListi(Brojevi);
			Console.WriteLine($"U main-u, broj u listi je {Brojevi[0]}");
			Console.ReadKey();

			int zklj = 3;
			zklj = UvecajBrojSaPromenom(zklj);

			int bla = 3;
			UvecajBrojPoReferenci(ref bla);

			int x = 5;
			int y = 8;
			Console.WriteLine("U main sam");
			int rez = Sabiranje(x, y) * 2;
			MojaMetoda();
			Console.WriteLine("Opet main :) ");
			MojaMetoda();
			Sabiranje(10, 5);
			Console.ReadKey();
		}

		static void CaoCallStack()
		{
			CaoCallStack();
		}

		static void UvecajBrojUListi(List<int> nekaLista)
		{
			//UvecajBrojSaPromenom(5);
			//UvecajBroj(10);
			Console.WriteLine($"U metodi, broj u listi je {++nekaLista[0]}");
		}

		static void UvecajBrojPoReferenci(ref int br)
		{
			br++;
		}

		static int UvecajBrojSaPromenom(int br)
		{
			return ++br;
		}

		static void UvecajBroj(int b) 
		{
			Console.WriteLine($"U metodi, broj je {++b}");
		}


		static int Sabiranje(int a, int b)
		{
			return a + b;	
		}

		static void MojaMetoda()
		{
			Console.WriteLine("Pozz iz metode :)");
		}
	}
}
