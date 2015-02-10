﻿using UnityEngine;
using System.Collections;

[System.Serializable]
public class MissionData
{
    public SkillsHolder requiredCombinedSkills { get; set; }
    public int monetaryReward { get; set; }
    public int itemRewardAmount { get; set; }
    public string itemRewardName { get; set; }
    public Continent location { get; set; }
    public string type { get; set; }
    public int amountOfAgents { get; set; }
    public float timeLimit { get; set; }
    public string cilentName { get; set; }
    public string missionName { get; set; }

    public MissionData(string missionName, SkillsHolder requiredCombinedSkills, int monetaryReward, int itemRewardAmount, string itemRewardName, Continent location, string type, int amountOfAgents, float timeLimit, string cilentName)
    {
        this.missionName = missionName;
        this.requiredCombinedSkills = requiredCombinedSkills;
        this.monetaryReward = monetaryReward;
        this.itemRewardAmount = itemRewardAmount;
        this.itemRewardName = itemRewardName;
        this.location = location;
        this.type = type;
        this.amountOfAgents = amountOfAgents;
        this.timeLimit = timeLimit;
        this.cilentName = cilentName;
    }
}