using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    float projectileSpeed;
    [SerializeField] PlayerRun playerRun;
    bool EnemeyRight = true;
    Rigidbody2D rb;


    private void Awake()
    {
       gameObject.GetComponent<PlayerShooter>();
       rb = GetComponent<Rigidbody2D>();
       playerRun = FindObjectOfType<PlayerRun>();
        
    }

    private void Start()
    {
        playerRun.OnFlipEvent += PlayerRun_OnFlipEvent;

        projectileSpeed = PlayerStatics.Instance.projectileSpeed;

    }

    private void PlayerRun_OnFlipEvent(object sender, System.EventArgs e)
    {
        Flip();
        EnemeyRight = playerRun.facingRight;
    }

    void Update()
    {

        projectileSpeed = PlayerStatics.Instance.projectileSpeed;
        

        if (EnemeyRight != playerRun.facingRight)
        {
            Flip();
            EnemeyRight = playerRun.facingRight;
        }

        

        if (EnemeyRight == false)
        {
            rb.velocity = transform.right * projectileSpeed;

        }
        else
        {
            rb.velocity = transform.right * -1 * projectileSpeed;
  
        }

        if (transform.position.x > 4.5 || transform.position.x < -4.5)
        {
            gameObject.SetActive(false);
        }
        
    }

    

    public void Flip()
    {

        spriteRenderer.flipX = EnemeyRight;

    }

    private void OnDestroy()
    {
        playerRun.OnFlipEvent -= PlayerRun_OnFlipEvent;
    }

}
