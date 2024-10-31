using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    public int totalCoins = 0; // Total de moedas coletadas
    public Text coinText; // Referência ao texto da UI que exibirá a quantidade de moedas

    void Start()
    {
        UpdateCoinText();
    }

    public void AddCoin()
    {
        totalCoins++;
        UpdateCoinText();
    }

    void UpdateCoinText()
    {
        coinText.text = "Moedas: " + totalCoins.ToString();
    }
}
