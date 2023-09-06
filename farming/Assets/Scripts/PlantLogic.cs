using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantLogic : MonoBehaviour
{
    float growth;
    [SerializeField] float growthRate;
    float water;
    [SerializeField] float waterConsumptionRate;
    [SerializeField] string name;
    [SerializeField] Sprite[] sprites;
    SpriteRenderer spriteRenderer;
    int e;
    int growthStage;

    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        water = 50;
        spriteRenderer.sprite = sprites[0];
        e = 100 / (sprites.Length - 1);
        growthStage = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
        growth += growthRate;
        //Debug.Log(growth);
        if (water <= 0)
            Destroy(this.gameObject);
        else
        water -= waterConsumptionRate;
        if (growth > e)
        {
            growthStage += 1;
            spriteRenderer.sprite = sprites[growthStage];
            e += 100 / (sprites.Length - 1);
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("WaterBucket") && water < 100)
        {
            Debug.Log("mmm water");
            water += 0.1f;

        }
    }
    
        
}
