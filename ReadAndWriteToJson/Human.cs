using System;
using System.Security.Cryptography.X509Certificates;

abstract class Human
{
    private string hairColor;
    private string eyeColor;
    private string gender;

    public Human(string hairColor, string eyeColor, string gender)
    {
        this.hairColor = hairColor;
        this.eyeColor = eyeColor;
        this.gender = gender;
    }

     public void printHairColor(){
            Console.WriteLine(this.hairColor);
        }
}