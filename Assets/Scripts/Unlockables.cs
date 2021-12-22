using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unlockables : MonoBehaviour
{
    public GameObject greenButton;
    public int CashValue;




    void Update()
    {
        CashValue = GlobalCash.TotalCash;
        if (CashValue >= 0)
        {
            greenButton.GetComponent<Button>().interactable = true;
        }
    }

    public void GreenUnlock()
    {
        greenButton.SetActive(false);
        CashValue -= 0;

    }
}
