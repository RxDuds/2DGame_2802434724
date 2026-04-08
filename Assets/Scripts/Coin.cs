using UnityEngine;

public class Coin : MonoBehaviour
{
    public AudioClip coinClip;
    public int coinValue;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Player player = collision.gameObject.GetComponent<Player>();
            player.pickupcoin(coinValue);
            
            Destroy(gameObject);
        }

    }
}
