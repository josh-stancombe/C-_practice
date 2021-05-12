using System;

namespace DatingProfile{ 
  class Profile{
    private string name;
    private int age;
    private string city;
    private string country;
    private string pronouns;
    private string[] hobbies;

    public Profile(string name, int age, string city, string country, string pronouns = "they/them"){
      this.name = name;
      this.age = age;
      this.city = city;
      this.country = country;
      this.pronouns = pronouns;
      this.hobbies = hobbies;
    }

    public void SetHobbies(string[] hobbies){
      this.hobbies = hobbies;
    }

    public string ViewProfile(){
      string bio = $"Name: {name},\nAge: {age},\nCity: {city},\nCountry: {country}, \nPronouns: {pronouns},\n";
      
      int hobbyCount = 0;
      foreach(string hobby in hobbies){
        if(hobbyCount == 0){
          bio += $"Hobbies: {hobby}";
        } else {
          bio += $", {hobby}";
        }
        hobbyCount+=1;
      }
      
      return bio;      
    }

  }
}
