using TMPro;
using UnityEngine;

public class UI_CoinDisplay : MonoBehaviour
{
    public CoinComponent coinComp;
    public TextMeshProUGUI coinText;

    private void Awake()
    {
        coinComp.CointAmountChanged += CoinComp_CoinAmountChanged;
    }


    private void CoinComp_CoinAmountChanged(float currentpoints, float amountChanged)
    {
        coinText.text = currentpoints.ToString();
    }
}
