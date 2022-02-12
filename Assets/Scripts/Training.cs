using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class Training : MonoBehaviour
{
    public GameObject TButtons;
    public GameObject StatGain;
    public GameObject Button;
    public string GainText;


    public void Start()
    {
        TButtons.SetActive(false);
    }

    public void TrainingButtons()
    {
        TButtons.SetActive(true);
    }

    public void TrainStr()
    {
        var MyDigi = GameObject.Find("PlayerDigi").GetComponent<MyDigimon>();
        int x = Random.Range(1, 6); 


        if (MyDigi.hunger >= 5)
        {
            GainText = MyDigi.MyDigi.Digi + " is too hungry to train!";
            print("Your digimon is too hungry to train!");
            GameObject fail = Instantiate(StatGain, Button.transform);
            fail.GetComponent<TextMeshPro>().SetText(GainText);
        }
        else
        {
            MyDigi.strength += x;
            print("Strength has increased by " + x);
            GainText = "+ " + x; 
            MyDigi.hunger += 1;
            print(MyDigi.MyDigi.Digi + " is getting hungry");
            GameObject increase = Instantiate(StatGain, Button.transform);
            increase.GetComponent<TextMeshPro>().SetText(GainText);
            MyDigi.Evolve();
        }
    }

    public void TrainDef()
    {
        var MyDigi = GameObject.Find("PlayerDigi").GetComponent<MyDigimon>();
        int x = Random.Range(1, 6);
        GameObject TButtons = GameObject.Find("Training");

        if (MyDigi.hunger >= 5)
        {
            GainText = MyDigi.MyDigi.Digi + " is too hungry to train!";
            print("Your digimon is too hungry to train!");
            GameObject fail = Instantiate(StatGain, Button.transform);
            fail.GetComponent<TextMeshPro>().SetText(GainText);
        }
        else
        {
            MyDigi.defense += x;
            print("Defense has increased by " + x);
            GainText = "+ " + x;
            MyDigi.hunger += 1;
            print(MyDigi.MyDigi.Digi + " is getting hungry");
            GameObject increase = Instantiate(StatGain, Button.transform);
            increase.GetComponent<TextMeshPro>().SetText(GainText);
            MyDigi.Evolve();
        }
    }

    public void TrainSpd()
    {
        var MyDigi = GameObject.Find("PlayerDigi").GetComponent<MyDigimon>();
        int x = Random.Range(1, 6);
        GameObject TButtons = GameObject.Find("Training");

        if (MyDigi.hunger >= 5)
        {
            GainText = MyDigi.MyDigi.Digi + " is too hungry to train!";
            print("Your digimon is too hungry to train!");
            GameObject fail = Instantiate(StatGain, Button.transform);
            fail.GetComponent<TextMeshPro>().SetText(GainText);
        }
        else
        {
            MyDigi.speed += x;
            print("Speed has increased by " + x);
            GainText = "+ " + x;
            MyDigi.hunger += 1;
            print(MyDigi.MyDigi.Digi + " is getting hungry");
            GameObject increase = Instantiate(StatGain, Button.transform);
            increase.GetComponent<TextMeshPro>().SetText(GainText);
            MyDigi.Evolve();
        }
    }

    public void TrainBrns()
    {
        var MyDigi = GameObject.Find("PlayerDigi").GetComponent<MyDigimon>();
        int x = Random.Range(1, 6);
        GameObject TButtons = GameObject.Find("Training");

        if (MyDigi.hunger >= 5)
        {
            GainText = MyDigi.MyDigi.Digi + " is too hungry to train!";
            print("Your digimon is too hungry to train!");
            GameObject fail = Instantiate(StatGain, Button.transform);
            fail.GetComponent<TextMeshPro>().SetText(GainText);
        }
        else
        {
            MyDigi.brains += x;
            print("Brains has increased by " + x);
            GainText = "+ " + x;
            MyDigi.hunger += 1;
            print(MyDigi.MyDigi.Digi + " is getting hungry");
            GameObject increase = Instantiate(StatGain, Button.transform);
            increase.GetComponent<TextMeshPro>().SetText(GainText);
            MyDigi.Evolve();
        }
    }
    public void Eat()
    {
        TButtons.SetActive(false);
        var MyDigi = GameObject.Find("PlayerDigi").GetComponent<MyDigimon>();
        if (MyDigi.hunger >= 1)
        {
            MyDigi.hunger -= 1;
            print(MyDigi.MyDigi.Digi + " has been fed");
            GainText = MyDigi.MyDigi.Digi + " has been fed";
            GameObject increase = Instantiate(StatGain, Button.transform);
            increase.GetComponent<TextMeshPro>().SetText(GainText);
        }
        else
        {
            print(MyDigi.MyDigi.Digi + " isn't hungry");
            GainText = MyDigi.MyDigi.Digi + " isn't hungry";
            GameObject increase = Instantiate(StatGain, Button.transform);
            increase.GetComponent<TextMeshPro>().SetText(GainText);
        }
    }


}

