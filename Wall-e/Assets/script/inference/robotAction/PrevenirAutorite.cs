using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrevenirAutorite : Action
{
    override public void execute(Personne p, Personne pAgit)
    {
        Debug.Log("Robot : previens Autorite .... COMPETENTE");
    }

    public override string getType()
    {
        return "prevenirAutorite";
    }
}
