using JetBrains.Annotations;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopPanelHandler : MonoBehaviour
{
    public GameObject MessagePopUp;
    public GameObject ConfirmationPopUp;
    public TMP_Text MessageText;
    public TMP_Text PriceText;
    public TMP_Text GoldCoinsText;
    public List<GameObject> ItemsToPurchase;
    public List<int> ItemsPrice;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int totalCoins = PlayerPrefs.GetInt("Coins");
        GoldCoinsText.text = "Golds: " + totalCoins;
        for (int i = 0; i < ItemsToPurchase.Count; i++)
        {
            string purchasedString = "Item_" + i;
            if (PlayerPrefs.GetString(purchasedString) == "1")
            {
                ItemsToPurchase[i].transform.GetChild(1).gameObject.SetActive(false);
            }

        }
    }

    int activePurchasePrice, activePurchaseIndex;
    public void PurchaseThisItem(int index)
    {
        string purchasedString = "Item_" + index;
        if (PlayerPrefs.GetString(purchasedString) == "1")
        {
            ItemsToPurchase[index].transform.GetChild(1).gameObject.SetActive(false);
            PlayerPrefs.SetInt("ActiveColorIndex", index);
        }
        else
        {
            activePurchasePrice = ItemsPrice[index];
            activePurchaseIndex = index;
            PriceText.text = activePurchasePrice + " GOLDS".ToString();
            ConfirmationPopUp.SetActive(true);
        }
    }
    public void ConfirmPurchase()
    {
        int totalCoins = PlayerPrefs.GetInt("Coins");
        if (activePurchasePrice <= totalCoins)
        {
            totalCoins = totalCoins - activePurchasePrice;
            PlayerPrefs.SetInt("Coins", totalCoins);
            GoldCoinsText.text = "Golds: " + totalCoins;
            MessageText.text = "Purchase Successful!";
            ConfirmationPopUp.SetActive(false);
            MessagePopUp.SetActive(true);
            // Removing the lock icon from purchased items
            ItemsToPurchase[activePurchaseIndex].transform.GetChild(1).gameObject.SetActive(false);
            string purchasedString = "Item_" + activePurchaseIndex;
            PlayerPrefs.SetString(purchasedString, "1");
            PlayerPrefs.SetInt("ActiveColorIndex", activePurchaseIndex);
        }
        else
        {
            MessageText.text = "Purchase Failed \n Not Enough GOLDS!!!";
            ConfirmationPopUp.SetActive(false);
            MessagePopUp.SetActive(true);
        }
    }

    public void CloseMessagePopUp()
    {
        MessagePopUp.SetActive(false);
    }
    public void QuickPlay()
    {
        SceneManager.LoadScene(1);
    }
}