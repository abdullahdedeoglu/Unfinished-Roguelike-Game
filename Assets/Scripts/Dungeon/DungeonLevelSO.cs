using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CreateAssetMenu(fileName = "DungeonLevel_", menuName = "Scriptable Objects/Dungeon/Dungeon Level")]
public class DungeonLevelSO : ScriptableObject
{
    #region Header BASIC LEVEL DETAILS
    [Space(10)]
    [Header("BASIC LEVEL DETAILS")]
    #endregion Header BASIC LEVEL DETAILS

    #region Tooltip
    [Tooltip("The name for the level")]
    #endregion Tooltip

    public string levelName;

    #region Header ROOM TEMPLATES FOR LEVEL
    [Space(10)]
    [Header("ROOM TEMPLATES FOR LEVEL")]
    #endregion Header ROOM TEMPLATES FOR LEVEL

    public List<RoomTemplateSO> roomTemplateList;

    public List<RoomNodeGraphSO> roomNodeGraphList;

    #region Validation
#if UNITY_EDITOR
    //private void OnValidate()
    //{
    //    HelperUtilities.ValidateCheckEmptyString(this, nameof(levelName), levelName);
    //    if (HelperUtilities.ValidateCheckEnumerableValues(this, nameof(roomTemplateList), roomTemplateList))
    //        return;
    //    if (HelperUtilities.ValidateCheckEnumerableValues(this, nameof(roomNodeGraphList), roomNodeGraphList))
    //        return;

    //    bool isEWCorridor = false;
    //    bool isNSCorridor = false;
    //    bool isEntrance = false;

    //    foreach (RoomTemplateSO roomTemplate in roomTemplateList)
    //    {
    //        if (roomTemplate == null)
    //            return;

    //        if (roomTemplate.roomNodeType.isCorridorEW)
    //            isEWCorridor = true;

    //        if(roomTemplate.roomNodeType.isCorridorNS)
    //            isNSCorridor = true;

    //        if(roomTemplate.roomNodeType.isEntrance)
    //            isEntrance = true;
    //    }

    //    if (!isEWCorridor)
    //        Debug.Log("In" + this.name.ToString() + " : No EW Corridor");

    //    if (!isNSCorridor)
    //        Debug.Log("In" + this.name.ToString() + " : No NS Corridor");

    //    if (!isEntrance)
    //        Debug.Log("In" + this.name.ToString() + " : No Entrance");

    //    foreach (RoomNodeGraphSO roomNodeGraph in roomNodeGraphList)
    //    {
    //        if (roomNodeGraph == null)
    //            return;
    //        foreach (RoomNodeSO roomNode in roomNodeGraph.roomNodeList)
    //        {
    //            if (roomNode == null)
    //                continue;

    //            if (roomNode.roomNodeType.isCorridor || roomNode.roomNodeType.isCorridorEW ||
    //                roomNode.roomNodeType.isCorridorNS || roomNode.roomNodeType.isEntrance || roomNode.roomNodeType.isNone)
    //                continue;

    //            bool isRoomNodeTypeFound = false;

    //            foreach (RoomTemplateSO roomTemplate in roomTemplateList)
    //            {
    //                if (roomTemplate == null) continue;

    //                if(roomTemplate.roomNodeType == roomNode.roomNodeType)
    //                {
    //                    isRoomNodeTypeFound = true;
    //                    break;
    //                }
    //            }

    //            if (!isRoomNodeTypeFound)
    //            {
    //                Debug.Log("In" + this.name.ToString() + " :No room template" + roomNode.roomNodeType.name.ToString() + " found for node graph"
    //                    + roomNodeGraph.name.ToString());
    //            }
    //        }
    //    }
    //}

#endif
    #endregion Validation

}
