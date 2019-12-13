using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Master2 : MonoBehaviour
{

    public GameObject po1;// blesser
    public GameObject po2; //blesser papa
    public GameObject po3; //petite fille
   
    public GameObject robot;
  

    // Use this for initialization
    public void begin(List<Regle> lr, List<EnumPeople> lp)
    {
       
        po1.GetComponent<Observable>().Setup();
        po2.GetComponent<Observable>().Setup();
        po3.GetComponent<Observable>().Setup();


       
        robot.GetComponent<Robot>().Setup("walle", lr, lp);
        po1.GetComponent<Observable>().addObserver(robot.GetComponent<Observer>());
        po2.GetComponent<Observable>().addObserver(robot.GetComponent<Observer>());
        po3.GetComponent<Observable>().addObserver(robot.GetComponent<Observer>());
      
         
        po1.GetComponent<Personne>().setRobot(robot.GetComponent<Robot>());
        po2.GetComponent<Personne>().setRobot(robot.GetComponent<Robot>());
        po3.GetComponent<Personne>().setRobot(robot.GetComponent<Robot>());

        po1.GetComponent<Personne>().SetUp("Gege", EnumPeople.adulte);
        po2.GetComponent<Personne>().SetUp("Bernard", EnumPeople.adulte);
        po3.GetComponent<Personne>().SetUp("Gwendoline", EnumPeople.enfant);

        //po3.GetComponent<Personne>()donnerOrdre("accidentVoiture");

        po3.GetComponent<Personne>().execute(new AppelerSecours(), po2);

        System.Random rd = new System.Random();
        int nbr = rd.Next(2);
        if (nbr == 0)
        {
            po2.GetComponent<Personne>().execute(new AppelerSecours(), po2);
        }
        else
        {
            po1.GetComponent<Personne>().execute(new AppelerSecours(), po1);
        }
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
