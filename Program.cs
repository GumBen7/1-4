namespace OneFour {
    class Program {
        static void Main(string[] args) {
            var nq = Console.ReadLine().Split();
            int n = Int32.Parse(nq[0]);
            int q = Int32.Parse(nq[1]);
            bool[] a = new bool[n + 1];
            a[0] = true;
            a[1] = true;
            double sqrN = Math.Sqrt(n);
            for (int i = 2; i <= sqrN; ++i) {
                for (int s = i*i; s <= n; s += i) {
                    a[s] = true;                   
                }         
            }
            for(int i = 0; i < q; ++i) {
                string bs = Console.ReadLine(); 
                Console.Write(bs + " "); 
                if (a[Int32.Parse(bs)]) { 
                    Console.WriteLine("not");
                }
                else {
                    Console.WriteLine("prime");
                }
            }
        }
    }
}