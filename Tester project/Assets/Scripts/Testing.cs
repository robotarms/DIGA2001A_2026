using UnityEngine;
//using MyGame.Characters;

public class Testing : MonoBehaviour
{
    //public PotionData potionData;
    public InventoryItem inventoryItem;
    //public Hero myHero;
    //public Villain myVillain;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Gained " + inventoryItem.itemName + " of " + inventoryItem.itemDescription + " and " + inventoryItem.itemValue);
        //Debug.Log("Got " + potionData.potionName + " with " + potionData.healAmount);
        //myHero.PrintHealth();
        //myVillain.PrintDamage();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
