using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Hooshyar.Utility
{
	public static class ExtentionMethodes
	{
		/// <summary>
		/// get description from enum
		/// </summary>
		/// <param name="enu"></param>
		/// <returns></returns>
		public static string GetDescription(this Enum enu)
		{
			Type type = enu.GetType();
			MemberInfo[] memberInfo = type.GetMember(enu.ToString());
			if (memberInfo.Length > 0)
			{
				object[] attrs = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
				if (attrs.Length > 0)
				{
					return ((DescriptionAttribute)attrs[0]).Description;
				}

			}
			return enu.ToString();
		}

		/// <summary>
		/// get integer number from enum
		/// </summary>
		/// <param name="enu"></param>
		/// <returns></returns>
		public static string GetCode(this Enum enu)
		{
			return enu.ToString("D");
		}
	}
}
