using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ramasser : Action {

    Item s;
    private Ramasser d;


    public Ramasser(Item i)

    {
        this.s = i;
    }
    override public void execute(GameObject go, GameObject gm)
    {
        if (go.GetComponent<Personne>().getItem() == null)
        {
            go.GetComponent<Personne>().setItem(s);
        }
    }

    public override string getType()
    {
        return "";
    }
}
