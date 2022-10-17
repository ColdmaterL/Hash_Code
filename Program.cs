using TestProj3HashCode.Entities;

namespace TestProj3HashCode{
    class Program{
        static void Main(string[] args){
            string path;
            HashSet<LogRecord> set = new HashSet<LogRecord>();

            System.Console.Write("Enter file name: ");
            path = Console.ReadLine()!;
            try{
                using(StreamReader sr = File.OpenText(path)){
                    while(!sr.EndOfStream){
                        string[] line = sr.ReadLine()!.Split(' ');
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);
                        set.Add(new LogRecord(name, instant));
                    }
                    System.Console.WriteLine("Total users: " + set.Count);
                }
            }
            catch(IOException e){
                System.Console.WriteLine(e.Message);
            }
            
        }
    }
}