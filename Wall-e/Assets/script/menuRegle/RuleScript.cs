using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RuleScript : MonoBehaviour 
{ 

    private Regle regle;
    public Text regleLabel;
    public Button button;
    public GameObject selection;
    public Text pos;

    public void Setup(Regle r, string num)
    {
        this.regle = r;
        this.regleLabel.text = r.getDescription();
    }
    // Start is called before the first frame update
    public void Start()
    {
        
        button.onClick.AddListener(delegate
        {
            Remove();
        }
            );
    }

    // Update is called once per frame  
    public void Remove()
    {
        GameObject spawnedGameObject = (GameObject)GameObject.Instantiate(selection);
        spawnedGameObject.SetActive(true);
        spawnedGameObject.transform.SetParent(this.transform.parent);
        spawnedGameObject.transform.SetSiblingIndex(gameObject.transform.GetSiblingIndex());
        Destroy(gameObject);
    }

    public Button getButton()
    {
        return this.button;
    }

    public Regle getRegle()
    {
        return this.regle;
    }

    
}
