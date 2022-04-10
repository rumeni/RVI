using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthElement : MonoBehaviour
{
    [SerializeField] private Image healthBar;

    public void SetHealth(float amount, Color barColor) 
    {
        healthBar.fillAmount = amount;
        healthBar.color = barColor;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

