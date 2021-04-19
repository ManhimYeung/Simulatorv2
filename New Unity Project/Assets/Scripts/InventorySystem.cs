using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    /// <summary>
    /// Inventory System script
    /// to store all the resources gathered by the villagers
    /// </summary>
    [HideInInspector]
    public float wood; //gathered from trees
    [HideInInspector]
    public float food; //gathered from animals
    [HideInInspector]
    public float water; //gathered from any water source such as waterwell, rain and rivers
    [HideInInspector]
    public bool lumberJack; //to decide if the villager needs to chop more trees for wood
    [HideInInspector]
    public bool hunter; //to decide if the villager needs to hunt more animals for food
    [HideInInspector]
    public bool noWater; //haven't thought of a better name yet but it's to decide if the villager needs to gather more water

    
    // Start is called before the first frame update
    void Start()
    {
        StorageInitial();
    }

    // Update is called once per frame
    void Update()
    {
        StorageChecker();
    }

    void StorageInitial()
    {
        wood = 0.0f;
        food = 0.0f;
        water = 0.0f;

        
    }

    void StorageChecker() {        
        if (wood <= 100)
            lumberJack = true;
        if (food <= 100)
            hunter = true;
        if (water <= 100.0f)
            noWater = true;
    }
}
