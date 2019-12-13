using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterTuerGroupe : MonoBehaviour
{

    public List<GameObject> GroupePetiteFille;
    public List<GameObject> GroupeNormal;
    public GameObject tuture;
   

    // Use this for initialization
    public void begin(List<Regle> lr, List<EnumPeople> lp)
    {
        tuture.GetComponent<Voiture>().Setup("Mc Queen",lr,null);
        //GameObject.FindGameObjectsWithTag("groupe");
        //tuture.GetComponent<Robot>().execute(new TuerGroupe(),);
    }

   
}
