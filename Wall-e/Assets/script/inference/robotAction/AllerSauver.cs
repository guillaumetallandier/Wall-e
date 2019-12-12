using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllerSauver : Action {

    override public void execute(GameObject go, GameObject gm)
    {
        Vector3 position = go.GetComponent<Robot>().transform.position;

        GameObject robot = go;

        Debug.Log("Robot : sauve " + gm.name);
        robot.GetComponent<Personne>().setDest(gm);

        go.transform.position = position;
        gm.transform.position = position;

        Debug.Log(gm.name + " à été sauvé par " + go.name);
    }

    public override string getType()
    {
        return "sauve";
    }
}
