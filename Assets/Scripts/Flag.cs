using Unity.VisualScripting;
using UnityEngine;

public class Flag : MonoBehaviour
{
    public GameObject Goalpanel;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Player player = collision.gameObject.GetComponent<Player>();
            player.save();
            Time.timeScale = 0f;
            Goalpanel.SetActive(true);

        }
    }
}
