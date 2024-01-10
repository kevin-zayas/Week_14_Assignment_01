using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HungerManager : MonoBehaviour
{

    public Image hungerBar;
    public float hungerAmount = 100f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            IncreaseHunger(10);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            DecreaseHunger(20);
        }
    }

    public void DecreaseHunger(float hunger)
    {
        hungerAmount -= hunger;
        hungerBar.fillAmount = hungerAmount / 100f;
    }

    public void IncreaseHunger(float hunger)
    {
        hungerAmount += hunger;
        hungerAmount = Mathf.Clamp(hungerAmount, 0, 100);

        hungerBar.fillAmount = hungerAmount / 100f;
    }
}
