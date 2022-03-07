using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TaxSlider : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    [SerializeField] private TextMeshProUGUI _sliderText;

    public static Village village;
    // Start is called before the first frame update
    void Start()
    {
        Text villageExpInc = GameObject.Find("Expected Income").GetComponent<Text>();
        _slider.value = village.Tax;
        _sliderText.text = village.Tax.ToString();
        _slider.onValueChanged.AddListener((v) => {
            _sliderText.text = v.ToString();
            village.Tax = (int) v;
            string villageExpGold = "<color=#00FF00>" + (village.CalculatePopTax() + village.CalculateResourceIncome()).ToString() + "</color>";
            string villageExpLumber = "<color=#00FF00>" + village.CalculateLumberIncome().ToString() + "</color>";
            villageExpInc.text = "Expected Income: " + villageExpGold + " gold, " + villageExpLumber + " lumber";
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
