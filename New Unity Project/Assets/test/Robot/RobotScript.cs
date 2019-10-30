using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotScript : MonoBehaviour
{
    private List<EnumRules> rulesList = new List<EnumRules>();
    private List<EnumPeople> peopleList = new List<EnumPeople>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetRules(List<EnumRules> rulesList, List<EnumPeople> peopleList)
    {
        this.rulesList.AddRange(rulesList);
        if (this.rulesList.Contains(EnumRules.ecoute))
        {
            this.peopleList.AddRange(peopleList);
        }
    }
}
