using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Action
{

    public abstract void execute(Personne p, GameObject gm);
    public abstract string getType();
}
