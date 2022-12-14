namespace EsercitazioneColino
{
    internal class Program
    {
        enum Operazione
        {
            DELETE,
            GET,
            POST,
            UPDATE
        }

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
            StreamWriter sw = new StreamWriter(path); 
            for (int i = 0; i < rownumber; i++)
            {
                sw.WriteLine(OperazioneRandom());
            }
            sw.Close();
            return control;
        }
        public static string OperazioneRandom()
        {
            Random random = new Random();
            Array values = Enum.GetValues(typeof(Operazione));
            string randomstring = values.GetValue(random.Next(values.Length)).ToString();
            Console.WriteLine(randomstring);
            return randomstring;

        }

    }
}