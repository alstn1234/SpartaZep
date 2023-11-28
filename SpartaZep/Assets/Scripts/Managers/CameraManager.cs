using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField] private Transform target;

    private float _zPos = -10;
    private void Update()
    {
        Vector3 cameraPos = new Vector3(target.position.x, target.position.y, _zPos);
        transform.position = cameraPos;
    }
}
