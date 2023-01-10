namespace App2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    public class Yazici
    {
        public Yazici(string name)
        {
            Name = name;
            OlusturmaTarihi = System.DateTime.Now;
            UId = System.Guid.NewGuid().ToString();
        }
        public int Id { get; set; }
        public string UId { get; set; }
        public DateTime OlusturmaTarihi { get; set; }
        public string Name { get; set; }
    }
}