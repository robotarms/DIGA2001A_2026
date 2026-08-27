using UnityEngine;

[CreateAssetMenu(fileName = "InventoryItem", menuName = "Scriptable Objects/Inventory Item")]

public class InventoryItem : ScriptableObject
{
    public string itemName;
    [TextArea] public string itemDescription; //anables more text input for inspector
    public int itemValue;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
