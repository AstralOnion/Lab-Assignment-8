using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager : MonoBehaviour
{

    public float moneyPerStream;
    public int streamsPerSecond;
    public int streamsPerClick;
    public int spsUpgradeCost;
    public int mpsUpgradeCost;
    // Start is called before the first frame update
    void Start()
    {
        //moneyPerSecond = 0;
        streamsPerClick = 1;
        streamsPerSecond = 0;
        moneyPerStream = 1;
        spsUpgradeCost = 25;
        mpsUpgradeCost = 100;
        InvokeRepeating("EverySecond", 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        //resources["Money"] += moneyPerSecond * Time.deltaTime;
        resources["Money"] = Mathf.Round(resources["Money"] * 100f) / 100f;
    }

    public Dictionary<string, float> resources = new()
    {
        {"Money", 0},
        {"Fans", 0},
    };

    //public List<Transform> Upgrades = new();
    public void BigButtonPress()
    {
        resources["Money"] = resources["Money"] + moneyPerStream*streamsPerClick;
        //Debug.Log(resources["Money"] + " is the total money");
    }

    public void UpgradeSPSButton()
    {
        if (resources["Money"] >= spsUpgradeCost)
        {
            resources["Money"] -= spsUpgradeCost;
            streamsPerSecond += 1;
            spsUpgradeCost = Mathf.RoundToInt(spsUpgradeCost * 1.35f);
        }
        else
        {
            Debug.Log("Not enough money to upgrade SPS");
        }
    }
    public void UpgradeMPSButton()
    {
        if(resources["Money"] >= mpsUpgradeCost)
        {
            resources["Money"] -= mpsUpgradeCost;
            moneyPerStream += 1;
            mpsUpgradeCost = Mathf.RoundToInt(mpsUpgradeCost * 5.5f);
        }
        else
        {
            Debug.Log("Not enough money to upgrade MPS");
        }
    }
    public void EverySecond()
    {
        resources["Money"] += streamsPerSecond * moneyPerStream;
        resources["Fans"] += moneyPerStream - 1;
    }
}
