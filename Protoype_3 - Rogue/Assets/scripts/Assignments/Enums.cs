using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enums : MonoBehaviour
{
    enum Color {blue, red, yellow, green, orange, purple};
    enum CarMake {Oldsmobile, Chevrolet, Ford, Mazda, Toyota, Dodge};
    enum CarModel {Alero, Silverado, Tacoma, f350, Miata, Viper};
    enum 
    enum ConsoleWar {Playstaion, Xbox, Nintendo, SteamDeak};

    // Start is called before the first frame update
    void Start()
    {
        Color paint;
        paint = Color.blue;

        print(paint);

        CarMake make;
        CarModel model;
        make = CarMake.Ford;
        model = CarModel.f350;
        //print ("Car Manufacture: " + make + "model: " + model);

        Recall(CarMake.Oldsmobile, CarModel.Alero);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Recall(CarMake make, CarModel model)
    {
        if(make == CarMake.Oldsmobile && model == CarModel.Alero)
        {
            print("There is a recall on your vehicale due to a faulty ignition!");
        }
        else if(make == CarMake.Ford && model == CarModel.f350)
        {
            print ("There is a recall on all f350's for being too Cool!");
        }
        else
        {
            print("There is no recall notice for your vehical make and model!");
        }
    }
}
