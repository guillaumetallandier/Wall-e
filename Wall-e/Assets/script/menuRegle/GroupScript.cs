using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroupScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject selection;
    public Transform contentPanel;
    void Start()
    {
        for(int i = 0; i < 3; i++)
        {
            GameObject spawnedGameObject = (GameObject)GameObject.Instantiate(selection);
            spawnedGameObject.SetActive(true);
            spawnedGameObject.transform.SetParent(contentPanel);
            
        }
    }

}
