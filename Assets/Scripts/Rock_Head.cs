using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock_Head : MonoBehaviour
{
    public float startSpeed; // Tốc độ ban đầu
        public float maxSpeed; // Tốc độ tối đa
        public float acceleration ; // Tốc độ tăng lên
    
        private float currentSpeed; // Tốc độ hiện tại
    
        private void Start()
        {
            currentSpeed = startSpeed; // Khởi tạo tốc độ ban đầu
            StartCoroutine(MoveCoroutine());
        }
    
        private IEnumerator MoveCoroutine()
        {
            while (currentSpeed < maxSpeed)
            {
                transform.Translate(Vector2.right * (-1) * currentSpeed * Time.deltaTime);
                currentSpeed += acceleration * Time.deltaTime;
                yield return null;
            }
        }
        public float minX = -2f; // Giới hạn X tối thiểu
        public float maxX = 2f; // Giới hạn X tối đa
        public float moveSpeed = 2f; // Tốc độ di chuyển
    
}
