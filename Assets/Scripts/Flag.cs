using UnityEngine;

public class Flag : MonoBehaviour
{
    public GameObject Goalpanel;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Time.timeScale = 0f;
            Goalpanel.SetActive(true);

        }
    }
}
