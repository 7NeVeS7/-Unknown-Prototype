using UnityEngine;
using UnityEngine.UI;

public class Multi : MonoBehaviour
{
    private float _multi;
    public Text multiText;
    private void Start()
    {
        multiText.text = "x1";
    }
    public void SetMulti(int Multi)
    {
        _multi = Multi;
        //Debug.Log(Multi);
        _multi /= 100;

        //Debug.Log(Multi);
        multiText.text = "x" + _multi.ToString();
    }
}
