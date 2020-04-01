using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReceivingScoreAndHealthLoss : MonoBehaviour
{
    [SerializeField]
    private float _score; //Punktacja gracza która nie może być obniżona
    [SerializeField]
    private float _pointsTaken; //przelicznik punktów podwyższa się gdy gracz zbiera  
    [SerializeField]
    private float _multiplier = 0.1f;
    [SerializeField]
    private float _pointsOnBeginning = 1;
    [SerializeField]
    private int _currentHealth;
    [SerializeField]
    private int _maxHealth = 100;
    [SerializeField]
    private int _healthLoss = 20;

    private void Start()
    {
        _currentHealth = _maxHealth;
        _pointsTaken = _pointsOnBeginning;
    }
    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Debug.Log(hitInfo.tag);
        if (hitInfo.tag == "Collectible")
        {
            _score += _pointsTaken;
            _pointsTaken += _multiplier;
        }else if (hitInfo.tag == "Enemy")
        {
            _currentHealth -= _healthLoss;
            Check();
            _pointsTaken = _pointsOnBeginning;
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
     }
    private void Dead()
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }
}
