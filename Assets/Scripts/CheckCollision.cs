using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CheckCollision : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI coinText;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("coin"))
        {
            //Debug.Log("CoinCollected");
            AddCoin();
            other.gameObject.SetActive(false);
        }
    }

    public void AddCoin()
    {
        score++;
        coinText.text = "Score: " + score.ToString();
    }
}
