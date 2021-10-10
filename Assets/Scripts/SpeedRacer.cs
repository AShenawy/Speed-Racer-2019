using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedRacer : MonoBehaviour
{
    string carModel    = "GTR R35";
    string engineType  = "V6, Twin Turbo";
    int carWeight      = 1609;
    int yearMade       = 2009;
    float maxAcceleration = 0.98f;
    bool isCarTypeSedan = false;
    bool hasFrontEngine = true;

    //Number 1 Assignment.
    void Start()
    {
        print("The new car model is like " + carModel + ". And the engine type should be " + engineType + " engine.");

        //call second function carWeightFunction
        CheckWeight();


        //Number 4Assignments
        if (yearMade <= 2009)
        {
            //4.a Assignment
            print("The car was introduced in first " + yearMade);

            //4.b Assignment
            int carAge = CalculateAge(yearMade);

            //4.c Assignment
            print("That makes it " + carAge + " years old.");

        }
        else
        {
            print("The car first introduced in the 2010's");
            print("And the  maximum acceleration is " + maxAcceleration + " m/s2");
        }

        print(CheckCharacteristics());

    }


    //Number 2 Assignment
    void CheckWeight()
    {
        if (carWeight < 1500)
        {
            print("The car named" + carModel + " is weight less than 1500 kg.");
        }
        else
        {
            print("The car named " + carModel + " weight is more than over 1500 kg.");
        }
    }

    //Number 3 Assignments
    int CalculateAge(int yearMade)
    {
        return 2021 - yearMade;
    }


    //Number 5 Assignments
    string CheckCharacteristics()
    {
        
        if (isCarTypeSedan)
        {
            return "The car is  sedan.";

        }
        else if (hasFrontEngine)
        {
            return "The car is not a sedan, it is a front engine.";

        }
        else
        {
            return "The car is a front engine.";
        }
    }






}
