﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {
	
	List<RepData> repListComplete = new List<RepData>();
	public List<PlayerData> allPlayers = new List<PlayerData>();
	RepManager rm;
	// Use this for initialization
	void Start () {
		populatePlayerList();
		try
		{
			rm = GameObject.Find("RepManager").GetComponent<RepManager>();
			rm.PopulateRepList();
		}
		catch
		{
			Debug.Log("No Rep Manager");
		}
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	public void populatePlayerList()
	{
		//This will be where we create the player objects
		GameObject[] tempPlayers = GameObject.FindGameObjectsWithTag("Player");
		foreach(GameObject p in tempPlayers)
		{
			allPlayers.Add(p.GetComponent<PlayerData>());
		}
		
	}
	
	public void populatePlayerRepLists(List<RepData> fullList)
	{
		foreach(PlayerData p in allPlayers)
		{
			p.repList = fullList;
		}
	}
	
	public void addNewRepObject(RepData newRep)
	{
		foreach(PlayerData p in allPlayers)
		{
			p.repList.Add(newRep);
		}
	}
	
	public void removeRepObject(RepData repObj)
	{
		foreach(PlayerData p in allPlayers)
		{
			p.repList.Remove(repObj);
		}
	}
}