using UnityEngine;
using System.Collections; // Add this line to fix the error

public class SpinCoin : MonoBehaviour
{
    public float rotationSpeed = 100f;

    private void Start()
    {
        // Start the coroutine to spin the coin
        StartCoroutine(Spin());
    }

    private IEnumerator Spin()
    {
        while (true)
        {
            // Rotate the coin around its local Z-axis
            transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime, Space.Self);

            // Wait for the next frame
            yield return null;
        }
    }
}
