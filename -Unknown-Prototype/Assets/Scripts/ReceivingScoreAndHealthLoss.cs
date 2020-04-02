using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    public HealthBar healthBar;
    public Score score;
    public Multi multi;

    private void Start()
    {
        _currentHealth = _maxHealth;
        _pointsTaken = _pointsOnBeginning;
        healthBar.SetHealth(_maxHealth);
    }
    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Debug.Log(hitInfo.tag);
        if (hitInfo.tag == "Collectible")
        {
            _score += _pointsTaken;
            _pointsTaken += _multiplier;
           score.SetScore(_score);
           multi.SetMulti(_pointsTaken);
            healthBar.SetHealth(_currentHealth);
        }
        else if (hitInfo.tag == "Enemy")
        {
            _currentHealth -= _healthLoss;
            Check();
            _pointsTaken = _pointsOnBeginning;
            multi.SetMulti(_pointsTaken);
        }
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
    private void Dead()
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }
}
