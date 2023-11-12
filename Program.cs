//List<char> Alfabeto = new List<char> {'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};
/*
foreach(var letra in Alfabeto){

    Console.Write(letra);
    Console.Write(" ------> ");
    Console.Write(System.Convert.ToInt32(letra));
    Console.WriteLine();

}
*/

//char entrada = Convert.ToChar(Console.ReadLine()!)

void PaginaInicial(){

    ConversaoAscii();

}

PaginaInicial();

void ConversaoAscii (){

    Console.Write($"Digite uma sequencia de letras para converter: ");

    string entrada = Console.ReadLine()!;

    for (int i=0; i < entrada.Length; i++){

        Char entradaConvertida = Convert.ToChar(entrada[i]);

        Console.Write(entrada[i]);
        Console.Write(" ------> ");
        int entradaCovertidaASCII = Convert.ToInt32(entradaConvertida);
        Console.WriteLine(entradaCovertidaASCII);
    }

        Console.WriteLine("Pressiona qualquer tecla para reiniciar");
        Console.ReadLine();
        Console.Clear();
        PaginaInicial();
}