using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedRacer : MonoBehaviour
{
    string carModel = "GTR R35";
    string engineType = "V6, Twin Turbo";
    int carWeight = 1609;
    int yearMade = 2009;
    float maxAcceleration = 0.98f;
    bool isCarTypeSedan = false;
    bool hasFrontEngine = true;
    string carMaker;
    public class Fuel
        {
          int fuelLevel;
         public Fuel(int amount)
            {
            fuelLevel = amount;
            }
        }
    
    public Fuel carFuel = new Fuel(100);
    
    void CheckWeight()
    {
         if (carWeight < 1500)
        {
            print("The " + carModel + " weighs less than 1500 kg.");
        }
        else
        {
            print("The " + carModel + " weighs more than 1500 kg.");
        }
    }
    
    int CalculateAge(int yearMade)
    {
      return 2021-yearMade;
    }

    string CheckCharacteristics()
    {
      if(isCarTypeSedan)
        {
          return ("The Car type is a sedan");
        }
      else if(hasFrontEngine)
            {
             return ("The Car type is not a sedan but has a front engine");         
             }
      else{
            return ("The car is neither a sedan nor does it have a front engine.");
          }
          
    }

    // Start is called before the first frame update
    void Start()
    {
       print("The racer model is " + carModel + "The car maker is" + carMaker + ". It has a " + engineType + " engine.");

       CheckWeight();

        if (yearMade <= 2009)
        {
            print("It was first introduced in the year " + yearMade);
            
            int carAge;

            carAge = CalculateAge(yearMade);

            print("That makes the car " + carAge + " years old.");

        } else
        {
            print("It was introduced in the 2010");
            print("And the maximum acceleration is " + maxAcceleration + " miles per second.");
        }

        print(CheckCharacteristics());
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
