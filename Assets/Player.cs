using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int health;
    public Slider sliderHealth;

    // Start is called before the first frame update
    void Start()
    {
        sliderHealth.value = sliderHealth.maxValue = health;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Stone"))
        {
            Debug.Log("Impacto");
            Destroy(collision.gameObject);
            health--;
            sliderHealth.value = health;
        }
    }
}
