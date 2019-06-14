
 static void Main (string[] args)
  {
   string nome;

   float saldo;
  
  }



 void cadastrar( );

  { 
 
   Console.WriteLine("Para realizar o cadastro, informe o seu nome: "); 

   nome = Console.ReadLine( ); 

   Console.WriteLine(" Informe o valor do seu saldo: "); 

   saldo = float.Parse(Console.ReadLine( ));


  } 

 float ConsultarSaldo( )
   
  { 

   return saldo;
 
  }

 void depositar (float valor)
 
  { 

   saldo = valor + ConsultarSaldo( );
 
  }

 void sacar (float valor)

  { 
    
   if (valor <= ConsultarSaldo( ))
 
saldo = ConsultarSaldo( ) - valor;
   else 
  
  {

   Console.WriteLine("Saldo insuficiente.");
 
  }
 
 }


  cadastrar();

  Console.WriteLine(" ");

  Console.WriteLine(ConsultarSaldo( ));
  
depositar (100);

  Console.WriteLine(ConsultarSaldo( ));

  sacar (200);

  Console.WriteLine(ConsultarSaldo( ));

  sacar (400);

  

Console.WriteLine(" ");
  
Console.ReadKey( );
