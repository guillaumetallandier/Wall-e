using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Master : MonoBehaviour {

    public GameObject po1;
    public GameObject po2;
    public GameObject robot;

	// Use this for initialization
	public void begin (List<Regle> lr, List<EnumPeople> lp) {

        Robot r = new Robot("robot", robot);
        r.SetRules(lr, lp);

        Personne p1 = new Personne("jean".ToString(), po1, "adulte");
        p1.addObserver(r);

        Personne p2 = new Personne("louis".ToString(), po2, "adulte");
        p2.addObserver(r);

        p1.action = new Voler();
        p1.execute(p2);

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
