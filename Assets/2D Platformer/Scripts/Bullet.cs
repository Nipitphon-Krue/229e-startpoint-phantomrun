using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody2D rb;

  
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    //ถ้ากระสุนโดนเป้าหมายต่างๆ
    private void OnTriggerEnter2D(Collider2D bullet)
    {
        
            //เมื่อกระสุนโดนศัตรู
        if (bullet.CompareTag("Enemy"))
        { 
            Destroy(bullet.gameObject);
            
            Destroy(gameObject);
        }


    }
}

 
