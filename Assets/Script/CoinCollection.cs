using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class coinCollection : MonoBehaviour
{
    private int Coin = 0;

    public TextMeshProUGUI coinText;
    public void OnTriggerEnter(Collider other)
    {
        {
            if (other.transform.tag == "coinKuning")
            {
                Coin = Coin + 30;
                coinText.text = "Score: " + Coin.ToString();
                Debug.Log(Coin);
                Destroy(other.gameObject);
            }

            if (other.transform.tag == "coinMerah")
            {
                Coin = Coin + 20;
                coinText.text = "Score: " + Coin.ToString();
                Debug.Log(Coin);
                Destroy(other.gameObject);
            }

            if (other.transform.tag == "coinHijau")
            {
                Coin = Coin + 100;
                coinText.text = "Score: " + Coin.ToString();
                Debug.Log(Coin);
                Destroy(other.gameObject);
            }

            if (other.transform.tag == "coinBiru")
            {
                Destroy(other.gameObject);
                //HealthSystem.Instance.HealDamage(10);
            }

            if (other.transform.tag == "coinHitam")
            {
                Destroy(other.gameObject);
                //HealthSystem.Instance.TakeDamage(20);
            }
        }
    }

}