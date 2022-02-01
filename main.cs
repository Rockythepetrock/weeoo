using System;

class Program {
  public static void Main (string[] args) {
      int guesses = 4;
      
    string[] WordList = {"there","sugar","perky","hello","front"};
    //Make a new random object
    //Pick a random number from 0 to the length of wordList
    //take that item from wordList and save it in word
    Random rnd = new Random();
    int choice = rnd.Next(0,WordList.Length);
    string word = WordList [choice];
    Console.WriteLine("Welcome to the game");
    

    while (guesses > 0){
      Console.WriteLine("Guess the 5 letter word.");
    string guess = Console.ReadLine().ToLower();
    if (guess[0]==word[0]){
        Console.WriteLine("First letter in the right place");
    }else if (word.IndexOf(guess[0])>-1){
      Console.WriteLine("The first letter is in the word");
      }


    if (guess[1]==word[1]){
        Console.WriteLine ("That second letter is in the right place");
    }else if(word.IndexOf(guess[1])>-1){
        Console.WriteLine("The second letter is in the word");
    }
    if (guess[2]==word[2]){
        Console.WriteLine ("That third letter is in the right place");
    }else if(word.IndexOf(guess[2])>-1){
      Console.WriteLine("The third letter is in the word");
    }
     if (guess[3]==word[3]){
        Console.WriteLine ("That fourth letter is in the right place");
    }else if(word.IndexOf(guess[3])>-1){
      Console.WriteLine("The Fourth letter is in the word");

    }
     if (guess[4]==word[4]){
        Console.WriteLine ("That fifth letter is in the right place");
    }else if(word.IndexOf(guess[4])>-1){
      Console.WriteLine("The Fifth letter is in the word");

    }
        if (guess==word){
          Console.WriteLine("yay you did it");
          break;
          }
        guesses--;
      }
      if (guesses == 0){
        Console.WriteLine("You're trash lol");

    }
  }
}