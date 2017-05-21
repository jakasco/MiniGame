using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MoveWithButtons : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public GameObject pelaaja;

    public float nopeus = 3.0f;

    public bool ylos = false;
    public bool alas = false;
    public bool ylosDown = false;
    public bool alasDown = false;
    bool _pressed = false;

    public void OnPointerDown(PointerEventData eventData)
    {
        _pressed = true;

    }

    public void OnPointerUp(PointerEventData eventData)
    {
        _pressed = false;
        ylosDown = false;
        alasDown = false;
    }

    void Update()
    {
        GameObject osunut = GameObject.FindGameObjectWithTag("Osunut");
        if (!_pressed)
            return;

        if (ylos == true)
        {
            ylosDown = true;

        //    if (pelaaja.gameObject.tag == "Osunut")
           // {
         //   GameObject osunut = GameObject.FindGameObjectWithTag("Osunut");
                osunut.transform.Translate(-Vector3.down * nopeus * Time.deltaTime);

          //  }

        }
        if (alas == true)
        {
            alasDown = true;

                osunut.transform.Translate(-Vector3.up * nopeus * Time.deltaTime);
                if (osunut.GetComponent<PlayerCollisionHissi>().pelaajaYli == false)
                {
                    osunut.tag = "Osunut";
                }
                else {
                    osunut.tag = "kaytetty";
                }
        }
    }
}
