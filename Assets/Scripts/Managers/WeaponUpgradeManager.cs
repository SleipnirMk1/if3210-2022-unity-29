using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class WeaponUpgradeManager : MonoBehaviour
{
    public bool isUpgradeChosen = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void UpgradeWeapon()
    {
        Debug.Log("UPGRADE CHOSEN");
        isUpgradeChosen = true;
        // Time.timeScale = 1;
    }
}
