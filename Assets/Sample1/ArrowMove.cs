using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMove : MonoBehaviour
{
    public float speed = 5f;

    // Update is called once per frame
    private void Update()
    {
        //////���1
        //Vector3 position = transform.position;
        //position.z = position.z + speed * Time.deltaTime;

        //// �ٽ� �Ҵ� ��������!
        //transform.position = position;

        //// ���2
        transform.Translate(0, 0, speed * Time.deltaTime);
    }
}