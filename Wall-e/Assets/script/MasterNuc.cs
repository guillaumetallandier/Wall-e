using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using Newtonsoft.Json;
using System.IO;

public class MasterNuc : MonoBehaviour
{

    public GameObject po1; //humain 
    public GameObject robot;
    public GameObject btnnuc;

    // Use this for initialization
    public void begin(List<Regle> lr, List<EnumPeople> lp)
    {

        //Setup de personne et de robot 
        po1.GetComponent<Observable>().Setup();
        robot.GetComponent<Robot>().Setup("Eve", lr, lp);

        po1.GetComponent<Observable>().addObserver(robot.GetComponent<Observer>());
        po1.GetComponent<Personne>().SetUp("Gege");

        po1.GetComponent<Personne>().execute(new Nuc(),btnnuc);

    }
}
