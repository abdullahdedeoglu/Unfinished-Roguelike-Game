using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerDetails_", menuName = "Scriptable Objects/Player/Player Details")]
public class PlayerDetailsSO : ScriptableObject
{
    #region PLAYER BASE DETAILS
    [Header("PLAYER BASE DETAILS")]
    #endregion PLAYER BASE DETAILS
    public string playerCharacterName;
    
    public GameObject playerPrefab;

    public RuntimeAnimatorController runtimeAnimatorController;

    #region PLAYER HEALTH
    [Header("PLAYER HEALTH")]
    #endregion PLAYER HEALTH

    public int playerHealthAmount;

    #region OTHER STUFF
    [Header("OTHER STUFF")]
    #endregion OTHER STUFF

    public Sprite playerMiniMapIcon;

    public Sprite playerHandSprite;

    #region VALIDATION
#if UNITY_EDITOR

    private void OnValidate()
    {
        HelperUtilities.ValidateCheckEmptyString(this, nameof(playerCharacterName), playerCharacterName);
        HelperUtilities.ValidateCheckNullValues(this, nameof(playerPrefab), playerPrefab);
        HelperUtilities.ValidateCheckNullValues(this, nameof(runtimeAnimatorController), runtimeAnimatorController);
        HelperUtilities.ValidateCheckPositiveValues(this, nameof(playerHealthAmount), playerHealthAmount, false);
        HelperUtilities.ValidateCheckNullValues(this, nameof(playerMiniMapIcon), playerMiniMapIcon);
        HelperUtilities.ValidateCheckNullValues(this, nameof(playerHandSprite), playerHandSprite);

    }

#endif
    #endregion VALIDATION
}
