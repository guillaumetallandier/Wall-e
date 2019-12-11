using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ramasser : Action {

    Item s = new Item("blabla");
    Ramasser(Item i)
    {
        this.s = i;
    }
    override public void execute(GameObject go, GameObject gm)
    {

    }

    public override string getType()
    {
        return ""; 
    }
}
