using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalap
{

    class Program
    {
        /*
         * //1.Publikus Push
         * //2. Publikus Pop, ami kivesz és visszaadja az értékét 
         * //3. Publikus Peek, ami nem vezs ki s a kalapból, DE visszaadja az értékét
         * //4. Publikus Empty, megmutatja, hogy a kalap üres-e vagy sem. Igazat vagy Hamisat ad vissza
         * //5. Publikus Count, ami megmutatja, hogy mennyi eleme van a kalapnak
         * 
         * BE KELL MUATNAI A FELHASZNÁLÓNAK!
         * 
         * */

        class Verem
        {
            private List<int> lista;
            public int Count;
            

            public Verem()
            {
                this.lista = new List<int>();
                this.Count = 0;
            }

            public bool Empty()
            {
                return this.lista.Count == 0;
            }

            public void Push(int elem)
            {
                Random rnd = new Random();
                int rszam = rnd.Next(100);

                this.lista.Add(elem);
                this.Count++;
            }

            public int Pop()
            {
                int result = this.lista[lista.Count - 1];
                this.lista.RemoveAt(lista.Count - 1);
                this.Count--;
                return result;
            }

            public int Peek()
            {
                return lista[lista.Count - 1];
            }

        }

        static void Main(string[] args)
        {
            Random rnd = new Random();
            int rszam = rnd.Next(100);

            Console.WriteLine("Létre hozom a kalapot");
            Verem verem = new Verem();
            Console.WriteLine("Létre hoztam, csak nem látod");

            Console.WriteLine($"Kiírim a kalap tartalmát: {verem.Count}");

            Console.WriteLine($"Megnézem, hogy üres-e a kalap: {verem.Empty()}");

            Console.WriteLine($"Most VÉLETLENSZERŰEN bele rakok egy számot 0-100-ig");
            verem.Push(rszam);
            
            Console.WriteLine($"Bizonyításképpen memutatom, hogy megváltozott a kalap tartalma: {verem.Count}, most pedig a számot mutatom meg: {verem.Peek()}");

            Console.WriteLine("Most bele rakok még 10 db számot");

            for (int i = 0; i < 10; i++)
            {
                Random rnd2 = new Random();
                int rszam2 = rnd.Next(100); 
                verem.Push(rszam2);
                Console.WriteLine(verem.Peek());
            }

            Console.WriteLine($"Most kiveszek egy számot és meg is mutatom: {verem.Pop()}");

            Console.WriteLine($"Megmutatom, hogy üres-e a kalap: {verem.Empty()}, végezetül pedig megmutatom a kalap tartalmának a létszámát: {verem.Count}");

            Console.ReadKey();
        }
    }
}

