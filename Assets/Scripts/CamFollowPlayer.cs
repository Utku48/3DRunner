using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollowPlayer : MonoBehaviour
{
    public Transform CamTarget;
    public float sSpeed = 10f;
    public Vector3 distance;
    public Transform lookTarget;

    private void LateUpdate()
    {
        Vector3 dPos = CamTarget.position + distance;
        Vector3 sPos = Vector3.Lerp(transform.position, dPos, sSpeed * Time.deltaTime);
        transform.position = sPos;
        transform.LookAt(lookTarget.position);
    }


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
