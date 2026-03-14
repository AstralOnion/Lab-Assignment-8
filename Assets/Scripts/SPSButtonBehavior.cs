using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPSButtonBehavior : MonoBehaviour
{
    public ResourceManager resourceManager;
    // Start is called before the first frame update
    void Start()
    {
        resourceManager = GameObject.Find("GameManager").GetComponent<ResourceManager>();
    }
    public void OnClick()
    {
        resourceManager.UpgradeSPSButton();
    }

}
