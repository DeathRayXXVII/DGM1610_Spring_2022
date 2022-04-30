using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAndShoot : MonoBehaviour
{
    public float speed; 
    public float stopDistance;// how far it get to the player
    public float retreatDistance; //how far it gets from the player
    private Transform target; //who are is our targt
    private float shotDelay;
    public float startDelay;
    public GameObject projectile; //projectile to shoot


    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        shotDelay = startDelay;
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(transform.position, target.position) > stopDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
        else if(Vector2.Distance(transform.position, target.position) < stopDistance && Vector2.Distance(transform.position, target.position) > retreatDistance)
        {
            transform.position = this.transform.position;
        }
        else if(Vector2.Distance(transform.position, target.position) < retreatDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, -speed * Time.deltaTime);
        }

        if(shotDelay <= 0)
        {
            Instantiate(projectile, transform.position, Quaternion.identity); 
            shotDelay = startDelay;
        }
        else 
        {
            shotDelay -= Time.deltaTime;
        }
    }
}
