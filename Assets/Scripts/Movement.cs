using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public enum TipoMovimiento { tup, tdown, tleft, tright, tpush }
    public TipoMovimiento tipoMovimiento { get; set; }
    Vector3 p;
    [SerializeField] List<Vector2> Psubir;
    public int counterx = 0;
    public int countery = 0;

    Movement() {
        _step = 0.7f;
    }

    public float _step { get; }

    public void Move(Transform t, TipoMovimiento tm) {
        
        
        switch (tm) {
            case TipoMovimiento.tup:
                if ((counterx == 0 && countery == 0) || (counterx == 4 && countery == 1) || (counterx == 4 && countery == 2) || (counterx == 4 && countery == 3))
                {
                    p = new Vector3(t.position.x, t.position.y + _step);
                    countery += 1;
                }
                if (counterx == 0 && countery == 4)
                {
                    p = new Vector3(t.position.x, t.position.y + _step * 2);
                    countery += 1;
                }
                break;
            case TipoMovimiento.tdown:
                if (countery == 5)
                {
                    p = new Vector3(t.position.x, t.position.y - _step * 2);
                    countery -= 1;
                } else if ((counterx == 0 && countery == 1) || (counterx == 4 && countery == 2) || (counterx == 4 && countery == 3) || (counterx == 4 && countery == 4))
                {
                    p = new Vector3(t.position.x, t.position.y - _step);
                    countery -= 1;
                }
                break;
            case TipoMovimiento.tleft:
                if (counterx > -1 && countery != 3)
                {
                    p = new Vector3(t.position.x - _step, t.position.y);
                    counterx -= 1;
                }
                break;
            case TipoMovimiento.tright:
                if (counterx < 4)
                {
                    p = new Vector3(t.position.x + _step, t.position.y);
                    counterx += 1;
                }
                break;
            case TipoMovimiento.tpush:
                p = new Vector3(t.position.x, t.position.y + _step);
                break;
        }

        t.position = p;

    }

}
