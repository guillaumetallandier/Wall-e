using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Master : MonoBehaviour {

    public GameObject po1; //voleur
    public GameObject po2; //humain
    public GameObject robot;
    public GameObject GO_item;
    public GameObject ITEM_item;

	// Use this for initialization
	public void begin (List<Regle> lr, List<EnumPeople> lp) {
        po1.GetComponent<Observable>().Setup();
        po2.GetComponent<Observable>().Setup();
        robot.GetComponent<Robot>().Setup("walle");

        po1.GetComponent<Observable>().addObserver(robot.GetComponent<Observer>());
        po2.GetComponent<Observable>().addObserver(robot.GetComponent<Observer>());

        po1.GetComponent<Personne>().setRobot(robot.GetComponent<Robot>());
        po2.GetComponent<Personne>().setRobot(robot.GetComponent<Robot>());

        po2.GetComponent<Personne>().setItem(new Item(GO_item,"porte-feuille"));

        po1.GetComponent<Personne>().setDest(po2);
        po1.GetComponent<Personne>().execute(new Voler() , po2.GetComponent<Personne>());
    }
	
	// Update is called once per frame
	void Update () {
         
	}

    public Action aleAction()
    {
        System.Random rd = new System.Random();
        int nbr = rd.Next(2);
        Action a;

        switch (nbr)
        {
            case 0 :
                a = new Voler();
                break;

            default:
                a = new Frapper();
                break;
        }
        return a;

    }
}
