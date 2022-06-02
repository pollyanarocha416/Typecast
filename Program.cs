class Aula10
{
    static void Main()
    {
        //convercao do tipo inplicita
        int n1 = 10;
        float n2 = n1;
        Console.WriteLine(n2);//10

        //typecast  CONVERCAO é necessário quando nao e segura ou seja Esplicita
        float n3 = 10.5f;
        int n4 = (int)n3;
        Console.WriteLine(n4);//10

        double a = 23.7;
        int n = (int)a;
        Console.WriteLine(n);

        double p = 43948.5;
        float q =  (float)p;



    }
}
