using UnityEngine;
using System.Collections;

public class MoveEgg : MonoBehaviour {

    public GameObject JumpPanel;

    private float jumpTime;

    public bool jumpSwitch = false;

    public float nopeus = 3f;

    public float hyppyNopeus = 400f;

    public bool jump = false;

    void Update()
    {

        transform.Translate(Vector3.right * nopeus * Time.deltaTime);

        if (jump == true)
        {

            //   transform.Translate(Vector3.up * hyppyNopeus * Time.deltaTime);
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, hyppyNopeus));
            JumpPanel.SetActive(false);
            jumpSwitch = false;
            gameObject.GetComponent<PelaajaDiamond>().hyppyBool = false;
            jump = false;
        }
    }

    public void hyppaa() {
        jump = true;
    }
}
