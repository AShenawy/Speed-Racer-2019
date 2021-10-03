using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedRacer : MonoBehaviour
{
    string carModel = "GTR R35";
    string engineType = "V6, Twin Turbo";
    int carWeight = 1609;
    int yearMade = 2009;
    decimal maxAcceleration = 0.98;
    bool isCarTypeSedan = false;
    bool hasFrontEngine = true;

    // Created functions
    int CheckWeight;
    int CalculateAge;
    int carAge;
    string CheckCharacteristics;

    CheakWeight()
        {
         if{
            carWeight < 1500;
            print("The"carModel" weighs less than 1500kg.");
            }
          else
            {
              print("The"carModel" weighs over than 1500kg.");
            }
        }
    
    CalculateAge()
    {
      carAge=2021-yearMade;
    }

    CheckCharacteristics()
    {
      if{
          isCarTypeSedan=true;
          print("The Car type is a sedan");
        }
      else if{
              hasFrontEngine = true;
              print("The Car type is not a sedan but has a front engine");         
             }
      else{
            print("The car is neither a sedan nor does it have a front engine.");
          }
    }

    // Start is called before the first frame update
    void Start()
    {
        print("The Car model is "carModel"and the engine Type is"engineType);
        print(CheckWeight);
        if
          {
            yearMade<=2009;
            print("The Car was introduced in "yearMade);
          }
        CalculateAge()
        {
        print("The age of the car is "carAge);
        }
        print("The maximum acceleration of the car is"maxAcceleration);  
        print(CheckCharacteristics);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
