using Övning_3a;
internal class Program
{
    private static void Main(string[] args)
    {
        Main main = new Main();
       
        /*
         3.3 frågor:
            Fråga 13: Ändringen för fåglar bör läggas i Bird-klassen

            Fråga 14: Behöver alla djur attributet bör ändringen läggas i Animal-klassen 

        3.4 frågor:
            Fråga 9: De är olika objekttyper. Var det en Animal-lista skulle det fungera eftersom båda är av den typen.

            Fråga 10: Animal- se ovan

            Fråga 13: På varje djur så initieras den Overrideade metoden för att returnera stats. Den overrideade metoden kallar på basversionen av metoden för att få den initiella listan, och lägger sedan till sina egna variabler på slutet av det returnerade string-värdet. Metoden returnerar sedan hela den färdiga stringen.

            Fråga 17: För Animal ärver inte från Dog. Nya metoder i Dog existerar alltså inte i en lista med Animals

              
         
         
         
         
         */


        try
        {
            main.Run();
        }
        catch (Exception ex) 
        {
            Console.WriteLine(  ex.Message);
        }
    }
}
