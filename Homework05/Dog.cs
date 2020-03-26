using System;
using System.Collections.Generic;
using System.Text;

namespace Homework05.classes
{
    public class Dog
    {
        public string  DogName { get; set; }
        public string DogColor { get; set; }
        public string DogRace { get; set; }
       
        public string Eat()
        {
            return $"{DogName}  which is a {DogColor} {DogRace} is now eating";
        }
        
        public string Play()
        {
            return $"{DogName} which is  a {DogColor} {DogRace} is now Playing";
        }
        public string ChasingTail()
        {
            return $"{DogName} which is a { DogColor} {DogRace} is now chasing it's tail";
        }
    }
}
