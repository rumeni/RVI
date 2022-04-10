using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popup : MonoBehaviour
{
    [SerializeField] private HPElement playerHealthBar;
    [SerializeField] private Sprite playerImage;
    [SerializeField] private Color playerHealthColor;
    [SerializeField] private Sprite enemyImage;
    [SerializeField] private Color enemyHealthColor;
    [SerializeField] private GameObject healthBarPrefab;
        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnEnable() 
    {
        Player player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        playerHealthBar.SetImage(playerImage);
        playerHealthBar.SetHealth(player.Health / 100, playerHealthColor);

        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

        for(int i = 0; i < enemies.Length; i++) 
        {
            Enemy enemy = enemies[i].GetComponent<Enemy>();
            GameObject enemyHealthBar = Instantiate(healthBarPrefab, GameObject.FindGameObjectWithTag("Content").transform);
            HPElement enemyHPE = enemyHealthBar.GetComponent<HPElement>();
            enemyHPE.SetImage(enemyImage);
            enemyHPE.SetHealth(enemy.Health / 100, enemyHealthColor);
        }
    }
}
