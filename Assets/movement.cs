using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody2D CarRigidbody;
    Vector2 CarAccelerate = new Vector2(50, 0);
    Vector2 CarReverse = new Vector2(40, 0);
    Vector2 CarJump = new Vector2(0, 125);

    float jumpcooldown = 1f;

    void Update()
    {
        jumpcooldown -= Time.deltaTime;

        if (Input.GetKey(KeyCode.A))
        {
            CarRigidbody.AddForce(-CarReverse, ForceMode2D.Force);
        }
        if (Input.GetKey(KeyCode.D))
        {
            CarRigidbody.AddForce(CarAccelerate, ForceMode2D.Force);
        }

        if(jumpcooldown <= 0)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                CarRigidbody.AddForce(CarJump, ForceMode2D.Impulse);
                jumpcooldown = 1f;
            }
        }
            
        
       
    }

    

   
}