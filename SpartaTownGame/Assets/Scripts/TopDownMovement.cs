using System;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    private TopDownController movementController;
    private Rigidbody2D movementRigidbody;

    private Vector2 movementDirection = Vector2.zero;

    private void Awake()
    {
        movementController = GetComponent<TopDownController>();
        movementRigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        movementController.OnMoveEvent += Move;
        // OnMoveEvent에 Move를 호출하라고 등록
    }

    private void Move(Vector2 direction)
    {
        // 이동방향만 정하고 실제 움직임 x
        // 움직이는건 FixedUpdate에서 진행 (rigidbody가 물리니까)
        movementDirection = direction;
    }

    private void FixedUpdate()
    {
        // 물리 업데이트에서 움직임 적용
        ApplyMovement(movementDirection);
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * 5;

        movementRigidbody.velocity = direction;
    }
}