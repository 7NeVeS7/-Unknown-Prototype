using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReceivingScoreAndHealthLoss : MonoBehaviour
{
    [SerializeField]
    private int _score; //Punktacja gracza która nie może być obniżona
    [SerializeField]
    private int _pointsTaken; //przelicznik punktów podwyższa się gdy gracz zbiera  
    [SerializeField]
    private int _multiplier = 10; //wartość mnożnika
    private int _pointsOnBeginning = 100;
    [SerializeField]
    private int _currentHealth;
    [SerializeField]
    private int _maxHealth = 100;
    [SerializeField]
    private int _healthLoss = 20;
    [SerializeField]
    private HealthBar healthBar;
    [SerializeField]
    private Score score;
    [SerializeField]
    private Multi multi;
    private SpriteRenderer _rend;
    private Sprite blueSprite, yellowSprite, redSprite;
    private string _myColor;
    [SerializeField]
    private int _colorChange=3;
    private int i; //used for changing color method;
    private void Start()
    {
        _rend = GetComponent<SpriteRenderer>();
        blueSprite = Resources.Load<Sprite>("Blue");
        yellowSprite = Resources.Load<Sprite>("Yellow");
        redSprite = Resources.Load<Sprite>("Red");
        Debug.Log(_rend.sprite.name);
        //ColorChange();

        _currentHealth = _maxHealth;
        _pointsTaken = _pointsOnBeginning;
        healthBar.SetHealth(_maxHealth);
    }
    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        
        if (hitInfo.tag == _rend.sprite.name) //collectible trigger
        {
            _score += _pointsTaken;
            _pointsTaken += _multiplier;
           score.SetScore(_score);
           multi.SetMulti(_pointsTaken);
            healthBar.SetHealth(_currentHealth);
        }
        else if (hitInfo.tag != _rend.sprite.name) //Enemy trigger
        {
            _currentHealth -= _healthLoss;
            Check();
            _pointsTaken = _pointsOnBeginning;
            multi.SetMulti(_pointsTaken);
        }
        i++;
        if (i==_colorChange) 
        {
            ColorChange();
        }

       // Debug.Log("Damage taken by" + hitInfo.tag + "to" + _rend.sprite);
     }
    private void Check()
    {
        if (_currentHealth > _maxHealth)
        {
            _currentHealth = _maxHealth;
        }
        else if (_currentHealth <= 0)
        {
            Dead();
        }
        healthBar.SetHealth(_currentHealth);
    }
    private void ColorChange()
    {
        
        _rend.sprite = blueSprite;
        i=0;
    }
    private void Dead()
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }
}