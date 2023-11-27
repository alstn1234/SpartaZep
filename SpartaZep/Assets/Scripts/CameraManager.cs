using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;

    private void Update()
    {

        transform.position = new Vector3(playerTransform.position.x, playerTransform.position.y, -10);
    }
}
