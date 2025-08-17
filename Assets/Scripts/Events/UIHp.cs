using UnityEngine;
using UnityEngine.UI;

public class UIHp : MonoBehaviour
{
    [SerializeField] private HPbar targetHealth;
    [SerializeField] private Slider slider;
    [SerializeField] private Image fillImage;
    [SerializeField] private Gradient colorByHealth;

    private void Reset()
    {
        slider = GetComponent<Slider>();

    }

    private void Start()
    {
        if (slider != null)
        {
            slider.minValue = 0f;
            slider.maxValue = 1f;
        }
    }
    private void Update()
    {
        if (targetHealth == null || slider == null) return;

        float t = targetHealth.Normalisasi;
        slider.value = t;

        if (fillImage != null && colorByHealth != null)
            fillImage.color = colorByHealth.Evaluate(t);
        
    }    
}