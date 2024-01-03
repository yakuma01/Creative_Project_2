using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    { 
        var x = player.forward;
        var y = player.up;
        var z = player.position;
        z += x * offset.x;
        z += y * offset.y;
        transform.rotation = player.rotation;
        transform.position = z;
    }
}
