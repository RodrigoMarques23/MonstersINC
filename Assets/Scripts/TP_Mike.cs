using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TP_Mike : MonoBehaviour {

    public Transform teleportDestination;
    public Transform teleportDestination2;
    public Transform teleportDestination3;
    public Transform teleportDestination4;

    // Start is called before the first frame update
    void Start() {


    }

    // Update is called once per frame
    void Update() {



    }
    void OnTriggerStay2D(Collider2D c) {

        //amarelas
        if (c.gameObject.tag == "TPAM" && Input.GetKey(KeyCode.W)) {
            transform.position = teleportDestination.position;
        } else if (c.gameObject.tag == "TPAM2" && Input.GetKey(KeyCode.S)) {
            transform.position = teleportDestination2.position;
        }

          //azuis
          else if (c.gameObject.tag == "TPAZ" && Input.GetKey(KeyCode.W)) {
            transform.position = teleportDestination3.position;
        } else if (c.gameObject.tag == "TPAZ2" && Input.GetKey(KeyCode.S)) {
            transform.position = teleportDestination4.position;
        }

          //vermelha
          else if (c.gameObject.tag == "TPV") {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +2);
        }
    }


}




