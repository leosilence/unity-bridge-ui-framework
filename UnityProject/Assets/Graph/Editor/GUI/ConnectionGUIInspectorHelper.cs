using UnityEngine;
using System.Collections.Generic;

using Model=NodeGraph.DataModel.Version2;

namespace NodeGraph {
	/*
	 * ScriptableObject helper object to let ConnectionGUI edit from Inspector
	 */
	public class ConnectionGUIInspectorHelper : ScriptableObject {
		public ConnectionGUI connectionGUI;
		//public Dictionary<string, List<AssetReference>> assetGroups;
		public List<bool> foldouts;
		public bool fileNameOnly;
		public string filterPattern;

		public void UpdateInspector (ConnectionGUI con) {
			this.connectionGUI = con;
			//this.assetGroups = assetGroups;

			this.foldouts = new List<bool>();
			//if(assetGroups != null) {
			//	for (var i = 0; i < this.assetGroups.Count; i++) {
			//		foldouts.Add(true);
			//	}
			//}
		}

		//public void UpdateAssetGroups(Dictionary<string, List<AssetReference>> assetGroups) {
		//	this.assetGroups = assetGroups;
  //      }
    }
}
