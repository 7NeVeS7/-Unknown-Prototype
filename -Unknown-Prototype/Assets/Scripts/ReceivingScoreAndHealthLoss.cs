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
    private SpriteRenderer _rend;
    private Sprite _blueSprite, _yellowSprite, _redSprite;
    private Sprite[] _color = new Sprite[3];
    private string _myColor;
    private int i = 0; //zmiana kolorów
    [SerializeField]
    private int _colorChange =3;

    private void Start()
    {   
        //sprite settings
        _rend = GetComponent<SpriteRenderer>();
        _color[0] = Resources.Load<Sprite>("Blue");
        _color[1] = Resources.Load<Sprite>("Yellow");
        _color[2] = Resources.Load<Sprite>("Red");


        //_blueSprite = Resources.Load<Sprite>("Blue");
        //_yellowSprite = Resources.Load<Sprite>("yellow");
        //_redSprite = Resources.Load<Sprite>("Red");
        Debug.Log(_rend.sprite.name);
        
        _myColor = _rend.sprite.name;

        //Hp settings
        _currentHealth = _maxHealth;
        _pointsTaken = _pointsOnBeginning;
        healthBar.SetHealth(_maxHealth);
    }
    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Debug.Log(hitInfo.tag);
        if (hitInfo.tag == _myColor)
        {
            _score += _pointsTaken;
            _pointsTaken += _multiplier;
           score.SetScore(_score);
           multi.SetMulti(_pointsTaken);
            healthBar.SetHealth(_currentHealth);
        }
        else if (hitInfo.tag != _myColor)
        {
            _currentHealth -= _healthLoss;
            Check();
            _pointsTaken = _pointsOnBeginning;
            multi.SetMulti(_pointsTaken);
        }
        i++;
        if (i == _colorChange)
        {
            _rend.sprite = _color[UnityEngine.Random.Range(0, 3)];
            _myColor = _rend.sprite.name;
            i = 1;
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
