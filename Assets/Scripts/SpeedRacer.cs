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

    // Created functions
    int CheckWeight;
    int CalculateAge;
    int carAge;
    string CheckCharacteristics;

    CheakWeight()
        {
        if(carWeight < 1500)
            {
             print("The " + carModel + " weighs less than 1500 kg.");
            }
          else
            {
              print("The " + carModel + " weighs more than 1500 kg.");
            }
            
        }
    
    CalculateAge()
    {
      carAge=2021-yearMade;
    }

    CheckCharacteristics()
    {
      if(isCarTypeSedan = true)
        {
          Console.WriteLine("The Car type is a sedan");
        }
      else if(hasFrontEngine = true)
            {
             Console.WriteLine("The Car type is not a sedan but has a front engine");         
             }
      else{
            Console.WriteLine("The car is neither a sedan nor does it have a front engine.");
          }
          
    }

    // Start is called before the first frame update
    void Start()
    {
        Console.WriteLine("The Car model is " + carModel +" and the engine Type is " + engineType +);
        Console.WriteLine(CheckWeight);
        if(yearMade <= 2009)
          {
            Console.WriteLine("The Car was introduced in 2009");
          }
        CalculateAge();
        {
        Console.WriteLine("The age of the car is " + carAge);
        }
        Console.WriteLine("The maximum acceleration of the car is" + maxAcceleration);  
        Console.WriteLine(CheckCharacteristics);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
