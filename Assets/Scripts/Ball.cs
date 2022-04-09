using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Ball ball_spawn;
    public float speed = 3;
    Rigidbody rb; 
    Animator anim;
    Vector3 endpos;
    bool istr;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        istr = false; endpos = new Vector3(Random.Range(-30f, 30f), 1, Random.Range(-20f, 20f));
        //   Launch();
        // InvokeRepeating("Launch", 1.5f, 1.5f);
        // Vector3 endPos = new Vector3(Random.Range(-30f, 30f), 1, Random.Range(-20f, 20f));
        // transform.position = Vector3.Lerp(transform.position, endPos, Time.deltaTime);
    }
    private void Update()
    {
        
        if (Vector3.Distance(transform.position, endpos) > 1f)
        {
            Movepos(endpos);
        }
        else
        {
            endpos = new Vector3(Random.Range(-30f, 30f), 1, Random.Range(-20f, 20f)); Debug.Log(endpos);
        }
    }
    private void Movepos(Vector3 target)
    {
        // Vector3 dir = target - transform.position;
        //   Quaternion rotation = Quaternion.LookRotation(-dir, Vector3.up);
        //  transform.rotation = rotation;
        // transform.Translate(dir * speed * Time.deltaTime, Space.World);

        Vector3 targetDirection = target - transform.position ;

        // The step size is equal to speed times frame time.
        float singleStep = speed * Time.deltaTime;

        // Rotate the forward vector towards the target direction by one step
        Vector3 newDirection = Vector3.RotateTowards(transform.forward, -targetDirection, singleStep, 0.0f);
        transform.rotation = Quaternion.LookRotation(newDirection);
        //  transform.position += -transform.forward * Time.deltaTime*speed;
        rb.AddRelativeForce(-Vector3.forward * speed);
        // transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * 10);
    }
    void Launch()
    {
        float x = Random.Range(-6f, 6f);
        float z = Random.Range(-6f, 6f);
        
        if (x == 0)
        {
            x = 1;
        }
        if (z == 0)
        {
            z = -1;
        }
        Vector3 target= new Vector3(x * speed, 0, z * speed);
        rb.velocity = new Vector3(x * speed, 0, z * speed);




        Vector3 dir = target - transform.position;
        Quaternion rotation = Quaternion.LookRotation(-dir , Vector3.up);
        transform.rotation = rotation;
        transform.Translate(dir * speed * Time.deltaTime, Space.World);
    }


}
