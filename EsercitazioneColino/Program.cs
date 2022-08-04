namespace EsercitazioneColino
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int rowNumber;
            bool control=Int32.TryParse(Console.ReadLine(), out  rowNumber);
            if (control)
            {
                if (rowNumber >= 10 & rowNumber <= 20)
                {
                    CreateFile(rowNumber);
                }
            }
            
            Console.ReadKey();
        }
        public static bool CreateFile(int rownumber)
        {
            bool control=false;
            string path = @"..\OperazioniAPI.txt";
            StreamWriter sw = File.CreateText(path);
            return control;
        }
        
    }
}