using UnityEngine;

public class Buy : MonoBehaviour
{
    public int price;
    public int amount;
    public Transform shopgui;

    public void back()
    {
        shopgui.gameObject.SetActive(false);
    }
    public void purchase_healthkit()
    {         
        Player player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        if(player.coins >= price)
        {
            player.pickupcoin(-price);
            
            player.healthkit += amount;
            player.healthkitText.text = player.healthkit.ToString();
        }
    }

    public void purchase_jump()
    {
        Player player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        if(player.coins >= price)
        {
            player.pickupcoin(-price);
            
            player.extraJumpValue += amount;
        }
    }

    public void purchase_speed()
    {
        Player player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        if(player.coins >= price)
        {
            player.pickupcoin(-price);
            
            player.moveSpeed += amount;
        }
    }   

}
