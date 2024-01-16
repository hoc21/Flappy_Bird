using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject pipe;
    public float maxTime;
    float timer;
    public float height;
    private void Update()
    {
        if (timer > maxTime)
        {
            GameObject tmp = Instantiate(pipe,new Vector3(transform.position.x,transform.position.y +Random.Range(-height,height),0), Quaternion.identity);
            Destroy(tmp, 15f);

            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
