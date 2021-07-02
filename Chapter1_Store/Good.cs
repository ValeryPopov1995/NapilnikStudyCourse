using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

namespace NapilnikStudyCourse.Chapter1_Store
{
	public class Good
	{
		public string Name {get; private set;}
		
		public Good(string name)
		{
			Name = name;
		}
	}
}
