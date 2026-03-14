using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextManager : MonoBehaviour
{

    public TextMeshProUGUI moneyText;
    public TextMeshProUGUI spsText;
    public TextMeshProUGUI mpsText;
    public TextMeshProUGUI fansText;
    public TextMeshProUGUI upgradeSPSText;
    public TextMeshProUGUI upgradeMPSText;
    private ResourceManager resourceManager;
    // Start is called before the first frame update
    void Start()
    {
        resourceManager = GameObject.Find("GameManager").GetComponent<ResourceManager>();
    }

    // Update is called once per frame
    void Update()
    {
        moneyText.text = ": " + resourceManager.resources["Money"].ToString();
        spsText.text = "Streams per second: " + resourceManager.streamsPerSecond.ToString();
        mpsText.text = "Money per stream: " + resourceManager.moneyPerStream.ToString();
        fansText.text = ": " + resourceManager.resources["Fans"].ToString();
        upgradeSPSText.text = "Produce Single: " + resourceManager.spsUpgradeCost.ToString() + " Money";
        upgradeMPSText.text = "Produce Album: " + resourceManager.mpsUpgradeCost.ToString() + " Money";
    }
}
