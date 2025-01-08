using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class HUD : MonoBehaviour
{
    #region Fields
    [SerializeField]
    GameObject missionTextGameObject;
    const string missionTextPrefix = "Mission: ";
    int lifeCount = 3;
    [SerializeField] List<GameObject> lifeIcons = new List<GameObject>();

    LastLifeLost lastLifeLost = new LastLifeLost();
    #endregion

    #region Properties
    public int LifeCount
    {
        get { return lifeCount; }
    }

    #endregion

    #region Unity Methods
    void Start()
    {
        Text missionText = missionTextGameObject.GetComponent<Text>();
        missionText.text = missionTextPrefix + ConfigurationUtils.missionName;
        EventManager.AddLifeLostListener(LoseLife);
        EventManager.AddLastLifeLostInvoker(this);
    }

    #endregion

    void LoseLife()
    {
        lifeCount--;
        lifeIcons[lifeCount].SetActive(false);
        if (lifeCount == 0)
        {
            lastLifeLost.Invoke();
        }
    }

    /// <summary>
    /// Adds the given script as a last life lost listener
    /// </summary>
    /// <param name="listener">listener</param>
    public void AddLastLifeLostListener(UnityAction listener)
    {
        lastLifeLost.AddListener(listener);
    }


}
