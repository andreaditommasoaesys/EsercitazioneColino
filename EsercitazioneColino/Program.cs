namespace EsercitazioneColino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rowNumber;
            bool control = false;
            while (!control)
            {
                Console.WriteLine("Please enter a valid number, between 10 and 20");
                control = Int32.TryParse(Console.ReadLine(), out rowNumber);

                if (rowNumber >= 10 & rowNumber <= 20)
                {
                    CreateFile(rowNumber);
                    control = true;
                }
                else
                {
                    control = false;
                }
                
            }
            Console.ReadKey();
        }
        public static bool CreateFile(int rownumber)
        {
            bool control = false;
            string path = @"..\OperazioniAPI.txt";
            StreamWriter sw = File.CreateText(path);
            return control;
        }

    }
}