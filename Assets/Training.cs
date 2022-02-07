using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Training : MyDigimon
{
    public MyDigimon curentDigi;

    public void Train()
    {
        var MyDigi = GameObject.Find("PlayerDigi").GetComponent<MyDigimon>();
        int whichStat = Random.Range(0, 4);
        int x = Random.Range(1, 3);

        if (whichStat == 0)
        {
            MyDigi.strength += x;
            MyDigi.Evolve();
        }
        else if (whichStat == 1)
        {
            MyDigi.defense += x;
            MyDigi.Evolve();
        }
        else if (whichStat == 2)
        {
            MyDigi.speed += x;
            MyDigi.Evolve();
        }
        else if (whichStat == 3)
        {
            MyDigi.brains += x;
            MyDigi.Evolve();
        }
    }
}
