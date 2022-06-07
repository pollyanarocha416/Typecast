class Aula10
{
    static void Main()
    {
        //convercao do tipo inplicita
       // int n1 = 10;
        //float n2 = n1;
       // Console.WriteLine(n2);//10

        //typecast  CONVERCAO é necessário quando nao e segura ou seja Esplicita
       // float n3 = 10.5f;
        //int n4 = (int)n3;
        //Console.WriteLine(n4);//10

        //double a = 23.7;
        //int n = (int)a;
        //Console.WriteLine(n);

        //double p = 43948.5;
        //float q =  (float)p;
        //Console.WriteLine(p);

        //calculadora 


        int n1, n2, n3, n4, res;
        res = n1 = n2 = n3 = n4 = 0;

        string resultado = "Reprovado";
        
        Console.WriteLine("Digite a nota 1: ");
        n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a nota 2: ");
        n2 = int.Parse(Console.ReadLine());
  
        Console.WriteLine("Digite a nota 3: ");
        n3 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a nota 4: ");
        n4 = int.Parse(Console.ReadLine());

        res = n1 + n2 + n3 + n4;

        if(res<40)
        {
            resultado = "reprovado";
        }else if(res<60){
            resultado="Recuperacao";
        }else{
            resultado = "Aprovado";
        }
        Console.WriteLine("Nota: {0} Resultado: {1}", res, resultado);
    }
}
