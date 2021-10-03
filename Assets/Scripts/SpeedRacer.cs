using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedRacer : MonoBehaviour
{
    string carModel = "GTR R35";
    string engineType = "V6, Twin Turbo";
    int carWeigh = 1609;
    int yearMade = 2009;
    decimal maxAcceleration = 0.98;
    bool isCarTypeSedan = false;
    bool hasFrontEngine = true;

    // Created functions
    int CheckWeight;
    int CalculateAge;

    CheakWeight
        {
         if{
            carWeight<1500;
            print("The"carModel" weighs less than 1500kg.");
            }
          else
            {
              print("The"carModel" weighs over than 1500kg.");
            }
    // Start is called before the first frame update
    void Start()
    {
        print("The Car model is "carModel"and the engine Type is"engineType);
        print(CheckWeight);
        
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
