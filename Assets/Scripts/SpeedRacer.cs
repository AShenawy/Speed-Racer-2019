using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedRacer : MonoBehaviour
{
    public string carModel = "GTR R35";
    public string engineType = "V6, Twin Turbo";
    public int carWeight = 1609;
    public int yearMade = 2009;
    public float maxAcceleration = 0.98f;
    public bool isCarTypeSedan = false;
    public bool hasFrontEngine = true;
    public string carMaker;
    public class Fuel
        {
        public int fuelLevel;
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

    void ConsumeFuel()
    {
        carFuel.fuelLevel = carFuel.fuelLevel - 10;
    }

    void CheckFuelLevel()
    {
        switch (carFuel.fuelLevel)
        {
            case 70:
                print("The Fuel level is now nearing two-thirds.");
                break;
            case 50:
                print("The Fuel level is now at half the amount.");
                break;
            case 10:
                print("WARNING!!! The Fuel level is now critically low.");
                break;
            default:
                print("Nothing to Report !");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ConsumeFuel();
            CheckFuelLevel();
        }
    }
    
}
