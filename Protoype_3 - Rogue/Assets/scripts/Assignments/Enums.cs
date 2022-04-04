using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enums : MonoBehaviour
{
    enum Color {blue, red, yellow, green, orange, purple};
    enum CarMake {Oldsmobile, Chevrolet, Ford, Mazda, Toyota, Dodge};
    enum CarModel {Alero, Silverado, Tacoma, f350, Miata, Viper}; 
    //enum CarYear {2000, 2005, 2010, 2015,2020, 2022};
    enum ConsoleWar {Playstaion, Xbox, Nintendo, SteamDeak};
    enum Weather {Raining, Sunny, Cloudy, Stormy};
    enum Food {Vegetables, Fruit, Protien, Dairy, Grains, Starvation};
    enum Drinks {Soda, Water, Sports, Coffie, Tea};
    enum Movies {Action, Drama, Horror, Romatic, Syfy, Fantasy};
    enum Snacks {Chips, Crackers, Candy, Cookies, Popcorn};
    // Start is called before the first frame update
    void Start()
    {
        Color paint;
        paint = Color.blue;
        print(paint);

        CarMake make;
        CarModel model;
        //CarYear year;
        make = CarMake.Ford;
        model = CarModel.f350;
        //year = CarYear.2020;
        print ("You won a " /*+ year*/ + make + "model: " + model);

        Recall(CarMake.Oldsmobile, CarModel.Alero);

        Snacks snacks;
        snacks = Snacks.Popcorn;
        print("You spiled your " + snacks + " while seeing an " + Movies.Action + " movie");

        ConsoleWar gaming;
        ConsoleWar gaming2;
        gaming = (ConsoleWar)Random.Range(0,3);
        gaming2 = (ConsoleWar)Random.Range(0,3);
        print("My " + gaming + " is better than your " + gaming2);

        Weather weather;
        weather = (Weather)Random.Range(0,3);
        print("Todays weather is going to be " + weather);

        Food food;
        food = (Food)Random.Range(0,5);
        Meal(food);

        Movies movie;
        movie = (Movies)Random.Range(0,5);
        print("Do you want to go see a  " + movie + " movie!");
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
    void Meal(Food food)
    {
        if(food == Food.Vegetables)
        {
            print("vegetables are like eating weeds!");
        }
        else if(food == Food.Fruit)
        {
            print ("Eating fruit is healthy!");
        }
        else if(food == Food.Protien)
        {
            print ("Eating protien build's me a great bod!");
        }
        else if(food == Food.Dairy)
        {
            print ("I'm am lactos!");
        }
        else if(food == Food.Grains)
        {
            print ("I tend to bloat when I eat grains!");
        }
        else if (food == Food.Starvation)
        {
            print ("starvation killed you!");
        }
    }
}
