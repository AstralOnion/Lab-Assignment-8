using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CMTPrefabBehavior : MonoBehaviour
{
    public ResourceManager resourceManager;
    void Start()
    {
        resourceManager = GameObject.Find("GameManager").GetComponent<ResourceManager>();
        //for later

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
