using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    public int state;
    public Transform thePlayer;
    private float waitWhileWalking;
    private float timeWhenWalking;
    public float baseWait = 5;
    public float baseWalkWait = 3;
    public float moveSpeed;
    public float chaseSpeed;
    public Rigidbody rb;
    private float attackTime;
    public GameObject theAttack;
    float x;
    float y;
    float z;
    Vector3 pos;
    public Animator anim;

    void Start()
    {
        state = 0;
        waitWhileWalking = baseWait;
        rb = GetComponent<Rigidbody>();
        timeWhenWalking = baseWalkWait;
        attackTime = 1.5f;
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if (state == 0)
        {
            Idle();
        }
        if (state == 1)
        {
            Walk();

        }
        if (state == 2)
        {
            Attack();
        }
        if (waitWhileWalking <= 0)
        {
            Debug.Log("waitOver");
            waitWhileWalking = baseWait;
            state = 2;
        }
    }
    void Idle()
    {
        //Debug.Log("isIdle");
        waitWhileWalking -= Time.deltaTime;
        x = Random.Range(-14.45f, 14.45f);
        z = Random.Range(-19, -0.73f);
        y = 0.5f;
        pos = new Vector3(x, y, z);
        anim.SetBool("IsRunning", false);
    }

    void Walk()
    {
        transform.LookAt(pos);
        transform.position = Vector3.MoveTowards(transform.position, pos, moveSpeed * Time.deltaTime);
        timeWhenWalking -= Time.deltaTime;
        if (timeWhenWalking <= 0)
        {
            state = 0 ;
            timeWhenWalking = baseWalkWait;
        }
        anim.SetBool("IsRunning", true);
    }
    void Attack()
    {
        // Quaternion toRotate = Quaternion.FromToRotation(transform.forward, thePlayer.position);
        // transform.rotation = Quaternion.Lerp(transform.rotation, toRotate, 15f * Time.deltaTime);
        //transform.LookAt(thePlayer);
        var rotation = Quaternion.LookRotation(thePlayer.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * 5f);
        transform.position += transform.forward * chaseSpeed * Time.deltaTime;
        attackTime -= Time.deltaTime;
        if (attackTime <= 0)
        {
            state = 1;
            attackTime = baseWait;
        }


    }
}

