using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantLogic : MonoBehaviour
{
    float growth;
    [SerializeField] float growthRate;
    float water;
    [SerializeField] float waterConsumptionRate;
    
  
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        growth -= growthRate;
        water -= waterConsumptionRate;
       
    }
    private void OnTriggerStay2D(Collision2D collision)
    {
        Debug.Log("colide");
        if (collision.gameObject.CompareTag("WaterBucket"))
        {
            water += 0.1f;
            Debug.Log("water");
        }
    }
   
}
