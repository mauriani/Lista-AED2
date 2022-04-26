using System;
using System.Collections.Generic;

class Program {
  static void exercicio01(){
     /* 01 - Crie um programa que exiba o seu nome na tela 100 vezes. */
   
   for (int i = 0; i < 10; i++) 
    {
      Console.WriteLine("Mauriani Maciel Lima");
    }
  }

  static void exercicio02(){
      /*02 - Crie um programa que exiba os números pares entre 1 e 100.*/

    for (int i = 1; i <= 100; i++) 
    {
      if(i%2 == 0){
        Console.WriteLine(i);
      }
    }
  }


  static void exercicio03(){
    /*03 Crie um programa que imprima na tela um triângulo de */
    
    int i, j;
    int n= 4;

    for(i = 1; i <= n; i++){
      for(j = n - i; j >= 1; j--) // imprime os espaços
          Console.WriteLine(" ");
      for(j = 1; j <= i; j++)
        // imprime os *
          Console.WriteLine("*");
      Console.WriteLine("\n");
    }
  }

  static void exercicio04(){
    /*
    04 - Os números de Fibonacci são uma sequência de números definidas recursivamente. 
    O primeiro elemento da sequência é 0 e o segundo é 1. 
    Os outros elementos são calculados somando os dois antecessores. 
    Crie um programa que exiba os primeiros 30 números da série de Fibonacci.
    */

    int fib1 = 0; 
    
    int fib2 = 1; 
    
    int fib3 = 0; 
    
    int n=4;


    Console.WriteLine(fib1);
    Console.WriteLine(fib2);

    for(int i =0; i< n; i++){

      fib3 = fib1 + fib2;

      Console.WriteLine(fib3);

      fib1 = fib2;
      fib2 = fib3;

    }

  }
  

  static void exercicio05(){
    Random randNum = new Random();
    
    int[] vetor = new int[10];
  

    for (int a = 0; a < vetor.Length; a++){
      vetor[a] = randNum.Next(100,200);
    }

    Array.Sort(vetor);

    for (int k= 0; k < vetor.Length - 1; k++){
        Console.WriteLine(vetor[k]);
    }
  }

  static void exercicio06(){
    
    Random randNum = new Random();

    int[] vetor1 = new int[5];
    int[] vetor2 = new int[5];
    int[] vetor3 = new int[10];
    int j = 0;



    for (int i = 0; i < vetor1.GetLength(0); i++){
      vetor1[i] = randNum.Next(100,200);
    }

    for (int i = 0; i < vetor2.GetLength(0); i++){
      vetor2[i] = randNum.Next(100,200);
    }

    for (int i = 0; i < 5; i++)
    {
      vetor3[j++] = vetor1[i];
      vetor3[j++] = vetor2[i];
    }

    Console.WriteLine("União dos vetores");

    for (int i = 0; i < vetor3.GetLength(0); i++)
    {
      Console.WriteLine($"{vetor3[i]}");
    }

    Array.Sort(vetor3);
    Console.WriteLine("Vetor ordenado");

    for (int i = 0; i < vetor3.GetLength(0); i++)
    {
      Console.WriteLine($"{vetor3[i]}");
    }
  }
  

  class Retangulo{
    private double baseRetangulo;
    private double alturaRetangulo;
  
    public double area;

    public Retangulo(double b, double h){
      baseRetangulo = b;
      alturaRetangulo = h;
    }

    public void setBase(double b){
       baseRetangulo = b;
    }

     public void setAltura(double h){
       alturaRetangulo = h;
    }

    public double getBase(){
      return baseRetangulo;
    }

    public double getAltura(){
      return alturaRetangulo;
    }

    public double calcularArea(){
      
      double calculo = this.baseRetangulo * this.alturaRetangulo;

      this.area = calculo;

      return this.area;
    }

    public override string ToString(){

      return   "\n" + "Dados Retangulo/Quadrado cadastrado" +"\n"+ 
       "Base: " + this.baseRetangulo + "\n" + 
       "Altura: " + this.alturaRetangulo + "\n" +
       "Area: " + this.area + "\n";
       
       }
       
  }


 class Ponto {
  /* CONSTRUTOR DA CLASSE Ponto */
    public double pontX;
    public double pontY;

    /*CONSTRUTOR PADRÃO*/
    public Ponto(){
      pontX = 0;
      pontY = 0;
    }

    /* CONSTRUTOR COM 2 PARÂMETROS */
    public Ponto(double X, double Y){
      this.pontX = X;
      this.pontY = Y;
    }

    public double getPontX(){
      return pontX;
    }

    public void setPontX(double X){
      pontX = X;
    }

    public double getPontY(){
      return pontY;
    }

    public void setPontY(double Y){
      pontY = Y;
    }
  }


[Serializable]
class Pessoa {
  public string? nome;
  public int idade;

 public Pessoa(){ }

  public Pessoa (string n, int i){
    this.nome = n;
    this.idade = i;
  }
  public string getNome()
  {
    return nome;
  }
  public void setNome(string n)
  {
    nome=n;
  }

  public int getIdade(){
    return idade;
  }

  public void setIdade(int i) {
    idade = i;
  }

  public void exibirDados(List<Pessoa> lista){
  
    int maxValue = 0;
    string nameOld = "";

    for(int i = 0; i < lista.Count; i++){

      if(lista[i].idade > maxValue){
        maxValue = lista[i].idade;
        nameOld = lista[i].nome;
      }
    }

    Console.WriteLine("A pessoa mais velha é " + nameOld + ", ela(e) tem a idade de " + maxValue + " anos");


  }
}

class Animal {
  public string nome_animal;
  public int tipo_animal;

  public Animal(){}
  public Animal(string n, int tipoAnimal){
    this.nome_animal = n;
    this.tipo_animal = tipoAnimal;
  }
}
  public static void Main (string[] args) {
   
    /*EXERCÍCIOS NIVEL BÁSICO*/
      // exercicio01();
      // exercicio02();
      // exercicio03();
      // exercicio04();

    /*EXERCÍCIOS NIVEL MÉDIO*/
      /*EXERCICIO 01*/
      // exercicio05();

      /*EXERCICIO 02*/
      // exercicio06();

      /*EXERCICIO 03*/
      /*
      double baseRetangulo = 0.0f;
      double alturaRetangulo = 0.0f;

      Console.WriteLine("Digite o valor da base: ");
      baseRetangulo = double.Parse(Console.ReadLine());

      Console.WriteLine("Digite o valor da altura: ");
      alturaRetangulo = double.Parse(Console.ReadLine());

      Retangulo retangulo = new Retangulo(baseRetangulo, alturaRetangulo);

      double areaResultante = retangulo.calcularArea();

      Console.WriteLine(String.Format("O valor da área é : {0:N0}", areaResultante)); 

      // chamando o override
      Console.WriteLine(retangulo);

      /*EXERCICIO 04*/

      /*construtor padrão*/
      // Ponto p = new Ponto();

      /*construtor com parametro*/
      // Ponto p = new Ponto(6.5,8.0);


    /*EXERCICIO 05*/

      //Construtor sem parâmetros
    /* Pessoa p = new Pessoa();

      List<Pessoa> list;

      list = new List<Pessoa>();


      for(int i = 0; i < 2; i++){
        Console.WriteLine("Informe o nome da pessoa: ");
        string name = Console.ReadLine();

        Console.WriteLine("Informe a idade da pessoa: ");
        int idade = int.Parse(Console.ReadLine());
        
        list.Add(new Pessoa(name,idade));

      }

      // Exibir a maior idade
      p.exibirDados(list);*/

        Animal a = new Animal();

              
    }
}