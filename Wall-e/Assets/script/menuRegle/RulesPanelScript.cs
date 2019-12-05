using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RulesPanelScript : MonoBehaviour
{
    public Button button;
    private List<EnumPeople> peopleList = new List<EnumPeople>();

    private void Start()
    {
        this.button.onClick.AddListener(delegate
        {
            sendToRobot();
        });
    }

    public void sendToRobot()
    {
        List<Regle> listeRegle = new List<Regle>();

        foreach(RuleScript rl in gameObject.GetComponentsInChildren<RuleScript>())
        {
            listeRegle.Add(rl.getRegle());
        }

        GameObject.FindGameObjectWithTag("maitre").GetComponent<Master2>().begin(listeRegle, this.peopleList);
        gameObject.SetActive(false);

    }
}
