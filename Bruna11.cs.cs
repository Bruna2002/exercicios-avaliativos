

string nome, linha1, linha2, linha3, linha4;
 
int idade;
           
float altura;

    


  Console.WriteLine("Esse é um software que formata trovas :) Antes de iniciarmos, você precisa se cadastrar. Vamos lá: ");
   
  Console.WriteLine("Informe o seu nome: ");
      
  nome = Console.ReadLine();

  
   
  Console.WriteLine("Informe a sua idade: ");
     
  idade = int.Parse(Console.ReadLine());

   
     
  Console.WriteLine("Só por curiosidade... qual é a sua altura?");
      
  altura = float.Parse(Console.ReadLine());

 

  Console.WriteLine();
      

  Console.WriteLine("Pronto! Agora nós iremos formatar a sua trova.");
       
  Console.WriteLine("Informe a primeira frase da trova: ");
     
  linha1 = Console.ReadLine();

      
   
  Console.WriteLine("Informe a segunda frase da trova: ");
          
  linha2 = Console.ReadLine();

  
     
  Console.WriteLine("Informe a terceira frase da trova: ");
    
  linha3 = Console.ReadLine();

  
       
  Console.WriteLine("Informe a quarta e última frase da trova: ");
        
  linha4 = Console.ReadLine();

  

  Console.WriteLine();
   
  Console.WriteLine("-----------------------------------------------");
          
  Console.WriteLine(linha1);
  
  Console.WriteLine(linha2);
       
  Console.WriteLine(linha3);
      
  Console.WriteLine(linha4);
      
  Console.WriteLine("------------------------------------------------");

   
         
  Console.ReadKey();
