using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameManager : MonoBehaviour
{
    public GameObject target;
    public ParticleSystem hitEffect;
    public GameObject killEffect;
    //public GameObject winEffect;
    //public GameObject winPos;
    public int score;
    new Transform camera;

    void Start()
    {
        camera = Camera.main.transform;
        score = 0;
    }
    void Update()
    {
        bool isHitting = false;
        Ray ray = new Ray(camera.position, camera.rotation * Vector3.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.tag == "Safe")
            {
                isHitting = true;
            }
        }
        if (isHitting)
        {
            hitEffect.transform.position = hit.point;
            if (hitEffect.isStopped)
            {
                hitEffect.Play();
            }
        }
        /*else
        {
            if(hit.collider.tag == "Wall")
            {
                // reset
                hitEffect.Stop();
                Instantiate(killEffect, target.transform.position, target.transform.rotation);
            }
            if (hit.collider.tag == "Goal")
            {
                // reset
                hitEffect.Stop();
                Instantiate(winEffect, winPos.transform.position, winPos.transform.rotation);
            }

        }*/
    }
    void SetRandomPosition()
    {
        float x = Random.Range(-5.0f, 5.0f);
        float z = Random.Range(-5.0f, 5.0f);
        target.transform.position = new Vector3(x, 0.0f, z);
    }
}
