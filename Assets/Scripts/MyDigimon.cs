using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyDigimon : MonoBehaviour
{

    public Transform DigimonPos;
    public GameObject CurentDigi;
    public SpriteRenderer theSR;
    public Digimon MyDigi;
    //public string Nickname;
    public int strength, defense, speed, brains, hunger;

   

    // Start is called before the first frame update
    public void Start()
    {
        var MyDigi = GameObject.Find("PlayerDigi").GetComponent<MyDigimon>();
        MyDigi.Starter();

    }
    public void Update()
    {

    }

    
     public void Evolve()
    {
        foreach (Digimon evo in DigimonBuilder.AllDigi)
        {
            if (((MyDigi.Digi == evo.pre1) || (MyDigi.Digi == evo.pre2) || (MyDigi.Digi == evo.pre3)) && (strength >= evo.str) && (defense >= evo.def) && (speed >= evo.spd) && (brains >= evo.brns))
            {
                var evolution = evo;
                print("Your " + MyDigi.Digi + " has evolved into " + evolution.Digi);
                MyDigi = evo;
                theSR.sprite = MyDigi.DigiSprite;
            }
        }
    }
        private void Starter()
    {
        var starterDigi = Random.Range(0, 16);
        MyDigi = DigimonBuilder.AllDigi[starterDigi];
        theSR.sprite = MyDigi.DigiSprite;
    }
   
}



