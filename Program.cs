namespace OneFour {
    class Program {
        static void Main(string[] args) {
            var nq = System.Console.ReadLine().Split();
            int n = System.Int32.Parse(nq[0]);
            int q = System.Int32.Parse(nq[1]);
            bool[] a = new bool[n + 1];
            a[0] = true;
            a[1] = true;
            double sqrN = System.Math.Sqrt(n);
            for (int i = 2; i <= sqrN; ++i) {
                for (int s = i*i; s <= n; s += i) {
                    a[s] = true;                   
                }         
            }
            for(int i = 0; i < q; ++i) {
                string bs = System.Console.ReadLine(); 
                System.Console.Write(bs + " "); 
                if (a[System.Int32.Parse(bs)]) { 
                    System.Console.WriteLine("not");
                }
                else {
                    System.Console.WriteLine("prime");
                }
            }
        }
    }
}