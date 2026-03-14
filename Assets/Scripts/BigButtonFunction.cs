using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigButtonFunction : MonoBehaviour
{
    public ResourceManager resourceManager;
    // Start is called before the first frame update
    void Start()
    {
        resourceManager = GameObject.Find("GameManager").GetComponent<ResourceManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        resourceManager.BigButtonPress();
    }

}
