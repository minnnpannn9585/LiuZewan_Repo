using UnityEngine;

public class CoinRotation : MonoBehaviour
{
    [Header("旋转设置")]
    [SerializeField] private float rotationSpeed = 100f; // 旋转速度

    void Update()
    {
        // 围绕Y轴旋转
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }
}