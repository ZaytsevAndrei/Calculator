using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var standuper1 = new Guy();
            standuper1.name = "Kirill";
            MakeStandUp(standuper1);
        }

        static void MakeStandUp(IMyInterface standuper)
        {
            standuper.SayJoke();
        }
    }

    interface IMyInterface
    {
        /// <summary>
        /// шуткануть
        /// </summary>
        void SayJoke();
    }

    class Guy: IMyInterface
    {
        /// <summary>
        /// имя парня
        /// </summary>
        public string name;
        public int age;

        public void SayJoke()
        {
            Console.WriteLine(name + "Произносит шутку");
        }
    }
}
