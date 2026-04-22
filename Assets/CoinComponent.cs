using UnityEngine;

public class CoinComponent : MonoBehaviour
{

    private float points;

    public delegate void CoinEventHandler(float currentPoints, float amountChanged);
    public event CoinEventHandler CointAmountChanged;

    private void Start()
    {
        AddPoints(0);
    }

    public void AddPoints(float amount)
        {
        points += amount;
        CointAmountChanged?.Invoke(points, amount);
         }
}
