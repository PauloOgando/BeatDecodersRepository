using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInitializer : MonoBehaviour
{
    /// <summary>
    /// Awake is called before Start
    /// </summary>
    void Awake()
    {
        // initialize configuration data
        LevelSelectUtils.Initialize();
        ConfigurationUtils.Initialize();
    }
}
