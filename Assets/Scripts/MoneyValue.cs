using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyValue : MonoBehaviour
{
    private TMP_Text moneyText;
    public int money = 0;

    // Start is called before the first frame update
    void Start()
    {
        moneyText = GetComponent<TMP_Text>();
        UpdateText();
    }

    public void UpdateText()
    {
        moneyText.text = "£" + money.ToString(); 

    }
}
