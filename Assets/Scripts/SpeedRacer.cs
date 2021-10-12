using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedRacer : MonoBehaviour
{
    //2nd assignment add public
    public string carModel    = "GTR R35";
    public string engineType  = "V6, Twin Turbo";
    public int carWeight      = 1609;
    public int yearMade       = 2009;
    public float maxAcceleration = 0.98f;
    public bool isCarTypeSedan = false;
    public bool hasFrontEngine = true;

    //2nd Assignment
    //Number 1
    //string carMaker;
    //Number 2
    public string carMaker;

    public class Fueal 
    {
       public int fuelLevel;

        public Fueal (int amount)
        {
            fuelLevel = amount;
        }
    }
    //Number 2
    public Fueal carFuel = new Fueal(100);

    //assignment 2 number 1
    void ConsumeFuel()
    {
        carFuel.fuelLevel = carFuel.fuelLevel - 10;
    }

    void CheckFuelLevel()
    {
        switch (carFuel.fuelLevel)
        {
            case 70:
                print("fuel level is in twothirds");
                break;

            case 50:
                print("fuel level is at half amount.");
                break;

            case 10:
                print("Warning! Fuel level is critically low.");
                break;

            default:
                print("Nothing to report.");
                break;

        }
    }
    //Number4 update Done
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ConsumeFuel();
            CheckFuelLevel();
        }
    }


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
