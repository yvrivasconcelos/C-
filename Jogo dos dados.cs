Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Rolagem de dados: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)){
    if ((roll1 == roll2) && (roll2 == roll3)){
        Console.WriteLine("Trio de dados iguais + 6 pontos ao total!");
        total += 6;
    }
    else{
        Console.WriteLine("Dados em dobro + 2 pontos ao total!");
        total += 2; 
    }
}

if (total >= 16) {
    Console.WriteLine("Parabéns, você ganhou uma bicicleta!");
    }

else if(total >= 10){
    Console.WriteLine("Parabéns, você ganhou um Notebook!");
}
else if(total == 7){
    Console.WriteLine("Parabéns, você ganhou uma viagem com acompanhante!");
}
else{
    Console.WriteLine("Você ganhou um gatinho!");
}


