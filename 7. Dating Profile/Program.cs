using System;

namespace DatingProfile {
  class Program {
    static void Main(string[] args) {

     Profile Sam = new Profile("Sam Drakilla", 30, "New York", "USA", "he/him");
     Sam.SetHobbies(new string[] {"Listening to audiobooks and podcasts", "playing rec sports like bowling and kickball", "writing a speculative fiction novel", "reading advice columns"});

     Profile Jayda = new Profile("Jayda Smith", 28, "Philadelphia", "USA", "she/her");
     Jayda.SetHobbies(new string[] {"Basketball", "watching independent documentaries", "reading advice columns"});
         
      Console.WriteLine(Sam.ViewProfile());
      Console.WriteLine(Jayda.ViewProfile());
    }
  }
}
