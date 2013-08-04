using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using RegisterKeeper.Web.Models;

namespace RegisterKeeper.Web
{
	public static class Extensions
	{
		//public static List<T> ToList<T>(this T myEnum) where T : Enum
		//{
		//	var valueList = new List<T>();
		//	foreach (var value in Enum.GetValues(myEnum.GetType()).Cast<T>())
		//	{
		//		if (myEnum.)
		//		{

		//		}
		//	}

		//	return valueList;
		//}

		public static List<Distance> ToList(this Distance distances)
		{
			return Enum.GetValues(typeof(Distance)).Cast<Distance>().Where(value => distances.HasFlag(value)).ToList();
		}

		public static string DisplayValue(this Distance distance)
		{
			var distancesList = distance.ToList()
				.Select(d =>
					{
						var memberInfo = typeof(Distance).GetMember(d.ToString())[0];
						var attributes = memberInfo.GetCustomAttributes(typeof(DisplayAttribute), false);
						return ((DisplayAttribute)attributes[0]).Name;
					})
				.ToList();

			var distanceString = String.Empty;

			distancesList.Reverse();
			for (var i = 0; i < distancesList.Count; i += 1)
			{
				string addBit;
				switch (i)
				{
					case 0:
						addBit = distancesList[0];
						break;
					case 1:
						addBit = distancesList[1] + " and ";
						break;
					default:
						addBit = distancesList[i] + ", ";
						break;
				}
				distanceString = addBit + distanceString;
			}
			return distanceString;
		}

		//public static string DisplayValue(this Score? score)
		//{
		//	return score.HasValue ? score.Value.DisplayValue() : String.Empty;
		//}

		public static string DisplayValue(this Score score)
		{
			switch (score)
			{
				case Score.Zero:
					return "0";
				case Score.One:
					return "1";
				case Score.Two:
					return "2";
				case Score.Three:
					return "3";
				case Score.Four:
					return "4";
				case Score.Five:
					return "5";
				case Score.V:
					return "V";
				default:
					return String.Empty;
			}
		}


	}
}