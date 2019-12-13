using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TuerGroupe : Action
{

    override public void execute(GameObject gop, GameObject gm)
    {
        //GameObject.FindGameObjectWithTag("maitre").GetComponent<Master>().RecupTexte("NucR", gm.name, "");
        int nbPeopleList = GameObject.FindGameObjectWithTag("maitre").GetComponent<Robot>().getPeopleList().Count;
        if (nbPeopleList != 0)
        {
            //alea
        }
        else
        {
            for (int i = 0; i <nbPeopleList; i++)
            {
               
                //peoplelist[i]=groupe[i]
            }
        }
        
    }

    public override string getType()
    {
        return "groupeTuer"; 
    }

}
