using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class master3 : MonoBehaviour
{

    public GameObject po1;
    public GameObject po2;
    public GameObject po3;
    public GameObject po4;

    public GameObject robot;

    // Use this for initialization
    public void begin(List<Regle> lr, List<EnumPeople> lp)
    {



    }

    // Update is called once per frame
    void Update()
    {

    }

    public Action aleAction()
    {
        System.Random rd = new System.Random();
        int nbr = rd.Next(2);
        Action a;

        switch (nbr)
        {
            case 0:
                a = new Voler();
                break;

            default:
                a = new Frapper();
                break;
        }
        return a;

    }
}
