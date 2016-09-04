using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;

namespace inventoryMagic {
	public class IISScriptableObjectDatabase<T> : ScriptableObject where T: class {

		[SerializeField] List<T> database = new List<T>();

		public void Add (T row) { 
			database.Add (row);
			EditorUtility.SetDirty (this);
		}

		public void Insert(int index, T row) { 
			database.Insert (index, row);
			EditorUtility.SetDirty (this);
		}

		public void Remove(T row) { 
			database.Remove (row);
			EditorUtility.SetDirty (this);
		}

		public int Count {
			get { return database.Count; }
		}

		public void Replace(int index, T row) {
			database [index] = row;
			EditorUtility.SetDirty (this);
		}

		public T Get(int index) {
			return database [index];
		}

		// Used to initialize the database used in various parts of our plugin
		public U GetDatabase<U>(string dbPath, string dbName) where U : ScriptableObject {
			string dbFullPath = @"Assets/" + dbPath + "/" + dbName;

			U database = AssetDatabase.LoadAssetAtPath (dbFullPath, typeof(U)) as U;

			if (database == null) {
				Debug.Log("Could not find Quality Database. Creating it now.");
				// Create our folder if it does not exist yet.
				if (!(AssetDatabase.IsValidFolder (@"Assets/" + dbPath))) {
					Debug.Log("Could not find Database Path. Creating it now.");
					AssetDatabase.CreateFolder(@"Assets/", dbPath);
				}

				database = ScriptableObject.CreateInstance<U>() as U;
				AssetDatabase.CreateAsset (database, dbFullPath);
				AssetDatabase.SaveAssets ();
				AssetDatabase.Refresh ();
			}

			return database;
		}

	}
}