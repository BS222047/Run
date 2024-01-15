using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform playerTransform; // Inspector からプレイヤーの Transform をアサインする
    public float xOffset = 3f;
    public float yOffset = 3f;

    void Update()
    {
        if(playerTransform != null)
        {
            float playerX = playerTransform.position.x;
            float playerY = playerTransform.position.y;
            Vector3 newPosition = new Vector3(playerX + xOffset, playerY + yOffset, -20.0f);
            transform.position = newPosition;
        }
    }
}
