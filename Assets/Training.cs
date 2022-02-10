using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Training : MyDigimon
{
    public MyDigimon curentDigi;

    public void Train()
    {
        var MyDigi = GameObject.Find("PlayerDigi").GetComponent<MyDigimon>();

        if (MyDigi.hunger >= 5)
        {
            print("Your digimon is too hungry to train!");
        } 
        else 
        { 
            int whichStat = Random.Range(0, 4);
            int x = Random.Range(1, 6);

            if (whichStat == 0)
            {
                MyDigi.strength += x;
                print("Strength has increased by " + x);
                MyDigi.hunger += 1;
                print(MyDigi.MyDigi.Digi + " is getting hungry");
                MyDigi.Evolve();

            }
            else if (whichStat == 1)
            {
                MyDigi.defense += x;
                print("Defense has increased by " + x);
                MyDigi.hunger += 1;
                print(MyDigi.MyDigi.Digi + " is getting hungry");
                MyDigi.Evolve();
            }
            else if (whichStat == 2)
            {
                MyDigi.speed += x;
                print("Speed has increased by " + x);
                MyDigi.hunger += 1;
                print(MyDigi.MyDigi.Digi + " is getting hungry");
                MyDigi.Evolve();
            }
            else if (whichStat == 3)
            {
                MyDigi.brains += x;
                print("Brains has increased by " + x);
                MyDigi.hunger += 1;
                print(MyDigi.MyDigi.Digi + " is getting hungry");
                MyDigi.Evolve();
            }
        }
    }
}
