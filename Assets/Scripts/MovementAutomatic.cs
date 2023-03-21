using System;
using UnityEngine;

public class MovementAutomatic : MonoBehaviour {
    enum TypeMovementBot { HorizontalBounce, VerticalBounce, HorizontalFromLeft, HorizontalFromRight, VerticalFromAbove, VerticalFromBelow }

    [SerializeField] TypeMovementBot typeMovementRobot;

    private Transform t;
    public float limXLeft = -2.2f;
    public float limXRight = 2.2f;
    public float limYTop = 0f;
    public float limYBottom = -1.9f;
    public float speed = 0.01f;
    private bool movingRight = true;
    private bool movingBottom = true;

    private void Awake() {
        t = GetComponent<Transform>();
    }

    private void Update() {

        try {
            switch (typeMovementRobot) {
                case TypeMovementBot.HorizontalBounce:
                    HorizontalBounce();
                    break;
                case TypeMovementBot.VerticalBounce:
                    VerticalBounce();
                    break;
                case TypeMovementBot.HorizontalFromLeft:
                    HorizontalFromLeft();
                    break;
                case TypeMovementBot.HorizontalFromRight:
                    HorizontalFromRight();
                    break;
                case TypeMovementBot.VerticalFromAbove:
                    VerticalFromAbove();
                    break;
                case TypeMovementBot.VerticalFromBelow:
                    VerticalFromBelow();
                    break;
            }
        } catch(Exception) {
            Debug.LogError("No se ha encontrado el componente Transform en el objeto actual");
        }

    }

    private void HorizontalBounce() {

        if (movingRight) {
            HorizontalFromLeft();
        } else {
            HorizontalFromRight();
        }

    }

    private void VerticalBounce() {

        if (movingBottom) {
            VerticalFromAbove();
        } else {
            VerticalFromBelow();
        }

    }

    private void HorizontalFromLeft() {

        if (t.position.x < limXRight) {
            t.position = new Vector3(t.position.x + speed, t.position.y);
        } else {
            movingRight = false;
        }

    }

    private void HorizontalFromRight() {

        if (t.position.x > limXLeft) {
            t.position = new Vector3(t.position.x - speed, t.position.y);
        } else {
            movingRight = true;
        }

    }

    private void VerticalFromAbove() {

        if (t.position.y > limYBottom) {
            t.position = new Vector3(t.position.x, t.position.y - speed);
        } else {
            movingBottom = false;
        }

    }

    private void VerticalFromBelow() {

        if (t.position.y < limYTop) {
            t.position = new Vector3(t.position.x, t.position.y + speed);
        } else {
            movingBottom = true;
        }

    }
}
