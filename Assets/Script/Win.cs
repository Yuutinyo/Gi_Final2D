using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject winScreen;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        winScreen.SetActive(true);
    }
}
