using System;

namespace _2{
    class Program{
        static void Main(string[] args){
            multiplicationtable(9);
        }

        static void multiplicationtable(int n){
            int r = 1;

            for (int j = 0; j < n; j++){

                for (int i = 0; i < n; i++){
                    int t = r * (i + 1);
                    
                    if (t < 10){
                        Console.Write(" " + t + "  ");
                    }

                    else{
                        Console.Write(t + "  ");
                    }
                }

            Console.Write("\n");
            r++;
            }
        }
    }
}

