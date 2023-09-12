using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    [SerializeField] Slider slider;


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
        slider.value = water;
        if (growth < 100)
            growth += growthRate * Time.deltaTime;
        //Debug.Log(growth);
        if (water <= 0)
            Destroy(this.gameObject);
        else
            water -= waterConsumptionRate * Time.deltaTime;
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
            water += 10 * Time.deltaTime;

        }
    }
}  
        

