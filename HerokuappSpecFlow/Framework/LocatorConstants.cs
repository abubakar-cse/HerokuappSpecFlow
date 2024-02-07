using System;
namespace HerokuappSpecFlow.Framework
{
	public class LocatorConstants
	{
		public const string PreciseTextLocator = "//*[text() = '{0}']";
		public const string PartialTextLocator = "//*[contains(text(), '{0}')]";
	}
}

