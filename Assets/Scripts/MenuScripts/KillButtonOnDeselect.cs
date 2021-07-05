using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class KillButtonOnDeselect : MonoBehaviour, IDeselectHandler
{
    public void OnDeselect(BaseEventData data)
    {
        Destroy(gameObject);
    }
}
