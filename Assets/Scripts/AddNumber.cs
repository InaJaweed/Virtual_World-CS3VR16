using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddNumber : MonoBehaviour
{
    public int boxMoney;

   
    public MoneyValue moneyValue;

    public void AddValue()
    {
        moneyValue.money += boxMoney;
        moneyValue.UpdateText();
    }

   
    
   



}
