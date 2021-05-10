using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

      Console.Write("Enter a message to encrypt: ");
      string message = Console.ReadLine();

      char[] secretMessage = message.ToCharArray();
      char[] encryptedMessage = new char[secretMessage.Length];

      for (int i=0; i < secretMessage.Length; i++){
        char letter = secretMessage[i];
        int position = (Array.IndexOf(alphabet, letter) + 3) % alphabet.Length;
        char newIndex = alphabet[position];
        encryptedMessage[i] = newIndex;
      }
      
      string encryptedString = String.Join("", encryptedMessage);
      Console.WriteLine(encryptedString);

    }
  }
}