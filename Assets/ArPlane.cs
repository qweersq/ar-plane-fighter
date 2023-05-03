using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ArPlane : MonoBehaviour
{
    public void ARPlane (string ARPlane) {
        SceneManager.LoadScene("ARPlane");
    }
}
