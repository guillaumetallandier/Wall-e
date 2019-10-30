using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RulesPanelScript : MonoBehaviour
{
    public Button button;
    private List<EnumRules> rulesList = new List<EnumRules>();
    private List<EnumPeople> peopleList = new List<EnumPeople>();

    private void Start()
    {
        this.button.onClick.AddListener(delegate
        {
            sendToRobot(rulesList, peopleList);
        });
    }

    public void sendToRobot(List<EnumRules> rulesList, List<EnumPeople> peopleList)
    {
        GameObject.FindGameObjectWithTag("Robot").GetComponent<RobotScript>().SetRules(this.rulesList, this.peopleList);
    }
}
