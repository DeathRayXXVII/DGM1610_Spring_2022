using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public EnemyController enemy;
    public Slider slider;
    public Color low;
    public Color high;
    //public Vector3 Offset;
    public float xOffset; //x offset for camera
    public float yOffset; // y offset for camera

    void Start(){
        
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(enemy.transform.position.x + xOffset, enemy.transform.position.y + yOffset, transform.position.z);
        //enemy = FindObjectOfType<EnemyController>();
        //slider.transform.position = Camera.main.WorldToScreenPoint(transform.parent.position + Offset);
    }
    public void SetMaxHealth(int health, float maxHealth)
    {
        slider.gameObject.SetActive(health < maxHealth);
        slider.maxValue = health;
        slider.value = health;
    }

    public void SetHealth(int health)
    {
        
        slider.value = health;
        slider.fillRect.GetComponentInChildren<Image>().color = Color.Lerp(low, high, slider.normalizedValue);
    }
}
