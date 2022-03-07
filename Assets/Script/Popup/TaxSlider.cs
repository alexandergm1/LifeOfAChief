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
        Debug.Log(village.Tax);
        _slider.value = village.Tax;
        _sliderText.text = village.Tax.ToString();
        _slider.onValueChanged.AddListener((v) => {
            _sliderText.text = v.ToString();
            village.Tax = (int) v;
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
