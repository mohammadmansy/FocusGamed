using System.Collections;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class CircleController : MonoBehaviour
{
    public float lifeTime = 3f; // Time the circle will stay on the screen before disappearing
    private void Start()
    {
        // Start a coroutine to destroy the circle after 'lifeTime' seconds
        StartCoroutine(DestroyAfterLifetime());
    }

    private IEnumerator DestroyAfterLifetime()
    {
        yield return new WaitForSeconds(lifeTime);
        Destroy(gameObject);
    }

    private void OnMouseDown()
    {
        // Called when the circle is clicked/touched
        // You can add any other functionality you need here, e.g., incrementing score
        Destroy(gameObject);
        Debug.Log("Clicked");
        scoreManager.Instance.AddPoint();
    }
}