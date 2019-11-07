using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Action
{

    public abstract void execute(Personne p, Personne pAgit);
    public abstract string getType();
}
