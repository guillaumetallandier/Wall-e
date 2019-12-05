using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Master2 : MonoBehaviour
{

    public GameObject po1;
    public GameObject po2;
    public GameObject po3;
    public GameObject voi1;
    public GameObject robot;
  

    // Use this for initialization
    public void begin(List<Regle> lr, List<EnumPeople> lp)
    {
        GameObject gm;
        po1.GetComponent<Observable>().Setup();
        po2.GetComponent<Observable>().Setup();
        po3.GetComponent<Observable>().Setup();
        voi1.GetComponent<Observable>().Setup();
        robot.GetComponent<Robot>().Setup("walle");

       

        po1.GetComponent<Personne>().setDest(robot);
        robot.GetComponent<Personne>().setDest(po3);
        


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
